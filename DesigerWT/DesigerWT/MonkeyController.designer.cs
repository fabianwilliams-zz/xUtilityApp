// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace DesigerWT
{
	[Register ("MonkeyController")]
	partial class MonkeyController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton backButton { get; set; }

		[Action ("Clicked:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Clicked (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (backButton != null) {
				backButton.Dispose ();
				backButton = null;
			}
		}
	}
}
