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
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM evrak", conn);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void txtad1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEvrakID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); //visible false
                txtKullaniciID.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                cmbEvrakTuru.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtRaf.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtEvrakSahibi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                dateTimeKayıt.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                
            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO evrak(kullaniciID,evrakTuru,rafKonumu,evrakSahibi,evrakKayitTarihi)" + 
    "VALUES (@kullaniciID,@evrakTuru,@rafKonumu,@evrakSahibi,@evrakKayitTarihi)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kullaniciID", Convert.ToString(txtKullaniciID.Text));
            cmd.Parameters.AddWithValue("@evrakTuru", cmbEvrakTuru.Text);
            cmd.Parameters.AddWithValue("@rafKonumu", txtRaf.Text);
            cmd.Parameters.AddWithValue("@evrakSahibi", txtEvrakSahibi.Text);
            cmd.Parameters.AddWithValue("@evrakKayitTarihi", dateTimeKayıt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM evrak WHERE evrakID=@evrakID";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakID", txtEvrakID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE evrak " +
    "SET kullaniciID=@kullaniciID,evrakTuru=@evrakTuru,rafKonumu=@rafKonumu,evrakSahibi=@evrakSahibi,evrakKayitTarihi=@evrakKayitTarihi" + 
    " WHERE kullaniciID=@kullaniciID";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kullaniciID", Convert.ToString(txtKullaniciID.Text));
            cmd.Parameters.AddWithValue("@evrakTuru", cmbEvrakTuru.Text);
            cmd.Parameters.AddWithValue("@rafKonumu", txtRaf.Text);
            cmd.Parameters.AddWithValue("@evrakSahibi", txtEvrakSahibi.Text);
            cmd.Parameters.AddWithValue("@evrakKayitTarihi", dateTimeKayıt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtArama2_TextChanged(object sender, EventArgs e)
        {
            if (cmbArama2.SelectedIndex == 0)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "evrakID LIKE '" + txtArama2.Text + "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama2.SelectedIndex == 1)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "kullaniciID LIKE '" + txtArama2.Text+ "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama2.SelectedIndex == 2)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "evrakTuru LIKE '" + txtArama2.Text + "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama2.SelectedIndex == 3)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "rafKonumu LIKE '" + txtArama2.Text + "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama2.SelectedIndex == 4)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "evrakSahibi LIKE '" + txtArama2.Text + "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama2.SelectedIndex == 5)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "evrakKayitTarihi LIKE '" + txtArama2.Text + "%'";
                dataGridView2.DataSource = dv;
                conn.Close();
            }
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
