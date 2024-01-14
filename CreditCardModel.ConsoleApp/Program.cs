//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using CreditCardModel.Model;
using Spectre.Console;

namespace CreditCardModel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Write(new FigletText("Welcome !").Centered().Color(Color.Blue));

            var msg = AnsiConsole.Ask<string>("[green]Hello! User type your query? :[/] \n\n");

            do
            {
                //if (msg == "retrain")
                //{
                //    ConsumeModel.RetrainModel("/Users/suren/Desktop/Code/Output/mlApp");
                //}

                // Create single instance of sample data from first line of dataset for model input
                ModelInput sampleData = new ModelInput()
                {
                    Col0 = msg,
                };

                // Make a single prediction on the sample data and print results
                var predictionResult = ConsumeModel.Predict(sampleData);


                Console.WriteLine($"\n\nPredicted value :: {predictionResult.Prediction} \n\n");
                Console.WriteLine("===================== End of prediction =====================");


                msg = AnsiConsole.Ask<string>("[green]User type your query? :[/] ");

            } while (msg != "bye");
        }
    }
}
