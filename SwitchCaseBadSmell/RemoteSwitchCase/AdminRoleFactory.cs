namespace RemoveSwitchCase
{
    public class AdminRoleFactory:IRoleFactory
    {
        public IRole CreateRole()
        {
            return new Admin();
        }
    }
}