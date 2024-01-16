namespace ShapeGUI
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.calculatePerimeterSquare = new System.Windows.Forms.Button();
			this.calculateAreaSquare = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSquareHeight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSquareWidth = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.calculatePerimeterCircle = new System.Windows.Forms.Button();
			this.calculateAreaCircle = new System.Windows.Forms.Button();
			this.textBoxCircleRadius = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.calculatePerimeterTriangle = new System.Windows.Forms.Button();
			this.calculateAreaTriangle = new System.Windows.Forms.Button();
			this.textBoxSideC = new System.Windows.Forms.TextBox();
			this.textBoxSideB = new System.Windows.Forms.TextBox();
			this.textBoxSideA = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(29, 98);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1212, 712);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.calculatePerimeterSquare);
			this.tabPage1.Controls.Add(this.calculateAreaSquare);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textBoxSquareHeight);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBoxSquareWidth);
			this.tabPage1.Location = new System.Drawing.Point(8, 39);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1196, 665);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Square";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// calculatePerimeterSquare
			// 
			this.calculatePerimeterSquare.Location = new System.Drawing.Point(77, 326);
			this.calculatePerimeterSquare.Name = "calculatePerimeterSquare";
			this.calculatePerimeterSquare.Size = new System.Drawing.Size(242, 50);
			this.calculatePerimeterSquare.TabIndex = 5;
			this.calculatePerimeterSquare.Text = "Calculate Perimeter";
			this.calculatePerimeterSquare.UseVisualStyleBackColor = true;
			this.calculatePerimeterSquare.Click += new System.EventHandler(this.calculatePerimeterSquare_Click);
			// 
			// calculateAreaSquare
			// 
			this.calculateAreaSquare.Location = new System.Drawing.Point(77, 241);
			this.calculateAreaSquare.Name = "calculateAreaSquare";
			this.calculateAreaSquare.Size = new System.Drawing.Size(242, 47);
			this.calculateAreaSquare.TabIndex = 4;
			this.calculateAreaSquare.Text = "Calculate Area";
			this.calculateAreaSquare.UseVisualStyleBackColor = true;
			this.calculateAreaSquare.Click += new System.EventHandler(this.calculateAreaSquare_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Enter Height:";
			// 
			// textBoxSquareHeight
			// 
			this.textBoxSquareHeight.Location = new System.Drawing.Point(218, 135);
			this.textBoxSquareHeight.Name = "textBoxSquareHeight";
			this.textBoxSquareHeight.Size = new System.Drawing.Size(383, 31);
			this.textBoxSquareHeight.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Enter Width:";
			// 
			// textBoxSquareWidth
			// 
			this.textBoxSquareWidth.Location = new System.Drawing.Point(218, 70);
			this.textBoxSquareWidth.Name = "textBoxSquareWidth";
			this.textBoxSquareWidth.Size = new System.Drawing.Size(383, 31);
			this.textBoxSquareWidth.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.calculatePerimeterCircle);
			this.tabPage2.Controls.Add(this.calculateAreaCircle);
			this.tabPage2.Controls.Add(this.textBoxCircleRadius);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(8, 39);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1196, 665);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Circle";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// calculatePerimeterCircle
			// 
			this.calculatePerimeterCircle.Location = new System.Drawing.Point(101, 265);
			this.calculatePerimeterCircle.Name = "calculatePerimeterCircle";
			this.calculatePerimeterCircle.Size = new System.Drawing.Size(255, 52);
			this.calculatePerimeterCircle.TabIndex = 3;
			this.calculatePerimeterCircle.Text = "Calculate Perimeter";
			this.calculatePerimeterCircle.UseVisualStyleBackColor = true;
			this.calculatePerimeterCircle.Click += new System.EventHandler(this.calculatePerimeterCircle_Click);
			// 
			// calculateAreaCircle
			// 
			this.calculateAreaCircle.Location = new System.Drawing.Point(101, 177);
			this.calculateAreaCircle.Name = "calculateAreaCircle";
			this.calculateAreaCircle.Size = new System.Drawing.Size(255, 49);
			this.calculateAreaCircle.TabIndex = 2;
			this.calculateAreaCircle.Text = "Calculate Area";
			this.calculateAreaCircle.UseVisualStyleBackColor = true;
			this.calculateAreaCircle.Click += new System.EventHandler(this.calculateAreaCircle_Click);
			// 
			// textBoxCircleRadius
			// 
			this.textBoxCircleRadius.Location = new System.Drawing.Point(267, 67);
			this.textBoxCircleRadius.Name = "textBoxCircleRadius";
			this.textBoxCircleRadius.Size = new System.Drawing.Size(274, 31);
			this.textBoxCircleRadius.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(96, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Enter Radius:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.calculatePerimeterTriangle);
			this.tabPage3.Controls.Add(this.calculateAreaTriangle);
			this.tabPage3.Controls.Add(this.textBoxSideC);
			this.tabPage3.Controls.Add(this.textBoxSideB);
			this.tabPage3.Controls.Add(this.textBoxSideA);
			this.tabPage3.Location = new System.Drawing.Point(8, 39);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1196, 665);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Triangle";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(46, 268);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(235, 25);
			this.label8.TabIndex = 7;
			this.label8.Text = "Enter Length of Side C:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(46, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(234, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "Enter Length of Side B:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(46, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(234, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Enter Length of Side A:";
			// 
			// calculatePerimeterTriangle
			// 
			this.calculatePerimeterTriangle.Location = new System.Drawing.Point(294, 460);
			this.calculatePerimeterTriangle.Name = "calculatePerimeterTriangle";
			this.calculatePerimeterTriangle.Size = new System.Drawing.Size(256, 41);
			this.calculatePerimeterTriangle.TabIndex = 4;
			this.calculatePerimeterTriangle.Text = "Calculate Perimeter";
			this.calculatePerimeterTriangle.UseVisualStyleBackColor = true;
			this.calculatePerimeterTriangle.Click += new System.EventHandler(this.calculatePerimeterTriangle_Click);
			// 
			// calculateAreaTriangle
			// 
			this.calculateAreaTriangle.Location = new System.Drawing.Point(294, 383);
			this.calculateAreaTriangle.Name = "calculateAreaTriangle";
			this.calculateAreaTriangle.Size = new System.Drawing.Size(256, 39);
			this.calculateAreaTriangle.TabIndex = 3;
			this.calculateAreaTriangle.Text = "Calculate Area";
			this.calculateAreaTriangle.UseVisualStyleBackColor = true;
			this.calculateAreaTriangle.Click += new System.EventHandler(this.calculateAreaTriangle_Click);
			// 
			// textBoxSideC
			// 
			this.textBoxSideC.Location = new System.Drawing.Point(294, 263);
			this.textBoxSideC.Name = "textBoxSideC";
			this.textBoxSideC.Size = new System.Drawing.Size(349, 31);
			this.textBoxSideC.TabIndex = 2;
			// 
			// textBoxSideB
			// 
			this.textBoxSideB.Location = new System.Drawing.Point(294, 166);
			this.textBoxSideB.Name = "textBoxSideB";
			this.textBoxSideB.Size = new System.Drawing.Size(349, 31);
			this.textBoxSideB.TabIndex = 1;
			// 
			// textBoxSideA
			// 
			this.textBoxSideA.Location = new System.Drawing.Point(294, 78);
			this.textBoxSideA.Name = "textBoxSideA";
			this.textBoxSideA.Size = new System.Drawing.Size(349, 31);
			this.textBoxSideA.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(433, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "AREA AND PERIMETER CALCULATOR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(531, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Please choose a shape!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 833);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSquareWidth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calculateAreaSquare;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxSquareHeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button calculatePerimeterSquare;
		private System.Windows.Forms.TextBox textBoxCircleRadius;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button calculateAreaCircle;
		private System.Windows.Forms.Button calculatePerimeterCircle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button calculatePerimeterTriangle;
		private System.Windows.Forms.Button calculateAreaTriangle;
		private System.Windows.Forms.TextBox textBoxSideC;
		private System.Windows.Forms.TextBox textBoxSideB;
		private System.Windows.Forms.TextBox textBoxSideA;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}

