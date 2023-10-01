using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiInputDataMahasiswa
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Kelas { get; set; }

        public string Nhuruf;
        private int nilai;
        public int Nilai
        {
            get { return nilai; }
            set
            {
                int val = value;
                nilai = val;
                if (val >= 81)
                {
                    Nhuruf = "A";
                }
                else if (val >= 61)
                {
                    Nhuruf = "B";
                }
                else if (val >= 41)
                {
                    Nhuruf = "C";
                }
                else if (val >= 21)
                {
                    Nhuruf = "D";
                }
                else
                {
                    Nhuruf = "E";
                }
            }
        }
    }
}
