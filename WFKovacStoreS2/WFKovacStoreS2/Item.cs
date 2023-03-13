using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFKovacStoreS2
{
    public class Item
    {
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public string Color { set; get; }
        public string Marca { set; get; }
        public string Talla { set; get; }
        public int Precio { set; get; }
        public string FechaDeListado { set; get; }
        public Item() { }

        public Item(string nombre, string tipo, string color, string marca, string talla, int precio, string fechaDeListado)
        {
            Nombre = nombre;
            Tipo = tipo;
            Color = color;
            Marca = marca;
            Talla = talla;
            Precio = precio;
            FechaDeListado = fechaDeListado;
        }
    }
}
