namespace AutoDealership.Core.Entities
{
    public class CarExportModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Kilometers { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }
    }
}
