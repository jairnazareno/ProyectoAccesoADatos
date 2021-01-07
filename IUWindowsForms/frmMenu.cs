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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarEstudiantes frm1 = new frmAgregarEstudiantes();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListadoEstudiante frm1 = new frmListadoEstudiante();
            frm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBuscar frm1 = new frmBuscar();
            frm1.ShowDialog();
        }
    }
}
