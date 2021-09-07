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
    public partial class MainPanel : Form
    {
        public string UserType;
        public MainPanel()
        {
            InitializeComponent();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            if (UserType == "panadero")
            {
                AdminBtn.Visible = false;
            }
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            using (AdminPanel adminPanel = new AdminPanel())
            {
                adminPanel.ShowDialog();
             }
        }

        private void PanaderoBtn_Click(object sender, EventArgs e)
        {
            using (PanaderoPanel panaderoPanel = new PanaderoPanel())
            {
                panaderoPanel.ShowDialog();
            }
        }
    }
}
