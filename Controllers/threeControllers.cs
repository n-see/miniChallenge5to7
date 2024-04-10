using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace miniChallenge5to7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThreeControllers : ControllerBase
    {
        [HttpGet("MadLib")]

        public string MadLib(string noun){
            return "hello" + noun;
        }

        [HttpGet("/oddOrEven")]
        
        public string oddOrEven(double num){
            double result = num % 2;
            if(result == 0){
                return num + " is even";
            }else{
                return num + " is odd";
            }
        }

        [HttpGet("/reverseIt(Alphanumeric)")]

        public string reverseIt(string anything){
            string reverse = "";
            for(int i = anything.Length - 1; i >= 0; i--){
                reverse += anything[i].ToString();
            } 
            return anything + " backwards is " + reverse;
        }

        [HttpGet("/reverseIt(numbersOnly)")]
        public string numberReverse(string numberOnly){
                if (string.IsNullOrEmpty(numberOnly))
                    return "Please enter a number";

                if (!numberOnly.All(char.IsDigit))
                    return "Only Numbers are allowed";

                Char[]  changeToCharArray = numberOnly.ToCharArray();
                Array.Reverse(changeToCharArray);

                string numReverse = new string(changeToCharArray);
                return numberOnly + " reversed is " + numReverse;
        }
    }
}
