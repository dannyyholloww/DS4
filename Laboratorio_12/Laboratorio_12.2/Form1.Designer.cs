using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio_12.2
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
            nota_uno_box = new TextBox();
            nota_dos_box = new TextBox();
            label3 = new Label();
            nota_tres_box = new TextBox();
            label4 = new Label();
            promedio_btn = new Button();
            borrar_btn = new Button();
            salir_btn = new Button();
            resultado_box = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(172, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "NOTA No. 1";
            // 
            // nota_uno_box
            // 
            nota_uno_box.Location = new Point(288, 81);
            nota_uno_box.Name = "nota_uno_box";
            nota_uno_box.Size = new Size(100, 23);
            nota_uno_box.TabIndex = 2;
            // 
            // nota_dos_box
            // 
            nota_dos_box.Location = new Point(288, 121);
            nota_dos_box.Name = "nota_dos_box";
            nota_dos_box.Size = new Size(100, 23);
            nota_dos_box.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(172, 123);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 3;
            label3.Text = "NOTA No. 2";
            // 
            // nota_tres_box
            // 
            nota_tres_box.Location = new Point(288, 159);
            nota_tres_box.Name = "nota_tres_box";
            nota_tres_box.Size = new Size(100, 23);
            nota_tres_box.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(172, 161);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 5;
            label4.Text = "NOTA No. 3";
            // 
            // promedio_btn
            // 
            promedio_btn.Location = new Point(103, 223);
            promedio_btn.Name = "promedio_btn";
            promedio_btn.Size = new Size(75, 23);
            promedio_btn.TabIndex = 7;
            promedio_btn.Text = "Promedio";
            promedio_btn.UseVisualStyleBackColor = true;
            promedio_btn.Click += promedio_btn_Click;
            // 
            // borrar_btn
            // 
            borrar_btn.Location = new Point(239, 223);
            borrar_btn.Name = "borrar_btn";
            borrar_btn.Size = new Size(75, 23);
            borrar_btn.TabIndex = 8;
            borrar_btn.Text = "Borrar";
            borrar_btn.UseVisualStyleBackColor = true;
            borrar_btn.Click += borrar_btn_Click;
            // 
            // salir_btn
            // 
            salir_btn.Location = new Point(395, 223);
            salir_btn.Name = "salir_btn";
            salir_btn.Size = new Size(75, 23);
            salir_btn.TabIndex = 9;
            salir_btn.Text = "Salir";
            salir_btn.UseVisualStyleBackColor = true;
            salir_btn.Click += salir_btn_Click;
            // 
            // resultado_box
            // 
            resultado_box.Location = new Point(297, 307);
            resultado_box.Name = "resultado_box";
            resultado_box.Size = new Size(100, 23);
            resultado_box.TabIndex = 11;
            resultado_box.TextChanged += resultado_box_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(172, 311);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 10;
            label5.Text = "Nota Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(resultado_box);
            Controls.Add(label5);
            Controls.Add(salir_btn);
            Controls.Add(borrar_btn);
            Controls.Add(promedio_btn);
            Controls.Add(nota_tres_box);
            Controls.Add(label4);
            Controls.Add(nota_dos_box);
            Controls.Add(label3);
            Controls.Add(nota_uno_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nota_uno_box;
        private TextBox nota_dos_box;
        private Label label3;
        private TextBox nota_tres_box;
        private Label label4;
        private Button promedio_btn;
        private Button borrar_btn;
        private Button salir_btn;
        private TextBox resultado_box;
        private Label label5;
    }
}