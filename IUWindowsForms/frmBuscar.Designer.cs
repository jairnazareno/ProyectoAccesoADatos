namespace IUWindowsForms
{
    partial class frmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCedula = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCedula
            // 
            this.cmbCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCedula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCedula.FormattingEnabled = true;
            this.cmbCedula.Location = new System.Drawing.Point(166, 56);
            this.cmbCedula.Name = "cmbCedula";
            this.cmbCedula.Size = new System.Drawing.Size(121, 21);
            this.cmbCedula.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(166, 186);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(160, 20);
            this.txtNombres.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 155);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(160, 20);
            this.txtApellidos.TabIndex = 13;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(166, 120);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccione el estudiante";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(354, 59);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 29);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Estatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(166, 330);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(160, 20);
            this.txtPeso.TabIndex = 23;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(166, 297);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(160, 20);
            this.txtEstatura.TabIndex = 24;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(166, 228);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 25;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(184, 261);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(103, 20);
            this.dtFechaNacimiento.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(166, 372);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(160, 20);
            this.txtCorreo.TabIndex = 28;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(132, 415);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCedula);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnActualizar;
    }
}