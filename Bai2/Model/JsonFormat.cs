using LanguageExt.ClassInstances;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class JsonFormat
    {
        [JsonProperty("version")]
        public string Version { get; set; } = "1.0.0";

        [JsonProperty("Folder")]
        public string folderName { get; set; }
        public List<shapes> shapes { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("imageHeight")]

        public int ImageHeight { get; set; }
        
        [JsonProperty("imageWidth")]
        public int ImageWidth { get; set; }
    }

    public class shapes
    {
        [JsonProperty("label")]
        public string Label { get; set; } 

        public List<List<float>> points { get; set; }
        
        [JsonProperty("visible")]
        public string Visible { get; set; }
        
        
        [JsonProperty("shape_type")]
        public string Shape_type { get; set; }
    }
}
