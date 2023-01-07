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
    public partial class buttercupsleep : Form
    {
        public buttercupsleep()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\PC\source\repos\xanad\videos\İsimsiz video ‐ Clipchamp ile yapıldı (6).mp4";//buttercup sleep
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
