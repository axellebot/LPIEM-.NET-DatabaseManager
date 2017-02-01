using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Model {
    class SqliteSequence {
        private string _name;
        private string _seq;

        public SqliteSequence() {
            this.Name = @"";
            this.Seq = @"";
        }

        public SqliteSequence(string _name, string _seq) {
            this.Name = _name;
            this.Seq = _seq;
        }

        public string Name {
            get {
                return _name;
            }

            set {
                _name = value;
            }
        }

        public string Seq {
            get {
                return _seq;
            }

            set {
                _seq = value;
            }
        }
    }
}
