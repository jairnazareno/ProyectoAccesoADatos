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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            this.cargarComboEstudiantes();
        }
        private void cargarComboEstudiantes()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.getAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "cedula";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = this.cmbCedula.SelectedValue.ToString();

            CapaDatos.Persona p = new CapaDatos.Persona();
            p = CapaDatos.PersonaDAO.GetPersona(cedula);

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Length == 0)
            {
                MessageBox.Show("No hay cedula seleccionada");
                return;
            }
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
                this.cargarComboEstudiantes();
                MessageBox.Show("Registro Aactualizar con exito!");
            }

            else
                MessageBox.Show("No se pudo actualizar el registro!");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirme", "Esta seguro que desea eliminar este registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
            {
                return;
            }
            int x = CapaDatos.PersonaDAO.eliminar(this.txtCedula.Text);
            if (x > 0)
            {
                this.encerar();
                this.cargarComboEstudiantes();
                MessageBox.Show("¡No se pudo borrar el registro!");
            }
        }
        private void encerar()
        {
            this.txtCedula.Text = "";
            this.txtApellidos.Text = "";
            this.txtNombres.Text = "";
            this.txtCorreo.Text = "";
            this.txtEstatura.Text = "0";
            this.txtPeso.Text = "0";

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           

            
        }
    }
}

