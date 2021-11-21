using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public int x;
        public int y;
        public int storona;
        public void Vleovo()
        {
            x = x + storona;
        }
        public void Vpravo()
        {
            x = x - storona;
        }
        public void koord()
        {
            Console.WriteLine($"{x} {y}  {x + storona} {y}   {x} {y + storona} {x + storona} {y + storona}");
        }
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            x = 5;
            y = 34;
            storona = 150;
            koord();
            g = CreateGraphics();
            g.Clear(Color.Azure);
            g.DrawRectangle(Pens.Black, x, y, storona, storona);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                x +=5;
                y = 34;
                storona = 150;
                koord();
                g = CreateGraphics();
                g.Clear(Color.Azure);
                g.DrawRectangle(Pens.Black, x, y, storona, storona);
            }
            if (e.KeyData == Keys.Left)
            {
                x -= 5;
                y = 34;
                storona = 150;
                koord();
                g = CreateGraphics();
                g.Clear(Color.Azure);
                g.DrawRectangle(Pens.Black, x, y, storona, storona);
            }
        }
    }
}
