namespace Grand_Theft_Auto_V_Platform_Switcher
{
	// Token: 0x02000002 RID: 2
	public partial class AboutWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020BA File Offset: 0x000002BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020DC File Offset: 0x000002DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grand_Theft_Auto_V_Platform_Switcher.AboutWindow));
			this.btnOkay = new global::System.Windows.Forms.Button();
			this.lblDescription = new global::System.Windows.Forms.Label();
			this.lblMadeBy = new global::System.Windows.Forms.Label();
			this.lblProductName = new global::System.Windows.Forms.Label();
			this.LblClickQIWI = new global::System.Windows.Forms.LinkLabel();
			this.LblProductVersion = new global::System.Windows.Forms.Label();
			this.LinkLblTS = new global::System.Windows.Forms.LinkLabel();
			this.LinkLblTG = new global::System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.btnOkay.Location = new global::System.Drawing.Point(359, 244);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new global::System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 0;
			this.btnOkay.Text = "&OK";
			this.btnOkay.UseVisualStyleBackColor = true;
			this.btnOkay.Click += new global::System.EventHandler(this.BtnOkay_Click);
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblDescription.Location = new global::System.Drawing.Point(12, 167);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new global::System.Drawing.Size(417, 60);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Utility for easy switching between Rockstar Games\r\nLauncher, Steam and Epic Games Launcher with just only\r\none installation";
			this.lblMadeBy.AutoSize = true;
			this.lblMadeBy.Location = new global::System.Drawing.Point(13, 227);
			this.lblMadeBy.Name = "lblMadeBy";
			this.lblMadeBy.Size = new global::System.Drawing.Size(116, 13);
			this.lblMadeBy.TabIndex = 2;
			this.lblMadeBy.Text = "Made by TechnoStone";
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 202);
			this.lblProductName.Location = new global::System.Drawing.Point(0, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new global::System.Drawing.Size(445, 29);
			this.lblProductName.TabIndex = 4;
			this.lblProductName.Text = "Grand Theft Auto V Platform Switcher";
			this.LblClickQIWI.AutoSize = true;
			this.LblClickQIWI.Location = new global::System.Drawing.Point(93, 249);
			this.LblClickQIWI.Name = "LblClickQIWI";
			this.LblClickQIWI.Size = new global::System.Drawing.Size(42, 13);
			this.LblClickQIWI.TabIndex = 5;
			this.LblClickQIWI.TabStop = true;
			this.LblClickQIWI.Text = "Donate";
			this.LblClickQIWI.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.LblProductVersion.AutoSize = true;
			this.LblProductVersion.Location = new global::System.Drawing.Point(13, 249);
			this.LblProductVersion.Name = "LblProductVersion";
			this.LblProductVersion.Size = new global::System.Drawing.Size(74, 13);
			this.LblProductVersion.TabIndex = 6;
			this.LblProductVersion.Text = "LblProductVer";
			this.LblProductVersion.Click += new global::System.EventHandler(this.LblProductVersion_Click);
			this.LinkLblTS.AutoSize = true;
			this.LinkLblTS.Location = new global::System.Drawing.Point(135, 227);
			this.LinkLblTS.Name = "LinkLblTS";
			this.LinkLblTS.Size = new global::System.Drawing.Size(60, 13);
			this.LinkLblTS.TabIndex = 9;
			this.LinkLblTS.TabStop = true;
			this.LinkLblTS.Text = "My website";
			this.LinkLblTS.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblTS_LinkClicked);
			this.LinkLblTG.AutoSize = true;
			this.LinkLblTG.Location = new global::System.Drawing.Point(201, 227);
			this.LinkLblTG.Name = "LinkLblTG";
			this.LinkLblTG.Size = new global::System.Drawing.Size(51, 13);
			this.LinkLblTG.TabIndex = 10;
			this.LinkLblTG.TabStop = true;
			this.LinkLblTG.Text = "Telegram";
			this.LinkLblTG.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblTG_LinkClicked);
			this.pictureBox1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.Switcher;
			this.pictureBox1.Location = new global::System.Drawing.Point(5, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(429, 128);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(446, 271);
			base.Controls.Add(this.LinkLblTG);
			base.Controls.Add(this.LinkLblTS);
			base.Controls.Add(this.LblProductVersion);
			base.Controls.Add(this.LblClickQIWI);
			base.Controls.Add(this.lblProductName);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.lblMadeBy);
			base.Controls.Add(this.lblDescription);
			base.Controls.Add(this.btnOkay);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutWindow";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			base.Load += new global::System.EventHandler(this.AboutWindow_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button btnOkay;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label lblDescription;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label lblMadeBy;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label lblProductName;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.LinkLabel LblClickQIWI;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label LblProductVersion;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.LinkLabel LinkLblTS;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.LinkLabel LinkLblTG;
	}
}
