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
    public partial class FrmLogin : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FrmBanks mainForm = new FrmBanks();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = ""; 
                txtPassword.Focus(); 
            }
        }
                
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
            this.AcceptButton=btnLogin;
        }
    }    
}
