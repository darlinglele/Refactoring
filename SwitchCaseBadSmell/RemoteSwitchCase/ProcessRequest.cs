using System;
using System.Configuration;

namespace RemoveSwitchCase
{
    public class ProcessRequest
    {
        public string Handle(string requestType)
        {
            IRole role = null;
            role = createRoleInstance(requestType);
            if (role != null)
                return role.Do();
            return null;
        }

        private IRole createRoleInstance(string requestType)
        {

            string factoryName = ConfigurationManager.AppSettings[requestType];
            string assemblyName = ConfigurationManager.AppSettings["assemblyName"];
            IRole role = null;
            try
            {
                IRoleFactory roleFactory = (IRoleFactory)Activator.CreateInstance(assemblyName, factoryName).Unwrap();
                role = roleFactory.CreateRole();
            }
            catch (Exception)
            {
                dosomething();
            }
            return role;
        }

        private void dosomething()
        {

        }
    }
}
