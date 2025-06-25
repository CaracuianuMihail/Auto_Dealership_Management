using AutoDealership.Core.Entities;
using System.Collections.Generic;

public interface ICarExporter
{
    void ExportCars(List<Car> cars, string filePath);
}
