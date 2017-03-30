using System.Collections.Generic;
using System.Web.Http;
using WebAPIhelp.Models;

namespace WebAPIhelp.Controllers
{
    public class ModeloController : ApiController
    {
        // GET: api/Modelo
        public IEnumerable<Modelo> Get()
        {
            return new[] {
                new Modelo
                {
                    Id=1, Nombre = "xx", Valor = "xxx"
                },
                new Modelo
                {
                    Id = 2, Nombre = "yy", Valor = "yy", ModeloPadre = new Modelo { Id = 1}
                }};
        }

        // GET: api/Modelo/5
        public Modelo Get(int id)
        {
            return new Modelo();
        }

        // POST: api/Modelo
        public void Post([FromBody]Modelo value)
        {
            //
        }

      
    }
}
