/*
=================================================
      KINGDOM HEARTS - RE:FIXED FOR 2 FM!
       COPYRIGHT TOPAZ WHITELOCK - 2022
 LICENSED UNDER MIT. GIVE CREDIT WHERE IT'S DUE! 
=================================================
*/

using System;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;

using Axa;
using ReFixed;

namespace AxaFormBase
{
	public partial class BaseSimpleForm : Form
	{
		public static CancellationTokenSource CancelSource;
		public static CancellationToken MainToken;
		public static Task MainTask;

		public unsafe static BaseSimpleForm createInstance(AppInterface* _app, string title)
		{
			if (BaseSimpleForm.theInstance == null)
			{
				new BaseSimpleForm(_app, title);
			}

			CancelSource = new CancellationTokenSource();
			MainToken = BaseSimpleForm.CancelSource.Token;

			Variables.GameProcess = Process.GetCurrentProcess();
			Variables.GameHandle = Variables.GameProcess.Handle;
			Variables.GameAddress = (ulong)Variables.GameProcess.MainModule.BaseAddress.ToInt64() + Variables.BaseAddress;

			MainTask = Task.Factory.StartNew(delegate()
			{
				while (!MainToken.IsCancellationRequested)
				{
					Functions.Execute();
				}
			}, MainToken);

			return BaseSimpleForm.theInstance;
		}
	}
}