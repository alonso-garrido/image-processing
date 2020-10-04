using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace image_processing
{
    class Processing
    {
        public Processing()
        {

        }
        public static bool ConvertToGray (Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    int gray = (byte)((r+g+b)/3);
                    r = gray;
                    g = gray;
                    b = gray;
                        
                    image.SetPixel (i, j, Color.FromArgb(r, g, b));
                }
            }
            return true;
        }
    }
}
