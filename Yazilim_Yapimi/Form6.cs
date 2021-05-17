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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string user_para;

        VeriTabanıMetot VTM = new VeriTabanıMetot();

        
        private void button1_Click(object sender, EventArgs e)
        {

            VTM.bakiye_ekle(user_para, Convert.ToInt32(TxtMiktar.Text));  //kullanıcının sisteme para ekleme isteği göndermesini sağlar
            TxtMiktar.Text = "";
            MessageBox.Show("para ekleme talebiniz iletilmiştir");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
