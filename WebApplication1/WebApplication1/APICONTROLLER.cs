using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class APIController
    {
        [HttpGet]
        [Route("api/NumberToWords/{number}")]
        public string ConvertToWords(int number)
        {
            return NumberToWordsConverter.ConvertNumberToWords(number);
        }

    }
}