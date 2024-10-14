namespace Laboratorio_14
{
    partial class formproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formproductos));
            tsbnuevo = new PictureBox();
            tsbguardar = new PictureBox();
            tsbcancelar = new PictureBox();
            tsbeliminar = new PictureBox();
            tsbid = new TextBox();
            tsbbuscar = new PictureBox();
            txtid = new TextBox();
            txtprecio = new TextBox();
            txtnombre = new TextBox();
            txtstock = new TextBox();
            ID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnsalir = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tsbnuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbguardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbcancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbeliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbbuscar).BeginInit();
            SuspendLayout();
            // 
            // tsbnuevo
            // 
            tsbnuevo.Image = Properties.Resources.nuevo;
            tsbnuevo.Location = new Point(12, 12);
            tsbnuevo.Name = "tsbnuevo";
            tsbnuevo.Size = new Size(30, 34);
            tsbnuevo.SizeMode = PictureBoxSizeMode.Zoom;
            tsbnuevo.TabIndex = 1;
            tsbnuevo.TabStop = false;
            tsbnuevo.Click += tsbnuevo_Click;
            // 
            // tsbguardar
            // 
            tsbguardar.Image = Properties.Resources.guardar;
            tsbguardar.Location = new Point(48, 12);
            tsbguardar.Name = "tsbguardar";
            tsbguardar.Size = new Size(30, 34);
            tsbguardar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbguardar.TabIndex = 2;
            tsbguardar.TabStop = false;
            tsbguardar.Click += tsbguardar_Click_1;
            // 
            // tsbcancelar
            // 
            tsbcancelar.Image = Properties.Resources.cancelar;
            tsbcancelar.Location = new Point(84, 12);
            tsbcancelar.Name = "tsbcancelar";
            tsbcancelar.Size = new Size(30, 34);
            tsbcancelar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbcancelar.TabIndex = 3;
            tsbcancelar.TabStop = false;
            tsbcancelar.Click += tsbcancelar_Click;
            // 
            // tsbeliminar
            // 
            tsbeliminar.Image = Properties.Resources.eliminar;
            tsbeliminar.Location = new Point(120, 12);
            tsbeliminar.Name = "tsbeliminar";
            tsbeliminar.Size = new Size(30, 34);
            tsbeliminar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbeliminar.TabIndex = 4;
            tsbeliminar.TabStop = false;
            tsbeliminar.Click += tsbeliminar_Click;
            // 
            // tsbid
            // 
            tsbid.Font = new Font("Segoe UI", 14F);
            tsbid.Location = new Point(272, 12);
            tsbid.Multiline = true;
            tsbid.Name = "tsbid";
            tsbid.Size = new Size(107, 34);
            tsbid.TabIndex = 5;
            // 
            // tsbbuscar
            // 
            tsbbuscar.Image = (Image)resources.GetObject("tsbbuscar.Image");
            tsbbuscar.Location = new Point(385, 12);
            tsbbuscar.Name = "tsbbuscar";
            tsbbuscar.Size = new Size(30, 34);
            tsbbuscar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbbuscar.TabIndex = 6;
            tsbbuscar.TabStop = false;
            tsbbuscar.Click += tsbbuscar_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(32, 120);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(118, 40);
            txtid.TabIndex = 7;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(32, 221);
            txtprecio.Multiline = true;
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(118, 40);
            txtprecio.TabIndex = 8;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(247, 120);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(222, 40);
            txtnombre.TabIndex = 9;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(247, 221);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(118, 40);
            txtstock.TabIndex = 10;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 11F);
            ID.Location = new Point(32, 86);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 11;
            ID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(32, 188);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 12;
            label1.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(247, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(247, 188);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 14;
            label3.Text = "Stock";
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 15F);
            btnsalir.Location = new Point(32, 317);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(96, 41);
            btnsalir.TabIndex = 15;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(167, 19);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 16;
            label4.Text = "Buscar por id:";
            // 
            // formproductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnsalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(txtstock);
            Controls.Add(txtnombre);
            Controls.Add(txtprecio);
            Controls.Add(txtid);
            Controls.Add(tsbbuscar);
            Controls.Add(tsbid);
            Controls.Add(tsbeliminar);
            Controls.Add(tsbcancelar);
            Controls.Add(tsbguardar);
            Controls.Add(tsbnuevo);
            Name = "formproductos";
            Text = "Form1";
            Load += formproductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbnuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbguardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbcancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbeliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbbuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tsbnuevo;
        private PictureBox tsbguardar;
        private PictureBox tsbcancelar;
        private PictureBox tsbeliminar;
        private TextBox tsbid;
        private PictureBox tsbbuscar;
        private TextBox txtid;
        private TextBox txtprecio;
        private TextBox txtnombre;
        private TextBox txtstock;
        private Label ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnsalir;
        private Label label4;
    }
}
