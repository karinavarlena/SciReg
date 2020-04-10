
using System;

namespace SciReg.Models
{
    public class Article
    {
        public DateTime ReleaseDate { get; set; }
        public String Title { get; set; }
        public Subject ArticleSubject { get; set; }
        public ContentType ArticleContentType { get; set; }
        public DateTime SubmitDate { get; set; }
        public String ISSN { get; set; }
        public Language ArticleLanguage { get; set; }
        public String Text { get; set; }
        public ApplicationUser Publisher { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
