using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/jobboard")]
        public ActionResult JobBoard()
        {
            return View();
        }
        [HttpGet("/addjob")]
        public ActionResult AddJob()
        {  
            return View();
        }
        [HttpPost("/jobboard")]
        public ActionResult CreateAddJob()
        {   
            JobBoardVariable myJobBoardVariable = new JobBoardVariable(Request.Form["job-name"], Request.Form["job-description"]);
            myJobBoardVariable.Save();
            List<JobBoardVariable> allJobs = JobBoardVariable.GetAll();
            return View("JobBoard", allJobs);
        }
    }
}

//JobBoardVariable myJobBoardVariable = new JobBoardVariable(Request.Query["job-title"], Request.Query["job-description"]);