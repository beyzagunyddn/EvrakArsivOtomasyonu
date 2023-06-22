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
    public partial class Form4 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;


        public Form4()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM emanet", conn);
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEvrakID2.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciID2.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                dtEmanet.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                dtTeslim.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                txtEmanetiAlan.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
                txtTeslimDurumu.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO emanet(evrakID,kullaniciID,emanetTarihi,teslimTarihi,emanetAlan,teslimDurumu)" +
           "VALUES (@evrakID,@kullaniciID,@emanetTarihi,@teslimTarihi,@emanetAlan,@teslimDurumu)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakID", Convert.ToString(txtEvrakID2.Text));
            cmd.Parameters.AddWithValue("@kullaniciID", Convert.ToString(txtKullaniciID2.Text));
            cmd.Parameters.AddWithValue("@emanetTarihi", dtEmanet.Text);
            cmd.Parameters.AddWithValue("@teslimTarihi", dtTeslim.Text);
            cmd.Parameters.AddWithValue("@emanetAlan", txtEmanetiAlan.Text);
            cmd.Parameters.AddWithValue("@teslimDurumu", txtTeslimDurumu.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM emanet WHERE evrakID=@evrakID";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakID", txtEvrakID2.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE emanet " +
           "SET evrakID=@evrakID,kullaniciID=@kullaniciID,emanetTarihi=@emanetTarihi,teslimTarihi=@teslimTarihi,emanetAlan=@emanetAlan,teslimDurumu=@teslimDurumu" +
           " WHERE kullaniciID=@kullaniciID";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakID", Convert.ToString(txtEvrakID2.Text));
            cmd.Parameters.AddWithValue("@kullaniciID", Convert.ToString(txtKullaniciID2.Text));
            cmd.Parameters.AddWithValue("@emanetTarihi", dtEmanet.Text);
            cmd.Parameters.AddWithValue("@teslimTarihi", dtTeslim.Text);
            cmd.Parameters.AddWithValue("@emanetAlan", txtEmanetiAlan.Text);
            cmd.Parameters.AddWithValue("@teslimDurumu", txtTeslimDurumu.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
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

        private void txtArama2_TextChanged(object sender, EventArgs e)
        {
            if (cmbArama3.SelectedIndex == 0)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "evrakID LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama3.SelectedIndex == 1)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "kullaniciID LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama3.SelectedIndex == 2)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "emanetTarihi LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama3.SelectedIndex == 3)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "teslimTarihi LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama3.SelectedIndex == 4)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "emanetAlan LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
            else if (cmbArama3.SelectedIndex == 5)
            {
                conn.Open();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "teslimDurumu LIKE '" + txtArama3.Text + "%'";
                dataGridView3.DataSource = dv;
                conn.Close();
            }
        }
    }
}
