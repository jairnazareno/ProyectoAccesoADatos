using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IUWindowsForms
{
    public partial class frmAgregarEstudiantes : Form
    {
        public frmAgregarEstudiantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar la cedula");
                this.txtCedula.Focus();
                return;
            }
            if (this.txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar los apellidos");
                this.txtApellidos.Focus();
                return;
            }
            if (this.txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar sus nombres");
                this.txtNombres.Focus();
                return;
            }
            if (this.cmbSexo.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debe seleccionar su sexo");
                this.cmbSexo.Focus();
                return;
            }
           
            if (this.txtCorreos.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debe ingresar el correo");
                this.txtCorreos.Focus();
                return;
            }
            if (this.txtEstaturas.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debe su estatura");
                this.txtEstaturas.Focus();
                return;
            }
            if (this.txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debe ingresar su peso");
                this.txtPeso.Focus();
                return;
            }

            try
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.FechaNacimiento = dtFechaNacimiento.Value;
                persona.Correo = this.txtCorreos.Text;
                persona.Estatura = int.Parse(this.txtEstaturas.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);


                int x = CapaDatos.PersonaDAO.crear(persona);

                if (x > 0)
                    MessageBox.Show("Se agrego correctamente...");
                else
                    MessageBox.Show("No se pudo agregar el registro...");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void txtCorreos_TextChanged(object sender, EventArgs e)
        {
           
        }
        public static bool ComprobarEmail(string MailAComprobar)
        {
            String Formato;
            Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(MailAComprobar, Formato))
            {
                if (Regex.Replace(MailAComprobar, Formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (ComprobarEmail(txtCorreos.Text) == false)
            {
                MessageBox.Show("Dirección no valida");
                txtCorreos.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Dirección valida");
                txtCorreos.ForeColor = Color.Green;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtEstaturas_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEstaturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
