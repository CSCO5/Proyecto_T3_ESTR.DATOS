using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Pila
    {
        private Nodo_pila tope;
        private int limite = 40;
        private int contador = 0;

        public void Apilar(string tramite)
        {
            Nodo_pila nuevo = new Nodo_pila(tramite);
            nuevo.Siguiente = tope;
            tope = nuevo;
            contador++;
        }

        public bool lleno() => contador == limite;

        public bool EstaVacio() => tope == null;


        public void Mostrar(DataGridView L)
        {
            L.Rows.Clear();
            if (EstaVacio())
            {
                return;
            }
            Nodo_pila aux = tope;
            while (aux != null)
            {
                L.Rows.Add(aux.tramite);
                aux = aux.Siguiente;
            }
        }


    }
}
