using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DinnerApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            Meattype.DropDownStyle = ComboBoxStyle.DropDown;
            List<String> prepTimes = new List<string> { "Short", "Medium", "Long", "Very Long", };
            List<String> meatTypes = new List<string>();

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

        private void Addrecipe_Click(object sender, EventArgs e)
        {

            SQLiteConnection sqliteConn;
            sqliteConn = CreateConnection();

            if ((Meattype.SelectedIndex == -1 && Meattype.Text == String.Empty) || Recipename.Text == string.Empty || Preptime.SelectedIndex == -1)
            {
                MessageBox.Show("Select values in all boxes before clicking the button");
                sqliteConn.Close();
                return;
            }

            var sqlCmd = sqliteConn.CreateCommand();
            sqlCmd.CommandText = "INSERT INTO recipies(recipeName, prepTime, meatType) " +
                "VALUES(@name, @prepTime, @meatType)";
            sqlCmd.Parameters.AddWithValue("@name", Recipename.Text);
            sqlCmd.Parameters.AddWithValue("@prepTime", Preptime.SelectedIndex);
            sqlCmd.Parameters.AddWithValue("@meatType", Meattype.Text);

            sqlCmd.ExecuteNonQuery();
            sqliteConn.Close();
            this.Close();
        }
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
                Console.WriteLine("Connection wasnt establised, Error: " + ex);
            }
            return sqliteConn;
        }
    }
}
