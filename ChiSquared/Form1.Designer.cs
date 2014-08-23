namespace ChiSquared
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbRat5 = new ChiSquared.NumberBox();
            this.lblRat5 = new System.Windows.Forms.Label();
            this.nbRat4 = new ChiSquared.NumberBox();
            this.lblRat4 = new System.Windows.Forms.Label();
            this.nbRat3 = new ChiSquared.NumberBox();
            this.lblRat3 = new System.Windows.Forms.Label();
            this.nbRat2 = new ChiSquared.NumberBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nbRat1 = new ChiSquared.NumberBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.oTot = new System.Windows.Forms.Label();
            this.eTot = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbV3 = new System.Windows.Forms.CheckBox();
            this.cbV4 = new System.Windows.Forms.CheckBox();
            this.cbV5 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.analysis = new System.Windows.Forms.TextBox();
            this.chiAns = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.resultsTable = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblOe2e = new System.Windows.Forms.Label();
            this.lblOe2 = new System.Windows.Forms.Label();
            this.lblYork = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.dataTable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.resultsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbRat5);
            this.groupBox1.Controls.Add(this.lblRat5);
            this.groupBox1.Controls.Add(this.nbRat4);
            this.groupBox1.Controls.Add(this.lblRat4);
            this.groupBox1.Controls.Add(this.nbRat3);
            this.groupBox1.Controls.Add(this.lblRat3);
            this.groupBox1.Controls.Add(this.nbRat2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nbRat1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.dataTable);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // nbRat5
            // 
            this.nbRat5.Enabled = false;
            this.nbRat5.Location = new System.Drawing.Point(383, 110);
            this.nbRat5.Name = "nbRat5";
            this.nbRat5.Size = new System.Drawing.Size(28, 20);
            this.nbRat5.TabIndex = 14;
            this.nbRat5.TextChanged += new System.EventHandler(this.ratio_TextChanged);
            // 
            // lblRat5
            // 
            this.lblRat5.AutoSize = true;
            this.lblRat5.Location = new System.Drawing.Point(335, 113);
            this.lblRat5.Name = "lblRat5";
            this.lblRat5.Size = new System.Drawing.Size(41, 13);
            this.lblRat5.TabIndex = 13;
            this.lblRat5.Text = "Ratio 5";
            // 
            // nbRat4
            // 
            this.nbRat4.Enabled = false;
            this.nbRat4.Location = new System.Drawing.Point(301, 111);
            this.nbRat4.Name = "nbRat4";
            this.nbRat4.Size = new System.Drawing.Size(28, 20);
            this.nbRat4.TabIndex = 12;
            this.nbRat4.TextChanged += new System.EventHandler(this.ratio_TextChanged);
            // 
            // lblRat4
            // 
            this.lblRat4.AutoSize = true;
            this.lblRat4.Location = new System.Drawing.Point(253, 114);
            this.lblRat4.Name = "lblRat4";
            this.lblRat4.Size = new System.Drawing.Size(41, 13);
            this.lblRat4.TabIndex = 11;
            this.lblRat4.Text = "Ratio 4";
            // 
            // nbRat3
            // 
            this.nbRat3.Enabled = false;
            this.nbRat3.Location = new System.Drawing.Point(219, 111);
            this.nbRat3.Name = "nbRat3";
            this.nbRat3.Size = new System.Drawing.Size(28, 20);
            this.nbRat3.TabIndex = 10;
            this.nbRat3.TextChanged += new System.EventHandler(this.ratio_TextChanged);
            // 
            // lblRat3
            // 
            this.lblRat3.AutoSize = true;
            this.lblRat3.Location = new System.Drawing.Point(171, 114);
            this.lblRat3.Name = "lblRat3";
            this.lblRat3.Size = new System.Drawing.Size(41, 13);
            this.lblRat3.TabIndex = 9;
            this.lblRat3.Text = "Ratio 3";
            // 
            // nbRat2
            // 
            this.nbRat2.Location = new System.Drawing.Point(137, 111);
            this.nbRat2.Name = "nbRat2";
            this.nbRat2.Size = new System.Drawing.Size(28, 20);
            this.nbRat2.TabIndex = 8;
            this.nbRat2.TextChanged += new System.EventHandler(this.ratio_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Ratio 2";
            // 
            // nbRat1
            // 
            this.nbRat1.Location = new System.Drawing.Point(55, 110);
            this.nbRat1.Name = "nbRat1";
            this.nbRat1.Size = new System.Drawing.Size(28, 20);
            this.nbRat1.TabIndex = 6;
            this.nbRat1.TextChanged += new System.EventHandler(this.ratio_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ratio 1";
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(643, 109);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnCount = 7;
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dataTable.Controls.Add(this.label1, 0, 0);
            this.dataTable.Controls.Add(this.label8, 0, 1);
            this.dataTable.Controls.Add(this.label7, 6, 0);
            this.dataTable.Controls.Add(this.label6, 5, 0);
            this.dataTable.Controls.Add(this.label5, 4, 0);
            this.dataTable.Controls.Add(this.label4, 3, 0);
            this.dataTable.Controls.Add(this.label3, 2, 0);
            this.dataTable.Controls.Add(this.label2, 1, 0);
            this.dataTable.Controls.Add(this.label9, 0, 2);
            this.dataTable.Controls.Add(this.oTot, 6, 1);
            this.dataTable.Controls.Add(this.eTot, 6, 2);
            this.dataTable.Controls.Add(this.label13, 0, 3);
            this.dataTable.Controls.Add(this.cbV3, 3, 3);
            this.dataTable.Controls.Add(this.cbV4, 4, 3);
            this.dataTable.Controls.Add(this.cbV5, 5, 3);
            this.dataTable.Location = new System.Drawing.Point(7, 20);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowCount = 5;
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.Size = new System.Drawing.Size(711, 83);
            this.dataTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observed";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Totals";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Variable 5";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Variable 4";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Variable 3";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Variable 2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variable 1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Expected";
            // 
            // oTot
            // 
            this.oTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oTot.AutoSize = true;
            this.oTot.Location = new System.Drawing.Point(652, 23);
            this.oTot.Name = "oTot";
            this.oTot.Size = new System.Drawing.Size(13, 13);
            this.oTot.TabIndex = 44;
            this.oTot.Text = "0";
            // 
            // eTot
            // 
            this.eTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eTot.AutoSize = true;
            this.eTot.Location = new System.Drawing.Point(652, 43);
            this.eTot.Name = "eTot";
            this.eTot.Size = new System.Drawing.Size(13, 13);
            this.eTot.TabIndex = 45;
            this.eTot.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Enabled";
            // 
            // cbV3
            // 
            this.cbV3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbV3.AutoSize = true;
            this.cbV3.Location = new System.Drawing.Point(346, 63);
            this.cbV3.Name = "cbV3";
            this.cbV3.Size = new System.Drawing.Size(15, 14);
            this.cbV3.TabIndex = 14;
            this.cbV3.UseVisualStyleBackColor = true;
            this.cbV3.CheckedChanged += new System.EventHandler(this.enabledRow);
            // 
            // cbV4
            // 
            this.cbV4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbV4.AutoSize = true;
            this.cbV4.Location = new System.Drawing.Point(447, 63);
            this.cbV4.Name = "cbV4";
            this.cbV4.Size = new System.Drawing.Size(15, 14);
            this.cbV4.TabIndex = 15;
            this.cbV4.UseVisualStyleBackColor = true;
            this.cbV4.CheckedChanged += new System.EventHandler(this.enabledRow);
            // 
            // cbV5
            // 
            this.cbV5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbV5.AutoSize = true;
            this.cbV5.Location = new System.Drawing.Point(548, 63);
            this.cbV5.Name = "cbV5";
            this.cbV5.Size = new System.Drawing.Size(15, 14);
            this.cbV5.TabIndex = 16;
            this.cbV5.UseVisualStyleBackColor = true;
            this.cbV5.CheckedChanged += new System.EventHandler(this.enabledRow);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(562, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisSoftwareToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutThisSoftwareToolStripMenuItem
            // 
            this.aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
            this.aboutThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutThisSoftwareToolStripMenuItem.Text = "About this software";
            this.aboutThisSoftwareToolStripMenuItem.Click += new System.EventHandler(this.aboutThisSoftwareToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.analysis);
            this.groupBox2.Controls.Add(this.chiAns);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.resultsTable);
            this.groupBox2.Location = new System.Drawing.Point(13, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 156);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Analysis";
            // 
            // analysis
            // 
            this.analysis.Location = new System.Drawing.Point(58, 156);
            this.analysis.Multiline = true;
            this.analysis.Name = "analysis";
            this.analysis.ReadOnly = true;
            this.analysis.Size = new System.Drawing.Size(658, 34);
            this.analysis.TabIndex = 3;
            // 
            // chiAns
            // 
            this.chiAns.AutoSize = true;
            this.chiAns.Location = new System.Drawing.Point(38, 134);
            this.chiAns.Name = "chiAns";
            this.chiAns.Size = new System.Drawing.Size(13, 13);
            this.chiAns.TabIndex = 2;
            this.chiAns.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "X^2";
            // 
            // resultsTable
            // 
            this.resultsTable.ColumnCount = 7;
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.resultsTable.Controls.Add(this.label22, 0, 0);
            this.resultsTable.Controls.Add(this.label10, 6, 0);
            this.resultsTable.Controls.Add(this.label18, 1, 0);
            this.resultsTable.Controls.Add(this.label17, 2, 0);
            this.resultsTable.Controls.Add(this.label16, 3, 0);
            this.resultsTable.Controls.Add(this.label12, 4, 0);
            this.resultsTable.Controls.Add(this.label11, 5, 0);
            this.resultsTable.Controls.Add(this.label19, 0, 1);
            this.resultsTable.Controls.Add(this.lblOe2e, 0, 4);
            this.resultsTable.Controls.Add(this.lblOe2, 0, 3);
            this.resultsTable.Controls.Add(this.lblYork, 0, 2);
            this.resultsTable.Location = new System.Drawing.Point(7, 20);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowCount = 5;
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultsTable.Size = new System.Drawing.Size(710, 105);
            this.resultsTable.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Totals";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(124, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Variable 1";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Variable 2";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(326, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Variable 3";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Variable 4";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Variable 5";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "(O - E)";
            // 
            // lblOe2e
            // 
            this.lblOe2e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOe2e.AutoSize = true;
            this.lblOe2e.Location = new System.Drawing.Point(17, 86);
            this.lblOe2e.Name = "lblOe2e";
            this.lblOe2e.Size = new System.Drawing.Size(67, 13);
            this.lblOe2e.TabIndex = 15;
            this.lblOe2e.Text = "(O - E)^2 / E";
            // 
            // lblOe2
            // 
            this.lblOe2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOe2.AutoSize = true;
            this.lblOe2.Location = new System.Drawing.Point(26, 63);
            this.lblOe2.Name = "lblOe2";
            this.lblOe2.Size = new System.Drawing.Size(49, 13);
            this.lblOe2.TabIndex = 14;
            this.lblOe2.Text = "(O - E)^2";
            // 
            // lblYork
            // 
            this.lblYork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYork.AutoSize = true;
            this.lblYork.Enabled = false;
            this.lblYork.Location = new System.Drawing.Point(18, 43);
            this.lblYork.Name = "lblYork";
            this.lblYork.Size = new System.Drawing.Size(65, 13);
            this.lblYork.TabIndex = 17;
            this.lblYork.Text = "(|O - E| - 0.5)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chi Squared";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataTable.ResumeLayout(false);
            this.dataTable.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.resultsTable.ResumeLayout(false);
            this.resultsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel dataTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbV5;
        private System.Windows.Forms.CheckBox cbV4;
        private System.Windows.Forms.CheckBox cbV3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oTot;
        private System.Windows.Forms.Label eTot;
        private System.Windows.Forms.TableLayoutPanel resultsTable;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblOe2e;
        private System.Windows.Forms.Label lblOe2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox analysis;
        private System.Windows.Forms.Label chiAns;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblYork;
        private NumberBox nbRat5;
        private System.Windows.Forms.Label lblRat5;
        private NumberBox nbRat4;
        private System.Windows.Forms.Label lblRat4;
        private NumberBox nbRat3;
        private System.Windows.Forms.Label lblRat3;
        private NumberBox nbRat2;
        private System.Windows.Forms.Label label15;
        private NumberBox nbRat1;
        private System.Windows.Forms.Label label14;

    }
}

