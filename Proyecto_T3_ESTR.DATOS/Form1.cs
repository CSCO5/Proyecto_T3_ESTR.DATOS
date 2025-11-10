using Proyecto_T3_ESTR.DATOS.CircularDoble;
using Proyecto_T3_ESTR.DATOS.Codigo_Cola;
using Proyecto_T3_ESTR.DATOS.Grafo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_T3_ESTR.DATOS
{
    public partial class Form1 : Form
    {
        Cola c = new Cola();

        Lista_doble l = new Lista_doble();
        //se generan las listas de datos de cada medicamento
        Lista_simple l1 = new Lista_simple();
        Lista_simple l2 = new Lista_simple();
        Lista_simple l3 = new Lista_simple();
        Lista_simple l4 = new Lista_simple();
        Lista_simple l5 = new Lista_simple();
        public Form1()
        {
            InitializeComponent();
            getDatos();
            //Insertamos cada lista de datos dentro de la lista simple
            l.Insertar("medicamentos 1", l1);
            l.Insertar("medicamentos 2", l2);
            l.Insertar("medicamentos 3", l3);
            l.Insertar("medicamentos 4", l4);
            l.Insertar("medicamentos 5", l5);
            l.Imprimir(l.Inicio(), label5, dataGridView2);

            //generamos la cantidad de camas que se desee
            for (int i = 0; i < 10; i++)
            {
                Circular.lc.Agregar(null);
            }
            Circular.lc.Inicio(dataGridView4, label9);
        }

        //Metodo auxiliar para generar los datos del medicamento en cada lista
        private void getDatos()
        {
            l1.insertar(new Medicamento("a1", 1, 0));
            l2.insertar(new Medicamento("b2", 2, 0));
            l3.insertar(new Medicamento("c3", 3, 0));
            l4.insertar(new Medicamento("d4", 4, 0));
            l5.insertar(new Medicamento("e5", 5, 0));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            c.Encolar(new Cliente(txtNombres.Text, txtApellidos.Text, Convert.ToInt32(txtDni.Text), comboBox1.Text));
            c.Imprimir(dataGridView3);
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//atendemos al cliente y enviamos los datos al árbol
        {
            UseArbol.a.Insertar(c.Desencolar());
            UseArbol.a.Imprimir(dataGridView1);
            c.Imprimir(dataGridView3);
        }

        //cambiamos la posicion del nodo para ver las otras listas y ver los datos de otros medicamentos
        private void Med_anterior_Click(object sender, EventArgs e)
        {
            l.Imprimir(l.anterior(), label5, dataGridView2);
        }

        private void sig_cliente_Click(object sender, EventArgs e)
        {
            l.Imprimir(l.siguiente(), label5, dataGridView2);
        }

        //buscamos a un cliente en el hospital
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            UseArbol.a.Buscar(txtBuscarApellido.Text);
        }

        private void NuevoTramite_Click(object sender, EventArgs e)
        {
            //verificamos si se eligio un tramite y lo añadimos al historial del cliente
            if (comboBox2.Text != "")
            {
                UseArbol.a.NewTramite(txtBuscarApellido.Text, comboBox2.Text);
                MessageBox.Show("Nuevo tramite hecho");
            }
        }

        private void button3_Click(object sender, EventArgs e)//mostramos el historial de cliente
        {
            if (txtBuscarApellido.Text == "")
            {
                MessageBox.Show("Escriba un nombre en la caja de texto primero");
                return;
            }
            HistorialCliente history = new HistorialCliente(txtBuscarApellido.Text);
            history.ShowDialog();
        }

        private void MandarACama_Click(object sender, EventArgs e)
        {
            Circular.lc.Cliente_A_Cama(txtBuscarApellido.Text);
        }

        //Cambiamos la posición de la cama se que observa
        private void button1_Click(object sender, EventArgs e)
        {
            Circular.lc.Siguiente(dataGridView4, label9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Circular.lc.Anterior(dataGridView4, label9);
        }

        //Liberamos la cama que este ocupada
        private void LiberarCama_Click(object sender, EventArgs e)
        {
            Circular.lc.Liberar_cama();
        }

        //Mostramos a los doctores que estan en el hospital
        private void VerDoctores_Click(object sender, EventArgs e)
        {
            DoctoresHospital doc = new DoctoresHospital();
            doc.ShowDialog();
        }
    }
}
