using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace DatabaseManager.Model {
    class TitleAuthor {

        private int _authorId;
        private int _titleId;
        private int _authorOrd;

        public TitleAuthor() {
            this.AuthorId = 0;
            this.TitleId = 0;
            this.AuthorOrd = 0;
        }

        public TitleAuthor(int _authorId, int _titleId, int _authorOrd) {
            this.AuthorId = _authorId;
            this.TitleId = _titleId;
            this.AuthorOrd = _authorOrd;
        }

        [Column("au_id")]
        public int AuthorId {
            get { return _authorId; }
            set { _authorId = value; }
        }

        [Column("title_id")]
        public int TitleId {
            get { return _titleId; }
            set { _titleId = value; }
        }

        [Column("au_ord")]
        public int AuthorOrd {
            get { return _authorOrd; }
            set { _authorOrd = value; }
        }
    }
}
