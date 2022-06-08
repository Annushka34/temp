using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;
using System;
using System.IO;

namespace RecognizePNG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This example will work without a license. The result will be reduced.\n");
            Console.WriteLine("Recognition has begun. Please, wait...\n\n");

            AsposeOcr api = new AsposeOcr();

            string uri = "https://i.stack.imgur.com/0Jl54.png";
            Console.Write($"TEST URI:  ");
            Console.ResetColor();
            Console.WriteLine($" {uri}");
            var res = api.RecognizeImageFromUri(uri, new RecognitionSettings());
            Console.WriteLine("\nRESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            ConsoleLogRecognitionResult(res);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();

            Console.WriteLine("\nNow you can enter your own link for recognition:");
            string ownUri = Console.ReadLine();
            res = api.RecognizeImageFromUri(ownUri, new RecognitionSettings());
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            ConsoleLogRecognitionResult(res);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }

        static void ConsoleLogRecognitionResult(RecognitionResult result)
        {
            Console.WriteLine($"\nSkew: {result.Skew}");          
            Console.WriteLine($"{result.RecognitionText}");
        }
    }
}

