using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DBMSProject
{
    public partial class UpdateUser : Form
    {
        public static string img_loc;
        public UpdateUser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");
        

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }
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
        
        

        private void uprofilepic_Click_1(object sender, EventArgs e)
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
                Image resizedImage = ResizeImage(retrievedImage, uprofilepic.Width, uprofilepic.Height);

                // Display the selected image in the PictureBox

                uprofilepic.Image = ResizeImage(resizedImage, uprofilepic.Width, uprofilepic.Height);

            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (txt_pass.Text.Equals(txt_confirmpass.Text))
            {
                byte[] image = null;
            
                FileStream stream = new FileStream(img_loc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                image = br.ReadBytes((int)stream.Length);


                try
                {
                    string query = "exec update_user  '" + txt_username.Text + "','" + txt_confirmpass.Text + "','" + txt_pno.Text + "','" + txt_email.Text + "' ,@image,'" + Login.admin + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@image", image));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("updated successfully");

                }
                catch (Exception ee)
                {

                    MessageBox.Show("update failed  " + ee.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("password doesnt match");
            }

        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
