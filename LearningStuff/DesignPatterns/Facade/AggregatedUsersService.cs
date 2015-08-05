namespace Facade
{
    public class AggregatedUsersService : UsersService
    {

        private readonly FacebookUsersService _facebookUsersService;
        private readonly LinkedInUsersService _linkedInUsersService;

        public AggregatedUsersService(
            FacebookUsersService facebookUsersService, 
            LinkedInUsersService linkedInUsersService)
        {
            _facebookUsersService = facebookUsersService;
            _linkedInUsersService = linkedInUsersService;
        }

        public override bool DoesUserExists(string name)
        {
            return _facebookUsersService.DoesUserExists(name) ||
                   _linkedInUsersService.DoesUserExists(name);
        }
    }
}
