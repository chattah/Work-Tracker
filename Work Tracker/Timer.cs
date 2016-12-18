using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

namespace Work_Tracker
{
	class Timer
	{
		public Timer()
		{
			DispatcherTimer myTimer = new DispatcherTimer();
			myTimer.Tick += new EventHandler(startTimer);
			myTimer.Interval = new TimeSpan(0, 0, 1);
			myTimer.Start();
		}
		
		private void startTimer(object sender, EventArgs e)
		{
			
		}
	}
}
