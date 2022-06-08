The source images: test1.jpg test2.png test3.png
The source code:

            AsposeOcr api = new AsposeOcr();
            var result = api.CalculateSkew("test1.jpg");
            Console.WriteLine("RESULT");

            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE 1:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test2.png");
            Console.WriteLine("\nSKEW IMAGE 2:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test3.png");
            Console.WriteLine("\nSKEW IMAGE 3:");
            Console.WriteLine(result);

