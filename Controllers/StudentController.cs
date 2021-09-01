using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restApiClientReference.Controllers
{
    public class StudentController : Controller
    {

        private List<string> studentList = new List<string>
            { "Asen", "Rumen" , "Ivan" };

        public string PrintStudent(int id)
        {
            return "GET student : " + id;
        }

        public List<string> GetAllStudents()        {
            return studentList;
        }
    }
}