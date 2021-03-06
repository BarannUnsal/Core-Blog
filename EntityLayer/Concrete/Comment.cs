using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommnetID { get; set; }
        public string CommentUsername { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public int BlogScore { get; set; } 
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
