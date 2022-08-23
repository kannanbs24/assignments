using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments.Employeess
{
    internal class Class8
    {
        static void Main(string[] args)
        {

            User u = new User();
            //   u.Name=Console.ReadLine();
            //  u.Location = Console.ReadLine();
            u.empid = Convert.ToInt32(Console.ReadLine());
            u.GetUserDetails();


        }
    }

    class User
    {
        private int empid;
        public int id
        {
            set
            {
                if(value == 123)
                { 
                    id = value;
                    
                }
                else
                {
                    Console.WriteLine("invlaid employee id");
                }
              
            }
        }
        /* private string location;
        public string Location
        {
            set
            {
                location = value;
            }
        } */
        public void GetUserDetails()
        {

            // Console.WriteLine("Name: " + name);

            //       Console.WriteLine("Location: " + location);
            Console.WriteLine("empid" + " "+ empid);
        }
    }
}
        
    


