using System;
using System.Collections.Generic;
using System.Linq;

namespace Adapter
{
    public interface IExternalService
    {
        IEnumerable<ExternalUser> GetAll();
    }

    public class ExternalUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string About { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }


    public class UsersService1
    {
        private readonly IExternalService _externalService;

        public UsersService1(IExternalService externalService)
        {
            _externalService = externalService;
        }

        public IEnumerable<ExternalUser> GetUsersByName(string name)
        {
            return
                _externalService
                .GetAll()
                .Where(x => x.FirstName == name);
        }
    }


    public class ExternalServiceAdapter : IExternalServiceAdapter
    {
        private readonly IExternalService _externalService;

        public ExternalServiceAdapter(IExternalService externalService)
        {
            _externalService = externalService;
        }

        public IEnumerable<User> GetAll()
        {
            return _externalService
                .GetAll()
                .Select(x => new User
            {
                Name = x.FirstName,
                Surname = x.LastName,
                Age = x.Age
            });
        } 
    }

    public interface IExternalServiceAdapter
    {
        IEnumerable<User> GetAll();
    }

    public class UsersService
    {
        private readonly IExternalServiceAdapter _externalServiceAdapter;

        public UsersService(IExternalServiceAdapter externalServiceAdapter)
        {
            _externalServiceAdapter = externalServiceAdapter;
        }

        public IEnumerable<User> GetUsersByName(string name)
        {
            return
                _externalServiceAdapter
                .GetAll()
                .Where(x => x.Name == name);
        }
    }
}
