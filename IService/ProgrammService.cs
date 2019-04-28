using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public class ProgrammService:IProgrammService
    {
        public string Msg(string msg)
        {
            return msg;
        }
        public User GetEmptyUser()
        {
            return new User();
        }
    }
}
