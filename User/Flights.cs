using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBMSProject
{
    public partial class Flights : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");
       public static string user_id, seat, otp_code, acc_no;
        bool verify = false;

        public Flights()
        {

            InitializeComponent();

            guna2Panel8.Hide();
            panel4.Hide();


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
            ConfirmPayment c = new ConfirmPayment();
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {

                    t.Stop();
                    c.btn_resend.ForeColor = Color.Black;
                    c.btn_resend.Enabled = true;
                    c.btn_verify.Enabled = false;

                }
                c.lbl_time.Text = m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');

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
        public string pnr_generator()
        {
            int len = 3;
            const string ValidChar = "1234567890";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            return result.ToString();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Flights_Load(object sender, EventArgs e)
        {



        }


        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel24_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_totfare_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton4_Click_2(object sender, EventArgs e)
        {


        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            if (user.Isroundtrip == true)
            {
                tabControl1.SelectedIndex = 1;
                guna2Panel8.Show();
                lbl_totfare.Text = "PKR " + user.grandtot;

            }
            else
            {
                tabControl1.SelectedIndex = 2;
                guna2Panel8.Hide();
                if (Login.login_status == false)
                {
                    Login login = new Login();
                    login.ShowDialog();
                }
                if (Login.login_status == true)
                {
                    con.Open();
                    string query = "select * from users where username='" + Login.admin + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_fname_p.Text = Convert.ToString(reader["f_name"]);
                        lbl_lname_p.Text = Convert.ToString(reader["l_name"]);
                        txt_dob_p.Text = Convert.ToString(reader["dob"]);
                        txt_nationality_p.Text = Convert.ToString(reader["nationality"]);
                        txt_passportno_p.Text = Convert.ToString(reader["passport_no"]);
                        txt_exp_p.Text = Convert.ToString(reader["pass_exp"]);
                        txt_pno_p.Text = Convert.ToString(reader["phone_num"]);
                        txt_email_p.Text = Convert.ToString(reader["email"]);
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from users   where f_name='" + txt_fname_p.Text + "' and l_name='" + lbl_lname_p.Text + "'and dob='" + txt_dob_p.Text + "'and nationality='" + txt_nationality_p.Text + "'and passport_no='" + txt_passportno_p.Text + "'and pass_exp='" + txt_exp_p.Text + "'and phone_num='" + txt_pno_p.Text + "'and email='" + txt_email_p.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_dob_t.Text = txt_dob_p.Text;
                user_id = Convert.ToString(reader["user_id"]);
                tabControl1.SelectedIndex = 3;

            }
            con.Close();
            reader.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from ticket where seat_no='" + bunifuTextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("This seat is already booked");
            }
            else
            {

                MessageBox.Show("The seat has been confirmed");
                seat = bunifuTextBox1.Text;
                tabControl1.SelectedIndex = 4;
                lbl_fname_t.Text = txt_fname_p.Text;
                lbl_lname_t.Text = lbl_lname_p.Text;
                lbl_dob_t.Text = txt_dob_p.Text;
                lbl_nationality_t.Text = txt_nationality_p.Text;
                lbl_ppt_t.Text = txt_passportno_p.Text;
                lbl_exp_t.Text = txt_exp_p.Text;

                lbl_seat_t.Text = seat;

            }
            con.Close();
            reader.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void guna2Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            //directed to passenger info
            tabControl1.SelectedIndex = 2;
            panel4.Show();
            Login login = new Login();

            if (Login.login_status == false)
            {
                login.ShowDialog();
            }
            if (Login.login_status == true)
            {
                con.Open();
                string query = "select * from users where username='" + login.txtUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user_id = Convert.ToString(reader["user_id"]);
                    txt_fname_p.Text = Convert.ToString(reader["f_name"]);
                    lbl_lname_p.Text = Convert.ToString(reader["l_name"]);
                    txt_dob_p.Text = Convert.ToString(reader["dob"]);
                    txt_nationality_p.Text = Convert.ToString(reader["nationality"]);
                    txt_passportno_p.Text = Convert.ToString(reader["passport_no"]);
                    txt_exp_p.Text = Convert.ToString(reader["pass_exp"]);
                    txt_pno_p.Text = Convert.ToString(reader["phone_num"]);
                    txt_email_p.Text = Convert.ToString(reader["email"]);
                }
                con.Close();
                reader.Close();
            }

        }

        private async void roundedButton5_Click(object sender, EventArgs e)
        {
            //code
            String PNR = "PK" + pnr_generator();

            user u = new user();
            con.Open();
            string query = "select * from account_details a inner join users u on a.user_id=u.user_id where a.card_no='" + Convert.ToInt64(txt_Cardno.Text) + "'and a.account_title='" + txt_cardname.Text + "' and a.cvv='" + Convert.ToInt32(txt_cvv.Text) + "' and '" + Convert.ToInt64(user.grandtot) + "'<=a.balance";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string emailaddress = Convert.ToString(reader["email"]);
                string pno = "+92" + Convert.ToString(reader["phone_num"]).Trim();
                acc_no = Convert.ToString(reader["account_id"]);
                Whatsapp w = new Whatsapp();
                Email em = new Email();
                otp_code = otp();
                Wait waa = new Wait();

                waa.Show();
                await Task.Run(() => em.sendemail(emailaddress, otp_code));
                await Task.Run(() => w.send(otp_code, pno));
                waa.Hide();
                waa.Close();


            }
            con.Close ();
            reader.Close();
            
                ConfirmPayment cp = new ConfirmPayment();
                cp.ShowDialog();
                MessageBox.Show(ConfirmPayment.IsSuccess.ToString());
                if (ConfirmPayment.IsSuccess==true)
                {
                    try
                    {
                    MessageBox.Show(user.air_id.ToString());
                        con.Open();
                    if (user.air_id == 1)
                    {
                        try
                        {
                            string query2 = " EXEC create_ticket_p '" + PNR + "','" + lbl_fno.Text + "','" + user.class_id + "','" + user.src_id + "','" + user.dest_id + "','" + seat + "','" + user_id + "'";
                            string query3 = " EXEC create_transaction '" + user.grandtot + "','" + acc_no + "','" + PNR + "','" + user_id + "'";
                            cmd = new SqlCommand(query2, con);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand(query3, con);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("pia ticket add");
                        }
                    
                    }
                    else if (user.air_id == 2)
                    {
                        try
                        {
                            string query1 = " EXEC create_ticket_f '" + PNR + "','" + lbl_fno.Text + "','" + user.class_id + "','" + user.src_id + "','" + user.dest_id + "','" + seat + "','" + user_id + "'";
                            string query3 = " EXEC create_transaction '" + user.grandtot + "','" + acc_no + "','" + PNR + "','" + user_id + "'";

                            cmd = new SqlCommand(query1, con);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand(query3, con);
                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("fj ticket add");
                        }

                    }
                    con.Close();                        
                        Ticketing t = new Ticketing();
                        t.lbl_pnr.Text = PNR.ToUpper();
                        t.lbl_name.Text = user.name;
                        t.lbl_pname.Text = user.name;
                        t.lbl_ticket.Text = PNR.ToUpper();
                        t.lbl_arr.Text = lbl_arr_t.Text;
                        t.lbl_dep.Text = lbl_deptime_t.Text;
                        t.lbl_fno.Text = lbl_fno.Text;
                        t.lbl_to.Text = txt_src_t.Text;
                        t.lbl_from.Text = txt_dest_t.Text;
                        t.lbl_class.Text = user.class_id.ToString();
                        t.lbl_current.Text = DateTime.Now.ToString();
                        t.lbl_note.Text = "We confirm the ticket issuance for your reservation " + PNR.ToUpper() + ". Please find details below";
                        t.ShowDialog();
                    }
                    catch (Exception ee)
                    {

                        MessageBox.Show(ee.Message);
                    }

                

            }
            else
            {
                MessageBox.Show("payment failed!! insufficient Amount");
            }
            con.Close();
            reader.Close();
        }

        private void roundedButton3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from users u inner join passport_details p on p.user_id=u.user_id where u.f_name='" + txt_fname_p.Text + "' and u.l_name='" + lbl_lname_p.Text + "'and u.dob='" + txt_dob_p.Text + "'and p.nationality='" + txt_nationality_p.Text + "'and p.pass_no='" + txt_passportno_p.Text + "'and p.pass_exp='" + txt_exp_p.Text + "'and u.phone_num='" + txt_pno_p.Text + "'and u.email='" + txt_email_p.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_dob_t.Text = txt_dob_p.Text;
                user_id = Convert.ToString(reader["user_id"]);
                tabControl1.SelectedIndex = 2;

            }
            con.Close();
            reader.Close();
        }




        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from tickets where seat_num='" + bunifuTextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("This seat is already booked");
            }
            else
            {
                MessageBox.Show("The seat has been confirmed");
            }
            con.Close();
            reader.Close();
            seat = bunifuTextBox1.Text;
            tabControl1.SelectedIndex = 3;
            lbl_fname_t.Text = txt_fname_p.Text;
            lbl_lname_t.Text = lbl_lname_p.Text;
            lbl_dob_t.Text = txt_dob_p.Text;
            lbl_nationality_t.Text = txt_nationality_p.Text;
            lbl_ppt_t.Text = txt_passportno_p.Text;
            lbl_exp_t.Text = txt_exp_p.Text;

            lbl_seat_t.Text = seat;
        }


    }
}
