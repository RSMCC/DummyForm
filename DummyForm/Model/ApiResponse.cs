using DummyForm.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForm.Model
{
    public class ApiResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public List<Product> Products { get; set; }
        [JsonProperty("skip")]
        public int Skip { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
