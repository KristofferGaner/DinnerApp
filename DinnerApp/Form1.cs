using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DinnerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            List<String> prepTimes = new List<string> { "Short", "Medium", "Long", "Very Long" };
            List<String> meatTypes = new List<string> { "All" };

            SQLiteConnection sqliteConn;
            sqliteConn = CreateConnection();

            SQLiteDataReader sqliteDatareader;
            SQLiteCommand sqliteCmd;
            sqliteCmd = sqliteConn.CreateCommand();

            sqliteCmd.CommandText = "SELECT DISTINCT meatType FROM recipies";

            sqliteDatareader = sqliteCmd.ExecuteReader();
            while (sqliteDatareader.Read())
            {
                string myreader = sqliteDatareader.GetString(0);
                meatTypes.Add(myreader);
            }

            Meattype.DataSource = meatTypes;
            Preptime.DataSource = prepTimes;
            sqliteConn.Close();
        }

        //should really throw this into a separate file to avoid redundancy redundancy!
        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn;
            // Create a new database connection:
            sqliteConn = new SQLiteConnection("Data Source= recipiesDb.db" +
                "; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqliteConn.Open();
            } catch (Exception ex)
            {
                MessageBox.Show("Connection wasnt establised, Error: " + ex);
            }
            return sqliteConn;
        }

        private void Dinner_Click_1(object sender, EventArgs e)
        {
            RecipeListBox.Items.Clear();
            List<String> recipeList = new List<string>();
            var rand = new Random();

            SQLiteConnection sqliteConn;
            sqliteConn = CreateConnection();

            if (Meattype.SelectedIndex == -1 || Symbol.SelectedIndex == -1 || Preptime.SelectedIndex == -1)
            {
                MessageBox.Show("Select values in all boxes before clicking the button");
                sqliteConn.Close();
                return;
            }

            String meatType = Meattype.SelectedItem.ToString();
            String symbol = Symbol.SelectedItem.ToString();
            int prepTime = Preptime.SelectedIndex;

            SQLiteDataReader sqliteDatareader;
            SQLiteCommand sqliteCmd;
            sqliteCmd = sqliteConn.CreateCommand();
            if (meatType == "All")
            {
                sqliteCmd.CommandText = "SELECT recipeName FROM recipies WHERE prepTime" + symbol + prepTime;
            } else
            {
                sqliteCmd.CommandText = "SELECT recipeName FROM recipies WHERE meatType='" + meatType + "'"
                + " AND prepTime " + symbol + " " + prepTime;
            }

            sqliteDatareader = sqliteCmd.ExecuteReader();
            while (sqliteDatareader.Read())
            {
                string myreader = sqliteDatareader.GetString(0);
                recipeList.Add(myreader);
            }
            if (Allrecipies.Checked || recipeList.Count <= 3)
            {
                RecipeListBox.Items.AddRange(recipeList.ToArray());
            } else
            {
                for (int i = 0; i < 3; i++)
                {
                    int rnd = rand.Next(recipeList.Count);
                    RecipeListBox.Items.Add(recipeList[rnd]);
                    recipeList.RemoveAt(rnd);
                }
            }
            sqliteConn.Close();
        }

        private void Addrecipe_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
