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
using System.Threading;

namespace DataBaseLearning
{
    public partial class Form1 : Form
    {
        private SQLiteConnection DB;

        public Form1()
        {
            InitializeComponent();
        }

        string GetWordsCount()
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select count(*) from Translator";
            return "Переводов: " + CMD.ExecuteScalar().ToString(); 
        }

        public void RefreshList()
        {
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Translator order by Russian";
            TBResults.Clear();
            SQLiteDataReader SQReader = CMD.ExecuteReader();
            if (SQReader.HasRows)
            {
                while (SQReader.Read())
                {
                    TBResults.Text += SQReader["Russian"] + " - " + SQReader["English"] + "\r\n";
                }
            }
            else TBResults.Text = "Нет результатов";
            LResCount.Text = GetWordsCount();
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = MyDataBase.db; Version = 3");
            RefreshList();
            DB.Open();
            LResCount.Text = GetWordsCount();
            DB.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DB.Close();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if(TBRussian.Text != "" && TBEnglish.Text != "")
            {
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert  into Translator(Russian, English) values ( @Russian , @English )";
                CMD.Parameters.Add("@Russian", DbType.String).Value = TBRussian.Text.ToUpper();
                CMD.Parameters.Add("@English", DbType.String).Value = TBEnglish.Text.ToUpper();
                CMD.ExecuteNonQuery();
                TBRussian.Text = "";
                TBEnglish.Text = "";
                DB.Close();
            }
            RefreshList();
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            if(TBRussian.Text != "" || TBEnglish.Text != "")
            {
                DB.Open();
                TBResults.Clear();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Translator where Russian like '%' || @Russian || '%' and English like '%' || @English || '%'";
                CMD.Parameters.Add("@Russian", DbType.String).Value = TBRussian.Text.ToUpper();
                CMD.Parameters.Add("@English", DbType.String).Value = TBEnglish.Text.ToUpper();
                SQLiteDataReader SQReader = CMD.ExecuteReader();
                if (SQReader.HasRows)
                {
                    while (SQReader.Read())
                    {
                        TBResults.Text += SQReader["Russian"] + " - " + SQReader["English"] + "\r\n";
                    }
                }
                else TBResults.Text = "Нет результатов";
                LResCount.Text = GetWordsCount();
                DB.Close();
            }
        }

        private void BClearDB_Click(object sender, EventArgs e)
        {
            DB.Close();
            Form2 F2 = new Form2(this);
            F2.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            LResCount.Text = GetWordsCount();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if(TBRussian.Text != "" && TBEnglish.Text != "")
            {
                DB.Open();
                TBResults.Clear();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "delete from Translator where Russian = @Russian and English = @English";
                CMD.Parameters.Add("@Russian", DbType.String).Value = TBRussian.Text.ToUpper();
                CMD.Parameters.Add("@English", DbType.String).Value = TBEnglish.Text.ToUpper();
                CMD.ExecuteNonQuery();
                TBRussian.Text = "";
                TBEnglish.Text = "";
                DB.Close();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Что бы удалить слово нужно ввести его " + 
                    "вариант на двух языках для точного удаления!");
            }
        }

        private void TBResults_TextChanged(object sender, EventArgs e)
        {
            TBResults.ScrollBars = ScrollBars.Vertical;
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
