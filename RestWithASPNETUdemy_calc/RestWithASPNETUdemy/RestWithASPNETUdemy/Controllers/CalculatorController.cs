using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CalculatorController : ControllerBase
   {


      private readonly ILogger<CalculatorController> _logger;

      public CalculatorController(ILogger<CalculatorController> logger)
      {
         _logger = logger;
      }
      private bool isNumeric(string parameter)
      {
         return true;
      }
      private decimal convertToDecimal(string parameter)
      {
         return decimal.Parse(parameter);
      }

      [HttpGet("sum/{firstNumber}/{secondNumber}")]
      public IActionResult Get(string firstNumber, string secondNumber)
      {
         if (isNumeric(firstNumber) && isNumeric(secondNumber))
         {
            var sum = convertToDecimal(firstNumber) + convertToDecimal(secondNumber);
            return Ok(sum.ToString());
         }

      }



   }
}