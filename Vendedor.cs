using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pays_las_primas
{
    public partial class Vendedor : Form
    {
        public Vendedor(string nombre)
        {
            InitializeComponent();
            lbltext1.Text = nombre;
        }
    }
}
