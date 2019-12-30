using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GeneratedPhotosApiExplorer
{
    public class FacesRepository : IDisposable
    {
        private readonly HttpClient client;
        private readonly string apiKey;

        public FacesRepository(IConfiguration configuration)
        {
            client = new HttpClient();
            apiKey = configuration.GetSection("ApiKey").Value;
            client.BaseAddress = new Uri($"https://api.generated.photos/api/v1/");
        }

        public async Task<IEnumerable<Face>> GetFaces(Parameters parameters)
        {
            string requestUri = $"faces?api_key={apiKey}&per_page=100&{parameters.ToString()}";

            var response = await client.GetAsync(requestUri);
            var stringContent = await response.Content.ReadAsStringAsync();
            var result = await response.ReadJsonResponse<Root>();
            return result.Faces;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }

    public class Reader
    {
        private readonly List<Face> faces;

        public Reader(List<Face> faces)
        {
            this.faces = faces;
        }

        public void Process()
        {
            foreach (var face in faces)
            {
                face.Urls
            }
        }
    }

    public class Parser
    {

    }
}


