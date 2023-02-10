using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomJerry.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TomJerry
{
    public partial class Form1 : Form
    {
        Bitmap tomBM= new Bitmap(Resources.tom_and_jerry_PNG58__1_);
        //Bitmap tomright = new Bitmap(Resources.tomright);
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor(tomBM.GetHicon());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void jerryBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
            }

            Button newJerryBtn = new Button();
            newJerryBtn.BackgroundImage = new Bitmap(Resources.jerry22__3_);
            newJerryBtn.BackColor = Color.Transparent;
            newJerryBtn.FlatStyle = FlatStyle.Flat;
            newJerryBtn.Size = jerryBtn.Size;

            newJerryBtn.FlatAppearance.BorderSize = jerryBtn.FlatAppearance.BorderSize;
            newJerryBtn.FlatAppearance.BorderColor = jerryBtn.FlatAppearance.BorderColor;
            newJerryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;

            Random random = new Random();
            int x = random.Next(10, 750);
            int y = random.Next(10, 600);
            newJerryBtn.Location = new Point(x, y);
            if (newJerryBtn.Location.X >= 450)
            {
                this.Cursor = new Cursor(tomBM.GetHicon());
            }
            
            newJerryBtn.AutoSize = true;;
            newJerryBtn.MouseMove += jerryBtn_MouseMove;
            this.Controls.Add(newJerryBtn);
        }

        private void jerryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
