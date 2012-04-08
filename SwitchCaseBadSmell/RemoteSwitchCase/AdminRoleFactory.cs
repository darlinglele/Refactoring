namespace RemoveSwitchCase
{
    public class AdminRoleFactory : IRoleFactory
    {
        private static IRoleFactory factory = null;
        private static readonly object lockedObject = new object();

        public IRole CreateRole()
        {
            return new Admin();
        }

        public AdminRoleFactory()
        {

        }
        public static IRoleFactory GetInstance()
        {
            lock (lockedObject)
            {
                return factory ?? (factory = new AdminRoleFactory());
            }
        }
    }
}