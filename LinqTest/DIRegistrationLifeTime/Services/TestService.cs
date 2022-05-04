using DIRegistrationLifeTime.Services.Interfaces;

namespace DIRegistrationLifeTime.Services
{
    public class TestService : IScopedService, ITransientService, ISingletonService
    {
        public string ServiceUniqueIdentifier { get; } = Guid.NewGuid().ToString();
    }
}
