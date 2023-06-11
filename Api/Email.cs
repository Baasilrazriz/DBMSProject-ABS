using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBMSProject
{
    internal class Email
    {

        MailMessage mm = new MailMessage();
        SmtpClient sc = new SmtpClient("smtp.gmail.com");

        public void send(string to)
        {
            try
            {
                string time = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                mm.From = new MailAddress("baasil86805@gmail.com");
                mm.To.Add(to);
                mm.Subject = "ABS-Login";
                mm.Body = "you have logged in your account at " + time + ".\nHope you get the best experience.";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("baasil86805@gmail.com", "fohl fwjq mmsa qsyj");
                sc.EnableSsl = true;
                sc.Send(mm);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Email"+ex.Message);
            }
        }

        public void sendemail(string to,string otp_code)
        {
            try
            {
            
                mm.From = new MailAddress("baasil86805@gmail.com");
                mm.To.Add(to);
                mm.Subject = "PFMS-RESET YOUR PASSWORD";
                mm.Body = "here is your otp:" + otp_code + ".Now you can reset your password easily\nif any query contact us on bah@gmail.com";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("baasil86805@gmail.com", "fohl fwjq mmsa qsyj");
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Email" + ex.Message);
            }
        }
        public void sendemail_Attach(string to,string outputFilePath)
        {   
            
        }
    }
}
