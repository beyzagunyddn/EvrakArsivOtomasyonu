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

namespace Evrak_Arşiv_Otomasyonu
{
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form6()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM kullanici", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKullaniciID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //visible false
                txtDpt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtad1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtsoyad1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
                txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtParola1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO kullanici(departman,ad,soyad,telefon,mail,parola)" + //values sonra kullaniciID
    "VALUES (@departman,@ad,@soyad,@telefon,@mail,@parola)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@departman", txtDpt.Text); //bu satırdan önce kullaniciID vardı
            cmd.Parameters.AddWithValue("@ad", txtad1.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad1.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@parola", txtParola1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM kullanici WHERE ad=@ad";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ad", txtad1.Text);//değişiklik yaptım burada kullaniciID vardı
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kullanici " +
    "SET departman=@departman,ad=@ad,soyad=@soyad,telefon=@telefon,mail=@mail,parola=@parola" + //set sonra kullaniciID
    " WHERE kullaniciID=@kullaniciID";
            cmd = new MySqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("@departman", txtDpt.Text); //bundan önce kullaniciID vardı
            cmd.Parameters.AddWithValue("@ad", txtad1.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad1.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text); 
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@parola", txtParola1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void cmbArama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtArama1_TextChanged(object sender, EventArgs e)
        {
            if (cmbArama.SelectedIndex == 0)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "ad LIKE '" + txtArama1.Text + "%'";
                dataGridView1.DataSource = dv;
                conn.Close();
            }
            else if(cmbArama.SelectedIndex == 1)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "soyad LIKE '" + txtArama1.Text + "%'";
                dataGridView1.DataSource = dv;
                conn.Close();
            }
            else if(cmbArama.SelectedIndex == 2)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "departman LIKE '" + txtArama1.Text + "%'";
                dataGridView1.DataSource = dv;
                conn.Close();
            }
            else if(cmbArama.SelectedIndex == 3)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "telefon LIKE '" + txtArama1.Text + "%'";
                dataGridView1.DataSource = dv;
                conn.Close();
            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            } 
        }
    }
}
