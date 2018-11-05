using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7Exercise
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Input in Celsius
            double temperature = Convert.ToDouble(txtInput.Text);

            // Convert to Fahrenheit (temperature Celsius * 1.8) =32
            double convertedTemperature = Convert.ToDouble(temperature * 1.8) + 32;

            //Decision about weather
            if(convertedTemperature >= 70)
            {
                lblOutput.Text = "It is " + convertedTemperature + " it's Warm!";
                btnCalculate.BackColor = Color.Red;
                btnCalculate.ForeColor = Color.Yellow;
            }
            if(convertedTemperature <70)
            {
                lblOutput.Text = "It is " + convertedTemperature + " it's Cool!";
                btnCalculate.BackColor = Color.LightBlue;
                btnCalculate.ForeColor = Color.LightGray;
            }
            if(convertedTemperature <= 32)
            {
                lblOutput.Text = "It is " + convertedTemperature + " it's Cold!";
                btnCalculate.BackColor = Color.DarkBlue;
                btnCalculate.ForeColor = Color.White;
            }

            //Output
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
