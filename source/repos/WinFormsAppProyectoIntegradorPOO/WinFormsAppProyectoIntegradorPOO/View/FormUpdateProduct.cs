using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppProyectoIntegradorPOO.Controller;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO
{
    public partial class FormUpdateProduct : Form
    {
        DbConnectionPostgreSql conn = new DbConnectionPostgreSql(
       "localhost",
       5432,
       "winform_proyecto_integrador_poo",
       "postgres",
       "43798911"
   );
        private ProductDTO product;
        private ProductController productController;
        public FormUpdateProduct(ProductDTO productDTO)
        {
            InitializeComponent();
            this.product = productDTO;
            productController = new ProductController();

            txtName.Text = product.name;
            txtPrice.Text = product.unitPrice.ToString();
        }
        private void keepProduct()
        {
            string name = txtName.Text;
            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("El precio ingresado no es válido.");
            }

            product.name = name;
            product.unitPrice = price;

            productController.updateProduct(product, conn);
        }
        private void bttnKeep_Click(object sender, EventArgs e)
        {
            keepProduct();
            this.Close();
        }
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
