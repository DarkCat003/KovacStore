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
            btMostrar = new Button();
            btIngresar = new Button();
            mtxFecha = new MaskedTextBox();
            mtxPrecio = new MaskedTextBox();
            cbTalla = new ComboBox();
            cbxMarca = new ComboBox();
            cbxColor = new ComboBox();
            cbxTipo = new ComboBox();
            txbNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(208, 415);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 33;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // btIngresar
            // 
            btIngresar.Location = new Point(78, 415);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(94, 29);
            btIngresar.TabIndex = 32;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // mtxFecha
            // 
            mtxFecha.Location = new Point(151, 352);
            mtxFecha.Mask = "00/00/0000";
            mtxFecha.Name = "mtxFecha";
            mtxFecha.Size = new Size(151, 27);
            mtxFecha.TabIndex = 31;
            mtxFecha.ValidatingType = typeof(DateTime);
            mtxFecha.MaskInputRejected += mtxFecha_MaskInputRejected;
            // 
            // mtxPrecio
            // 
            mtxPrecio.Location = new Point(151, 302);
            mtxPrecio.Mask = "999";
            mtxPrecio.Name = "mtxPrecio";
            mtxPrecio.Size = new Size(151, 27);
            mtxPrecio.TabIndex = 30;
            // 
            // cbTalla
            // 
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "S", "M", "L" });
            cbTalla.Location = new Point(151, 267);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(151, 28);
            cbTalla.TabIndex = 29;
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Items.AddRange(new object[] { "Addidas", "Nika", "Puma", "Sin Marca" });
            cbxMarca.Location = new Point(151, 233);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(151, 28);
            cbxMarca.TabIndex = 28;
            // 
            // cbxColor
            // 
            cbxColor.FormattingEnabled = true;
            cbxColor.Items.AddRange(new object[] { "Rojo", "Azul", "Verde", "Naranja" });
            cbxColor.Location = new Point(151, 199);
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(151, 28);
            cbxColor.TabIndex = 27;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Hoodie", "Camiseta", "Zapatillas", "Pantalon", "Gorra" });
            cbxTipo.Location = new Point(151, 165);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(151, 28);
            cbxTipo.TabIndex = 26;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(151, 128);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(151, 27);
            txbNombre.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(166, 57);
            label8.Name = "label8";
            label8.Size = new Size(136, 43);
            label8.TabIndex = 24;
            label8.Text = "KOVAC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(70, 341);
            label7.Name = "label7";
            label7.Size = new Size(75, 38);
            label7.TabIndex = 23;
            label7.Text = "Fecha de\r\ningreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(85, 307);
            label6.Name = "label6";
            label6.Size = new Size(60, 19);
            label6.TabIndex = 22;
            label6.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 273);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 21;
            label5.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 239);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 20;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 205);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 19;
            label3.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 171);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 18;
            label2.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 137);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 17;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.KovacLoco;
            pictureBox1.Location = new Point(77, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 512);
            Controls.Add(pictureBox1);
            Controls.Add(btMostrar);
            Controls.Add(btIngresar);
            Controls.Add(mtxFecha);
            Controls.Add(mtxPrecio);
            Controls.Add(cbTalla);
            Controls.Add(cbxMarca);
            Controls.Add(cbxColor);
            Controls.Add(cbxTipo);
            Controls.Add(txbNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMostrar;
        private Button btIngresar;
        private MaskedTextBox mtxFecha;
        private MaskedTextBox mtxPrecio;
        private ComboBox cbTalla;
        private ComboBox cbxMarca;
        private ComboBox cbxColor;
        private ComboBox cbxTipo;
        private TextBox txbNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;

            /*
            En Argentina nací
            Tierra del Diego y Lionel
            De los pibes de Malvinas
            Que jamás olvidaré

            No te lo puedo explicar
            Porque no vas a entender
            Las finales que perdimos
            Cuantos años la lloré

            Pero eso se terminó
            Porque en el Maracaná
            La final con los brazucas
            La volvió a ganar papá

            Muchachos
            Ahora nos volvimos a ilusionar
            Quiero ganar la tercera
            Quiero ser campeón mundial

            Y al Diego
            Desde el cielo lo podemos ver
            Con Don Diego y La Tota
            Alentándolo a Lionel

            Muchachos
            Ahora nos volvimos a ilusionar
            Quiero ganar la tercera
            Quiero ser campeón mundial

            Y al Diego
            Desde el cielo lo podemos ver
            Con Don Diego y La Tota
            Alentándolo a Lionel, y ser campeones otra vez, y ser campeones otra vez
            */

    }
}