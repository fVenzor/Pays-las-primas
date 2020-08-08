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
        }
        SqlConnection con = new SqlConnection(@"Data Source= (localdb)\MSSQLLocalDB; Initial Catalog=usuarios; Integrated Security=True");

        public void logear(string usuario, string contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre,Tipo_usuario from usuarios WHERE Usuario=@usuario AND Password= @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Vendedor")
                    {
                        new Vendedor(dt.Rows[0][0].ToString()).Show();

                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            logear(this.textBox3.Text, this.textBox2.Text);
        }
    }

   

    
}

