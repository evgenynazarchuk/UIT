using System;

namespace WebComponentModel.Implements
{
    public static class WebBlockExt
    {
        public static CurrentWebBlock Assert<CurrentWebBlock>(this CurrentWebBlock webBlock,
            Action<CurrentWebBlock> action)
            where CurrentWebBlock : WebBlock
        {
            action(webBlock);
            return webBlock;
        }

        public static CurrentWebBlock StayHere<CurrentWebBlock>(this CurrentWebBlock webBlock)
            where CurrentWebBlock : WebBlock
        {
            return webBlock;
        }
    }
}
