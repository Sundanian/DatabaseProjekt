using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Guns_For_Hire
{
    class SaveLoad
    {
        public string loadedDatabase;

        static SQLiteDatabaseHelper SQLhelper = new SQLiteDatabaseHelper();

        public SaveLoad()
        {
        }

        public void CreateGame(int saveSlot)
        {
            string databaseToCreate = string.Format("save0{0}.db", saveSlot.ToString());
            SQLiteConnection.CreateFile(databaseToCreate);
            loadedDatabase = databaseToCreate;

            //Opretter en ny instans af SQLiteDatabaseHelper klassen på baggrund af loadedDatabase
            SQLiteDatabaseHelper SQLhelper = new SQLiteDatabaseHelper(databaseToCreate);

            //Sætter tabellerne op
            #region AssassinsProfile
            //Opretter tabel med assassin profiler
            SQLhelper.ExecuteNonQuery("create table if not exists AssassinsProfile (id integer primary key, navn string, XP int, Level int, Pris int, charisma int, coverUp int, disguise int, getAway int)");

            //Tilføjer 5 assassins
            SQLhelper.ExecuteNonQuery(
            @"insert or ignore into AssassinsProfile values (1, 'Hugo', 0, 1, 500, 70, 10, 50, 20);
                insert or ignore into AssassinsProfile values (2, 'Fritz', 0, 1, 350, 30, 60, 20, 4);
                insert or ignore into AssassinsProfile values (3, 'Karl', 0, 1, 370, 10, 60, 30, 20);
                insert or ignore into AssassinsProfile values (4, 'Olga', 0, 1, 200, 30, 20, 30, 50)");
            #endregion

            #region Mission
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
            //                //Tilføjer en tabel over assassin stats
            //                SQLhelper.ExecuteNonQuery("create table if not exists AssassinsStats (id integer primary key references AssassinsProfile, charisma int, coverUp int, disguise int, getAway int)");

            //                //Sætter de fem assassins fra assassin listens stats
            //                SQLhelper.ExecuteNonQuery(
            //                @"insert or ignore into AssassinsStats values (1, 70, 10, 50, 20);
            //                insert or ignore into AssassinsStats values (2, 30, 60, 20, 40);
            //                insert or ignore into AssassinsStats values (3, 10, 60, 30, 20);
            //                insert or ignore into AssassinsStats values (4, 30, 20, 30, 50);
            //                insert or ignore into AssassinsStats values (5, 5, 20, 100, 5)");
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

            #region ListOfAssassins
            //Opretter lister over egne assassins tabel
            SQLhelper.ExecuteNonQuery("create table if not exists ListOfAssassins (ID integer primary key not NULL, EgneAssassins integer references AssassinsProfile(id))");
            #endregion

            #region RetiredAssassins
            //Opretter liste over assassins på pension
            SQLhelper.ExecuteNonQuery("create table if not exists RetiredAssassins (id integer primary key, assassin integer references AssasinsProfile(ID))");
            #endregion

            #region OnMission
            //Opretter liste over assassins på mission
            SQLhelper.ExecuteNonQuery("create table if not exists OnMission (id integer primary key, assassin integer references AssasinsProfile(ID))");
            #endregion
        }

        #region LoadGame Method
        public void LoadGame(int slot)
        {
            SQLiteDatabaseHelper loadHelper = new SQLiteDatabaseHelper(string.Format("save0{0}.db", slot.ToString()));

            #region AssassinsProfile
            SQLhelper.ClearTable("assassinsprofile");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM assassinsprofile").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO assassinsprofile (navn, XP, Level, Pris, charisma, coverUp, disguise, getAway)
                    VALUES ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7})",
                    row["navn"], row["XP"], row["Level"], row["Pris"], row["charisma"], row["coverUp"], row["disguise"], row["getAway"]));
            }
            #endregion

            #region ListOfAssassins
            SQLhelper.ClearTable("ListOfAssassins");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM ListOfAssassins").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO ListOfAssassins (EgneAssassins)
                    VALUES ({0})",
                    row["EgneAssassins"]));
            }
            #endregion

            #region Mission
            SQLhelper.ClearTable("mission");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM mission").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO mission (Level, Pay, Accident, Infiltration, CharismaKill, PublicAss, 'Primary Type', 'Secondary Type')
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, '{6}', '{7}')",
                    row["Level"], row["Pay"], row["Accident"], row["Infiltration"], row["CharismaKill"], row["PublicAss"], row["Primary Type"], row["Secondary Type"]));
            }
            #endregion

            #region MissionList
            SQLhelper.ClearTable("missionList");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM missionList").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO missionList (mission)
                    VALUES ({0})",
                    row["mission"]));
            }
            #endregion

            #region OnMission
            SQLhelper.ClearTable("OnMission");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM OnMission").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO OnMission (assassin)
                    VALUES ({0})",
                    row["assassin"]));
            }
            #endregion

            #region RetiredAssassins
            SQLhelper.ClearTable("RetiredAssassins");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM RetiredAssassins").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO RetiredAssassins (assassin)
                    VALUES ({0})",
                    row["assassin"]));
            }
            #endregion

            #region Toolbar
            SQLhelper.ClearTable("toolbar");

            foreach (DataRow row in loadHelper.GetDataTable("SELECT * FROM toolbar").Rows)
            {
                SQLhelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO toolbar (valuta)
                    VALUES ({0})",
                    row["valuta"]));
            }
            #endregion
        }
        #endregion

        #region SaveGame Method
        public void SaveGame(int slot)
        {
            SQLiteDatabaseHelper saveHelper = new SQLiteDatabaseHelper(string.Format("save0{0}.db", slot.ToString()));

            #region AssassinsProfile
            saveHelper.ClearTable("assassinsprofile");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM assassinsprofile").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO assassinsprofile (navn, XP, Level, Pris, charisma, coverUp, disguise, getAway)
                    VALUES ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7})",
                    row["navn"], row["XP"], row["Level"], row["Pris"], row["charisma"], row["coverUp"], row["disguise"], row["getAway"]));
            }
            #endregion

            #region ListOfAssassins
            saveHelper.ClearTable("ListOfAssassins");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM ListOfAssassins").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO ListOfAssassins (EgneAssassins)
                    VALUES ({0})",
                    row["EgneAssassins"]));
            }
            #endregion

            #region Mission
            saveHelper.ClearTable("mission");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM mission").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO mission (Level, Pay, Accident, Infiltration, CharismaKill, PublicAss, 'Primary Type', 'Secondary Type')
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, '{6}', '{7}')",
                    row["Level"], row["Pay"], row["Accident"], row["Infiltration"], row["CharismaKill"], row["PublicAss"], row["Primary Type"], row["Secondary Type"]));
            }
            #endregion

            #region MissionList
            saveHelper.ClearTable("missionList");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM missionList").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO missionList (mission)
                    VALUES ({0})",
                    row["mission"]));
            }
            #endregion

            #region OnMission
            saveHelper.ClearTable("OnMission");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM OnMission").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO OnMission (assassin)
                    VALUES ({0})",
                    row["assassin"]));
            }
            #endregion

            #region RetiredAssassins
            saveHelper.ClearTable("RetiredAssassins");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM RetiredAssassins").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO RetiredAssassins (assassin)
                    VALUES ({0})",
                    row["assassin"]));
            }
            #endregion

            #region Toolbar
            saveHelper.ClearTable("toolbar");

            foreach (DataRow row in SQLhelper.GetDataTable("SELECT * FROM toolbar").Rows)
            {
                saveHelper.ExecuteNonQuery(
                    string.Format(
                    @"INSERT INTO toolbar (valuta)
                    VALUES ({0})",
                    row["valuta"]));
            }
            #endregion
        }
        #endregion
    }
}
