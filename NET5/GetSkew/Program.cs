////using Aspose.OCR;
//using System;
//using System.IO;
//using System.Reflection;

//namespace RecognizeImage
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("This example will work without a license. The result will be reduced.");
//            Console.WriteLine("Recognition has begun.");

//            Assembly ocr = Assembly.LoadFrom("data/Aspose.OCR.dll");
//            Type type = ocr.GetType("Aspose.OCR.AsposeOcr");
//            Type typeAreas = ocr.GetType("Aspose.OCR.AreasType");
//            MethodInfo methodInfo = type.GetMethod("GetRectangles", new Type[] { typeof(string), typeAreas, typeof(bool) });

//            if (methodInfo != null)
//            {
//                ParameterInfo[] parameters = methodInfo.GetParameters();
//                object classInstance = Activator.CreateInstance(type, null);
//                object areasType = Activator.CreateInstance(typeAreas, null);
//                object[] parametersArray = new object[] { "test.png", null, null };
//                object result = methodInfo.Invoke(classInstance, parametersArray);
//                Console.WriteLine(result);
//            }

//            Console.WriteLine("\nRecognition is over.\n Aspose.OCR.");
//            Console.ReadKey();
//        }
//    }
//}

using Aspose.OCR;
using System;

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
            var result = api.CalculateSkew("test1.jpg");
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE 1:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test2.png");
            Console.WriteLine("\nSKEW IMAGE 2:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test3.png");
            Console.WriteLine("\nSKEW IMAGE 3:");
            Console.WriteLine(result);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

