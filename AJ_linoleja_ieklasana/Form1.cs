using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ_linoleja_ieklasana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aprekinat_Click(object sender, EventArgs e)
        {
            
            int t_platums = Convert.ToInt32(Math.Round(platums.Value, 0));

            int t_garums = Convert.ToInt32(Math.Round(garums.Value, 0));

            int linoleja_platums = Convert.ToInt32(Math.Round(l_platums.Value, 0));

            double cena = Convert.ToDouble(l_cena.Text);

            gridas_izmaksas(cena, linoleja_platums, t_platums, t_garums);
        }

        private void gridas_izmaksas(double cena, int linoleja_platums, int telpas_platums, int telpas_garums)
        {
            int telpas_izmers = telpas_garums * telpas_platums;

            double izmaksa = cena * telpas_izmers / linoleja_platums;

            izvadit.Text = $"{izmaksa.ToString("0.00")}";
        }
    }
}
