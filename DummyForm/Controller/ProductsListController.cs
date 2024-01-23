using DummyForm.Model;
using DummyForm.Modelo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace DummyForm.Controller
{
    public class ProductsListController
    {
        public async Task getProducts( DataGridView productsList)
        {
            string apiUrl = "https://dummyjson.com/products/";
            string responseData = await GetApiResponse(apiUrl);
            var responseObj = JsonConvert.DeserializeObject<ApiResponse>(responseData);
            List < Product > products = responseObj.Products;
            productsList.Rows.Clear();
            foreach (Product product in products)
            {
                productsList.Rows.Add(product.Id, product.Title, product.Description,
                    product.Price, product.DiscountPercentage, product.Rating, product.Stock,
                    product.Brand, product.Category, product.Thumbnail);
            }
           
        }

        static async Task<string> GetApiResponse(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error en la solicitud. Código de estado: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
                    return null;
                }
            }
        }
        public async Task AddProduct(Product newProduct)
        {
            string apiUrl = "https://dummyjson.com/products/add";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonProduct = JsonConvert.SerializeObject(newProduct);

                    StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(newProduct.Title + "agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show($"Error en la solicitud. Código de estado: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
                }
            }
        }
        public async Task UpdateProduct(Product updatedProduct, int id)
        {
            string apiUrl = "https://dummyjson.com/products/" + id;


            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonProduct = JsonConvert.SerializeObject(updatedProduct);

                    StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show($"Error en la solicitud. Código de estado: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
                }
            }
        }
    }
}
