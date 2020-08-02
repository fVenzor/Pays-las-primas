using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pays_las_primas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@ "Data Source = (LocalDb)\vll.0;initial Catalog= usuarios;Integrated Security=True");

            void logear(string usuario, string contraseña)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nombre,Tipo_usuario from usuarios WHERE usuario=@usuario ADN Password= @pass", con);
                    cmd.Parameters.AddWithValue("usuario", usuario);
                    cmd.Parameters.AddWithValue("pass", contraseña);
                    SqlDataAdapter sda = new SqlDataAdapter(cdm);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count==1)
                    {

                    }
                    else
                    {
                        MessageBox.Show()
                    }

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message)
                }
                finally
                {

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
