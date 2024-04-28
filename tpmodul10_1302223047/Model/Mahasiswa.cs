using System;
namespace tpmodul10_1302223047.Model
{
	public class Mahasiswa
	{
		public string nama { get; set; }
		public string nim { get; set; }
	
		public Mahasiswa(string nama, string nim)
		{
			this.nama = nama;
			this.nim = nim;
		}
	}
}

