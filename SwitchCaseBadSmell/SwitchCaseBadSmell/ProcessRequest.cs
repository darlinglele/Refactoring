using System;

namespace SwitchCaseBadSmell
{
    public class ProcessRequest
    {
        public void Handle(string requestType)
        {
            switch (requestType)
            {
                case "admin":
                case "PwCAdmin":
                    adminDo();
                    break;
                case "user":
                case "PwCUser":
                    userDo();
                    break;
            }
        }

        private void userDo()
        {
            Console.Write("I am a user, may I have a question");
        }

        private void adminDo()
        {
            Console.Write("I am a admin, can I help you!");
        }
    }
}
