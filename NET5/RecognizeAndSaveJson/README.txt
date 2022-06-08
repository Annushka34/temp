The source images: test.png
The source code:

            AsposeOcr api = new AsposeOcr();
            var res = api.RecognizeImage("test.png", new RecognitionSettings());
            res.Save("result.json", SaveFormat.Json);

