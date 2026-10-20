namespace WinFormsAppProyectoIntegradorPOO
{
    partial class Form2Prueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            MostrarProducto = new Button();
            AddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MostrarProducto
            // 
            MostrarProducto.Location = new Point(12, 168);
            MostrarProducto.Name = "MostrarProducto";
            MostrarProducto.Size = new Size(95, 23);
            MostrarProducto.TabIndex = 5;
            MostrarProducto.Text = "Ver productos";
            MostrarProducto.UseVisualStyleBackColor = true;
            MostrarProducto.Click += MostrarProducto_Click;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(12, 197);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(113, 23);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Agregar Producto";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // Form2Prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddProduct);
            Controls.Add(MostrarProducto);
            Controls.Add(dataGridView1);
            Name = "Form2Prueba";
            Text = "Form2Prueba";
            Load += Form2Prueba_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button MostrarProducto;
        private Button AddProduct;
    }
}