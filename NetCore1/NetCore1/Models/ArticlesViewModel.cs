using System.Collections.Generic;

namespace NetCore1.Models
{
    public class ArticlesViewModel
    {
        public List<Article> Articles { get; set; }

        public ArticlesViewModel()
        {
            Articles = new List<Article>();
        }
        
    }
}
