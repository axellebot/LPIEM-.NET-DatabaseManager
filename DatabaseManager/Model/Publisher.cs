using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace DatabaseManager.Model {
    [Table("Publishers")]
    class Publisher {
        private int _id;
        private string _name;
        private string _phoneNumber;
        private string _adress;
        private string _zipCode;
        private string _city;

        public Publisher() {
            this._id = 0;
            this._name = @"";
            this._phoneNumber = @"";
            this._adress = @"";
            this._zipCode = @"";
            this._city = @"";
        }

        public Publisher(int _id, string _name, string _phoneNumber, string _adress, string _zipCode, string _city) {
            this._id = _id;
            this._name = _name;
            this._phoneNumber = _phoneNumber;
            this._adress = _adress;
            this._zipCode = _zipCode;
            this._city = _city;
        }

        [Column("pub_id")]
        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        [Column("pub_name")]
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        [Column("pub_phone")]
        public string PhoneNumber {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        [Column("pub_adress")]
        public string Adress {
            get { return _adress; }
            set { _adress = value; }
        }

        [Column("pub_zip")]
        public string ZipCode {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        [Column("pub_city")]
        public string City {
            get { return _city; }
            set { _city = value; }
        }
    }
}
