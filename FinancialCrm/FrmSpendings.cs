using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;


namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

            // ---------------------------------------------------------
            // 1. VERİ ÇEKME VE GRUPLAMA İŞLEMİ
            // ---------------------------------------------------------
            // Spendings ve Categories tablolarını birleştirip (Join),
            // Kategori ismine göre gruplayıp, harcamaları topluyoruz.
            var categoryTotalList = (from spending in db.Spendings
                                     join category in db.Categories
                                     on spending.CategoryId equals category.CategoryId
                                     group spending by category.CategoryName into g
                                     select new
                                     {
                                         KategoriAdi = g.Key,
                                         ToplamTutar = g.Sum(x => x.SpendingAmount)
                                     }).ToList();

            // ---------------------------------------------------------
            // 2. GRAFİK AYARLARI (chartCategoryAnalysis)
            // ---------------------------------------------------------

            // Önce eski verileri temizleyelim ki üst üste binmesin.
            chartCategoryAnalysis.Series.Clear();
            chartCategoryAnalysis.Legends.Clear();
            chartCategoryAnalysis.Legends.Add("Legend1"); // Açıklama kutusunu yeniden ekle

            // Yeni bir seri oluşturalım
            var series = chartCategoryAnalysis.Series.Add("Kategoriler");

            // Grafik türünü PASTA (Pie) yapalım
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // (İsteğe Bağlı) Pasta grafiği biraz daha estetik görünsün diye paleti değiştirebiliriz
            chartCategoryAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;

            // ---------------------------------------------------------
            // 3. VERİLERİ GRAFİĞE YAZDIRMA
            // ---------------------------------------------------------
            foreach (var item in categoryTotalList)
            {
                // Değeri grafiğe ekle
                int pointIndex = series.Points.AddXY(item.KategoriAdi, item.ToplamTutar);

                // Dilimlerin üzerinde ne yazacağını ayarlayalım
                // Örnek Görünüm: 
                // Yeme-İçme
                // 460 ₺
                series.Points[pointIndex].Label = $"{item.KategoriAdi}\n{item.ToplamTutar} ₺";
            }

            var totalSpending = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalSpending.Text = totalSpending.ToString() + " ₺";

            var maxSpending = db.Spendings.Max(x => x.SpendingAmount);
            lblHighestSpending.Text = maxSpending.ToString() + " ₺";

            var averageSpending = db.Spendings.Average(x => x.SpendingAmount);
            lblAverageSpending.Text = string.Format("{0:0.00} ₺", averageSpending);
        }



        //-----------------------------------------------

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
        




