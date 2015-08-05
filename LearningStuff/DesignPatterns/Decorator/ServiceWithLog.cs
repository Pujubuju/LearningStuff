namespace Decorator
{
    public class ServiceWithLog : ServiceDecorator
    {

        private readonly Logger _logger = new Logger();

        public ServiceWithLog(Service service) 
            : base(service)
        {
        }

        public override void Action1()
        {
            _logger.Log("Action1");
            Service.Action1();
        }

        public override void Action2()
        {
            _logger.Log("Action2");
            Service.Action2();
        }
    }
}
