namespace WinFormsAppProyectoIntegradorPOO
{
    partial class FormUpdateProduct
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
            lblPrice = new Label();
            lblName = new Label();
            txtPrice = new TextBox();
            txtName = new TextBox();
            bttnKeep = new Button();
            bttnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Precio";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(776, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(776, 23);
            txtName.TabIndex = 3;
            // 
            // bttnKeep
            // 
            bttnKeep.Location = new Point(713, 159);
            bttnKeep.Name = "bttnKeep";
            bttnKeep.Size = new Size(75, 23);
            bttnKeep.TabIndex = 4;
            bttnKeep.Text = "Guardar";
            bttnKeep.UseVisualStyleBackColor = true;
            bttnKeep.Click += bttnKeep_Click;

            // 
            // bttnCancel
            // 
            bttnCancel.Location = new Point(622, 159);
            bttnCancel.Name = "bttnCancel";
            bttnCancel.Size = new Size(75, 23);
            bttnCancel.TabIndex = 5;
            bttnCancel.Text = "Cancelar";
            bttnCancel.UseVisualStyleBackColor = true;
            bttnCancel.Click += bttnCancel_Click;
            // 
            // FormUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnCancel);
            Controls.Add(bttnKeep);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Name = "FormUpdateProduct";
            Text = "FormUpdateProduct";
            Click += bttnKeep_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private Label lblName;
        private TextBox txtPrice;
        private TextBox txtName;
        private Button bttnKeep;
        private Button bttnCancel;
    }
}