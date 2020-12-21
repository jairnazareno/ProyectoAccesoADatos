using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class PersonaDAO
    {
        public static string cadenaConexion = @"Server=DESKTOP-BVI966H\SQLEXPRESS; database=Estudiante; integrated security=true";
        public static int crear(Persona persona)
            {
         

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
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select cedula, upper(apellidos +' '+ nombres) as Estudiante , case when sexo='M' then 'Masculino' else 'Femenino' end as Sexo, F_Nacimiento as [Fecha Nac.], Correo, Estatura, Peso " +
                "from Personas order by apellidos, nombres";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt); 
            return dt;
        }
        public static Persona GetPersona(String cedula)
        {

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select cedula,apellidos, nombres, sexo, F_Nacimiento, Correo, Estatura, Peso" + " from Personas "
               + "where cedula=@cedula";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            ad.SelectCommand.Parameters.AddWithValue("@cedula", cedula);



            DataTable dt = new DataTable();
            ad.Fill(dt);

            Persona p = new Persona();
            foreach (DataRow fila in dt.Rows)
            {
                p.Cedula = fila["cedula"].ToString();
                p.Apellidos = fila["apellidos"].ToString();
                p.Nombres = fila["nombres"].ToString();
                p.Sexo = fila["sexo"].ToString();
                p.Correo = fila["correo"].ToString();
                p.Estatura = int.Parse(fila["Estatura"].ToString());
                p.Peso = decimal.Parse(fila["Peso"].ToString());
                p.FechaNacimiento = Convert.ToDateTime(fila["F_Nacimiento"].ToString());
                break;
            }
            return p;
        }
        
    }
}
