using Proyecto_T3_ESTR.DATOS;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Lista_simple
    {
        Nodo_simple header;
        public Lista_simple() => header = null;

        public void insertar(Medicamento compras)
        {
            Nodo_simple nuevo = new Nodo_simple(compras);
            if (header == null) { header = nuevo; return; }
            Nodo_simple insertar = header;
            while (insertar.next != null)
            {
                insertar = insertar.next;
            }
            insertar.next = nuevo;
        }
        public void Imprimir(DataGridView lista)
        {
            if (header == null) return;
            Nodo_simple print = header;
            do
            {
                lista.Rows.Add("Nombre: " + print?.datos.nombre);
                lista.Rows.Add("Concentración: " + print?.datos.concentracion);
                lista.Rows.Add("Stock: " + print?.datos.stock);
                print = print.next;
            } while (print != null);
        }
    }
}
