using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.SingletonPattern
{
    public class UserLoginSingleton
    {
        public string USERNAME;
        public string NAME;
        public string POSITION;
        private static UserLoginSingleton instance = new UserLoginSingleton();

        private UserLoginSingleton() { }

        public static UserLoginSingleton GetInstance()
        {
            return instance;
        }
    }
}
