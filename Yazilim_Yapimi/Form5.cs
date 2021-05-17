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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string user_al;



        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }
        

        void listele(string deneme , DataGridView tablo)         //  listele fonksiyonu  kullanıcı satış taleplerini tablolara bastırır 
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
            DataSet daset = new DataSet();

         
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select teklif_sahip , teklif_miktar ,teklif_kg_fiyat from teklifler WHERE teklif_urun like '%"+deneme+"%' ", baglanti);
            adtr.Fill(daset, "teklifler");
            tablo.DataSource = daset.Tables["teklifler"];
            baglanti.Close();
        }

       


        private void Form5_Load(object sender, EventArgs e)
        {
            listele("bugday",dataGridView1);
            listele("arpa", dataGridView2);
            listele("yulaf", dataGridView3);
            listele("petrol", dataGridView4);
            listele("pamuk", dataGridView5);
        }
        
        private void BtnAl1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
