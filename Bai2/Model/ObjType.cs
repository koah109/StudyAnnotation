using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace Bai2.Model
{
    public class ObjType
    {
        public int Id { get; set; }

        public string Value { get; set; }
        public string TextVn { get; set; }

        public Color Color { get; set; }


        public Color ColorText { get; set; }

        public Key HotKey { get; set; }


        public Shape Shape { get; set; }

        public ObjType() {
            ColorText = Color.Black;
        }

    }




}
