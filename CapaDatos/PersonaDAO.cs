using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class PersonaDAO
    {
            public static int crear(Persona persona)
            {
            string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Estudiante; integrated security=true";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "insert into Personas(cedula, apellidos, nombres, sexo, F_Nacimiento, "+
                "Correo, Estatura, Peso) values(@cedula, @apellidos, @nombres, @sexo, @F_Nacimiento,"+
                "@Correo, @Estatura, @Peso)";
            
            SqlCommand comando = new SqlCommand(sql, conexion);
            
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@F_Nacimiento", persona.FechaNacimiento);
            comando.Parameters.AddWithValue("@Correo", persona.Correo);
            comando.Parameters.AddWithValue("@Estatura", persona.Estatura);
            comando.Parameters.AddWithValue("@Peso", persona.Peso);


            conexion.Open();
            int X = comando.ExecuteNonQuery();

            conexion.Close();

            return X;
        }
        public static DataTable getAll()
            {
             string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Estudiante; integrated security=true";

             SqlConnection conexion = new SqlConnection(cadenaConexion);
               
             string sql = "select cedula, apellidos, nombres, sexo, F_Nacimiento, Correo, Estatura, Peso" + " from Personas";
             SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
              
            DataTable dt = new DataTable(); 
            ad.Fill(dt);
            return dt;
            }
        
    }
}
