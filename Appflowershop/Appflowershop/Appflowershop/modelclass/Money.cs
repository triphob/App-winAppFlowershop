using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appflowershop.modelclass
{
    class Money
    {
        [PrimaryKey, AutoIncrement]
        public int IDodercheck { get; set; }

        public string NameUser { get; set; }

    }
}

