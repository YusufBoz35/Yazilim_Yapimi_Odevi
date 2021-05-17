using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazilim_Yapimi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string user_urun;
        VeriTabanıMetot VTM = new VeriTabanıMetot();
        

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            VTM.urun_ekle(user_urun, CmbUrun.Text, TxtMiktar.Text);
            CmbUrun.Text = "" ;
            TxtMiktar.Text = "" ;
            MessageBox.Show("Ürün ekleme talabiniz iletilmiştir");               

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
