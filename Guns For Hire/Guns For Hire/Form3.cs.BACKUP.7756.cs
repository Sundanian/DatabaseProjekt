﻿using System;
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

        public void Assassins_Level_Check()
        {
            #region TurnXPToVariable
            SQLiteCommand command2 = new SQLiteCommand(sql, dbcon);
            command2.CommandText = "select XP from AssassinsProfile";
            SQLiteDataReader reader = command2.ExecuteReader();
            int variableXP = 0;

            while (reader.Read())
            {
                variableXP = Convert.ToInt32(reader["XP"]);
            }
            #endregion

            #region TurnLevelToVariable
            SQLiteCommand command3 = new SQLiteCommand(sql, dbcon);
            command3.CommandText = "select Level from AssassinsProfile";
            SQLiteDataReader reader2 = command3.ExecuteReader();
            int variableLevel = 0;

            while (reader.Read())
            {
                variableLevel = Convert.ToInt32(reader2["Level"]);
            }
            #endregion

            int MaxXP = 1000 * variableLevel;

            if (variableXP == MaxXP)
            {
                variableLevel++;
                sql = " Update AssassinsProfile(Level) values (" + variableLevel + ")";
                command.ExecuteNonQuery();

                sql = "Update AssassinsProfile SET XP=0";
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        private void Btn_Select_Mission_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            #region MissionLevelTing
            SQLiteCommand command1 = new SQLiteCommand(sql, dbcon);
            SQLiteCommand commandSA = new SQLiteCommand(sql, dbcon);
            command1.CommandText = "select Level from mission where Level='" + list_Mission.SelectedItems[0].SubItems[1].Text + "'";
            commandSA.CommandText = "select id from AssassinsProfile where id='" + Available_Assassins.SelectedItems[0].SubItems[0].Text + "'";
            SQLiteDataReader reader = command1.ExecuteReader();
            SQLiteDataReader readerSA = commandSA.ExecuteReader();
            string value = "";

            while (reader.Read())
=======
            try
>>>>>>> 3568f7c4c3cd25cce436465f87444bd05044251f
            {
                #region MissionLevelTing
                SQLiteCommand command1 = new SQLiteCommand(sql, dbcon);
                command1.CommandText = "select from mission where Level='" + list_Mission.SelectedItems[0].SubItems[0].Text + "'";
                SQLiteDataReader reader = command1.ExecuteReader();
                string value = "";

                while (reader.Read())
                {
                    value = Convert.ToString(reader["Level"]);
                }

                command = new SQLiteCommand(sql, dbcon);

                switch (value)
                {
                    case "1":
                        sql = "Update AssassinsProfile  SET XP=XP+100 WHERE id='" + Available_Assassins.SelectedItems[0].SubItems[0].Text + "'";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        Assassins_Level_Check();
                        break;

                    case "2":
                        sql = "Update AssassinsProfile  SET XP=XP+200 WHERE id='" + Available_Assassins.SelectedItems[0].SubItems[0].Text + "'";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        break;
                    case "3":
                        sql = "Update AssassinsProfile  SET XP=XP+300 WHERE id='" + Available_Assassins.SelectedItems[0].SubItems[0].Text + "'";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        break;
                    default:
                        break;
                }
                #endregion
                UpdateTables();
            }
            catch (Exception)
            {

            }
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
            SQLiteCommand list = new SQLiteCommand("select * from assassinsprofile INNER JOIN ListOfAssassins ON assassinsprofile.id = ListOfAssassins.Egneassassins", dbcon);
            SQLiteDataReader reader = list.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["navn"].ToString());
                item.SubItems.Add(reader["XP"].ToString());
                item.SubItems.Add(reader["Level"].ToString());
                item.SubItems.Add(reader["Pris"].ToString());
                Available_Assassins.Items.Add(item);
            }
            SQLiteCommand list2 = new SQLiteCommand("select * from mission", dbcon);
            reader = list2.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["level"].ToString());
                item.SubItems.Add(reader["pay"].ToString());
                item.SubItems.Add(reader["accident"].ToString());
                item.SubItems.Add(reader["infiltration"].ToString());
                item.SubItems.Add(reader["charismakill"].ToString());
                item.SubItems.Add(reader["publicass"].ToString());
                item.SubItems.Add(reader["primary type"].ToString());
                item.SubItems.Add(reader["secondary type"].ToString());
                list_Mission.Items.Add(item);
            }
            SQLiteCommand list3 = new SQLiteCommand("select * from missionList", dbcon);
            reader = list3.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["level"].ToString());
                item.SubItems.Add(reader["pay"].ToString());
                item.SubItems.Add(reader["accident"].ToString());
                item.SubItems.Add(reader["infiltration"].ToString());
                item.SubItems.Add(reader["charismakill"].ToString());
                item.SubItems.Add(reader["publicass"].ToString());
                item.SubItems.Add(reader["primary type"].ToString());
                item.SubItems.Add(reader["secondary type"].ToString());
                list_Mission_Ongoing.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Available_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTables();
            }
            catch (Exception)
            {

            }
        }
    }
}
