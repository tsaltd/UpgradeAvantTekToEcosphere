using Microsoft.AspNetCore.Mvc;
using System.Net;
using Messages;
using System;

namespace Workspace.Controllers.API
{
    [Route("API/Message")]
    public class MessageController : Controller
    {
        [HttpGet("")]
        public JsonResult Get()
        {   
            return Json(new {name = "AvantTek"});
        }

        [HttpPost("")]
        public void Post([FromBody]  Email msg)
        {
            if (ModelState.IsValid)
            {

                Response.StatusCode = (int)HttpStatusCode.Created;
               
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
          
            }
            
            
        }
    }
}
