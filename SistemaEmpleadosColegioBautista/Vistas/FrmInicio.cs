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
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Frm_Inicio formularioInicio = new Frm_Inicio();
            formularioInicio.Show();
            this.Hide(); // Oculta el formulario actual (opcional)
        }

        private void Btn_SalirdelSistema_Click(object sender, EventArgs e)
        {
            {
                var respuesta = MessageBox.Show("¿Seguro que deseas salir del sistema?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }

        private void Btn_RegistroEmpleado_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Frm_RegistroEmpleado formularioEmpleados = new Frm_RegistroEmpleado();

            formularioEmpleados.StartPosition = FormStartPosition.Manual;
            formularioEmpleados.Location = new Point(324, 66);

            // Mostrar el formulario
            formularioEmpleados.Show();
        }
    }
}
