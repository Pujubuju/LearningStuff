namespace Decorator
{
    public abstract class ServiceDecorator : Service
    {
        protected Service Service { get; set; }

        public ServiceDecorator(Service service)
        {
            Service = service;
        }
    }
}
