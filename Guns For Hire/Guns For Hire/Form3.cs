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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Select_Mission_Click(object sender, EventArgs e)
        {

            //SQLiteCommand command1 = new SQLiteCommand(sql, dbcon);
            //command1.CommandText = "select from mission where Level='" + List_Mission.SelectedItems[0].SubItems[0].Text + "'";
        }

    }

}
