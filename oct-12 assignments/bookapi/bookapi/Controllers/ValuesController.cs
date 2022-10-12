using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using bussinesslogic;
using helper;
using bookapi.Models;
namespace bookapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        Employee_Helper obj = null;
        public ValuesController()
        {
            obj = new Employee_Helper();
        }
        public List<bookmodel> Getbooklist()
        {
            //return new string[] { "value1", "value2" };

            List<Employee_BAL> empbal = new List<Employee_BAL>();
            empbal = obj.dispEmployeeList();
            List<bookmodel> emps = new List<bookmodel>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new bookmodel
                {
                    book_id = item.book_id,
                    book_name = item.book_name,
                    book_author = item.book_author
                });
            }
            return emps;

        }

        // GET api/<controller>/5           
        public bookmodel Getbookid(int id)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal = obj.searchEmployee(id);
            bookmodel emp = new bookmodel();
            emp.book_id = empbal.book_id;
            emp.book_name = empbal.book_name;
            emp.book_author = empbal.book_author;

            return emp;
            //return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Postbook([FromBody] bookmodel empdata)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal.book_id = empdata.book_id;
            empbal.book_name = empdata.book_name;
            empbal.book_author = empdata.book_author;



            bool ans = obj.AddEmployee(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // PUT api/<controller>/5
        public HttpResponseMessage Putbook(int id, [FromBody] bookmodel empdata)
        {

            Employee_BAL empbal = new Employee_BAL();
            empbal.book_id = empdata.book_id;
            empbal.book_name = empdata.book_name;
            empbal.book_author = empdata.book_author;

            bool ans = obj.AddEmployee(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage DeleteProduct(int id)
        {
            bool ans = obj.removebook(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
    }
}
