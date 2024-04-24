using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string.Equals("text1", "text2", StringComparison.OrdinalIgnoreCase);


            DbConnection.ConnectionString = "server1";

            Credential[] credentials = new Credential[]
            {
                new Credential("user1", "password1"),
                new Credential("user2", "password2"),
                new Credential("user3", "password3")
            };

            foreach (Credential credential in credentials)
            {
                /*
                DbConnection conn = new DbConnection(
                    credential.UserName, 
                    credential.Password);

                conn.Open();
                conn.ExecuteQuery("select * from Table");
                */

                QueryExecutionEngine.ExecuteQuery(
                    credential.UserName,
                    credential.Password,
                    "select * from Table");
            }

            

            //
            DbConnection.ConnectionString = "server2";

            // indexers
            Address addr = new Address();
            addr.Street = "Onisifor Ghibu";
            addr.City = "Cluj-Napoca";
            addr.Country = "Romania";
            addr.PostalCode = "123";

            Console.WriteLine(addr["Street"]);
        }
    }
}
