namespace LAB1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_float = new System.Windows.Forms.Label();
            this.label_int = new System.Windows.Forms.Label();
            this.label_long = new System.Windows.Forms.Label();
            this.label_ushort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_float);
            this.panel1.Controls.Add(this.label_int);
            this.panel1.Controls.Add(this.label_long);
            this.panel1.Controls.Add(this.label_ushort);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 220);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_float
            // 
            this.label_float.AutoSize = true;
            this.label_float.Location = new System.Drawing.Point(3, 72);
            this.label_float.Name = "label_float";
            this.label_float.Size = new System.Drawing.Size(31, 15);
            this.label_float.TabIndex = 3;
            this.label_float.Text = "float";
            this.label_float.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_int
            // 
            this.label_int.AutoSize = true;
            this.label_int.Location = new System.Drawing.Point(3, 48);
            this.label_int.Name = "label_int";
            this.label_int.Size = new System.Drawing.Size(21, 15);
            this.label_int.TabIndex = 2;
            this.label_int.Text = "int";
            this.label_int.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_long
            // 
            this.label_long.AutoSize = true;
            this.label_long.Location = new System.Drawing.Point(3, 24);
            this.label_long.Name = "label_long";
            this.label_long.Size = new System.Drawing.Size(31, 15);
            this.label_long.TabIndex = 1;
            this.label_long.Text = "long";
            this.label_long.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_ushort
            // 
            this.label_ushort.AutoSize = true;
            this.label_ushort.Location = new System.Drawing.Point(3, 0);
            this.label_ushort.Name = "label_ushort";
            this.label_ushort.Size = new System.Drawing.Size(41, 15);
            this.label_ushort.TabIndex = 0;
            this.label_ushort.Text = "ushort";
            this.label_ushort.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label label_ushort;
		private Label label_float;
		private Label label_int;
		private Label label_long;
	}
}