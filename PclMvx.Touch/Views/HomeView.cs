using System;
using Cirrious.MvvmCross.Touch.Views;
using UIKit;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using PclMvx.Core;

namespace PclMvx.Touch
{
	public class HomeView : MvxViewController
	{
		public HomeView ()
		{
		}

		public override void ViewDidLoad()
		{

			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.Gray;

			var label = new UILabel (new Rectangle (100, 100, 100, 50));
			Add (label);
			var edit = new UITextView (new Rectangle (100, 150, 100, 50));
			Add (edit);
			var binding = this.CreateBindingSet<HomeView,HomeViewModel> ();
			binding.Bind (label).To ((v) => v.Firstname);
			binding.Bind (edit).To ((v) => v.Firstname);
			binding.Apply ();

		}
	
	}

}

