using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio_12.3
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
            ladoabox = new TextBox();
            ladobbox = new TextBox();
            label2 = new Label();
            ladocbox = new TextBox();
            label3 = new Label();
            semiperbtn = new Button();
            areabtn = new Button();
            borrarbtn = new Button();
            salirbtn = new Button();
            semiperbox = new TextBox();
            label4 = new Label();
            areabox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la longitud del lado A";
            // 
            // ladoabox
            // 
            ladoabox.Location = new Point(262, 49);
            ladoabox.Margin = new Padding(3, 4, 3, 4);
            ladoabox.Name = "ladoabox";
            ladoabox.Size = new Size(114, 26);
            ladoabox.TabIndex = 1;
            // 
            // ladobbox
            // 
            ladobbox.Location = new Point(262, 93);
            ladobbox.Margin = new Padding(3, 4, 3, 4);
            ladobbox.Name = "ladobbox";
            ladobbox.Size = new Size(114, 26);
            ladobbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(39, 95);
            label2.Name = "label2";
            label2.Size = new Size(205, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la longitud del lado B";
            // 
            // ladocbox
            // 
            ladocbox.Location = new Point(262, 138);
            ladocbox.Margin = new Padding(3, 4, 3, 4);
            ladocbox.Name = "ladocbox";
            ladocbox.Size = new Size(114, 26);
            ladocbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(39, 140);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 4;
            label3.Text = "Ingrese la longitud del lado C";
            // 
            // semiperbtn
            // 
            semiperbtn.Location = new Point(42, 226);
            semiperbtn.Name = "semiperbtn";
            semiperbtn.Size = new Size(107, 52);
            semiperbtn.TabIndex = 6;
            semiperbtn.Text = "SemiPerimetro";
            semiperbtn.UseVisualStyleBackColor = true;
            semiperbtn.Click += semiperbtn_Click;
            // 
            // areabtn
            // 
            areabtn.Location = new Point(184, 226);
            areabtn.Name = "areabtn";
            areabtn.Size = new Size(107, 52);
            areabtn.TabIndex = 7;
            areabtn.Text = "Area";
            areabtn.UseVisualStyleBackColor = true;
            areabtn.Click += areabtn_Click;
            // 
            // borrarbtn
            // 
            borrarbtn.Location = new Point(42, 303);
            borrarbtn.Name = "borrarbtn";
            borrarbtn.Size = new Size(107, 52);
            borrarbtn.TabIndex = 8;
            borrarbtn.Text = "Borrar";
            borrarbtn.UseVisualStyleBackColor = true;
            borrarbtn.Click += borrarbtn_Click;
            // 
            // salirbtn
            // 
            salirbtn.Location = new Point(184, 303);
            salirbtn.Name = "salirbtn";
            salirbtn.Size = new Size(107, 52);
            salirbtn.TabIndex = 9;
            salirbtn.Text = "Salir";
            salirbtn.UseVisualStyleBackColor = true;
            salirbtn.Click += salirbtn_Click;
            // 
            // semiperbox
            // 
            semiperbox.Location = new Point(567, 274);
            semiperbox.Margin = new Padding(3, 4, 3, 4);
            semiperbox.Name = "semiperbox";
            semiperbox.Size = new Size(114, 26);
            semiperbox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(383, 280);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 10;
            label4.Text = "Calcular SemiPerimetro";
            // 
            // areabox
            // 
            areabox.Location = new Point(567, 329);
            areabox.Margin = new Padding(3, 4, 3, 4);
            areabox.Name = "areabox";
            areabox.Size = new Size(114, 26);
            areabox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(415, 331);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 12;
            label5.Text = "Area del Triángulo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 570);
            Controls.Add(areabox);
            Controls.Add(label5);
            Controls.Add(semiperbox);
            Controls.Add(label4);
            Controls.Add(salirbtn);
            Controls.Add(borrarbtn);
            Controls.Add(areabtn);
            Controls.Add(semiperbtn);
            Controls.Add(ladocbox);
            Controls.Add(label3);
            Controls.Add(ladobbox);
            Controls.Add(label2);
            Controls.Add(ladoabox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.5F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ladoabox;
        private TextBox ladobbox;
        private Label label2;
        private TextBox ladocbox;
        private Label label3;
        private Button semiperbtn;
        private Button areabtn;
        private Button borrarbtn;
        private Button salirbtn;
        private TextBox semiperbox;
        private Label label4;
        private TextBox areabox;
        private Label label5;
    }
}