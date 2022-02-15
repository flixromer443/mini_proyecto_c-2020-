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
using System.Xml.Linq;

namespace Trabajo
{
    public partial class agregar_vendedor : Form
    {
        public agregar_vendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar empleado = new agregar();
            
            empleado.Nombre = textBox1.Text;
            empleado.Password = textBox2.Text;
            string consulta = "INSERT INTO empleados(nombre,contrasena,tipo) VALUES(@nombre,@apellido,'vendedor')";

            empleado.verificar(empleado.Nombre,empleado.Password,consulta);
            this.Close();

        }

        
    }
}
