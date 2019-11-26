using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalculator_2303
{
    public partial class frmHasilPerhitungan : Form
    {
       
        public frmHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void frmCalculator_OnCreate(int index, double NilaiA, double NilaiB)
        {
            var calculator = new Calculator();

            if(index == 0)
            {
                lsvHasilPerhitungan.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", NilaiA, NilaiB, calculator.tambah(NilaiA, NilaiB)));
            }
            else if (index == 1)
            {
                lsvHasilPerhitungan.Items.Add(string.Format("Hasil Pengurangan : {0} + {1} = {2}", NilaiA, NilaiB, calculator.kurang(NilaiA, NilaiB)));
            }
            else if (index == 2)
            {
                lsvHasilPerhitungan.Items.Add(string.Format("Hasil Perkalian : {0} + {1} = {2}", NilaiA, NilaiB, calculator.kali(NilaiA, NilaiB)));
            }
            else if (index == 3)
            {
                lsvHasilPerhitungan.Items.Add(string.Format("Hasil Pembagian : {0} + {1} = {2}", NilaiA, NilaiB, calculator.bagi(NilaiA, NilaiB)));
            }

            
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            frmCalculator frmCalculator = new frmCalculator();
            frmCalculator.OnCreate += frmCalculator_OnCreate;
            frmCalculator.ShowDialog();
        }
    }
}
