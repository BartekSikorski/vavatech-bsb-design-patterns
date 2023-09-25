using System;

namespace SingletonPattern
{
    public class ApplicationContext : ThreadSafeSingleton<ApplicationContext>
    {
        public string LoggedUser { get; set; }
        public DateTime LoggedOn { get; set; }
    }
}
