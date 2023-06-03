using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_votacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int c1 = 0, c2 = 0, votos = 0;

        private void BtnVotar_Click(object sender, EventArgs e)
        {
            TxtCandidato_uno.Enabled = false;
            TxtCandidato_dos.Enabled = false;
            Btnc1.Visible = true;
            Btnc2.Visible = true;
            BtnVotar.Enabled = false;
        }

        private void Btnc1_Click(object sender, EventArgs e)
        {
            votos = Convert.ToInt32(label7.Text);
            votos--;

            if (votos < 0)
            {

                MessageBox.Show("error");

            }
            else {
                label7.Text = votos.ToString();
                c1++;
                lblconteoc1.Text = c1.ToString();
            
            }
        }


        private void Btnc2_Click(object sender, EventArgs e)
        {

            votos = Convert.ToInt32(label7.Text);
            votos--;

            if (votos < 0)
            {
               MessageBox.Show("error");

            }
            else
            {
                label7.Text = votos.ToString();
                c2++;
                lblconteoc2.Text = c2.ToString();
            }

        }

        private void lblconteo2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btnc1.Visible = false;
            Btnc2.Visible = false;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            c1 = 0;
            c2 = 0;
           
            Btnc1.Visible = false;
            Btnc2.Visible = false;

            TxtCandidato_uno.Enabled = true;
            TxtCandidato_dos.Enabled = true;
            BtnVotar.Enabled = true;
            TxtCandidato_uno.Text = "";
            TxtCandidato_dos.Text = "";
            lblc1.Text = "";
            lblc2.Text = "";
            TxtCandidato_uno.Focus ();
            label7.Text = "900";



        }
    }
}
