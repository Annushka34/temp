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
            var res = api.RecognizeImage("test.png", new RecognitionSettings());


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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nText:");
            Console.ResetColor();
            Console.WriteLine(result.RecognitionText);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nSkew:");
            Console.ResetColor();
            Console.WriteLine($"{result.Skew}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAreas coordinates:");
            Console.ResetColor();
            result.RecognitionAreasRectangles.ForEach(a => Console.WriteLine($"x: {a.X} y: {a.Y} width: {a.Width} height: {a.Height}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAreas text:");
            Console.ResetColor();
            result.RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nLines:");
            Console.ResetColor();
            result.RecognitionLinesResult.ForEach(a => Console.WriteLine($"x: {a.Line.X} y: {a.Line.Y} width: {a.Line.Width} height: {a.Line.Height}\n{a.TextInLine}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWarnings:");
            Console.ResetColor();
            result.Warnings.ForEach(w => Console.WriteLine($"{w}"));
        }
    }
}

