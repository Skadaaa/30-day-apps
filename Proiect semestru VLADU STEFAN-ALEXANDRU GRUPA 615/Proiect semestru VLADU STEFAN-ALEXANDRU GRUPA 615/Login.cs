using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_semestru_VLADU_STEFAN_ALEXANDRU_GRUPA_615
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool state = false;
            MainProgram mainmenu = new MainProgram();

            if (File.Exists("User.txt") && File.Exists("Pass.txt"))
            {
                string user = userBox.Text;
                string pass = passBox.Text;

                int i, j;
                int aux = 0;
                string[] username = File.ReadAllLines("User.txt");
                string[] password = File.ReadAllLines("Pass.txt");
                for (i = 0; i < username.Length; i++)
                {
                    for (j = 0; j < password.Length; j++)
                    {
                        if (user == username[i])
                        {
                            state = true;
                            aux = i;

                        }
                        if (state == true && j == aux)
                        {
                            if (pass == password[j])
                            {

                                this.Hide();
                                mainmenu.Show();
                            }
                            else MessageBox.Show("Credentiale gresite", "Eroare");
                        }
                    }
                }
                if (state == false)
                {
                    MessageBox.Show("Credentiale gresite", "Eroare");
                    userBox.Clear();
                    passBox.Clear();
                }








            }
            else MessageBox.Show("Fisierele nu exista");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            this.Hide();
            reg.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            passBox.PasswordChar = '\0';
            label4.Visible = true;
            label3.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
            label3.Visible = true;
            label4.Hide();
        }
    }
}
