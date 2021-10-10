using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserNAme="Ali"
                },
                new UserComment
                {
                    ID=2,
                    UserNAme="Veli"
                },
                new UserComment
                {
                    ID=3,
                    UserNAme="Ahmet"
                }

            };
            return View(commentValues);

        }
    }
}
