namespace FinancialCrm
{
    partial class FrmCategories
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryTitle = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 32);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
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
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 435);
            this.panel1.TabIndex = 3;
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
            this.btnFrmCategories.Location = new System.Drawing.Point(3, 22);
            this.btnFrmCategories.Name = "btnFrmCategories";
            this.btnFrmCategories.Size = new System.Drawing.Size(150, 37);
            this.btnFrmCategories.TabIndex = 0;
            this.btnFrmCategories.Text = "Kategoriler";
            this.btnFrmCategories.UseVisualStyleBackColor = false;
            this.btnFrmCategories.Click += new System.EventHandler(this.btnFrmCategories_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.btnRemoveCategory);
            this.panel3.Controls.Add(this.btnCreateCategory);
            this.panel3.Controls.Add(this.btnCategoryList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCategoryTitle);
            this.panel3.Controls.Add(this.txtCategoryId);
            this.panel3.Location = new System.Drawing.Point(181, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 166);
            this.panel3.TabIndex = 5;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(193)))));
            this.btnUpdateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateCategory.Location = new System.Drawing.Point(444, 94);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(138, 52);
            this.btnUpdateCategory.TabIndex = 7;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(193)))));
            this.btnRemoveCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveCategory.Location = new System.Drawing.Point(300, 94);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(138, 52);
            this.btnRemoveCategory.TabIndex = 6;
            this.btnRemoveCategory.Text = "Kategori Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(193)))));
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreateCategory.Location = new System.Drawing.Point(156, 94);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(138, 52);
            this.btnCreateCategory.TabIndex = 5;
            this.btnCreateCategory.Text = "Yeni Kategori";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(193)))));
            this.btnCategoryList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategoryList.Location = new System.Drawing.Point(12, 94);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(138, 52);
            this.btnCategoryList.TabIndex = 4;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Id:";
            // 
            // txtCategoryTitle
            // 
            this.txtCategoryTitle.Location = new System.Drawing.Point(122, 46);
            this.txtCategoryTitle.Name = "txtCategoryTitle";
            this.txtCategoryTitle.Size = new System.Drawing.Size(207, 20);
            this.txtCategoryTitle.TabIndex = 1;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(122, 20);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(207, 20);
            this.txtCategoryId.TabIndex = 0;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryTitle;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnCategoryList;
    }
}