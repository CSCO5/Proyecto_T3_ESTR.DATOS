using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS.Constructores
{
    public class Doctores
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string especialidad;
        public Doctores(string nombre, string apellido, string especialidad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.dni = dni;
        }
    }
}
