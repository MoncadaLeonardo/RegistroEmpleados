using EL;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime;


namespace DAL
{
    public static class EmpleadoController
    {
        public static DataTable GetList()
        {
            SqlConnection conexion = new SqlConnection(ConexionBD.GetConexion());
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Empleados", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            da.Dispose();
            conexion.Close();
            conexion.Dispose();
            return dt;
        }

        public static int Insert(Empleado Entidad)
        {
            SqlConnection conexion = new SqlConnection(ConexionBD.GetConexion());
            conexion.Open();
            SqlCommand cmd =new SqlCommand("Insert_Empleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
            cmd.Parameters.AddWithValue("@CorreoElectronico", Entidad.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Telefono", Entidad.Telefono);
            int ID = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conexion.Close();
            conexion.Dispose();
            return ID ;
        }



        //    private readonly ConexionBD conexion;

        //    public EmpleadoController()
        //    {
        //        // Usamos la clase de conexión en lugar de acceder a la cadena directamente
        //        conexion = new ConexionBD();
        //    }

        //    public int AgregarEmpleado(Empleado empleado)
        //    {
        //        int idGenerado = 0;
        //        string query = "INSERT INTO Empleados (Nombre, CorreoElectronico, Telefono, NumCedula, IdArea, Activo, IdUsuarioRegistro, FechaRegistro) " +
        //                       "VALUES (@Nombre, @CorreoElectronico, @Telefono, @NumCedula, @IdArea, @Activo, @IdUsuarioRegistro, @FechaRegistro); " +
        //                       "SELECT SCOPE_IDENTITY();";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        //                    command.Parameters.AddWithValue("@CorreoElectronico", empleado.CorreoElectronico);
        //                    command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
        //                    command.Parameters.AddWithValue("@NumCedula", empleado.NumCedula);
        //                    command.Parameters.AddWithValue("@IdArea", empleado.IdArea);
        //                    command.Parameters.AddWithValue("@Activo", empleado.Activo);
        //                    command.Parameters.AddWithValue("@IdUsuarioRegistro", empleado.IdUsuarioRegistro);
        //                    command.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);

        //                    idGenerado = Convert.ToInt32(command.ExecuteScalar());
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogError("Error al agregar empleado", ex);
        //            MessageBox.Show($"Error al agregar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        return idGenerado;
        //    }

        //    public bool EditarEmpleado(Empleado empleado)
        //    {
        //        string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE IdEmpleado = @IdEmpleado";
        //        string query = "UPDATE Empleados SET Nombre = @Nombre, CorreoElectronico = @CorreoElectronico, " +
        //                       "Telefono = @Telefono, NumCedula = @NumCedula, IdArea = @IdArea " +
        //                       "WHERE IdEmpleado = @IdEmpleado";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, connection))
        //                {
        //                    cmdVerificar.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
        //                    int existe = (int)cmdVerificar.ExecuteScalar();
        //                    if (existe == 0)
        //                    {
        //                        MessageBox.Show("El empleado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return false;
        //                    }
        //                }

        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
        //                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        //                    command.Parameters.AddWithValue("@CorreoElectronico", empleado.CorreoElectronico);
        //                    command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
        //                    command.Parameters.AddWithValue("@NumCedula", empleado.NumCedula);
        //                    command.Parameters.AddWithValue("@IdArea", empleado.IdArea);

        //                    int filasAfectadas = command.ExecuteNonQuery();
        //                    MessageBox.Show($"Filas afectadas: {filasAfectadas}");

        //                    return filasAfectadas > 0;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogError("Error al editar empleado", ex);
        //            MessageBox.Show($"Error al editar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }

        //    public bool EliminarEmpleado(int idEmpleado)
        //    {
        //        string query = "DELETE FROM Empleados WHERE IdEmpleado = @IdEmpleado";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    // Añadimos el parámetro de forma explícita
        //                    command.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = idEmpleado;

        //                    // Ejecutamos la consulta DELETE y verificamos si afectó alguna fila
        //                    int filasAfectadas = command.ExecuteNonQuery();
        //                    return filasAfectadas > 0;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogError("Error al eliminar empleado", ex);
        //            MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }

        //    public DataTable ObtenerEmpleados()
        //    {
        //        DataTable dtEmpleados = new DataTable();
        //        string query = "SELECT IdEmpleado, Nombre, CorreoElectronico, Telefono, NumCedula, Activo, IdArea FROM Empleados";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    SqlDataAdapter da = new SqlDataAdapter(command);
        //                    da.Fill(dtEmpleados);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogError("Error al obtener empleados", ex);
        //            MessageBox.Show($"Error al obtener empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        return dtEmpleados;
        //    }

        //    public DataTable ObtenerAreas()
        //    {
        //        DataTable dtAreas = new DataTable();
        //        string query = "SELECT IdArea, NombreArea FROM Areas";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    SqlDataAdapter da = new SqlDataAdapter(command);
        //                    da.Fill(dtAreas);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LogError("Error al obtener áreas", ex);
        //            MessageBox.Show($"Error al obtener áreas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        return dtAreas;
        //    }

        //    private void LogError(string mensaje, Exception ex)
        //    {
        //        string rutaLog = "errores.log";
        //        string mensajeError = $"{DateTime.Now}: {mensaje} - {ex.Message} - {ex.StackTrace}{Environment.NewLine}";
        //        System.IO.File.AppendAllText(rutaLog, mensajeError);
        //    }

        //    public bool AgregarDetalleLaboral(int idEmpleado, int idAsignatura, string horarioLaboral, DateTime fechaInicio, DateTime fechaFin, bool activo)
        //    {
        //        string queryAsignatura = "INSERT INTO EmpleadoAsignatura (IdEmpleado, IdAsignatura) VALUES (@IdEmpleado, @IdAsignatura); " +
        //                                 "SELECT SCOPE_IDENTITY();";

        //        string queryDetallesLaborales = "INSERT INTO DetalleLaborales (Horario_Laboral, FechaInicio, FechaFin, IdEmpleado, IdEmpleadoAsig, Activo, IdUsuarioRegistro, FechaRegistro) " +
        //                                        "VALUES (@HorarioLaboral, @FechaInicio, @FechaFin, @IdEmpleado, @IdEmpleadoAsig, @Activo, @IdUsuarioRegistro, @FechaRegistro);";

        //        try
        //        {
        //            using (SqlConnection connection = conexion.AbrirConexion())
        //            {
        //                int idEmpleadoAsig = 0;
        //                using (SqlCommand commandAsig = new SqlCommand(queryAsignatura, connection))
        //                {
        //                    commandAsig.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
        //                    commandAsig.Parameters.AddWithValue("@IdAsignatura", idAsignatura);
        //                    idEmpleadoAsig = Convert.ToInt32(commandAsig.ExecuteScalar());
        //                }

        //                using (SqlCommand commandDetalles = new SqlCommand(queryDetallesLaborales, connection))
        //                {
        //                    commandDetalles.Parameters.AddWithValue("@HorarioLaboral", horarioLaboral);
        //                    commandDetalles.Parameters.AddWithValue("@FechaInicio", fechaInicio);
        //                    commandDetalles.Parameters.AddWithValue("@FechaFin", fechaFin);
        //                    commandDetalles.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
        //                    commandDetalles.Parameters.AddWithValue("@IdEmpleadoAsig", idEmpleadoAsig);
        //                    commandDetalles.Parameters.AddWithValue("@Activo", activo);
        //                    commandDetalles.Parameters.AddWithValue("@IdUsuarioRegistro", 1); // Aquí debe ir el usuario que registra
        //                    commandDetalles.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

        //                    commandDetalles.ExecuteNonQuery();
        //                }
        //            }
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error al agregar detalles laborales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }

        //}
    }
}
