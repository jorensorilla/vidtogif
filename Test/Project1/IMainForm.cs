/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/15/2015
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Project1
{
	/// <summary>
	/// Description of IMainForm.
	/// </summary>
	public interface IMainForm
	{
		//Action Listeners
		void btnTRPath_Click(object sender, EventArgs e);
		void btnBMPath_Click(object sender, EventArgs e);
		void btnStart_Click(object sender, EventArgs e);
		
		//Methods
		void displayResults(List<Resource> result);
		void displayNumOfInBenchResources(int numResources, int numResourcesTotal);
		string getTRPath();
		string getBRPath();
		void setController(Controller controller);
		
	}
}
