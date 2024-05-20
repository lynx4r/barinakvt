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

namespace barınakvt
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniForm ekleForm = new YeniForm();
            ekleForm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            ListeleForm filmlerForm = new ListeleForm();
            filmlerForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string klasorYolu = @"fotograf";
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
        }
    }
}
