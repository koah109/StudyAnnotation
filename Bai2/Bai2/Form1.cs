using Bai2.Model;
using BpoWinFormControlLib;
using Bps.Fx.ImageBox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;

namespace Bai2
{
    public partial class Form1 : Form
    {
        #region file
        private string _folderInput, _folderOuput;
        private List<TagImage> _listtagimage = new List<TagImage>();
        //private List<Point> polygon = new List<Point>();
        private List<shapes> rectangle = new List<shapes>();
        List<TagObject> _listSelected  = new List<TagObject>();

        private TagObject _tagObject;
        private MouseMode _mouseMode = MouseMode.Drawing;
        private TagPicture _currentTagPicture;
        private TagObject _currentTagObject;
        private bool _isDrawing;
        private PointF _startPoint, _currentPoint;
        private Image _currentImage;
        private bool _isMouseLeftClick;
        private Rectangle _rectSelect = Rectangle.Empty;
        private bool _isCtrlDown = false;

        #endregion

        #region Method
        #endregion

        public Form1()
        {
            InitializeComponent();
            //boxImage.SizeMode = PictureBoxSizeMode.Zoom;
            boxImage.MouseDown += BoxImage_MouseDown;
            boxImage.MouseMove += BoxImage_MouseMove;
            boxImage.MouseUp += BoxImage_MouseUp;
            boxImage.Paint += BoxImage_Paint;
            _tagObject = new RectKhoa();
        }

        #region Button
        
        private void RadioButtonChecked(int index)
        {
            var listRb = panel1.Controls.OfType<RadioButton>().ToList();
            if (!listRb.Any()) return;
            if (index > listRb.Count - 1) return;
            var rb = listRb[index];
            rb.PerformClick();

        }


        #endregion
        #region Image

        private PointF GetLocationInPicture(System.Drawing.Point point)
        {
            PointF p = boxImage.PointToImage(point.X, point.Y);
            int min = TagLib.Global.BORDER;
            int maxWidth = _currentImage.Width + TagLib.Global.BORDER;
            int maxHeight = _currentImage.Height + TagLib.Global.BORDER;

            float x = p.X < min ? min : p.X;
            float y = p.Y < min ? min : p.Y;
            x = x > maxWidth ? maxWidth : x;
            y = y > maxHeight ? maxHeight : y;
            return new PointF(x, y);
        }
        private void Drawing(Graphics g)
        {
            if (_currentImage == null)
            {
                return;
            }
            switch (_mouseMode)
            {
                case MouseMode.Drawing:
                    if (_isDrawing)
                    {
                        _tagObject.Drawing(boxImage, g, boxImage.Zoom, _startPoint, _currentPoint);
                    }
                    break;
                case MouseMode.Selected:
                    if (_rectSelect != Rectangle.Empty)
                    {
                        boxImage.DrawRectangle(g, new Pen(Color.Yellow, Global.LINE_WEIGHT), _rectSelect);
                    }
                    break;
            }
        }

        private void DrawAllObject()
        {
            boxImage.Invalidate();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void StartDrawNewObject()
        {
            _isDrawing = true;
            _tagObject.OnLeftMouseDown(_currentPoint);
            //_tagObject.Id = GetId();
            DrawAllObject();
            if (_tagObject.IsAutoCompleteDraw())
            {
                FinishDrawing();
            }
        }

        private void CloneCurrentTagObject()
        {
            var currentClass = _tagObject.Class;
            _tagObject = _tagObject.CreateInstance();
            _tagObject.Class = currentClass;
        }
        private void AddTagObject(TagObject tagObject)
        {
            _currentTagPicture.ListTagObject.Add(tagObject);
        }

        private void ResetDraw()
        {
            _isDrawing = false;
            _tagObject.Reset();
            DrawAllObject();
        }

        private void FinishDrawing()
        {
            _isDrawing = false;
            AddTagObject(_tagObject);
            
            CloneCurrentTagObject();
            
            DrawAllObject();

        }

        private void SelectObject()
        {
            if (_listSelected.Count > 1)
            {
                if (!_isCtrlDown)
                    _listSelected.Clear();
                _currentTagPicture.FindAnnotation(_currentPoint, ref _listSelected, false);
            }
            else
            {
                _currentTagPicture.FindAnnotation(_currentPoint, ref _listSelected, false);

            }
            if (_listSelected.Count > 0)
            {
                _tagObject = _listSelected[0];
                _tagObject.SelectNode(_currentPoint, false);
            }
            
        }

        private void BoxImage_Paint(object sender, PaintEventArgs e)
        {
            if (_currentImage == null)
            {
                return;
            }
            _currentTagPicture.Draw(boxImage, e.Graphics, boxImage.Zoom);

            Drawing(e.Graphics);
        }
        private void DrawSelectionArea()
        {
            RectangleF rectF = GetRectangle(_startPoint, _currentPoint);
            _rectSelect = new Rectangle((int)rectF.X, (int)rectF.Y, (int)rectF.Width, (int)rectF.Height);

            DrawAllObject();
        }
        private void EditSelectedTagObject()
        {
            _currentTagObject.EditGraphics(_startPoint, _currentPoint, _currentImage.Width, _currentImage.Height);

            _startPoint = _currentPoint;

            DrawAllObject();
        }
        private void BoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentImage == null) return;
            _startPoint = _currentPoint = GetLocationInPicture(e.Location);

            if (e.Button == MouseButtons.Left)
            {
                _isMouseLeftClick = true;
                switch (_mouseMode)
                {
                    
                    case MouseMode.Drawing:
                        _isDrawing = true;
                        DrawAllObject();
                        StartDrawNewObject();
                        break;
                    case MouseMode.Selected:
                        SelectObject();
                        break;
                }
            }
            else if (e.Button == MouseButtons.Right && _isDrawing == true)
            {
                _tagObject.OnRightMouseDown();
                if (_tagObject.IsDataVaild())
                {
                    FinishDrawing();
                }
                else
                {
                    ResetDraw();
                }
            }
        }
       

        private void BoxImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_currentImage == null) return;

            _currentPoint = GetLocationInPicture(e.Location);
            switch (_mouseMode)
            {
                case MouseMode.Drawing:

                    if (_isDrawing)
                    {
                        DrawAllObject();
                    }
                    break;
                case MouseMode.Selected:
                    boxImage.Cursor = Cursors.Hand;
                    if (!_isMouseLeftClick) return;
                    if (_isCtrlDown)
                    {
                        DrawSelectionArea();
                    }
                    EditSelectedTagObject();

                    break;
            }
        }

        private void BoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseLeftClick = false;
            switch (_mouseMode)
            {
                case MouseMode.Drawing:

                    _tagObject.OnLeftMouseUp();
                    if (_tagObject.DrawingStatus == DrawingStatus.Finish)
                    {
                        if (_tagObject.IsDataVaild())
                            FinishDrawing();
                        else
                        {
                            ResetDraw();
                        }
                    }
                    break;
                case MouseMode.Selected:
                    if (_tagObject.EditMode == EditMode.Move)
                    {

                    }
                    break;

            }

        }

        

        
        #endregion
        
        private void LoadAllData(string inputFolder, string outputFolder)

        {

            var files = BpoWinFormControlLib.BpoGetFiles.GetFilesFromFolder(inputFolder, new string[]
                 {
                    "jpg", "jpeg", "png", "bmp"
                 }, true);



            if (files.Count == 0)

            {

                MessageBox.Show("Data not found");

                return;

            }



            _listtagimage = new List<TagImage>();

            for (int i = 0; i < files.Count; i++)

            {

                string pathImage = files[i];

                string nameImage = Path.GetFileNameWithoutExtension(pathImage);

                string pathOutput = Path.Combine(_folderOuput, nameImage + ".json");


                TagImage tagImage = new TagImage()

                {


                    FileName = Path.GetFileNameWithoutExtension(pathImage),

                    PathInput = pathImage,

                    NameFolder = Path.GetFileName(Path.GetDirectoryName(pathImage)),
                    PathOutput = pathOutput,


                };

                _listtagimage.Add(tagImage);

            }
            //listImage.DataSource = _listtagimage;
            listImage.DataSource = _listtagimage;
            listImage.DisplayMember = "FileName";
            //UpdateListId();

        }

        #region OpenMenuStrip
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            _folderInput = _folderOuput = "";
            InputForm frm = new InputForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _folderInput = frm.FolderInput;
                _folderOuput = frm.FolderOuput;
                LoadAllData(_folderInput, _folderOuput);
            }
        }

        


        #endregion

        #region ImageBox

        public RectangleF GetRectangle(PointF p1, PointF p2)
        {
            return new RectangleF
                (
                    Math.Min(p1.X, p2.X),
                    Math.Min(p1.Y, p2.Y),
                    Math.Abs(p1.X - p2.X),
                    Math.Abs(p1.Y - p2.Y)
                );
        }
        
        
        public void listImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lstBox = sender as ListBox;

            _currentTagPicture = lstBox.SelectedItem as TagImage;

            _currentImage =  new Bitmap(_currentTagPicture.PathInput);
            boxImage.Image = _currentImage;

            _currentTagPicture.ImageHeight = boxImage.Image.Height;

            _currentTagPicture.ImageWidth = boxImage.Image.Width;

            //var cvjson = CVoutput(_tagimage);

            //string json = JsonConvert.SerializeObject(cvjson);

            //File.WriteAllText(_tagimage.PathOutput, json);
        }

        #endregion
    }
}