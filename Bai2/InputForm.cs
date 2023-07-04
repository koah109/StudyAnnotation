using BpoWinFormControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai2
{
    public partial class InputForm : Form
    {
        #region file
        public string FolderInput, FolderOuput;
        
        #endregion

        public InputForm()
        {
            InitializeComponent();
            LoadDirectory();
        }
        private bool checkDirectory()
        {
            if (Directory.Exists(txtInBox.Text) && Directory.Exists(txtOutBox.Text))
            {
                return true;
            }
            return false;
        }

        public void btnIn_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dir = new FolderSelectDialog();
            dir.ShowDialog();
            string folderName = dir.FileName;
            txtInBox.Text = folderName;

        }

        public void btnOK_Click(object sender, EventArgs e)
        {

            //string pathFolder = @"" + inBox.Text;
            //string[] FileList = Directory.GetFiles(pathFolder, "*.jpg", SearchOption.AllDirectories);
            if (!checkDirectory())
            {
                MessageBox.Show("Can't find folder");
                return;
            }
            FolderInput = txtInBox.Text;
            FolderOuput = txtOutBox.Text;
            saveDirectory();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void saveDirectory()
        {
            Properties.Settings.Default.inputFolder =  txtInBox.Text;
            Properties.Settings.Default.outputFolder =  txtOutBox.Text;
            Properties.Settings.Default.Save();
        }
        private void LoadDirectory()
        {
            txtInBox.Text = Properties.Settings.Default.inputFolder;
            txtOutBox.Text = Properties.Settings.Default.outputFolder;
        }


    }
}
