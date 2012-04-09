using System;
using System.Collections.Generic;
using System.Configuration;

namespace FactoryMethod
{
    public class RoleManager
    {
        private static Dictionary<string, IRoleFactory> _defaultFactories;

        static RoleManager()
        {
            _defaultFactories = new Dictionary<string, IRoleFactory> { { "user", new UserFactory() }, { "admin", new AdminFactory() } };
        }
        public static IRole Create(string request)
        {
            IRoleFactory factory = getFactoryInstance(request);
            return factory == null ? null : factory.CreateRole();
        }

        private static IRoleFactory getFactoryInstance(string request)
        {
            return _defaultFactories.ContainsKey(request) ? _defaultFactories[request] : customFactory(request);
        }

        private static IRoleFactory customFactory(string request)
        {
            string requestTypeKey = request;
            string factoryTypeName = getConfigValue(requestTypeKey);
            string assemblyNameKey = requestTypeKey + "_assembly";
            string assemblyName = getConfigValue(assemblyNameKey);
            return (IRoleFactory)Activator.CreateInstance(assemblyName, factoryTypeName).Unwrap();
        }

        private static string getConfigValue(string requestTypeKey)
        {
            return ConfigurationManager.AppSettings[requestTypeKey];
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
