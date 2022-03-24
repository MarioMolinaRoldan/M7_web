using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using System.Diagnostics;
using System.Net.Mail;
using portfolio.Services;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Proyectos()
        {
            ViewBag.VprojectosMario = new RepositoryOfProjects().GetProjects();
            return View();
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult VideoPresentacion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult metodoEmail(ClassEmail classEmail)
        {
            email(classEmail);
            return View("Contacto");
        }
        private void email(ClassEmail classEmail)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("mario020705.mm@gmail.com");
            mail.From = new MailAddress(classEmail.email);


            mail.Subject = classEmail.asunto;
            mail.Body = classEmail.mensaje;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("ggerardab@gmail.com", "2Barcelona$$");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}