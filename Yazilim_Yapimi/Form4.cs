using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazilim_Yapimi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string UserNick;
        
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.user_al = UserNick;
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            fr.user_para = UserNick;
            fr.Show();      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            fr.user_urun = UserNick;
            fr.Show();     
        }

        
    }
}
