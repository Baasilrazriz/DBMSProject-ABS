using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace DBMSProject
{
    public partial class MyBooking : Form
    {
        public static bool ISprint, Isemail;
        public MyBooking()
        {
            InitializeComponent();
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyBooking_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Ticketing t=new Ticketing();
            t.lbl_pnr.Text = lbl_pnr.Text.ToUpper();
            t.lbl_name.Text = user.name;
            t.lbl_pname.Text = user.name;
            t.lbl_ticket.Text = lbl_pnr.Text.ToUpper();
            t.lbl_arr.Text=lbl_arr.Text;
            t.lbl_dep.Text = lbl_dep.Text;
            t.lbl_fno.Text=lbl_flights.Text;
            t.lbl_to.Text=lbl_srcfull.Text;
            t.lbl_from.Text=lbl_destfull.Text;
            t.lbl_class.Text=lbl_class.Text;
            t.lbl_current.Text=lbl_date.Text;
            t.lbl_note.Text = "We confirm the ticket issuance for your reservation "+lbl_pnr.Text.ToUpper()+". Please find details below";
            t.ShowDialog();
        }
        public void form_topdf()
        {
            //Document document = new Document();

            //// Create a PDF writer and specify the output file path
            //string outputFilePath = "path/to/output.pdf";
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFilePath, FileMode.Create));

            //// Open the PDF document
            //document.Open();

            //// Add the form content to the PDF document
            

            //// Close the document
            //document.Close();

            //Console.WriteLine("PDF saved successfully.");
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Isemail = true;
            Ticketing t = new Ticketing();
            t.lbl_pnr.Text = lbl_pnr.Text.ToUpper();
            t.lbl_name.Text = user.name;
            t.lbl_pname.Text = user.name;
            t.lbl_ticket.Text = lbl_pnr.Text.ToUpper();
            t.lbl_arr.Text = lbl_arr.Text;
            t.lbl_dep.Text = lbl_dep.Text;
            t.lbl_fno.Text = lbl_flights.Text;
            t.lbl_to.Text = lbl_srcfull.Text;
            t.lbl_from.Text = lbl_destfull.Text;
            t.lbl_class.Text = lbl_class.Text;
            t.lbl_current.Text = lbl_date.Text;
            t.lbl_note.Text = "We confirm the ticket issuance for your reservation " + lbl_pnr.Text.ToUpper() + ". Please find details below";
            t.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ISprint = true;
            Ticketing t = new Ticketing();
            t.lbl_pnr.Text = lbl_pnr.Text.ToUpper();
            t.lbl_name.Text = user.name;
            t.lbl_pname.Text = user.name;
            t.lbl_ticket.Text = lbl_pnr.Text.ToUpper();
            t.lbl_arr.Text = lbl_arr.Text;
            t.lbl_dep.Text = lbl_dep.Text;
            t.lbl_fno.Text = lbl_flights.Text;
            t.lbl_to.Text = lbl_srcfull.Text;
            t.lbl_from.Text = lbl_destfull.Text;
            t.lbl_class.Text = lbl_class.Text;
            t.lbl_current.Text = lbl_date.Text;
            t.lbl_note.Text = "We confirm the ticket issuance for your reservation " + lbl_pnr.Text.ToUpper() + ". Please find details below";
            t.ShowDialog();
        }
    }
}
