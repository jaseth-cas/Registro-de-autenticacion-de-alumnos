namespace WindowsFormsApp2
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAcceso = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.Lblacc = new System.Windows.Forms.Label();
            this.btnIng = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Cmbxrol = new System.Windows.Forms.ComboBox();
            this.TxtbxContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAcceso
            // 
            this.LblAcceso.AutoSize = true;
            this.LblAcceso.Location = new System.Drawing.Point(169, 53);
            this.LblAcceso.Name = "LblAcceso";
            this.LblAcceso.Size = new System.Drawing.Size(117, 16);
            this.LblAcceso.TabIndex = 0;
            this.LblAcceso.Text = "Acceso al sistema";
            this.LblAcceso.Click += new System.EventHandler(this.LblAcceso_Click);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(41, 128);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(101, 16);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo de usuario";
            this.LblTipo.Click += new System.EventHandler(this.LblTipo_Click);
            // 
            // Lblacc
            // 
            this.Lblacc.AutoSize = true;
            this.Lblacc.Location = new System.Drawing.Point(41, 185);
            this.Lblacc.Name = "Lblacc";
            this.Lblacc.Size = new System.Drawing.Size(118, 16);
            this.Lblacc.TabIndex = 2;
            this.Lblacc.Text = "Código de acceso";
            // 
            // btnIng
            // 
            this.btnIng.Location = new System.Drawing.Point(84, 275);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(90, 34);
            this.btnIng.TabIndex = 3;
            this.btnIng.Text = "Ingresar";
            this.btnIng.UseVisualStyleBackColor = true;
            this.btnIng.Click += new System.EventHandler(this.btnIng_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(271, 275);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(85, 34);
            this.Btnsalir.TabIndex = 4;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Cmbxrol
            // 
            this.Cmbxrol.FormattingEnabled = true;
            this.Cmbxrol.Items.AddRange(new object[] {
            "Administrador",
            "Profesor"});
            this.Cmbxrol.Location = new System.Drawing.Point(235, 125);
            this.Cmbxrol.Name = "Cmbxrol";
            this.Cmbxrol.Size = new System.Drawing.Size(121, 24);
            this.Cmbxrol.TabIndex = 5;
            this.Cmbxrol.Text = "Administrador";
            this.Cmbxrol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtbxContra
            // 
            this.TxtbxContra.Location = new System.Drawing.Point(235, 185);
            this.TxtbxContra.Name = "TxtbxContra";
            this.TxtbxContra.Size = new System.Drawing.Size(121, 22);
            this.TxtbxContra.TabIndex = 6;
            this.TxtbxContra.TextChanged += new System.EventHandler(this.TxtbxContra_TextChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 393);
            this.Controls.Add(this.TxtbxContra);
            this.Controls.Add(this.Cmbxrol);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.btnIng);
            this.Controls.Add(this.Lblacc);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblAcceso);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAcceso;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label Lblacc;
        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.ComboBox Cmbxrol;
        private System.Windows.Forms.TextBox TxtbxContra;
    }
}