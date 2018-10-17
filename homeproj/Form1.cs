using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeproj
{
	
	public partial class Form1 : Form
	{
		int[] a = new int[10];
		int i = 0,tot=0, j = 0;
		char[] op = new char[10];
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			i++;
			Result.Text = Result.Text + "-";
			
			op[j] = '-';
			j++;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			i++;
			Result.Text = Result.Text + "+";
			
			op[j] = '+';
			j++;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
				if (Result.Text == "0")
					Result.Clear();

			Result.Text=Result.Text+1;
			a[i] = 1;
			
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			
				if (Result.Text == "0")
					Result.Clear();

			Result.Text = Result.Text + 2;
			a[i] = 2;
			

		}

		private void button3_Click(object sender, EventArgs e)
		{
				if (Result.Text == "0")
					Result.Clear();


			Result.Text = Result.Text + 3;
			a[i] = 3;
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
				if (Result.Text == "0")
					Result.Clear();

			Result.Text = Result.Text + 4;
			a[i] = 4;
		
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (Result.Text == "0")
				Result.Clear();
			
				Result.Text = Result.Text + 5;
			a[i] = 5;
			
		}

		private void calc_Click(object sender, EventArgs e)
		{
			
			for (int y = 0; y <= j; y++)
			{
				if (op[y] == '+')
				{
					tot += a[y] + a[y + 1];
					
					
				}
				else if (op[y] == '-')
				{
					tot += a[y] - a[y + 1];
					
					
				}
				else
					Result.Text ="0";
			}

			
			a[0] = tot;
			i = 0;j = 0;
			Result.Text =Convert.ToString(tot);
			tot = 0;
		}
	}
}
