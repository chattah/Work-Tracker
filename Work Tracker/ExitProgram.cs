using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Work_Tracker
{
	public static class ExitProgram
	{
		public static void Exit()
		{
			Application.Current.Shutdown();
		}
	}
}
