namespace pryApellidoTest
{
    partial class frmDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grpUno = new System.Windows.Forms.GroupBox();
            this.grpDos = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.droRepuesto = new System.Windows.Forms.RadioButton();
            this.rdoEquipo = new System.Windows.Forms.RadioButton();
            this.chkInstalacion = new System.Windows.Forms.CheckBox();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            this.chkGarantia = new System.Windows.Forms.CheckBox();
            this.grpUno.SuspendLayout();
            this.grpDos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(6, 57);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(184, 13);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista de Productos Registrados";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbLista
            // 
            this.cmbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(6, 73);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(215, 21);
            this.cmbLista.TabIndex = 2;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(227, 11);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(279, 89);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(97, 36);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // grpUno
            // 
            this.grpUno.Controls.Add(this.lblNombre);
            this.grpUno.Controls.Add(this.lblLista);
            this.grpUno.Controls.Add(this.btnSiguiente);
            this.grpUno.Controls.Add(this.txtNombre);
            this.grpUno.Controls.Add(this.btnRegistrar);
            this.grpUno.Controls.Add(this.cmbLista);
            this.grpUno.Location = new System.Drawing.Point(6, 17);
            this.grpUno.Name = "grpUno";
            this.grpUno.Size = new System.Drawing.Size(382, 131);
            this.grpUno.TabIndex = 4;
            this.grpUno.TabStop = false;
            // 
            // grpDos
            // 
            this.grpDos.Controls.Add(this.groupBox2);
            this.grpDos.Controls.Add(this.groupBox1);
            this.grpDos.Controls.Add(this.cmbProductos);
            this.grpDos.Controls.Add(this.lblProducto);
            this.grpDos.Location = new System.Drawing.Point(6, 17);
            this.grpDos.Name = "grpDos";
            this.grpDos.Size = new System.Drawing.Size(382, 131);
            this.grpDos.TabIndex = 5;
            this.grpDos.TabStop = false;
            this.grpDos.Visible = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(6, 16);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Productos";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(76, 13);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(257, 21);
            this.cmbProductos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.rdoEquipo);
            this.groupBox1.Controls.Add(this.droRepuesto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.chkGarantia);
            this.groupBox2.Controls.Add(this.chkEnvio);
            this.groupBox2.Controls.Add(this.chkInstalacion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(175, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADICIONAL";
            // 
            // droRepuesto
            // 
            this.droRepuesto.AutoSize = true;
            this.droRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droRepuesto.Location = new System.Drawing.Point(6, 19);
            this.droRepuesto.Name = "droRepuesto";
            this.droRepuesto.Size = new System.Drawing.Size(79, 17);
            this.droRepuesto.TabIndex = 0;
            this.droRepuesto.TabStop = true;
            this.droRepuesto.Text = "Repuseto";
            this.droRepuesto.UseVisualStyleBackColor = true;
            // 
            // rdoEquipo
            // 
            this.rdoEquipo.AutoSize = true;
            this.rdoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEquipo.Location = new System.Drawing.Point(91, 19);
            this.rdoEquipo.Name = "rdoEquipo";
            this.rdoEquipo.Size = new System.Drawing.Size(64, 17);
            this.rdoEquipo.TabIndex = 1;
            this.rdoEquipo.TabStop = true;
            this.rdoEquipo.Text = "Equipo";
            this.rdoEquipo.UseVisualStyleBackColor = true;
            // 
            // chkInstalacion
            // 
            this.chkInstalacion.AutoSize = true;
            this.chkInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInstalacion.Location = new System.Drawing.Point(6, 19);
            this.chkInstalacion.Name = "chkInstalacion";
            this.chkInstalacion.Size = new System.Drawing.Size(88, 17);
            this.chkInstalacion.TabIndex = 0;
            this.chkInstalacion.Text = "Instalacion";
            this.chkInstalacion.UseVisualStyleBackColor = true;
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnvio.Location = new System.Drawing.Point(100, 19);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(58, 17);
            this.chkEnvio.TabIndex = 1;
            this.chkEnvio.Text = "Envio";
            this.chkEnvio.UseVisualStyleBackColor = true;
            // 
            // chkGarantia
            // 
            this.chkGarantia.AutoSize = true;
            this.chkGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGarantia.Location = new System.Drawing.Point(6, 42);
            this.chkGarantia.Name = "chkGarantia";
            this.chkGarantia.Size = new System.Drawing.Size(74, 17);
            this.chkGarantia.TabIndex = 2;
            this.chkGarantia.Text = "Garantia";
            this.chkGarantia.UseVisualStyleBackColor = true;
            // 
            // frmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(403, 167);
            this.Controls.Add(this.grpDos);
            this.Controls.Add(this.grpUno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michelin";
            this.Load += new System.EventHandler(this.frmDos_Load);
            this.grpUno.ResumeLayout(false);
            this.grpUno.PerformLayout();
            this.grpDos.ResumeLayout(false);
            this.grpDos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox grpUno;
        private System.Windows.Forms.GroupBox grpDos;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoEquipo;
        private System.Windows.Forms.RadioButton droRepuesto;
        private System.Windows.Forms.CheckBox chkGarantia;
        private System.Windows.Forms.CheckBox chkEnvio;
        private System.Windows.Forms.CheckBox chkInstalacion;
    }
}