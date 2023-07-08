using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameU8
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        
        private void mainMenu_Load(object sender, EventArgs e)
        {

        }



        // Start Button \\

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        // Select Level Button \\

        private void btnLevel_Click(object sender, EventArgs e)
        {
            selectLevel selectLevel = new selectLevel();
            selectLevel.Show();
            this.Hide();
        }

        
        // Option Button \\

        private void btnOption_Click(object sender, EventArgs e)
        {
            optionPage optionPage = new optionPage();
            optionPage.Show();
            this.Hide();
        }


        // Quit Button \\

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
