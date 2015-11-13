/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/12/2015
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form, IMainForm
	{
		private Controller controller;
		public MainForm()
		{
			InitializeComponent();
		}
		
		/*
		 * Action Listeners
		 * 
		 */
		public void btnTRPath_Click(object sender, EventArgs e){
			var FD = new System.Windows.Forms.OpenFileDialog();
			if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
			    txtTRPath.Text = FD.FileName;
			}
		}
		
		
		public void btnBMPath_Click(object sender, EventArgs e){
			var FD = new System.Windows.Forms.OpenFileDialog();
			if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
			    txtBMPath.Text = FD.FileName;
			}
		}
		
		public void btnStart_Click(object sender, EventArgs e){
			this.controller.checkAttendance();
			
		}
		
		
		/*
		 * UI Action Methods
		 * 
		 */
		public void displayResults(List<Resource> result)
		{
			foreach(Resource resource in result){
				listBox.Items.Add(resource.lastName.ToUpper()+", "+resource.firstName.ToUpper()+" is In Bench.");
			}
		}
		
		public void displayNumOfInBenchResources(int numResources, int numResourcesTotal){
			listBox.Items.Add(numResources+" out of "+numResourcesTotal+" resources are currently In Bench.");
		}
				
		
		/*
		 * Get/Set Methods
		 * 
		 */
		 
		public string getTRPath(){
			string path = txtTRPath.Text;
			if (!String.IsNullOrEmpty(path)) {
				return txtTRPath.Text;
			} else
				return null;
		}
		
		public string getBRPath(){
			string path = txtBMPath.Text;
			if (!String.IsNullOrEmpty(path)) {
				return txtBMPath.Text;
			} else
				return null;
		}
		
		public void setController(Controller controller)
		{
			this.controller = controller;
		}
		 
		
	}
}
