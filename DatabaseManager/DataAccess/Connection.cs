using System;
using System.Collections.Generic;
using SQLite.Net;

namespace DatabaseManager.DataAccess
{
    public class Connection
    {
        private static Connection _connection = null;
        /// <summary>
        /// Permet de récupérer la connexion en cours
        /// </summary>
        /// <param name="db_file_path">Chemin d'accès au fichier base de données</param>
        /// <returns>Objet permettant de gérer la connexion à la base de données</returns>
        public static Connection GetCurrent(string db_file_path = "")
        {
            if (_connection == null || !_connection._connectionInitialized)
            {
                 _connection = new Connection();
                 _connection.Initialize(db_file_path);
            }

            return _connection;
        }


        private SQLite.Net.SQLiteConnection _conn;
        private string _databasePath;
        private bool _connectionInitialized;
        private List<string> _errors;

        public string DatabasePath
        {
            get { return _databasePath; }
        }
        public bool ConnectionInitialized
        {
            get { return _connectionInitialized; }
        }
        public List<string> Errors
        {
            get { return _errors; }
        }

        private Connection()
        {
            this._connectionInitialized = false;
            this._databasePath = "";
            this._errors = new List<string>();
        }
        
        private bool Initialize(string db_file_path)
        {
            _errors.Clear();

            try
            {
                // Vérification de l'existence du fichier
                if (!System.IO.File.Exists(db_file_path))
                {
                    this._errors.Add("Le fichier '" + db_file_path + "' n'existe pas !");
                    return false;   
                }

                // Initialisation de la base de données
                _databasePath = db_file_path.Replace(@"\", @"/");
                _conn = new SQLiteConnectionWithLock(new SQLite.Net.Platform.Generic.SQLitePlatformGeneric(), new SQLiteConnectionString(_databasePath, storeDateTimeAsTicks: true));
                this._connectionInitialized = true;
            }
            catch (Exception ex)
            {
                _errors.Add(ex.Message);
                this._connectionInitialized = false;
            }

            return _errors.Count <= 0;
        }

        private bool CheckIfInstanceIsInitialized()
        {
            if (!this._connectionInitialized)
            {
                this._errors.Add("Base de données non initialisée !");
                return false;
            }

            return true;
        }



        public T ExecuteScalar<T>(string sqlQuery) where T : class
        {
            this._errors.Clear();
            if (!CheckIfInstanceIsInitialized()) return null;

            try
            {
                return _conn.ExecuteScalar<T>(sqlQuery);
            }
            catch (Exception ex)
            {
                this._errors.Add(ex.Message);
                return null;
            }
        }

        public List<T> ExecuteQuery<T>(string sqlQuery) where T : class
        {
            this._errors.Clear();
            if (!CheckIfInstanceIsInitialized()) return null;

            try
            {
                return _conn.Query<T>(sqlQuery);
            }
            catch (Exception ex)
            {
                this._errors.Add(ex.Message);
                return null;
            }
        }

        public int Execute(string sqlQuery)
        {
            this._errors.Clear();
            if (!CheckIfInstanceIsInitialized()) return 0;

            try
            {
                return _conn.Execute(sqlQuery);
            }
            catch (Exception ex)
            {
                this._errors.Add(ex.Message);
                return 0;
            }
        }

    }
}
