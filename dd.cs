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
    public partial class dd : Form
    {
        public dd()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttercupsleep form11 = new buttercupsleep();
            form11.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttercupdance form22= new buttercupdance();    
            form22.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage formm= new mainpage();
            formm.ShowDialog(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            code code = new code();
            code.ShowDialog();
        }
    }
}
