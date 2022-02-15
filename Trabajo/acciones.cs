using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabajo
{
    class acciones
    {
        public void eliminar_usuario(string id) {
            try
            {
                string consulta = "DELETE  FROM empleados WHERE nombre='@id'";
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J7EBE14\\SQLEXPRESS;Initial Catalog=trabajo;Integrated Security=True");
                con.Open();
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader datos = comando.ExecuteReader();
                MessageBox.Show("Se ha eliminado un empleado");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error : " + err);
            }
        }
    }
}
