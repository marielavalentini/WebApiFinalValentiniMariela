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
    public class MedicoController : ControllerBase
    {
        public DbHospitalContext Context { get; set; }

        public MedicoController (DbHospitalContext context)
        {
            this.Context = context;
        }

        //GET /api/medico

        [HttpGet("/api/medico/lista")]

        public IEnumerable Get() //trae la lista de medicos
        {
            List<Medico> medicos = Context.Medicos.ToList();
            return medicos;

        }

        //[HttpGet("{Doctor_No}")]

        //public Medico Get(int Doctor_No) //muestra un medico por id
        //{
        //    Medico medico = Context.Medicos.Find(Doctor_No);
        //    return medico;
        //}

        //GET /api/medico/id

        //[HttpGet("/api/medico/{id}", Name = "ObtenerMedico")]

        //public ActionResult<Medico> Get(int id)
        //{
        //    var resultado = Context.Medicos.FirstOrDefault(x => x.Doctor_No == id);
        //    if (resultado == null)
        //    { return NotFound(); }
        //    return resultado;
        //}


        [HttpGet("/api/medico/{especialidad}")]

        public dynamic Get(string Especialidad)//trae la lista de medicos por especialidad
        {
            dynamic medicos = (from m in Context.Medicos
                               where m.Especialidad == Especialidad
                               select m).ToList();
            return medicos;
        }

        [HttpPost]

        public ActionResult Post([FromBody] Medico medico)//agregar un medico
        {
            Context.Medicos.Add(medico);
            Context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerMedico", new { id = medico.Doctor_No }, medico);
        }

        [HttpPut("{id}")]

        public ActionResult Put(int id, [FromBody] Medico value)
        {
            if (id != value.Doctor_No)
            {
                BadRequest();
            }
            Context.Entry(value).State = EntityState.Modified;
            Context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Medico> Delete(int id)
        {
            var resultado = Context.Medicos.FirstOrDefault(x => x.Doctor_No ==
            id);
            if (resultado == null)
            { return NotFound(); }
            Context.Medicos.Remove(resultado);
            Context.SaveChanges();
            return resultado;
        }


    }
}
