The source image: test.png
The source code:

            AsposeOcr api = new AsposeOcr();
            var result = api.GetRectangles("test.png");

            Console.WriteLine("AREAS RECTANGLES COORDINATES:");
            Console.WriteLine("RESULT");

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"X: {result[i].X} Y: {result[i].Y} Width: {result[i].Width} Height: {result[i].Height}");    
            }

