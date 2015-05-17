using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcBinario_2003_VictorFernandes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(Converter.binaryDivision("10000","10")[0]);
        }
    }
}
