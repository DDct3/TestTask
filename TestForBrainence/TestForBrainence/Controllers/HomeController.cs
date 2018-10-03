using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BL;
using DAL;

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
