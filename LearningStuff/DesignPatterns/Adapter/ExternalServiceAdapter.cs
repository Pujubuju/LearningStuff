namespace Adapter
{
    public class ExternalServiceAdapter : IUsersService
    {
        private readonly ExternalService _externalService;

        public ExternalServiceAdapter(ExternalService externalService)
        {
            _externalService = externalService;
        }

        public int UsersCount()
        {
            return _externalService.GetNumberOfUsers();
        }
    }
}
