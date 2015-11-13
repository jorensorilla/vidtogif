using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;
using HelloWPF.ViewModels;
using HelloWPF.Views;
namespace HelloWPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		
		public App()
		{
			new Window1()
			{
				DataContext = new MainWindowViewModel()
			}.Show();
		}
		
		
	}
}