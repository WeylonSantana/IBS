﻿using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Controls;

namespace FormControls
{
    public class Labels
    {
        public static DarkLabel NewLabel(DarkLabel label, int x, int y, string name)
        {
            label.Text = $"{name}";
            label.Location = new Point(x, y);
            label.AutoSize = true;
            return label;
        }
    }
}
