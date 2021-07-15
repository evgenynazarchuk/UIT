using System;

namespace WebComponentModel
{
    public static class WebBlockExtensions
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
