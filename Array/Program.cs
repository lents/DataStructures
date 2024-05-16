using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Load the image file into a byte array
        string imagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "1.png");
        byte[] imageBytes = File.ReadAllBytes(imagePath);

        // Apply a grayscale filter to the image bytes
        ApplyGrayscaleFilter(imageBytes);

        // Save the modified byte array as a new image file
        string outputImagePath = "output_image.jpg";
        File.WriteAllBytes(outputImagePath, imageBytes);

        Console.WriteLine("Image processing complete. Output saved as output_image.jpg");
    }

    static void ApplyGrayscaleFilter(byte[] imageBytes)
    {
        // Convert the byte array to a Bitmap object
        using (MemoryStream memoryStream = new MemoryStream(imageBytes))
        using (var bitmap = new Bitmap(memoryStream, true))
        {
            // Loop through each pixel in the image
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    // Get the pixel color at the current position
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Calculate the grayscale value (average of R, G, and B)
                   // byte grayscaleValue = (byte)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(pixelColor.A, grayScale, grayScale, grayScale);

                    //var newColor = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                    // Set the pixel color to grayscale
                    bitmap.SetPixel(x, y, newColor);
                }
            }

           string outputImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "output_image.png");
           bitmap.Save(outputImagePath);
              
        }
    }
}
