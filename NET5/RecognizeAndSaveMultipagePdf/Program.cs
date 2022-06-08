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
            var res = api.RecognizePdf("test.pdf", new DocumentRecognitionSettings(0,2));
            

            Console.WriteLine("RESULT");
            Console.ResetColor();
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine($"PAGE {i+1}\n------------------------------------------------------------");
                Console.WriteLine(res[i].RecognitionText);
            }

            AsposeOcr.SaveMultipageDocument("result.pdf", SaveFormat.Pdf, res);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over. The result Searchable PDF is in the application folder.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

