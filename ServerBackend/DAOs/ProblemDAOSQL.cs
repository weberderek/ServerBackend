using ServerBackend.Models;
using System.Data.SqlClient;

namespace ServerBackend.DAOs
{
    public class ProblemDAOSQL : IProblemDAO
    {
        private static ProblemDAOSQL _instance = null;
        public static ProblemDAOSQL Instance()
        {
            if(_instance == null )
                _instance = new ProblemDAOSQL();
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

        private Problem GetProblemFromReader(SqlDataReader reader)
        {
            string? partID = "";
            string? VIN = "";
            int userID = -1;
            int stationID = -1;
            int sideID = -1;
            string? workInstruction = "";
            int partQuantity = -1;
            bool missingPart = false;
            string? issue = "";
            DateTime? openedOn = DateTime.MinValue;
            int closedByUser = -1;
            int closedOnStation = -1;
            int closedQuantity = -1;
            string? closedComments = "";
            string? fixType = "";
            DateTime? closedOn = DateTime.MinValue;
            if (!reader.IsDBNull(0))
            {
                partID = reader.GetString(0);
            }
            if (!reader.IsDBNull(1))
            {
                VIN = reader.GetString(1);
            }
            if (!reader.IsDBNull(2))
            {
                userID = reader.GetInt32(2);
            }
            if (!reader.IsDBNull(3))
            {
                stationID = reader.GetInt32(3);
            }
            if (!reader.IsDBNull(4))
            {
                sideID = reader.GetInt32(4);
            }
            if (!reader.IsDBNull(5))
            {
                workInstruction = reader.GetString(5);
            }
            if (!reader.IsDBNull(6))
            {
                partQuantity = reader.GetInt32(6);
            }
            if (!reader.IsDBNull(7))
            {
                missingPart = reader.GetBoolean(7);
            }
            if (!reader.IsDBNull(8))
            {
                issue = reader.GetString(8);
            }
            if (!reader.IsDBNull(9))
            {
                openedOn = reader.GetDateTime(9);
            }
            if (!reader.IsDBNull(10))
            {
                closedByUser = reader.GetInt32(10);
            }
            if (!reader.IsDBNull(11))
            {
                closedOnStation = reader.GetInt32(11);
            }
            if (!reader.IsDBNull(12))
            {
                closedQuantity = reader.GetInt32(12);
            }
            if (!reader.IsDBNull(13))
            {
                closedComments = reader.GetString(13);
            }
            if (!reader.IsDBNull(14))
            {
                fixType = reader.GetString(14);
            }
            if (!reader.IsDBNull(15))
            {
                closedOn = reader.GetDateTime(15);
            }
            return new Problem(partID, VIN, userID,
                stationID, sideID, workInstruction, partQuantity,
                missingPart, issue, openedOn, closedByUser,
                closedOnStation, closedQuantity, closedComments,
                fixType, closedOn);
        }

        public List<Problem> selectAllProblems()
        {
            List<Problem> problems = new List<Problem>();
            SqlConnection cnn = connectToDB();
            cnn.Open();
            SqlCommand command;
            SqlDataReader reader;
            string query = "SELECT * FROM problems";
            command = new SqlCommand(query, cnn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                problems.Add(GetProblemFromReader(reader));
                //string? partID = "";
                //string? VIN = "";
                //int userID = -1;
                //int stationID = -1;
                //int sideID = -1;
                //string? workInstruction = "";
                //int partQuantity = -1;
                //bool missingPart = false;
                //string? issue = "";
                //DateTime? openedOn = DateTime.MinValue;
                //int closedByUser = -1;
                //int closedOnStation = -1;
                //int closedQuantity = -1;
                //string? closedComments = "";
                //string? fixType = "";
                //DateTime? closedOn = DateTime.MinValue;
                //if (!reader.IsDBNull(0))
                //{
                //    partID = reader.GetString(0);
                //}
                //if (!reader.IsDBNull(1))
                //{
                //    VIN = reader.GetString(1);
                //}
                //if (!reader.IsDBNull(2))
                //{
                //    userID = reader.GetInt32(2);
                //}
                //if (!reader.IsDBNull(3))
                //{
                //    stationID = reader.GetInt32(3);
                //}
                //if (!reader.IsDBNull(4))
                //{
                //    sideID = reader.GetInt32(4);
                //}
                //if (!reader.IsDBNull(5))
                //{
                //    workInstruction = reader.GetString(5);
                //}
                //if (!reader.IsDBNull(6))
                //{
                //    partQuantity = reader.GetInt32(6);
                //}
                //if (!reader.IsDBNull(7))
                //{
                //    missingPart = reader.GetBoolean(7);
                //}
                //if (!reader.IsDBNull(8))
                //{
                //    issue = reader.GetString(8);
                //}
                //if (!reader.IsDBNull(9))
                //{
                //    openedOn = reader.GetDateTime(9);
                //}
                //if (!reader.IsDBNull(10))
                //{
                //    closedByUser = reader.GetInt32(10);
                //}
                //if (!reader.IsDBNull(11))
                //{
                //    closedOnStation = reader.GetInt32(11);
                //}
                //if (!reader.IsDBNull(12))
                //{
                //    closedQuantity = reader.GetInt32(12);
                //}
                //if (!reader.IsDBNull(13))
                //{
                //    closedComments = reader.GetString(13);
                //}
                //if (!reader.IsDBNull(14))
                //{
                //    fixType = reader.GetString(14);
                //}
                //if (!reader.IsDBNull(15))
                //{
                //    closedOn = reader.GetDateTime(15);
                //}
                //problems.Add(new Problem(partID, VIN, userID,
                //    stationID, sideID, workInstruction, partQuantity,
                //    missingPart, issue, openedOn, closedByUser,
                //    closedOnStation, closedQuantity, closedComments,
                //    fixType, closedOn));
            }
            cnn.Close();
            return problems;
        }
    }
}
