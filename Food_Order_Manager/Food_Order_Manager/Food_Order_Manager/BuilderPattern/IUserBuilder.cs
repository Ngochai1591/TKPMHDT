using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.BuilderPattern
{
    interface IUserBuilder
    {
        BuilderPatternOfUser AddLocal(string username, string password);
        BuilderPatternOfUser AddProfile(string name,string sex, string address, string DOB, string NumberPhone);
        BuilderPatternOfUser AddMajor(string position);
        User Build();
    }
}
