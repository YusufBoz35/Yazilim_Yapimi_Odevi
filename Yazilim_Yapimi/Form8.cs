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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
        public string deger;

        VeriTabanıMetot VTM = new VeriTabanıMetot();


        int secilen1 ;
        string secilen_kul_nick;            
        int secilen_kul_istek;
        int eski_bakiye , yeni_bakiye ;
        string silme_degeri ;

        string urun_id;
        int  urun_miktar;
        string urun_tip;

        //kapat
        private void button1_Click(object sender, EventArgs e)                   //Çıkış butonu
        {
            Application.Exit();
        }


        //listele
        private void Form8_Load(object sender, EventArgs e)
        {   
            this.urun_istekTableAdapter.Fill(this.finansDataSet4.urun_istek);    //Urun ekleme isteklerini DataGridView ' a basar
            this.para_istekTableAdapter.Fill(this.finansDataSet3.para_istek);    //para ekleme isteklerini DataGridView ' a basar
        }
        

        // para isteği sil
        private void BtnParaS_Click(object sender, EventArgs e)
        {
            VTM.para_istek_sil(silme_degeri);                                     //Para ekleme isteğini siler
            this.para_istekTableAdapter.Fill(this.finansDataSet3.para_istek);    //para eklem isteklerini yenden tabloya yazdirir
            MessageBox.Show("kayıt silindi");
        }


        // urun isteği sil

        private void BtnUrunS_Click(object sender, EventArgs e)
        {
            VTM.urun_istek_sil(urun_id);
            this.urun_istekTableAdapter.Fill(this.finansDataSet4.urun_istek);
            MessageBox.Show("kayıt silindi");
        }


        // dataGridView1'den  veri seçme
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen1 = dataGridView1.SelectedCells[0].RowIndex;
            silme_degeri = dataGridView1.Rows[secilen1].Cells[0].Value.ToString();
            secilen_kul_nick = dataGridView1.Rows[secilen1].Cells[1].Value.ToString();
            secilen_kul_istek = Convert.ToInt32(dataGridView1.Rows[secilen1].Cells[2].Value);           
        }


        // dataGridView2'den  veri seçme
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen1 = dataGridView2.SelectedCells[0].RowIndex;
            urun_id = dataGridView2.Rows[secilen1].Cells[0].Value.ToString();
            secilen_kul_nick = dataGridView2.Rows[secilen1].Cells[1].Value.ToString();
            urun_tip = dataGridView2.Rows[secilen1].Cells[2].Value.ToString();
            urun_miktar = Convert.ToInt32(dataGridView2.Rows[secilen1].Cells[3].Value);

          
        }
        //public var miktar;
        private void BtnUrunG_Click(object sender, EventArgs e)
        {

            VTM.miktar_guncelle(secilen_kul_nick,urun_tip,urun_miktar);
            MessageBox.Show("guncelleme islemi tamamlandı");
            VTM.urun_istek_sil(urun_id);
            this.urun_istekTableAdapter.Fill(this.finansDataSet4.urun_istek);

        }

        // Para istek onayla vma
        private void BtnParaG_Click(object sender, EventArgs e)
        {
            eski_bakiye = VTM.bakiye_getir(secilen_kul_nick);                     //bakiyesi güncellenicek kullanıcını bakiyesi getirilir                                                            
            yeni_bakiye = eski_bakiye + secilen_kul_istek;
            VTM.para_guncelle(yeni_bakiye, secilen_kul_nick);                     //yeni bakiye veri tabanına eklenir
            VTM.para_istek_sil(silme_degeri);                                     //istek onaylanıp eklenen istek silinir
            this.para_istekTableAdapter.Fill(this.finansDataSet3.para_istek);
        }


    }
}
