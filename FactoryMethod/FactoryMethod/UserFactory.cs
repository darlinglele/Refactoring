namespace FactoryMethod
{
    internal class UserFactory : IRoleFactory
    {
        public IRole CreateRole()
        {
            return new User();
        }
    }
}