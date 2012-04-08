namespace FactoryMethod
{
    public class Process
    {
        private string _request = null;
        public void Handle(string request)
        {
            _request = request;
            IRole user = UserRequest.Create(_request);
            user.Do();
        }

        public void Response()
        {
            IRole user = UserRequest.Create(_request);
            user.SayHello();
        }
    }
}