using System;

using Xamarin.Forms;

namespace People
{
	public class App : Application
	{
		public static PersonRepository PersonRepo { get; private set; }

		public App(string dbPath)
		{
			// The root page of your application
			//var content = new ContentPage
			//{
			//	Title = "People",
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = displayText
			//			}
			//		}
			//	}
			//};


			//MainPage = content;
			//MainPage = new NavigationPage(content);
			PersonRepo = new PersonRepository(dbPath);

			this.MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
