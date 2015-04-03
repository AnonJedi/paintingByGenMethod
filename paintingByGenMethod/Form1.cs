using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace paintingByGenMethod
{
    public partial class MainForm : Form
    {
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Var
        private Bitmap Dbit;    //bitmap загружаемой картинки
        private Bitmap Ubit;    //bitmap результата
        private Graphics g;     //рисовалка
        private Triangle poligon;    //полигон
        private List<Triangle> poligonList = new List<Triangle>();  //список годных полигонов
        private int[] PixelCntr = {0, 0};
        #endregion 

        private void ExitButton_Click(object sender, EventArgs e)   //кнопка выхода из программы
        {
            Application.Exit();
        }

        private void LoadButton_Click(object sender, EventArgs e)   //кнопка загрузки изображения
        {
            if (openPaint.ShowDialog() == DialogResult.OK)
            {
                Dbit = new Bitmap(openPaint.OpenFile());
                samplePictureBox.Image = Dbit;
            }
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Ubit = new Bitmap(myPictureBox.Size.Width, myPictureBox.Size.Height);
            LoadBar.Value = 0;

            for (int i = 0; i < 50; i++)
            {
                //while (true)
                //{
                    CntrLbl.Text = poligonList.Count.ToString();
                    try
                    {
                        poligon = new Triangle(myPictureBox, Dbit);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        continue;
                    }

                    foreach (Triangle t in poligonList)
                    {
                        PointF[] points = new PointF[3];
                        points = t.InitPoligon();

                        g = Graphics.FromImage(Ubit);
                        g.FillPolygon(new SolidBrush(t.color), points);
                    }  
                    myPictureBox.Refresh();
                    myPictureBox.Image = Ubit;
                    

                    //PixelCntr[1] = 0;
                    //for (int x = 0; x < 574; x++)
                    //    for (int y = 0; y < 558; y++)
                    //    {
                    //        try
                    //        {
                    //            if (Dbit.GetPixel(x, y) == Ubit.GetPixel(x, y))
                    //            {
                    //                PixelCntr[1]++;
                    //            }
                    //        }
                    //        catch (ArgumentOutOfRangeException)
                    //        {               
                    //            continue;
                    //        }
                            
                    //    }
                    
                    //if (PixelCntr[0] <= PixelCntr[1])
                    //{
                        poligonList.Add(poligon);
                    //    PixelCntr[0] = PixelCntr[1];
                        LoadBar.Increment(1);

                    //    break;
                    //}                  
                //}
            }
        }

    }
}
