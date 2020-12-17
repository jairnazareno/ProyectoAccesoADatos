using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class PersonaDAO
    {
            public static DataTable getAll()
            {
             string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS\SQLEXPRESS; database=Estudiantes; integrated security=true";

             SqlConnection conexion = new SqlConnection(cadenaConexion);
               
            string sql = "select cedula, apellidos, nombres, sexo, F_Nacimiento, Correo, Estatura, Peso" + "from Personas";
             SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
              
            DataTable dt = new DataTable(); 
            ad.Fill(dt);
            return dt;
            }
        
    }
}
