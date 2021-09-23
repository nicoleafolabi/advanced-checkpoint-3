using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AppLibrary
{
    public record Places (string name, double[] position);
    public class Fetching
    {
        public static async Task<List<Places>> GetDataFromHttp()
        {
            var client = new HttpClient();
            var jsonTask = client.GetFromJsonAsync<List<Places>>("https://raw.githubusercontent.com/chyld/datasets/main/markers.json");
            await Task.WhenAll(jsonTask);

            if (jsonTask.Status != TaskStatus.RanToCompletion) throw new Exception("JSON did not run to completion");

            return (jsonTask.Result);
        }
    }
}
