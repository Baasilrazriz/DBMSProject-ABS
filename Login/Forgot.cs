using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBMSProject
{
    public partial class Forgot : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");

        string username, phone, emailaddress;
        private string otp_code;
        public Forgot()
        {
            InitializeComponent();
            txt_email_f.Hide();
            txt_email_f.Enabled = false;
            btn_resend.Enabled = false;



        }
        System.Timers.Timer t;
        int h, s, m;
        public void time()
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();

        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    t.Stop();
                    btn_resend.ActiveFillColor = Color.Green;
                    btn_resend.IdleFillColor = Color.Green;

                    btn_resend.ForeColor = Color.Silver;
                    btn_resend.Enabled = true;
                    btn_sendotp.Enabled = false;

                }
                lbl_time.Text = m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');

            }));
            t.AutoReset = true;

        }

        public string otp()
        {
            int len = 4;
            const string ValidChar = "1234567890";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            return result.ToString();
        }




        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           this.Hide(); 
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_uname_f.Text == string.Empty)
            {
                MessageBox.Show("kindly enter your username first!!");
            }
            else
            {
                con.Open();

                string query1 = "SELECT * FROM user_authentication WHERE username ='" + txt_uname_f.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    emailaddress = Convert.ToString(reader["email"]);
                    string num = Convert.ToString(reader["phone_num"]);
                    phone = num.ToString();
                    tabControl_f.SelectedIndex = 1;
                }

                else
                {
                    MessageBox.Show("USERNAME AND PASSWORD DOES NOT MATCH!", "ABS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                con.Close();


            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (combo_forgot.SelectedIndex == -1)
            {
                MessageBox.Show("select a medium first");
            }
            else

            {

                if (combo_forgot.SelectedIndex == 0)
                {
                    radio_email.Text = emailaddress;
                    radioButton2.Text = "Enter another email";
                    tabControl_f.SelectedIndex = 2;


                }
                else if (combo_forgot.SelectedItem.ToString().Equals("WHATSAPP"))
                {
                    radio_email.Text = "+92" + phone;
                    radioButton2.Text = "Enter another number";
                    tabControl_f.SelectedIndex = 2;

                }

            }

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            txt_email_f.Show();
        }

        private void btn_sendotp_Click_2(object sender, EventArgs e)
        {

            Email email = new Email();
            Whatsapp watsapp = new Whatsapp();
            otp_code = otp();
            MessageBox.Show(otp_code);
            if (radio_email.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("please select any option");

            }
            else
            {


                if (combo_forgot.SelectedItem.ToString().Equals("EMAIL"))
                {
                    if (radio_email.Checked == true)
                    {
                        txt_email_f.Enabled = false;
                        email.sendemail(emailaddress, otp_code);
                        tabControl_f.SelectedIndex = 3;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        txt_email_f.Show();
                        txt_email_f.Enabled = true;
                        if (txt_email_f.Text == "")
                        {
                            MessageBox.Show("enter email address to get otp!");
                        }
                        else
                        {
                            email.sendemail(txt_email_f.Text, otp_code);
                            tabControl_f.SelectedIndex = 3;
                        }
                    }

                }
                else if (combo_forgot.SelectedItem.ToString() == "WHATSAPP")
                {
                    radio_email.Text = phone;
                    radioButton2.Text = "Enter another number";
                    if (radio_email.Checked == true)
                    {
                        txt_email_f.Enabled = false;
                        watsapp.send(otp_code, "+92" + phone);
                        tabControl_f.SelectedIndex = 3;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        txt_email_f.Enabled = true;
                        if (txt_email_f.Text == "")
                        {
                            MessageBox.Show("enter email address to get otp!");
                        }

                        watsapp.send(otp_code, txt_email_f.Text);

                        tabControl_f.SelectedIndex = 3;

                    }
                }
                time();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 1;
        }

        private void btn_resend_Click_2(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 2;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            if (txt_newpass.Text == "" || txt_confirmpass.Text == "")
            {
                MessageBox.Show("KINDLY ENTER YOUR NEW PASSWORD");
            }
            else
            {
                if (txt_confirmpass.Text == txt_newpass.Text)
                {
                    con.Open();
                    string query1 = "UPDATE users  SET pass='" + txt_newpass.Text + "' WHERE username='" + txt_uname_f.Text + "'";

                    try
                    {

                        SqlCommand cmd = new SqlCommand(query1, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("DATA IS UPDATED !");
                        Login l = new Login();

                        this.Hide();
                        l.Show();

                        Forgot s = new Forgot();
                        s.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("USERNAME AND PASSWORD DOES NOT MATCH !", "ABS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 3;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 2;

        }

        private void btn_verify_Click_1(object sender, EventArgs e)
        {
            if (txt_otp.Text == "")
            {
                MessageBox.Show("PLEASE ENTER THE OTP YOU RECIEVED !");
            }
            if (txt_otp.Text.Equals(otp_code))
            {
                tabControl_f.SelectedIndex = 4;
            }
            else
            {
                MessageBox.Show("OTP IS NOT VALID !");
            }
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 0;
        }

        private void radio_email_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_email_f.Hide();
        }







        private void bunifuThinButton24_Click_2(object sender, EventArgs e)
        {
            tabControl_f.SelectedIndex = 2;
        }



    }
}
