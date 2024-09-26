using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patinage
{
    public partial class Form1 : Form
    {
        evenementJO E = new evenementJO("CAN");
        public void actualiser()
        {
            datacompetitions.Rows.Clear();
            foreach(Copetition c in E.Lc)
            {
                if(c is Natation)
                {
                    Natation n = (Natation)c;
                    datacompetitions.Rows.Add(c.Code, c.Nom, c.Anne, c.Effectif, n.Type, "");
                }
                else
                {
                    Patinage n = (Patinage)c;
                    datacompetitions.Rows.Add(c.Code, c.Nom, c.Anne, c.Effectif, "", n.Categorie);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_competition.Items.Add("Natation");
            combo_competition.Items.Add("Patinage");
            combo_competition.SelectedIndex = 0;

            rb_individuel.Checked = true;

            combo_typenatation.Items.Add("Natation en au libre");
            combo_typenatation.Items.Add("Natation artistique");
            combo_typenatation.SelectedIndex = 0;

            combo_categorie.Items.Add("Patinage artistique");
            combo_categorie.Items.Add("Patinage de vitesse");
            combo_categorie.Items.Add("Patinage de vitesse sur pistes courts");
            combo_categorie.SelectedIndex = 0;

            panel2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_competition_TextChanged(object sender, EventArgs e)
        {
            if(combo_competition.Text== "Natation")
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            combo_competition.SelectedIndex = 0;
            text_code.Clear();
            text_nom.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rb_individuel.Checked = true;
            combo_typenatation.SelectedIndex = 0;

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if(text_code.Text!="" && text_nom.Text != "")
            {
                string s;
                if (rb_individuel.Checked) s = "Individuel";
                else s = "Collectif";

                if(combo_competition.Text== "Natation")
                {
                    Copetition x = new Natation(int.Parse(text_code.Text), text_nom.Text, dateTimePicker1.Value, s, combo_typenatation.Text);
                   bool r= E.Ajouter(x);
                    if (r == true)
                    {
                        MessageBox.Show("la competition a ete ajouter!!");
                        actualiser();
                    }
                    else
                    {
                        MessageBox.Show("cette competition deja existe");
                    }
                }
                else
                {
                    Copetition x = new Patinage(int.Parse(text_code.Text), text_nom.Text, dateTimePicker1.Value, s, combo_categorie.Text);
                    bool r = E.Ajouter(x);
                    if (r == true)
                    {
                        MessageBox.Show("la competition a ete ajouter!!");
                        actualiser();
                    }
                    else
                    {
                        MessageBox.Show("cette competition deja existe");
                    }
                }

            }

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datacompetitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("vous-avez sur!!","Confirmez votre choix!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string r = E.Supprimer(int.Parse(text_code.Text));
                MessageBox.Show(r);
                actualiser();
            }
           

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            string s;
            if (rb_individuel.Checked) s = "Individuel";
            else s = "Collectif";
            string r = E.Modifier(int.Parse(text_code.Text), text_nom.Text, dateTimePicker1.Value, s);
            MessageBox.Show(r);
            actualiser();
        }
    }
}
