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
    public partial class Form5 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup13-2023;Uid=Grup13-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        
        public Form5()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT COUNT * FROM istatistik", conn);
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            VeriGetir();

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView4.CurrentRow.Cells[0].Value.ToString();
                dataGridView4.CurrentRow.Cells[1].Value.ToString();
                dataGridView4.CurrentRow.Cells[2].Value.ToString();
                

            }
            catch
            {

            }
        }
    }
}
