using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CreditAdviceAndSavingsSimulator.Services
{
    public class CreditAdviceService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public CreditAdviceService(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _apiKey = configuration["OpenAI:ApiKey"]
                ?? throw new Exception("La API Key no está configurada correctamente en appsettings.json");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<string> GetCreditAdvice(string prompt)
        {
            try
            {
                var requestBody = new
                {
                    model = "gpt-3.5-turbo",
                    messages = new[]
                    {
                new { role = "system", content = "You are a helpful assistant." },
                new { role = "user", content = prompt }
            },
                    max_tokens = 150,
                    temperature = 0.7
                };

                var requestContent = new StringContent(
                    JsonSerializer.Serialize(requestBody),
                    Encoding.UTF8,
                    "application/json"
                );

                var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", requestContent);
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<dynamic>(responseString);
                return data.choices[0].message.content.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al realizar la solicitud a OpenAI: {ex.Message}");
            }
        }
    }
}
