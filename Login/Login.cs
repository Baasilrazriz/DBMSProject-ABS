using Bunifu.Core.forms;
using Bunifu.Framework.UI;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DBMSProject
{
    public partial class Login : Form
    {
        public static string admin, id,uname;
        public static Boolean login_status = false;
        
        public Login()
        {
            InitializeComponent();
           
            txt_Password.PasswordChar = '*';
        }




        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

            
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            hide_btn.Visible = true;
            show_btn.Visible = false;

            hide_btn.BringToFront();
            txt_Password.PasswordChar = '\0';

        }

        private void hide_btn_Click_1(object sender, EventArgs e)
        {

            show_btn.Visible = true;
            hide_btn.Visible = false;

            show_btn.BringToFront();
            txt_Password.PasswordChar = '*';
        }

        private void bunifuLabel3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
        Forgot l = new Forgot();

         
            l.Show();

      



        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            create c = new create();

            l.Hide();
            c.Show();

            
            l.Close();

        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txt_Password.Text == string.Empty)
            {
                MessageBox.Show("Fields cannot be left empty", "ABS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string emailaddress;
                Email email = new Email();
                SqlConnection con = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");
                con.Open();
                //string query = "SELECT * FROM admininfo WHERE admin_uname='" + txtUsername.Text + "'AND admin_pass='" + txt_Password.Text + "'";
                string query = "exec admin_login '" + txtUsername.Text + "','" + txt_Password.Text + "'";
                string query1 = "exec user_login '" + txtUsername.Text + "','" + txt_Password.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    login_status = true;
                    admin ds = new admin();
                    emailaddress = Convert.ToString(reader["email_id"]);
                    this.Hide();
                    Login l = new Login();
                    l.Close();
                    this.Hide();
         
                    Wait w = new Wait();

                    w.Show();
                    await Task.Run(() => email.send(emailaddress));
                    l.Close();
                    w.Hide();
                    ds.Show();


                }
                else
                {
                    reader.Close();

                    cmd = new SqlCommand(query1, con);
                    reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        login_status = true;
                        admin = txtUsername.Text;

                        emailaddress = Convert.ToString(reader["email"]);
                        this.Hide();
                        Login l = new Login();
                        Wait w = new Wait();

                        w.Show();
                        await Task.Run(() => email.send(emailaddress));
                        l.Close();
                        w.Hide();


                        //user user = new user();
                        //user.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username And Password Not Match!", "ABS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        login_status = false;
                    }
                    txtUsername.Text = string.Empty;
                    txt_Password.Text = string.Empty;
                    reader.Close();

                    con.Close();
                }

            
            }

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            show_btn.Visible = true;
            hide_btn.Visible = false;

            show_btn.BringToFront();
            txt_Password.PasswordChar = '*';

        }

    }
}
