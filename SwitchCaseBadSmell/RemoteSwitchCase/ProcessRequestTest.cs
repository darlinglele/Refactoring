using NUnit.Framework;

namespace RemoveSwitchCase
{
    [TestFixture]
    class ProcessRequestTest    
    {
        [Test]
        public void HandleTheUserRequest()
        {
            ProcessRequest request = new ProcessRequest();
            string expected = "I am a user, can I ask a question?";
            string result = request.Handle("user");
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void HandleTheAdminRequest()
        {
            ProcessRequest request = new ProcessRequest();
            string expected = "I am a admin, can I help you?";
            string result = request.Handle("admin");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void HandleThePwCAdminRequest()
        {
            ProcessRequest request = new ProcessRequest();
            string expected = "I am a admin, can I help you?";
            string result = request.Handle("PwCAdmin");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void HandleThePwCUserRequest()
        {
            ProcessRequest request = new ProcessRequest();
            string expected = "I am a user, can I ask a question?";
            string result = request.Handle("PwCUser");
            Assert.AreEqual(expected, result);
        }
    }
}
