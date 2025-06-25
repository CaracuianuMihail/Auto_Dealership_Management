using System.Collections.Generic;
using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
public class CarCsvAdapter : ICarExporter
{
    private readonly CsvExporter _csvExporter;

    public CarCsvAdapter(CsvExporter csvExporter)
    {
        _csvExporter = csvExporter;
    }

    public void ExportCars(List<CarExportModel> cars, string filePath)
    {
        _csvExporter.WriteToCsv(cars, filePath); 
    }
    void ICarExporter.ExportCars(List<Car> cars, string filePath)
    {
        throw new System.NotImplementedException();
    }
}
