namespace FinancialCrm
{
    partial class FrmSpendings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFrmSettings = new System.Windows.Forms.Button();
            this.btnFrmDashboard = new System.Windows.Forms.Button();
            this.btnBankProcess = new System.Windows.Forms.Button();
            this.btnFrmSpendings = new System.Windows.Forms.Button();
            this.btnFrmBilling = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnFrmCategories = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAverageSpending = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalSpending = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHighestSpending = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chartCategoryAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryAnalysis)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 32);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giderler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFrmSettings);
            this.panel1.Controls.Add(this.btnFrmDashboard);
            this.panel1.Controls.Add(this.btnBankProcess);
            this.panel1.Controls.Add(this.btnFrmSpendings);
            this.panel1.Controls.Add(this.btnFrmBilling);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnFrmCategories);
            this.panel1.Location = new System.Drawing.Point(-1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 435);
            this.panel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(16, 323);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 37);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFrmSettings
            // 
            this.btnFrmSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmSettings.ForeColor = System.Drawing.Color.White;
            this.btnFrmSettings.Location = new System.Drawing.Point(16, 280);
            this.btnFrmSettings.Name = "btnFrmSettings";
            this.btnFrmSettings.Size = new System.Drawing.Size(137, 37);
            this.btnFrmSettings.TabIndex = 2;
            this.btnFrmSettings.Text = "Ayarlar";
            this.btnFrmSettings.UseVisualStyleBackColor = false;
            this.btnFrmSettings.Click += new System.EventHandler(this.btnFrmSettings_Click);
            // 
            // btnFrmDashboard
            // 
            this.btnFrmDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmDashboard.ForeColor = System.Drawing.Color.White;
            this.btnFrmDashboard.Location = new System.Drawing.Point(16, 237);
            this.btnFrmDashboard.Name = "btnFrmDashboard";
            this.btnFrmDashboard.Size = new System.Drawing.Size(137, 37);
            this.btnFrmDashboard.TabIndex = 1;
            this.btnFrmDashboard.Text = "Dashboard";
            this.btnFrmDashboard.UseVisualStyleBackColor = false;
            this.btnFrmDashboard.Click += new System.EventHandler(this.btnFrmDashboard_Click);
            // 
            // btnBankProcess
            // 
            this.btnBankProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcess.ForeColor = System.Drawing.Color.White;
            this.btnBankProcess.Location = new System.Drawing.Point(16, 194);
            this.btnBankProcess.Name = "btnBankProcess";
            this.btnBankProcess.Size = new System.Drawing.Size(137, 37);
            this.btnBankProcess.TabIndex = 1;
            this.btnBankProcess.Text = "Banka Hareketleri";
            this.btnBankProcess.UseVisualStyleBackColor = false;
            this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
            // 
            // btnFrmSpendings
            // 
            this.btnFrmSpendings.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmSpendings.ForeColor = System.Drawing.Color.White;
            this.btnFrmSpendings.Location = new System.Drawing.Point(3, 151);
            this.btnFrmSpendings.Name = "btnFrmSpendings";
            this.btnFrmSpendings.Size = new System.Drawing.Size(150, 37);
            this.btnFrmSpendings.TabIndex = 1;
            this.btnFrmSpendings.Text = "Giderler";
            this.btnFrmSpendings.UseVisualStyleBackColor = false;
            this.btnFrmSpendings.Click += new System.EventHandler(this.btnFrmSpendings_Click);
            // 
            // btnFrmBilling
            // 
            this.btnFrmBilling.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmBilling.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmBilling.ForeColor = System.Drawing.Color.White;
            this.btnFrmBilling.Location = new System.Drawing.Point(16, 108);
            this.btnFrmBilling.Name = "btnFrmBilling";
            this.btnFrmBilling.Size = new System.Drawing.Size(137, 37);
            this.btnFrmBilling.TabIndex = 1;
            this.btnFrmBilling.Text = "Faturalar";
            this.btnFrmBilling.UseVisualStyleBackColor = false;
            this.btnFrmBilling.Click += new System.EventHandler(this.btnFrmBilling_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(16, 65);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(137, 37);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnFrmCategories
            // 
            this.btnFrmCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmCategories.ForeColor = System.Drawing.Color.White;
            this.btnFrmCategories.Location = new System.Drawing.Point(16, 22);
            this.btnFrmCategories.Name = "btnFrmCategories";
            this.btnFrmCategories.Size = new System.Drawing.Size(137, 37);
            this.btnFrmCategories.TabIndex = 0;
            this.btnFrmCategories.Text = "Kategoriler";
            this.btnFrmCategories.UseVisualStyleBackColor = false;
            this.btnFrmCategories.Click += new System.EventHandler(this.btnFrmCategories_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblAverageSpending);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(586, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 126);
            this.panel7.TabIndex = 13;
            // 
            // lblAverageSpending
            // 
            this.lblAverageSpending.AutoSize = true;
            this.lblAverageSpending.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageSpending.ForeColor = System.Drawing.Color.Transparent;
            this.lblAverageSpending.Location = new System.Drawing.Point(21, 51);
            this.lblAverageSpending.Name = "lblAverageSpending";
            this.lblAverageSpending.Size = new System.Drawing.Size(114, 45);
            this.lblAverageSpending.TabIndex = 6;
            this.lblAverageSpending.Text = "0.00 ₺";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(13, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ortalama Gider";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTotalSpending);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(184, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 126);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(198, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 126);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 59);
            this.label4.TabIndex = 6;
            this.label4.Text = "0.00 ₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ziraat Bankası";
            // 
            // lblTotalSpending
            // 
            this.lblTotalSpending.AutoSize = true;
            this.lblTotalSpending.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalSpending.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalSpending.Location = new System.Drawing.Point(18, 51);
            this.lblTotalSpending.Name = "lblTotalSpending";
            this.lblTotalSpending.Size = new System.Drawing.Size(171, 45);
            this.lblTotalSpending.TabIndex = 6;
            this.lblTotalSpending.Text = "0000.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Harcama";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblHighestSpending);
            this.panel5.Controls.Add(this.lblBillTitle);
            this.panel5.Location = new System.Drawing.Point(385, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 126);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(198, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 126);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(22, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 59);
            this.label6.TabIndex = 6;
            this.label6.Text = "0.00 ₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ziraat Bankası";
            // 
            // lblHighestSpending
            // 
            this.lblHighestSpending.AutoSize = true;
            this.lblHighestSpending.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighestSpending.ForeColor = System.Drawing.Color.Transparent;
            this.lblHighestSpending.Location = new System.Drawing.Point(21, 51);
            this.lblHighestSpending.Name = "lblHighestSpending";
            this.lblHighestSpending.Size = new System.Drawing.Size(114, 45);
            this.lblHighestSpending.TabIndex = 6;
            this.lblHighestSpending.Text = "0.00 ₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillTitle.Location = new System.Drawing.Point(11, 16);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(150, 26);
            this.lblBillTitle.TabIndex = 5;
            this.lblBillTitle.Text = "En Yüksek Gider";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel8.Location = new System.Drawing.Point(184, 187);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(594, 2);
            this.panel8.TabIndex = 14;
            // 
            // chartCategoryAnalysis
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCategoryAnalysis.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCategoryAnalysis.Legends.Add(legend3);
            this.chartCategoryAnalysis.Location = new System.Drawing.Point(186, 246);
            this.chartCategoryAnalysis.Name = "chartCategoryAnalysis";
            this.chartCategoryAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.chartCategoryAnalysis.Series.Add(series3);
            this.chartCategoryAnalysis.Size = new System.Drawing.Size(236, 159);
            this.chartCategoryAnalysis.TabIndex = 15;
            this.chartCategoryAnalysis.Text = "chart1";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(441, 195);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 210);
            this.panel9.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel10.Location = new System.Drawing.Point(272, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(19, 228);
            this.panel10.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kategori Bazlı Analiz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(461, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Son İşlemler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(449, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(324, 159);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.TabStop = false;
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.chartCategoryAnalysis);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryAnalysis)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFrmSettings;
        private System.Windows.Forms.Button btnFrmDashboard;
        private System.Windows.Forms.Button btnBankProcess;
        private System.Windows.Forms.Button btnFrmSpendings;
        private System.Windows.Forms.Button btnFrmBilling;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnFrmCategories;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAverageSpending;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalSpending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHighestSpending;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryAnalysis;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}