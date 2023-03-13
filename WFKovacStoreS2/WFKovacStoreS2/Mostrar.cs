using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFKovacStoreS2
{
    public partial class Mostrar : Form
    {
        public Inventario inventario = new Inventario();
        public Mostrar()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtgvMostrar.DataSource = inventario.BuscarPorCualidad(cbxSeleccion.Text, txtBuscar.Text);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            dtgvMostrar.DataSource = inventario.Disponibles;
        }
    }
}
