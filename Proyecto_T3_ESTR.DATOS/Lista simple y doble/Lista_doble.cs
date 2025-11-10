using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Lista_doble
    {
        Nodo_doble actual, header, tail;
        public Lista_doble() => header = tail = null;

        public void Insertar(string medicamento, Lista_simple list)
        {
            string titulo = $"{medicamento}";
            Nodo_doble nuevo = new Nodo_doble(titulo, list);
            if (header == null) { header = tail = nuevo; return; }
            tail.next = nuevo;
            nuevo.back = tail;
            tail = nuevo;
        }
        public void Imprimir(Nodo_doble nodo, Label titulo, DataGridView dataG)
        {
            dataG.Rows.Clear();
            titulo.Text = nodo?.titulo;
            nodo.lista.Imprimir(dataG);
        }

        //metodos para cambiar la posición del nodo
        public Nodo_doble Inicio()
        {
            actual = header;
            return actual;
        }
        public Nodo_doble siguiente()
        {
            if (actual.next != null)
            {
                actual = actual.next;
                return actual;
            }
            return actual;
        }
        public Nodo_doble anterior()
        {
            if (actual.back != null)
            {
                actual = actual.back;
                return actual;
            }
            return header;
        }
    }
}
