using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameAndPassword
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username, password;

            username = "abdurrehman555@gmail.com";
            password = "pass555@";

            Console.WriteLine("enter the username : ");

            string user = Console.ReadLine();

            Console.WriteLine("enter the password : ");

            string pass = Console.ReadLine();

            if (user == username && pass == password)
            {
                Console.WriteLine("login successfull");
            }
            else
            {
                Console.WriteLine("login unsuccessfull");
            }
        }

    }
}
