using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Grand_Theft_Auto_V_Platform_Switcher.Properties;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
	// Token: 0x02000003 RID: 3
	public partial class MainWindow : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002738 File Offset: 0x00000938
		public MainWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002814 File Offset: 0x00000A14
		public void Switch()
		{
			this.lblGameVer.Text = string.Concat(new string[] { this._gb, "\n", this._rglVer, "\n", this._steamVer, "\n", this._eglVer, "\n", this._cp });
			Process.Start("xcopy", "\"Switcher\\" + this._cp + "\" /f /y");
			if (this._cp == "RGL" || this._cp == "EGL")
			{
				if (!File.Exists(this._steamApi64Orig) || File.Exists(this._steamApi64Back))
				{
					goto IL_02FD;
				}
				try
				{
					File.Move("steam_api64.dll", "steam_api64.dll.steam");
					goto IL_02FD;
				}
				catch (Exception innerException)
				{
					using (StreamWriter streamWriter = new StreamWriter(this._exPath, true))
					{
						if (this._pp != "RGL" && this._pp != "EGL")
						{
							while (innerException != null)
							{
								streamWriter.WriteLine("-----------------------------------------------------------------------------");
								streamWriter.WriteLine("Date : " + DateTime.Now.ToString());
								streamWriter.WriteLine("Switching from " + this._pp + " to " + this._cp);
								streamWriter.WriteLine();
								streamWriter.WriteLine(innerException.GetType().FullName);
								streamWriter.WriteLine("Message : " + innerException.Message);
								streamWriter.WriteLine("StackTrace : " + innerException.StackTrace);
								innerException = innerException.InnerException;
							}
						}
					}
					goto IL_02FD;
				}
			}
			if (this._cp == "Steam")
			{
				if (!File.Exists(this._steamApi64Back) || File.Exists(this._steamApi64Orig))
				{
					goto IL_02FD;
				}
				try
				{
					File.Move("steam_api64.dll.steam", "steam_api64.dll");
					goto IL_02FD;
				}
				catch (Exception innerException2)
				{
					using (StreamWriter streamWriter2 = new StreamWriter(this._exPath, true))
					{
						if (this._pp != "Steam")
						{
							while (innerException2 != null)
							{
								streamWriter2.WriteLine("-----------------------------------------------------------------------------");
								streamWriter2.WriteLine("Date : " + DateTime.Now.ToString());
								streamWriter2.WriteLine("Switching from " + this._pp + " to " + this._cp);
								streamWriter2.WriteLine();
								streamWriter2.WriteLine(innerException2.GetType().FullName);
								streamWriter2.WriteLine("Message : " + innerException2.Message);
								streamWriter2.WriteLine("StackTrace : " + innerException2.StackTrace);
								innerException2 = innerException2.InnerException;
							}
						}
					}
					goto IL_02FD;
				}
			}
			MessageBox.Show(this._tmbIdkWhatAreYouTryingToDo, this._oops, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			IL_02FD:
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			configuration.AppSettings.Settings.Remove("PreviousPlatform");
			configuration.AppSettings.Settings.Add("PreviousPlatform", this._pp);
			configuration.AppSettings.Settings.Remove("CurrentPlatform");
			configuration.AppSettings.Settings.Add("CurrentPlatform", this._cp);
			configuration.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
			Thread.Sleep(1000);
			this.CheckVersions();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void CheckVersions()
		{
			if (!File.Exists(AppDomain.CurrentDomain.FriendlyName + ".config") && !File.Exists(AppDomain.CurrentDomain.FriendlyName + ".Config"))
			{
				MessageBox.Show(this._tmbConfigCorrupted, this._oops, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this._pp = ConfigurationManager.AppSettings["PreviousPlatform"];
			this._cp = ConfigurationManager.AppSettings["CurrentPlatform"];
			try
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\GTA5.exe");
				this._gb = versionInfo.FileVersion;
			}
			catch (Exception innerException)
			{
				using (StreamWriter streamWriter = new StreamWriter(this._exPath, true))
				{
					while (innerException != null)
					{
						streamWriter.WriteLine("-----------------------------------------------------------------------------");
						streamWriter.WriteLine("Date : " + DateTime.Now.ToString());
						streamWriter.WriteLine();
						streamWriter.WriteLine(innerException.GetType().FullName);
						streamWriter.WriteLine("Message : " + innerException.Message);
						streamWriter.WriteLine("StackTrace : " + innerException.StackTrace);
						innerException = innerException.InnerException;
					}
				}
			}
			try
			{
				FileVersionInfo versionInfo2 = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\Switcher\\RGL\\GTA5.exe");
				this._rglVer = versionInfo2.FileVersion;
			}
			catch (Exception innerException2)
			{
				using (StreamWriter streamWriter2 = new StreamWriter(this._exPath, true))
				{
					while (innerException2 != null)
					{
						streamWriter2.WriteLine("-----------------------------------------------------------------------------");
						streamWriter2.WriteLine("Date : " + DateTime.Now.ToString());
						streamWriter2.WriteLine();
						streamWriter2.WriteLine(innerException2.GetType().FullName);
						streamWriter2.WriteLine("Message : " + innerException2.Message);
						streamWriter2.WriteLine("StackTrace : " + innerException2.StackTrace);
						innerException2 = innerException2.InnerException;
					}
				}
			}
			try
			{
				FileVersionInfo versionInfo3 = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\Switcher\\Steam\\GTA5.exe");
				this._steamVer = versionInfo3.FileVersion;
			}
			catch (Exception innerException3)
			{
				using (StreamWriter streamWriter3 = new StreamWriter(this._exPath, true))
				{
					while (innerException3 != null)
					{
						streamWriter3.WriteLine("-----------------------------------------------------------------------------");
						streamWriter3.WriteLine("Date : " + DateTime.Now.ToString());
						streamWriter3.WriteLine();
						streamWriter3.WriteLine(innerException3.GetType().FullName);
						streamWriter3.WriteLine("Message : " + innerException3.Message);
						streamWriter3.WriteLine("StackTrace : " + innerException3.StackTrace);
						innerException3 = innerException3.InnerException;
					}
				}
			}
			try
			{
				FileVersionInfo versionInfo4 = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\Switcher\\EGL\\GTA5.exe");
				this._eglVer = versionInfo4.FileVersion;
			}
			catch (Exception innerException4)
			{
				using (StreamWriter streamWriter4 = new StreamWriter(this._exPath, true))
				{
					while (innerException4 != null)
					{
						streamWriter4.WriteLine("-----------------------------------------------------------------------------");
						streamWriter4.WriteLine("Date : " + DateTime.Now.ToString());
						streamWriter4.WriteLine();
						streamWriter4.WriteLine(innerException4.GetType().FullName);
						streamWriter4.WriteLine("Message : " + innerException4.Message);
						streamWriter4.WriteLine("StackTrace : " + innerException4.StackTrace);
						innerException4 = innerException4.InnerException;
					}
				}
			}
			if (this._pp != "Steam" && this._pp != "RGL" && this._pp != "EGL")
			{
				this._pp = "Unknown";
			}
			if (this._cp != "Steam" && this._cp != "RGL" && this._cp != "EGL")
			{
				this._cp = "Unknown";
			}
			if (this._gb.Length <= 0 || this._gb == null)
			{
				this._gb = "unknown";
			}
			if (this._rglVer.Length <= 0 || this._rglVer == null)
			{
				this._rglVer = "unknown";
			}
			if (this._steamVer.Length <= 0 || this._steamVer == null)
			{
				this._steamVer = "unknown";
			}
			if (this._eglVer.Length <= 0 || this._eglVer == null)
			{
				this._eglVer = "unknown";
			}
			this.lblGameVer.Text = string.Concat(new string[] { this._gb, "\n", this._rglVer, "\n", this._steamVer, "\n", this._eglVer, "\n", this._cp });
			try
			{
				if (File.Exists(this._steamApi64Orig) && File.Exists(this._steamApi64Back))
				{
					if (this._cp == "Steam")
					{
						File.Delete(this._steamApi64Back);
					}
					else
					{
						File.Delete(this._steamApi64Orig);
					}
				}
			}
			catch (Exception innerException5)
			{
				using (StreamWriter streamWriter5 = new StreamWriter(this._exPath, true))
				{
					while (innerException5 != null)
					{
						streamWriter5.WriteLine("-----------------------------------------------------------------------------");
						streamWriter5.WriteLine("Date : " + DateTime.Now.ToString());
						streamWriter5.WriteLine("Current platform is " + this._cp + ", previous is " + this._pp);
						streamWriter5.WriteLine();
						streamWriter5.WriteLine(innerException5.GetType().FullName);
						streamWriter5.WriteLine("Message : " + innerException5.Message);
						streamWriter5.WriteLine("StackTrace : " + innerException5.StackTrace);
						innerException5 = innerException5.InnerException;
					}
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000327C File Offset: 0x0000147C
		private void Form1_Load(object sender, EventArgs e)
		{
			this.CheckVersions();
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				this.btnSteamInstalled.Enabled = false;
				this.btnFixPlayOnSteam.Enabled = false;
				this.btnFixPlayOnEpic.Enabled = false;
				this.btnInstallEpic.Enabled = false;
				this.lblRunAsAdmin.Visible = true;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000032E1 File Offset: 0x000014E1
		private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000032E3 File Offset: 0x000014E3
		private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000032E5 File Offset: 0x000014E5
		private void Button1_Click(object sender, EventArgs e)
		{
			this._pp = this._cp;
			this._cp = "RGL";
			this.Switch();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003304 File Offset: 0x00001504
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AboutWindow aboutWindow = new AboutWindow())
			{
				aboutWindow.ShowDialog();
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000333C File Offset: 0x0000153C
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003344 File Offset: 0x00001544
		private void LblTextGameVer_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003346 File Offset: 0x00001546
		private void LblGameVer_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003348 File Offset: 0x00001548
		private void BtnSteam_Click(object sender, EventArgs e)
		{
			this._pp = this._cp;
			this._cp = "Steam";
			this.Switch();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003368 File Offset: 0x00001568
		private void BtnLaunch_Click(object sender, EventArgs e)
		{
			string text = ConfigurationManager.AppSettings["CurrentPlatform"];
			if (text == "Steam")
			{
				Process.Start("steam://rungameid/271590");
				return;
			}
			if (text == "RGL")
			{
				Process.Start("PlayGTAV");
				return;
			}
			if (text == "EGL")
			{
				Process.Start("com.epicgames.launcher://apps/9d2d0eb64d5c44529cece33fe2a46482?action=launch&silent=true");
				Application.Exit();
				return;
			}
			MessageBox.Show(this._tmbLaunchError, this._oops, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000033EA File Offset: 0x000015EA
		private void troubleshootingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("Switcher\\GTA V Platform Switcher.docx");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000033F8 File Offset: 0x000015F8
		private void btnFixPlayOnSteam_Click(object sender, EventArgs e)
		{
			Process.Start("reg", " add HKCU\\SOFTWARE\\Valve\\Steam\\Apps\\271590 /v Installed /t REG_DWORD /d 0 /f");
			Process.Start("reg", " delete \"HKLM\\SOFTWARE\\WOW6432Node\\Rockstar Games\\GTAV\" /v InstallFolderSteam /f");
			MessageBox.Show(this._tmbFixSteam, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this._pp = this._cp;
			this._cp = "RGL";
			this.Switch();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003456 File Offset: 0x00001656
		private void btnSteamInstalled_Click(object sender, EventArgs e)
		{
			Process.Start("reg", " add HKCU\\SOFTWARE\\Valve\\Steam\\Apps\\271590 /v Installed /t REG_DWORD /d 1 /f");
			Process.Start("reg", "add \"HKLM\\SOFTWARE\\WOW6432Node\\Rockstar Games\\GTAV\" /v InstallFolderSteam /t REG_SZ /d \"" + Environment.CurrentDirectory + "\\GTAV\" /f");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003487 File Offset: 0x00001687
		private void btnEpic_Click(object sender, EventArgs e)
		{
			this._pp = this._cp;
			this._cp = "EGL";
			this.Switch();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000034A6 File Offset: 0x000016A6
		private void btnFixPlayOnEpic_Click(object sender, EventArgs e)
		{
			Process.Start("reg", " delete \"HKLM\\SOFTWARE\\WOW6432Node\\Rockstar Games\\Grand Theft Auto V\" /v InstallFolderEpic /f");
			MessageBox.Show(this._tmbFixEpic, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000034CC File Offset: 0x000016CC
		private void btnInstallEpic_Click(object sender, EventArgs e)
		{
			Process.Start("reg", "add \"HKLM\\SOFTWARE\\WOW6432Node\\Rockstar Games\\Grand Theft Auto V\" /v InstallFolderEpic /t REG_SZ /d \"" + Environment.CurrentDirectory + "\" /f");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000040A5 File Offset: 0x000022A5
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000040AD File Offset: 0x000022AD
		public object CurrentPlatform { get; private set; }

		// Token: 0x0400000B RID: 11
		private string _pp = "";

		// Token: 0x0400000C RID: 12
		private string _cp = "";

		// Token: 0x0400000D RID: 13
		private string _gb = "";

		// Token: 0x0400000E RID: 14
		private string _rglVer = "";

		// Token: 0x0400000F RID: 15
		private string _steamVer = "";

		// Token: 0x04000010 RID: 16
		private string _eglVer = "";

		// Token: 0x04000011 RID: 17
		private string _exPath = Environment.CurrentDirectory + "\\Switcher.log";

		// Token: 0x04000012 RID: 18
		private string _steamApi64Orig = Environment.CurrentDirectory + "\\steam_api64.dll";

		// Token: 0x04000013 RID: 19
		private string _steamApi64Back = Environment.CurrentDirectory + "\\steam_api64.dll.steam";

		// Token: 0x04000014 RID: 20
		private string _tmbLaunchError = "Current platform in config file is wrong.\nPlease, select needed platform by clicking one of the big buttons above.";

		// Token: 0x04000015 RID: 21
		private string _tmbFixSteam = "Relaunch Rockstar Games Launcher\nThen install game to steamapps\\common folder";

		// Token: 0x04000016 RID: 22
		private string _tmbFixEpic = "Relaunch Rockstar Games Launcher\nThen install game to steamapps\\common folder if you're planning to switch to Steam\nOr to folder above current if you want to switch to RGL only";

		// Token: 0x04000017 RID: 23
		private string _tmbConfigCorrupted = "Unable to read the config. It's probably corrupted or inaccesible, or you have not installed Switcher properly.\nIf you have ran the Switcher directly from archive - unpack archive to game folder (place everything from it next to GTA5.exe), open Switcher from folder, click About - How to use";

		// Token: 0x04000018 RID: 24
		private string _oops = "Oops, something went wrong! Or maybe not...";

		// Token: 0x04000019 RID: 25
		private string _tmbIdkWhatAreYouTryingToDo = "I don't really know what do you want me to do.";
	}
}
