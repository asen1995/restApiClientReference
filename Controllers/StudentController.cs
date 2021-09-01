using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restApiClientReference.Controllers
{
    public class StudentController : Controller
    {
        public string PrintStudent(int id)
        {
            return "GET student : " + id;
        }
    }
}