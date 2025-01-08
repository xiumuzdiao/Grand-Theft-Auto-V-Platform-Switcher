using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Grand_Theft_Auto_V_Platform_Switcher.Properties;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
	// Token: 0x02000002 RID: 2
	public partial class AboutWindow : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AboutWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205E File Offset: 0x0000025E
		private void BtnOkay_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://TechnoSt.one/donate");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002073 File Offset: 0x00000273
		private void LblProductVersion_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002075 File Offset: 0x00000275
		private void AboutWindow_Load(object sender, EventArgs e)
		{
			this.LblProductVersion.Text = "版本号 " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A0 File Offset: 0x000002A0
		private void LinkLblTS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://TechnoSt.one");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020AD File Offset: 0x000002AD
		private void LinkLblTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://t.me/TechnoStones");
		}
	}
}
