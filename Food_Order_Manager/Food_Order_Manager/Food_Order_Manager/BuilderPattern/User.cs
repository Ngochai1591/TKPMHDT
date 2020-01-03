using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.BuilderPattern
{
    public  class User
    {
        public string Password;
        public string Name;
        public string Username;
        public string Position;
        public string Sex;
        public string DOB;
        public string Address;
        public string NumberPhone;

        public User(string username,string password, string name, string position, string sex, string dob,
           string address,string numberPhone)
        {
            Username = username;
            Password = password;
            Name = name;
            Position = position;
            Sex = sex;
            DOB = dob;
            Address = address;
            NumberPhone = numberPhone;
        }
    }
}
