using System;
using System.Collections.Generic;
using System.Linq;
using NetCore1.Models;

namespace NetCore1
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "Sapiens",
                Author = "Someone",
                Content = "lljksf lksldkjejj sdljdlfkjsdlk   sklkiekk;ere"

            }
        };

        public List<Article> GetLatest()
        {
            return articles;
        }

    }
}
