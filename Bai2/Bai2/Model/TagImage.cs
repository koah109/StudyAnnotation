using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;
using TagLib;

namespace Bai2
{
    public class TagImage : TagPicture
    {
        public string NameFolder { get; set;}
       
        public override IEnumerable<object> GetDataSourceForDataGridView()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }

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