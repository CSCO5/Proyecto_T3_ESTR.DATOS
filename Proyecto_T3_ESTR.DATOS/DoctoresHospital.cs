using Proyecto_T3_ESTR.DATOS.Grafo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_T3_ESTR.DATOS.Constructores;

namespace Proyecto_T3_ESTR.DATOS
{
    public partial class DoctoresHospital : Form
    {
        public DoctoresHospital()
        {
            InitializeComponent();
            UseGrafo.g.Insertar(new Doctores("Doctor a", "apellido a", "Médico general", 1265));
            UseGrafo.g.Insertar(new Doctores("Doctor b", "apellido b", "Cirujano", 11498225));
            UseGrafo.g.Insertar(new Doctores("Doctor c", "apellido c", "Obstetra", 1216615));
            UseGrafo.g.Insertar(new Doctores("Doctor d", "apellido d", "Pediatra", 16816));
            UseGrafo.g.Insertar(new Doctores("Doctor e", "apellido e", "Cirujano", 11498575));
            UseGrafo.g.Insertar(new Doctores("Doctor f", "apellido f", "Médico general", 1265365));
            UseGrafo.g.Insertar(new Doctores("Doctor g", "apellido g", "Médico general", 1186265));
            UseGrafo.g.Insertar(new Doctores("Doctor h", "apellido h", "Pediatra", 26948885));
            UseGrafo.g.Insertar(new Doctores("Doctor i", "apellido i", "Obstetra", 1216265));
            UseGrafo.g.Insertar(new Doctores("Doctor j", "apellido j", "Cirujano", 114985895));
            UseGrafo.g.Insertar(new Doctores("Doctor k", "apellido k", "Pediatra", 269485546));
            UseGrafo.g.Insertar(new Doctores("Doctor l", "apellido l", "Obstetra", 121698335));
            UseGrafo.g.Insertar(new Doctores("Doctor m", "apellido m", "Cirujano", 1149811165));
            UseGrafo.g.Insertar(new Doctores("Doctor n", "apellido n", "Cirujano", 114985988));
            UseGrafo.g.Insertar(new Doctores("Doctor o", "apellido o", "Médico general", 12684935));
            UseGrafo.g.Insertar(new Doctores("Doctor p", "apellido p", "Pediatra", 26988925));
            UseGrafo.g.Insertar(new Doctores("Doctor q", "apellido q", "Cirujano", 11498985));
            UseGrafo.g.Insertar(new Doctores("Doctor r", "apellido r", "Médico general", 11655265));
            UseGrafo.g.Imprimir(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UseGrafo.g.Imprimir(comboBox1.SelectedItem.ToString(), dataGridView1);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            UseGrafo.g.Imprimir(dataGridView1);
        }
    }
}
