using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace GeneratedPhotosApiExplorer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            builder.AddUserSecrets<Program>();

            IConfigurationRoot configuration = builder.Build();

            var repository = new FacesRepository(configuration);
            var faces = await repository.GetFaces(new Parameters(Ethnicity.White, Gender.Female, Age.Adult));
        }
    }
}


