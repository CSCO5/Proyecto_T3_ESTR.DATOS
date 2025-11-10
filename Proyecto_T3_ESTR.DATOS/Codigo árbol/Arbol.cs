using Proyecto_T3_ESTR.DATOS.Codigo_árbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Arbol
    {
        Nodo_arbol raiz;

        public void Insertar(Cliente datos)
        {
            raiz = Insertar(raiz, datos);
        }
        private Nodo_arbol Insertar(Nodo_arbol select, Cliente datos)
        {
            if (select == null) return new Nodo_arbol(datos);

            if (string.Compare(datos.Apellido, select.datos.Apellido, StringComparison.OrdinalIgnoreCase) > 0 && datos.Dni != select.datos.Dni)
                select.derecha = Insertar(select.derecha, datos);
            else if (string.Compare(datos.Apellido, select.datos.Apellido, StringComparison.OrdinalIgnoreCase) < 0 && datos.Dni != select.datos.Dni)
                select.izquierda = Insertar(select.izquierda, datos);
            return select;
        }

        //metodo para imprimir los clientes
        public void Imprimir(DataGridView d)
        {
            d.Rows.Clear();
            InOrder(raiz, d);
        }
        private void InOrder(Nodo_arbol print, DataGridView d)
        {
            if (print == null) return;
            InOrder(print.izquierda, d);
            d.Rows.Add(print.datos.Nombre, print.datos.Apellido, print.datos.Dni);
            InOrder(print.derecha, d);
        }

        //metodo para mostrar el historial de un cliente especifico
        public void VerHistorial(string apellido, DataGridView data)
        {
            Nodo_arbol datos = Buscar(raiz, apellido);
            datos.datos.historial.Mostrar(data);
        }

        //metodo de busqueda
        public void Buscar(string apellido)
        {
            Nodo_arbol busq = Buscar(raiz, apellido);
            if (busq == null) return;
            MessageBox.Show($"{busq.datos.Apellido}\n {busq.datos.Nombre}\n {busq.datos.Dni}");
        }
        private Nodo_arbol Buscar(Nodo_arbol nodo, string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido)) return null;
            while (nodo != null)
            {
                if (string.Compare(apellido, nodo.datos.Apellido, StringComparison.OrdinalIgnoreCase) == 0) return nodo;
                else if (string.Compare(apellido, nodo.datos.Apellido, StringComparison.OrdinalIgnoreCase) < 0) nodo = nodo.izquierda;
                else nodo = nodo.derecha;
            }
            return null;
        }

        //mtodo para mandar lo datos del cliente a una cama
        public Cliente mandar(string apellido)
        {
            Nodo_arbol cliente = Buscar(raiz, apellido);
            return cliente.datos;
        }

        //metodo para agregar un nuevo tramite al historial del cliente
        public void NewTramite(string apellido, string tramite)
        {
            Nodo_arbol pos = Buscar(raiz, apellido);
            if (pos == null) return;
            pos.datos.historial.Apilar(tramite);
        }

    }

    public static class UseArbol //Clase estatica para acceder a la instancia del árbol desde cualquier lugar 
    {
        public static Arbol a = new Arbol();
    }
}
