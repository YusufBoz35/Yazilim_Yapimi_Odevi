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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        VeriTabanıMetot VTM = new VeriTabanıMetot();   // veri tabanı için yazılan fonksiyonları kullanmak için VTM isimli bir nesne oluşturduk
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parola_onay = VTM.giris_kontrol(TxtNick.Text, TxtParola.Text);   

            if (parola_onay == 1)                           // veri tabanı üzerinde kullanıcı adı ve parola eşleşmesi sağlanırsa kod buradaki karar yapısına girer
            {
                if (TxtNick.Text == "admin")                //kullanici adi eger admin kullanıcı adiyla sisteme giriş yapabildiyse admin sayfasına yönlendirilir
                {
                    Form8 fr8 = new Form8();
                    fr8.Show();
                    this.Hide();
                }
                else 
                {
                    Form4 fr4 = new Form4();
                    fr4.UserNick = TxtNick.Text;
                    fr4.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanci adiniz veya parolanız hatalı");
            }

        }

        
    }
}
