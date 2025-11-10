using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    internal class Nodo_pila
    {
        public string tramite;
        public Nodo_pila Siguiente;
        public Nodo_pila Anterior;


        public Nodo_pila(string tramite)
        {
            this.tramite = tramite;
            Siguiente = null;
            Anterior = null;
        }
    }
}
