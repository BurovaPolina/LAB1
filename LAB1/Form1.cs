namespace LAB1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{
			label_ushort.Text = ushort.MinValue + "..." + ushort.MaxValue;
		}

		private void label2_Click(object sender, EventArgs e)
		{
			label_long.Text = long.MinValue + "..." + long.MaxValue;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			label_int.Text = int.MinValue + "..." + int.MaxValue;
		}

		private void label4_Click(object sender, EventArgs e)
		{
			label_float.Text = float.MinValue + "..." + float.MaxValue;
		}

		private void button_short_Click(object sender, EventArgs e)
		{
            label_ushort.Text = ushort.MinValue + "..." + ushort.MaxValue;
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button_long_Click(object sender, EventArgs e)
		{
            label_long.Text = long.MinValue + "..." + long.MaxValue;
        }

		private void button_int_Click(object sender, EventArgs e)
		{
            label_int.Text = int.MinValue + "..." + int.MaxValue;
        }

		private void button_float_Click(object sender, EventArgs e)
		{
            label_float.Text = float.MinValue + "..." + float.MaxValue;
        }

		private void clear_Click(object sender, EventArgs e)
		{
			label_float.Text = "float";
			label_int.Text = "int";
			label_ushort.Text = "ushort";
			label_long.Text = "long";
        }
	}
}