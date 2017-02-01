using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;


namespace DatabaseManager.Model {
    [Table("Authors")]
    class Author {

        private int _id;
        private string _lastName;
        private string _firstName;
        private string _phoneNumber;
        private string _adress;
        private string _zipCode;
        private string _city;

        public Author() {
            this._id = 0;
            this._lastName = @"";
            this._firstName = @"";
            this._phoneNumber = @"";
            this._adress = @"";
            this._zipCode = @"";
            this._city = @"";
        }

        public Author(int _id, string _lastName, string _firstName, string _phoneNumber, string _adress, string _zipCode, string _city) {
            this._id = _id;
            this._lastName = _lastName;
            this._firstName = _firstName;
            this._phoneNumber = _phoneNumber;
            this._adress = _adress;
            this._zipCode = _zipCode;
            this._city = _city;
        }

        [Column("au_id")]
        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        [Column("au_lname")]
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [Column("au_fname")]
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [Column("au_phone")]
        public string PhoneNumber {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        [Column("au_adress")]
        public string Adress {
            get { return _adress; }
            set { _adress = value; }
        }

        [Column("au_zip")]
        public string ZipCode {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        [Column("au_city")]
        public string City {
            get { return _city; }
            set { _city = value; }
        }
    }
}
