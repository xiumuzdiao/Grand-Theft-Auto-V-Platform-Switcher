using System;
using System.Windows.Forms;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000040B6 File Offset: 0x000022B6
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
