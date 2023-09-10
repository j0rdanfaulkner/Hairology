using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class DatabaseManagement
    {
        public System.Data.SqlClient.SqlConnection conn = default!;
        private string _connectionString = Properties.Settings.Default.ConnectionString;
        private string _address = "https://www.jordan-faulkner.com/databases/hairology/Database.mdf";
        WebClient client = new WebClient();
        public void ConnectToDatabase()
        {
            if (!File.Exists("C:\\Hairology\\Data\\Database.mdf"))
            {
                MessageBox.Show("The database will now be downloaded", "Missing Database File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string current = Directory.GetCurrentDirectory();
                string dbpath = "C:\\Hairology\\Data\\Database.mdf";
                Directory.CreateDirectory(dbpath);
                Directory.SetCurrentDirectory(dbpath);
                try
                {
                    client.DownloadFile(_address, "Database.mdf");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("No such host") == true)
                    {
                        MessageBox.Show("Check your internet connection, then try again", "Download Was Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Directory.SetCurrentDirectory(current);
                ConnectToDatabase();
            }
            else
            {
                conn = new System.Data.SqlClient.SqlConnection(_connectionString);
            }
        }
    }

}
