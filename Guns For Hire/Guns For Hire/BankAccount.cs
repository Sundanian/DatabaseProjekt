﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Guns_For_Hire
{
    class BankAccount
    {
        int currency = 0;

        public BankAccount()
        {
            
        }

        SQLiteDatabaseHelper SQLhelper = new SQLiteDatabaseHelper();

        public int Currency
        {
            get
            {
                return Int32.Parse(SQLhelper.ExecuteScalar("SELECT valuta FROM toolbar WHERE ID=1"));
            }

            set
            {
                if (currency - value >= 0 )
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();

                    dictionary.Add("valuta", value.ToString());
                    SQLhelper.Update("toolbar", dictionary, "ID=1");
                }
            }
        }
    }
}
