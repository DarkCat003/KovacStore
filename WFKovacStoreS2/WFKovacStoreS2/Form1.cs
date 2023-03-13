namespace WFKovacStoreS2
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Nombre = txbNombre.Text;
            item.Tipo = cbxTipo.ToString();
            item.Talla = cbTalla.ToString();
            item.Color = cbxColor.ToString();
            item.Marca = cbxMarca.ToString();
            item.Precio = Convert.ToInt32(mtxPrecio.Text);
            item.FechaDeListado = mtxFecha.Text;
            inventario.Agregar(item);
            Limpiar();
        }

        private void Limpiar()
        {
            txbNombre.Text = "";
            cbxTipo.SelectedIndex = -1;
            cbTalla.SelectedIndex = -1;
            cbxColor.SelectedIndex = -1;
            cbxMarca.SelectedIndex = -1;
            mtxPrecio.Text = "";
            mtxFecha.Text = "";
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            Mostrar mostrar = new Mostrar();
            mostrar.inventario = inventario;
            mostrar.Show();
        }

        private void mtxFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}