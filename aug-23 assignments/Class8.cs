using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments.Employeess
{
    internal class Class8
    {
        struct Employee
        {
            public int id, deptno;
            public string n;
            public float sal;

           
            public int Id
            {

              
                get
                {
                    return id;
                }

                set
                {
                    try
                    {
                        if (value == 0)
                        {
                            throw new ArgumentNullException(nameof(value), "Id cannot be zero !!");
                           
                        }
                        else { id = value; }
                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.GetType().Name);


                        Console.WriteLine(e.StackTrace);
                    }


                }
            }
            public int Deptno
            {

                // returns id field
                get
                {
                    return deptno;
                }

                
                set
                {
                    try
                    {
                        if (value == 0)
                        {
                            throw new ArgumentNullException("Dept number cannot be zero !!");


                            

                        }
                        else { deptno = value; }
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }


                }
            }

            public string name
            {
                get
                {
                    return n;
                }
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {

                        Console.WriteLine("Name cannot be null or empty");


                    }

                    else { n = value; }
                }
            }
            public void getDisplaydata()
            {
                Console.WriteLine("Employee Id: " + id);
                Console.WriteLine("Employee name: " + n);
                Console.WriteLine("Employee salary:" + sal);
                Console.WriteLine("Employee deptno:" + deptno);
            }
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter employee id: ");
            e.Id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter name of employee:");
            e.name = Console.ReadLine();


            Console.WriteLine("Enter salary:");

            e.sal = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter dept no:");
            e.Deptno = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("-----------------------------------------------");
            e.getDisplaydata();
            Console.ReadLine();



        }
    }
}
        
    


