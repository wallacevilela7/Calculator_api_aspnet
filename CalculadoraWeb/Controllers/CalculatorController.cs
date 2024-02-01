using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace CalculadoraWeb.Controllers
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

        //Soma
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSoma(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }


        //Subtracao
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtracao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtracao = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(subtracao.ToString());
            }
            return BadRequest("Invalid input");
        }

        //Multiplicacao
        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplicacao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var multip = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(multip.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //Divisao
        [HttpGet("divi/{n1}/{n2}")]
        public IActionResult GetDivisao(string n1, string n2)
        {
            if (IsNumeric(n1) && IsNumeric(n2))
            {
                var divisao = ConvertToDecimal(n1) / ConvertToDecimal(n2);
                return Ok(divisao.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //Media
        [HttpGet("media/{n1}/{n2}")]
        public IActionResult GetMedia(string n1, string n2)
        {
            if (IsNumeric(n1) && IsNumeric(n2))
            {
                var media = (ConvertToDecimal(n1) + ConvertToDecimal(n2)) / 2;
                return Ok(media.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //Raiz Quadrada
        [HttpGet("raiz/{num}")]
        public IActionResult GetRaiz(string num)
        {
            if (IsNumeric(num))
            {
                double numConvertido = Convert.ToDouble(num);
                double raiz = Math.Sqrt(numConvertido);
                return Ok(raiz.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string number)
        {
            double n;
            bool isNumber = double.TryParse(number, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out n);

            return isNumber;

        }
    }
}
