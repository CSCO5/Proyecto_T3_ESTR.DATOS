using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS.CircularDoble
{
    public class ListaCircular
    {
        NodoCircular buscar, cabeza;
        int numCama = 1;
        public ListaCircular()
        {
            cabeza = null;
        }


        public void Agregar(Cliente datos)
        {
            NodoCircular nuevo = new NodoCircular(datos, numCama.ToString());
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.siguiente = cabeza;
                cabeza.anterior = cabeza;
                numCama++;
                return;
            }
            NodoCircular tail = cabeza.anterior;
            tail.siguiente = nuevo;
            nuevo.anterior = tail;
            nuevo.siguiente = cabeza;
            cabeza.anterior = nuevo;
            numCama++;
        }

        //Funciones para modificar el estado de una cama con los datos del cliente
        public void Cliente_A_Cama(string apellido)
        {
            NodoCircular aux = cabeza;
            do
            {
                if (aux.cama.estado == "Libre")
                {
                    aux.datos = UseArbol.a.mandar(apellido);
                    aux.cama.estado = "Ocupado";
                    return;
                }
                aux = aux.siguiente;
            } while (aux != cabeza);
        }
        public void Liberar_cama()
        {
            buscar.cama.estado = "Libre";
            buscar.datos = null;
        }
        // -> metodos para mover la posición actual del nodo
        public void Inicio(DataGridView d, Label titulo)
        {
            buscar = cabeza;
            titulo.Text = buscar.cama.numCama;
            d.Rows.Clear();
            d.Rows.Add(buscar?.datos?.Apellido, buscar?.datos?.Dni, buscar.cama.estado);
        }
        public void Siguiente(DataGridView d, Label titulo)
        {
            buscar = buscar.siguiente;
            titulo.Text = buscar?.cama.numCama;
            d.Rows.Clear();
            d.Rows.Add(buscar?.datos?.Apellido, buscar?.datos?.Dni, buscar.cama.estado);
        }
        public void Anterior(DataGridView d, Label titulo)
        {
            buscar = buscar.anterior;
            titulo.Text = buscar?.cama.numCama;
            d.Rows.Clear();
            d.Rows.Add(buscar?.datos?.Apellido, buscar?.datos?.Dni, buscar.cama.estado);
        }
    }
    public static class Circular
    {
        public static ListaCircular lc = new ListaCircular();
    }
}
