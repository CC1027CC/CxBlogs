using CxBlogs.Core.Framework;

namespace CxBlogs.Core.Models
{
    /// <summary>
    /// 博客实体
    /// </summary>
    public class Blog: FullEntity<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

    }
}
