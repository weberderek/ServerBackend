namespace ServerBackend.Models
{
    public class Result : IModel
    {
        public Result() { }
        public Result(int iD, string vin_Number, string date, string startTime, string unitToe, string unitSWB, string relation, double f1_ToeL, double f1_ToeR, double f1_TotalToe, double f1_TotalToeNom, double f1_TotalToeMax, double f1_TotalToeMin, string f1_TotalToeValStr, double f1_DriveAngle, string f1_DriveAngleValStr, double f2_ToeL, double f2_ToeR, double f2_TotalToe, double f2_TotalToeNom, double f2_TotalToeMax, double f2_TotalToeMin, string f2_TotalToeValStr, double f2_DriveAngle, string f2_DriveAngleValStr, int steeringAngleStraightOn, string steeringAngleStraightOnValStr, double sWBAngle, string sWBAngleValStr, double steeringColumnPitchAngle, double steeringColumnPitchAngleMax, double steeringColumnPitchAngleMin, string steeringColumnPitchAngleValStr, double d1_ToeL, double d1_ToeR, double d1_TotalToe, double d1_TotalToeNom, double d1_TotalToeMax, double d1_TotalToeMin, string d1_TotalToeValStr, double d1_DriveAngle, string d1_DriveAngleValStr, double d2_ToeL, double d2_ToeR, double d2_TotalToe, double d2_TotalToeNom, double d2_TotalToeMax, double d2_TotalToeMin, string d2_TotalToeValStr, double d2_DriveAngle, string d2_DriveAngleValStr, double crabAngle, int crabAngleNom, string crabAngleValStr, double symmetrie, int driveVector)
        {
            ID = iD;
            Vin_Number = vin_Number;
            Date = date;
            StartTime = startTime;
            UnitToe = unitToe;
            UnitSWB = unitSWB;
            Relation = relation;
            F1_ToeL = f1_ToeL;
            F1_ToeR = f1_ToeR;
            F1_TotalToe = f1_TotalToe;
            F1_TotalToeNom = f1_TotalToeNom;
            F1_TotalToeMax = f1_TotalToeMax;
            F1_TotalToeMin = f1_TotalToeMin;
            F1_TotalToeValStr = f1_TotalToeValStr;
            F1_DriveAngle = f1_DriveAngle;
            F1_DriveAngleValStr = f1_DriveAngleValStr;
            F2_ToeL = f2_ToeL;
            F2_ToeR = f2_ToeR;
            F2_TotalToe = f2_TotalToe;
            F2_TotalToeNom = f2_TotalToeNom;
            F2_TotalToeMax = f2_TotalToeMax;
            F2_TotalToeMin = f2_TotalToeMin;
            F2_TotalToeValStr = f2_TotalToeValStr;
            F2_DriveAngle = f2_DriveAngle;
            F2_DriveAngleValStr = f2_DriveAngleValStr;
            SteeringAngleStraightOn = steeringAngleStraightOn;
            SteeringAngleStraightOnValStr = steeringAngleStraightOnValStr;
            SWBAngle = sWBAngle;
            SWBAngleValStr = sWBAngleValStr;
            SteeringColumnPitchAngle = steeringColumnPitchAngle;
            SteeringColumnPitchAngleMax = steeringColumnPitchAngleMax;
            SteeringColumnPitchAngleMin = steeringColumnPitchAngleMin;
            SteeringColumnPitchAngleValStr = steeringColumnPitchAngleValStr;
            D1_ToeL = d1_ToeL;
            D1_ToeR = d1_ToeR;
            D1_TotalToe = d1_TotalToe;
            D1_TotalToeNom = d1_TotalToeNom;
            D1_TotalToeMax = d1_TotalToeMax;
            D1_TotalToeMin = d1_TotalToeMin;
            D1_TotalToeValStr = d1_TotalToeValStr;
            D1_DriveAngle = d1_DriveAngle;
            D1_DriveAngleValStr = d1_DriveAngleValStr;
            D2_ToeL = d2_ToeL;
            D2_ToeR = d2_ToeR;
            D2_TotalToe = d2_TotalToe;
            D2_TotalToeNom = d2_TotalToeNom;
            D2_TotalToeMax = d2_TotalToeMax;
            D2_TotalToeMin = d2_TotalToeMin;
            D2_TotalToeValStr = d2_TotalToeValStr;
            D2_DriveAngle = d2_DriveAngle;
            D2_DriveAngleValStr = d2_DriveAngleValStr;
            CrabAngle = crabAngle;
            CrabAngleNom = crabAngleNom;
            CrabAngleValStr = crabAngleValStr;
            Symmetrie = symmetrie;
            DriveVector = driveVector;
        }

        public int ID { get; set; }
        public string Vin_Number { get; set; }
        public string Date  { get; set; }
        public string StartTime { get; set; }
        public string UnitToe { get; set; }
        public string UnitSWB { get; set; }
        public string Relation { get; set; }
        public double F1_ToeL { get; set; }
        public double F1_ToeR { get; set; }
        public double F1_TotalToe { get; set; }
        public double F1_TotalToeNom { get; set; }
        public double F1_TotalToeMax { get; set; }
        public double F1_TotalToeMin { get; set; }
        public string F1_TotalToeValStr { get; set; }
        public double F1_DriveAngle { get; set; }
        public string F1_DriveAngleValStr { get; set; }
        public double F2_ToeL { get; set; }
        public double F2_ToeR { get; set; }
        public double F2_TotalToe { get; set; }
        public double F2_TotalToeNom { get; set; }
        public double F2_TotalToeMax { get; set; }
        public double F2_TotalToeMin { get; set; }
        public string F2_TotalToeValStr { get; set; }
        public double F2_DriveAngle { get; set; }
        public string F2_DriveAngleValStr { get; set; }
        public int SteeringAngleStraightOn { get; set; }
        public string SteeringAngleStraightOnValStr { get; set; }
        public double SWBAngle { get; set; }
        public string SWBAngleValStr { get; set; }
        public double SteeringColumnPitchAngle { get; set; }
        public double SteeringColumnPitchAngleMax { get; set; }
        public double SteeringColumnPitchAngleMin { get; set; }
        public string SteeringColumnPitchAngleValStr { get; set; }
        public double D1_ToeL { get; set; }
        public double D1_ToeR { get; set; }
        public double D1_TotalToe { get; set; }
        public double D1_TotalToeNom { get; set; }
        public double D1_TotalToeMax { get; set; }
        public double D1_TotalToeMin { get; set; }
        public string D1_TotalToeValStr { get; set; }
        public double D1_DriveAngle { get; set; }
        public string D1_DriveAngleValStr { get; set; }
        public double D2_ToeL { get; set; }
        public double D2_ToeR { get; set; }
        public double D2_TotalToe { get; set; }
        public double D2_TotalToeNom { get; set; }
        public double D2_TotalToeMax { get; set; }
        public double D2_TotalToeMin { get; set; }
        public string D2_TotalToeValStr { get; set; }
        public double D2_DriveAngle { get; set; }
        public string D2_DriveAngleValStr { get; set; }
        public double CrabAngle { get; set; }
        public int CrabAngleNom { get; set; }
        public string CrabAngleValStr { get; set; }
        public double Symmetrie { get; set; }
        public int DriveVector { get; set; }
    }
}
