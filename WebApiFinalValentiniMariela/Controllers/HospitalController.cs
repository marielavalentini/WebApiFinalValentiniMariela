using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalValentiniMariela.Conection;
using WebApiFinalValentiniMariela.Models;

namespace WebApiFinalValentiniMariela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public DbHospitalContext Context { get; set; }

        public HospitalController(DbHospitalContext context)
        {
            this.Context = context;
        }

        [HttpGet]

        public IEnumerable Get() //trae la lista de hospitales
        {
            List<Hospital> hospitales = Context.Hospitales.ToList();
            return hospitales;

        }

    }
}
