using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace DBMSProject
{
    public partial class admin : Form
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
        SqlConnection con = new SqlConnection(@"Data Source=MY-DEVICE\MSSQL;Initial Catalog=ABS AIRLINE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        private Timer timer;
        private string labelText;
        private int labelIndex;
        int src_id;
        int dest_id;
        public admin()
        {
            string text = "Select Airline";
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //date time code
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            datetime.Text = formattedDateTime;
            datetime1.Text = formattedDateTime;
            datetime2.Text = formattedDateTime;
            datetime3.Text = formattedDateTime;
            datetime4.Text = formattedDateTime;
            datetime6.Text = formattedDateTime;
            datetime7.Text = formattedDateTime;
            //disclamer code 
            timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            labelText = "Passengers are responsible for obtaining the necessary travel documents, including passports and visas, and complying with all applicable laws and regulations.";
            labelIndex = 100;
            disclamer.Text = labelText;
            //combo box code
            flightscombobox.SelectedIndexChanged += FlightComboBox_SelectedIndexChanged;
            //combo box code
            selectioncombo.SelectedIndexChanged += SelectionCombo_SelectedIndexChanged;




        }
        private void SelectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = selectioncombo.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "Pakistan International Airline":
                    try
                    {
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                    break;

                case "Fly Jinnah":

                    try
                    {
                       
                    }
                    catch (Exception ex)
                    {
                        // handle any errors
                        MessageBox.Show("error: " + ex.Message);
                    }
                    break;

                default:
                    // Default action
                    Console.WriteLine("Other option is selected");
                    break;
            }
        }
        private void FlightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = flightscombobox.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "Pakistan International Airline":
                    try
                    {
                        piagrid.Show();
                        fjgrid.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                    break;

                case "Fly Jinnah":

                    try
                    {
                        fjgrid.Show();
                        piagrid.Hide();
                    }
                    catch (Exception ex)
                    {
                        // handle any errors
                        MessageBox.Show("error: " + ex.Message);
                    }
                    break;

                default:
                    // Default action
                    Console.WriteLine("Other option is selected");
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelIndex = (labelIndex + 1) % labelText.Length;
            disclamer.Text = labelText.Substring(labelIndex) + labelText.Substring(0, labelIndex);
        }


        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (flightscombobox.SelectedIndex == -1)
            {
                fjgrid.Hide();
                piagrid.Hide();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();

        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            // tab page 3

        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tab page 4
        }

        private void gunaDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // tab page 5
        }

        private void gunaDataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // tab page 6
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            flight_numtxtp.Text = flight_num();
            string flight_num()
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
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int airline_id = 1;
            try
            {
                SqlDataReader reader;
                con.Open();
                try
                { 
                    string src_id_city = "EXEC generate_city_id '" + srctxtp.Text + "'";
                    cmd = new SqlCommand(src_id_city, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        src_id = Convert.ToInt32(reader["city_id"]);
                    }
                    reader.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                try
                {
                    string dest_id_city = "EXEC generate_city_id '" + desttxtp.Text + "'";
                    cmd = new SqlCommand(dest_id_city, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dest_id = Convert.ToInt32(reader["city_id"]);
                    }
                    reader.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                string query = "EXEC add_pia_flight '" +Convert.ToInt32( flight_numtxtp.Text) + "','" + airline_id + "','" + Convert.ToString(dep_timetxtp.Text) + "','" + Convert.ToString(arrival_timetxtp.Text) + "','" + src_id + "','" + dest_id + "','" + Convert.ToInt32(seatstxtp.Text) + "','" + Convert.ToDateTime(datetxtp.Text) + "'";
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Inserted");
                }
                con.Close();
                reader.Close();
                MessageBox.Show("Flight Added Successfully");
                flight_numtxtp.Clear();

                dep_timetxtp.Clear();

                arrival_timetxtp.Clear();
                srctxtp.Clear();
                desttxtp.Clear();
                seatstxtp.Clear();
                datetxtp.Clear();

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selectioncombo.SelectedItem.ToString().Equals("Pakistan International Airline"))
            {
                try
                {
                    SqlDataReader reader;
                    con.Open();
                    string query = "delete from PIA where flight_nump='" + txtflightnum.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Flight Deleted Successfully");
                        txtflightnum.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Flight number");
                        txtflightnum.Clear();
                    }
                    con.Close();
                    reader.Close();

                    txtflightnum.Enabled = false;
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else if( selectioncombo.SelectedItem.ToString().Equals("Fly Jinnah"))
            {
                try
                {
                    SqlDataReader reader;
                    con.Open();
                    string query = "delete from FJ where flight_numf='" + txtflightnum.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Flight Deleted Successfully");
                        txtflightnum.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Flight number");
                        txtflightnum.Clear();
                    }
                    con.Close();
                    reader.Close();

                    txtflightnum.Enabled = false;
                }
                catch (Exception ee)
                {

                    MessageBox.Show("The flight number is invalid");
                }
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void datetime6_Click(object sender, EventArgs e)
        {

        }

        private void disclamer_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flightscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet17.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.aMSDataSet17.City);
            // TODO: This line of code loads data into the 'aMSDataSet16.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.aMSDataSet16.Country);
            // TODO: This line of code loads data into the 'aMSDataSet15.airline' table. You can move, or remove it, as needed.
            this.airlineTableAdapter.Fill(this.aMSDataSet15.airline);
            // TODO: This line of code loads data into the 'aMSDataSet14.flight_info_fj' table. You can move, or remove it, as needed.
            this.flight_info_fjTableAdapter.Fill(this.aMSDataSet14.flight_info_fj);
            // TODO: This line of code loads data into the 'aMSDataSet13.flight_info_pia' table. You can move, or remove it, as needed.
            this.flight_info_piaTableAdapter.Fill(this.aMSDataSet13.flight_info_pia);
            //// TODO: This line of code loads data into the 'aMSDataSet13.flight_info_pia' table. You can move, or remove it, as needed.
            //this.flight_info_piaTableAdapter.Fill(this.aMSDataSet13.flight_info_pia);


        }

        private void btn_country_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btn_city_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;
        }

        private void srctxtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatef_Click(object sender, EventArgs e)
        {
            flight_numtxtf.Text = flight_num();
            string flight_num()
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
        }

        private void addbtnf_Click(object sender, EventArgs e)
        {
            int airline_id = 2;


            try
            {
                SqlDataReader reader;
                con.Open();
                try
                {
                    string src_id_city = "EXEC generate_city_id '" + srctxtf.Text + "'";
                    cmd = new SqlCommand(src_id_city, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        src_id = Convert.ToInt32(reader["city_id"]);
                    }
                    reader.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                try
                {
                    string dest_id_city = "EXEC generate_city_id '" + desttxtf.Text + "'";
                    cmd = new SqlCommand(dest_id_city, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dest_id = Convert.ToInt32(reader["city_id"]);
                    }
                    reader.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                string query = "EXEC add_fj_flight '" + Convert.ToInt32(flight_numtxtf.Text) + "','" + airline_id + "','" + Convert.ToString(dep_timetxtf.Text) + "','" + Convert.ToString(arrival_timetxtf.Text) + "','" + src_id + "','" + dest_id + "','" + Convert.ToInt32(seatstxtf.Text) + "','" + Convert.ToDateTime(datetxtf.Text) + "'";
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Inserted");
                }
                con.Close();
                reader.Close();
                MessageBox.Show("Flight Added Successfully");
               
                flight_numtxtf.Clear();
                dep_timetxtp.Clear();
               arrival_timetxtp.Clear();
                srctxtp.Clear();
                desttxtp.Clear();
                seatstxtp.Clear();
                datetxtp.Clear();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            if (selectioncombo.SelectedItem.ToString().Equals("Pakistan International Airline"))
            {
                deletepanel.Show();
                try
                {
                    SqlDataReader reader;
                    con.Open();
                    string query = "select * from PIA where flight_nump='" + txtflightnum.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Flight Searched Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Flight number");
                    }
                    con.Close();
                    reader.Close();


                }
                catch (Exception ee)
                {

                    MessageBox.Show("Something went wrong");
                    //txtflightnum.Enabled = true;
                }

            }
            else if (selectioncombo.SelectedItem.ToString().Equals("Fly Jinnah"))
            {
                deletepanel.Show();
                try
                {
                    SqlDataReader reader;
                    con.Open();
                    string query = "select * from FJ where flight_numf='" + txtflightnum.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Flight Searched Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Flight number");
                    }
                    con.Close();
                    reader.Close();


                }
                catch (Exception ee)
                {

                    MessageBox.Show("Something went wrong");
                    //txtflightnum.Enabled = true;
                }

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
