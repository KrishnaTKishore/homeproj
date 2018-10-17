namespace homeproj
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
			this.Add = new System.Windows.Forms.Button();
			this.Sub = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Result = new System.Windows.Forms.TextBox();
			this.Calc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(525, 209);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 0;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Sub
			// 
			this.Sub.Location = new System.Drawing.Point(525, 280);
			this.Sub.Name = "Sub";
			this.Sub.Size = new System.Drawing.Size(75, 23);
			this.Sub.TabIndex = 1;
			this.Sub.Text = "Sub";
			this.Sub.UseVisualStyleBackColor = true;
			this.Sub.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(45, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(138, 174);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 32);
			this.button2.TabIndex = 3;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(227, 174);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 32);
			this.button3.TabIndex = 4;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(312, 174);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(56, 32);
			this.button4.TabIndex = 5;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(393, 174);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(56, 32);
			this.button5.TabIndex = 6;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Result
			// 
			this.Result.Location = new System.Drawing.Point(121, 102);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(178, 20);
			this.Result.TabIndex = 7;
			this.Result.Text = "0";
			this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Calc
			// 
			this.Calc.Location = new System.Drawing.Point(113, 268);
			this.Calc.Name = "Calc";
			this.Calc.Size = new System.Drawing.Size(80, 34);
			this.Calc.TabIndex = 8;
			this.Calc.Text = "=";
			this.Calc.UseVisualStyleBackColor = true;
			this.Calc.Click += new System.EventHandler(this.calc_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Calc);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Sub);
			this.Controls.Add(this.Add);
			this.Name = "Form1";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Sub;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox Result;
		private System.Windows.Forms.Button Calc;
	}
}

