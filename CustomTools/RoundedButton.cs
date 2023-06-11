using Bunifu.Framework.UI;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DBMSProject
{
    public class RoundedButton : BunifuFlatButton
    {
        private int cornerRadius = 10;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0, 0, Width, Height);
            float radius = cornerRadius;

            // Adjust the radius if it exceeds the maximum possible value
            if (radius > (rect.Width / 2))
                radius = rect.Width / 2;
            if (radius > (rect.Height / 2))
                radius = rect.Height / 2;

            // Create a rounded rectangle path with equal corner radii
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90); // Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the panel's region to the rounded rectangle path
            Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }
}