The source image: test.pdf
The source code:

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

