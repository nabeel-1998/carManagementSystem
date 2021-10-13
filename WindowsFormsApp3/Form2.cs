using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            bunifuPages1.SetPage(tabPage1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }
    }
}
