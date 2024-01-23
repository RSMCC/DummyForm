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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DummyForm.View
{
    public partial class ProductsList : Form
    {
        ProductsListController productsListController;
        public ProductsList()
        {
            productsListController = new ProductsListController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            //dataGridView1.DataSource = productsListController.getProducts();
        }

        private void ConsultaExample_Click(object sender, EventArgs e)
        {
            productsListController.getProducts();
        }
    }
}
