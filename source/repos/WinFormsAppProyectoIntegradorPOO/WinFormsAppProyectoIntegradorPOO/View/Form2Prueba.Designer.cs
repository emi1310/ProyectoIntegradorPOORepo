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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenu = new ToolStripMenuItem();
            modifyToolStripMenu = new ToolStripMenuItem();
            MostrarProducto = new Button();
            AddProduct = new Button();
            txtName = new TextBox();
            label1 = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(263, 150);
            dataGridView1.TabIndex = 4;
            
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenu, modifyToolStripMenu });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 48);
            // 
            // deleteToolStripMenu
            // 
            deleteToolStripMenu.Name = "deleteToolStripMenu";
            deleteToolStripMenu.Size = new Size(177, 22);
            deleteToolStripMenu.Text = "Eliminar Producto";
            deleteToolStripMenu.Click += deleteToolStripMenu_Click;
            // 
            // modifyToolStripMenu
            // 
            modifyToolStripMenu.Name = "modifyToolStripMenu";
            modifyToolStripMenu.Size = new Size(177, 22);
            modifyToolStripMenu.Text = "Modificar Producto";
            modifyToolStripMenu.Click += modifyToolStripMenu_Click;
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
            AddProduct.Location = new Point(314, 139);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(113, 23);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Guardar";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(314, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(113, 23);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "Ingresar producto";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(405, 306);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(315, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(112, 23);
            txtPrice.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Precio";
            // 
            // Form2Prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(AddProduct);
            Controls.Add(MostrarProducto);
            Controls.Add(dataGridView1);
            Name = "Form2Prueba";
            Text = "Form2Prueba";
            Load += Form2Prueba_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button MostrarProducto;
        private Button AddProduct;
        private TextBox txtName;
        private Label label1;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem deleteToolStripMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modifyToolStripMenu;
    }
}