using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class PixelCalc
    {
        public static string CalcPixel(int width, int height, int diagonal)
        {
            string output;

            if (width <= 0 || height <= 0 || diagonal <= 0)
            {
                output = "At least one of your input is negative or zero. Please enter positive integers.";
                return output;
            }

            double ppi = Math.Sqrt(width * width + height * height) / diagonal;
            double diagonalPixels = Math.Sqrt(width * width + height * height);
            double dotPitch = diagonal / diagonalPixels;

            output = ($"PPI: {ppi:F2}\nDiagonal (in pixels): {diagonalPixels:F2}\nDot pitch: {dotPitch:F4} inches");

            return output;
        }
    }
}
