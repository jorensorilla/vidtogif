/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/12/2015
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Project1
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		/// 
		
		
		[STAThread]
		private static void Main(string[] args)
		{	
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			ExcelReader er = new ExcelReader();
			MainForm mf = new MainForm();
			Controller controller = new Controller(mf, er);
			mf.setController(controller);
			
			
			Application.Run(mf);
			
			
			
		}
		
	}
}
