using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace calcola_sottoreti
{
    public partial class Form1 : Form
    {
        public String classe;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Math.Log(int.Parse(sottoreti.Text), 2) + Math.Log(int.Parse(host.Text) + 2, 2) <= 8)
            {
                classe = "C";
            }
            else if (Math.Log(int.Parse(sottoreti.Text), 2) + Math.Log(int.Parse(host.Text) + 2, 2) <= 16)
            {
                classe = "B";
            }
            else if (Math.Log(int.Parse(sottoreti.Text), 2) + Math.Log(int.Parse(host.Text) + 2, 2) <= 24)
            {
                classe = "A";
            }
            else
            {
                //
                MessageBox.Show("numero eccessivo");
            }
            Classe.Text = classe;
            if (Classe.Text == "A")
            {
                Indirizzoprivato.Text = "10.0.0.0";
            }
            if (Classe.Text == "B")
            {
                Indirizzoprivato.Text = "172.16.0.0";
            }
            if (Classe.Text == "C")
            {
                Indirizzoprivato.Text = "192.168.0.0";
            }

        }

        private void sottoreti_TextChanged(object sender, EventArgs e)
        {

        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
