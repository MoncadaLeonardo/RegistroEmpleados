using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleadosColegioBautista.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load; 
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Eliminar el evento si ya está asignado para evitar duplicación
            btnLogin.Click -= btnLogin_Click;
            btnLogin.Click += btnLogin_Click; // Asignamos el evento
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Contraseña))
            {
                MessageBox.Show("Ingrese el Usuario y la Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Usuario == "admin" && Contraseña == "1234")
            {
                Frm_Inicio formPrincipal = new Frm_Inicio();
                formPrincipal.Show();

                // Ocultar el formulario de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
