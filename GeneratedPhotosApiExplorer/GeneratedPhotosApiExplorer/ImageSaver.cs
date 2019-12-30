using System;
using System.Net;

namespace GeneratedPhotosApiExplorer
{
    public class ImageSaver
    {
        private readonly string origin;
        private readonly Uri destiny;

        public ImageSaver(string origin, Uri destiny)
        {
            this.origin = origin;
            this.destiny = destiny;
        }

        public void Save()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(origin, destiny);
            }
        }
    }
}


