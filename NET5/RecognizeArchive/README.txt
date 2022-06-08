The source images: test.zip
The source code:

           AsposeOcr api = new AsposeOcr();
            var res = api.RecognizeMultipleImages("test.zip", new RecognitionSettings());


            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"IMAGE {i + 1}\n------------------------------");
                Console.WriteLine(res[i].RecognitionText);
            }
