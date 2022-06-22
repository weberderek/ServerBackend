namespace ServerBackend.Models
{
    public class Vin : IModel
    {
        public Vin(string vin, string workOrder, string model)
        {
            this.vin = vin;
            this.workOrder = workOrder;
            this.model = model;
        }

        public string vin { get; set; }
        public string workOrder { get; set; }
        public string model { get; set; }
    }
}
