using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_librarie
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void access_btn_Click(object sender, EventArgs e)
        {
            Imprumut biblioteca = new Imprumut();
            this.Hide();
            biblioteca.Closed += (s, args) => this.Close();
            biblioteca.Show();
        }

        private void acces_tabel(object sender, EventArgs e)
        {
            CartiImprumutate carti = new CartiImprumutate();
            this.Hide();
            carti.Closed += (s, args) => this.Close();
            carti.Show();
        }
    }
}
