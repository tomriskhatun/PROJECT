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
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yySpecies form4 = new yySpecies();
            form4.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZZspecies form3 = new ZZspecies();
            form3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         mainpage mainpage = new mainpage();
              mainpage.ShowDialog();
                
        }
    }
}
