using DBMSProject.Properties;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace DBMSProject
{
    public partial class user : Form

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
        public user()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Size = MinimumSize;
        }


        SqlConnection con = new SqlConnection(@"Data Source=IRFAN\RAZRIZ;Initial Catalog=AMS;Persist Security Info=True;User ID=admin;Password=Zxc121216");
        int tot_flight;
        public static string dest, src, destfull, srcfull, totfare_d, totfare_r, grandtot, fare, email, disctitle;
        public static int src_id, dest_id, class_id, flight_num, flight_numr, air_id, air_idr, disc;
        public double tot_d, tot_r, discamt, discamtr;
        public static string name;
        private bool isCollapsed, isdisc, isdiscr;
        public static bool Isroundtrip;
        private byte[] img;

        private void bunifuThinButton23_Click(object sender, EventArgs e)

        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string air_id = "", classfull = "", srcfull = "", destfull = "", pclass = "", src = "", dest = "";
            try
            {
                string query = "select * from ticket t inner join users u on u.user_id=t.user_id inner join flight_info_pia f  on t.flight_nump=f.flight_nump  where PNR_num='" + txt_pnr.Text + "' and u.l_name='" + txt_lname.Text + "'";
                string query1 = "select * from ticket t inner join users u on u.user_id=t.user_id inner join flight_info_fj f  on t.flight_numf=f.flight_numf  where PNR_num='" + txt_pnr.Text + "' and u.l_name='" + txt_lname.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    src = Convert.ToString(reader["src_id"]);
                    dest = Convert.ToString(reader["dest_id"]);
                    pclass = Convert.ToString(reader["class_id"]);
                    air_id = Convert.ToString(reader["airline_id"]);

                }
                else
                {
                    reader.Close();
                    cmd = new SqlCommand(query1, con);
                    reader = cmd.ExecuteReader();
                    src = Convert.ToString(reader["src_id"]);
                    dest = Convert.ToString(reader["dest_id"]);
                    pclass = Convert.ToString(reader["class_id"]);
                    air_id = Convert.ToString(reader["airline_id"]);

                }
                reader.Close();
                string query2 = "select * from city where city_id= '" + src + "'";
                cmd = new SqlCommand(query2, con);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    srcfull = Convert.ToString(reader["city"]);
                }
                reader.Close();
                string query3 = "select * from city where city_id= '" + dest + "'";
                cmd = new SqlCommand(query3, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    destfull = Convert.ToString(reader["city"]);
                }

                reader.Close();
                string query4 = "select * from class where class_id= '" + pclass + "'";
                cmd = new SqlCommand(query4, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    classfull = Convert.ToString(reader["class_name"]);
                }

                reader.Close();
                if (air_id == 1.ToString())
                {
                    string query5 = "select * from ticket t inner join users u on u.user_id=t.user_id inner join flight_info_pia f  on t.flight_nump=f.flight_nump inner join FlightFare ff on ff.flight_nump=f.flight_nump where PNR_num='" + txt_pnr.Text + "' and u.l_name='" + txt_lname.Text + "' and ff.class_id='" + pclass + "'";


                    cmd = new SqlCommand(query5, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        email = Convert.ToString(reader["email"]);
                        name = Convert.ToString(reader["f_name"]) + " " + Convert.ToString(reader["l_name"]);
                        MyBooking b = new MyBooking();
                        b.lbl_dep.Text = srcfull;
                        b.lbl_arr.Text = destfull;
                        b.lbl_srcfull.Text = Convert.ToString(reader["dep_time"]);
                        b.lbl_destfull.Text = Convert.ToString(reader["arr_time"]);
                        b.lbl_date.Text = Convert.ToString(reader["flight_date"]);
                        b.lbl_flightname.Text = "PIA";
                        b.lbl_flights.Text = Convert.ToString(reader["flight_nump"]);
                        b.lbl_class.Text = classfull;
                        b.lbl_price.Text = "PKR " + Convert.ToString(reader["fare"]);
                        b.lbl_pnr.Text = txt_pnr.Text.ToUpper();
                        b.lbl_nop.Text = "2 x Passengers";
                        this.Hide();
                        b.Show();
                    }
                }

                else if (air_id == 2.ToString())
                {
                    reader.Read();
                    string query6 = "select * from ticket t inner join users u on u.user_id=t.user_id inner join flight_info_fj f  on t.flight_numf=f.flight_numf inner join FlightFare ff on ff.flight_numf=f.flight_numf  where PNR_num='" + txt_pnr.Text + "' and u.l_name='" + txt_lname.Text + "'and ff.class_id='" + pclass + "'";
                    cmd = new SqlCommand(query6, con);
                    reader = cmd.ExecuteReader();

                    email = Convert.ToString(reader["email"]);
                    name = Convert.ToString(reader["f_name"]) + " " + Convert.ToString(reader["l_name"]);
                    MyBooking b = new MyBooking();
                    b.lbl_dep.Text = srcfull;
                    b.lbl_arr.Text = destfull;
                    b.lbl_srcfull.Text = Convert.ToString(reader["dep_time"]);
                    b.lbl_destfull.Text = Convert.ToString(reader["arr_time"]);
                    b.lbl_date.Text = Convert.ToString(reader["flight_date"]);
                    b.lbl_flightname.Text = "FJ";
                    b.lbl_flights.Text = Convert.ToString(reader["flight_nump"]);
                    b.lbl_class.Text = classfull;
                    b.lbl_price.Text = "PKR " + Convert.ToString(reader["fare"]);
                    b.lbl_pnr.Text = txt_pnr.Text.ToUpper();
                    b.lbl_nop.Text = "2 x Passengers";
                    this.Hide();
                    b.Show();

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                con.Close();
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private Image RetrieveAndResizeImageFromDatabase(PictureBox p1)
        {
            Image resizedImage = null;
            con.Open();
            string query = "select * from users where username='" + Login.admin + "';";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Check if the ImageData column is not null
                if (!reader.IsDBNull(16))
                {
                    byte[] imageData = (byte[])reader["profile_pic"];

                    // Convert the byte array to Image
                    Image retrievedImage = ByteArrayToImage(imageData);

                    // Resize the retrieved image based on the target PictureBox size
                    resizedImage = ResizeImage(retrievedImage, p1.Width, p1.Height);

                }

            }
            con.Close();
            reader.Close();

            return resizedImage;
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                panel1.Height += 1000;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                panel1.Height -= 1000;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            //update
            UpdateUser update = new UpdateUser();
            try
            {
                string query1 = "SELECT * FROM users WHERE username='" + Login.admin + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    update.txt_username.Text = Convert.ToString(reader["username"]);
                    update.txt_pno.Text = Convert.ToString(reader["phone_num"]);
                    update.txt_email.Text = Convert.ToString(reader["email"]);


                }

                reader.Close();
                con.Close();
                Image resizedImage = RetrieveAndResizeImageFromDatabase(update.uprofilepic);

                if (resizedImage != null)
                {
                    // Display the resized image in the target PictureBox

                    update.uprofilepic.Image = resizedImage;
                }

                update.ShowDialog();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label24.Text = "LOGIN/REGISTER";
            Login.login_status = false;
            ppsmall.Image = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {
            if (Login.login_status == false)
            {
                if (label24.Text == "LOGIN/REGISTER")
                {
                    Login l = new Login();
                    l.ShowDialog();
                    if (Login.login_status == true)
                    {

                        label24.Text = Login.admin;
                        Image resizedImage = RetrieveAndResizeImageFromDatabase(pp);
                        Image resizedImage1 = RetrieveAndResizeImageFromDatabase(ppsmall);
                        if (resizedImage != null)
                        {
                            // Display the resized image in the target PictureBox
                            pp.Image = resizedImage;
                            ppsmall.Image = resizedImage1;
                        }
                        else
                        {
                            pp.Image = null;
                            ppsmall.Image = null;
                        }
                    }
                }

            }
            else if (Login.login_status == true)
            {
                Image resizedImage = RetrieveAndResizeImageFromDatabase(pp);
                Image resizedImage1 = RetrieveAndResizeImageFromDatabase(ppsmall);
                if (resizedImage != null)
                {
                    // Display the resized image in the target PictureBox
                    pp.Image = resizedImage;
                    ppsmall.Image = resizedImage1;
                }
                else
                {
                    pp.Image = null;
                    ppsmall.Image = null;
                }
                label24.Text = Login.admin;

                timer1.Start();
            }
        }

        private void bunifuThinButton22_Click_3(object sender, EventArgs e)
        {
            if (Login.login_status == true)
            {
                UserDetails u = new UserDetails();
                try
                {
                    string query = "select * from users where username='" + Login.admin + "'";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        u.txt_username.Text = Convert.ToString(reader["username"]);
                        u.txt_fname.Text = Convert.ToString(reader["f_name"]);
                        u.txt_lname.Text = Convert.ToString(reader["l_name"]);
                        u.txt_dob.Text = Convert.ToString(reader["dob"]);
                        u.txt_age.Text = Convert.ToString(reader["age"]);
                        u.txt_pno.Text = Convert.ToString(reader["phone_num"]);
                        u.txt_email.Text = Convert.ToString(reader["email"]);
                        u.txt_passport_no.Text = Convert.ToString(reader["passport_no"]);
                        u.txt_nationality.Text = Convert.ToString(reader["nationality"]);
                        u.txt_pass_issue.Text = Convert.ToString(reader["pass_issue"]);
                        u.txt_pass_exp.Text = Convert.ToString(reader["pass_exp"]);
                        u.txt_sex.Text = Convert.ToString(reader["gender"]);
                        u.txt_address.Text = Convert.ToString(reader["adress"]);
                        u.txt_city.Text = Convert.ToString(reader["city"]);


                    }

                    reader.Close();
                    con.Close();
                    Image resizedImage = RetrieveAndResizeImageFromDatabase(u.profilepic);

                    if (resizedImage != null)
                    {
                        // Display the resized image in the target PictureBox

                        u.profilepic.Image = resizedImage;
                    }
                    else
                    {
                        u.profilepic = null;
                    }
                    u.ShowDialog();
                }
                catch (Exception ee)
                {

                    throw;
                }
            }

        }


        private void txt_source_TextChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void txt_dest_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadData()
        {



        }


        private void txt_source_TextChanged_1(object sender, EventArgs e)
        {

            //try
            //{

            //    string query = "SELECT distinct city FROM city WHERE city LIKE '" + txt_source.Text + "%'";

            //    con.Open();
            //    SqlCommand command = new SqlCommand(query, con);

            //SqlDataReader reader = command.ExecuteReader();

            //    List<string> suggestions = new List<string>();
            //    while (reader.Read())
            //    {
            //        suggestions.Add(Convert.ToString(reader["city"]));
            //    }

            //    //   Bind suggestions to text field
            //    txt_source.AutoCompleteMode = AutoCompleteMode.Suggest;
            //    txt_source.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    txt_source.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            //    txt_source.AutoCompleteCustomSource.AddRange(suggestions.ToArray());
            //    reader.Close();
            //}

            //catch (Exception ee)
            //{

            //    MessageBox.Show(ee.Message.ToString());
            //}

            //finally
            //{

            //    con.Close();


            //}

        }

        private void roundtrip_CheckedChanged(object sender, EventArgs e)
        {
            ret_time.Show();
            label7.Show();
            label13.Show();
            Flights f = new Flights();
            f.guna2Panel8.Show();
            f.panel4.Hide();
            Isroundtrip = true;

        }

        private void onewaytrip_CheckedChanged(object sender, EventArgs e)
        {
            label7.Hide();
            ret_time.Hide();
            label13.Hide();
            Flights f = new Flights();
            f.guna2Panel8.Hide();
            f.panel4.Hide();
            Isroundtrip = false;

        }
        public void search_flights(string depdate, string retdate)
        {

        }

        private void btn_searchflight_Click(object sender, EventArgs e)
        {
            double p = 0, far = 0.0;
            string pstart = string.Empty, pend = string.Empty;
            if (txt_dest.Text.Equals("") || txt_source.Text.Equals("") || passengerclass.Text.Equals("") || noofpassenger.Text.Equals(""))
            {
                MessageBox.Show("field cannot be left empty");
            }
            if (roundtrip.Checked == false && onewaytrip.Checked == false)
            {
                MessageBox.Show("please select your trip first");
            }
            else
            {
                try
                {
                    Flights f = new Flights();
                    con.Open();
                    string query = "EXEC generate_city_id   '" + txt_source.Text + "'";
                    string query1 = "EXEC generate_city_id   '" + txt_dest.Text + "'";
                    string disquery = "select * from packages";

                    SqlCommand cmd = new SqlCommand(disquery, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        disctitle = Convert.ToString(reader["package_description"]);
                        disc = 20;
                        pstart = Convert.ToString(reader["package_start"]);
                        pend = Convert.ToString(reader["package_end"]);
                    }
                    else
                    {
                        disctitle = "";
                        disc = 0;
                        pstart = "";
                        pend = "";
                    }
                    reader.Close();
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        src_id = Convert.ToInt32(reader["city_id"]);

                        if (txt_source.Text.Equals("Karachi") || txt_source.Text.Equals("karachi"))
                        {
                            src = "KHI";

                        }
                        else if (txt_source.Text.Equals("Lahore") || txt_source.Text.Equals("lahore"))
                        {
                            src = "LHR";
                        }
                        else if (txt_source.Text.Equals("Islamabad") || txt_source.Text.Equals("islamabad"))
                        {
                            src = "ISB";
                        }
                        else if (txt_source.Text.Equals("Multan") || txt_source.Text.Equals("multan"))
                        {

                            src = "MUX";
                        }
                        else if (txt_source.Text.Equals("Peshawar") || txt_source.Text.Equals("peshawar"))
                        {
                            src = "PEW";
                        }
                        else if (txt_source.Text.Equals("Rawalpindi") || txt_source.Text.Equals("rawalpindi"))
                        {
                            src = "RWP";
                        }
                        else if (txt_source.Text.Equals("Sialkot") || txt_source.Text.Equals("Sialkot"))
                        {
                            src = "SKT";

                        }

                    }
                    reader.Close();
                    cmd = new SqlCommand(query1, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dest_id = Convert.ToInt32(reader["city_id"]);
                        if (txt_dest.Text.Equals("Karachi"))
                        {
                            dest = "KHI";

                        }
                        else if (txt_dest.Text.Equals("lahore"))
                        {
                            dest = "LHR";
                        }
                        else if (txt_dest.Text.Equals("Islamabad"))
                        {
                            dest = "ISB";
                        }
                        else if (txt_dest.Text.Equals("Multan"))

                        {

                            dest = "MUX";
                        }
                        else if (txt_dest.Text.Equals("Peshawar"))
                        {
                            dest = "PEW";
                        }
                        else if (txt_source.Text.Equals("Rawalpindi"))
                        {
                            dest = "RWP";
                        }
                        else if (txt_source.Text.Equals("Sialkot"))
                        {
                            dest = "SKT";

                        }

                    }
                    string query7 = "EXEC generate_class_id  '" + passengerclass.SelectedItem.ToString() + "'";

                    reader.Close();
                    cmd = new SqlCommand(query7, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        class_id = Convert.ToInt32(reader["class_id"]);

                    }

                    reader.Close();
                    //outbound
                    string query3 = "exec [search_flights_fj]  '" + src_id + "','" + dest_id + "','" + dep_time.Text.ToString() + "'";
                    string query4 = "exec [search_flights_pia]  '" + src_id + "','" + dest_id + "','" + dep_time.Text.ToString() + "'";
                    //return  
                    string query5 = "exec [search_flights_fj]  '" + dest_id + "','" + src_id + "' ,'" + ret_time.Text.ToString() + "'";
                    string query6 = "exec [search_flights_pia]  '" + dest_id + "','" + src_id + "' ,'" + ret_time.Text.ToString() + "'";

                    string query11 = " select * from [flight_info_fj] where src_id='" + src_id + "' and  dest_id='" + dest_id + "' and flight_date between '" + pstart + "' and '" + pend + "'";
                    string query12 = " select * from [flight_info_pia] where src_id='" + src_id + "' and  dest_id='" + dest_id + "' and flight_date between '" + pstart + "' and '" + pend + "'";
                    //retur
                    string qery13 = " select * from [flight_info_fj] where src_id='" + dest_id + "' and  dest_id='" + src_id + "' and flight_date between '" + pstart + "' and '" + pend + "'";
                    string query14 = " select * from [flight_info_pia] where src_id='" + dest_id + "' and  dest_id='" + src_id + "' and flight_date between '" + pstart + "' and '" + pend + "'";

                    cmd = new SqlCommand(query11, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        isdisc = true;
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand(query12, con);
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isdisc = true;
                        }
                    }
                    reader.Close();
                    cmd = new SqlCommand(qery13, con);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isdiscr = true;
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand(query14, con);
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isdiscr = true;
                        }
                    }
                    
                    reader.Close();
                    cmd = new SqlCommand(query4, con);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        air_id = Convert.ToInt32(reader["airline_id"]);
                        flight_num = Convert.ToInt32(reader["flight_nump"]);
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand(query3, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            air_id = Convert.ToInt32(reader["airline_id"]);
                            flight_num = Convert.ToInt32(reader["flight_numf"]);
                        }
                        
                    }
                    reader.Close();
                    cmd = new SqlCommand(query6, con);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        air_idr = Convert.ToInt32(reader["airline_id"]);
                        flight_numr = Convert.ToInt32(reader["flight_nump"]);
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand(query5, con);
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            air_idr = Convert.ToInt32(reader["airline_id"]);
                            flight_numr = Convert.ToInt32(reader["flight_numf"]);
                        }
                        
                    }
                    reader.Close();
                    MessageBox.Show(air_id.ToString()+"\n"+air_idr.ToString());
                    if (air_id == 1)
                    {
                        string query9 = "exec calculate_fare_p '" + class_id + "','" + src_id + "','" + dest_id + "','" + dep_time.Text.ToString() + "','" + flight_num + "'";
                        cmd = new SqlCommand(query9, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            fare = Convert.ToString(reader["fare"]);
                            p = Convert.ToDouble(noofpassenger.Text);
                            far = Convert.ToDouble(fare);
                            tot_d = far * p;

                            if (isdisc == true)
                            {
                                discamt = (tot_d * 0.2);
                            }
                            tot_d = tot_d - discamt;
                            f.txt_disc.Text = "PKR " + discamt;
                            totfare_d = Convert.ToString(tot_d);
                            f.lbl_totfare.Text = "PKR " + totfare_d;
                            f.lbl_tot.Text = totfare_d;

                            double tax = ((tot_d * 13) / 100);
                            f.lbl_tax.Text = tax.ToString();
                            f.lbl_grandtot.Text = (tot_d + tax).ToString();
                        }
                        
                        reader.Close();
                    }
                    else if (air_id == 2)
                    {

                        string query8 = "exec calculate_fare_f '" + class_id + "','" + src_id + "','" + dest_id + "','" + dep_time.Text.ToString() + "','" + flight_num + "'";
                        cmd = new SqlCommand(query8, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {


                            fare = Convert.ToString(reader["fare"]);
                            p = Convert.ToDouble(noofpassenger.Text);
                            far = Convert.ToDouble(fare);
                            tot_d = far * p;
                            if (isdisc == true)
                            {
                                discamt = ((tot_d * 20) / 100);
                            }
                            tot_d = tot_d - discamt;
                            f.txt_disc.Text = "PKR " + discamt;
                            totfare_d = Convert.ToString(tot_d);
                            f.lbl_totfare.Text = "PKR " + totfare_d;
                            f.lbl_tot.Text = totfare_d;

                            double tax = ((tot_d * 13) / 100);
                            f.lbl_tax.Text = tax.ToString();
                            f.lbl_grandtot.Text = (tot_d + tax).ToString();
                        }

                        reader.Close();
                    
                    }
                    if (air_idr == 1)
                    {

                        string query10 = "exec calculate_fare_p '" + class_id + "','" + dest_id + "','" + src_id + "','" + ret_time.Text.ToString() + "','" + flight_num + "'";
                        cmd = new SqlCommand(query10, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            fare = Convert.ToString(reader["fare"]);
                            p = Convert.ToDouble(noofpassenger.Text);
                            far = Convert.ToDouble(fare);
                            tot_r = far * p;
                            grandtot = (tot_d + tot_r).ToString();
                            if (isdiscr == true)
                            {
                                discamtr = (((tot_d + tot_r) * disc) / 100);
                            }
                            f.txt_disc.Text = "PKR " + discamtr;

                            tot_r = (tot_d + tot_r) - discamtr;

                            totfare_r = Convert.ToString(tot_r);
                            f.lbl_totfare.Text = "PKR " + tot_r;
                            f.lbl_tot.Text = grandtot;

                            double tax = (((tot_d + tot_r) * 13) / 100);
                            f.lbl_tax.Text = tax.ToString();
                            f.lbl_grandtot.Text = ((tot_d + tot_r) + tax).ToString();
                        }

                        reader.Close();

                    }
                    else if (air_idr == 2)
                    {
                        string query9 = "exec calculate_fare_f '" + class_id + "','" + dest_id + "','" + src_id + "','" + ret_time.Text.ToString() + "','" + flight_num + "'";
                        cmd = new SqlCommand(query9, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            
                            
                            fare = Convert.ToString(reader["fare"]);
                            p = Convert.ToDouble(noofpassenger.Text);
                            far = Convert.ToDouble(fare);
                            tot_r = far * p;

                            grandtot = (tot_d + tot_r).ToString();
                            {
                                discamtr = (((tot_d + tot_r) * disc) / 100);
                            }
                            
                            f.txt_disc.Text = "PKR " + discamtr;

                            tot_r = (tot_d + tot_r) - discamtr;

                            totfare_r = Convert.ToString(tot_r);
                            //f.lbl_totfare.Text = "PKR " + grandtot;
                            f.lbl_tot.Text = tot_r.ToString();
                            f.lbl_totfare.Text = "PKR " + tot_r.ToString();
                            double tax = (((tot_d + tot_r) * 13) / 100);
                            f.lbl_tax.Text = tax.ToString();
                            f.lbl_grandtot.Text = ((tot_d + tot_r) + tax).ToString();
                        }

                        reader.Close();

                    }
                    
                    
                    if (air_id == 1)
                    {
                        //outbound
                        cmd = new SqlCommand(query4, con);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            ucFlightDetails uf = new ucFlightDetails();

                            f.showflight.Controls.Add(uf);
                            uf.price_e.Text = totfare_d;
                            dep_time.CustomFormat = "MMMM dd,yyyy";
                            f.current.Text = dep_time.Text.ToString();
                            f.current1.Text = dep_time.Value.AddDays(1).ToString().Substring(0, 10);
                            f.current2.Text = dep_time.Value.AddDays(2).ToString().Substring(0, 10);
                            f.current3.Text = dep_time.Value.AddDays(3).ToString().Substring(0, 10);
                            f.current4.Text = dep_time.Value.AddDays(-1).ToString().Substring(0, 10);
                            f.current5.Text = dep_time.Value.AddDays(-2).ToString().Substring(0, 10);
                            f.current6.Text = dep_time.Value.AddDays(-3).ToString().Substring(0, 10);
                            f.label17.Text = "Total fare . " + noofpassenger.Text + " Passenger";
                            f.lbl_src.Text = txt_source.Text;
                            f.lbl_dest.Text = txt_dest.Text;
                            f.lbl_fno.Text = Convert.ToString(reader["flight_nump"]);
                            f.lbl_Air_name.Text = "PIA";
                            f.lbl_fldate.Text = dep_time.Text.ToString();
                            f.lbl_fname_t.Text = ret_time.Text.ToString();
                            f.lbl_arr_t.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            f.lbl_deptime_t.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5); ;
                            f.txt_src_t.Text = txt_source.Text;
                            f.txt_dest_t.Text = txt_dest.Text;
                            uf.lbl_src.Text = src;
                            uf.lbl_dest.Text = dest;
                            uf.lbl_srcfull.Text = txt_source.Text;
                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.label7.Text = passengerclass.Text.ToString();
                            uf.price_e.Text = totfare_d;
                            uf.lbl_arr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            uf.lbl_dep.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5);
                            uf.lbl_date.Text = Convert.ToString(reader["flight_date"]);

                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.lbl_flights.Text = Convert.ToString(reader["flight_nump"]);
                            uf.lbl_flightname.Text = "PIA";

                        }
                        reader.Close();
                    }
                    else if (air_id == 2)
                    {
                        cmd = new SqlCommand(query3, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            ucFlightDetails uf = new ucFlightDetails();
                            f.showflight.Controls.Add(uf);
                            uf.price_e.Text = totfare_d;
                            dep_time.CustomFormat = "MMMM dd,yyyy";
                            f.current.Text = dep_time.Text.ToString();
                            f.current1.Text = dep_time.Value.AddDays(1).ToString().Substring(0, 10);
                            f.current2.Text = dep_time.Value.AddDays(2).ToString().Substring(0, 10);
                            f.current3.Text = dep_time.Value.AddDays(3).ToString().Substring(0, 10);

                            f.current4.Text = dep_time.Value.AddDays(-1).ToString().Substring(0, 10);
                            f.current5.Text = dep_time.Value.AddDays(-2).ToString().Substring(0, 10);
                            f.current6.Text = dep_time.Value.AddDays(-3).ToString().Substring(0, 10);

                            f.label17.Text = "Total fare . " + noofpassenger.Text + " Passenger";
                            f.lbl_src.Text = txt_source.Text;
                            f.lbl_dest.Text = txt_dest.Text;
                            f.lbl_fno.Text = Convert.ToString(reader["flight_numf"]);
                            f.lbl_Air_name.Text = "FJ";
                            f.lbl_fldate.Text = dep_time.Text.ToString();

                            f.lbl_arr_t.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            f.lbl_deptime_t.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5); ;
                            f.txt_src_t.Text = txt_source.Text;
                            f.txt_dest_t.Text = txt_dest.Text;

                            uf.lbl_src.Text = src;
                            uf.lbl_dest.Text = dest;
                            uf.lbl_srcfull.Text = txt_source.Text;
                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.label7.Text = passengerclass.Text.ToString();
                            uf.price_e.Text = totfare_d;
                            uf.lbl_arr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            uf.lbl_dep.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5);
                            uf.lbl_date.Text = Convert.ToString(reader["flight_date"]);

                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.lbl_flights.Text = Convert.ToString(reader["flight_numf"]);
                            uf.lbl_flightname.Text = "FJ";

                        }
                        reader.Close();

                    }
                    

                    if (air_idr == 1)
                    {
                        //return
                        cmd = new SqlCommand(query6, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            ucFlightDetails uf = new ucFlightDetails();

                            f.showflights1.Controls.Add(uf);
                            uf.price_e.Text = totfare_r;
                            dep_time.CustomFormat = "MMMM dd,yyyy";
                            f.currentr1.Text = ret_time.Text.ToString();
                            f.currentr2.Text = ret_time.Value.AddDays(1).ToString().Substring(0, 10);
                            f.currentr3.Text = ret_time.Value.AddDays(2).ToString().Substring(0, 10);
                            f.currentr4.Text = ret_time.Value.AddDays(3).ToString().Substring(0, 10);

                            f.currentr6.Text = ret_time.Value.AddDays(-1).ToString().Substring(0, 10);
                            f.currentr7.Text = ret_time.Value.AddDays(-2).ToString().Substring(0, 10);
                            f.currentr8.Text = ret_time.Value.AddDays(-3).ToString().Substring(0, 10);

                            f.label17.Text = "Total fare . " + noofpassenger.Text + " Passenger";
                            f.lbl_src.Text = txt_source.Text;
                            f.lbl_dest.Text = txt_dest.Text;
                            f.lbl_fno.Text = Convert.ToString(reader["flight_nump"]);
                            f.lbl_Air_name.Text = "PIA";
                            f.lbl_fdate_tr.Text = ret_time.Text.ToString();

                            f.lbl_arr_tr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            f.lbl_dep_tr.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5); ;
                            f.lbl_src_tr.Text = txt_source.Text;
                            f.lbl_dest_tr.Text = txt_dest.Text;

                            uf.lbl_src.Text = src;
                            uf.lbl_dest.Text = dest;
                            uf.lbl_srcfull.Text = txt_source.Text;
                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.label7.Text = passengerclass.Text.ToString();
                            uf.price_e.Text = totfare_r;
                            uf.lbl_arr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            uf.lbl_dep.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5);
                            uf.lbl_date.Text = Convert.ToString(reader["flight_date"]);

                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.lbl_flights.Text = Convert.ToString(reader["flight_nump"]);
                            uf.lbl_flightname.Text = "PIA";


                        }
                        reader.Close();

                    }
                    else if (air_idr == 2)
                    {
                        //return
                        cmd = new SqlCommand(query5, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            ucFlightDetails uf = new ucFlightDetails();
                            f.showflights1.Controls.Add(uf);
                            uf.price_e.Text = totfare_r;
                            dep_time.CustomFormat = "MMMM dd,yyyy";
                            f.currentr1.Text = ret_time.Text.ToString();
                            f.currentr2.Text = ret_time.Value.AddDays(1).ToString().Substring(0, 10);
                            f.currentr3.Text = ret_time.Value.AddDays(2).ToString().Substring(0, 10);
                            f.currentr4.Text = ret_time.Value.AddDays(3).ToString().Substring(0, 10);

                            f.currentr6.Text = ret_time.Value.AddDays(-1).ToString().Substring(0, 10);
                            f.currentr7.Text = ret_time.Value.AddDays(-2).ToString().Substring(0, 10);
                            f.currentr8.Text = ret_time.Value.AddDays(-3).ToString().Substring(0, 10);


                            f.label17.Text = "Total fare . " + noofpassenger.Text + " Passenger";
                            f.lbl_src.Text = txt_source.Text;
                            f.lbl_dest.Text = txt_dest.Text;
                            f.lbl_fno.Text = Convert.ToString(reader["flight_numf"]);
                            f.lbl_Air_name.Text = "FJ";
                            f.lbl_fdate_tr.Text = ret_time.Text.ToString();

                            f.lbl_arr_tr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            f.lbl_dep_tr.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5); ;
                            f.lbl_src_tr.Text = txt_source.Text;
                            f.lbl_dest_tr.Text = txt_dest.Text;

                            uf.lbl_src.Text = src;
                            uf.lbl_dest.Text = dest;
                            uf.lbl_srcfull.Text = txt_source.Text;
                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.label7.Text = passengerclass.Text.ToString();

                            uf.lbl_arr.Text = Convert.ToString(reader["arr_time"]).Substring(0, 5);
                            uf.lbl_dep.Text = Convert.ToString(reader["dep_time"]).Substring(0, 5);
                            uf.lbl_date.Text = Convert.ToString(reader["flight_date"]);
                            uf.price_e.Text = totfare_r;
                            uf.lbl_destfull.Text = txt_dest.Text;
                            uf.lbl_flights.Text = Convert.ToString(reader["flight_numf"]);
                            uf.lbl_flightname.Text = "FJ";
                        }
                        reader.Close();
                    }
                    
                    this.Hide();
                    f.Show();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString(), "ABS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
