using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;

namespace HelloWPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
			private void Application_Startup(object sender, StartupEventArgs e)
                {
                        Window1 wnd = new Window1();
                        if(e.Args.Length == 1)
                                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
                        wnd.Show();
                }
	}
}