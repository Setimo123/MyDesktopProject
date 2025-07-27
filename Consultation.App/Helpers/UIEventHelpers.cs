using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Helpers
{
    public class UIEventHelpers
    {
        public static void AttachHoverEvents(Control parent, EventHandler onEnter, EventHandler onLeave)
        {
            parent.MouseEnter += onEnter;
            parent.MouseLeave += onLeave;

            foreach (Control child in parent.Controls)
            {
                AttachHoverEvents(child, onEnter, onLeave);
            }
        }

    
    }
}
