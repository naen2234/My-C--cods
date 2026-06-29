using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
            string fullname = "Abrahem Khaled ";
            //string phonenumber = "781-177-4929";
            
            //fullname = fullname.ToUpper();
            //fullname = fullname.ToLower();
            //Console.WriteLine(fullname);

           //phonenumber = phonenumber.Replace("-","");
           //Console.WriteLine(phonenumber);
           
           //string username = fullname.Insert(0,"Mr. ");
           //Console.WriteLine(username);
           
           //Console.WriteLine(fullname.Length);

           string lastname = fullname.Substring(8);
           string firstname = fullname.Substring(0,7);
           Console.WriteLine(firstname);
           Console.WriteLine(lastname);

        }
    }
}
