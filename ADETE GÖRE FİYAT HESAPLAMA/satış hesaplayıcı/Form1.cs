using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int kazanc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int t, b, k, a, toplam;
            t = Convert.ToInt16(txtT.Text);
            b = Convert.ToInt16(txtB.Text);
            k = Convert.ToInt16(txtK.Text);
            a = Convert.ToInt16(txtA.Text);
            toplam = t * 170 + b * 80 + k * 90 + a * 60;
            lbltoplam.Text = toplam.ToString() + " TL";

            kazanc = kazanc + toplam;
            lblkazanc.Text = kazanc.ToString() + " TL";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtK.Text = "";
            txtT.Text = "";
            lbltoplam.Text = "";
            txtT.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kazanc = 0;
            lblkazanc.Text = "0 TL";

            lbltoplam.Text = "0 TL";

            txtA.Clear();
            txtB.Clear();
            txtK.Clear();
            txtT.Clear();

            txtT.Focus();
        }

        //INSTAGRAM ==>> samet_altundag63
        //INSTAGRAM ==>> samethecode
    }
}
