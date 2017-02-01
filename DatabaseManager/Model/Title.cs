using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;


namespace DatabaseManager.Model {
    [Table("Titles")]
    class Title {

        private int _id;
        private string _title;
        private DateTime _pubDate;
        private float _price;
        private int _pubId;

        public Title() {
            this._id = 0;
            this._title = @"";
            this._pubDate = new DateTime();
            this._price = 0.0f;
            this._pubId = 0;
        }

        public Title(int _id, string _title, DateTime _pubDate, float _price, int _pubId) {
            this._id = _id;
            this._title = _title;
            this._pubDate = _pubDate;
            this._price = _price;
            this._pubId = _pubId;
        }

        [Column("title_id")]
        public int Id {
            get { return _id; }
            set { _id = value;  }
        }

        [Column("title")]
        public string BookTitle {
            get {  return _title; }
            set { _title = value; }
        }

        [Column("pubdate")]
        public DateTime PubDate {
            get { return _pubDate; }
            set {  _pubDate = value; }
        }

        [Column("price")]
        public float Price {
            get { return _price; }
            set { _price = value; }
        }

        [Column("pub_id")]
        public int PubId {
            get { return _pubId; }
            set { _pubId = value; }
        }
    }
}
