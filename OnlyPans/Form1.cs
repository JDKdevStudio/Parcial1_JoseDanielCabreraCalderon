using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (userInput.Text == "admin" && passInput.Text == "admin")
            {
                using (MainPanel mainPanel = new MainPanel()) {
                    mainPanel.UserType = "admin";
                    this.Hide();
                    mainPanel.ShowDialog();
                    this.Close();
                }
            }
            else if (userInput.Text == "panadero" && passInput.Text == "panadero")
            {
                using (MainPanel mainPanel = new MainPanel())
                {
                    mainPanel.UserType = "panadero";
                    this.Hide();
                    mainPanel.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                userInput.Clear();
                passInput.Clear();
                MessageBox.Show("Usuario incorrecto/no existe");
            }
        }
    }
}
