using System.Collections.Generic;
using Task.Models;

namespace Task.ViewModels
{
    public class HomeVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
