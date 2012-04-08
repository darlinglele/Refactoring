using System;
using System.Collections.Generic;
using System.Configuration;

namespace FactoryMethod
{
    public class UserRequest
    {
        private static Dictionary<string, IRoleFactory> _defaultFactories;

        static UserRequest()
        {
            _defaultFactories = new Dictionary<string, IRoleFactory> { { "user", new UserFactory() }, { "admin", new AdminFactory() } };
        }
        public static IRole Create(string request)
        {
            IRoleFactory factory = getFactoryInstance(request);
            return factory.CreateRole();
        }

        private static IRoleFactory getFactoryInstance(string request)
        {
            return _defaultFactories[request] ?? (customFactory(request));
        }

        private static IRoleFactory customFactory(string request)
        {
            string factoryTypeName = ConfigurationManager.AppSettings[request];
            string assemblyNameKey = factoryTypeName + "_assembly";
            string assemblyName = ConfigurationManager.AppSettings[assemblyNameKey];
            return (IRoleFactory)Activator.CreateInstance(assemblyName, factoryTypeName);
        }

        public static void Extends(string request, IRoleFactory factory)
        {
            if (_defaultFactories.ContainsKey(request))
                _defaultFactories.Remove(request);
            _defaultFactories.Add(request, factory);
        }

        public static void Remove(string request)
        {
            if (!_defaultFactories.ContainsKey(request))
                return;
            _defaultFactories.Remove(request);
        }
    }
}
