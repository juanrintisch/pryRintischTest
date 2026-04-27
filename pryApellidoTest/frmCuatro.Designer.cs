namespace pryApellidoTest
{
    partial class frmCuatro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuatro));
            this.dtaInfo = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionalUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionalDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionalTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaInfo
            // 
            this.dtaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Tipo,
            this.AdicionalUno,
            this.AdicionalDos,
            this.AdicionalTres});
            this.dtaInfo.Location = new System.Drawing.Point(12, 12);
            this.dtaInfo.Name = "dtaInfo";
            this.dtaInfo.Size = new System.Drawing.Size(544, 327);
            this.dtaInfo.TabIndex = 1;
            this.dtaInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // AdicionalUno
            // 
            this.AdicionalUno.HeaderText = "Adicional Nº Uno";
            this.AdicionalUno.Name = "AdicionalUno";
            // 
            // AdicionalDos
            // 
            this.AdicionalDos.HeaderText = "Adicional Nº Dos";
            this.AdicionalDos.Name = "AdicionalDos";
            // 
            // AdicionalTres
            // 
            this.AdicionalTres.HeaderText = "Adicional Nº Tres";
            this.AdicionalTres.Name = "AdicionalTres";
            // 
            // frmCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(572, 362);
            this.Controls.Add(this.dtaInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuatro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michelin - Resumen";
            ((System.ComponentModel.ISupportInitialize)(this.dtaInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtaInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdicionalUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdicionalDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdicionalTres;
    }
}