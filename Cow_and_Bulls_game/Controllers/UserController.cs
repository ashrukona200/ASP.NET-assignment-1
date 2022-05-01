using Cow_and_Bulls_game.Models;
using Cow_and_Bulls_game.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace Cow_and_Bulls_game.Controllers
{
    public class UserController : Controller
    {
        private MyAppDbContext _context;   

        //This will redirect the login page 
        public IActionResult Login()
        {
            return View();
        }

        //This will redirect the register page
        public IActionResult Signup()
        {
            return View();
        }

        //This will redirect the home page
        public IActionResult HomePage()
        {
            return View();
        }
        //This will redirect the error message page
        public IActionResult ErrMsg()
        {
            return View();
        }

        public IActionResult AuthenticateUser(UserGameViewModel obj)
        {
            _context = new MyAppDbContext();

            var result = _context.Users.Where(u => u.UserId == obj.user.UserId && u.Password == obj.user.Password);
            //If no error go ahead
            if(result.Count() > 0)
            {
                return RedirectToActionPermanent("GamePage", "Game");
            }
            //else handling the error
            else
            {
                var AuthFailed = new UserGameViewModel();
                AuthFailed.errorMsg = "Please Enter valid username/password";
                return View("ErrMsg", AuthFailed);
            }
            
        }
        public IActionResult AddUser(User user)
        {
            _context = new MyAppDbContext();
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToActionPermanent("Login", "User");
        }
        
    }
}
