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
            btActualizar = new Button();
            btBuscar = new Button();
            txtBuscar = new TextBox();
            cbxSeleccion = new ComboBox();
            label1 = new Label();
            dtgvMostrar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(12, 341);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 11;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(482, 377);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 10;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(351, 377);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 9;
            // 
            // cbxSeleccion
            // 
            cbxSeleccion.FormattingEnabled = true;
            cbxSeleccion.ImeMode = ImeMode.Off;
            cbxSeleccion.Items.AddRange(new object[] { "Nombre", "Tipo", "Color", "Marca", "Talla" });
            cbxSeleccion.Location = new Point(194, 376);
            cbxSeleccion.Name = "cbxSeleccion";
            cbxSeleccion.Size = new Size(151, 28);
            cbxSeleccion.TabIndex = 8;
            cbxSeleccion.Text = "Seleccione . . .";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 353);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 7;
            label1.Text = "Busqueda Avanzada:";
            // 
            // dtgvMostrar
            // 
            dtgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMostrar.Location = new Point(12, 44);
            dtgvMostrar.Name = "dtgvMostrar";
            dtgvMostrar.RowHeadersWidth = 51;
            dtgvMostrar.RowTemplate.Height = 29;
            dtgvMostrar.Size = new Size(776, 289);
            dtgvMostrar.TabIndex = 6;
            // 
            // Mostrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btActualizar);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cbxSeleccion);
            Controls.Add(label1);
            Controls.Add(dtgvMostrar);
            Name = "Mostrar";
            Text = "Mostrar";
            Load += Mostrar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
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