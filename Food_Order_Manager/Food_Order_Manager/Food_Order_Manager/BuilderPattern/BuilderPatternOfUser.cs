using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Order_Manager.BuilderPattern;

namespace Food_Order_Manager.BuilderPattern
{
    public class BuilderPatternOfUser:IUserBuilder
    {
        public string Password;
        public string Name;
        public string Username;
        public string Position;
        public string Sex;
        public string DOB;
        public string Address;
        public string NumberPhone;


        public BuilderPatternOfUser AddLocal(string password, string username)
        {
            Password = password;
            Username = username;
            return this;
        }
        public BuilderPatternOfUser AddProfile(string name,string sex, string address, string dob,string numberPhone)
        {
            Sex = sex;
            Address = address;
            DOB = dob;
            NumberPhone = numberPhone;
            Name = name;
            return this;
        }
        public BuilderPatternOfUser AddMajor(string position)
        {
            Position = position;
            return this;
        }

        public User Build()
        {
            return new User(Username,Password,Name,Position,Sex,DOB,Address,NumberPhone);
        }


    }
}
