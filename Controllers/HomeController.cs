using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wedding_planner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace wedding_planner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("User/new")]
        public IActionResult registration(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.FirstOrDefault(q => q.email == newUser.email) != null)
                {
                    ModelState.AddModelError("email", "Please log in");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.password = hasher.HashPassword(newUser, newUser.password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                return RedirectToAction("success");
            }
            return View("Index");
        }

        [HttpGet("User/success")]
        public IActionResult success()
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            int uid = (int)HttpContext.Session.GetInt32("userId");
            User user = dbContext.Users.FirstOrDefault(q => q.UserId == uid);
            List<Wedding> allW = dbContext.Weddings.Include(x => x.RSVP).Include(q => q.Creator).ToList();
            successModel model = new successModel();
            model.userLogged = user;
            model.allW = allW;
            return View(model);
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("User/login")]
        public IActionResult UserLogin(Login userLogin)
        {
            if (ModelState.IsValid)
            {
                User isInDb = dbContext.Users.FirstOrDefault(q => q.email == userLogin.lemail);
                if (isInDb == null)
                {
                    ModelState.AddModelError("lemail", "Invalid Credentials");
                    return View("Login");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(userLogin, isInDb.password, userLogin.lpassword);
                if (result == 0)
                {
                    ModelState.AddModelError("lemail", "Invalid Credentials");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("userId", isInDb.UserId);
                return RedirectToAction("success");
            }
            return View("Login");
        }

        [HttpGet("User/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("createWedding")]
        public IActionResult NewWedding()
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("Wedding/new")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                newWedding.UserId = (int)HttpContext.Session.GetInt32("userId");
                dbContext.Add(newWedding);
                dbContext.SaveChanges();
                return RedirectToAction("success");
            }

            return View("NewWedding");
        }

        [HttpGet("Wedding/{WeddingId}")]
        public IActionResult ShowWedding(int WeddingId)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            Wedding oneWedding = dbContext.Weddings.Include(w => w.RSVP).ThenInclude(u => u.User).FirstOrDefault(w => w.WeddingId == WeddingId);
            return View(oneWedding);
        }

        [HttpPost("delete/wedding/{WeddingId}")]
        public IActionResult delete(int WeddingId)
        {
            Wedding wedtoDel = dbContext.Weddings.FirstOrDefault(x => x.WeddingId == WeddingId);
            dbContext.Weddings.Remove(wedtoDel);
            dbContext.SaveChanges();
            return RedirectToAction("success");
        }

        [HttpPost("rsvptoyourwedding/{WeddingId}")]
        public IActionResult Rsvp(int WeddingId)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            RSVP going = new RSVP();
            going.WeddingId = WeddingId;
            going.UserId = (int)HttpContext.Session.GetInt32("userId");
            dbContext.RSVPs.Add(going);
            dbContext.SaveChanges();
            return RedirectToAction("success");
        }

        [HttpPost("notgoingtoyourwedding/{WeddingId}")]
        public IActionResult UnRsvp(int WeddingId)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }
            RSVP Notgoing = dbContext.RSVPs.FirstOrDefault(x => x.WeddingId == WeddingId && x.UserId == HttpContext.Session.GetInt32("userId"));
            dbContext.RSVPs.Remove(Notgoing);
            dbContext.SaveChanges();
            return RedirectToAction("success");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
