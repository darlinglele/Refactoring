namespace FactoryMethod
{
    public class Process
    {
        private string _request = null;
        public void Handle(string request)
        {
            _request = request;
            IRole role = RoleManager.Create(_request);
            role.Do();
        }

        public void Response()
        {
            IRole role = RoleManager.Create(_request);
            role.SayHello();
        }
    }
}