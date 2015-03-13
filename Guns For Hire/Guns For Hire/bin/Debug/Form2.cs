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

namespace Guns_For_Hire
{

    public partial class Form2 : Form
    {

        private static SQLiteConnection dbcon = new SQLiteConnection("Data Source = current.db;Version=3");
        private static String sql = "";
        private static SQLiteCommand command = new SQLiteCommand(sql, dbcon);



        public Form2()
        {
            InitializeComponent();
        }

        private void List_Hire_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from AssassinsProfile";
            SQLiteCommand command = new SQLiteCommand(sql, dbcon);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            int tempId = reader.GetInt32(1);


            while (reader.Read())
            {
                List_Current_Assassins.Items.Add(tempId);
            }
        }

        private void List_Current_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Retired_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Hire_Assassin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Retire_Assassin_Click(object sender, EventArgs e)
        {
            sql = "insert into RetiredAssassins (assassin) values (" + List_Current_Assassins.SelectedIndex + ")";
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        private void btn_Rehire_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dbcon.Open();
        }
    }
}
