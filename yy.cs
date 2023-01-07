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
    public partial class yySpecies : Form
    {
        public yySpecies()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage form1 = new mainpage();  
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yyvideo1 form7= new yyvideo1();
            form7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mojofrench form9= new mojofrench();
                form9.ShowDialog();
        }

        private void yySpecies_Load(object sender, EventArgs e)
        {

        }
    }
}
