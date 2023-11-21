using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Asegúrate de tener la referencia a la librería Newtonsoft.Json
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // O cualquier otro espacio de nombres necesario
using System.Net.Http.Json;
using Presentacion.Models;

public class ProductoController : Controller
{
    private readonly HttpClient _httpClient;

    public ProductoController()
    {
        // Configura la URL base del servicio REST
        string apiUrl = "https://tu-servicio-rest.com/api/productos";
        _httpClient = new HttpClient { BaseAddress = new Uri(apiUrl) };
    }

    public async Task<IActionResult> ObtenerProductos()
    {
        // Realiza una solicitud GET al servicio REST
        HttpResponseMessage response = await _httpClient.GetAsync("/obtenerproductos");

        // Verifica si la solicitud fue exitosa
        if (response.IsSuccessStatusCode)
        {
            // Lee el contenido de la respuesta como una cadena JSON
            string jsonContent = await response.Content.ReadAsStringAsync();

            // Deserializa la cadena JSON a objetos C#
            //List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(jsonContent);
            List<Producto>? listaProductos = JsonConvert.DeserializeObject<List<Producto>>(jsonContent);


            // Ahora, puedes utilizar la lista de productos en tu lógica de presentación
            return View(listaProductos);
        }
        else
        {
            // Manejar el caso de respuesta no exitosa
            return View("Error");
        }
    }
}
