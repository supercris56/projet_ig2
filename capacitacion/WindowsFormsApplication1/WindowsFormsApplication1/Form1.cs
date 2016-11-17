using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("IBM.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Asesor")
            {
                if (this.textBox2.Text == "1234")
                {
                    Asesor llamar = new Asesor();
                    llamar.Show();
                }
                else
                {
                    if (this.textBox1.Text == "Administrador")
                    {
                        if (this.textBox2.Text == "1234")
                        {
                            Administrador llamar = new Administrador();
                            llamar.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contrasena Invalido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contrasena Invalido");
                    }
                    //MessageBox.Show("Usuario o Contrasena Invalido");
                }
            }
            else 
            {
                if (this.textBox1.Text == "Administrador")
                {
                    if (this.textBox2.Text == "1234")
                    {
                        Administrador llamar = new Administrador();
                        llamar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contrasena Invalido");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena Invalido");
                }
                // MessageBox.Show("Usuario o Contrasena Invalido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
