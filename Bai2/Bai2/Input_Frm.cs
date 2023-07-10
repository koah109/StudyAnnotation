using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai2
{
    public partial class Input_Frm : Form
    {
        Form1 form1 = new Form1();
        
        public Input_Frm()
        {
            InitializeComponent();
        }



        private void Input_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            
            file.DefaultExt = "File folder";
            Input_box.Text = file.FileName;
        }

        public void OK_btn_Click(object sender, EventArgs e)
        {
            
            string pathFolder = @"" + Input_box.Text;
            string[] listFile = Directory.GetFiles(pathFolder, "*.png", SearchOption.AllDirectories);
            ListBox listImage = new ListBox();
            listImage.DataSource = listFile;

        }
    }
}
