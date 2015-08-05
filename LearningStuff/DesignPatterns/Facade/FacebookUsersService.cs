using System;

namespace Facade
{
    public class FacebookUsersService : UsersService
    {
        public override bool DoesUserExists(string name)
        {
            throw new NotImplementedException();
        }
    }
}
