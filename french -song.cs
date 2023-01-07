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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
        
         
            axWindowsMediaPlayer1.URL = @"C:\Users\PC\source\repos\xanad\videos\İsimsiz video ‐ Clipchamp ile yapıldı (7).mp4";//fransızca sarkı
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

    }
}
