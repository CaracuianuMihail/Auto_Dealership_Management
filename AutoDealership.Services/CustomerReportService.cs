using System;
using System.Collections.Generic;
using System.IO;
using AutoDealership.Core.Entities;
public class CustomerReportManager
{
    private static CustomerReportManager _instance;

    private readonly string _reportFilePath;

    // Constructor privat pentru a preveni instanțierea directă
    private CustomerReportManager()
    {
        _reportFilePath = "D:\\UTM\\Anul III\\SEM2\\TMPP\\CustomerReport.txt";  // Calea fișierului de raport
    }

    // Metoda pentru obținerea instanței unice
    public static CustomerReportManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new CustomerReportManager();
        }
        return _instance;
    }

    // Metodă pentru generarea raportului cu toți clienții
    public void GenerateCustomerReport(List<Customer> customers)
    {
        string report = "Customer Report\n";
        report += "Customer ID | Name | Email | Phone Number\n";
        report += new string('-', 50);

        // Adăugăm informațiile despre clienți în raport
        foreach (var customer in customers)
        {
            report += $"\n{customer.Id} | {customer.FullName} | {customer.Email} | {customer.PhoneNumber}";
        }

        // Salvăm raportul într-un fișier text
        File.WriteAllText(_reportFilePath, report);
        Console.WriteLine("Customer report has been generated.");
    }

    // Metodă pentru a deschide raportul salvat
    public void OpenReport()
    {
        if (File.Exists(_reportFilePath))
        {
            string report = File.ReadAllText(_reportFilePath);
            Console.WriteLine("Generated Report:\n" + report);
        }
        else
        {
            Console.WriteLine("No report generated yet.");
        }
    }
}
