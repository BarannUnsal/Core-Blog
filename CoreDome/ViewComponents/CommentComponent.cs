using CoreDome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDome.ViewComponents
{
    public class CommentComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                   ID = 1,
                   Username = "Baran Unsal"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Sinem Unsal"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Ahmet Ayse"
                }
            };
            return View(commentValues);
        }
    }
}
