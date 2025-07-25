using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Helpers
{
    public class MaterialSkinCardUIHelper
    {
        public static void AddHoverBorder(Control panel, Color hoverColor, Color normalColor, int borderThickness = 2)
        {
            hoverStates[panel] = false;

  
            AttachHoverEvents(panel,
                (s, e) => { hoverStates[panel] = true; panel.Invalidate(); },
                (s, e) => { hoverStates[panel] = false; panel.Invalidate(); }
            );


            panel.Paint += (s, e) =>
            {
                var g = e.Graphics;
                var rect = panel.ClientRectangle;

                bool isHovered = hoverStates[panel];
                Color borderColor = isHovered ? hoverColor : normalColor;

                using (var pen = new Pen(borderColor, borderThickness))
                {
                    rect.Width -= 1;
                    rect.Height -= 1;
                    g.DrawRectangle(pen, rect);
                }
            };
        }
    }
}
