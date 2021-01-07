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
    public partial class frmActualizar : Form
    {
        private String mCedula;
        public frmActualizar(String cedula)
        {
            InitializeComponent();
            this.mCedula = cedula;
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            this.txtCedula.Text = mCedula;
            CapaDatos.Persona p = new CapaDatos.Persona();
            p = CapaDatos.PersonaDAO.GetPersona(mCedula);

            //cargar datos en los cuadros de texto
            this.txtCedula.Text = p.Cedula;
            this.txtApellidos.Text = p.Apellidos;
            this.txtNombres.Text = p.Nombres;
            this.cmbSexo.Text = p.Sexo;
            this.dtFechaNacimiento.Value = Convert.ToDateTime(p.FechaNacimiento);
            this.txtEstatura.Text = p.Estatura.ToString();
            this.txtPeso.Text = p.Peso.ToString();
            this.txtCorreo.Text = p.Correo;
        }

        private void toolStripButtonActualizar_Click(object sender, EventArgs e)
        {
            if (this.mCedula.Length > 0)
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.Correo = this.txtCorreo.Text;
                persona.Estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = decimal.Parse(this.txtPeso.Text);
                persona.FechaNacimiento = dtFechaNacimiento.Value;


                int x = CapaDatos.PersonaDAO.actualizar(persona);

                if (x > 0)
                {

                    MessageBox.Show("Registro Aactualizar con exito!");
                }

                else
                    MessageBox.Show("No se pudo actualizar el registro!");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
