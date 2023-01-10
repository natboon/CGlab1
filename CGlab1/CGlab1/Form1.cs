using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGlab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();


            Pen myPen1 = new Pen(System.Drawing.Color.DodgerBlue, 8);
            Pen myPen2 = new Pen(System.Drawing.Color.PaleVioletRed, 8);
            Pen myPen3 = new Pen(System.Drawing.Color.SandyBrown, 8);
            Pen myPen4 = new Pen(System.Drawing.Color.Khaki, 8);
            Pen myPen5 = new Pen(System.Drawing.Color.MediumAquamarine, 8);
            Pen myPen6 = new Pen(System.Drawing.Color.Plum, 8);
            Pen myPen7 = new Pen(System.Drawing.Color.Black, 10);
            Pen myPen8 = new Pen(System.Drawing.Color.Red, 8);
            Pen myPen9 = new Pen(System.Drawing.Color.Red, 6);
            Pen myPen10 = new Pen(System.Drawing.Color.Lime, 4);
            Pen myPen11 = new Pen(System.Drawing.Color.Cyan, 4);
            Pen myPen12 = new Pen(System.Drawing.Color.OrangeRed, 4);
            Pen myPen13 = new Pen(System.Drawing.Color.DarkViolet, 4);
            Pen myPen14 = new Pen(System.Drawing.Color.Firebrick, 4);
            Pen myPen15 = new Pen(System.Drawing.Color.Magenta, 4);
            Pen myPen16 = new Pen(System.Drawing.Color.MediumBlue, 4);
            Pen myPen17 = new Pen(System.Drawing.Color.Gold, 4);
            Pen myPen18 = new Pen(System.Drawing.Color.Gray, 2);
            Pen myPen19 = new Pen(System.Drawing.Color.Black, 2);
            //H
            myGraphic.DrawLine(myPen1, 100, 220, 100, 125); // |
            myGraphic.DrawLine(myPen1, 100, 170, 150, 170); // -
            myGraphic.DrawLine(myPen1, 150, 220, 150, 125); // |
            //A
            myGraphic.DrawLine(myPen2, 170, 220, 170, 125); // |
            myGraphic.DrawLine(myPen2, 170, 170, 220, 170); // -กลาง
            myGraphic.DrawLine(myPen2, 220, 220, 220, 125); // |
            myGraphic.DrawLine(myPen2, 170, 130, 220, 130); // -บน
            //P
            myGraphic.DrawLine(myPen3, 240, 220, 240, 125); // |
            myGraphic.DrawLine(myPen3, 240, 170, 290, 170); // -กลาง
            myGraphic.DrawLine(myPen3, 290, 170, 290, 125); // |
            myGraphic.DrawLine(myPen3, 240, 130, 290, 130); // -บน
            //P
            myGraphic.DrawLine(myPen4, 310, 220, 310, 125); // |
            myGraphic.DrawLine(myPen4, 310, 170, 360, 170); // -กลาง
            myGraphic.DrawLine(myPen4, 360, 170, 360, 125); // |
            myGraphic.DrawLine(myPen4, 310, 130, 360, 130); // -บน
            //Y
            myGraphic.DrawLine(myPen5, 380, 170, 380, 125); // |
            myGraphic.DrawLine(myPen5, 380, 170, 430, 170); // -กลาง
            myGraphic.DrawLine(myPen5, 430, 170, 430, 125); // |
            myGraphic.DrawLine(myPen5, 405, 220, 405, 170); // |
            //N
            myGraphic.DrawLine(myPen6, 500, 220, 500, 125); // |
            myGraphic.DrawLine(myPen6, 500, 125, 510, 125); // -บน
            myGraphic.DrawLine(myPen6, 540, 220, 510, 125); // \
            myGraphic.DrawLine(myPen6, 550, 220, 540, 220); // -ล่าง
            myGraphic.DrawLine(myPen6, 550, 220, 550, 125); // |
            //E
            myGraphic.DrawLine(myPen1, 570, 220, 570, 125); // |
            myGraphic.DrawLine(myPen1, 570, 130, 620, 130); // -บน
            myGraphic.DrawLine(myPen1, 620, 150, 620, 130); // |ต่อบน
            myGraphic.DrawLine(myPen1, 570, 170, 620, 170); // -กลาง
            myGraphic.DrawLine(myPen1, 620, 200, 620, 220); // |ต่อล่าง
            myGraphic.DrawLine(myPen1, 570, 220, 620, 220); // -ล่าง
            //W
            myGraphic.DrawLine(myPen2, 640, 220, 640, 125); // |
            myGraphic.DrawLine(myPen2, 665, 170, 665, 220); // |กลาง
            myGraphic.DrawLine(myPen2, 640, 220, 690, 220); // -ล่าง
            myGraphic.DrawLine(myPen2, 690, 220, 690, 125); // |
            //Y
            myGraphic.DrawLine(myPen3, 760, 170, 760, 125); // |
            myGraphic.DrawLine(myPen3, 760, 170, 810, 170); // -กลาง
            myGraphic.DrawLine(myPen3, 810, 170, 810, 125); // |
            myGraphic.DrawLine(myPen3, 785, 220, 785, 170); // |
            //A
            myGraphic.DrawLine(myPen4, 830, 220, 830, 125); // |
            myGraphic.DrawLine(myPen4, 880, 170, 830, 170); // -กลาง
            myGraphic.DrawLine(myPen4, 880, 220, 880, 125); // |
            myGraphic.DrawLine(myPen4, 880, 130, 830, 130); // -บน
            //E
            myGraphic.DrawLine(myPen5, 900, 220, 900, 125); // |
            myGraphic.DrawLine(myPen5, 900, 130, 950, 130); // -บน
            myGraphic.DrawLine(myPen5, 950, 150, 950, 130); // |ต่อบน
            myGraphic.DrawLine(myPen5, 900, 170, 950, 170); // -กลาง
            myGraphic.DrawLine(myPen5, 950, 200, 950, 220); // |ต่อล่าง
            myGraphic.DrawLine(myPen5, 900, 220, 950, 220); // -ล่าง
            //R
            myGraphic.DrawLine(myPen6, 970, 220, 970, 125); // |
            myGraphic.DrawLine(myPen6, 970, 125, 1020, 125); // -บน
            myGraphic.DrawLine(myPen6, 1020, 170, 1020, 125); // |ต่อบน
            myGraphic.DrawLine(myPen6, 970, 170, 1020, 170); // -กลาง
            myGraphic.DrawLine(myPen6, 990, 170, 1020, 220); // \ต่อกลาง
            //2
            myGraphic.DrawLine(myPen7, 400, 285, 400, 250); // |
            myGraphic.DrawLine(myPen7, 400, 250, 460, 250); // -บน
            myGraphic.DrawLine(myPen7, 460, 300, 460, 250); // |ต่อบน
            myGraphic.DrawLine(myPen7, 400, 300, 460, 300); // -กลาง
            myGraphic.DrawLine(myPen7, 400, 350, 400, 300); // |ต่อล่าง
            myGraphic.DrawLine(myPen7, 400, 350, 460, 350); // -ล่าง
            //0
            myGraphic.DrawLine(myPen7, 490, 350, 490, 250); // |
            myGraphic.DrawLine(myPen7, 490, 250, 550, 250); // -บน
            myGraphic.DrawLine(myPen7, 550, 350, 550, 250); // |
            myGraphic.DrawLine(myPen7, 490, 350, 550, 350); // -ล่าง
            //2
            myGraphic.DrawLine(myPen7, 580, 285, 580, 250); // |
            myGraphic.DrawLine(myPen7, 580, 250, 640, 250); // -บน
            myGraphic.DrawLine(myPen7, 640, 300, 640, 250); // |ต่อบน
            myGraphic.DrawLine(myPen7, 580, 300, 640, 300); // -กลาง
            myGraphic.DrawLine(myPen7, 580, 350, 580, 300); // |ต่อล่าง
            myGraphic.DrawLine(myPen7, 580, 350, 640, 350); // -ล่าง
            //3
            myGraphic.DrawLine(myPen7, 670, 285, 670, 250); // |
            myGraphic.DrawLine(myPen7, 670, 250, 730, 250); // -ต่อบน
            myGraphic.DrawLine(myPen7, 730, 350, 730, 250); // |
            myGraphic.DrawLine(myPen7, 690, 300, 730, 300); // -กลาง
            myGraphic.DrawLine(myPen7, 670, 350, 730, 350); // |ต่อล่าง
            myGraphic.DrawLine(myPen7, 670, 350, 670, 320); // -ล่าง
            //กล่องของขวัญ
            myGraphic.DrawRectangle(myPen8, 400, 450, 340, 100); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            myGraphic.DrawLine(myPen9, 400, 500, 740, 500); // -กลาง
            myGraphic.DrawLine(myPen9, 580, 455, 580, 545); // |กลาง
            //สีพลุ cyan orangered lime darkviolet firebrick magenta mediumblue yellow
            //พลุ
            myGraphic.DrawLine(myPen10, 170, 410, 170, 320); // |1
            myGraphic.DrawLine(myPen11, 170, 410, 230, 340); // |2
            myGraphic.DrawLine(myPen12, 170, 410, 250, 410); // |3
            myGraphic.DrawLine(myPen13, 170, 410, 230, 470); // |4
            myGraphic.DrawLine(myPen14, 170, 410, 170, 490); // |5
            myGraphic.DrawLine(myPen15, 170, 410, 110, 470); // |6
            myGraphic.DrawLine(myPen16, 170, 410, 110, 350); // |7
            myGraphic.DrawLine(myPen17, 90, 410, 170, 410); // |8
            //พลุ
            myGraphic.DrawLine(myPen11, 970, 410, 970, 320); // |1
            myGraphic.DrawLine(myPen13, 970, 410, 1030, 340); // |2
            myGraphic.DrawLine(myPen10, 970, 410, 1050, 410); // |3
            myGraphic.DrawLine(myPen17, 970, 410, 1030, 470); // |4
            myGraphic.DrawLine(myPen16, 970, 410, 970, 490); // |5
            myGraphic.DrawLine(myPen14, 970, 410, 910, 470); // |6
            myGraphic.DrawLine(myPen15, 970, 410, 910, 350); // |7
            myGraphic.DrawLine(myPen12, 890, 410, 970, 410); // |8
            //ขีดเส้นตรงห้อยลงมา
            myGraphic.DrawLine(myPen19, 20, 0, 20, 100);
            myGraphic.DrawLine(myPen18, 40, 0, 40, 110);
            myGraphic.DrawLine(myPen19, 60, 0, 60, 110);
            myGraphic.DrawLine(myPen18, 80, 0, 80, 80);
            myGraphic.DrawLine(myPen19, 100, 0, 100, 110);
            myGraphic.DrawLine(myPen18, 120, 0, 120, 90);
            myGraphic.DrawLine(myPen19, 140, 0, 140, 100);
            myGraphic.DrawLine(myPen18, 160, 0, 160, 110);
            myGraphic.DrawLine(myPen19, 180, 0, 180, 110);
            myGraphic.DrawLine(myPen18, 200, 0, 200, 80);
            myGraphic.DrawLine(myPen19, 220, 0, 220, 110);
            myGraphic.DrawLine(myPen18, 240, 0, 240, 90);
            myGraphic.DrawLine(myPen19, 260, 0, 260, 100);
            myGraphic.DrawLine(myPen18, 280, 0, 280, 110);
            myGraphic.DrawLine(myPen19, 300, 0, 300, 110);
            myGraphic.DrawLine(myPen18, 320, 0, 320, 110);
            myGraphic.DrawLine(myPen19, 340, 0, 340, 110);
            myGraphic.DrawLine(myPen18, 360, 0, 360, 80);
            myGraphic.DrawLine(myPen19, 380, 0, 380, 110);
            myGraphic.DrawLine(myPen18, 400, 0, 400, 90);
            myGraphic.DrawLine(myPen19, 420, 0, 420, 100);
            myGraphic.DrawLine(myPen18, 440, 0, 440, 110);
            myGraphic.DrawLine(myPen19, 460, 0, 460, 110);
            myGraphic.DrawLine(myPen18, 480, 0, 480, 80);
            myGraphic.DrawLine(myPen19, 500, 0, 500, 110);
            myGraphic.DrawLine(myPen18, 520, 0, 520, 90);
            myGraphic.DrawLine(myPen19, 540, 0, 540, 100);
            myGraphic.DrawLine(myPen18, 560, 0, 560, 110);
            myGraphic.DrawLine(myPen19, 580, 0, 580, 90);
            myGraphic.DrawLine(myPen18, 600, 0, 600, 80);
            myGraphic.DrawLine(myPen19, 620, 0, 620, 110);
            myGraphic.DrawLine(myPen18, 640, 0, 640, 80);
            myGraphic.DrawLine(myPen19, 660, 0, 660, 110);
            myGraphic.DrawLine(myPen18, 680, 0, 680, 90);
            myGraphic.DrawLine(myPen19, 700, 0, 700, 100);
            myGraphic.DrawLine(myPen18, 720, 0, 720, 110);
            myGraphic.DrawLine(myPen19, 740, 0, 740, 110);
            myGraphic.DrawLine(myPen18, 760, 0, 760, 80);
            myGraphic.DrawLine(myPen19, 780, 0, 780, 110);
            myGraphic.DrawLine(myPen18, 800, 0, 800, 90);
            myGraphic.DrawLine(myPen19, 820, 0, 820, 100);
            myGraphic.DrawLine(myPen18, 840, 0, 840, 80);
            myGraphic.DrawLine(myPen19, 860, 0, 860, 90);
            myGraphic.DrawLine(myPen18, 880, 0, 880, 110);
            myGraphic.DrawLine(myPen19, 900, 0, 900, 110);
            myGraphic.DrawLine(myPen18, 920, 0, 920, 80);
            myGraphic.DrawLine(myPen19, 940, 0, 940, 110);
            myGraphic.DrawLine(myPen18, 960, 0, 960, 90);
            myGraphic.DrawLine(myPen19, 980, 0, 980, 100);
            myGraphic.DrawLine(myPen18, 1000, 0,1000, 110);
            myGraphic.DrawLine(myPen19, 1020, 0, 1020, 110);
            myGraphic.DrawLine(myPen18, 1040, 0, 1040, 90);
            myGraphic.DrawLine(myPen19, 1060, 0, 1060, 110);
            myGraphic.DrawLine(myPen18, 1080, 0, 1080, 100);
            myGraphic.DrawLine(myPen19, 1100, 0, 1100, 80);
            myGraphic.DrawLine(myPen18, 1120, 0, 1120, 100);
            myGraphic.DrawLine(myPen19, 1140, 0, 1140, 90);
        }
    }
}
