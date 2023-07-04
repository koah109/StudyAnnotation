using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace Bai2
{
    public class TagImage
    {


        [JsonIgnore]
        public string  ImagePath {get; set;}

        public string NameFolder { get; set;}
        [JsonIgnore]
        public string PathInput { get; set; }
        [JsonIgnore]
        public string PathOutput { get; set; }

        public int ImageHeight { get; set; }

        public int ImageWidth { get; set; }

        //public List<TagObject> ListTagObjects = new List<TagObject>();

        //public void Draw(Graphics g)
        //{
        //    foreach (var item in ListTagObjects)
        //    {
        //        item.Draw(g);
        //    }
        //}

    }
}