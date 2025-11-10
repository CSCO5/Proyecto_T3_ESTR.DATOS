using Proyecto_T3_ESTR.DATOS.Constructores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Grafo
{
    public class Vertice
    {
        public Doctores datos;
        public Vertice siguiente;
        public Arista arista;
        public Vertice(Doctores datos)
        {
            this.datos = datos;
            siguiente = null;
            arista = null;
        }
        public void AñadirArista(Vertice next) // metodo para crear una arista
        {
            Arista add = new Arista(next);

            if (this.arista == null) { this.arista = add; return; }

            Arista arista = this.arista;
            while (arista.next != null) arista = arista.next;
            arista.next = add;
        }
    }
}
