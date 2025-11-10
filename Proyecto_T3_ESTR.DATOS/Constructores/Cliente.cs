using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Cliente
    {
        public Pila historial;
        public string Nombre, Apellido, Tramite;
        public int Dni;

        public Cliente(string nombre, string apellido, int dni, string tramite)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Tramite = tramite;
            historial = new Pila();
            historial.Apilar(tramite);
        }

    }
}
