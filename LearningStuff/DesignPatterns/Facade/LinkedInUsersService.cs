using System;

namespace Facade
{
    public class LinkedInUsersService : UsersService
    {
        public override bool DoesUserExists(string name)
        {
            throw new NotImplementedException();
        }
    }
}
