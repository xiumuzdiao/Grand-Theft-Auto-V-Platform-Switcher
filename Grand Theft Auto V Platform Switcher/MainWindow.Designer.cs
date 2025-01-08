namespace Grand_Theft_Auto_V_Platform_Switcher
{
	// Token: 0x02000003 RID: 3
	public partial class MainWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000034ED File Offset: 0x000016ED
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000350C File Offset: 0x0000170C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grand_Theft_Auto_V_Platform_Switcher.MainWindow));
			this.lblTextGameVer = new global::System.Windows.Forms.Label();
			this.lblGameVer = new global::System.Windows.Forms.Label();
			this.BtnLaunch = new global::System.Windows.Forms.Button();
			this.btnFixPlayOnSteam = new global::System.Windows.Forms.Button();
			this.btnSteamInstalled = new global::System.Windows.Forms.Button();
			this.Extra = new global::System.Windows.Forms.Label();
			this.btnEpic = new global::System.Windows.Forms.Button();
			this.BtnSteam = new global::System.Windows.Forms.Button();
			this.BtnRGL = new global::System.Windows.Forms.Button();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkForUpdatesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.troubleshootingToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.btnFixPlayOnEpic = new global::System.Windows.Forms.Button();
			this.btnInstallEpic = new global::System.Windows.Forms.Button();
			this.lblRunAsAdmin = new global::System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.lblTextGameVer.AutoSize = true;
			this.lblTextGameVer.Location = new global::System.Drawing.Point(12, 196);
			this.lblTextGameVer.Name = "lblTextGameVer";
			this.lblTextGameVer.Size = new global::System.Drawing.Size(123, 65);
			this.lblTextGameVer.TabIndex = 4;
			this.lblTextGameVer.Text = "Game version:\r\nRGL files version:\r\nSteam files version:\r\nEpic games files version:\r\nCurrent platform:";
			this.lblTextGameVer.Click += new global::System.EventHandler(this.LblTextGameVer_Click);
			this.lblGameVer.AutoSize = true;
			this.lblGameVer.Location = new global::System.Drawing.Point(141, 196);
			this.lblGameVer.Name = "lblGameVer";
			this.lblGameVer.Size = new global::System.Drawing.Size(94, 65);
			this.lblGameVer.TabIndex = 5;
			this.lblGameVer.Text = "varGameVer\r\nvarRGLVer\r\nvarSteamVer\r\nvarEpicVer\r\nvarCurrentPlatform\r\n";
			this.lblGameVer.Click += new global::System.EventHandler(this.LblGameVer_Click);
			this.BtnLaunch.Location = new global::System.Drawing.Point(15, 264);
			this.BtnLaunch.Name = "BtnLaunch";
			this.BtnLaunch.Size = new global::System.Drawing.Size(201, 23);
			this.BtnLaunch.TabIndex = 0;
			this.BtnLaunch.Text = "&Launch Game";
			this.BtnLaunch.UseVisualStyleBackColor = true;
			this.BtnLaunch.Click += new global::System.EventHandler(this.BtnLaunch_Click);
			this.btnFixPlayOnSteam.Location = new global::System.Drawing.Point(222, 179);
			this.btnFixPlayOnSteam.Name = "btnFixPlayOnSteam";
			this.btnFixPlayOnSteam.Size = new global::System.Drawing.Size(171, 23);
			this.btnFixPlayOnSteam.TabIndex = 5;
			this.btnFixPlayOnSteam.Text = "Remove \"on Steam\" from RGL\r\n";
			this.btnFixPlayOnSteam.UseVisualStyleBackColor = true;
			this.btnFixPlayOnSteam.Click += new global::System.EventHandler(this.btnFixPlayOnSteam_Click);
			this.btnSteamInstalled.Location = new global::System.Drawing.Point(222, 237);
			this.btnSteamInstalled.Name = "btnSteamInstalled";
			this.btnSteamInstalled.Size = new global::System.Drawing.Size(171, 23);
			this.btnSteamInstalled.TabIndex = 7;
			this.btnSteamInstalled.Text = "Add \"on Steam\" to RGL";
			this.btnSteamInstalled.UseVisualStyleBackColor = true;
			this.btnSteamInstalled.Click += new global::System.EventHandler(this.btnSteamInstalled_Click);
			this.Extra.AutoSize = true;
			this.Extra.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.Extra.Location = new global::System.Drawing.Point(218, 152);
			this.Extra.Name = "Extra";
			this.Extra.Size = new global::System.Drawing.Size(183, 24);
			this.Extra.TabIndex = 8;
			this.Extra.Text = "Additional options:";
			this.btnEpic.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.EGL;
			this.btnEpic.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnEpic.Location = new global::System.Drawing.Point(270, 27);
			this.btnEpic.Name = "btnEpic";
			this.btnEpic.Size = new global::System.Drawing.Size(123, 123);
			this.btnEpic.TabIndex = 4;
			this.btnEpic.UseVisualStyleBackColor = true;
			this.btnEpic.Click += new global::System.EventHandler(this.btnEpic_Click);
			this.BtnSteam.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.Steam;
			this.BtnSteam.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.BtnSteam.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.BtnSteam.Location = new global::System.Drawing.Point(141, 27);
			this.BtnSteam.Name = "BtnSteam";
			this.BtnSteam.Size = new global::System.Drawing.Size(123, 123);
			this.BtnSteam.TabIndex = 3;
			this.BtnSteam.UseVisualStyleBackColor = true;
			this.BtnSteam.Click += new global::System.EventHandler(this.BtnSteam_Click);
			this.BtnRGL.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.RGL;
			this.BtnRGL.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.BtnRGL.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.BtnRGL.ForeColor = global::System.Drawing.Color.White;
			this.BtnRGL.Location = new global::System.Drawing.Point(12, 27);
			this.BtnRGL.Name = "BtnRGL";
			this.BtnRGL.Size = new global::System.Drawing.Size(123, 123);
			this.BtnRGL.TabIndex = 2;
			this.BtnRGL.UseVisualStyleBackColor = true;
			this.BtnRGL.Click += new global::System.EventHandler(this.Button1_Click);
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.checkForUpdatesToolStripMenuItem, this.toolStripMenuItem2, this.exitToolStripMenuItem });
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			this.checkForUpdatesToolStripMenuItem.Enabled = false;
			this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
			this.checkForUpdatesToolStripMenuItem.Size = new global::System.Drawing.Size(308, 22);
			this.checkForUpdatesToolStripMenuItem.Text = "&Total rework project has started, stay tuned...";
			this.checkForUpdatesToolStripMenuItem.Click += new global::System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(305, 6);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(308, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.ExitToolStripMenuItem_Click);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem, this.troubleshootingToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(191, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.AboutToolStripMenuItem_Click);
			this.troubleshootingToolStripMenuItem.Name = "troubleshootingToolStripMenuItem";
			this.troubleshootingToolStripMenuItem.Size = new global::System.Drawing.Size(191, 22);
			this.troubleshootingToolStripMenuItem.Text = "&How to install and use";
			this.troubleshootingToolStripMenuItem.Click += new global::System.EventHandler(this.troubleshootingToolStripMenuItem_Click);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.helpToolStripMenuItem });
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(408, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.btnFixPlayOnEpic.Location = new global::System.Drawing.Point(222, 208);
			this.btnFixPlayOnEpic.Name = "btnFixPlayOnEpic";
			this.btnFixPlayOnEpic.Size = new global::System.Drawing.Size(171, 23);
			this.btnFixPlayOnEpic.TabIndex = 6;
			this.btnFixPlayOnEpic.Text = "Remove \"on Epic\" from RGL";
			this.btnFixPlayOnEpic.UseVisualStyleBackColor = true;
			this.btnFixPlayOnEpic.Click += new global::System.EventHandler(this.btnFixPlayOnEpic_Click);
			this.btnInstallEpic.Location = new global::System.Drawing.Point(222, 264);
			this.btnInstallEpic.Name = "btnInstallEpic";
			this.btnInstallEpic.Size = new global::System.Drawing.Size(171, 23);
			this.btnInstallEpic.TabIndex = 8;
			this.btnInstallEpic.Text = "Add \"on Epic\" to RGL";
			this.btnInstallEpic.UseVisualStyleBackColor = true;
			this.btnInstallEpic.Click += new global::System.EventHandler(this.btnInstallEpic_Click);
			this.lblRunAsAdmin.AutoSize = true;
			this.lblRunAsAdmin.Location = new global::System.Drawing.Point(9, 160);
			this.lblRunAsAdmin.Name = "lblRunAsAdmin";
			this.lblRunAsAdmin.Size = new global::System.Drawing.Size(192, 13);
			this.lblRunAsAdmin.TabIndex = 9;
			this.lblRunAsAdmin.Text = "Run as admin to enable locked buttons";
			this.lblRunAsAdmin.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(408, 304);
			base.Controls.Add(this.lblRunAsAdmin);
			base.Controls.Add(this.btnInstallEpic);
			base.Controls.Add(this.btnFixPlayOnEpic);
			base.Controls.Add(this.btnEpic);
			base.Controls.Add(this.Extra);
			base.Controls.Add(this.btnSteamInstalled);
			base.Controls.Add(this.btnFixPlayOnSteam);
			base.Controls.Add(this.BtnLaunch);
			base.Controls.Add(this.lblGameVer);
			base.Controls.Add(this.lblTextGameVer);
			base.Controls.Add(this.BtnSteam);
			base.Controls.Add(this.BtnRGL);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "MainWindow";
			this.Text = "Grand Theft Auto V Platform Switcher";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button BtnRGL;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button BtnSteam;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label lblTextGameVer;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label lblGameVer;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button BtnLaunch;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button btnFixPlayOnSteam;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button btnSteamInstalled;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label Extra;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button btnEpic;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ToolStripMenuItem troubleshootingToolStripMenuItem;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button btnFixPlayOnEpic;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button btnInstallEpic;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label lblRunAsAdmin;
	}
}
