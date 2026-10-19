using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppProyectoIntegradorPOO.Repository;

namespace WinFormsAppProyectoIntegradorPOO
{
    public partial class Form2Prueba : Form
    {
        public Form2Prueba()
        {
            InitializeComponent();
            
        }
        private void Form2Prueba_Load(object sender, EventArgs e)
        {

            DbConnectionPostgreSql conn = new DbConnectionPostgreSql(
        "localhost",
        5432,
        "winform_proyecto_integrador_poo",
        "postgres",
        "43798911"
    );
            ProductRepository productos = ProductRepository.getInstance(conn);
            productos.create("hyhhhhhhhhhhhhhh");
            showProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void showProducts()
        {
            DbConnectionPostgreSql conn = new DbConnectionPostgreSql(
        "localhost",
        5432,
        "winform_proyecto_integrador_poo",
        "postgres",
        "43798911");
            ProductRepository repository = ProductRepository.getInstance(conn);

            dataGridView1.DataSource = repository.get();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
