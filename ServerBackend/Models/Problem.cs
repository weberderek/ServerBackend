namespace ServerBackend.Models
{
    public class Problem : IModel
    {
        public Problem() { }
        public Problem(string? partID, string? VIN, int userID, int stationID, 
            int sideID, string? workInstruction, int partQuantity, 
            bool missingPart, string? issue, DateTime? openedOn, 
            int closedByUser, int closedOnStation, int closedQuantity, 
            string? closedComments, string? fixType, DateTime? closedOn)
        {
            this.partID = partID;
            this.VIN = VIN;
            this.userID = userID;
            this.stationID = stationID;
            this.sideID = sideID;
            this.workInstruction = workInstruction;
            this.partQuantity = partQuantity;
            this.missingPart = missingPart;
            this.issue = issue;
            this.openedOn = openedOn;
            this.closedByUser = closedByUser;
            this.closedOnStation = closedOnStation;
            this.closedQuantity = closedQuantity;
            this.closedComments = closedComments;
            this.fixType = fixType;
            this.closedOn = closedOn;
        }

        public string? partID { get; set; }
        public string? VIN { get; set; }
        public int userID { get; set; }
        public int stationID { get; set; }
        public int sideID { get; set; }
        public string? workInstruction { get; set; }
        public int partQuantity { get; set; }
        public bool missingPart { get; set; }
        public string? issue { get; set; }
        public DateTime? openedOn { get; set; }
        public int closedByUser { get; set; }
        public int closedOnStation { get; set; }
        public int closedQuantity { get; set; }
        public string? closedComments { get; set; }
        public string? fixType { get; set; }
        public DateTime? closedOn { get; set; }

        override public string ToString()
        {
            return partID + ' ' + VIN + ' ' + userID + ' ' + stationID + ' ' + sideID + ' ' + workInstruction + ' ' + partQuantity + ' ' + missingPart + ' ' + 
                issue + ' ' + openedOn + ' ' + closedByUser + ' ' + closedOnStation + ' ' + closedQuantity + ' ' + closedComments + ' ' + fixType + ' ' + closedOn;
        }
    }
}
