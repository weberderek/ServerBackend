using ServerBackend.Models;
using System.Data.OleDb;

namespace ServerBackend.DAOs
{
    public class ResultDAOAccess : IResultDAO
    {
        private OleDbConnection connectToDB()
        {
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\derek.weber\\Downloads\\result.mdb");
        }

        public Result getResultFromReader(OleDbDataReader reader)
        {
            int ID;
            string Vin_Number;
            string Date;
            string StartTime;
            string UnitToe;
            string UnitSWB;
            string Relation;
            double F1_ToeL;
            double F1_ToeR;
            double F1_TotalToe;
            double F1_TotalToeNom;
            double F1_TotalToeMax;
            double F1_TotalToeMin;
            string F1_TotalToeValStr;
            double F1_DriveAngle;
            string F1_DriveAngleValStr;
            double F2_ToeL;
            double F2_ToeR;
            double F2_TotalToe;
            double F2_TotalToeNom;
            double F2_TotalToeMax;
            double F2_TotalToeMin;
            string F2_TotalToeValStr;
            double F2_DriveAngle;
            string F2_DriveAngleValStr;
            int SteeringAngleStraightOn;
            string SteeringAngleStraightOnValStr;
            double SWBAngle;
            string SWBAngleValStr;
            double SteeringColumnPitchAngle;
            double SteeringColumnPitchAngleMax;
            double SteeringColumnPitchAngleMin;
            string SteeringColumnPitchAngleValStr;
            double D1_ToeL;
            double D1_ToeR;
            double D1_TotalToe;
            double D1_TotalToeNom;
            double D1_TotalToeMax;
            double D1_TotalToeMin;
            string D1_TotalToeValStr;
            double D1_DriveAngle;
            string D1_DriveAngleValStr;
            double D2_ToeL;
            double D2_ToeR;
            double D2_TotalToe;
            double D2_TotalToeNom;
            double D2_TotalToeMax;
            double D2_TotalToeMin;
            string D2_TotalToeValStr;
            double D2_DriveAngle;
            string D2_DriveAngleValStr;
            double CrabAngle;
            int CrabAngleNom;
            string CrabAngleValStr;
            double Symmetrie;
            int DriveVector;
            if (!reader.IsDBNull(0))
            {
                ID = reader.GetInt32(0);
            }
            if (!reader.IsDBNull(1))
            {
                Vin_Number = reader.GetString(1);
            }
            if (!reader.IsDBNull(2))
            {
                Date = reader.GetString(2);
            }
            if (!reader.IsDBNull(3))
            {
                StartTime = reader.GetString(3);
            }
            if (!reader.IsDBNull(4))
            {
                UnitToe = reader.GetString(4);
            }
            if (!reader.IsDBNull(5))
            {
                UnitSWB = reader.GetString(5);
            }
            if (!reader.IsDBNull(6))
            {
                Relation = reader.GetString(6);
            }
            if (!reader.IsDBNull(7))
            {
                F1_ToeL = reader.GetDouble(7);
            }
            if (!reader.IsDBNull(8))
            {
                F1_ToeR = reader.GetDouble(8);
            }
            if (!reader.IsDBNull(9))
            {
                F1_TotalToe = reader.GetDouble(9);
            }
            if (!reader.IsDBNull(10))
            {
                F1_TotalToeNom = reader.GetDouble(10);
            }
            if (!reader.IsDBNull(11))
            {
                F1_TotalToeMax = reader.GetDouble(11);
            }
            if (!reader.IsDBNull(12))
            {
                F1_TotalToeMin = reader.GetDouble(12);
            }
            if (!reader.IsDBNull(13))
            {
                F1_TotalToeValStr = reader.GetString(13);
            }
            if (!reader.IsDBNull(14))
            {
                F1_DriveAngle = reader.GetDouble(14);
            }
            if (!reader.IsDBNull(15))
            {
                F1_DriveAngleValStr = reader.GetString(15);
            }
            if (!reader.IsDBNull(16))
            {
                F2_ToeL = reader.GetDouble(16);
            }
            if (!reader.IsDBNull(17))
            {
                F2_ToeR = reader.GetDouble(17);
            }
            if (!reader.IsDBNull(18))
            {
                F2_TotalToe = reader.GetDouble(18);
            }
            if (!reader.IsDBNull(19))
            {
                F2_TotalToeNom = reader.GetDouble(19);
            }
            if (!reader.IsDBNull(20))
            {
                F2_TotalToeMax = reader.GetDouble(20);
            }
            if (!reader.IsDBNull(21))
            {
                F2_TotalToeMin = reader.GetDouble(21);
            }
            if (!reader.IsDBNull(22))
            {
                F2_TotalToeValStr = reader.GetString(22);
            }
            if (reader.IsDBNull(23))
            {
                F2_DriveAngle = reader.GetInt32(23);
            }
            if (!reader.IsDBNull(24))
            {
                F2_DriveAngleValStr = reader.GetString(24);
            }
            if (!reader.IsDBNull(25))
            {
                SteeringAngleStraightOn = reader.GetInt32(25);
            }
            if (!reader.IsDBNull(26))
            {
                SteeringAngleStraightOnValStr = reader.GetString(26);
            }
            if (!reader.IsDBNull(27))
            {
                SWBAngle = reader.GetDouble(27);
            }
            if (!reader.IsDBNull(28))
            {
                SWBAngleValStr = reader.GetString(28);
            }
            if (!reader.IsDBNull(29))
            {
                SteeringColumnPitchAngle = reader.GetDouble(29);
            }
            if (!reader.IsDBNull(30))
            {
                SteeringColumnPitchAngleMax = reader.GetDouble(30);
            }
            if (!reader.IsDBNull(31))
            {
                SteeringColumnPitchAngleMin = reader.GetDouble(31);
            }
            if (!reader.IsDBNull(32))
            {
                SteeringColumnPitchAngleValStr = reader.GetString(32);
            }
            if (!reader.IsDBNull(33))
            {
                D1_ToeL = reader.GetDouble(33);
            }
            if (!reader.IsDBNull(34))
            {
                D1_ToeR = reader.GetDouble(34);
            }
            if (!reader.IsDBNull(35))
            {
                D1_TotalToe = reader.GetDouble(35);
            }
            if (!reader.IsDBNull(36))
            {
                D1_TotalToeNom = reader.GetDouble(36);
            }
            if (!reader.IsDBNull(37))
            {
                D1_TotalToeMax = reader.GetDouble(37);
            }
            if (!reader.IsDBNull(38))
            {
                D1_TotalToeMin = reader.GetDouble(38);
            }
            if (!reader.IsDBNull(39))
            {
                D1_TotalToeValStr = reader.GetString(39);
            }
            if (!reader.IsDBNull(40))
            {
                D1_DriveAngle = reader.GetDouble(40);
            }
            if (!reader.IsDBNull(41))
            {
                D1_DriveAngleValStr = reader.GetString(41);
            }
            if (!reader.IsDBNull(42))
            {
                D2_ToeL = reader.GetDouble(42);
            }
            if (!reader.IsDBNull(43))
            {
                D2_ToeR = reader.GetDouble(43);
            }
            if (!reader.IsDBNull(44))
            {
                D2_TotalToe = reader.GetDouble(44);
            }
            if (!reader.IsDBNull(45))
            {
                D2_TotalToeNom = reader.GetDouble(45);
            }
            if (!reader.IsDBNull(46))
            {
                D2_TotalToeMax = reader.GetDouble(46);
            }
            if (!reader.IsDBNull(47))
            {
                D2_TotalToeMin = reader.GetDouble(47);
            }
            if (!reader.IsDBNull(48))
            {
                D2_TotalToeValStr = reader.GetString(48);
            }
            if (!reader.IsDBNull(49))
            {
                D2_DriveAngle = reader.GetDouble(49);
            }
            if (!reader.IsDBNull(50))
            {
                D2_DriveAngleValStr = reader.GetString(50);
            }
            if (!reader.IsDBNull(51))
            {
                CrabAngle = reader.GetDouble(51);
            }
            if (!reader.IsDBNull(52))
            {
                CrabAngleNom = reader.GetInt32(52);
            }
            if (!reader.IsDBNull(53))
            {
                CrabAngleValStr = reader.GetString(53);
            }
            if (!reader.IsDBNull(54))
            {
                Symmetrie = reader.GetDouble(54);
            }
            if (!reader.IsDBNull(55))
            {
                DriveVector = reader.GetInt32(55);
            }
        }
        public List<Result> selectAllResults()
        {
            List<Result> results = new List<Result>();
            OleDbConnection cnn = connectToDB();
            string sql = "SELECT * FROM Result_ToeFirst";

            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            cnn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                results.Add(getResultFromReader(reader));
            }
            cnn.Close();
            return results;
        }
    }
}
