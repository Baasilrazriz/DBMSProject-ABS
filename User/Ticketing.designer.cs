namespace DBMSProject
{
    partial class Ticketing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticketing));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.lbl_class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_fno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel28 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel27 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel26 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_arr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_dep = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_from = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_pname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_pnr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_current = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_note = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lbl_to = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 43);
            this.button1.TabIndex = 129;
            this.button1.Text = "print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelPrint
            // 
            this.panelPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPrint.BackColor = System.Drawing.Color.White;
            this.panelPrint.Controls.Add(this.lbl_class);
            this.panelPrint.Controls.Add(this.lbl_fno);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel19);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel16);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel28);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel27);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel26);
            this.panelPrint.Controls.Add(this.lbl_arr);
            this.panelPrint.Controls.Add(this.lbl_dep);
            this.panelPrint.Controls.Add(this.lbl_to);
            this.panelPrint.Controls.Add(this.lbl_from);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel18);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel17);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel15);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel14);
            this.panelPrint.Controls.Add(this.guna2Separator3);
            this.panelPrint.Controls.Add(this.guna2Separator4);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel13);
            this.panelPrint.Controls.Add(this.lbl_ticket);
            this.panelPrint.Controls.Add(this.lbl_pname);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel10);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel9);
            this.panelPrint.Controls.Add(this.lbl_pnr);
            this.panelPrint.Controls.Add(this.lbl_current);
            this.panelPrint.Controls.Add(this.guna2Separator2);
            this.panelPrint.Controls.Add(this.guna2Separator1);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel6);
            this.panelPrint.Controls.Add(this.lbl_note);
            this.panelPrint.Controls.Add(this.lbl_name);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel2);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel1);
            this.panelPrint.Controls.Add(this.bunifuCustomLabel3);
            this.panelPrint.Location = new System.Drawing.Point(2, 61);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(1165, 861);
            this.panelPrint.TabIndex = 130;
            this.panelPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrint_Paint);
            // 
            // lbl_class
            // 
            this.lbl_class.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.Black;
            this.lbl_class.Location = new System.Drawing.Point(881, 434);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(147, 28);
            this.lbl_class.TabIndex = 164;
            this.lbl_class.Text = "\"Class\"";
            // 
            // lbl_fno
            // 
            this.lbl_fno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fno.ForeColor = System.Drawing.Color.Black;
            this.lbl_fno.Location = new System.Drawing.Point(636, 434);
            this.lbl_fno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fno.Name = "lbl_fno";
            this.lbl_fno.Size = new System.Drawing.Size(147, 28);
            this.lbl_fno.TabIndex = 163;
            this.lbl_fno.Text = "\"Flight No\"";
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel19.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel19.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(882, 409);
            this.bunifuCustomLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(128, 28);
            this.bunifuCustomLabel19.TabIndex = 162;
            this.bunifuCustomLabel19.Text = "Booking Class";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(637, 409);
            this.bunifuCustomLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(64, 28);
            this.bunifuCustomLabel16.TabIndex = 161;
            this.bunifuCustomLabel16.Text = "Flight";
            // 
            // bunifuCustomLabel28
            // 
            this.bunifuCustomLabel28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel28.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel28.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel28.Location = new System.Drawing.Point(36, 714);
            this.bunifuCustomLabel28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel28.Name = "bunifuCustomLabel28";
            this.bunifuCustomLabel28.Size = new System.Drawing.Size(161, 28);
            this.bunifuCustomLabel28.TabIndex = 160;
            this.bunifuCustomLabel28.Text = "Best Regards,";
            // 
            // bunifuCustomLabel27
            // 
            this.bunifuCustomLabel27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel27.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel27.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel27.Location = new System.Drawing.Point(36, 747);
            this.bunifuCustomLabel27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
            this.bunifuCustomLabel27.Size = new System.Drawing.Size(1039, 60);
            this.bunifuCustomLabel27.TabIndex = 159;
            this.bunifuCustomLabel27.Text = "Baggage information: Please do not place valuables items such as jeweler, laptops" +
    " and mobile phones,. or important documents inside your checked baggage.";
            // 
            // bunifuCustomLabel26
            // 
            this.bunifuCustomLabel26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel26.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel26.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel26.Location = new System.Drawing.Point(34, 677);
            this.bunifuCustomLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel26.Name = "bunifuCustomLabel26";
            this.bunifuCustomLabel26.Size = new System.Drawing.Size(529, 28);
            this.bunifuCustomLabel26.TabIndex = 158;
            this.bunifuCustomLabel26.Text = "For further information, please contact our service desk.";
            // 
            // lbl_arr
            // 
            this.lbl_arr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_arr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_arr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arr.ForeColor = System.Drawing.Color.Black;
            this.lbl_arr.Location = new System.Drawing.Point(239, 622);
            this.lbl_arr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_arr.Name = "lbl_arr";
            this.lbl_arr.Size = new System.Drawing.Size(147, 28);
            this.lbl_arr.TabIndex = 155;
            this.lbl_arr.Text = "\"Time\"";
            // 
            // lbl_dep
            // 
            this.lbl_dep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep.ForeColor = System.Drawing.Color.Black;
            this.lbl_dep.Location = new System.Drawing.Point(59, 622);
            this.lbl_dep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(147, 28);
            this.lbl_dep.TabIndex = 154;
            this.lbl_dep.Text = "\"Time\"";
            // 
            // lbl_from
            // 
            this.lbl_from.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_from.BackColor = System.Drawing.Color.Transparent;
            this.lbl_from.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.Black;
            this.lbl_from.Location = new System.Drawing.Point(543, 622);
            this.lbl_from.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(147, 28);
            this.lbl_from.TabIndex = 152;
            this.lbl_from.Text = "\"Location\"";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel18.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(544, 566);
            this.bunifuCustomLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(95, 28);
            this.bunifuCustomLabel18.TabIndex = 150;
            this.bunifuCustomLabel18.Text = "Departure";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(803, 566);
            this.bunifuCustomLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(72, 28);
            this.bunifuCustomLabel17.TabIndex = 149;
            this.bunifuCustomLabel17.Text = "Arrival";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(240, 566);
            this.bunifuCustomLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(56, 28);
            this.bunifuCustomLabel15.TabIndex = 147;
            this.bunifuCustomLabel15.Text = "To";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(58, 566);
            this.bunifuCustomLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(56, 28);
            this.bunifuCustomLabel14.TabIndex = 146;
            this.bunifuCustomLabel14.Text = "From";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(40, 530);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1044, 12);
            this.guna2Separator3.TabIndex = 145;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(41, 524);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(1042, 12);
            this.guna2Separator4.TabIndex = 144;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(45, 485);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(216, 28);
            this.bunifuCustomLabel13.TabIndex = 143;
            this.bunifuCustomLabel13.Text = "Itinerary information";
            // 
            // lbl_ticket
            // 
            this.lbl_ticket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ticket.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ticket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticket.ForeColor = System.Drawing.Color.Black;
            this.lbl_ticket.Location = new System.Drawing.Point(380, 434);
            this.lbl_ticket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ticket.Name = "lbl_ticket";
            this.lbl_ticket.Size = new System.Drawing.Size(165, 28);
            this.lbl_ticket.TabIndex = 142;
            this.lbl_ticket.Text = "\"ticket number\"";
            // 
            // lbl_pname
            // 
            this.lbl_pname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pname.ForeColor = System.Drawing.Color.Black;
            this.lbl_pname.Location = new System.Drawing.Point(72, 434);
            this.lbl_pname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(223, 28);
            this.lbl_pname.TabIndex = 141;
            this.lbl_pname.Text = "\"name of passenger\"";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(381, 411);
            this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(149, 23);
            this.bunifuCustomLabel10.TabIndex = 140;
            this.bunifuCustomLabel10.Text = "Ticket Number";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(80, 411);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(176, 23);
            this.bunifuCustomLabel9.TabIndex = 139;
            this.bunifuCustomLabel9.Text = "Passenger Name";
            // 
            // lbl_pnr
            // 
            this.lbl_pnr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pnr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pnr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnr.ForeColor = System.Drawing.Color.Black;
            this.lbl_pnr.Location = new System.Drawing.Point(201, 199);
            this.lbl_pnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pnr.Name = "lbl_pnr";
            this.lbl_pnr.Size = new System.Drawing.Size(161, 28);
            this.lbl_pnr.TabIndex = 138;
            this.lbl_pnr.Text = "\"PNR Number\"";
            // 
            // lbl_current
            // 
            this.lbl_current.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_current.BackColor = System.Drawing.Color.Transparent;
            this.lbl_current.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current.ForeColor = System.Drawing.Color.Black;
            this.lbl_current.Location = new System.Drawing.Point(896, 9);
            this.lbl_current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(216, 28);
            this.lbl_current.TabIndex = 137;
            this.lbl_current.Text = "\"date\"";
            this.lbl_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(40, 385);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1043, 10);
            this.guna2Separator2.TabIndex = 136;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(38, 380);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1044, 10);
            this.guna2Separator1.TabIndex = 135;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(45, 335);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(148, 28);
            this.bunifuCustomLabel6.TabIndex = 134;
            this.bunifuCustomLabel6.Text = "Ticket details";
            // 
            // lbl_note
            // 
            this.lbl_note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.Black;
            this.lbl_note.Location = new System.Drawing.Point(45, 287);
            this.lbl_note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(996, 28);
            this.lbl_note.TabIndex = 133;
            this.lbl_note.Text = "We confirm the ticket issuance for your reservation \"PNR number\". Please find det" +
    "ails below";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(45, 246);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(280, 28);
            this.lbl_name.TabIndex = 132;
            this.lbl_name.Text = "Dear \"name of passenger\"";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 199);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(148, 28);
            this.bunifuCustomLabel2.TabIndex = 131;
            this.bunifuCustomLabel2.Text = "PNR Number:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(383, 148);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(383, 23);
            this.bunifuCustomLabel1.TabIndex = 130;
            this.bunifuCustomLabel1.Text = "ELECTRONIC TICKET ISSUANCE";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel3.Image")));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(484, 62);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(155, 57);
            this.bunifuCustomLabel3.TabIndex = 129;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(927, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 43);
            this.button2.TabIndex = 131;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lbl_to
            // 
            this.lbl_to.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_to.BackColor = System.Drawing.Color.Transparent;
            this.lbl_to.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.Black;
            this.lbl_to.Location = new System.Drawing.Point(802, 622);
            this.lbl_to.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(147, 28);
            this.lbl_to.TabIndex = 153;
            this.lbl_to.Text = "\"Location\"";
            // 
            // Ticketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 924);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ticketing";
            this.Text = "Ticketing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ticketing_Load);
            this.panelPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel28;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel27;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel26;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_arr;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_dep;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_from;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_ticket;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_pname;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_pnr;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_current;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_note;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Button button2;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_class;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_fno;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.PrintDialog printDialog1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_to;
    }
}