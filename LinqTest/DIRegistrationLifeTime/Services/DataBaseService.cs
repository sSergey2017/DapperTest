using DIRegistrationLifeTime.Services.Interfaces;

namespace DIRegistrationLifeTime.Services
{
    public class DataBaseService
    {
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;

        public DataBaseService(ISingletonService singletonService, ITransientService transientService, IScopedService scopedService)
        {
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
        }

        public void Save()
        {
            Console.WriteLine("\n |||||||| DataBaseService ||||||| \n");

            Console.WriteLine($"Singleton UID : \t\t {_singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID : \t\t {_scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID : \t\t {_transientService.ServiceUniqueIdentifier}");
          
        }
    }
}
