using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumerDisneyIdApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.disneyapi.dev/character/423";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    DisneyResponse result = JsonSerializer.Deserialize<DisneyResponse>(jsonResponse);

                    if (result?.Data != null)
                    {
                        Console.WriteLine("Nome:");
                        Console.WriteLine(result.Data.Name);
                        Console.WriteLine("\nImagem:");
                        Console.WriteLine(result.Data.ImageUrl);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível obter os dados do personagem.");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Erro ao consultar a API: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro inesperado: {e.Message}");
                }
            }
        }
    }
}