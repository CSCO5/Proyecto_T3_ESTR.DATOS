using Proyecto_T3_ESTR.DATOS.Constructores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS.Grafo
{
    public class Grafo
    {
        Vertice inicio;

        public Grafo()
        {
            inicio = null;
        }

        //metodos para insertar un vertice y generar las aristas de forma automatica 
        public void Insertar(Doctores dato)
        {
            Vertice nuevo = new Vertice(dato);
            if (inicio == null) { inicio = nuevo; return; }
            Vertice aux = inicio;
            while (aux.siguiente != null) aux = aux.siguiente;
            aux.siguiente = nuevo;
            InsertarArista(dato.especialidad, dato.dni.ToString());
        }
        public void InsertarArista(string vertice, string destino)
        {
            Vertice origen = buscar(vertice);
            Vertice llegada = buscar(destino);
            if (origen == null || llegada == null) return;
            origen.AñadirArista(llegada);
        }
        public Vertice buscar(string especialidad)
        {
            if (inicio == null) return null;
            Vertice aux = inicio;
            while (aux != null)
            {
                if (aux.datos.especialidad == especialidad || aux.datos.dni.ToString() == especialidad)
                    return aux;
                aux = aux.siguiente;
            }
            return aux;
        }

        //metodo para imprimir a los dotores filtrados por si especialidad
        public void Imprimir(string especialidad, DataGridView d)
        {
            d.Rows.Clear();
            Vertice seccion = buscar(especialidad);
            if (seccion == null) return;
            d.Rows.Add(seccion.datos.nombre, seccion.datos.apellido, seccion.datos.dni, seccion.datos.especialidad);

            Arista a = seccion.arista;
            while (a != null)
            {
                d.Rows.Add(a.destino.datos.nombre, a.destino.datos.apellido, a.destino.datos.dni, a.destino.datos.especialidad);
                a = a.next;
            }
        }

        //metodo para imprimir todos los doctores
        public void Imprimir(DataGridView d)
        {
            d.Rows.Clear();
            Vertice aux = inicio;
            while (aux != null)
            {
                d.Rows.Add(aux.datos.nombre, aux.datos.apellido, aux.datos.dni, aux.datos.especialidad);
                aux = aux.siguiente;
            }
        }
    }
    public static class UseGrafo//clase estatica para acceder desde cualquier lugar al grafo
    {
        public static Grafo g = new Grafo();
    }
}
