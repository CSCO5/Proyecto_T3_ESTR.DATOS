using Proyecto_T3_ESTR.DATOS.Codigo_árbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Codigo_Cola
{
    public class NodoCola
    {
        public Cliente datos;
        public NodoCola siguiente;
        public NodoCola(Cliente datos)
        {
            this.datos = datos;
            siguiente = null;
        }
    }
}
