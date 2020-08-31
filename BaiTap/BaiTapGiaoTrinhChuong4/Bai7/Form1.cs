using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int congX = 0;
        int truX = 1;
        int congY = 0;
        int truY = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            congX = r.Next(5, 15);
            congY = r.Next(5, 15);
            int x = picBuom.Location.X;
            int y = picBuom.Location.Y;

            if (x + picBuom.Width+15 > this.Width)
                truX = -1;
            if (x < 0)
                truX = 1;
            if (y + picBuom.Height+30 > this.Height)
                truY = -1;
            if (y < 0)
                truY = 1;
            picBuom.Location = new Point(x + congX*truX, y + congY*truY);
        }
    }
}
