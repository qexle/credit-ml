//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Col0 = 1F,
                Reports = 0F,
                Age = 37.66667F,
                Income = 4.52F,
                Share = 0.03326991F,
                Expenditure = 124.9833F,
                Owner = true,
                Selfemp = false,
                Dependents = 3F,
                Months = 54F,
                Majorcards = 1F,
                Active = 12F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Card with predicted Card from sample data...\n\n");
            Console.WriteLine($"Col0: {sampleData.Col0}");
            Console.WriteLine($"Reports: {sampleData.Reports}");
            Console.WriteLine($"Age: {sampleData.Age}");
            Console.WriteLine($"Income: {sampleData.Income}");
            Console.WriteLine($"Share: {sampleData.Share}");
            Console.WriteLine($"Expenditure: {sampleData.Expenditure}");
            Console.WriteLine($"Owner: {sampleData.Owner}");
            Console.WriteLine($"Selfemp: {sampleData.Selfemp}");
            Console.WriteLine($"Dependents: {sampleData.Dependents}");
            Console.WriteLine($"Months: {sampleData.Months}");
            Console.WriteLine($"Majorcards: {sampleData.Majorcards}");
            Console.WriteLine($"Active: {sampleData.Active}");
            Console.WriteLine($"\n\nPredicted Card value {predictionResult.Prediction} \nPredicted Card scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
