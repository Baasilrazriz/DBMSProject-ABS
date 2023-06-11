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
    public partial class ucFlightDetails : UserControl
    {
        // Define a delegate for the button click event
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);

        // Define an event for the button click
        public event ButtonClickedEventHandler ButtonClicked;
        public ucFlightDetails()
        {
            InitializeComponent();
        }
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }
        protected virtual void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void ucFlightDetails_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           Flights flights = new Flights();
            flights.guna2Panel7.Show();  
        }
    }
}
