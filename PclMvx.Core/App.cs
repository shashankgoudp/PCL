using System;
using Cirrious.MvvmCross.ViewModels;

namespace PclMvx.Core
{
	public class App : MvxApplication
	{
		public App ()
		{
		}

		public override void Initialize()
		{
			base.Initialize ();
			RegisterAppStart<HomeViewModel> ();
		}
	}
}

