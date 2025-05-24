using Microsoft.AspNetCore.Mvc;

namespace EgitimPortaliUI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            // Zaten giriş yapmışsa ana sayfaya yönlendir
            return View();
        }

        public IActionResult Register()
        {
            // Register sayfası için layout belirle
            return View();
        }

        public IActionResult ForgotPassword()
        {
            // ForgotPassword sayfası için layout belirle
            return View();
        }

        public IActionResult Logout()
        {
            TempData["ClearLocalStorage"] = true;
            return RedirectToAction("Login");
        }
    }
}