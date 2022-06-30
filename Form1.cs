using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntertheMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            int idade;
            string nome;
            string sobrenome;
            int anonascimento;
            nome = txtnome.Text;
            sobrenome = txtsobrenome.Text;
            anonascimento = int.Parse(txtnascimento.Text);
            idade = int.Parse(DateTime.Now.ToString("yyyy")) - anonascimento;

            if(idade >= 18)
            {
                lblmensagem.Text = nome + " " + sobrenome + idade + " anos";
                picture.Image = Properties.Resources.rodrigos_620x410;
            }
            else
            {
                lblmensagem.Text = "NÃO VAI DAR NAMORO";
                picture.Image = Properties.Resources.FUM8H_yXEAAshHl;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
