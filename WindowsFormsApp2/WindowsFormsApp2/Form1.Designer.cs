using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Lblusu = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Lblcontr = new System.Windows.Forms.Label();
            this.GpBxCrede = new System.Windows.Forms.GroupBox();
            this.Lblconf = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lblnomb = new System.Windows.Forms.Label();
            this.Lblced = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.Lblcarre = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.Lblsemes = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.rbMatutina = new System.Windows.Forms.RadioButton();
            this.rbVespertina = new System.Windows.Forms.RadioButton();
            this.chkTerminos = new System.Windows.Forms.CheckBox();
            this.chkNotificaciones = new System.Windows.Forms.CheckBox();
            this.GpbxAlum = new System.Windows.Forms.GroupBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnnuv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnguar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnslr = new System.Windows.Forms.ToolStripMenuItem();
            this.btnacercade = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnuopcion = new System.Windows.Forms.MenuStrip();
            this.GpBxalumnos = new System.Windows.Forms.GroupBox();
            this.GpBxCrede.SuspendLayout();
            this.GpbxAlum.SuspendLayout();
            this.Mnuopcion.SuspendLayout();
            this.GpBxalumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(100, 70);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // Lblusu
            // 
            this.Lblusu.AutoSize = true;
            this.Lblusu.Location = new System.Drawing.Point(27, 35);
            this.Lblusu.Name = "Lblusu";
            this.Lblusu.Size = new System.Drawing.Size(54, 16);
            this.Lblusu.TabIndex = 6;
            this.Lblusu.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(100, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // Lblcontr
            // 
            this.Lblcontr.AutoSize = true;
            this.Lblcontr.Location = new System.Drawing.Point(21, 76);
            this.Lblcontr.Name = "Lblcontr";
            this.Lblcontr.Size = new System.Drawing.Size(76, 16);
            this.Lblcontr.TabIndex = 7;
            this.Lblcontr.Text = "Contraseña";
            // 
            // GpBxCrede
            // 
            this.GpBxCrede.Controls.Add(this.Lblconf);
            this.GpBxCrede.Controls.Add(this.Lblcontr);
            this.GpBxCrede.Controls.Add(this.Lblusu);
            this.GpBxCrede.Controls.Add(this.txtConfirmar);
            this.GpBxCrede.Controls.Add(this.label7);
            this.GpBxCrede.Controls.Add(this.txtContraseña);
            this.GpBxCrede.Controls.Add(this.label6);
            this.GpBxCrede.Controls.Add(this.txtUsuario);
            this.GpBxCrede.Controls.Add(this.label5);
            this.GpBxCrede.Location = new System.Drawing.Point(112, 352);
            this.GpBxCrede.Name = "GpBxCrede";
            this.GpBxCrede.Size = new System.Drawing.Size(300, 200);
            this.GpBxCrede.TabIndex = 1;
            this.GpBxCrede.TabStop = false;
            this.GpBxCrede.Text = "Credenciales";
            // 
            // Lblconf
            // 
            this.Lblconf.AutoSize = true;
            this.Lblconf.Location = new System.Drawing.Point(27, 117);
            this.Lblconf.Name = "Lblconf";
            this.Lblconf.Size = new System.Drawing.Size(64, 16);
            this.Lblconf.TabIndex = 8;
            this.Lblconf.Text = "Confirmar";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(100, 110);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmar.TabIndex = 0;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirmar:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario:";
            // 
            // Lblnomb
            // 
            this.Lblnomb.Location = new System.Drawing.Point(10, 20);
            this.Lblnomb.Name = "Lblnomb";
            this.Lblnomb.Size = new System.Drawing.Size(100, 23);
            this.Lblnomb.TabIndex = 12;
            this.Lblnomb.Text = "Nombre:";
            // 
            // Lblced
            // 
            this.Lblced.Location = new System.Drawing.Point(10, 60);
            this.Lblced.Name = "Lblced";
            this.Lblced.Size = new System.Drawing.Size(100, 23);
            this.Lblced.TabIndex = 10;
            this.Lblced.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(80, 60);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(144, 22);
            this.txtCedula.TabIndex = 9;
            // 
            // Lblcarre
            // 
            this.Lblcarre.Location = new System.Drawing.Point(10, 100);
            this.Lblcarre.Name = "Lblcarre";
            this.Lblcarre.Size = new System.Drawing.Size(100, 23);
            this.Lblcarre.TabIndex = 8;
            this.Lblcarre.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.Location = new System.Drawing.Point(80, 100);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(144, 24);
            this.cmbCarrera.TabIndex = 7;
            // 
            // Lblsemes
            // 
            this.Lblsemes.Location = new System.Drawing.Point(10, 140);
            this.Lblsemes.Name = "Lblsemes";
            this.Lblsemes.Size = new System.Drawing.Size(100, 23);
            this.Lblsemes.TabIndex = 6;
            this.Lblsemes.Text = "Semestre:";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.Enabled = false;
            this.cmbSemestre.Location = new System.Drawing.Point(80, 140);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(144, 24);
            this.cmbSemestre.TabIndex = 5;
            // 
            // rbMatutina
            // 
            this.rbMatutina.Location = new System.Drawing.Point(120, 180);
            this.rbMatutina.Name = "rbMatutina";
            this.rbMatutina.Size = new System.Drawing.Size(104, 24);
            this.rbMatutina.TabIndex = 4;
            this.rbMatutina.Text = "Matutina";
            // 
            // rbVespertina
            // 
            this.rbVespertina.Location = new System.Drawing.Point(10, 180);
            this.rbVespertina.Name = "rbVespertina";
            this.rbVespertina.Size = new System.Drawing.Size(104, 24);
            this.rbVespertina.TabIndex = 3;
            this.rbVespertina.Text = "Vespertina";
            // 
            // chkTerminos
            // 
            this.chkTerminos.Location = new System.Drawing.Point(10, 225);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(104, 24);
            this.chkTerminos.TabIndex = 2;
            this.chkTerminos.Text = "Acepto términos";
            // 
            // chkNotificaciones
            // 
            this.chkNotificaciones.Location = new System.Drawing.Point(150, 225);
            this.chkNotificaciones.Name = "chkNotificaciones";
            this.chkNotificaciones.Size = new System.Drawing.Size(104, 24);
            this.chkNotificaciones.TabIndex = 1;
            this.chkNotificaciones.Text = "Notificaciones";
            // 
            // GpbxAlum
            // 
            this.GpbxAlum.Controls.Add(this.chkNotificaciones);
            this.GpbxAlum.Controls.Add(this.chkTerminos);
            this.GpbxAlum.Controls.Add(this.rbVespertina);
            this.GpbxAlum.Controls.Add(this.rbMatutina);
            this.GpbxAlum.Controls.Add(this.cmbSemestre);
            this.GpbxAlum.Controls.Add(this.Lblsemes);
            this.GpbxAlum.Controls.Add(this.cmbCarrera);
            this.GpbxAlum.Controls.Add(this.Lblcarre);
            this.GpbxAlum.Controls.Add(this.txtCedula);
            this.GpbxAlum.Controls.Add(this.Lblced);
            this.GpbxAlum.Controls.Add(this.txtNombre);
            this.GpbxAlum.Controls.Add(this.Lblnomb);
            this.GpbxAlum.Location = new System.Drawing.Point(112, 60);
            this.GpbxAlum.Name = "GpbxAlum";
            this.GpbxAlum.Size = new System.Drawing.Size(300, 260);
            this.GpbxAlum.TabIndex = 0;
            this.GpbxAlum.TabStop = false;
            this.GpbxAlum.Text = "Datos del Alumno";
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.ItemHeight = 16;
            this.lstAlumnos.Location = new System.Drawing.Point(10, 30);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(342, 180);
            this.lstAlumnos.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // btnnuv
            // 
            this.btnnuv.Name = "btnnuv";
            this.btnnuv.Size = new System.Drawing.Size(66, 24);
            this.btnnuv.Text = "Nuevo";
            this.btnnuv.Click += new System.EventHandler(this.btnnuv_Click);
            // 
            // btnguar
            // 
            this.btnguar.Name = "btnguar";
            this.btnguar.Size = new System.Drawing.Size(76, 24);
            this.btnguar.Text = "Guardar";
            this.btnguar.Click += new System.EventHandler(this.btnguar_Click);
            // 
            // btnslr
            // 
            this.btnslr.Name = "btnslr";
            this.btnslr.Size = new System.Drawing.Size(52, 24);
            this.btnslr.Text = "Salir";
            this.btnslr.Click += new System.EventHandler(this.btnslr_Click);
            // 
            // btnacercade
            // 
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(89, 24);
            this.btnacercade.Text = "Acerca de";
            this.btnacercade.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // Mnuopcion
            // 
            this.Mnuopcion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mnuopcion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuv,
            this.btnguar,
            this.btnslr,
            this.btnacercade});
            this.Mnuopcion.Location = new System.Drawing.Point(0, 0);
            this.Mnuopcion.Name = "Mnuopcion";
            this.Mnuopcion.Size = new System.Drawing.Size(601, 28);
            this.Mnuopcion.TabIndex = 2;
            // 
            // GpBxalumnos
            // 
            this.GpBxalumnos.Controls.Add(this.lstAlumnos);
            this.GpBxalumnos.Location = new System.Drawing.Point(112, 594);
            this.GpBxalumnos.Name = "GpBxalumnos";
            this.GpBxalumnos.Size = new System.Drawing.Size(358, 216);
            this.GpBxalumnos.TabIndex = 3;
            this.GpBxalumnos.TabStop = false;
            this.GpBxalumnos.Text = "Lista de Alumnos";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(601, 846);
            this.Controls.Add(this.GpBxalumnos);
            this.Controls.Add(this.GpbxAlum);
            this.Controls.Add(this.GpBxCrede);
            this.Controls.Add(this.Mnuopcion);
            this.MainMenuStrip = this.Mnuopcion;
            this.Name = "Form1";
            this.Text = "Registro de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GpBxCrede.ResumeLayout(false);
            this.GpBxCrede.PerformLayout();
            this.GpbxAlum.ResumeLayout(false);
            this.GpbxAlum.PerformLayout();
            this.Mnuopcion.ResumeLayout(false);
            this.Mnuopcion.PerformLayout();
            this.GpBxalumnos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtContraseña;
        private Label Lblusu;
        private TextBox txtUsuario;
        private Label Lblcontr;
        private GroupBox GpBxCrede;
        private Label Lblconf;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtConfirmar;
        private Label Lblnomb;
        private Label Lblced;
        private TextBox txtCedula;
        private Label Lblcarre;
        private ComboBox cmbCarrera;
        private Label Lblsemes;
        private ComboBox cmbSemestre;
        private RadioButton rbMatutina;
        private RadioButton rbVespertina;
        private CheckBox chkTerminos;
        private CheckBox chkNotificaciones;
        private GroupBox GpbxAlum;
        private ListBox lstAlumnos;
        private TextBox txtNombre;
        private ToolStripMenuItem btnnuv;
        private ToolStripMenuItem btnguar;
        private ToolStripMenuItem btnslr;
        private ToolStripMenuItem btnacercade;
        private MenuStrip Mnuopcion;
        private GroupBox GpBxalumnos;
    }
}


