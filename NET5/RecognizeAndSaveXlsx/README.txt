The source images: table.png
The source code:

            AsposeOcr api = new AsposeOcr();
            var result = api.RecognizeImage("table.png", new RecognitionSettings { DetectAreasMode = DetectAreasMode.PHOTO});         

            Console.WriteLine($"\nText: {result.RecognitionText}");
            Console.WriteLine($"\nSkew: {result.Skew}");
            result.Save("result.xlsx", SaveFormat.Xlsx);