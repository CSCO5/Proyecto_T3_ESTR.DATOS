using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Grafo
{
    public class Arista
    {
        public Vertice destino;
        public Arista next;
        public Arista(Vertice destino)
        {
            this.destino = destino;
            next = null;
        }
    }
}
