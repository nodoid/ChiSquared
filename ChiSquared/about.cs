using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChiSquared
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            textBox1.Text = "To calculate the chi squared value for a given set of data and the compare to the critical values.";
            textBox2.Text = "Warrington Collegiate will not be held responsible for the misinterpretation of any data or ";
            textBox2.Text += "problems there-in. Use is purely for academic use - outside of this, you're on your own!";
        }
    }
}
