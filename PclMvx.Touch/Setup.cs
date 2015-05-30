using System;
using Cirrious.MvvmCross.Touch.Platform;
using PclMvx.Core;
using UIKit;

namespace PclMvx.Touch
{
	public class Setup : MvxTouchSetup
	{

		public Setup (MvxApplicationDelegate del, UIWindow window) : base(del, window)
		{

		}


		#region implemented abstract members of MvxSetup

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new App ();
		}

		#endregion

		

	}
}

