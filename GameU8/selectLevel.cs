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
    public partial class selectLevel : Form
    {
        // Initialise the code \\

        public selectLevel()
        {
            InitializeComponent();
        }



        // If you click the Level 1 Button, it should take you to form 1 \\

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // If you click the Level 2 Button, it should take you to form 2 \\

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        // If you click the Back Button, it should take you to the main menu \\

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }




    }
}
