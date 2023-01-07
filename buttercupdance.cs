using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xanad
{
    public partial class buttercupdance : Form
    {
        public buttercupdance()
        {
            InitializeComponent();
        }

        private void buttercupdance_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\PC\\source\\repos\\xanad\\videos\\İsimsiz video ‐ Clipchamp ile yapıldı (8).mp4";
        }
    }
}
