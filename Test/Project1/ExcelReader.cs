/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/13/2015
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Excel;
using System.Collections.Generic;

namespace Project1
{
	/// <summary>
	/// Description of ExcelReader.
	/// </summary>
	public class ExcelReader
	{
		private List<Resource> timeReportNames;
		private List<Resource> benchReportNames;
		private int numInBench;
		
		public ExcelReader(){
			timeReportNames = new List<Resource>();
			benchReportNames = new List<Resource>();
			numInBench = 0;
		}
		
		public int getNumInBench(){
			return numInBench;
		}
		
		public List<Resource> getTimeReportNames(){
			return timeReportNames;
		}
		
		public List<Resource> getBenchReportNames(){
			return benchReportNames;
		}
		
		public void readTimeReport(string path){
			string temp;
			int rowNum = 0;
			foreach (var worksheet in Workbook.Worksheets(@path)){
				
				foreach (var row in worksheet.Rows){
					foreach (var cell in row.Cells){
						if(cell != null){
							if(cell.ColumnIndex == 2){
								System.Diagnostics.Debug.Write(cell.Text);
								System.Diagnostics.Debug.WriteLine("");
								temp = cell.Text;
								
								string[] splitText = temp.Split(',');
								
								if(rowNum != 0){
									splitText[1] = splitText[1].Trim().Split(' ')[0];
									Resource res = new Resource();
									res.firstName = splitText[1].ToLower();
									res.lastName = splitText[0].ToLower();
									timeReportNames.Add(res);
									System.Diagnostics.Debug.WriteLine(splitText[0]+" "+splitText[1]);
								} 
							}//end if
						}//end if
						
					}//end foreach
					rowNum++;
				}//end foreach
			    break;
			}
			
		}
		
		public void readBenchReport(string path){
			string temp;
			this.numInBench = 0;
			foreach (var worksheet in Workbook.Worksheets(@path)){
				int rowNum = 0;
				
				foreach (var row in worksheet.Rows){
					Resource res = new Resource();
					foreach (var cell in row.Cells){
						if(cell != null){
							if (cell.ColumnIndex == 9 && !String.Equals(cell.Text, "")){
								System.Diagnostics.Debug.Write(cell.Text);
								System.Diagnostics.Debug.WriteLine("");
								temp = cell.Text;
								
								string[] splitText = temp.Split('.');
								if(rowNum != 0){
									res.firstName = splitText[0];
									res.lastName = splitText[splitText.Length-1];
									benchReportNames.Add(res);
								}
							}else if (cell.ColumnIndex == 14){
								if(cell.Text.Equals("In Bench")){
									System.Diagnostics.Debug.WriteLine("    "+res.lastName+" "+cell.Text);
									res.status = "In Bench";
									numInBench++;
								}else
									res.status = cell.Text;
							}
						}//end if
						
					}//end foreach
					rowNum++;
				}//end foreach
			    break;
			}
		}
		
		
	}
	
}
