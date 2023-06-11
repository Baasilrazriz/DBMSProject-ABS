using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class ConfirmPayment : Form
    {
        public static bool IsSuccess=false;
        public ConfirmPayment()
        {
            InitializeComponent();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (Flights.otp_code.Equals(txt_otp.Text))
            {
                IsSuccess = true;
                MessageBox.Show(IsSuccess.ToString());
                this.Close();
            }
        }

        private void btn_resend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
