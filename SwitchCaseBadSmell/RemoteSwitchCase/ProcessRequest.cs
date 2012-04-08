using System;
using System.Configuration;
using System.Reflection;

namespace RemoveSwitchCase
{
    public class ProcessRequest
    {
        public string Handle(string requestType)
        {
            IRole role = null;
            role = Helper.CreateRoleInstance(requestType);
            if (role != null)
                return role.Do();
            return null;
        }
    }
}
