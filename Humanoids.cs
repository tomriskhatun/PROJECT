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
    public partial class Humanoids : Form
    {
        public Humanoids()
        {
            InitializeComponent();
        }

        private void buttonZZ_Click(object sender, EventArgs e)
        {
            ZZspecies zZspecies2 = new ZZspecies();
            zZspecies2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NNSpecies nNSpecies= new NNSpecies();
            nNSpecies.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dd  dd = new dd();
            dd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yySpecies yySpecies = new yySpecies();
            yySpecies.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpage mainpage = new mainpage();
                mainpage.ShowDialog();
        }
    }
}
