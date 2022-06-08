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
            var res = api.RecognizeTiff("three_page.tif", new DocumentRecognitionSettings(0, 3));


            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine($"PAGE {i + 1}  skew {res[i].Skew}");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(res[i].RecognitionText);
                Console.WriteLine("------------------------------------------------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

