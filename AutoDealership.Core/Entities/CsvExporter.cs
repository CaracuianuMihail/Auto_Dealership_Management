using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoDealership.Core.Entities;

public class CsvExporter
{
    public void WriteToCsv(List<CarExportModel> cars, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Make,Model,Color,Year,Price,Kilometers,IsAvailable,ImagePath");

            foreach (var car in cars)
            {
                writer.WriteLine($"{car.Make},{car.Model},{car.Color},{car.Year},{car.Price},{car.Kilometers},{car.IsAvailable},{car.ImagePath}");
            }
        }
    }
}
