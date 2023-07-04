using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2.Model
{
    internal class Constant
    {
        public const string VERSION = "1.3.1.0";

        public const string VALUE_0 = "0";
        public const string VALUE_1 = "1";
        public const string Rectangle = "Rectangle";



        public const int NUMER_LINE = 3;

        public const int SCOPE_ANNOTATION = 360;
        public const int MIN_BBOX = 50;
        public const int MIN_VALUE_3 = 3;


        // public static OpenCvSharp.Scalar COLOR_MIN_SIZE = OpenCvSharp.Scalar.Aqua;

        public static List<ObjType> LIST_OBJ_TYPES = new List<ObjType>()
        {
            new ObjType(){ Id = 1, Value = Constant.Rectangle, TextVn = Rectangle, Color = Color.Red, ColorText = Color.White,  HotKey = (TagLib.Key)Keys.Q , Shape = Shape.Rectangle }
            
        };
    }
}
