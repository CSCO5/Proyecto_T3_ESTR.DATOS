using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Codigo_árbol
{
    public class Nodo_arbol
    {
        public Cliente datos;
        public Nodo_arbol derecha;
        public Nodo_arbol izquierda;
        public Nodo_arbol(Cliente datos)
        {
            this.datos = datos;
            derecha = null;
            izquierda = null;
        }
    }
}
