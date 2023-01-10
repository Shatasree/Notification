using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NotificationTemplate.DAL;
using NotificationTemplate.Model;
using System.Reflection.Metadata.Ecma335;

namespace NotificationTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TemplateController : ControllerBase
    {
        private readonly Idbcon idbcon;
        public TemplateController(Idbcon idbcon)
        {
            this.idbcon = idbcon;
        }
        [HttpPost]
        public ActionResult FirstTemplate(CreateTemplate createTemplate)
        { 
            var Status = this.idbcon.Connection(createTemplate);     
           
           if (Status != null)
            {
                return Ok(new Response { StatusCode="200",Message="Template Created",TemplateNo="1"});
            }
           else
            {
                return Ok(new Response { StatusCode="400",Message="Template Not Created", TemplateNo="nOT fOUND"});
            }
        }
    }
}
           

            

         
