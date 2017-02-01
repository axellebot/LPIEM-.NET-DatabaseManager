using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace DatabaseManager.Model
{
    public class Table
    {
        private string _name;

        [Column("name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Table()
        {
            _name = "";
        }
    }
}
