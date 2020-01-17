using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<Alunos> Get()
        {
            Alunos aluno = new Alunos();
            return aluno.listaAlunos();
        }

        // GET: api/Aluno/5
        public Alunos Get(int id)
        {
            Alunos aluno = new Alunos();
            return aluno.listaAlunos().Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Aluno
        public List<Alunos> Post(Alunos aluno)
        {
            List<Alunos> alunos = new List<Alunos>();

            alunos.Add(aluno);

            return alunos;

        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
        }
    }
}
