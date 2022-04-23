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
    public partial class CartiImprumutate : Form
    {
        public CartiImprumutate()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Imprumut.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CartiImprumutate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imprumutDataSet.Imprumut' table. You can move, or remove it, as needed.
            this.imprumutTableAdapter.Fill(this.imprumutDataSet.Imprumut);
            // TODO: This line of code loads data into the 'cartiImprumutateDataSet5.TabelImprumut' table. You can move, or remove it, as needed.
            show_data();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        public void show_data()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Nume as Nume, Prenume as Prenume, Titlu as Titlu, Data_limita as Data_limita From Imprumut", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
