using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo
{
    public partial class agregar_normal : Form
    {
        public agregar_normal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar empleado = new agregar();

            empleado.Nombre = textBox1.Text;
            empleado.Password = textBox2.Text;
            string consulta = "INSERT INTO empleados(nombre,contrasena,tipo) VALUES(@nombre,@apellido,'Empleado')";

            empleado.verificar(empleado.Nombre, empleado.Password, consulta);
            this.Close();
        }
    }
}
