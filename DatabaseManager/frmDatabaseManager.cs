using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager.Model;

namespace DatabaseManager
{
    public partial class frmDatabaseManager : Form
    {
        public DataAccess.Connection DBConn
        {
            get { return DataAccess.Connection.GetCurrent(); }
        }

        public frmDatabaseManager()
        {
            InitializeComponent();
        }


        private void tsOuvrirBdd_Click(object sender, EventArgs e)
        {
            OpenDBFile();
        }
        private void tsQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTable.Items.Count == 0 || this.cbTable.SelectedItem == null) return;

            // TODO : Charger le contenu de la table sélectionnée
            string tableName = (string)this.cbTable.SelectedItem;
            string query = "SELECT * FROM " + tableName;
            switch (tableName) {
                case Constants.Type.AUTHOR:
                    dataGridView1.DataSource = DBConn.ExecuteQuery<Model.Author>(query);
                    break;
                case Constants.Type.PUBLISHER:
                    dataGridView1.DataSource = DBConn.ExecuteQuery<Model.Publisher>(query);
                    break;
                case Constants.Type.SQLITE_SEQUENCE:
                    dataGridView1.DataSource = DBConn.ExecuteQuery<Model.SqliteSequence>(query);
                    break;
                case Constants.Type.TITLE:
                    dataGridView1.DataSource = DBConn.ExecuteQuery<Model.Title>(query);
                    break;
                case Constants.Type.TITLE_AUTHOR:
                    dataGridView1.DataSource = DBConn.ExecuteQuery<Model.TitleAuthor>(query);
                    break;
            }
        }


        private void ShowErrors()
        {
            if (DBConn == null) return;

            string message = "";
            foreach (string err in DBConn.Errors)
            {
                if (message != "") message += "\n\r";
                message += err;
            }

            MessageBox.Show(this, message, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableWindow()
        {
            this.pnlContenu.Enabled = (DBConn != null && DBConn.ConnectionInitialized && DBConn.Errors.Count == 0);
        }

        private void LoadTablesList()
        {
            this.cbTable.Items.Clear();
            if (DBConn != null && DBConn.ConnectionInitialized && DBConn.Errors.Count == 0)
            {
                string query = "SELECT name FROM sqlite_master WHERE type='table'";
                foreach (Model.Table t in DBConn.ExecuteQuery<Model.Table>(query))
                {
                    this.cbTable.Items.Add(t.Name);
                }
            }
        }

        private void OpenDBFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "";
            dialog.Filter = "db files (*.db)|*.db";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataAccess.Connection c = DataAccess.Connection.GetCurrent(dialog.FileName);
                if (c.Errors.Count > 0)
                {
                    ShowErrors();
                    this.tsLblBddEnCours.Text = "Aucune base de données n'est ouverte !";
                }
                else
                {
                    this.tsLblBddEnCours.Text = "Base de données ouverte : " + c.DatabasePath;
                }
                EnableWindow();
                LoadTablesList();
            }

        }

    }
}
