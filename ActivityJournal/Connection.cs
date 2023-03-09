using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ActivityJournal
{
    class Connection
    {
        // declare connection variables
        private static SQLiteConnection con;
        private static SQLiteCommand cmd;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();

        // connection to database file
        public void setConnection()
        {
            con = new SQLiteConnection("Data Source=ActivityJournal.db;Version=3;New=Flase;Compress=True;");
        }
        // execute query function with no returning values
        public void ExecuteQuery(string txtQuery)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // creates a connection to the database and keeps it open
        public SQLiteConnection GetConnection()
        {
            setConnection();
            con.Open();
            return con;
        }
        // gets values that are in the specified table and returns a string
        public string ReadString(string txtQuery)
        {
            using(SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd = new SQLiteCommand(txtQuery, con))
            {
                object result = cmd.ExecuteScalar();
                return (result == null ? "" : result.ToString());
            }
        }
        // pulls data from a table and fills it into a specified datagrid
        public void LoadData(string query, DataGridView dataGrid)
        {
            var conn = GetConnection();
            var DB = new SQLiteDataAdapter(query, con);
            var DS = new DataSet();
            var DT = new DataTable();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGrid.DataSource = DT;
            con.Close();
        }
    }
}
