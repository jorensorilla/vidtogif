/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 11/10/2015
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HelloWPF
{
	/// <summary>
	/// Description of FMMPEGWrapper.
	/// </summary>
	public class FMMPEGWrapper
	{
		public FMMPEGWrapper()
		{
		}
		
		public void ConvertToImage(string file_path, int start, int end, int fps, int resolution_x, 
		                          int resolution_y, string output_path, int image_format){
			
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			
			if(!output_path[output_path.Length - 1].Equals('/')){
				output_path+="/";
			}		
			
			string ffmpeg_path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FFmpeg/ffmpeg");
			startInfo.Arguments = ffmpeg_path+" -i "+file_path+" -ss "+start+" -to "+end+" -r "+fps+" -s "+resolution_x
				+"x"+resolution_y+" -f image2 "+output_path+"image%03d."+image_format;
			
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
