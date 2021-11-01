using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewCompanent
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    userName = "Fatih"
                },
                 new UserComment
                {
                    ID = 2,
                    userName = "İsmail"
                },
            };
            return View(values);
        }
    }
}
