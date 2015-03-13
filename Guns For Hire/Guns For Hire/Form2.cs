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
<<<<<<< HEAD
            string sql = "select * from AssassinsProfile";
            SQLiteCommand command = new SQLiteCommand(sql, dbcon);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
            }
=======
           
>>>>>>> 215fa73f4cb3b2e45422a9a36dcb2390f672715d
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

        }

        private void btn_Rehire_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dbcon.Open();


            SQLiteCommand list = new SQLiteCommand("select * from AssassinsProfile", dbcon);
            //command.ExecuteNonQuery();
            SQLiteDataReader reader = list.ExecuteReader();
            
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["navn"].ToString());
                item.SubItems.Add(reader["XP"].ToString());
                item.SubItems.Add(reader["Level"].ToString());
                item.SubItems.Add(reader["Pris"].ToString());

                List_Hire_Assassin.Items.Add(item);
                List_Retire_Assassin.Items.Add(item);
                List_Rehire_Assassin.Items.Add(item);
            }


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
    }
}
