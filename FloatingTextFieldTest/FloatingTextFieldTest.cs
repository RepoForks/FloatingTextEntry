﻿using System;
using Xamarin.Forms;
using Alex.Controls.Forms;

namespace FloatingTextFieldTest
{
	public class App : Application
	{
		FloatingTextEntry EmailEntry {
			get;
			set;
		}

		FloatingTextEntry PassEntry {
			get;
			set;
		}

		public App ()
		{
			EmailEntry = new FloatingTextEntry ();
			EmailEntry.Placeholder = "Email";
			EmailEntry.AccentColor = Color.FromHex("#FFC107");
			EmailEntry.InactiveAccentColor = Color.FromHex ("#1976D2");
			EmailEntry.TextColor = Color.Purple;
			EmailEntry.ErrorColor = Color.Red;
			EmailEntry.ErrorText = "Bad Email";
			EmailEntry.Validator = FloatingTextEntry.EmailValidator;

			PassEntry = new FloatingTextEntry ();
			PassEntry.Placeholder = "Password";
			PassEntry.AccentColor = Color.FromHex("#FFC107");
			PassEntry.InactiveAccentColor = Color.FromHex ("#1976D2");
			PassEntry.TextColor = Color.Purple;
			PassEntry.IsPassword = true;
			PassEntry.ErrorColor = Color.Red;
			PassEntry.ErrorText = "Bad Password";
			PassEntry.Validator = (string input) => {
				return !string.IsNullOrWhiteSpace (input);
			};

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Padding = new Thickness(20,0),
					Children = {
						EmailEntry,
						PassEntry
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
