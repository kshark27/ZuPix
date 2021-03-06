﻿
namespace ZuPix.ImageFilter
{
    public class BlockPrintFilter : IImageFilter
    {
        public string Name { get { return "Block Print"; } }
        //@Override
        public CustomImage process(CustomImage imageIn)
        {
            ParamEdgeDetectFilter pde = new ParamEdgeDetectFilter();
            pde.K00 = 1;
            pde.K01 = 2;
            pde.K02 = 1;
            pde.Threshold = 0.25f;
            pde.DoGrayConversion = false;
            ImageBlender ib = new ImageBlender();
            ib.Mode = (int)BlendMode.Multiply;
            return ib.Blend(imageIn.clone(), pde.process(imageIn));
        }
    }

}
