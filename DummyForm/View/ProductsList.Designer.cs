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
            dataProductsList = new DataGridView();
            refreshButton = new Button();
            TitleProductsLabel = new Label();
            addButton = new Button();
            editButton = new Button();
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
            Images = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataProductsList).BeginInit();
            SuspendLayout();
            // 
            // dataProductsList
            // 
            dataProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductsList.Columns.AddRange(new DataGridViewColumn[] { id, title, description, price, discountPercentage, rating, stock, brand, category, thumbnail, Images });
            dataProductsList.Location = new Point(38, 82);
            dataProductsList.Name = "dataProductsList";
            dataProductsList.Size = new Size(725, 296);
            dataProductsList.TabIndex = 3;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.DodgerBlue;
            refreshButton.ForeColor = SystemColors.Control;
            refreshButton.Location = new Point(636, 402);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(127, 36);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refrescar";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += ConsultaExample_Click;
            // 
            // TitleProductsLabel
            // 
            TitleProductsLabel.AutoSize = true;
            TitleProductsLabel.Location = new Point(38, 49);
            TitleProductsLabel.Name = "TitleProductsLabel";
            TitleProductsLabel.Size = new Size(122, 15);
            TitleProductsLabel.TabIndex = 5;
            TitleProductsLabel.Text = "Productos registrados";
            // 
            // addButton
            // 
            addButton.BackColor = Color.DodgerBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(569, 39);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 37);
            addButton.TabIndex = 8;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.DodgerBlue;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.ForeColor = SystemColors.ControlLightLight;
            editButton.Location = new Point(669, 39);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 37);
            editButton.TabIndex = 9;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
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
            // Images
            // 
            Images.HeaderText = "Links de imagenes";
            Images.Name = "Images";
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(TitleProductsLabel);
            Controls.Add(refreshButton);
            Controls.Add(dataProductsList);
            Name = "ProductsList";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataProductsList;
        private Button refreshButton;
        private Label TitleProductsLabel;
        private Button addButton;
        private Button editButton;
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
        private DataGridViewTextBoxColumn Images;
    }
}