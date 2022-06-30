using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CoreDome.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string RePassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
