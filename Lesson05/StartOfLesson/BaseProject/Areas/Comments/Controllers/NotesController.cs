using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Areas.Comments.Controllers
{
    [Area("Comments")]
    [Route("[area]/notes")]

    public class NotesController : Controller
    {
        [Route("")]
        [Route("Index")]
        // GET: Notes
        public IActionResult Index()
        {
            return View();
        }
    }
}