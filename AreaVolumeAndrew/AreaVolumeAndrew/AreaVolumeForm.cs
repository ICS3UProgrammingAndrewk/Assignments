/*
  * Created by: Andrew Kuekam
  * Created on: 2020-03-30
  * Created for: ICS3U Programming
  * Daily Assignment – Assignment 5b - Area and Volume
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

namespace AreaVolumeAndrew
{
    public partial class frmAreaVolume : Form
    {
        public frmAreaVolume()
        {
            InitializeComponent();
        }

        private void frmAreaVolume_Load(object sender, EventArgs e)
        {
            //hide the perimeter and answer until the user click on the calculate
            this.lblAreaAnswer.Hide();
            this.lblVolumeAnswer.Hide();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            //This diclare the variable
            double Area, Base, Height, Radius, Length, Volume, Width;
            double PI = 3.14;

            //this convert text to double
            Area = double.Parse(txtArea.Text);
            Base = double.Parse(txtBase.Text);
            Height = double.Parse(txtHeight.Text);
            Radius = double.Parse(txtRadius.Text);
            Length = double.Parse(txtLength.Text);
            Width = double.Parse(txtWidth.Text);

            //This Calculate the Area and the Volume of the Shapes
            Area = ((Area + Base) / 2) * Height;
            Area = Base * Height;
            Area = Area * Area;
            Area = (0.5 * Base * Height);
            Area = (3.14) * Radius * Radius;
            Volume = (3.14) * Radius * Radius * Height;
            Volume = (Length * Base * Height) / 2;
            Volume = (Length * Width * Height) / 3;
            Volume = 4 / 3 * 3.14 * Radius * Radius * Radius;
            Volume = (1 / 3) * 3.14 * Radius * Radius * Height;
            Volume = Area * Area * Area;

            //insert the area and Volume of shapes
            this.lblDisplayArea.Text = Convert.ToString(Area);
            this.lblDisplayVolume.Text = Convert.ToString(Volume);

            // display the area and Volume lable with the respective answer
            this.lblDisplayVolume.Show();
            this.lblDisplayArea.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //This cose the program
            this.Close();
        }
