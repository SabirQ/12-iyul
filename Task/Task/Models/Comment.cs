using System;

namespace Task.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Article { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
