using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Simulateur_des
{
    public partial class Form1 : Form
    {
        int face;
        //int sum;
        //int[] results;
        String show;
        String Condition = "";
        Historique journal;
        Random randy= new Random();

        public Form1()
        {
            InitializeComponent();
            piped_values.Text= "";
            journal = new Historique();
        }

        private void d4_Click(object sender, EventArgs e)
        {
            face = 4;
        }

        private void d6_Click(object sender, EventArgs e)
        {
            face = 6;
        }

        private void d8_Click(object sender, EventArgs e)
        {
            face = 8;
        }

        private void d10_Click(object sender, EventArgs e)
        {
            face = 10;
        }

        private void d12_Click(object sender, EventArgs e)
        {
            face = 12;
        }

        private void d20_Click(object sender, EventArgs e)
        {
            face = 20;
        }

        private void d100_Click(object sender, EventArgs e)
        {
            face = 100;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //results = new int[int.Parse(textBox3.Text)];
        }

        private void jeter_Click(object sender, EventArgs e)
        {
            System.Timers.Timer waiter = new System.Timers.Timer();
            waiter.Interval=5000;
            show = "";
            Lancer l;
            if (piped_values.Text == "")
            {
                if(face==4)
                {
                    Jeter.Image = Resource.d4_gif;
                }
                Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                DeGenerique dg = new DeGenerique(face);
                l = new Lancer(dg, int.Parse(nb_des.Text));
                l.roll();
                journal.maj(l);
                for(int i = 0; i < l.Lancers.Length-1; i++)
                {
                    show += l.Lancers[i] + " + ";
                }
                show += l.Lancers[l.Lancers.Length-1] + " = " + l.resultat + " .";
                AffRes.Text = show;
            }
            else
            {
                String[] val_pip = piped_values.Text.Split(';');
                int[] temp_val = new int[val_pip.Length];
                for (int i = 0; i < val_pip.Length;i++)
                {
                    temp_val[i] = int.Parse(val_pip[i]);
                }
                DePipe dp = new DePipe(temp_val.Length, temp_val);
                l = new Lancer(dp, int.Parse(nb_des.Text));
                l.roll();
                journal.maj(l);
                for (int i = 0; i < l.Lancers.Length; i++)
                {
                    if(i< l.Lancers.Length - 1)
                    {
                        show += l.Lancers[i] + " + ";
                    }
                }
                show += l.Lancers[l.Lancers.Length - 1] + " = " + l.resultat + " .";
                AffRes.Text = show;

            }

            if (obj_text.Text != "")
            {
                Jeu j = new Jeu(int.Parse(obj_text.Text), Condition, l);
                j.ResultatJeu();
            }

            //show="" ;
            //sum = 0;
            //for(int i = 0; i < results.Length-1; i++)
            //{
            //    results[i] = randy.Next(1, face);
            //    show += results[i] + " + ";
            //    sum +=  results[i];
            //}
            //results[results.Length - 1] = randy.Next(1, face);
            //show += results[results.Length - 1] + " = ";
            //sum += results[results.Length - 1];
            //show += sum + " .";
            //textBox1.Text = show;
        }

        public void historique_Click(object sender, EventArgs e)
        {
            show = "";
            MessageBox mb;
            for(int i = 0; i < journal.histo.Count; i++)
            {
                if(journal.histo[i].De.pipe)
                {
                    show = "Dé personnalisé: ";
                }
                else
                {
                    show += "Dé à " + journal.histo[i].De.Face + " face: ";
                }
                for (int j = 0; j < journal.histo[i].Lancers.Length; j++)
                {
                    if (j < journal.histo[i].Lancers.Length - 1)
                    {
                        show += journal.histo[i].Lancers[j] + " + ";
                    }
                }
                show += journal.histo[i].Lancers[journal.histo[i].Lancers.Length - 1] + " = " + journal.histo[i].resultat + " ."+Environment.NewLine;
            }
            
            MessageBox.Show(show,"Historique de vos lancers.");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void obj_inf_Click(object sender, EventArgs e)
        {
            Condition = "<";
        }

        private void obj_egal_Click(object sender, EventArgs e)
        {
            Condition = "=";
        }

        private void obj_sup_Click(object sender, EventArgs e)
        {
            Condition = ">";
        }
    }
}
