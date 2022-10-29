/*
Rafael Manzo
10/26/2022
Odd or even end point challenge.

Peer Review: Jovann Contreras: Code looks good and I can see what is going on and understand it. It runs postman and gives back the correct answers by checking if the number is odd or even, overall the code works good.

*/
using Microsoft.AspNetCore.Mvc;

namespace ManzoR_oddOrEven_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class strangleyController : ControllerBase
{

    [HttpGet]
    [Route("Odders/{num1}")]
    public string shimone(string num1)
    {
        int num1a = int.Parse(num1);
        if (num1a % 2 == 0)
        {
            return $"Your number is even.";
        }
        else
        {
            return "This one is odd... hmm.";

        }
    }
}
