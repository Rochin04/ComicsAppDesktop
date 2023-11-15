namespace ComicsAPPDesktop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripSplitButton();
            changeThemeToolStripMenuItem = new ToolStripMenuItem();
            darToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1780, 34);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.ForeColor = Color.Red;
            toolStripLabel1.LinkColor = Color.Red;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(119, 29);
            toolStripLabel1.Text = "ComicsDCMC";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { changeThemeToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(91, 29);
            toolStripSplitButton1.Text = "&Setings";
            // 
            // changeThemeToolStripMenuItem
            // 
            changeThemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darToolStripMenuItem, toolStripMenuItem2 });
            changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            changeThemeToolStripMenuItem.Size = new Size(232, 34);
            changeThemeToolStripMenuItem.Text = "&Change Theme";
            // 
            // darToolStripMenuItem
            // 
            darToolStripMenuItem.Name = "darToolStripMenuItem";
            darToolStripMenuItem.Size = new Size(215, 34);
            darToolStripMenuItem.Text = "&Dark theme";
            darToolStripMenuItem.Click += darToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(215, 34);
            toolStripMenuItem2.Text = "&White theme";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(929, 34);
            label1.Name = "label1";
            label1.Size = new Size(76, 48);
            label1.TabIndex = 3;
            label1.Text = "List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(894, 116);
            label2.Name = "label2";
            label2.Size = new Size(156, 38);
            label2.TabIndex = 4;
            label2.Text = "Add Comic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(725, 199);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(762, 263);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 6;
            label4.Text = "Tags";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(701, 339);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 7;
            label5.Text = "Date Added";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(697, 414);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 8;
            label6.Text = "Date Release";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(760, 491);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 9;
            label7.Text = "Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(749, 566);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 10;
            label8.Text = "Writer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 640);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 11;
            label9.Text = "Artist";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(815, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(815, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(815, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(376, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(815, 408);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 31);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(815, 485);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(376, 31);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(815, 560);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(376, 31);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(814, 634);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(376, 31);
            textBox7.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(938, 718);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 19;
            button1.Text = "Add Comic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(938, 783);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 20;
            button2.Text = "Ver Comics";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1780, 916);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem changeThemeToolStripMenuItem;
        private ToolStripMenuItem darToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
    }
}