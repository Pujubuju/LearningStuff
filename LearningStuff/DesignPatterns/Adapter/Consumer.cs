using System;

namespace Adapter
{
    public class Consumer
    {
        private readonly IUsersService _usersService;

        public Consumer(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public void AnalyzeUsers()
        {
            int count = _usersService.UsersCount();
            Console.WriteLine(count);
        }
    }
}
