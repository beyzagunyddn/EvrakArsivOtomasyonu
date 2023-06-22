using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evrak_Arşiv_Otomasyonu
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBoxad.Text;
            string soyad = textBoxsoyad.Text;
            string pass = textBoxparola.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where ad='" + textBoxad.Text + "' AND soyad='" + textBoxsoyad.Text + "' AND parola='" + textBoxparola.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı.");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                Application.Exit();
            }

            
            if (comboBoxformsec.SelectedIndex == 0)
            {
                Form3 form3 = new Form3(); //evraklar tamamladım
                form3.Show();
                this.Hide();
            }
            else if (comboBoxformsec.SelectedIndex == 1)
            {
                Form4 form4 = new Form4();  //emanet tamamladım
                form4.Show();
                this.Hide();
            }
            
            
            else if (comboBoxformsec.SelectedIndex == null)
            {
                MessageBox.Show("İşlem Türünü Seçiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //fakülte sekreteri (giriş ve ana ekranı tamamladım)
            form2.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxparola.PasswordChar = '\0';
            }
            else
            {
                textBoxparola.PasswordChar = '*';
            }
        }
    }
}
