namespace DataBaseLearning
{
    partial class Form2
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
            this.LWarning = new System.Windows.Forms.Label();
            this.LWarning2 = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.NotApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LWarning
            // 
            this.LWarning.AutoSize = true;
            this.LWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LWarning.Location = new System.Drawing.Point(97, 24);
            this.LWarning.Name = "LWarning";
            this.LWarning.Size = new System.Drawing.Size(88, 20);
            this.LWarning.TabIndex = 0;
            this.LWarning.Text = "Вы точно";
            // 
            // LWarning2
            // 
            this.LWarning2.AutoSize = true;
            this.LWarning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LWarning2.Location = new System.Drawing.Point(6, 55);
            this.LWarning2.Name = "LWarning2";
            this.LWarning2.Size = new System.Drawing.Size(270, 20);
            this.LWarning2.TabIndex = 1;
            this.LWarning2.Text = "хотите очистить базу данных?\r\n";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(22, 90);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(107, 23);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Да";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // NotApply
            // 
            this.NotApply.Location = new System.Drawing.Point(152, 90);
            this.NotApply.Name = "NotApply";
            this.NotApply.Size = new System.Drawing.Size(107, 23);
            this.NotApply.TabIndex = 3;
            this.NotApply.Text = "Нет";
            this.NotApply.UseVisualStyleBackColor = true;
            this.NotApply.Click += new System.EventHandler(this.NotApply_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 125);
            this.Controls.Add(this.NotApply);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.LWarning2);
            this.Controls.Add(this.LWarning);
            this.Name = "Form2";
            this.Text = "Предупреждение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LWarning;
        private System.Windows.Forms.Label LWarning2;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button NotApply;
    }
}