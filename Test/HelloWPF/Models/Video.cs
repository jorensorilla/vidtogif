/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 11/13/2015
 * Time: 11:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HelloWPF.Models
{
	/// <summary>
	/// Description of Video.
	/// </summary>
	public class Video
	{
		public string file_path{get; set;}
		public int start{get; set;}
		public int end{get; set;}
		public int fps{get; set;}
		public int resolution_x{get; set;}
		public int resolution_y{get; set;}
		public string output_path{get; set;}
		public int image_format{get; set;}
		
		
		/**
		 * Video Constructor
		 * Set default values
		 */
		public Video(){
			start = 0;
			end = 0;
			fps = 30;
			resolution_x = 800;
			resolution_y = 600;
			output_path = "";
			image_format = 0;
		
		}
		
		
		
	}
	
	
}
