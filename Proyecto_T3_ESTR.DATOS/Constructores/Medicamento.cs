using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_ESTR.DATOS
{
    public class Medicamento
    {
        public string nombre;
        public decimal concentracion;
        public int stock;
        public Medicamento(string nombre, decimal concentracion, int stock)
        {
            this.nombre = nombre;
            this.concentracion = concentracion;
            this.stock = stock;
        }
    }
}
