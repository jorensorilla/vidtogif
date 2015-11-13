/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/16/2015
 * Time: 2:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Project1
{
	/// <summary>
	/// Description of Processor.
	/// </summary>
	public class Controller
	{	
		private IMainForm mf;
		private ExcelReader er;
		
		public Controller(IMainForm mf, ExcelReader er)
		{
			
			this.mf = mf;
			this.er = er;
			
			
		}
		
		public void checkAttendance(){
			er.readTimeReport(mf.getTRPath());
			er.readBenchReport(mf.getBRPath());
			List<Resource> presentResources = new List<Resource>();
			List<Resource> reportNames = er.getTimeReportNames();
			foreach(Resource resource in er.getBenchReportNames()){
				if(reportNames.Contains(resource))
					presentResources.Add(resource);
			}
			
			mf.displayResults(presentResources);
			mf.displayNumOfInBenchResources(presentResources.Capacity,er.getNumInBench());
		}
		
		 
	}
}
