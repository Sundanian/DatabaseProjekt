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
    public partial class Form3 : Form
    {

        private static SQLiteConnection dbcon = new SQLiteConnection("Data Source = current.db;Version=3");
        private static String sql = "";
        private static SQLiteCommand command = new SQLiteCommand(sql, dbcon);



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dbcon.Open();
            UpdateTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbcon.Close();
            Close();
        }

        private void Btn_Select_Mission_Click(object sender, EventArgs e)
        {

            SQLiteCommand command1 = new SQLiteCommand(sql, dbcon);
            command1.CommandText = "select from mission where Level='" + list_Mission.SelectedItems[0].SubItems[0].Text + "'";

            #region MissionLevelTing

            command = new SQLiteCommand(sql, dbcon);


            switch (command1.CommandText)
            {
                case "1":
                    sql = "Update AssassinsProfile  SET XP=XP+100 WHERE id='" + Available_Assassins.SelectedItems[0].SubItems[0].Text + "'";

                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    break;

                case "2":
                    sql = "Update AssassinsProfile SET XP=XP+200";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    break;
                case "3":
                    sql = "Update AssassinsProfile SET XP=XP+300 WHERE id=1";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    break;
                default:
                    break;
            }
            #endregion

        }

        private void list_Mission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_Mission_Ongoing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_Mission_Details_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nu Available_Assassins!!!

        }
        private void UpdateTables()
        {
            #region Clear
            list_Mission.Clear();
            Available_Assassins.Clear();
            list_Mission_Ongoing.Clear();
            list_Mission.Columns.Add("ID", 40);
            list_Mission.Columns.Add("Lv", 40);
            list_Mission.Columns.Add("Pay", 40);
            list_Mission.Columns.Add("Acc", 40);
            list_Mission.Columns.Add("Inf", 40);
            list_Mission.Columns.Add("CK", 40);
            list_Mission.Columns.Add("PA", 40); //Haha, PublicAss :P
            list_Mission.Columns.Add("Primary", 60);
            list_Mission.Columns.Add("Secondary", 70);
            list_Mission_Ongoing.Columns.Add("ID", 40);
            list_Mission_Ongoing.Columns.Add("Lv", 40);
            list_Mission_Ongoing.Columns.Add("Pay", 40);
            list_Mission_Ongoing.Columns.Add("Acc", 40);
            list_Mission_Ongoing.Columns.Add("Inf", 40);
            list_Mission_Ongoing.Columns.Add("CK", 40);
            list_Mission_Ongoing.Columns.Add("PA", 40); //Haha, PublicAss :P
            list_Mission_Ongoing.Columns.Add("Primary", 60);
            list_Mission_Ongoing.Columns.Add("Secondary", 70);
            Available_Assassins.Columns.Add("ID", 75);
            Available_Assassins.Columns.Add("Name", 75);
            Available_Assassins.Columns.Add("XP", 75);
            Available_Assassins.Columns.Add("Level", 75);
            #endregion
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Available_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
