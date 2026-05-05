namespace prySilvaMenendez_SP1_07._04._26
{
    partial class frmMedicos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxAgregar = new System.Windows.Forms.GroupBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            this.cbxEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.btnAgregarMedico = new System.Windows.Forms.Button();
            this.btnLimpiarMedico = new System.Windows.Forms.Button();
            this.groupBoxAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Médicos";
            // 
            // groupBoxAgregar
            // 
            this.groupBoxAgregar.Controls.Add(this.lblMatricula);
            this.groupBoxAgregar.Controls.Add(this.txtMatricula);
            this.groupBoxAgregar.Controls.Add(this.lblNombreMedico);
            this.groupBoxAgregar.Controls.Add(this.txtNombreMedico);
            this.groupBoxAgregar.Controls.Add(this.lblEspecialidadMedico);
            this.groupBoxAgregar.Controls.Add(this.cbxEspecialidadMedico);
            this.groupBoxAgregar.Controls.Add(this.btnAgregarMedico);
            this.groupBoxAgregar.Controls.Add(this.btnLimpiarMedico);
            this.groupBoxAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAgregar.Location = new System.Drawing.Point(24, 43);
            this.groupBoxAgregar.Name = "groupBoxAgregar";
            this.groupBoxAgregar.Size = new System.Drawing.Size(460, 150);
            this.groupBoxAgregar.TabIndex = 1;
            this.groupBoxAgregar.TabStop = false;
            this.groupBoxAgregar.Text = "Agregar Médico";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 25);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(99, 19);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 22);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Location = new System.Drawing.Point(6, 55);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(56, 16);
            this.lblNombreMedico.TabIndex = 2;
            this.lblNombreMedico.Text = "Nombre";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(99, 49);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(250, 22);
            this.txtNombreMedico.TabIndex = 3;
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(6, 85);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(87, 16);
            this.lblEspecialidadMedico.TabIndex = 4;
            this.lblEspecialidadMedico.Text = "Especialidad";
            // 
            // cbxEspecialidadMedico
            // 
            this.cbxEspecialidadMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidadMedico.Location = new System.Drawing.Point(99, 77);
            this.cbxEspecialidadMedico.Name = "cbxEspecialidadMedico";
            this.cbxEspecialidadMedico.Size = new System.Drawing.Size(250, 24);
            this.cbxEspecialidadMedico.TabIndex = 5;
            // 
            // btnAgregarMedico
            // 
            this.btnAgregarMedico.Location = new System.Drawing.Point(99, 115);
            this.btnAgregarMedico.Name = "btnAgregarMedico";
            this.btnAgregarMedico.Size = new System.Drawing.Size(76, 23);
            this.btnAgregarMedico.TabIndex = 6;
            this.btnAgregarMedico.Text = "Agregar";
            this.btnAgregarMedico.UseVisualStyleBackColor = true;
            this.btnAgregarMedico.Click += new System.EventHandler(this.btnAgregarMedico_Click);
            // 
            // btnLimpiarMedico
            // 
            this.btnLimpiarMedico.Location = new System.Drawing.Point(220, 115);
            this.btnLimpiarMedico.Name = "btnLimpiarMedico";
            this.btnLimpiarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarMedico.TabIndex = 7;
            this.btnLimpiarMedico.Text = "Limpiar";
            this.btnLimpiarMedico.UseVisualStyleBackColor = true;
            this.btnLimpiarMedico.Click += new System.EventHandler(this.btnLimpiarMedico_Click);
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(511, 219);
            this.Controls.Add(this.groupBoxAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.groupBoxAgregar.ResumeLayout(false);
            this.groupBoxAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxAgregar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.ComboBox cbxEspecialidadMedico;
        private System.Windows.Forms.Button btnAgregarMedico;
        private System.Windows.Forms.Button btnLimpiarMedico;
    }
}