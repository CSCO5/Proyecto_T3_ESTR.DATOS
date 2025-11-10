using Proyecto_T3_ESTR.DATOS.Codigo_árbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS.Codigo_Cola
{
    public class Cola
    {
        NodoCola tope;
        public Cola()
        {
            tope = null;
        }

        public void Encolar(Cliente datos)
        {
            NodoCola nuevo = new NodoCola(datos);
            if (tope == null)
            {
                tope = nuevo;
            }
            else
            {
                NodoCola insertar = tope;
                while (insertar.siguiente != null)
                {
                    insertar = insertar.siguiente;
                }
                insertar.siguiente = nuevo;
            }
        }
        public Cliente Desencolar()
        {
            Cliente datos = tope.datos;
            tope = tope.siguiente;
            return datos;
        }

        public void Imprimir(DataGridView d)
        {
            d.Rows.Clear();
            NodoCola imprimir = tope;
            while (imprimir != null)
            {
                d.Rows.Add(imprimir.datos.Nombre, imprimir.datos.Apellido, imprimir.datos.Dni, imprimir.datos.Tramite);
                imprimir = imprimir.siguiente;
            }
        }
    }
}
