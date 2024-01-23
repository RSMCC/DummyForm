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
        public AddProduct()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Title = idInput.Text;
            product.Price = int.Parse(priceInput.Text);
            product.Id = int.Parse(idInput.Text);

        }
    }
}
