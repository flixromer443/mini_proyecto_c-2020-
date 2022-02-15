using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar(object sender, EventArgs e)
        {
            string nombre = textboxnombre.Text;
            string pass = textBox2.Text;
            validar(nombre,pass);
            string consulta = "SELECT * FROM administrador";
            string consulta2 = "SELECT * FROM empleados";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J7EBE14\\SQLEXPRESS;Initial Catalog=trabajo;Integrated Security=True");
                con.Open();
                SqlCommand comando = new SqlCommand(consulta, con);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    if (datos.GetValue(1).ToString() == nombre && datos.GetValue(2).ToString() == pass)
                    {
                        datos.Close();
                        MessageBox.Show("Iniciaste sesion como admin");
                        admin formu = new admin();
                        formu.Show();
                        this.Hide();
                        return;
                    }
                }
                datos.Close();
                SqlCommand comando2 = new SqlCommand(consulta2, con);
                SqlDataReader datos2 = comando2.ExecuteReader();
                while (datos2.Read())
                {
                    if (datos2.GetValue(1).ToString() == nombre)
                    {
                        datos2.Close();
                        MessageBox.Show("Sos un vendedor");
                        return;
                    }
                }
                MessageBox.Show("Los datos ingresados no son validos");
                datos2.Close();
            }catch(Exception err)
            {
                MessageBox.Show("Error : " + err);
            }

        }

        private void validar(string nombre, string pass)
        {
            if (nombre == "" && pass=="")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textboxnombre, "Debe ingresar su nombre");
                errorProvider1.SetError(textBox2, "Debe ingresar su contraseña");
                return;
            }
            else if (nombre == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textboxnombre, "El campo de nombre se encuentra vacio");
                return;
            }
            else if (pass == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "El campo de nombre se encuentra vacio");
                return;
            }
            errorProvider1.Clear();
        }
    }
}
