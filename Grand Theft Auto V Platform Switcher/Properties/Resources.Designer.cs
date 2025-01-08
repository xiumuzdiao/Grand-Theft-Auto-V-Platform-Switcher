using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Grand_Theft_Auto_V_Platform_Switcher.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000040CD File Offset: 0x000022CD
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000040D5 File Offset: 0x000022D5
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004101 File Offset: 0x00002301
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00004108 File Offset: 0x00002308
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004110 File Offset: 0x00002310
		internal static Bitmap EGL
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("EGL", Resources.resourceCulture);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000412B File Offset: 0x0000232B
		internal static Bitmap RGL
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("RGL", Resources.resourceCulture);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004146 File Offset: 0x00002346
		internal static Bitmap Steam
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Steam", Resources.resourceCulture);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004161 File Offset: 0x00002361
		internal static Bitmap Switcher
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Switcher", Resources.resourceCulture);
			}
		}

		// Token: 0x04000030 RID: 48
		private static ResourceManager resourceMan;

		// Token: 0x04000031 RID: 49
		private static CultureInfo resourceCulture;
	}
}
