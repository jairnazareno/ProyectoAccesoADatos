using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class frmListadoEstudiante : Form
    {
        public frmListadoEstudiante()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.cargaGrid();
        }
        private void cargaGrid()
        {
            this.dataGridViewEstudiantes.DataSource = CapaDatos.PersonaDAO.getAll();

        }

        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["cedula", fila].Value.ToString();
                String Estudiante = dataGridViewEstudiantes["Estudiante", fila].Value.ToString();

                DialogResult dr = MessageBox.Show("ESTAS SEGURO DE ELIMINAR AL ESTDUDIANTE, " + Estudiante + " ?", "CONFIRME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int x = CapaDatos.PersonaDAO.eliminar(cedula);
                if (x > 0)
                {
                    MessageBox.Show("Registro borrado con exito...");
                }
                else
                    MessageBox.Show("NO SE PUDO BORRAR");
          
            
            
            }
            else if (this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["cedula", fila].Value.ToString();

                //MessageBox.Show("clic actualizar");
                frmActualizar frm1 = new frmActualizar(cedula);
                frm1.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
