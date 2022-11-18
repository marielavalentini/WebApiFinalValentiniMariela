using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public dynamic Get() //trae la lista de hospitales
        {
            dynamic hospitales = (from h in Context.Hospitales
                                  select new { h.Nombre, h.Telefono, h.Num_Camas}).ToList();
            return hospitales;

        }
        [HttpGet("/api/hospital/{CantidadCamas}")]

        public dynamic Get(int CantidadCamas) //trae la lista de aquellos hospitales donde el numero de camas sea mayor al recibido por parametro
        {
            dynamic hospitales = (from h in Context.Hospitales
                                  where h.Num_Camas > CantidadCamas
                                  select new { h.Nombre, h.Telefono, h.Num_Camas }).ToList();
            return hospitales;
        }
    }
}
