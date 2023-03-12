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
            Una lista de items que se encuentren en la tienda
            Una lista de items que se encuentren reservados

        Aqui se puede: 
            -Buscar si un item esta disponible o reservado; 
                                                **(revisar)**
            -Buscar items por una unica cualidad
                                                **(pendiente)**
            -Marcar un item como reservado o disponible; 
                                                **(revisar)**
            -Comprar un item disponible (porque va a estar dificil pedir 
                                        la comprobacion para comprar 
                                        desde reservacion)
         */
        List<Item> Disponibles { set; get; }
        List<Item> Reservados { set; get; }
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
      
        public int ComprobarUnidades(Item item, string lugar)
        {
            //Revisa si hay suficientes unidades de cierto objeto dependiendo
            //el lugar de busqueda
            List<Item> aux = new List<Item>(); 
            if(lugar.Equals("Reservados"))
            {
                foreach(Item buscar in Reservados)
                {
                    if(buscar == item)
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
