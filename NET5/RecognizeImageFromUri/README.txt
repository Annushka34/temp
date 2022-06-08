The source code:

        AsposeOcr api = new AsposeOcr();

        string uri = "https://i.stack.imgur.com/0Jl54.png";
        var res = api.RecognizeImageFromUri(uri, new RecognitionSettings());
        ConsoleLogRecognitionResult(res);

        Console.WriteLine("\nNow you can enter your own link for recognition:");
        string ownUri = Console.ReadLine();
        res = api.RecognizeImageFromUri(ownUri, new RecognitionSettings());
        ConsoleLogRecognitionResult(res);

        static void ConsoleLogRecognitionResult(RecognitionResult result)
        {
            Console.WriteLine($"\nSkew: {result.Skew}");          
            Console.WriteLine($"{result.RecognitionText}");
        }

