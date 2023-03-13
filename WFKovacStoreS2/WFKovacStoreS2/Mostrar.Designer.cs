namespace WFKovacStoreS2
{
    partial class Mostrar
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
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxSeleccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(12, 341);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(94, 29);
            this.btActualizar.TabIndex = 11;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(482, 377);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 29);
            this.btBuscar.TabIndex = 10;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(351, 377);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(125, 27);
            this.txtBuscar.TabIndex = 9;
            // 
            // cbxSeleccion
            // 
            this.cbxSeleccion.FormattingEnabled = true;
            this.cbxSeleccion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbxSeleccion.Items.AddRange(new object[] {
            "Nombre",
            "Tipo",
            "Color",
            "Marca",
            "Talla"});
            this.cbxSeleccion.Location = new System.Drawing.Point(194, 376);
            this.cbxSeleccion.Name = "cbxSeleccion";
            this.cbxSeleccion.Size = new System.Drawing.Size(151, 28);
            this.cbxSeleccion.TabIndex = 8;
            this.cbxSeleccion.Text = "Seleccione . . .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Busqueda Avanzada:";
            // 
            // dtgvMostrar
            // 
            this.dtgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrar.Location = new System.Drawing.Point(12, 44);
            this.dtgvMostrar.Name = "dtgvMostrar";
            this.dtgvMostrar.RowHeadersWidth = 51;
            this.dtgvMostrar.RowTemplate.Height = 29;
            this.dtgvMostrar.Size = new System.Drawing.Size(776, 289);
            this.dtgvMostrar.TabIndex = 6;
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxSeleccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMostrar);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btActualizar;
        private Button btBuscar;
        private TextBox txtBuscar;
        private ComboBox cbxSeleccion;
        private Label label1;
        private DataGridView dtgvMostrar;
    }
}