using Aspose.OCR;
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
            var result = api.RecognizeImage("table.png", new RecognitionSettings { DetectAreasMode = DetectAreasMode.PHOTO});
         
            Console.ResetColor();
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"\nText: {result.RecognitionText}");
            Console.WriteLine($"\nSkew: {result.Skew}");
            result.Save("result.xlsx", SaveFormat.Xlsx);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over. The result XLSX file is in the application folder.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

