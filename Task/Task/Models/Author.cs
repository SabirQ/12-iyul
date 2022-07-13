using System.Collections.Generic;

namespace Task.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }

        public string FbUrl { get; set; }
        public string TwUrl { get; set; }
        public string InsUrl { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
