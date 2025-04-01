namespace EL
{
    public static class ConexionBD
    {
        public static string GetConexion()
        {
            return "Data Source=.;Initial Catalog=ColegioBautista;Integrated Security=True;TrustServerCertificate=Yes";
        }

        //        connectionString = 


        //    public SqlConnection AbrirConexion()
        //    {
        //        SqlConnection conexion = new SqlConnection(connectionString);
        //        if (conexion.State == ConnectionState.Closed)
        //        {
        //            conexion.Open();
        //        }
        //        return conexion;
        //    }

        //    public SqlConnection ObtenerConexion()
        //    {
        //        try
        //        {
        //            SqlConnection conexion = new SqlConnection(connectionString);
        //            conexion.Open();
        //            return conexion;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error al conectar con la base de datos: " + ex.Message);
        //        }
        //    }
        //}
    }
}

