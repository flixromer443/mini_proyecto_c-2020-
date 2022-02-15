using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Trabajo
{
    class agregar
    {
        private string nombre;
        private string password;

        public string Nombre { get; set; }
        public string Password { get; set; }

        public void verificar(string nom, string pass, string consulta)
        {
            if (nom == "" && pass == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");

                return;
            }
            enviar_consulta(nom, pass, consulta);
        }
        private void enviar_consulta(string nombre, string contraseña, string consulta)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J7EBE14\\SQLEXPRESS;Initial Catalog=trabajo;Integrated Security=True");
                con.Open();
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", contraseña);
                SqlDataReader datos = comando.ExecuteReader();
                MessageBox.Show("Se ha agregado un nuevo empleado");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error : " + err);
            }
        }
    }
}
