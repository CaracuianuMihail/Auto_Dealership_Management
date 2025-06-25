using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface ICustomCarBuilder
    {
        void SetMake(string make);
        void SetModel(string model);
        void SetYear(int year);
        void SetPrice(decimal price);
        void SetKilometers(int kilometers);
        void SetIsElectric(bool isElectric);
        void SetColor(string color);
        void SetInteriorType(string interiorType);
        void SetTransmissionType(string transmissionType);
        void SetHasSunroof(bool hasSunroof);
        void SetWheelType(string wheelType);
        void SetInfotainmentSystem(string infotainmentSystem);
        void SetAdditionalNotes(string notes);
        CustomCar Build();
    }
}
