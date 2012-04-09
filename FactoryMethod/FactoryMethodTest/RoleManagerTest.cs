using System.Configuration;
using System.Reflection;
using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FactoryMethodTest
{

    [TestClass()]
    public class RoleManagerTest
    {
        [TestMethod()]
        public void CreateUserRoleTest()
        {
            const string request = "user";
            Type expected = typeof(User);
            Type actual = RoleManager.Create(request).GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateAdminRoleTest()
        {
            const string request = "admin";
            Type expected = typeof(Admin);
            Type actual = RoleManager.Create(request).GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateCustomRoleTest()
        {
            const string request = "custom";
            Type expected = typeof(Custom);
            ConfigurationManager.AppSettings.Set(request, typeof(CustomFactory).FullName);
            ConfigurationManager.AppSettings.Set(request + "_assembly", Assembly.GetExecutingAssembly().GetName().Name);
            Type actual = RoleManager.Create(request).GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateExtensionRoleTest()
        {
            const string request = "extension";
            Type expected = typeof(Extension);
            RoleManager.Extends("extension", new ExtensionFactory());
            Type actual = RoleManager.Create(request).GetType();
            Assert.AreEqual(expected, actual);
        }
    }

    public class ExtensionFactory : IRoleFactory
    {
        public IRole CreateRole()
        {
            return new Extension();
        }
    }

    public class Extension : IRole
    {
        public void Do()
        {
        }

        public void SayHello()
        {
        }
    }

    public class Custom : IRole
    {
        public void Do()
        {
        }

        public void SayHello()
        {
        }
    }

    public class CustomFactory : IRoleFactory
    {
        public IRole CreateRole()
        {
            return new Custom();
        }
    }
}
