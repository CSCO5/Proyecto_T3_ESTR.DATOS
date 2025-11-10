using Proyecto_T3_ESTR.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Nodo_simple
    {
        public Medicamento datos;
        public Nodo_simple next;
        public Nodo_simple(Medicamento datos)
        {
            this.datos = datos;
            next = null;
        }
    }
}
