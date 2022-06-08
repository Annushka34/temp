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
            var memoryStream = api.PreprocessImage("test.jpg", new Aspose.OCR.Models.PreprocessingFilters.PreprocessingFilter { PreprocessingFilter.ContrastCorrectionFilter()});
            FileStream fs = new FileStream("corrected.jpg", FileMode.OpenOrCreate);
            memoryStream.WriteTo(fs);
            fs.Close();
            memoryStream.Close();
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The preprocessed image was saved by the name corrected.jpg. Check the folder.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Preprocessing is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

