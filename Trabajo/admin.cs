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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDataSet1.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.trabajoDataSet1.empleados);

        }

        private void normalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_normal ventana = new agregar_normal();
            ventana.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_vendedor ventana = new agregar_vendedor();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.trabajoDataSet1.empleados);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            acciones admin = new acciones(); 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string dato = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                admin.eliminar_usuario(dato);
            }
        }
    }
}
