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
    public partial class Imprumut : Form
    {


        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        public Imprumut()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Magazin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                poza1.Image = Properties.Resources.ACTIUNE1;
                poza2.Image = Properties.Resources.ACTIUNE2;
                poza3.Image = Properties.Resources.ACTIUNE3;


            }

            if (comboBox1.SelectedIndex == 1)
            {
                poza1.Image = Properties.Resources.COPII1;
                poza2.Image = Properties.Resources.COPII2;
                poza3.Image = Properties.Resources.COPII3;


            }

            if (comboBox1.SelectedIndex == 2)
            {
                poza1.Image = Properties.Resources.PSIH1;
                poza2.Image = Properties.Resources.PSIH2;
                poza3.Image = Properties.Resources.PSIH3;


            }

            if (comboBox1.SelectedIndex == 3)
            {
                poza1.Image = Properties.Resources.BUSINESS1;
                poza2.Image = Properties.Resources.BUSINESS2;
                poza3.Image = Properties.Resources.BUSINESS3;

            }

            if (comboBox1.SelectedIndex == 4)
            {
                poza1.Image = Properties.Resources.ISTORIE1;
                poza2.Image = Properties.Resources.ISTORIE2;
                poza3.Image = Properties.Resources.ISTORIE3;

            }

            if (comboBox1.SelectedIndex == 5)
            {
                poza1.Image = Properties.Resources.BIOGRAFII1;
                poza2.Image = Properties.Resources.BIOGRAFII2;
                poza3.Image = Properties.Resources.BIOGRAFII3;
            }



        }

        private void imprumut_btn_Click(object sender, EventArgs e)
        {
            if (ales1_rdbtn.Checked || ales2_rdbtn.Checked || ales3_rdbtn.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (ales1_rdbtn.Checked)
                    {


                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ACTIUNE1;
                        form.carte_txtBox.Text = "Totul se termina cu noi";
                        
                        
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ACTIUNE2;
                        form.carte_txtBox.Text = "Ugly love";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ACTIUNE3;
                        form.carte_txtBox.Text = "Verity";
                    }
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    if (ales1_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.COPII1;
                        form.carte_txtBox.Text = "Micul Print";
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.COPII2;
                        form.carte_txtBox.Text = "Reguli de comportament";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.COPII3;
                        form.carte_txtBox.Text = "Printul Nemilos";
                    }
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    if (ales1_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.PSIH1;
                        form.carte_txtBox.Text = "Cand corpul spune NU";
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.PSIH2;
                        form.carte_txtBox.Text = "Minti imprastiate";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.PSIH3;
                        form.carte_txtBox.Text = "Omul in cautarea sensului vietii";
                    }
                }

                if (comboBox1.SelectedIndex == 3)
                {
                    if (ales1_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BUSINESS1;
                        form.carte_txtBox.Text = "Tata bogat, tata sarac";
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BUSINESS2;
                        form.carte_txtBox.Text = "Arta negocierii";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BUSINESS3;
                        form.carte_txtBox.Text = "Draga, unde-s banii?";
                    }
                }

                if (comboBox1.SelectedIndex == 4)
                {
                    if (ales1_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ISTORIE1;
                        form.carte_txtBox.Text = "Sfarsitul soaptelor, Decembrie 1989";
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ISTORIE2;
                        form.carte_txtBox.Text = "100 de femei afurisite";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.ISTORIE3;
                        form.carte_txtBox.Text = "Rugaciune pentru Cernobil";
                    }
                }

                if (comboBox1.SelectedIndex == 5)
                {
                    if (ales1_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BIOGRAFII1;
                        form.carte_txtBox.Text = "Povestea mea, Michelle Obama";
                    }
                    else if (ales2_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BIOGRAFII2;
                        form.carte_txtBox.Text = "Iernile sufletului";
                    }
                    else if (ales3_rdbtn.Checked)
                    {
                        FormularImprumut form = new FormularImprumut();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.pictureBox2.Image = Properties.Resources.BIOGRAFII3;
                        form.carte_txtBox.Text = "Alegerea. Accepta cu bucurie posibilul";
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectati cartea dorita");
            }
        }
    }
}
