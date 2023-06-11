using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSProject
{
    public partial class Loading : Form

    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );
        Timer timer = new Timer();
        public Loading()
        {
            InitializeComponent();
            guna2ProgressBar1.Value = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 2;
            guna2ProgressBar1.Text = guna2ProgressBar1.Value.ToString() + "%";
            if (guna2ProgressBar1.Value == 10)
            {
                bunifuLabel1.Text = "Establishing Connection...";
            }
            if (guna2ProgressBar1.Value == 20)
            {
                bunifuLabel1.Text = "Connecting to Database ...";
            }
            if (guna2ProgressBar1.Value == 30)
            {
                bunifuLabel1.Text = "Compiling Resources ...";
            }
            if (guna2ProgressBar1.Value == 40)
            {
                bunifuLabel1.Text = "Loading User Interfaces...";
            }
            if (guna2ProgressBar1.Value == 50)
            {
                bunifuLabel1.Text = "Loading Admin Interfaces...";
            }
            if (guna2ProgressBar1.Value == 60)
            {
                bunifuLabel1.Text = "Loading Icons...";
            }
            if (guna2ProgressBar1.Value == 70)
            {
                bunifuLabel1.Text = "Checking Services Availability...";
            }
            if (guna2ProgressBar1.Value == 80)
            {
                bunifuLabel1.Text = "Checking For Updates...";
            }
            if (guna2ProgressBar1.Value == 90)
            {
                bunifuLabel1.Text = "Finishing Up (please wait)...";
            }

            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                user f = new user();
                this.Hide();
                f.ShowDialog();
            }


        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
