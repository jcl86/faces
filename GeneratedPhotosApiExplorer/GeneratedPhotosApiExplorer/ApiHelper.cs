using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeneratedPhotosApiExplorer
{
    public static class ApiHelper
    {
        public static async Task<TModel> ReadJsonResponse<TModel>(this HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TModel>(json);
            return result;
        }
    }

}


