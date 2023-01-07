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
    public partial class mojofrench : Form
    {
        public mojofrench()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\PC\source\repos\xanad\videos\İsimsiz video ‐ Clipchamp ile yapıldı (4).mp4
";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
