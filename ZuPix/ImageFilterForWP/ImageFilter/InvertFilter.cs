﻿

namespace ZuPix.ImageFilter
{
    public class InvertFilter : IImageFilter
    {
        public string Name { get { return "Invert"; } }
        public CustomImage process(CustomImage imageIn)
        {
            int r, g, b;
            for (int x = 0; x < imageIn.getWidth(); x++)
            {
                for (int y = 0; y < imageIn.getHeight(); y++)
                {
                    r = (255 - imageIn.getRComponent(x, y));
                    g = (255 - imageIn.getGComponent(x, y));
                    b = (255 - imageIn.getBComponent(x, y));
                    imageIn.setPixelColor(x, y, r, g, b);
                }
            }
            return imageIn;
        }
    }
}
