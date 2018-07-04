using CxBlogs.Core.Framework;

namespace CxBlogs.Core.Models
{
    public class User:FullEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
