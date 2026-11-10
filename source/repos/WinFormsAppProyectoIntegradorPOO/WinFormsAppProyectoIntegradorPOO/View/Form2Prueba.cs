using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppProyectoIntegradorPOO.Controller;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsAppProyectoIntegradorPOO
{
    public partial class Form2Prueba : Form
    {
        DbConnectionPostgreSql conn = new DbConnectionPostgreSql(
        "localhost",
        5432,
        "winform_proyecto_integrador_poo",
        "postgres",
        "43798911"
    );
        ProductController productController = new ProductController();
        public Form2Prueba()
        {
            InitializeComponent();
        }
        private void Form2Prueba_Load(object sender, EventArgs e)
        {
            ProductRepository productos = ProductRepository.getInstance(conn);
            //showProducts();
        }
        private void showProducts()
        {

            ProductRepository repository = ProductRepository.getInstance(conn);

            dataGridView1.DataSource = repository.get();
            dataGridView1.Columns["Name"].HeaderText = "Nombre";
            dataGridView1.Columns["UnitPrice"].HeaderText = "Precio";
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void MostrarProducto_Click(object sender, EventArgs e)
        {
            showProducts();
        }

        public void addProduct()
        {
            ProductDTO product = createProduct();
            productController.add(product, conn);
            showProducts();
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            addProduct();
        }


        private ProductDTO createProduct()
        {

            string name = txtName.Text;
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("El precio ingresado no es válido.");
                //throw new Exception("El precio ingresado no es válido.");
            }

            ProductDTO productoDTO = new ProductDTO(name, price);
            showProducts();

            return productoDTO;

        }

        private void deleteToolStripMenu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            ProductDTO producto = (ProductDTO)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show(
                $"¿Querés eliminar el producto {producto.name}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );


            if (resultado == DialogResult.Yes)
            {
                productController.deleteProduct(producto, conn);

                showProducts();
            }
        }

        private void modifyToolStripMenu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            ProductDTO product = (ProductDTO)dataGridView1.CurrentRow.DataBoundItem;
            FormUpdateProduct formUpdate = new FormUpdateProduct(product);

            formUpdate.ShowDialog();

            showProducts();
            
        }
        
    }
}
