using System;
using System.Collections.Generic;

namespace Task.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }
        public string Quote { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
