using DummyForm.Modelo;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DummyForm.Controller
{
    public class ProductsListController
    {
        public async void getProducts()
        {
            string apiUrl = "https://dummyjson.com/products/";
            string responseData = await GetApiResponse(apiUrl);
            //var result = JsonConvert.DeserializeObject<Dictionary<string, List<Product>>>(responseData);
            MessageBox.Show("Datos obtenidos: " + responseData);
           
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
                        Console.WriteLine($"Error en la solicitud. Código de estado: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
