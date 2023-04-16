using Microsoft.AspNetCore.Mvc;

namespace tpModul9_1302213073.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Farhan Mulya Argyanto", "1302213073"),
            new Mahasiswa("Tangguh Laksana", "1302210025"),
            new Mahasiswa("Fathur Rahman ", "13022130093"),
            new Mahasiswa("Yesa Krisanto S", "1302210000"),
            new Mahasiswa("Ghaza Gymnastiar", "1302210063")
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            dataMahasiswa.Add(newMahasiswa);
        }

        //// PUT api/<MahasiswaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Mahasiswa updatedMahasiswa)
        //{
        //    dataMahasiswa[id] = updatedMahasiswa;
        //}

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
