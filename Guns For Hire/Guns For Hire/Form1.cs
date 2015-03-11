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
    public partial class btn_star_game : Form
    {
        public btn_star_game()
        {
            InitializeComponent();
            HideMenu2();
            HideIngameMenu();
            //SQLite ting
            SQLiteConnection dbcon = new SQLiteConnection("Data Source = mindb2.db;Version=3");
            dbcon.Open();
            String sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, dbcon);

            //Brug følgende 3 linjer for at køre en SQL command, som ikke er en reader.
            //sql = "";
            //command.CommandText = sql;
            //command.ExecuteNonQuery();


        }

        #region Show Hide Menu
        private void HideMenu1()
        {
            Btn_Start_Game.Visible = false;
            Btn_how_to_play.Visible = false;
            Btn_quit.Visible = false;
        }

        private void ShowMenu1()
        {
            Btn_Start_Game.Visible = true;
            Btn_how_to_play.Visible = true;
            Btn_quit.Visible = true;
        }


        private void HideMenu2()
        {
            Btn_new_game.Visible = false;
            Btn_Load.Visible = false;
            Btn_Back.Visible = false;
        }

        private void ShowMenu2()
        {
            Btn_new_game.Visible = true;
            Btn_Load.Visible = true;
            Btn_Back.Visible = true;
        }

        private void HideIngameMenu()
        {

            btn_Assassins.Visible = false;
            Btn_Back.Visible = false;
            Btn_Missions.Visible = false;
            Btn_Save_Load.Visible = false;
            btn_Quit_InGame.Visible = false;

        }

        private void ShowIngameMenu()
        {
            btn_Assassins.Visible = true;
            Btn_Back.Visible = true;
            Btn_Missions.Visible = true;
            Btn_Save_Load.Visible = true;
            btn_Quit_InGame.Visible = true;
        }
        #endregion

        private void Btn_Start_Game_Click(object sender, EventArgs e)
        {
            HideMenu1();
            ShowMenu2();
        }
        


        private void Btn_how_to_play_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_new_game_Click(object sender, EventArgs e)
        {
            HideMenu2();
            ShowIngameMenu();
            Form2 f2 = new Form2();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            ShowMenu1();
            HideMenu2();
        }

        private void btn_Assassins_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Btn_Missions_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Btn_Save_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quit_InGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
