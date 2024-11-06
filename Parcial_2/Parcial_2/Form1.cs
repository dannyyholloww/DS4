using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial_2
{
   
        public partial class MainForm : Form
        {
            private List<string> history;

            public MainForm()
            {
                InitializeComponent();
                history = new List<string>();
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    int numFiles = int.Parse(txtNumFiles.Text);
                    double fileSizeMB = double.Parse(txtFileSizeMB.Text);
                    double usbSizeGB = double.Parse(txtUSBSizeGB.Text);

                    // Convertimos de GB a MB para hacer las comparaciones
                    double totalFileSizeMB = numFiles * fileSizeMB;
                    double usbSizeMB = usbSizeGB * 1024;

                    if (totalFileSizeMB <= usbSizeMB)
                    {
                        string result = $"Puedes almacenar {numFiles} archivos de {fileSizeMB} MB en un USB de {usbSizeGB} GB";
                        MessageBox.Show(result, "Resultado");
                        history.Add(result);
                    }
                    else
                    {
                        // Calcular el espacio adicional necesario
                        double additionalSpaceMB = totalFileSizeMB - usbSizeMB;
                        double additionalSpaceGB = additionalSpaceMB / 1024; // Convertir a GB para mostrarlo en el mensaje
                        string result = $"No puedes almacenar {numFiles} archivos de {fileSizeMB} MB en un USB de {usbSizeGB} GB.\n" +
                                        $"Te pasaste por {additionalSpaceMB:F2} MB ({additionalSpaceGB:F2} GB).";
  
                        MessageBox.Show(result, "Resultado");
                        history.Add(result);
                    }

                    UpdateHistory();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos", "Error de Formato");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Excepción");
                }
            }

            private void UpdateHistory()
            {
                lstHistory.Items.Clear();
                foreach (var record in history)
                {
                    lstHistory.Items.Add(record);
                }
            }
        }
    }




