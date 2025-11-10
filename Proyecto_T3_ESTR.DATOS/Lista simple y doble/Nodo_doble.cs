using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Nodo_doble
    {
        public string titulo;
        public Lista_simple lista;
        public Nodo_doble next;
        public Nodo_doble back;
        public Nodo_doble(string titulo, Lista_simple lista)
        {
            this.titulo = titulo;
            this.lista = lista;
            next = null;
            back = null;
        }
    }
}
