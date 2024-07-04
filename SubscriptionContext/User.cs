using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    class User : Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}