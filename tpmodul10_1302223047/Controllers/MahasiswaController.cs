using System;
using Microsoft.AspNetCore.Mvc;
namespace tpmodul10_1302223047.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class MahasiswaController : ControllerBase
	{
		private static List<Model.Mahasiswa> listOfMahasiswa = new List<Model.Mahasiswa>
		{
			new Model.Mahasiswa("Yazid Al Ghozali", "1302223047"),
			new Model.Mahasiswa("Meira Hafshah", "13022223048"),
		};

		[HttpGet]
		public IEnumerable<Model.Mahasiswa> Get()
		{
			return listOfMahasiswa;
		}

		[HttpGet("{id}")]
		public Model.Mahasiswa Get(int id)
		{
			return listOfMahasiswa[id];
		}

		[HttpPost]
		public void Post([FromBody] Model.Mahasiswa value)
		{
			listOfMahasiswa.Add(value);
		}

		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Model.Mahasiswa value)
		{
			listOfMahasiswa[id] = value;
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			listOfMahasiswa.RemoveAt(id);
		}
	}
}

