using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tori3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();


            Random r = new Random();
            // フォーム位置
            int l = r.Next(0, Screen.PrimaryScreen.Bounds.Width);
            int t = r.Next(0, Screen.PrimaryScreen.Bounds.Height);
            // フォーム移動パラメータ
            int dx = r.Next(1, 12);
            int dy = r.Next(1, 12);
            int dxx = r.Next(0, 1);
            int dxy = r.Next(0, 1);
            int num = r.Next(50, 1000);
            this.Left = l;
            this.Top = t;
            // フォームを動かす
            for (int i = 0; i < num; i++)
            {
                if (i % dx == 0 && dxx == 0) this.Left++;
                if (i % dx == 0 && dxx == 1) this.Left--;
                if (i % dy == 0 && dxy == 0) this.Top++;
                if (i % dy == 0 && dxy == 1) this.Top--;
            }

            // タイマー間隔再設定し実行
            timer1.Interval = r.Next(400, 1000);
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}
