using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace tpModul9_1302213073.Controller
{
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Farhan Mulya Argyanto", "1302213073"),
            new Mahasiswa("Glorious Satria", "1302210025"),
            new Mahasiswa("Kevin ", "13022130019"),
            new Mahasiswa("Rafidhia Haikal P", "1302210127"),
            new Mahasiswa("Putu Vidya Ananda R", "1302213026")
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

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
