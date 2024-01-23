namespace DummyForm.View
{
    partial class ProductsList
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
            id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            discountPercentage = new DataGridViewTextBoxColumn();
            rating = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            thumbnail = new DataGridViewTextBoxColumn();
            ConsultaExample = new Button();
            TitleProductsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, title, description, price, discountPercentage, rating, stock, brand, category, thumbnail });
            dataGridView1.Location = new Point(38, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 150);
            dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // title
            // 
            title.HeaderText = "Título";
            title.Name = "title";
            // 
            // description
            // 
            description.HeaderText = "Descripción";
            description.Name = "description";
            // 
            // price
            // 
            price.HeaderText = "Precio";
            price.Name = "price";
            // 
            // discountPercentage
            // 
            discountPercentage.HeaderText = "Descuento";
            discountPercentage.Name = "discountPercentage";
            // 
            // rating
            // 
            rating.HeaderText = "Calificación";
            rating.Name = "rating";
            // 
            // stock
            // 
            stock.HeaderText = "Cantidad disponible";
            stock.Name = "stock";
            // 
            // brand
            // 
            brand.HeaderText = "Marca";
            brand.Name = "brand";
            // 
            // category
            // 
            category.HeaderText = "Categoría";
            category.Name = "category";
            // 
            // thumbnail
            // 
            thumbnail.HeaderText = "Thumbnail";
            thumbnail.Name = "thumbnail";
            // 
            // ConsultaExample
            // 
            ConsultaExample.Location = new Point(636, 302);
            ConsultaExample.Name = "ConsultaExample";
            ConsultaExample.Size = new Size(127, 23);
            ConsultaExample.TabIndex = 4;
            ConsultaExample.Text = "Obtener ejemplo";
            ConsultaExample.UseVisualStyleBackColor = true;
            ConsultaExample.Click += ConsultaExample_Click;
            // 
            // TitleProductsLabel
            // 
            TitleProductsLabel.AutoSize = true;
            TitleProductsLabel.Location = new Point(38, 44);
            TitleProductsLabel.Name = "TitleProductsLabel";
            TitleProductsLabel.Size = new Size(122, 15);
            TitleProductsLabel.TabIndex = 5;
            TitleProductsLabel.Text = "Productos registrados";
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TitleProductsLabel);
            Controls.Add(ConsultaExample);
            Controls.Add(dataGridView1);
            Name = "ProductsList";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn discountPercentage;
        private DataGridViewTextBoxColumn rating;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn thumbnail;
        private Button ConsultaExample;
        private Label TitleProductsLabel;
    }
}