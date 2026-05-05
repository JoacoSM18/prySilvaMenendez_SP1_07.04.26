namespace prySilvaMenendez_SP1_07._04._26
{
    partial class frmConsulta
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
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.groupBoxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.lblEspecialidad);
            this.groupBoxConsulta.Controls.Add(this.cbxEspecialidad);
            this.groupBoxConsulta.Controls.Add(this.dgvMedicos);
            this.groupBoxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConsulta.Location = new System.Drawing.Point(30, 34);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(460, 314);
            this.groupBoxConsulta.TabIndex = 3;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consultar Médicos por Especialidad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 30);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(87, 16);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidad.Location = new System.Drawing.Point(99, 27);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(250, 24);
            this.cbxEspecialidad.TabIndex = 1;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(49, 75);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.Size = new System.Drawing.Size(372, 214);
            this.dgvMedicos.TabIndex = 2;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.groupBoxConsulta);
            this.Name = "frmConsulta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.DataGridView dgvMedicos;
    }
}