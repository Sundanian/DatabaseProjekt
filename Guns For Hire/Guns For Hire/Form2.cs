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

        static SaveLoad save = new SaveLoad();

        private static SQLiteConnection dbcon = new SQLiteConnection("Data Source = "+save.loadedDatabase);
        private static String sql = "";
        private static SQLiteCommand command = new SQLiteCommand(sql, dbcon);



        public Form2()
        {
            InitializeComponent();
        }

        private void List_Hire_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Current_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Retired_Assassins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Hire_Assassin_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "insert into ListOfAssassins (EgneAssassins) select id from AssassinsProfile where id='" + List_Hire_Assassin.SelectedItems[0].SubItems[0].Text + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            UpdateTables();
        }

        private void btn_Retire_Assassin_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "insert or replace into retiredassassins (Assassin) select id from AssassinsProfile where id='" + List_Retire_Assassin.SelectedItems[0].SubItems[0].Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = "delete from ListOfAssassins where EgneAssassins='" + List_Retire_Assassin.SelectedItems[0].SubItems[0].Text + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            UpdateTables();
        }

        private void btn_Rehire_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "insert or replace into ListOfAssassins (EgneAssassins) select id from AssassinsProfile where id='" + List_Rehire_Assassin.SelectedItems[0].SubItems[0].Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = "delete from RetiredAssassins where Assassin='" + List_Rehire_Assassin.SelectedItems[0].SubItems[0].Text + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            UpdateTables();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dbcon.Open();
            UpdateTables();
        }

        private void List_Hire_Assassin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Retire_Assassin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Rehire_Assassin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbcon.Close();
            Close();
        }
        public void UpdateTables()
        {
            #region Clear
            List_Hire_Assassin.Clear();
            List_Hire_Assassin.Columns.Add("ID", 75);
            List_Hire_Assassin.Columns.Add("Name", 75);
            List_Hire_Assassin.Columns.Add("XP", 75);
            List_Hire_Assassin.Columns.Add("Level", 75);
            List_Hire_Assassin.Columns.Add("Pris", 75);
            List_Rehire_Assassin.Clear();
            List_Rehire_Assassin.Columns.Add("ID", 75);
            List_Rehire_Assassin.Columns.Add("Name", 75);
            List_Rehire_Assassin.Columns.Add("XP", 75);
            List_Rehire_Assassin.Columns.Add("Level", 75);
            List_Rehire_Assassin.Columns.Add("Pris", 75);
            List_Retire_Assassin.Clear();
            List_Retire_Assassin.Columns.Add("ID", 75);
            List_Retire_Assassin.Columns.Add("Name", 75);
            List_Retire_Assassin.Columns.Add("XP", 75);
            List_Retire_Assassin.Columns.Add("Level", 75);
            List_Retire_Assassin.Columns.Add("Pris", 75);
            #endregion
            SQLiteCommand list = new SQLiteCommand("select * from AssassinsProfile LEFT JOIN ListOfAssassins ON assassinsprofile.id = ListOfAssassins.Egneassassins where ListOfAssassins.EgneAssassins IS NULL", dbcon);
            SQLiteDataReader reader = list.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["navn"].ToString());
                item.SubItems.Add(reader["XP"].ToString());
                item.SubItems.Add(reader["Level"].ToString());
                item.SubItems.Add(reader["Pris"].ToString());

                List_Hire_Assassin.Items.Add(item);

            }
            SQLiteCommand list2 = new SQLiteCommand("select * from assassinsprofile INNER JOIN ListOfAssassins ON assassinsprofile.id = ListOfAssassins.Egneassassins", dbcon);
            reader = list2.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["navn"].ToString());
                item.SubItems.Add(reader["XP"].ToString());
                item.SubItems.Add(reader["Level"].ToString());
                item.SubItems.Add(reader["Pris"].ToString());
                List_Retire_Assassin.Items.Add(item);
            }

            SQLiteCommand list3 = new SQLiteCommand("select * from assassinsprofile INNER JOIN retiredassassins ON assassinsprofile.id = retiredassassins.assassin", dbcon);
            reader = list3.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["navn"].ToString());
                item.SubItems.Add(reader["XP"].ToString());
                item.SubItems.Add(reader["Level"].ToString());
                item.SubItems.Add(reader["Pris"].ToString());
                List_Rehire_Assassin.Items.Add(item);
            }
        }
    }
}
