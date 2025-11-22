namespace FinancialCrm
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillTitle.Location = new System.Drawing.Point(11, 16);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(100, 19);
            this.lblBillTitle.TabIndex = 5;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(21, 51);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(114, 45);
            this.lblLastBankProcessAmount.TabIndex = 6;
            this.lblLastBankProcessAmount.Text = "0.00 ₺";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(13, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Gelen Son Havale";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillAmount.Location = new System.Drawing.Point(21, 51);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(114, 45);
            this.lblBillAmount.TabIndex = 6;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel7.Controls.Add(this.lblLastBankProcessAmount);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(582, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 126);
            this.panel7.TabIndex = 10;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 32);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış Formu";
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
            this.panel1.Location = new System.Drawing.Point(-1, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 400);
            this.panel1.TabIndex = 6;
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
            this.btnFrmDashboard.Location = new System.Drawing.Point(3, 237);
            this.btnFrmDashboard.Name = "btnFrmDashboard";
            this.btnFrmDashboard.Size = new System.Drawing.Size(150, 37);
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
            this.btnFrmSpendings.Location = new System.Drawing.Point(16, 151);
            this.btnFrmSpendings.Name = "btnFrmSpendings";
            this.btnFrmSpendings.Size = new System.Drawing.Size(137, 37);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(180, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 126);
            this.panel3.TabIndex = 8;
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
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalBalance.Location = new System.Drawing.Point(18, 51);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(171, 45);
            this.lblTotalBalance.TabIndex = 6;
            this.lblTotalBalance.Text = "0000.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Bakiye";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblBillAmount);
            this.panel5.Controls.Add(this.lblBillTitle);
            this.panel5.Location = new System.Drawing.Point(381, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 126);
            this.panel5.TabIndex = 9;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(180, 247);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(284, 171);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(487, 247);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Faturalar";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(284, 171);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(183, 181);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 54);
            this.panel9.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bankalar ve banka hesaplarındaki para\r\nmiktarlarına aşağıdaki grafikten ulaşabili" +
    "rsiniz.";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(487, 181);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 54);
            this.panel10.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına\r\naşağıdaki grafikten ulaşabilirsini" +
    "z.";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
    }
}