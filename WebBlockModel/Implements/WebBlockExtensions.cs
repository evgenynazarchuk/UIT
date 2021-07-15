using System;

namespace WebBlockModel
{
    public static class WebBlockExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="CurrentWebBlock"></typeparam>
        /// <param name="webBlock"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static CurrentWebBlock Assert<CurrentWebBlock>(this CurrentWebBlock webBlock,
            Action<CurrentWebBlock> action)
            where CurrentWebBlock : WebBlock
        {
            action(webBlock);
            return webBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="CurrentWebBlock"></typeparam>
        /// <param name="webBlock"></param>
        /// <returns></returns>
        public static CurrentWebBlock SetCurrentBlock<CurrentWebBlock>(this CurrentWebBlock webBlock)
            where CurrentWebBlock : WebBlock
        {
            return webBlock;
        }
    }
}
