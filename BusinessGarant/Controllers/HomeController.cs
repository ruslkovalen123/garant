using BusinessGarant.Models;
using BusinessGarant.Services;
using BusinessGarant.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BusinessGarant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailService _emailService;
        private readonly IDocumentEditorService _documentEditorService;
        private readonly DocumentSettings _documentSettings;
        public HomeController(IOptions<DocumentSettings> documentSettings, ILogger<HomeController> logger, IMailService emailService, IDocumentEditorService documentEditorService)
        {
            _logger = logger;
            _emailService = emailService;
            _documentEditorService = documentEditorService;
            _documentSettings = documentSettings.Value;
        }

        public IActionResult Index()
        {
            var seo = new SeoModel();
            seo.PageTitle = @"ГАРАНТ СЕРВІС УКРАЇНА | Фінансові Гарантії | ТОВ  ДЕЛЮКС ФІНАНС І КОМПАНІЯ | Транзит | Гарант";
            seo.Description = @"Незалежний фінансовий посередник, уповноважений на надання послуг з оформлення та видачі фінансових гарантій для забезпечення сплати митних платежів митним органам України, при переміщенні вантажів по території України в митних режимах: «транзит», «тимчасове ввезення», «імпорт», «переробка», «реі мпорт/реекспорт» 
надаємо фінансові гарантії на митні платежі";
            ViewBag.Seo = seo;

            return View();
        }
        [Route("/aboutus")]
        public IActionResult AboutUs()
        {
            var seo = new SeoModel();
            seo.PageTitle = @"Про нас | ТОВ  ДЕЛЮКС ФІНАНС І КОМПАНІЯ | ГАРАНТ СЕРВІС УКРАЇНА | Транзит | Гарант";
            seo.Description = @"Компанія надає фінансові гарантії суб'єктам Зовнішньої Економічної Діяльності. Надання фінансових гарантій відбувається цілодобово і щодня, а їх видача займає до 10-ти хвилин. Фінансова гарантія є найзручнішим способом забезпечення сплати митних органів України, так як не вимагає вносити гроші на рахунок ДМСУ (ДМСУ) на тривалий період.​";
            ViewBag.Seo = seo;
            return View();
        }

        [Route("/contactus")]
        public IActionResult ContactUs()
        {
            var seo = new SeoModel();
            seo.PageTitle = "Контакти | ПТ «ГАРАНТ СЕРВІС УКРАЇНА» ТОВ  ДЕЛЮКС ФІНАНС І КОМПАНІЯ» | Транзит ";
            seo.Description = @"Незалежний фінансовий посередник, уповноважений на надання послуг з оформлення та видачі фінансових гарантій для забезпечення сплати митних платежів митним органам України, при переміщенні вантажів по території України в митних режимах: «транзит», «тимчасове ввезення», «імпорт», «переробка», «реі мпорт/реекспорт» 
надаємо фінансові гарантії на митні платежі";
            ViewBag.Seo = seo;
            return View();
        }

        [Route("/request")]
        public IActionResult Request()
        {
            var seo = new SeoModel();
            seo.PageTitle = "Заявка | Фінансова гарантія | ГАРАНТ СЕРВІС УКРАЇНА";
            seo.Description = @"Незалежний фінансовий посередник, уповноважений на надання послуг з оформлення та видачі фінансових гарантій для забезпечення сплати митних платежів митним органам України, при переміщенні вантажів по території України в митних режимах: «транзит», «тимчасове ввезення», «імпорт», «переробка», «реі мпорт/реекспорт» 
надаємо фінансові гарантії на митні платежі";
            ViewBag.Seo = seo;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("/request")]
        public async Task<IActionResult> Index([FromForm] Request model)
        {
            var requestDocByteArray = _documentEditorService.EditRequestDocument(model);

            try
            {
                if (requestDocByteArray?.Length > 0)
                {
                    var fileName = $"{_documentSettings.FileName}_{DateTime.Now.ToShortDateString()}";
                    await _emailService.SendEmailAsync(fileName, _documentSettings.RequestSubject, requestDocByteArray, "Нова заявка");
                }
            }
            catch(Exception e)
            {
                return Content(e.Message);
            }

            return Ok();
        }


        [HttpPost("/askquestion")]
        public async Task<IActionResult> SentQuestion([FromForm] QuestionModel model)
        {
            string message = @$"<p>Клієнт з ім'ям <strong>{model.Name}</strong> , у якого email: <strong>{model.Email}</strong> та телефон: <strong>{model.Phone}</strong>
                                 залишив наступне запитання: </n>" + "\"" + $"<strong>{model.Question}</strong>" + "\"" + "</p>";
            try
            {
                await _emailService.SendEmailAsync(_documentSettings.QuestionSubject, message);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
            return Ok();
        }

        [HttpPost("/dogovor")]
        public async Task<IActionResult> Deal([FromForm] DogovorModel model)
        {
            string message = @$"<p>Клієнт з ім'ям <strong>{model.pib}</strong> , у якого email: <strong>{model.email}</strong> та телефон: <strong>{model.mobile}</strong>
                                 з кодом <strong>{model.cod}</strong> та компанією: <strong>{model.nameOfCompany} </strong> залишив коментар </n>" + "\"" + $"<strong>{model.message}</strong>" + "\"" + "</p>";
            try
            {
                await _emailService.SendEmailAsync(_documentSettings.DogovorSubject, message);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
            return Ok();
        }
    }
}
