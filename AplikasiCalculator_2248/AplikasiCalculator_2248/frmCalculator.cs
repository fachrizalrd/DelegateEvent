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
    public partial class frmCalculator : Form
    { 
        public string select;
        

        public delegate void CalculatorUpdateEventHandler(int index, double NilaiA, double NilaiB);
        public event CalculatorUpdateEventHandler OnCreate;
        
        public frmCalculator()
        {
            InitializeComponent();
        }

        public frmCalculator(string title)
            : this()
        {
            this.Text = title;
        }

        
        private void BtnProses_Click(object sender, EventArgs e)
        {
            double NilaiA = Convert.ToDouble(txtNilaiA.Text);
            double NilaiB = Convert.ToDouble(txtNilaiB.Text);

            
            if (select == "Penambahan")
            {
                OnCreate(0, NilaiA, NilaiB);
            }
            else if (select == "Pengurangan")
            {
                OnCreate(1, NilaiA, NilaiB);
            }
            else if (select == "Perkalian")
            {
                 OnCreate(2, NilaiA, NilaiB);
            }
            else if (select == "Pembagian")
            {
                 OnCreate(3, NilaiA, NilaiB);
            }
            
        }

        private void CmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = cmbOperasi.SelectedItem.ToString();
           
        }

    }
}
