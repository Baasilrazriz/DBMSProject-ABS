using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBMSProject
{
    public partial class create : Form
    {
        int id;
        public create()
        {
            InitializeComponent();
          

        }
        SqlConnection conn = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");
        string img_loc;
        SqlCommand cmd;
        private Image ResizeImage(Image sourceImage, int width, int height)
        {
            // Create a new Bitmap with the desired size
            Bitmap resizedImage = new Bitmap(width, height);

            // Create a Graphics object from the resized image
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // Set the interpolation mode to high quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the source image onto the resized image
                graphics.DrawImage(sourceImage, 0, 0, width, height);
            }

            return resizedImage;
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }
        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void create_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

        }

        

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void bunifuThinButton22_Click_2(object sender, EventArgs e)
        {
            try
            {
                byte[] image = null;
                FileStream stream = new FileStream(img_loc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                image = br.ReadBytes((int)stream.Length);
                conn.Open();
                string query1 = " EXEC insert_user '" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_uname.Text + "','" + txt_pass.Text + "','" + Convert.ToDateTime(txt_dob.Text) + "','" + Convert.ToInt32(txt_age.Text) + "','" + txt_pno.Text + "','" + txt_email.Text + "','" + txt_passport_no.Text + "','" + txt_nationality.Text + "','" +Convert.ToDateTime( txt_pass_issue.Text) + "','" + Convert.ToDateTime(txt_pass_exp.Text) + "','"  + txt_sex.Text + "','" + txt_address.Text + "','" + txt_city.Text +  "',@image";
               
 
                cmd = new SqlCommand(query1, conn);
                cmd.Parameters.Add(new SqlParameter("@image", image));
                cmd.ExecuteNonQuery();

                MessageBox.Show("SUCCESSFULLY ADDED !");
                string query = "SELECT user_id FROM users WHERE email='" + txt_email.Text + "'";

                SqlCommand cmd1 = new SqlCommand(query, conn);
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["user_id"]);
                }
                conn.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
            tabControl1.SelectedIndex = 3;
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query1 = "EXEC create_acc_detail '"  + Convert.ToInt64(txt_cardno.Text) +   "','" + Convert.ToDouble(txt_balance.Text) + "','" + txt_cardname.Text + "','" + Convert.ToInt32(txt_cvv.Text) + "','" + id + "'";



                cmd = new SqlCommand(query1, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESSFULLY ADDED !");
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp) | *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                img_loc = openFileDialog.FileName; ;
                byte[] imageData = File.ReadAllBytes(img_loc);
                // Convert the byte array to Image
                Image retrievedImage = ByteArrayToImage(imageData);

                // Resize the retrieved image based on the target PictureBox size
                Image resizedImage = ResizeImage(retrievedImage, cpp.Width, cpp.Height);

                // Display the selected image in the PictureBox

                cpp.Image = ResizeImage(resizedImage, cpp.Width, cpp.Height);

            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex =2;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {


        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
