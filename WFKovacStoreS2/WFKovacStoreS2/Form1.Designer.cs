namespace WFKovacStoreS2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.mtxFecha = new System.Windows.Forms.MaskedTextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOVAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Talla: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marca: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de \r\nListado: ";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(140, 52);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(151, 27);
            this.txbNombre.TabIndex = 7;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Hodies",
            "Gorras",
            "Camiestas",
            "Pantalones",
            "Zapatillas"});
            this.cbTipo.Location = new System.Drawing.Point(140, 90);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(151, 28);
            this.cbTipo.TabIndex = 8;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Naranja",
            "Verde"});
            this.cbColor.Location = new System.Drawing.Point(140, 128);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(151, 28);
            this.cbColor.TabIndex = 9;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Gucci",
            "Supreme",
            "Nike",
            "Addidas",
            "Puma",
            "Sin Marca"});
            this.cbMarca.Location = new System.Drawing.Point(140, 166);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(151, 28);
            this.cbMarca.TabIndex = 10;
            // 
            // cbTalla
            // 
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbTalla.Location = new System.Drawing.Point(140, 204);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(151, 28);
            this.cbTalla.TabIndex = 11;
            // 
            // mtxFecha
            // 
            this.mtxFecha.Location = new System.Drawing.Point(140, 245);
            this.mtxFecha.Mask = "00/00/0000";
            this.mtxFecha.Name = "mtxFecha";
            this.mtxFecha.Size = new System.Drawing.Size(151, 27);
            this.mtxFecha.TabIndex = 12;
            this.mtxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(82, 308);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(94, 29);
            this.btEnviar.TabIndex = 13;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(212, 308);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(94, 29);
            this.btMostrar.TabIndex = 14;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.mtxFecha);
            this.Controls.Add(this.cbTalla);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbNombre;
        private ComboBox cbTipo;
        private ComboBox cbColor;
        private ComboBox cbMarca;
        private ComboBox cbTalla;
        private MaskedTextBox mtxFecha;
        private Button btEnviar;
        private Button btMostrar;
    }
}