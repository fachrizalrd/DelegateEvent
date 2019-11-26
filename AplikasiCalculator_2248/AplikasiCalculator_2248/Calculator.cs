using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiCalculator_2303
{
    class Calculator
    {
        public double tambah(double NilaiA, double NilaiB)
        {
            return NilaiA + NilaiB;
        }
        public double kurang(double NilaiA, double NilaiB)
        {
            return NilaiA - NilaiB;
        }
        public double kali(double NilaiA, double NilaiB)
        {
            return NilaiA * NilaiB;
        }
        public double bagi(double NilaiA, double NilaiB)
        {
            return NilaiA / NilaiB;
        }
    }
}
