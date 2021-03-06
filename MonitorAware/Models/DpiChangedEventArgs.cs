﻿using System;
using MonitorAware.Models.Win32;

namespace MonitorAware.Models
{
	/// <summary>
	/// DPI changed event args
	/// </summary>
	public class DpiChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Old DPI
		/// </summary>
		public Dpi OldDpi { get; private set; }

		/// <summary>
		/// New DPI
		/// </summary>
		public Dpi NewDpi { get; private set; }

		/// <summary>
		/// Window Message
		/// </summary>
		public WindowMessage windowMessage { get; private set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="oldDpi">Old DPI</param>
		/// <param name="newDpi">New DPI</param>
		/// <param name="windowMessage">Window Message</param>
		public DpiChangedEventArgs(Dpi oldDpi, Dpi newDpi, WindowMessage windowMessage)
		{
			this.OldDpi = oldDpi;
			this.NewDpi = newDpi;
			this.windowMessage = windowMessage;
		}
	}
}