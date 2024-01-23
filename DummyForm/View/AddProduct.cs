using DummyForm.Controller;
using DummyForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyForm.View
{
    public partial class AddProduct : Form
    {
        ProductsListController productsListController;
        public AddProduct()
        {
            productsListController = new ProductsListController();
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(idInput.Text);
            product.Title = titleInput.Text;
            product.Price = int.Parse(priceInput.Text);
            MessageBox.Show(product.Title);
            productsListController.AddProduct(product);
            this.Close();
        }
    }
}
