using System;
using Microsoft.AspNetCore.Mvc;
using Trigre.ViewModel;

namespace Trigre.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController
    {
        public UserController: Controller
        {
            public IActionResult Index()
            {
                UserViewModel user = new UserViewModel();
                return View(user);
            }

        }
    }
}
