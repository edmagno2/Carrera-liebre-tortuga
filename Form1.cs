using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tortuga t1 = new Tortuga(5);
        Liebre l1 = new Liebre(11);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                t1.correr();
                l1.correr();
                textBox1.Text = "";
                textBox1.Text = t1.ToString() + " " + Environment.NewLine + l1.ToString();
            } while (t1.posicion >= 100 && l1.posicion >= 100);
            if (t1.posicion >= 100 && l1.posicion >= 100)
            {
                textBox1.Text = "empate";
            }
            else
            {
                if (t1.posicion > l1.posicion)
                {
                    textBox1.Text = "Gano la tortuga";
                }
                else
                {
                    textBox1.Text = " Gano La liebre";
                }
            }

        }
    }
}
