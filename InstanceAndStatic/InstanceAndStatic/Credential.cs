using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStatic
{
    public class Credential
    {
        private const double pi = 3.14D;
        private static readonly double otherpi = CalculatePi(1, 2, 3);
        private static readonly bool flag = CheckFlag();


        public Credential(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public string UserName { get; }

        public string Password { get; }



        private static double CalculatePi(int nr1, int nr2, int nr3)
        {
            return 3.14D;
        }

        public static bool CheckFlag()
        {
            // 1) path-ul
            // 2) citesc
            // 3) returned
            return true;
        }
    }
}
