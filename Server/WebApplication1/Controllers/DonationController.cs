using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
  // [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Donation> Get()
        {
           
            //await mail.SendEmailAsync(request);
            return DonationBl.GetAllDonation();
        }


        [HttpPost("saveNew")]

        public IEnumerable<Donation> saveNew([FromBody] Donation donation)
        {
            return DonationBl.GetAllDonation();
            // DonationBl.SaveNewDonation(donation);
        }

    }
}
