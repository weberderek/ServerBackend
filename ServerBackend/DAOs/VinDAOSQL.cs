using ServerBackend.Models;
using System.Data.SqlClient;

namespace ServerBackend.DAOs
{
    internal class VinDAOSQL : IVinDAO
    {
        private static VinDAOSQL _instance;
        public static VinDAOSQL Instance()
        {
            if(_instance == null )
                _instance = new VinDAOSQL();
            return _instance;
        }

        private SqlConnection connectToDB()
        {
            string server1 = "10.244.150.129";
            string databaseName1 = "Production";
            string userName1 = "prodadmin";
            string password1 = "ProdAdmin2022";
            string connstring = string.Format("Server={0}; Database={1}; User Id={2}; Password={3}", server1, databaseName1, userName1, password1);
            return new SqlConnection(connstring);
        }

        private Vin GetVinFromReader(SqlDataReader reader)
        {
            string? vin ="";
            string? workOrder ="";
            string? model ="";
            if (!reader.IsDBNull(0))
            {
                vin = reader.GetString(0);
            }
            if (!reader.IsDBNull(1))
            {
                workOrder = reader.GetString(1);
            }
            if (!reader.IsDBNull(2))
            {
                model = reader.GetString(2);
            }
            return new Vin(vin, workOrder, model);
        }

        public List<Vin> GetVins()
        {
            List<Vin> vins = new List<Vin>();
            SqlConnection cnn = connectToDB();
            cnn.Open();
            SqlCommand command;
            SqlDataReader reader;
            string query = "SELECT * FROM vin";
            command = new SqlCommand(query, cnn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                vins.Add(GetVinFromReader(reader));
            }
            cnn.Close();
            return vins;
        }
    }
}
