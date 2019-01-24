using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overview
{
    public partial class Userinterface : Form
    {
        public Userinterface()
        {
            InitializeComponent();
            errorLeider.Visible = false;
        }

        private void Userinterface_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (leiderInput.Text == "")
            {
                errorLeider.Visible = true;
            }
            else
            {
                leiderField.Text = leiderInput.Text;
            }                      
        }

        private void LeiderInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (inputNr1.Text == "" || inputNr2.Text == "" || inputNr3.Text == "")
            {
                errorTop.Text = "Niet alle velden zijn ingevuld...";
            }
            else
            {

            }
        }
    }
}
