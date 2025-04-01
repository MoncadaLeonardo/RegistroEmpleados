using System;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace SistemaEmpleadosColegioBautista.Vistas
{
    public partial class Frm_RegistroEmpleado : Form
    {
        //private EmpleadoController _empleadoController;
        private int empleadoSeleccionadoId = -1; // Para saber si estamos editando un empleado

        public Frm_RegistroEmpleado()
        {
            InitializeComponent();
            //_empleadoController = new EmpleadoController();
        }

        private void Frm_RegistroEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarAreas();
        }

        private void CargarAreas()
        {
            //try
            //{
            //    DataTable dtAreas = _empleadoController.ObtenerAreas();
            //    if (dtAreas == null || dtAreas.Rows.Count == 0)
            //    {
            //        MessageBox.Show("No se encontraron áreas en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    cb_Area.DataSource = dtAreas;
            //    cb_Area.DisplayMember = "NombreArea";
            //    cb_Area.ValueMember = "IdArea";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar áreas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            empleadoSeleccionadoId = -1;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (string.IsNullOrWhiteSpace(tb_Nombre.Text) ||
            //        string.IsNullOrWhiteSpace(tb_Correo.Text) ||
            //        string.IsNullOrWhiteSpace(tb_Telefono.Text) ||
            //        string.IsNullOrWhiteSpace(tb_Cedula.Text) ||
            //        cb_Area.SelectedValue == null)
            //    {
            //        MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    Empleado empleado = new Empleado
            //    {
            //        Nombre = tb_Nombre.Text.Trim(),
            //        CorreoElectronico = tb_Correo.Text.Trim(),
            //        Telefono = tb_Telefono.Text.Trim(),
            //        NumCedula = tb_Cedula.Text.Trim(),
            //        IdArea = Convert.ToInt32(cb_Area.SelectedValue),
            //        IdUsuarioRegistro = 1, // Esto se debe obtener dinámicamente
            //        FechaRegistro = DateTime.Now
            //    };

            //    if (empleadoSeleccionadoId == -1)
            //    {
            //        int idGenerado = _empleadoController.AgregarEmpleado(empleado);
            //        if (idGenerado > 0)
            //        {
            //            MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("No se pudo registrar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        empleado.IdEmpleado = empleadoSeleccionadoId;
            //        bool actualizado = _empleadoController.EditarEmpleado(empleado);
            //        if (actualizado)
            //        {
            //            MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al actualizar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //    LimpiarCampos();
            //    CargarEmpleados();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //if (dgv_Empleados.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow fila = dgv_Empleados.SelectedRows[0];
            //    empleadoSeleccionadoId = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
            //    tb_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
            //    tb_Correo.Text = fila.Cells["CorreoElectronico"].Value.ToString();
            //    tb_Telefono.Text = fila.Cells["Telefono"].Value.ToString();
            //    tb_Cedula.Text = fila.Cells["NumCedula"].Value.ToString();
            //    cb_Area.SelectedValue = Convert.ToInt32(fila.Cells["IdArea"].Value);
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un empleado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //if (dgv_Empleados.SelectedRows.Count > 0)
            //{
            //    int idEmpleado = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells["IdEmpleado"].Value);
            //    MessageBox.Show($"ID del empleado seleccionado: {idEmpleado}"); // Mostrar el ID para asegurarse de que es correcto
            //    DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (confirmacion == DialogResult.Yes)
            //    {
            //        bool eliminado = _empleadoController.EliminarEmpleado(idEmpleado);
            //        if (eliminado)
            //        {
            //            MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            CargarEmpleados();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al eliminar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void LimpiarCampos()
        {
            tb_Nombre.Clear();
            tb_Correo.Clear();
            tb_Telefono.Clear();
            tb_Cedula.Clear();
            cb_Area.SelectedIndex = -1;
        }

        private void CargarEmpleados()
        {
            //dgv_Empleados.DataSource = _empleadoController.ObtenerEmpleados();
        }
    }
}

