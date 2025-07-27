using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Helpers
{
    public class MaterialSkinCardUIHelper
    {
        public static void AddHoverBorder(Control panel, Color hoverColor, Color normalColor, int thickness = 2)
        {
            //First: set the boolean if ang mouse kay naka enter sa card or not
            bool isHovered = false;

            //Second: Create a method na mo set ang set ang event kung ang mouse kay mo enter or dili
            UIEventHelpers.AttachHoverEvents(panel,
                (s, e) => { isHovered = true; panel.Invalidate(); },
                (s, e) => { isHovered = false; panel.Invalidate(); }
            );

            //Third: Customize event sa card
            panel.Paint += (s, e) =>
            {
                // e.graphics is means creating a paper forthe costumize card
                var g = e.Graphics;
                // panel.ClientRectangle is means creating a area of customize effect
                var rect = panel.ClientRectangle;

                // isHovered ? hoverColor : normalColor; condition if the user hovered or not
                Color borderColor = isHovered ? hoverColor : normalColor;

                //pen means telling the code how to draw the lines
                using (var pen = new Pen(borderColor, thickness))
                {
                    rect.Width -= 1;
                    rect.Height -= 1;
                    g.DrawRectangle(pen, rect);
                }
            };
        }

        public static void AddHoverBackground(Control panel, Color hoverColor, Color normalColor)
        {
            UIEventHelpers.AttachHoverEvents(panel,
                (s, e) => panel.BackColor = hoverColor,
                (s, e) => panel.BackColor = normalColor
            );
        }

        public static void AddHoverAndClickEffect(Control panel, Color hoverColor, Color normalColor, Action onClick)
        {
            UIEventHelpers.AttachHoverEvents(panel,
                (s, e) => panel.BackColor = hoverColor,
                (s, e) => panel.BackColor = normalColor
            );

            panel.Click += (s, e) => onClick?.Invoke();
            foreach (Control child in panel.Controls)
            {
                child.Click += (s, e) => onClick?.Invoke();
            }
        }

        public static System.Drawing.Drawing2D.GraphicsPath SetRoundedCorners(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top-left arc
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            // top-right arc
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            // bottom-right arc
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            // bottom-left arc
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void DrawBorder(Graphics g, Rectangle bounds, Color color, int thickness)
        {
            using (Pen borderPen = new Pen(color, thickness))
            {
                g.DrawRectangle(borderPen, bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1);
            }
        }
    }
}
