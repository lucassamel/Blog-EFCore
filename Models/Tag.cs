using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public int CategoriId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Sumary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
