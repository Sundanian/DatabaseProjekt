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
using System.Xml.Linq;
using System.Collections;

namespace Guns_For_Hire
{


    public partial class btn_star_game : Form
    {        
        static SaveLoad save = new SaveLoad();
        static Form2 form2 = new Form2();

        int selectedSlot = 0;

        private static SQLiteConnection dbcon = new SQLiteConnection("Data Source = save04.db");
        private static String sql = "";
        private static SQLiteCommand command = new SQLiteCommand(sql, dbcon);

        public btn_star_game()
        {
            InitializeComponent();
        }

        //Brug følgende 3 linjer for at køre en SQL command, som ikke er en reader.
        //sql = "";
        //command.CommandText = sql;
        //command.ExecuteNonQuery();

        #region Show Hide Menu
        //Den samling af metoder som Viser og skjluer menu knapper alter efter hvilken menu men er i
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

        private void HideSaveLoadMenu()
        {
            btn_Save.Visible = false;
            Btn_Load_ingame.Visible = false;
            Btn_Back_SL.Visible = false;
            btn_Save_1.Visible = false;
            btn_Save_2.Visible = false;
            btn_Save_3.Visible = false;
        }

        private void ShowSaveLoadMenu()
        {
            btn_Save.Visible = true;
            Btn_Load_ingame.Visible = true;
            Btn_Back_SL.Visible = true;
            btn_Save_1.Visible = true;
            btn_Save_2.Visible = true;
            btn_Save_3.Visible = true;
        }

        private void HideSaveLoadMenuMainmenu()
        {
            btn_save_1_Mainmenu.Visible = false;
            btn_Save_2_Mainmenu.Visible = false;
            Btn_Save_3_Mainmenu.Visible = false;
            btn_Load_Mainmenu.Visible = false;
        }

        private void ShowSaveLoadMenuMainmenu()
        {
            btn_save_1_Mainmenu.Visible = true;
            btn_Save_2_Mainmenu.Visible = true;
            Btn_Save_3_Mainmenu.Visible = true;
            btn_Load_Mainmenu.Visible = true;
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
            #region AddCashOnNewGame
            SQLiteCommand command = new SQLiteCommand();
            sql = "Update toolbar SET valuta=valuta+500";
            command = new SQLiteCommand(sql, dbcon);
            dbcon.Open();
            command.ExecuteNonQuery();
            Showcash();
            #endregion
            HideMenu2();
            ShowIngameMenu();
            Form2 f2 = new Form2();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            ShowSaveLoadMenuMainmenu();
            HideMenu2();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            ShowMenu1();
            HideMenu2();
        }

        private void btn_Assassins_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Btn_Missions_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Btn_Save_Load_Click(object sender, EventArgs e)
        {
            HideIngameMenu();
            ShowSaveLoadMenu();
            HideSaveLoadMenuMainmenu();
        }

        private void btn_Quit_InGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Save_1_Click(object sender, EventArgs e)
        {
            selectedSlot = 1;
        }

        private void btn_Save_2_Click(object sender, EventArgs e)
        {
            selectedSlot = 2;
        }

        private void btn_Save_3_Click(object sender, EventArgs e)
        {
            selectedSlot = 3;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (selectedSlot != 0)
            {
                save.SaveGame(selectedSlot);
                selectedSlot = 0;
            }
            Form4 popup = new Form4();
            popup.Show();
        }

        private void Btn_Load_ingame_Click(object sender, EventArgs e)
        {
            if (selectedSlot != 0)
            {
                save.LoadGame(selectedSlot);

                HideSaveLoadMenu();
                ShowIngameMenu();
                HideSaveLoadMenuMainmenu();
                selectedSlot = 0;
            }
            Form4 popup = new Form4();
            popup.Show();
        }

        private void Btn_Back_SL_Click(object sender, EventArgs e)
        {
            HideSaveLoadMenu();
            ShowIngameMenu();
        }

        private void btn_star_game_Load(object sender, EventArgs e)
        {
            HideMenu2();
            HideIngameMenu();

            HideSaveLoadMenu();
            HideSaveLoadMenuMainmenu();

            #region SaveLoadSetup
            SaveLoad save = new SaveLoad();
            save.CreateGame(1);
            save.CreateGame(2);
            save.CreateGame(3);
            save.CreateGame(4);
            #endregion

            //Tmp database
            SQLiteConnection dbcon = new SQLiteConnection("Data Source = save04.db;Version=3");
            dbcon.Open();
            String sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, dbcon);
            //Save1
            SQLiteConnection dbcon1 = new SQLiteConnection("Data Source = save01.db;Version=3");
            dbcon1.Open();
            String sql1 = "";
            SQLiteCommand command1 = new SQLiteCommand(sql1, dbcon);
            //Save2
            SQLiteConnection dbcon2 = new SQLiteConnection("Data Source = save02.db;Version=3");
            dbcon2.Open();
            String sql2 = "";
            SQLiteCommand command2 = new SQLiteCommand(sql2, dbcon);
            //Save3
            SQLiteConnection dbcon3 = new SQLiteConnection("Data Source = save03.db;Version=3");
            dbcon3.Open();
            String sql3 = "";
            SQLiteCommand command3 = new SQLiteCommand(sql3, dbcon);


            //Brug følgende 3 linjer for at køre en SQL command, som ikke er en reader.
            //sql = "";
            //command.CommandText = sql;
            //command.ExecuteNonQuery()

            Showcash();
            ShowNews();
        }


        private void List_Moneyyyyyyy_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void Showcash()
        {
            
            List_Moneyyyyyyy.Clear();
            List_Moneyyyyyyy.Columns.Add("Money",80);


            List_Moneyyyyyyy.Clear();
            List_Moneyyyyyyy.Columns.Add("Money", 100);

            SQLiteConnection dbcon = new SQLiteConnection("Data Source = save04.db;version=3 ");
            dbcon.Open();
            SQLiteCommand list = new SQLiteCommand("select valuta from toolbar", dbcon);
            SQLiteDataReader reader = list.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["valuta"].ToString());


                List_Moneyyyyyyy.Items.Add(item);
            }
          
        }

        private void News_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowNews()
        {
            //Laver et array af news
            string[] news = new string[] {"The pope have been assassinated.", "The russian president have not been seen for days. Assassination suspected.", "Police still no clues in german assassination.", "Suicide victim known as O.M. turns out to be assassination.", "Fish assassinated by well known assassin O.M. Assassin is armed and dangerous. Police advice to keep distance." };

            Random rnd = new Random();
            int r = rnd.Next(1, news.Length);
            var newsToShow = from n in news
                             select news[r];
            foreach (var n in newsToShow)
            {
                News.Items.Add(n);
            }
        }

        private void News_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
