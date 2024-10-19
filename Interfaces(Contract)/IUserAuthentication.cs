using EventManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Interfaces_Contract_
{
    internal interface IUserAuthentication
    {
        Person Authentication(string username, string password);
        
    }
}
