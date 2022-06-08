The source images: test.jpg
The source code:

            AsposeOcr api = new AsposeOcr();
            var memoryStream = api.PreprocessImage("test.jpg", new Aspose.OCR.Models.PreprocessingFilters.PreprocessingFilter { PreprocessingFilter.ContrastCorrectionFilter()});
            FileStream fs = new FileStream("corrected.jpg", FileMode.OpenOrCreate);
            memoryStream.WriteTo(fs);
            fs.Close();
            memoryStream.Close();

