﻿using System;
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
    public partial class NNSpecies : Form
    {
        public NNSpecies()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dd form= new dd();    
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            themesong form8= new themesong();    
            form8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 form= new Form10();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code code = new code();
            code.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainpage mainpage = new mainpage();
            mainpage.ShowDialog();
        }
    }
}
