using System.Collections.Generic;
using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface ICarExporter
    {
        void ExportCars(List<CarExportModel> cars, string filePath);
    }
}