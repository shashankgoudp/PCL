using System;
using Cirrious.MvvmCross.ViewModels;

namespace PclMvx.Core
{
	public class HomeViewModel : MvxViewModel
	{
		public HomeViewModel ()
		{
		}

		string firstname;
		public string Firstname{
			get{ 
				return firstname;
			
			}
			set{ 
			
				firstname = value;
				RaisePropertyChanged (() => Firstname);
			}
		}
	}
}

