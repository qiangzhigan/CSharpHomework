using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace homework5._1
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

        private void button1_Click(object sender, EventArgs e)
        {
            //判断图片是否为空
            if (graphics == null)
                graphics = this.CreateGraphics();//接口？事件触发点
            DrawCayleyTree(15, 200, 300, 100, -Math.PI / 2);


        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        
        double per = 0.6;


        void DrawCayleyTree(int n, double x0, double y0, double length, double th)
        {//判断N是否为零
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            Drawline(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per * length, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per * length, th - th1);


        }//画线
        void Drawline(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}
