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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        VeriTabanıMetot VTM = new VeriTabanıMetot();

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)     // geri gelme butonu
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            VTM.kullanici_kayit(TxtAd.Text, TxtSoyad.Text, TxtNick.Text,TxtParola.Text, MskTc.Text, TxtMail.Text, RtxtAdres.Text, MskTel.Text); //kayıt alma fonksiyonu
            MessageBox.Show("Kaydınız başarıyla tamamlanmıştır");
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
