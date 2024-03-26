namespace lab2_CG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addPoint = new System.Windows.Forms.Button();
            this.textBox_t1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_t2 = new System.Windows.Forms.TextBox();
            this.comboBox_calculationMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_selectMethod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_startX = new System.Windows.Forms.TextBox();
            this.textBox_endX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_findPoints = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_noRow = new System.Windows.Forms.TextBox();
            this.btn_findMatrixElements = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_sumDiagonals = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a point of the characteristic rectangle of \r\nthe Bezier curve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(66, 355);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(200, 34);
            this.textBox_X.TabIndex = 3;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(66, 410);
            this.textBox_Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(200, 34);
            this.textBox_Y.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(645, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 497);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(281, 451);
            this.btn_addPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(128, 48);
            this.btn_addPoint.TabIndex = 6;
            this.btn_addPoint.Text = "Add point";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // textBox_t1
            // 
            this.textBox_t1.Location = new System.Drawing.Point(103, 191);
            this.textBox_t1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_t1.Name = "textBox_t1";
            this.textBox_t1.Size = new System.Drawing.Size(74, 34);
            this.textBox_t1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the interval t:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(203, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "to";
            // 
            // textBox_t2
            // 
            this.textBox_t2.Location = new System.Drawing.Point(259, 191);
            this.textBox_t2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_t2.Name = "textBox_t2";
            this.textBox_t2.Size = new System.Drawing.Size(74, 34);
            this.textBox_t2.TabIndex = 11;
            // 
            // comboBox_calculationMethod
            // 
            this.comboBox_calculationMethod.FormattingEnabled = true;
            this.comboBox_calculationMethod.Items.AddRange(new object[] {
            "Parametric formula",
            "Matrix formula"});
            this.comboBox_calculationMethod.Location = new System.Drawing.Point(32, 73);
            this.comboBox_calculationMethod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_calculationMethod.Name = "comboBox_calculationMethod";
            this.comboBox_calculationMethod.Size = new System.Drawing.Size(282, 34);
            this.comboBox_calculationMethod.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Please select the Bezier curve calculation method";
            // 
            // button_selectMethod
            // 
            this.button_selectMethod.Location = new System.Drawing.Point(343, 66);
            this.button_selectMethod.Margin = new System.Windows.Forms.Padding(4);
            this.button_selectMethod.Name = "button_selectMethod";
            this.button_selectMethod.Size = new System.Drawing.Size(119, 47);
            this.button_selectMethod.TabIndex = 14;
            this.button_selectMethod.Text = "OK";
            this.button_selectMethod.UseVisualStyleBackColor = true;
            this.button_selectMethod.Click += new System.EventHandler(this.button_selectMethod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(26, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Find all points on the x-axis";
            // 
            // textBox_startX
            // 
            this.textBox_startX.Location = new System.Drawing.Point(109, 602);
            this.textBox_startX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_startX.Name = "textBox_startX";
            this.textBox_startX.Size = new System.Drawing.Size(74, 34);
            this.textBox_startX.TabIndex = 16;
            // 
            // textBox_endX
            // 
            this.textBox_endX.Location = new System.Drawing.Point(259, 600);
            this.textBox_endX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_endX.Name = "textBox_endX";
            this.textBox_endX.Size = new System.Drawing.Size(74, 34);
            this.textBox_endX.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(26, 600);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(203, 600);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "to";
            // 
            // button_findPoints
            // 
            this.button_findPoints.Location = new System.Drawing.Point(381, 598);
            this.button_findPoints.Margin = new System.Windows.Forms.Padding(4);
            this.button_findPoints.Name = "button_findPoints";
            this.button_findPoints.Size = new System.Drawing.Size(129, 41);
            this.button_findPoints.TabIndex = 22;
            this.button_findPoints.Text = "Find";
            this.button_findPoints.UseVisualStyleBackColor = true;
            this.button_findPoints.Click += new System.EventHandler(this.button_findPoints_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 529);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 78);
            this.label10.TabIndex = 23;
            this.label10.Text = "Find the elements of the row of the matrix N \r\n\r\nunder the number No";
            // 
            // textBox_noRow
            // 
            this.textBox_noRow.Location = new System.Drawing.Point(864, 573);
            this.textBox_noRow.Name = "textBox_noRow";
            this.textBox_noRow.Size = new System.Drawing.Size(79, 34);
            this.textBox_noRow.TabIndex = 24;
            // 
            // btn_findMatrixElements
            // 
            this.btn_findMatrixElements.Location = new System.Drawing.Point(962, 567);
            this.btn_findMatrixElements.Name = "btn_findMatrixElements";
            this.btn_findMatrixElements.Size = new System.Drawing.Size(129, 45);
            this.btn_findMatrixElements.TabIndex = 25;
            this.btn_findMatrixElements.Text = "OK";
            this.btn_findMatrixElements.UseVisualStyleBackColor = true;
            this.btn_findMatrixElements.Click += new System.EventHandler(this.btn_findMatrixElements_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(382, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "The sum of the main and side diagonals";
            // 
            // btn_sumDiagonals
            // 
            this.btn_sumDiagonals.Location = new System.Drawing.Point(962, 693);
            this.btn_sumDiagonals.Name = "btn_sumDiagonals";
            this.btn_sumDiagonals.Size = new System.Drawing.Size(129, 45);
            this.btn_sumDiagonals.TabIndex = 27;
            this.btn_sumDiagonals.Text = "Find out";
            this.btn_sumDiagonals.UseVisualStyleBackColor = true;
            this.btn_sumDiagonals.Click += new System.EventHandler(this.btn_sumDiagonals_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(416, 451);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(128, 48);
            this.btn_reset.TabIndex = 28;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 862);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sumDiagonals);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_findMatrixElements);
            this.Controls.Add(this.textBox_noRow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_findPoints);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_endX);
            this.Controls.Add(this.textBox_startX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_selectMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_calculationMethod);
            this.Controls.Add(this.textBox_t2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_t1);
            this.Controls.Add(this.btn_addPoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Construction of the Bezier curve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addPoint;
        private System.Windows.Forms.TextBox textBox_t1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_t2;
        private System.Windows.Forms.ComboBox comboBox_calculationMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_selectMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_startX;
        private System.Windows.Forms.TextBox textBox_endX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_findPoints;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_noRow;
        private System.Windows.Forms.Button btn_findMatrixElements;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_sumDiagonals;
        private System.Windows.Forms.Button btn_reset;
    }
}

