namespace ComicsAPPDesktop
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripSplitButton();
            changeThemeToolStripMenuItem = new ToolStripMenuItem();
            darToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
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
            toolStrip1.Size = new Size(1742, 34);
            toolStrip1.TabIndex = 4;
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
            changeThemeToolStripMenuItem.Size = new Size(270, 34);
            changeThemeToolStripMenuItem.Text = "&Change Theme";
            // 
            // darToolStripMenuItem
            // 
            darToolStripMenuItem.Name = "darToolStripMenuItem";
            darToolStripMenuItem.Size = new Size(270, 34);
            darToolStripMenuItem.Text = "&Dark theme";
            darToolStripMenuItem.Click += darToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(270, 34);
            toolStripMenuItem2.Text = "&White theme";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1742, 736);
            Controls.Add(toolStrip1);
            Name = "Form5";
            Text = "Form5";
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
    }
}