using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RemoteShutdown.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShutdownController : ControllerBase
    {
        //[HttpPost("shutdown")]
        //public IActionResult Shutdown()
        //{
        //    Process.Start(new ProcessStartInfo("shutdown", "/s /f /t 0")
        //    {
        //        CreateNoWindow = true,
        //        UseShellExecute = false
        //    }
        //        );
        //    return Ok("Shutting down the computer");
        //}
        [HttpPost("adddoc")]
        public IActionResult AddDoc()
        {

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "shutdown.log.txt");

            System.IO.File.WriteAllText(filePath, "tutaj mial sie komp wylaczyc" + System.DateTime.Now);

            return Ok("Plik został utworzony");
        }

    }
}
