using Clase___Laboratorio___25_05_2024.Data;
using Clase___Laboratorio___25_05_2024.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase___Laboratorio___25_05_2024
{
    public partial class Form1 : Form
    {
        Consola VConsola = new Consola();

        private ConsolasBD cconsola;

        public Form1()
        {
            InitializeComponent();
            cconsola = new ConsolasBD("localhost", "root", "59104667");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Grindview para mostrar datos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_cargar_datos_Click(object sender, EventArgs e)
        {
            dataGridView_Mostrar_datos.DataSource = cconsola.LeerConsolas();
        }



        //==========================================================================
        private void label_compania_Click(object sender, EventArgs e)
        {

        }
    }
}
