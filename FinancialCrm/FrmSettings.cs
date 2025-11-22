using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            // Kullanıcı adı çekme işlemi isteğiniz üzerine kaldırıldı.

            // Sadece şifre kutucuklarının karakterlerini gizliyoruz (*)
            txtOldPassword.PasswordChar = '*';     // Mevcut Şifre
            txtNewPassword.PasswordChar = '*';     // Yeni Şifre
            txtConfirmPassword.PasswordChar = '*'; // Yeni Şifre (Tekrar)
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Alanlar boş mu kontrolü
            if (string.IsNullOrEmpty(txtOldPassword.Text) ||
                string.IsNullOrEmpty(txtNewPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Lütfen tüm şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanındaki kullanıcıyı çek
            var user = db.Users.FirstOrDefault();

            // Verileri değişkenlere al
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // 2. Mevcut şifre kontrolü
            // Not: Gerçek hayatta kullanıcı yoksa hata vermemesi için null kontrolü eklenebilir, 
            // ancak mevcut yapınızı bozmamak için doğrudan şifre kontrolü yapıyorum.
            if (user.Password != oldPassword)
            {
                MessageBox.Show("Mevcut şifrenizi yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Yeni şifrelerin eşleşme kontrolü
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Yeni şifreler birbiriyle uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Güncelleme ve Kaydetme
            user.Password = newPassword;
            db.SaveChanges();

            MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // İşlem bitince kutuları temizle
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }


        private void btnFrmCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnFrmSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnFrmDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnFrmSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}