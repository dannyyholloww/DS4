
    namespace Parcial_2
    {
        partial class MainForm
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Button btnCalculate;
            private System.Windows.Forms.TextBox txtNumFiles;
            private System.Windows.Forms.TextBox txtFileSizeMB;
            private System.Windows.Forms.TextBox txtUSBSizeGB;
            private System.Windows.Forms.ListBox lstHistory;
            private System.Windows.Forms.Label lblNumFiles;
            private System.Windows.Forms.Label lblFileSizeMB;
            private System.Windows.Forms.Label lblUSBSizeGB;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.btnCalculate = new System.Windows.Forms.Button();
                this.txtNumFiles = new System.Windows.Forms.TextBox();
                this.txtFileSizeMB = new System.Windows.Forms.TextBox();
                this.txtUSBSizeGB = new System.Windows.Forms.TextBox();
                this.lstHistory = new System.Windows.Forms.ListBox();
                this.lblNumFiles = new System.Windows.Forms.Label();
                this.lblFileSizeMB = new System.Windows.Forms.Label();
                this.lblUSBSizeGB = new System.Windows.Forms.Label();
                this.SuspendLayout();

                // 
                // lblNumFiles
                // 
                this.lblNumFiles.AutoSize = true;
                this.lblNumFiles.Location = new System.Drawing.Point(20, 30);
                this.lblNumFiles.Name = "lblNumFiles";
                this.lblNumFiles.Size = new System.Drawing.Size(100, 13);
                this.lblNumFiles.TabIndex = 5;
                this.lblNumFiles.Text = "Número de archivos";
               

                // 
                // txtNumFiles
                // 
                this.txtNumFiles.Location = new System.Drawing.Point(150, 30);
                this.txtNumFiles.Name = "txtNumFiles";
                this.txtNumFiles.Size = new System.Drawing.Size(100, 20);
                this.txtNumFiles.TabIndex = 1;

                // 
                // lblFileSizeMB
                // 
                this.lblFileSizeMB.AutoSize = true;
                this.lblFileSizeMB.Location = new System.Drawing.Point(20, 60);
                this.lblFileSizeMB.Name = "lblFileSizeMB";
                this.lblFileSizeMB.Size = new System.Drawing.Size(114, 13);
                this.lblFileSizeMB.TabIndex = 6;
                this.lblFileSizeMB.Text = "Tamaño de archivo (MB)";

                // 
                // txtFileSizeMB
                // 
                this.txtFileSizeMB.Location = new System.Drawing.Point(150, 60);
                this.txtFileSizeMB.Name = "txtFileSizeMB";
                this.txtFileSizeMB.Size = new System.Drawing.Size(100, 20);
                this.txtFileSizeMB.TabIndex = 2;

                // 
                // lblUSBSizeGB
                // 
                this.lblUSBSizeGB.AutoSize = true;
                this.lblUSBSizeGB.Location = new System.Drawing.Point(20, 90);
                this.lblUSBSizeGB.Name = "lblUSBSizeGB";
                this.lblUSBSizeGB.Size = new System.Drawing.Size(100, 13);
                this.lblUSBSizeGB.TabIndex = 7;
                this.lblUSBSizeGB.Text = "Tamaño del USB (GB)";

                // 
                // txtUSBSizeGB
                // 
                this.txtUSBSizeGB.Location = new System.Drawing.Point(150, 90);
                this.txtUSBSizeGB.Name = "txtUSBSizeGB";
                this.txtUSBSizeGB.Size = new System.Drawing.Size(100, 20);
                this.txtUSBSizeGB.TabIndex = 3;

                // 
                // btnCalculate
                // 
                this.btnCalculate.Location = new System.Drawing.Point(150, 130);
                this.btnCalculate.Name = "btnCalculate";
                this.btnCalculate.Size = new System.Drawing.Size(75, 23);
                this.btnCalculate.TabIndex = 0;
                this.btnCalculate.Text = "Calcular";
                this.btnCalculate.UseVisualStyleBackColor = true;
                this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

                // 
                // lstHistory
                // 
                this.lstHistory.FormattingEnabled = true;
                this.lstHistory.Location = new System.Drawing.Point(20, 170);
                this.lstHistory.Name = "lstHistory";
                this.lstHistory.Size = new System.Drawing.Size(230, 95);
                this.lstHistory.TabIndex = 4;

                // 
                // MainForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Controls.Add(this.lblNumFiles);
                this.Controls.Add(this.lblFileSizeMB);
                this.Controls.Add(this.lblUSBSizeGB);
                this.Controls.Add(this.lstHistory);
                this.Controls.Add(this.txtUSBSizeGB);
                this.Controls.Add(this.txtFileSizeMB);
                this.Controls.Add(this.txtNumFiles);
                this.Controls.Add(this.btnCalculate);
                this.Name = "MainForm";
                this.Text = "Calculadora de Archivos en USB";
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }



