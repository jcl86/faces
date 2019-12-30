using System;
using System.Collections.Generic;

namespace GeneratedPhotosApiExplorer
{
    public class Face
    {
        public string Id { get; set; }
        public List<Dictionary<string, Uri>> Urls { get; set; }
        public Meta Meta { get; set; }
    }
}
