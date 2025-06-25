namespace AutoDealership.Core.Entities
{
    public class CustomCar
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Kilometers { get; set; }
        public bool IsElectric { get; set; }
        public string Color { get; set; }
        public string InteriorType { get; set; }
        public string TransmissionType { get; set; }  
        public bool HasSunroof { get; set; }          
        public string WheelType { get; set; }         
        public string InfotainmentSystem { get; set; }  
        public string AdditionalNotes { get; set; }   

        public CustomCar Clone()
        {
            return (CustomCar)this.MemberwiseClone(); // PROTOTYPE
        }
    }
}
