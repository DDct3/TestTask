using Microsoft.AspNetCore.Mvc;
using BL;

namespace TestForBrainence.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("api/HomeController/GetText")]
        public void GetText(string text, int entry)
        {
            SentencesManager.ReverseSentences(text, entry);
        }
    }
}
