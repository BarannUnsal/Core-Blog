using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; } 
        public DateTime BlogCreateDate { get; set; } 
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category{ get; set; }
        public int WriterID { get; set; }
        public Writer Writer{ get; set; }
        public List<Comment> Comment{ get; set; }
    }
}
