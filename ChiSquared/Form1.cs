using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChiSquared
{
    public partial class Form1 : Form
    {
        List<double> c2 = new List<double>();
        private NumberBox[] numbers;
        private Label[] expt, row1, row2, row3, row4;
        private int dof;

        public Form1()
        {
            InitializeComponent();
            generatec2();
            generateWidgets();
        }

        private void generateWidgets()
        {
            NumberBox[] nos = new NumberBox[6];
            Label[] ex = new Label[6];
            Label[] r1 = new Label[6];
            Label[] r2 = new Label[6];
            Label[] r3 = new Label[6];
            Label[] r4 = new Label[6];

            int n = 0;
            for (n = 0; n < 5; ++n)
            {
                nos[n] = new NumberBox();
                nos[n].AutoSize = true;
                nos[n].Location = new System.Drawing.Point(104 + (101 * n), 23);
                nos[n].Name = "Data" + n.ToString();
                nos[n].Size = new System.Drawing.Size(83, 17);
                nos[n].TabIndex = n;
                nos[n].Text = "";
                if (n > 1 && n < 5)
                    nos[n].Enabled = false;
            }
            dataTable.Controls.AddRange(nos);
            numbers = nos;
            for (n = 0; n < 5; ++n)
            {
                ex[n] = new Label();
                ex[n].AutoSize = true;
                ex[n].Anchor = System.Windows.Forms.AnchorStyles.None;
                ex[n].Location = new System.Drawing.Point(104 + (101 * n), 43);
                ex[n].Name = "Expected" + n.ToString();
                ex[n].Size = new System.Drawing.Size(83, 17);
                ex[n].TabIndex = n;
                ex[n].Text = "";
                if (n > 1 && n < 5)
                    ex[n].Enabled = false;
            }
            dataTable.Controls.AddRange(ex);
            expt = ex;
            for (n = 0; n < 6; ++n)
            {
                r1[n] = new Label();
                r1[n].Anchor = System.Windows.Forms.AnchorStyles.None;
                r1[n].AutoSize = true;
                r1[n].Location = new System.Drawing.Point(131 + (101 * n), 23);
                r1[n].Name = "Observed" + n.ToString();
                r1[n].Size = new System.Drawing.Size(41, 13);
                r1[n].TabIndex = 14;
                r1[n].Text = "0";
                if (n > 1 && n < 5)
                    r1[n].Enabled = false;
            }
            resultsTable.Controls.AddRange(r1);
            for (n = 0; n < 6; ++n)
            {
                r2[n] = new Label();
                r2[n].Anchor = System.Windows.Forms.AnchorStyles.None;
                r2[n].AutoSize = true;
                r2[n].Location = new System.Drawing.Point(131 + (101 * n), 23);
                r2[n].Name = "Observed" + n.ToString();
                r2[n].Size = new System.Drawing.Size(41, 13);
                r2[n].TabIndex = 14;
                r2[n].Text = "0";
                r2[n].Enabled = false;
            }
            resultsTable.Controls.AddRange(r2);
            for (n = 0; n < 6; ++n)
            {
                r3[n] = new Label();
                r3[n].Anchor = System.Windows.Forms.AnchorStyles.None;
                r3[n].AutoSize = true;
                r3[n].Location = new System.Drawing.Point(131 + (101 * n), 23);
                r3[n].Name = "Observed" + n.ToString();
                r3[n].Size = new System.Drawing.Size(41, 13);
                r3[n].TabIndex = 14;
                r3[n].Text = "0";
                if (n > 1 && n < 5)
                    r3[n].Enabled = false;
            }
            resultsTable.Controls.AddRange(r3);
            for (n = 0; n < 6; ++n)
            {
                r4[n] = new Label();
                r4[n].Anchor = System.Windows.Forms.AnchorStyles.None;
                r4[n].AutoSize = true;
                r4[n].Location = new System.Drawing.Point(131 + (101 * n), 23);
                r4[n].Name = "Observed" + n.ToString();
                r4[n].Size = new System.Drawing.Size(41, 13);
                r4[n].TabIndex = 14;
                r4[n].Text = "0";
                if (n > 1 && n < 5)
                    r4[n].Enabled = false;
            }
            resultsTable.Controls.AddRange(r4);
            row1 = r1;
            row2 = r2;
            row3 = r3;
            row4 = r4;
        }

        private void generatec2()
        {
            double[] n = new double[] {0, 0.004, 3.84, 6.64, 10.83,
            0.02, 0.103, 5.99, 9.21, 13.82,
            0.115, 0.352, 7.82, 11.35, 16.27,
            0.297, 0.711, 9.49, 13.28, 18.47,
            0.554, 1.145, 11.07, 15.09, 20.52,
            0.872, 1.635, 12.59, 16.81, 22.46,
            1.239, 2.167, 14.07, 18.48, 24.32,
            1.646, 2.733, 15.51, 20.09, 26.13,
            2.088, 3.325, 16.92, 21.67, 27.88,
            2.558, 3.94, 18.31, 23.21, 29.59,
            3.05, 4.58, 19.68, 24.73, 31.26,
            3.57, 5.23, 21.03, 26.22, 32.91,
            4.11, 5.89, 22.36, 27.69, 34.53,
            4.66, 6.57, 23.69, 29.14, 36.12,
            5.23, 7.26, 25.00, 30.58, 37.70,
            5.81, 7.96, 26.30, 32.00, 39.25,
            6.41, 8.67, 27.59, 33.41, 40.79,
            7.02, 9.39, 28.87, 34.81, 42.31,
            7.63, 10.12, 30.14, 36.19, 43.82,
            8.26, 10.85, 31.41, 37.57, 45.32,
            8.90, 11.59, 32.67, 38.93, 46.80,
            9.54, 12.34, 33.92, 40.29, 48.27,
            10.20, 13.09, 35.17, 41.64, 49.73,
            10.86, 13.85, 36.42, 42.98, 51.18,
            11.52, 14.61, 37.65, 44.31, 52.62,
            12.20, 15.38, 38.89, 45.64, 54.05,
            12.88, 16.15, 40.11, 46.96, 55.48,
            13.57, 16.93, 41.34, 48.28, 56.89,
            14.26, 17.71, 42.56, 49.59, 58.30,
            14.95, 18.49, 43.77, 50.89, 59.70};
            c2.AddRange(n);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double chi = 0;
            switch (b.Name)
            {
                case "btnClear":
                    clearData();
                    break;
                case "btnCalc":
                    chi = calcData();
                    chiAns.Text = string.Format("{0:0.0000}", chi);
                    compareToConfidence(chi);
                    break;
            }
        }

        private double calcData()
        {
            double chi = 0, e = 0, o = 0, oe = 0, oe2 = 0, oe2e = 0, york, ot = 0, et = 0;
            dof = 1;
            if (cbV5.Checked == true)
                dof = 4;
            if (cbV4.Checked == true && cbV5.Checked == false)
                dof = 3;
            if (cbV3.Checked == true && cbV4.Checked == false)
                dof = 2;
            double[] rats = new double[5];
            double [] ratio = new double[5];
            ratio[0] = Convert.ToDouble(nbRat1.Text);
            ratio[1] = Convert.ToDouble(nbRat2.Text);
            ratio[2] = nbRat3.Text != "" ? Convert.ToDouble(nbRat3.Text) : 0;
            ratio[3] = nbRat4.Text != "" ? Convert.ToDouble(nbRat4.Text) : 0;
            ratio[4] = nbRat5.Text != "" ? Convert.ToDouble(nbRat5.Text) : 0;
            int totRat = 0;
            for (int n = 0; n < 5; ++n)
                totRat += Convert.ToInt32(ratio[n]);
            double sr = 0;
            for (int n = 0; n < 5; ++n)
            {
                if (numbers[n].Text == "")
                    ot += 0;
                else
                    ot += Convert.ToDouble(numbers[n].Text);
            }
            sr = ot / totRat;
            for (int n = 0; n < dof + 1; ++n)
            {
                rats[n] = ot * (ratio[n] / totRat);
                expt[n].Text = rats[n].ToString();
            }
            for (int n = 0; n < 5; ++n)
            {
                if (rats[n] == 0)
                    et += 0;
                else
                    et += rats[n];
            }
            oTot.Text = ot.ToString();
            eTot.Text = et.ToString();

            if (dof == 1)
            {
                lblOe2.Text = "(|O - E|)^2";
                lblOe2e.Text = "(|O - E|)^2 / E";
                analysis.Text = "Only one degree of freedom so York correction is used. ";
            }

            int r = 0, c = 0;
            for (int n = 0; n < dof + 1; ++n)
            {
                o = Convert.ToDouble(numbers[n].Text);
                e = rats[n];
                oe = o - e;
                if (oe < 0)
                {
                    york = Math.Abs(oe) - 0.5;
                    york *= -1;
                }
                else
                    york = oe - .5;
                oe2 = Math.Pow(dof == 1 ? york : oe, 2);
                oe2e = oe2 / e;
                row1[r].Text = string.Format("{0:0.0000}", oe);
                if (dof == 1)
                {
                    lblYork.Enabled = true;
                    for (int m = 0; m < 6; ++m)
                        row2[m].Enabled = true;
                    row2[r].Text = string.Format("{0:0.0000}", york);
                }
                else
                {
                    lblYork.Enabled = false;
                    for (int m = 0; m < 6; ++m)
                        row2[m].Enabled = false;
                }
                row3[r].Text = string.Format("{0:0.0000}", oe2);
                row4[r].Text = string.Format("{0:0.0000}", oe2e);
                r++;
                chi += oe2e;
                c += 2;
            }
            return chi;
        }

        private void compareToConfidence(double chi)
        {
            double[] critical = new double[5];
            double[] probs = new double[5] { 0.99, 0.95, 0.05, 0.01, 0.001 };
            string a = "";
            int c = 0, m = 0, p = 0;
            if (dof != 1)
            {
                c = dof * 5;
                for (int r = c; r < c + 5; ++r)
                    critical[m++] = c2[r];
            }
            else
            {
                for (int r = 0; r < 5; ++r)
                    critical[m++] = c2[r];
            }
            if (chi < critical[0])
                p = 0;
            if (chi >= critical[0] && chi < critical[1])
                p = 0;
            if (chi >= critical[1] && chi < critical[2])
                p = 1;
            if (chi >= critical[2] && chi < critical[3])
                p = 2;
            if (chi >= critical[3] && chi < critical[4])
                p = 3;
            if (chi >= critical[4])
                p = 4;
            analysis.Text += "The result for the analysis corresponds to a probability of " + probs[p] + ". ";
            analysis.Text += "This value corresponds to a";
            switch (p)
            {
                case 0:
                    a = "n excellent agreement";
                    break;
                case 1:
                    a = " good agreement";
                    break;
                case 2:
                    a = " 50/50 agreement";
                    break;
                case 3:
                    a = " poor agreement";
                    break;
                case 4:
                    a = " large disagreement";
                    break;
            }
            analysis.Text += a + " with the null hypothesis";
        }

        private void clearData()
        {
            cbV3.Checked = cbV4.Checked = cbV5.Checked = false;
            oTot.Text = eTot.Text = "0";
            analysis.Text = "";
            lblOe2e.Text = "(O - E)^2 / E";
            lblOe2.Text = "(O - E)^2";
            chiAns.Text = "0";
            for (int n = 0; n < 5; ++n)
            {
                numbers[n].Text = "";
                if (n > 1 && n < 5)
                    numbers[n].Enabled = false;
            }
            for (int n = 0; n < 6; ++n)
            {
                row1[n].Text = row2[n].Text = row3[n].Text = row4[n].Text = "0";
                if (n > 1 && n < 5)
                    row1[n].Enabled = row3[n].Enabled = row4[n].Enabled = false;
                row2[n].Enabled = false;
            }
            nbRat3.Text = nbRat4.Text = nbRat5.Text = "0";
            lblYork.Enabled = nbRat3.Enabled = nbRat4.Enabled = nbRat5.Enabled = false;
        }

        private void enabledRow(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int s = 0;
            switch (cb.Name)
            {
                case "cbV3":
                    if (cb.Checked == false)
                    {
                        cbV4.Checked = cbV5.Checked = false;
                        clearRow(true, true, true);
                        return;
                    }
                    numbers[2].Enabled = row1[2].Enabled = row2[2].Enabled = row3[2].Enabled = true;
                    expt[2].Enabled = row4[2].Enabled = nbRat3.Enabled =true;
                    break;
                case "cbV4":
                    if (cb.Checked == false)
                    {
                        cbV5.Checked = false;
                        clearRow(false, true, true);
                        return;
                    }
                    s = 4;
                    cbV3.Checked = nbRat4.Enabled = true;
                    break;
                case "cbV5":
                    if (cb.Checked == false)
                    {
                        clearRow(false, false, true);
                        return;
                    }
                    s = 5;
                    cbV3.Checked = cbV4.Checked = nbRat5.Enabled = true;
                    break;
            }
            if (s != 0)
            {
                for (int n = 2; n < s; ++n)
                {
                    numbers[n].Enabled = row1[n].Enabled = row2[n].Enabled = row3[n].Enabled = true;
                    row4[n].Enabled = expt[n].Enabled = true;
                }
            }
        }

        private void clearRow(bool r1, bool r2, bool r3)
        {
            if (r1 == true)
            {
                numbers[2].Text = "";
                row1[2].Text = row2[2].Text = row3[2].Text = "0";
                numbers[2].Enabled = false;
                row1[2].Enabled = row2[2].Enabled = row3[3].Enabled = false;
            }
            if (r2 == true)
            {
                numbers[3].Text = "";
                row1[3].Text = row2[3].Text = row3[3].Text = "0";
                numbers[3].Enabled = false;
                row1[3].Enabled = row2[3].Enabled = row3[3].Enabled = false;
            }
            if (r3 == true)
            {
                numbers[4].Text = "";
                row1[4].Text = row2[4].Text = row3[4].Text = "0";
                numbers[4].Enabled = false;
                row1[4].Enabled = row2[4].Enabled = row3[4].Enabled = false;
            }
        }

        private void aboutThisSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about abt = new about();
            abt.Show();
        }

        private void ratio_TextChanged(object sender, EventArgs e)
        {
            if (nbRat1.Text != "" && nbRat2.Text != "")
                btnCalc.Enabled = true;
            else
                btnCalc.Enabled = false;
            if (nbRat3.Enabled == true && nbRat3.Text == "")
                btnCalc.Enabled = false;
            if (nbRat4.Enabled == true && nbRat4.Text == "")
                btnCalc.Enabled = false;
            if (nbRat5.Enabled == true && nbRat5.Text == "")
                btnCalc.Enabled = false;
        }
    }

    class NumberBox : TextBox
    {
        public NumberBox()
        {
            this.CausesValidation = true;
            this.Validating += new CancelEventHandler(TextBox_Validation);
        }

        private void TextBox_Validation(object sender, CancelEventArgs e)
        {
            try
            {
                double value = System.Double.Parse(this.Text);
            }
            catch (System.Exception)
            {
                e.Cancel = true;
            }
        }
    }
}
