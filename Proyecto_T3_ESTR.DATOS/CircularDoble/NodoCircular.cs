using Proyecto_T3_ESTR.DATOS.Constructores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.CircularDoble
{
    public class NodoCircular
    {
        public Cliente datos;
        public CamasDisponibles cama;
        public NodoCircular siguiente;
        public NodoCircular anterior;
        public NodoCircular(Cliente datos, string numcama)
        {
            this.datos = datos;
            cama = new CamasDisponibles("Libre", numcama);
            cama.estado = "Libre";
            cama.numCama = numcama;
            siguiente = null;
            anterior = null;
        }
    }
}
