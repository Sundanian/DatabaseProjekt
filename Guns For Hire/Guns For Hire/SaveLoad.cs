using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Guns_For_Hire
{
    class SaveLoad
    {
        public string loadedDatabase="save04.db";

        public SaveLoad()
        {
        }

        public void CreateGame(int saveSlot)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += string.Format("save0{0}.db", saveSlot.ToString());

            if (!File.Exists(path))
            {
                string databaseToCreate = string.Format("save0{0}.db", saveSlot.ToString());
                SQLiteConnection.CreateFile(databaseToCreate);
                loadedDatabase = databaseToCreate;
                    
                //Opretter en ny instans af SQLiteDatabaseHelper klassen på baggrund af loadedDatabase
                SQLiteDatabaseHelper SQLhelper = new SQLiteDatabaseHelper(databaseToCreate);

                //Sætter tabellerne op
                #region AssassinsProfile
                //Opretter tabel med assassin profiler
                SQLhelper.ExecuteNonQuery("create table if not exists AssassinsProfile (id integer primary key, navn string, XP int, Level int, Pris int)");

                //Tilføjer 5 assassins
                SQLhelper.ExecuteNonQuery(
                @"insert or ignore into AssassinsProfile values (1, 'Hugo', 0, 1, 500);
                insert or ignore into AssassinsProfile values (2, 'Fritz', 0, 1, 350);
                insert or ignore into AssassinsProfile values (3, 'Karl', 0, 1, 370);
                insert or ignore into AssassinsProfile values (4, 'Olga', 0, 1, 200)");
                #endregion

                #region Missions
                //Opretter mission tabel
                SQLhelper.ExecuteNonQuery("create table if not exists mission (ID integer primary key not NULL, Level int, Pay int, Accident int, Infiltration int, CharismaKill int, PublicAss int, 'Primary Type' varchar(20), 'Secondary Type' varchar(20))");

                //Tilføjer 5 missioner
                SQLhelper.ExecuteNonQuery(
                @"insert or ignore into mission values (1, 2, 1000, 2, 3, 2, 4, 'PublicAss', 'Infiltration');
                insert or ignore into mission values (2, 2, 1000, 2, 4, 3, 2, 'Infiltration', 'CharismaKill');
                insert or ignore into mission values (3, 1, 1000, 3, 2, 4, 2, 'CharismaKill', 'Accident');
                insert or ignore into mission values (4, 1, 1000, 4, 2, 2, 3, 'Accident', 'PublicAss')");
                #endregion

                #region AssassinStats
                //Tilføjer en tabel over assassin stats
                SQLhelper.ExecuteNonQuery("create table if not exists AssassinsStats (id integer primary key, charisma int, coverUp int, disguise int, getAway int)");

                //Sætter de fem assassins fra assassin listens stats
                SQLhelper.ExecuteNonQuery(
                @"insert or ignore into AssassinsStats values (1, 70, 10, 50, 20);
                insert or ignore into AssassinsStats values (2, 30, 60, 20, 40);
                insert or ignore into AssassinsStats values (3, 10, 60, 30, 20);
                insert or ignore into AssassinsStats values (4, 30, 20, 30, 50);
                insert or ignore into AssassinsStats values (5, 5, 20, 100, 5)");
                #endregion

                #region MissionList
                //Opretter missionlist tabel
                SQLhelper.ExecuteNonQuery("create table if not exists missionList (ID integer primary key not NULL, mission integer references mission(ID))");
                #endregion

                #region TransferWindow
                SQLhelper.ExecuteNonQuery("create table if not exists TransferWindow (id integer primary key not NULL, TransferAssassins int references AssassinsProfile(id))");
                #endregion

                #region Toolbar
                //Opretter missionlist tabel
                SQLhelper.ExecuteNonQuery("create table if not exists toolbar (ID integer primary key not NULL, valuta integer)");

                //Debug værdi
                SQLhelper.ExecuteNonQuery("insert or ignore into toolbar values (1, 0)");
                #endregion

                #region AssassinsList
                //Opretter lister over egne assassins tabel
                SQLhelper.ExecuteNonQuery("create table if not exists ListOfAssassins (ID integer primary key not NULL, EgneAssassins integer references AssassonsProfile(id))");
                #endregion

                #region RetiredAssassins
                //Opretter liste over assassins på pension
                SQLhelper.ExecuteNonQuery("create table if not exists RetiredAssassins (id integer primary key, assassin integer references AssasinsProfile(ID))");
                #endregion
            }
        }

        public void LoadGame(string loadDatabase)
        {
            loadedDatabase = loadDatabase;
        }
    }
}
