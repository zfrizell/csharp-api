using Microsoft.AspNetCore.Mvc;


namespace Catalog2.Controllers
{
    [ApiController]
    [Route("can/zack/write/cs")]
    public class zacksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            string response = "He's not very good yet but he can build a simple API.";
            return response;
        }

        // [HttpGet]
        // public HttpResponseMessage Get()
        // {
        //     return new HttpResponseMessage()
        //     {
        //         Content = new StringContent(
        //             "<strong>the API says yes</strong>", 
        //             Encoding.UTF8, 
        //             "text/html"
        //         )
        //     };
        // }   
    }
}