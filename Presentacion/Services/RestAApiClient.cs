using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class RestApiClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public RestApiClient(string baseUrl)
    {
        _httpClient = new HttpClient();
        _baseUrl = baseUrl;
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        // Manejar errores según sea necesario
        return default;
    }

    // Puedes agregar métodos adicionales para manejar otros tipos de solicitudes (POST, PUT, etc.)
}
