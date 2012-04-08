namespace FactoryMethod
{
    public class AdminFactory : IRoleFactory
    {
        public IRole CreateRole()
        {
            return new Admin();
        }
    }
}