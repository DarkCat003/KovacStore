using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFKovacStoreS2
{
    internal class Inventario
    {
        /*
        Atributos:
            Una lista de items que se encuentren en la tienda **(listo)**
            Una lista de items que se encuentren reservados **(listo)**
            
        Aqui se puede: 
            -Buscar si un item esta disponible o reservado; 
                    -añadir a disponibles **(listo)** [Rgregar()]
                    -añadir a reservados **(listo)** [Reservar()]
                    -comprobar las unidades disponibles **(listo)** [ComprobarUnidades()]
                    -trasladar de reservados a disponibles **(listo)** [CambiarDisponibilidad()]
                                                
            -Buscar items por una unica cualidad
                                                **(listo)**
                                                
            -Marcar un item como reservado o disponible;
                                                **(listo)**
                                                
            -Comprar un item disponible (porque va a estar dificil pedir 
                                        la comprobacion para comprar 
                                        desde reservacion) **(listo)**
         */
        public List<Item> Disponibles { set; get; }
        public List<Item> Reservados { set; get; }

        public Inventario() 
        {
            Disponibles = new List<Item>();
            Reservados = new List<Item>();
        }
        
        public void Agregar(Item item) 
        {
            Disponibles.Add(item);
        }

        public void Reservar(Item item)
        {
            Reservados.Add(item);
        }

        public int ComprobarUnidades(Item item, string lugar)
        {
            //Revisa si hay suficientes unidades de cierto objeto dependiendo
            //el lugar de busqueda
            List<Item> aux = new List<Item>();
            if (lugar.Equals("Reservados"))
            {
                foreach (Item buscar in Reservados)
                {
                    if (buscar == item)
                    {
                        aux.Add(buscar);
                    }
                }
            }
            else
            {
                foreach (Item buscar in Disponibles)
                {
                    if (buscar == item)
                    {
                        aux.Add(buscar);
                    }
                }
            }
            return aux.Count();
        }

        public List<Item> BuscarPorObjeto(Item item, string lugar)
        {
            //Recibe un objeto de tipo item y devuelve una lista de items de la
            //lista disponibles que coincidan con las caracteristicas del item
            List<Item> aux = new List<Item>();
            if(lugar.Equals("Disponibles"))
            {
                foreach (Item item2 in Disponibles)
                {
                    if (item == item2)
                    {
                        aux.Add(item2);
                    }
                }
            }
            else
            {
                foreach (Item item2 in Reservados)
                {
                    if (item.Nombre.Equals(item2.Nombre))
                    {
                        aux.Add(item2);
                    }
                }
            }
            return aux;
        } 

        public List<Item> BuscarPorCualidad(string seleccion, string cualidad)
        {
            //Recibe un parametro de busqueda y la cualidad a buscar en la lista
            //Devuelve una lista con los elementos encontrados
            //Caso contrario devuelve un mensaje de error
            List<Item> aux = new List<Item>();
            switch(seleccion)
            {
                case "Nombre":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Nombre.Equals(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "Tipo":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Tipo.Equals(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "Color":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Color.Equals(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "Marca":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Marca.Equals(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "Talla":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Talla.Equals(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "Precio":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Precio == Convert.ToInt32(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                case "FechaDeListado":
                    foreach (Item item2 in Disponibles)
                    {
                        if (item2.Precio == Convert.ToInt32(cualidad))
                        {
                            aux.Add(item2);
                        }
                    }
                    break;

                default:
                    MessageBox.Show("No se encontraron elementos disponibles con esa cualidad");
                    break;
            }
            return aux;
        }

        public void CambiarDisponibilidad(Item item, string lugar, int cantidad)
        {
            //Recibe un objeto guia, una orden de movimiento y una cantidad,
            //revisa si existen suficientes unidades y realiza el cambio; 
            //envia un mensaje de error si no existen suficientes unidades
            if (lugar.Equals("Reservar"))
            {
                if(BuscarPorObjeto(item, "Reservados").Count >= cantidad)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Disponibles.Remove(item);
                        Reservar(item);
                    }
                    MessageBox.Show("Item(s) reservados!");
                }
                else
                {
                    MessageBox.Show("No se pudo reservar porque la cantidad de items " +
                                    "disponibles es menor a la cantidad solicitada");
                }
            }
            else
            {
                if (BuscarPorObjeto(item, "Disponibles").Count >= cantidad)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Reservados.Remove(item);
                        Disponibles.Add(item);
                    }
                    MessageBox.Show("Item(s) liberados!");
                }
                else
                {
                    MessageBox.Show("No se pudo liberar porque la cantidad de items " +
                                    "reservados es menor a la cantidad solicitada");
                }
            }
        }
        
        public void Comprar(Item item, int cantidad)
        {
            //Recibe un objeto guia y una cantidad
            //remueve de la lista disponibles los objetos que coincidan
            //acorde a la cantidad
            if(ComprobarUnidades(item, "Disponibles") >= cantidad)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Disponibles.Remove(item);
                }
                MessageBox.Show("Item comprado con exito!");
            }
        }
    }
}
