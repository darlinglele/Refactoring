using System;
using System.Configuration;

namespace RemoveSwitchCase
{
    internal class Helper
    {
        public static IRoleFactory CreateRoleFactory(string factoryName, string assemblyName)
        {
            return (IRoleFactory)Activator.CreateInstance(assemblyName, factoryName).Unwrap();
        }

        public static IRole CreateRoleInstance(string requestType)
        {
            string factoryName = ConfigurationManager.AppSettings[requestType];
            string assemblyName = ConfigurationManager.AppSettings["assemblyName"];
            IRoleFactory roleFactory = null;
            try
            {
                roleFactory = CreateRoleFactory(factoryName, assemblyName);
            }
            catch (Exception)
            {
                return null;
            }

            if (roleFactory == null)
                return null;
            return roleFactory.CreateRole();
        }
    }
}