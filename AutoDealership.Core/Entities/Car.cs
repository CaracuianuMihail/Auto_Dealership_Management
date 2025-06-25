namespace AutoDealership.Core.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public override string ToString()
        {
            return $"{Make} {Model} ({Year}) - {Price:C}";
        }
        public string ImagePath { get; set; }  
    }
}
