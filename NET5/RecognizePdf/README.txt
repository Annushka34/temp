The source images: three_page.tif
The source code:

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

