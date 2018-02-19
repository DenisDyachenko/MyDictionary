namespace DataBaseLearning
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBRussian = new System.Windows.Forms.TextBox();
            this.TBEnglish = new System.Windows.Forms.TextBox();
            this.LPhoneNumber = new System.Windows.Forms.Label();
            this.LFullName = new System.Windows.Forms.Label();
            this.BAdd = new System.Windows.Forms.Button();
            this.BFind = new System.Windows.Forms.Button();
            this.TBResults = new System.Windows.Forms.TextBox();
            this.LResCount = new System.Windows.Forms.Label();
            this.BClearDB = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBRussian
            // 
            this.TBRussian.Location = new System.Drawing.Point(12, 37);
            this.TBRussian.Name = "TBRussian";
            this.TBRussian.Size = new System.Drawing.Size(168, 20);
            this.TBRussian.TabIndex = 0;
            // 
            // TBEnglish
            // 
            this.TBEnglish.Location = new System.Drawing.Point(12, 85);
            this.TBEnglish.Name = "TBEnglish";
            this.TBEnglish.Size = new System.Drawing.Size(168, 20);
            this.TBEnglish.TabIndex = 1;
            // 
            // LPhoneNumber
            // 
            this.LPhoneNumber.AutoSize = true;
            this.LPhoneNumber.Location = new System.Drawing.Point(12, 69);
            this.LPhoneNumber.Name = "LPhoneNumber";
            this.LPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.LPhoneNumber.TabIndex = 2;
            this.LPhoneNumber.Text = "Английский:";
            // 
            // LFullName
            // 
            this.LFullName.AutoSize = true;
            this.LFullName.Location = new System.Drawing.Point(12, 21);
            this.LFullName.Name = "LFullName";
            this.LFullName.Size = new System.Drawing.Size(52, 13);
            this.LFullName.TabIndex = 3;
            this.LFullName.Text = "Русский:";
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(99, 128);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(81, 32);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BFind
            // 
            this.BFind.Location = new System.Drawing.Point(12, 128);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(81, 32);
            this.BFind.TabIndex = 3;
            this.BFind.Text = "Найти";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // TBResults
            // 
            this.TBResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBResults.Location = new System.Drawing.Point(199, 12);
            this.TBResults.Multiline = true;
            this.TBResults.Name = "TBResults";
            this.TBResults.ReadOnly = true;
            this.TBResults.Size = new System.Drawing.Size(211, 219);
            this.TBResults.TabIndex = 8;
            this.TBResults.TextChanged += new System.EventHandler(this.TBResults_TextChanged);
            // 
            // LResCount
            // 
            this.LResCount.AutoSize = true;
            this.LResCount.Location = new System.Drawing.Point(99, 214);
            this.LResCount.Name = "LResCount";
            this.LResCount.Size = new System.Drawing.Size(0, 13);
            this.LResCount.TabIndex = 7;
            // 
            // BClearDB
            // 
            this.BClearDB.Location = new System.Drawing.Point(12, 166);
            this.BClearDB.Name = "BClearDB";
            this.BClearDB.Size = new System.Drawing.Size(81, 32);
            this.BClearDB.TabIndex = 5;
            this.BClearDB.Text = "Очистить БД";
            this.BClearDB.UseVisualStyleBackColor = true;
            this.BClearDB.Click += new System.EventHandler(this.BClearDB_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(99, 166);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(81, 32);
            this.BDelete.TabIndex = 6;
            this.BDelete.Text = "Удалить";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BRefresh.Location = new System.Drawing.Point(12, 204);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(81, 32);
            this.BRefresh.TabIndex = 7;
            this.BRefresh.Text = "Обновить";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 243);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BClearDB);
            this.Controls.Add(this.LResCount);
            this.Controls.Add(this.TBResults);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LFullName);
            this.Controls.Add(this.LPhoneNumber);
            this.Controls.Add(this.TBEnglish);
            this.Controls.Add(this.TBRussian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Словарь";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LPhoneNumber;
        private System.Windows.Forms.Label LFullName;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Label LResCount;
        private System.Windows.Forms.Button BClearDB;
        private System.Windows.Forms.Button BDelete;
        public System.Windows.Forms.TextBox TBResults;
        public System.Windows.Forms.TextBox TBRussian;
        public System.Windows.Forms.TextBox TBEnglish;
        private System.Windows.Forms.Button BRefresh;
    }
}

