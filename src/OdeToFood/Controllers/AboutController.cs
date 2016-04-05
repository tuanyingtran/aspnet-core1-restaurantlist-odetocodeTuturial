using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Routing.Template;

namespace OdeToFood.Controllers
{
    //Using Routes Attribute
    [Route("company/[controller]/[action]")]//[Route("company")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "Phone: 555-555-5555";
        }

        //[Route("[action]")]//[Route("country")]
        public string Country()
        {
            return "Contry: USA";
        }
    }
}
