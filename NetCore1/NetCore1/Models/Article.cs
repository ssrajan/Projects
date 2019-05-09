using System;

namespace NetCore1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Content { get; set; }

    }
}