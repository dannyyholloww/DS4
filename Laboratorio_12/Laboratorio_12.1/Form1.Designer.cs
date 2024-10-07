using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio_12.1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            box_velocidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            box_tiempo = new TextBox();
            respuesta_box = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Laboratorio 12.1 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(126, 55);
            label2.Name = "label2";
            label2.Size = new Size(355, 45);
            label2.TabIndex = 1;
            label2.Text = "El siguiente ejercicio nos pedira ingrear la velocidad de un movil\r\ny el tiempo usado por el movil, calcularemos la distancia recorrida\r\n y mostraremos el resultado del total de la distancia recorrdia";
            // 
            // box_velocidad
            // 
            box_velocidad.Location = new Point(331, 159);
            box_velocidad.Name = "box_velocidad";
            box_velocidad.Size = new Size(100, 23);
            box_velocidad.TabIndex = 2;
            box_velocidad.TextChanged += box_velocidad_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 162);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 3;
            label3.Text = "Velocidad del movil (km)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 216);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 5;
            label4.Text = "Tiempo usado por el movil (horas)";
            // 
            // box_tiempo
            // 
            box_tiempo.Location = new Point(331, 213);
            box_tiempo.Name = "box_tiempo";
            box_tiempo.Size = new Size(100, 23);
            box_tiempo.TabIndex = 4;
            box_tiempo.TextChanged += box_tiempo_TextChanged;
            // 
            // respuesta_box
            // 
            respuesta_box.Location = new Point(232, 350);
            respuesta_box.Name = "respuesta_box";
            respuesta_box.Size = new Size(100, 23);
            respuesta_box.TabIndex = 6;
            respuesta_box.TextChanged += respuesta_box_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 315);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Respuesta";
            // 
            // button1
            // 
            button1.Location = new Point(344, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(respuesta_box);
            Controls.Add(label4);
            Controls.Add(box_tiempo);
            Controls.Add(label3);
            Controls.Add(box_velocidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "X";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox box_velocidad;
        private Label label3;
        private Label label4;
        private TextBox box_tiempo;
        private TextBox respuesta_box;
        private Label label5;
        private Button button1;
    }
}