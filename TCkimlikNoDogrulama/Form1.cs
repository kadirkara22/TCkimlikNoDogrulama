using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCkimlikNoDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            TCKimlikNoDogrulama.KPSPublic kps = new TCKimlikNoDogrulama.KPSPublic();
           bool kontrol= kps.TCKimlikNoDogrula(long.Parse(txtTC.Text), txtisim.Text.ToUpper(), txtsoyisim.Text.ToUpper(),int.Parse(txtDogumyili.Text));

            if (kontrol)
            {
                MessageBox.Show("Bilgileriniz doğrulandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz doğrulanamadı", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
