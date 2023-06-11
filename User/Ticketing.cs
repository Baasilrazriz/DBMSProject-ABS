using Guna.UI2.WinForms;
using MimeKit;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ContentDisposition = MimeKit.ContentDisposition;
using Panel = System.Windows.Forms.Panel;
using Rectangle = System.Drawing.Rectangle;

namespace DBMSProject

{
    public partial class Ticketing : Form
    {

        public Ticketing()
        {
            InitializeComponent();

        }

        private async void Ticketing_Load(object sender, EventArgs e)
        {
            if (MyBooking.ISprint==true)
            {
                Wait ws=new Wait();
                ws.ShowDialog();
              await Task.Run(()=> print(panelPrint))  ;
                ws.Close();
                this.Close();
            }
            else if (MyBooking.Isemail==true)
            {
                Wait ws = new Wait();
                ws.ShowDialog();
                await Task.Run(() => ConvertPanelToPdfAndSendEmail(panelPrint, user.name + "'s ticket.pdf", user.email));
                ws.Close();
                this.Close();
               
            }
        }

        Bitmap bitmap;
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public void ConvertPanelToPdfAndSendEmail(Panel panel, string pdfFilePath, string to)
        {
            // Convert panel to PDF
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            var panelSize = panel.Size;
            var panelBitmap = new Bitmap(panelSize.Width, panelSize.Height);
            panel.DrawToBitmap(panelBitmap, new Rectangle(Point.Empty, panelSize));
            using (MemoryStream ms = new MemoryStream())
            {
                panelBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);
                XImage image = XImage.FromStream(ms);
                graphics.DrawImage(image, 0, 0);
            }
            document.Save(pdfFilePath);
            document.Close();

            // Create MIME message
           

            // Create MIME part for PDF attachment
            MimePart attachment = new MimePart("application", "pdf")
            {
                Content = new MimeContent(File.OpenRead(pdfFilePath)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(pdfFilePath)
            };

            // Create MIME multipart to hold the attachment
            Multipart multipart = new Multipart("mixed");
            multipart.Add(attachment);

            // Set the multipart as the message body
           

            MailMessage mm = new MailMessage();
            SmtpClient sc = new SmtpClient("smtp.gmail.com");

            try
            {

                // Create the email message

                mm.From = new MailAddress("baasil86805@gmail.com");
                mm.To.Add(to);
                mm.Subject = "Ticket Details";
                mm.Body = "";


                // Attach the PDF document to the email
                Attachment attach= new Attachment(pdfFilePath);
                mm.Attachments.Add(attach);
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("baasil86805@gmail.com", "fohl fwjq mmsa qsyj");
                sc.EnableSsl = true;
                sc.Send(mm);

                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }
         
        public void print(Panel p)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panelPrint = p;
            getprintarea(p);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrinterSettings.DefaultPageSettings.Landscape = true;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap((Bitmap)memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private void lbl_to_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pname_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel28_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ticket_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel27_Click(object sender, EventArgs e)
        {

        }

        private void lbl_arr_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_current_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel26_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fno_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pnr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_note_Click(object sender, EventArgs e)
        {

        }

        private void lbl_from_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }



        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_class_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dep_Click(object sender, EventArgs e)
        {

        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            converttopdf();
        }
        private Panel panel;
        public void converttopdf()
        {
            //panel = panelPrint; // Replace 'yourPanel' with the name of your Panel control

            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string filePath = saveFileDialog.FileName;

            //        // Create a new PDF document
            //        Document document = new Document();
                    
            //        // Create a PDF writer instance
            //        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            //        // Open the PDF document
            //        document.Open();

            //        // Create a new PDF content byte
            //        PdfContentByte contentByte = writer.DirectContent;

            //        // Create a new PDF template
            //        PdfTemplate template = contentByte.CreateTemplate(panel.Width, panel.Height);

            //        // Draw the panel onto a bitmap
            //        Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            //        panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

            //        // Convert the bitmap to iTextSharp's Image format
            //        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Bmp);

            //        // Set the position and dimensions of the image on the PDF template
            //        image.SetAbsolutePosition(0, 0);
            //        image.ScaleToFit(panel.Width, panel.Height);

            //        // Add the image to the PDF template
            //        template.AddImage(image);

            //        // Add the PDF template to the PDF document
            //        contentByte.AddTemplate(template, 0, 0);

            //        // Close the PDF document
            //        document.Close();


            //        MessageBox.Show("Panel converted to PDF successfully!");
            //    }
            //}
        }
    }
}