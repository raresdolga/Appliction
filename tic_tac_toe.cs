using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_si_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;

        }

        private void afisare()
        {
            if (jucator % 2 == 0)
                MessageBox.Show("The winer is" + textBox2.Text);
            else
                if(jucator%2!=0)
                MessageBox.Show("the winer is" + textBox3.Text);

             

        }
        private void Click_b(object sender, EventArgs e)
        {
            k++;

            if (jucator % 2 == 0)
            {
                ((Button)sender).Text = "X";
                ((Button)sender).Enabled = false;
            }
            else
            {
                ((Button)sender).Text = "0";
                ((Button)sender).Enabled = false;
            }
            check_winer();
            jucator++;
           
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                n = Convert.ToInt32(textBox1.Text);
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= n; j++)
                    {
                        b[i, j] = new Button();
                        b[i, j].Top = 40 * i + 20;
                        b[i, j].Left = 40 * j;
                        b[i, j].Height = 40;
                        b[i, j].Width = 40;
                        Controls.Add(b[i, j]);
                        b[i, j].Click += new EventHandler(Click_b);
                       
                    }

               


            }
        }
        private void check_winer()
        {
            int exista = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {if(i-2>0&&j-2>0)
                    if (b[i, j].Text == b[i - 1, j - 1].Text && b[i - 1, j - 1].Text == b[i - 2, j - 2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if (i + 2 <=n && j + 2 <= n)
                        if (b[i, j].Text == b[i + 1, j + 1].Text && b[i + 1, j + 1].Text == b[i + 2, j + 2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if (i - 2 > 0 &&j+2<=n)
                        if (b[i, j].Text == b[i - 1, j + 1].Text && b[i - 1, j + 1].Text == b[i - 2, j + 2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if(i+2<=n&&j-2>0)
if (b[i, j].Text == b[i + 1, j - 1].Text && b[i + 1, j - 1].Text == b[i + 2, j - 2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if ( j - 2 > 0)
                        if (b[i, j].Text == b[i, j - 1].Text && b[i, j - 1].Text == b[i, j - 2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if ( j + 2 <= n)
                        if (b[i, j].Text == b[i, j + 1].Text && b[i, j + 1].Text == b[i, j +2].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if (i - 2 > 0)
                        if (b[i, j].Text == b[i - 1, j].Text && b[i - 1, j].Text == b[i - 2, j].Text && (!b[i, j].Enabled))
                            exista = 1;
                    if (i + 2 <=n)
                        if (b[i, j].Text == b[i + 1, j].Text && b[i + 1, j].Text == b[i + 2, j].Text && (!b[i, j].Enabled))
                            exista = 1;

                    }
            if (exista == 1) afisare();
            else
        if (k == n*n) MessageBox.Show("mata, Rares castjiga");
                        

                

        }
        private void scrietivaNumeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    Controls.Remove(b[i, j]);

        }
    }
}
