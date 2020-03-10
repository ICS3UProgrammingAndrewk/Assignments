/*
 * Created by: Andrew Kuekam
 * Created on: 2020-02-19
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Object
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectAndrew
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare the local variables
            double time, answer;

            // Convert the object in the textbox to a double
            time = double.Parse(txtTime.Text);

            // this calculate the Height 
            answer = 100 - 0.5 * 9.81 * Math.Pow(time, 2);
            // this displays the label 
            this.lblAnswer.Show();
            this.lblAnswer.Text = Convert.ToString(answer) + "m";

            // if the object has reached the ground
            if(answer < 0)
            {
                this.lblAnswer.Text = "The object has reached the ground";
            }
            if (time< 0 )
            {
                this.lblAnswer.Text = "Please input only positive numbers";
            }

        }
    }
}
