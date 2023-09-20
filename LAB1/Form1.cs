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
			label_ushort.Text = long.MinValue + "..." + long.MinValue;
		}

		private void label2_Click(object sender, EventArgs e)
		{
			label_long.Text = int.MinValue + "..." + int.MinValue;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			label_int.Text = float.MinValue + "..." int.MinValue;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}