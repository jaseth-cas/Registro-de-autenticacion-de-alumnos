using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Atajos
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            // Eventos
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            txtNombre.Validating += txtNombre_Validating;
            txtCedula.Validating += txtCedula_Validating;

            // Menú
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            acerdaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicio de sesión
            string codigo = Interaction.InputBox("Ingrese el código del administrador/profesor:", "Inicio de sesión", "");
            if (codigo != "1234")
            {
                MessageBox.Show("Código incorrecto. El programa se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Llenar combos
            cmbCarrera.Items.AddRange(new string[] { "Ingeniería", "Medicina", "Derecho" });
            cmbSemestre.Items.AddRange(new string[] { "1er Semestre", "2do Semestre", "3er Semestre" });

            txtContraseña.PasswordChar = '*';
            txtContraseña.MaxLength = 12;
            txtUsuario.ReadOnly = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            GenerarUsuario();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria.", "Advertencia");
                e.Cancel = true;
            }
            else
                GenerarUsuario();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Advertencia");
                e.Cancel = true;
            }
        }

        private void GenerarUsuario()
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();

            if (nombre.Length > 0 && cedula.Length > 0)
            {
                txtUsuario.Text = nombre.Substring(0, 1).ToLower() + cedula;
            }
            else
            {
                txtUsuario.Text = "";
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Nombre y cédula son obligatorios.");
                return false;
            }

            if (!chkTerminos.Checked)
            {
                MessageBox.Show("Debe aceptar los términos.");
                return false;
            }

            if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            if (txtContraseña.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                return false;
            }

            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("No se pudo generar el usuario.");
                return false;
            }

            return true;
        }

        private void GuardarAlumno()
        {
            if (!ValidarCampos()) return;

            string jornada = rbMatutina.Checked ? "Matutina" :
                             rbVespertina.Checked ? "Vespertina" : "No seleccionada";

            string alumno = $"Nombre: {txtNombre.Text}, Cédula: {txtCedula.Text}, Usuario: {txtUsuario.Text}, " +
                            $"Carrera: {cmbCarrera.Text}, Semestre: {cmbSemestre.Text}, Jornada: {jornada}, " +
                            $"Notificaciones: {(chkNotificaciones.Checked ? "Sí" : "No")}";

            lstAlumnos.Items.Add(alumno);
            MessageBox.Show("Alumno registrado con éxito.", "Éxito");

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmar.Clear();
            cmbCarrera.SelectedIndex = -1;
            cmbSemestre.SelectedIndex = -1;
            rbMatutina.Checked = false;
            rbVespertina.Checked = false;
            chkTerminos.Checked = false;
            chkNotificaciones.Checked = false;
            txtNombre.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                GuardarAlumno();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                LimpiarCampos();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarAlumno();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Alexandra De Gracia\nVersión: 1.0", "Acerca de");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


