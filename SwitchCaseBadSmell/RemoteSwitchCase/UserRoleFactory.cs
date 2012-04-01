namespace RemoveSwitchCase
{
    public class UserRoleFactory : IRoleFactory
    {
        public IRole CreateRole()
        {
            return new User();
        }
    }
}