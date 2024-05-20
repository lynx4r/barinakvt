using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace barınakvt
{
    public partial class ListeleForm : Form
    {
        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd='';";
        string yeniAd;
        public ListeleForm()
        {
            InitializeComponent();
        }

        private void dgwHayvanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwHayvanlar.SelectedCells.Count > 0)
            {
                txtİsim.Text = dgwHayvanlar.SelectedRows[0].Cells["adi"].Value.ToString();
                txtYas.Text = dgwHayvanlar.SelectedRows[0].Cells["yas"].Value.ToString();
                cmbCins.SelectedValue = dgwHayvanlar.SelectedRows[0].Cells["cins"].Value.ToString();
                cbEngelDurumu.Checked = Convert.ToBoolean(dgwHayvanlar.SelectedRows[0].Cells["engel_durumu"].Value);

                string dosyaYolu = Path.Combine(Environment.CurrentDirectory, "fotograf", dgwHayvanlar.SelectedRows[0].Cells["fotograf_adi"].Value.ToString());

                pbFotograf.Image = null;
                if (File.Exists(dosyaYolu))
                {
                    pbFotograf.Image = Image.FromFile(dosyaYolu);
                    pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM hayvanlar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwHayvanlar.DataSource = dt;

            }
        }

        private void ListeleForm_Load(object sender, EventArgs e)
        {

            DgwDoldur();
            CmbDoldur();
        }

       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {

                baglan.Open();
                string sorgu = "UPDATE hayvanlar SET adi=@isim, yas = @yas,  cins=@cins, engel_durumu = @engel_durumu  , fotograf_adi = @fotograf WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@isim", txtİsim.Text);
                cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                cmd.Parameters.AddWithValue("@cins", cmbCins.SelectedValue);
                cmd.Parameters.AddWithValue("@engel_durumu", cbEngelDurumu.Checked);
                cmd.Parameters.AddWithValue("@fotograf_adi", yeniAd);

                int id = Convert.ToInt32(dgwHayvanlar.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fotograf", yeniAd);

                cmd.ExecuteNonQuery();
                DgwDoldur();

            }
        }

        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT cins FROM Hayvanlar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbCins.DataSource = dt;

                cmbCins.DisplayMember = "cins";
                cmbCins.ValueMember = "cins";

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwHayvanlar.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Kayıtı silmek istediğinizden emin misiniz?",
                                                 "Kayıtı sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int hid = Convert.ToInt32(dgwHayvanlar.SelectedRows[0].Cells["id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM hayvanlar WHERE id=@id;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@id", hid);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
        }
    }

      
}


