using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DataBaseLearning
{
    public partial class Form2 : Form
    {
        private SQLiteConnection DB;
        private Form1 refForm;

        public Form2(Form1 refForm)
        {
            InitializeComponent();
            this.refForm = refForm;
        }

        public Form2()
        {
            InitializeComponent();
        }

        string GetWordsCount()
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select count(*) from Translator";
            return "Переводов: " + CMD.ExecuteScalar().ToString();
        }

        public void Apply_Click(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = MyDataBase.db; Version = 3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Translator";
            CMD.ExecuteNonQuery();
            refForm.RefreshList();
            refForm.TBRussian.Text = "";
            refForm.TBEnglish.Text = "";
            this.Close();
        }

        private void NotApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
