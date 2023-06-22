using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evrak_Arşiv_Otomasyonu
{
    public partial class Form2 : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fsAd = txtfsAD.Text;
            string fsSoyad = txtfsSOYAD.Text;
            string fsKey = txtfsKey.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM fakülteSekreteri where fsAD='" + txtfsAD.Text + "' AND fsSOYAD='" + txtfsSOYAD.Text + "' AND fsKey='" + txtfsKey.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı.");
                Form6 form6 = new Form6(); //fakülte sekreteri sayfası
                form6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                Application.Exit();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtfsKey.PasswordChar = '\0';
            }
            else
            {
                txtfsKey.PasswordChar = '*';
            }
        }
    }
}
