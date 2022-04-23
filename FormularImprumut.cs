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

namespace Gestiune_librarie
{
    public partial class FormularImprumut : Form
    {
        public FormularImprumut()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Imprumut.mdf;Integrated Security = True; Connect Timeout = 30");

        private void back_btn_Click(object sender, EventArgs e)
        {
            Imprumut impr = new Imprumut();
            this.Hide();
            impr.Closed += (s, args) => this.Close();
            impr.Show();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if(nume_txtBox.Text=="" || prenume_txtBox.Text=="" || dataLimita.Value.ToString()=="")
            {
                MessageBox.Show("Atentie! Verificati daca ati completat toate campurile!");
            }
            else
            {
                
                
                SqlCommand cmd = new SqlCommand("Insert into Imprumut(Nume, Prenume, Titlu, Data_limita)Values('" + nume_txtBox.Text + "', '" + prenume_txtBox.Text + "', '" + carte_txtBox.Text + "', '" + dataLimita.Text + "')", con);
               
                con.Open();
               cmd.ExecuteNonQuery();
               
                    MessageBox.Show("Imprumut finalizat cu succes");
                
                con.Close();

               
                
                MainMenu menu = new MainMenu();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.Show();

            }
            
        }
    }
}
