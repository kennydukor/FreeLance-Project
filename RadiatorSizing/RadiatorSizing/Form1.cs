using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiatorSizing
{
    public partial class Form1 : Form
    {
        double _engineCapacity;
        string Unit;
        double recommSize;
        double addition = 0d;
        double two;
        //conversion ecap = new conversion();

        private double EngineCapCal(double Cap)
        {
            //Add();
            two = (2 + addition);
            if (addition == 0)
            {
                Cap += 0;
            }
            else
            {
                Cap = Cap * two;
            }
            
            return Cap;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _engineCapacity =Int32.Parse(EngineCap.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            switch (VFRC.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = EngineCapCal(_engineCapacity).ToString() + " cm³";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = " ";

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox15.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox6.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox14.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox12.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox3.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox5.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox11.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox9.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox8.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.3d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox10.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.3d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.3d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox4.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.4d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox7.CheckState)
            {
                case CheckState.Checked:
                    addition += 0.6d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox22.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox21.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox20.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox19.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.1d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //VFRC.Text = string.Empty;
            //textBox2.Text = string.Empty;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox16.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox17.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox18.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox24.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.2d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox23.CheckState)
            {
                case CheckState.Checked:
                    addition -= 0.3d;
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    addition += 0d;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    addition += 0d;
                    break;
            }
        }

    }
}
