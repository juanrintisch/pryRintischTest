namespace pryApellidoTest
{
    partial class frmTres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTres));
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.grpAdicional = new System.Windows.Forms.GroupBox();
            this.chkInstalacion = new System.Windows.Forms.CheckBox();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            this.chkGarantia = new System.Windows.Forms.CheckBox();
            this.rdoRespuesto = new System.Windows.Forms.RadioButton();
            this.rdoEquipo = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grpTipo.SuspendLayout();
            this.grpAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(12, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Bici",
            "Avion"});
            this.cmbProducto.Location = new System.Drawing.Point(76, 6);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.AliceBlue;
            this.grpTipo.Controls.Add(this.rdoEquipo);
            this.grpTipo.Controls.Add(this.rdoRespuesto);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(15, 33);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(189, 50);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "TIPO";
            // 
            // grpAdicional
            // 
            this.grpAdicional.BackColor = System.Drawing.Color.AliceBlue;
            this.grpAdicional.Controls.Add(this.chkGarantia);
            this.grpAdicional.Controls.Add(this.chkEnvio);
            this.grpAdicional.Controls.Add(this.chkInstalacion);
            this.grpAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdicional.Location = new System.Drawing.Point(15, 89);
            this.grpAdicional.Name = "grpAdicional";
            this.grpAdicional.Size = new System.Drawing.Size(189, 72);
            this.grpAdicional.TabIndex = 3;
            this.grpAdicional.TabStop = false;
            this.grpAdicional.Text = "ADICIONAL";
            // 
            // chkInstalacion
            // 
            this.chkInstalacion.AutoSize = true;
            this.chkInstalacion.Location = new System.Drawing.Point(6, 19);
            this.chkInstalacion.Name = "chkInstalacion";
            this.chkInstalacion.Size = new System.Drawing.Size(108, 17);
            this.chkInstalacion.TabIndex = 0;
            this.chkInstalacion.Text = "INSTALACION";
            this.chkInstalacion.UseVisualStyleBackColor = true;
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.Location = new System.Drawing.Point(120, 19);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(64, 17);
            this.chkEnvio.TabIndex = 1;
            this.chkEnvio.Text = "ENVIO";
            this.chkEnvio.UseVisualStyleBackColor = true;
            // 
            // chkGarantia
            // 
            this.chkGarantia.AutoSize = true;
            this.chkGarantia.Location = new System.Drawing.Point(6, 42);
            this.chkGarantia.Name = "chkGarantia";
            this.chkGarantia.Size = new System.Drawing.Size(89, 17);
            this.chkGarantia.TabIndex = 2;
            this.chkGarantia.Text = "GARANTIA";
            this.chkGarantia.UseVisualStyleBackColor = true;
            // 
            // rdoRespuesto
            // 
            this.rdoRespuesto.AutoSize = true;
            this.rdoRespuesto.Location = new System.Drawing.Point(6, 19);
            this.rdoRespuesto.Name = "rdoRespuesto";
            this.rdoRespuesto.Size = new System.Drawing.Size(100, 17);
            this.rdoRespuesto.TabIndex = 0;
            this.rdoRespuesto.TabStop = true;
            this.rdoRespuesto.Text = "RESPUESTO";
            this.rdoRespuesto.UseVisualStyleBackColor = true;
            // 
            // rdoEquipo
            // 
            this.rdoEquipo.AutoSize = true;
            this.rdoEquipo.Location = new System.Drawing.Point(112, 19);
            this.rdoEquipo.Name = "rdoEquipo";
            this.rdoEquipo.Size = new System.Drawing.Size(72, 17);
            this.rdoEquipo.TabIndex = 1;
            this.rdoEquipo.TabStop = true;
            this.rdoEquipo.Text = "EQUIPO";
            this.rdoEquipo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(155, 167);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 39);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(256, 212);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grpAdicional);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michelin";
            this.Load += new System.EventHandler(this.frmTres_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpAdicional.ResumeLayout(false);
            this.grpAdicional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.GroupBox grpAdicional;
        private System.Windows.Forms.RadioButton rdoEquipo;
        private System.Windows.Forms.RadioButton rdoRespuesto;
        private System.Windows.Forms.CheckBox chkGarantia;
        private System.Windows.Forms.CheckBox chkEnvio;
        private System.Windows.Forms.CheckBox chkInstalacion;
        private System.Windows.Forms.Button btnSiguiente;
    }
}