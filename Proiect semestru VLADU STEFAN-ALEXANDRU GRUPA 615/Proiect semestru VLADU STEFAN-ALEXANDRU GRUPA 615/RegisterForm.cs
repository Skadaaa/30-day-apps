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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool stare = false;
            string user = Environment.NewLine+boxUser.Text+Environment.NewLine;
            string pass = Environment.NewLine+ boxPass.Text + Environment.NewLine;

            if(stare==false)
            {
                File.AppendAllText("User.txt", user);
                File.AppendAllText("Pass.txt", pass);
                stare = true;
            }
            if (stare == true)
            {
                MessageBox.Show("Succesfully registered");
            }
            else MessageBox.Show("Register failed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            
            this.Hide();
            log.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            boxPass.PasswordChar = '*';
            label4.Hide();
            label3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            boxPass.PasswordChar = '\0';
            label3.Hide();
            label4.Show();
        }
    }
}
