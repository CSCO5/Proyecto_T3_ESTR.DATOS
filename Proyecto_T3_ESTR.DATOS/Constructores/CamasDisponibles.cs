using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Constructores
{
    public class CamasDisponibles
    {
        public string numCama;
        public string estado;
        public CamasDisponibles(string estado, string numCama)
        {
            this.estado = estado;
            this.numCama = numCama;
        }
    }
}
