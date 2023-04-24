using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _22_04_2023_WinForms_GDI_Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       Graphics g;

        //private void Form1_Paint_1(object sender, PaintEventArgs e)
        //{
        //    g = CreateGraphics();
        //    g.Clear(Color.Azure);
        //    g.DrawArc(Pens.Black, 2, 2, 50, 50, 0, 180);
        //     g = e.Graphics;
        //    Pen pn = new Pen(Brushes.Blue, 5);
        //    pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        //    g.DrawEllipse(pn, 50, 100, 170, 40);
            
        //    Rectangle rect = new Rectangle(200, 200, 200, 200);
        //    LinearGradientBrush lgBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, 0.0f, true);
        //    g.FillRectangle(lgBrush, rect);
        //    Font f = new Font("Verdana", 30, FontStyle.Italic);
        //    g.DrawString("Hello World!", f, Brushes.Blue, 10, 10);
        //    //g.Dispose();
        //}
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Bitmap myBitmap = new Bitmap("Background.bmp");
        //        // получаем объект Graphics
        //        Graphics gFromImage = Graphics.FromImage(myBitmap);
        //        Font f = new Font("Verdana", 8, FontStyle.Italic);
        //        string helloStr = "Hello World!";
        //        // меряем "Hello World!" с помошью метода MeasureString
        //        SizeF sz = gFromImage.MeasureString(helloStr, f);
        //        gFromImage.DrawString("Hello World!", f, Brushes.Blue, 10, 10);
        //        gFromImage.DrawRectangle(new Pen(Color.Red, 2),
        //         10.0F, 10.0F, sz.Width, sz.Height);
        //        // сохроняем изображение на диск
        //        myBitmap.Save(@"NewFon.bmp");
        //        Rectangle regionRec = new Rectangle(new Point(0, 0), myBitmap.Size);
        //        myBitmap.Dispose();
        //        gFromImage.Dispose();
        //        // этот метод выполняет перерисовку клиентской области
        //        this.Invalidate(regionRec);
        //    }
        //    catch { }
        //}

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                string ruspaint = @"C:\Users\Fishman_1\Documents\GitHub\22-04-2023_WinForms_GDI_Home\Безымянный.bmp";
                string engpaint = @"C:\Users\Fishman_1\Documents\GitHub\22-04-2023_WinForms_GDI_Home\Background.bmp";

                var myBitmap = new Bitmap(ruspaint);
                Graphics g = e.Graphics;
                g.DrawImage(myBitmap, 10, 10, 400, 400);
                myBitmap.Dispose();
                g.Dispose();
            }
            catch { }
        }
    }
}
