using DIRegistrationLifeTime.Services;
using DIRegistrationLifeTime.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIRegistrationLifeTime.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TestController : ControllerBase
    {
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly DataBaseService _dataBase;

        public TestController(ISingletonService singletonService, ITransientService transientService, IScopedService scopedService, DataBaseService dataBase )
        {
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
            _dataBase = dataBase;

        }

        [HttpGet]
        public ActionResult Get()
        {
            Console.WriteLine("\n |||||||| Test Controller ||||||| \n");

            Console.WriteLine($"Singleton UID : \t\t {_singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID : \t\t {_scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID : \t\t {_transientService.ServiceUniqueIdentifier}");

            _dataBase.Save(); 
            return Ok();
        }
    }
}
