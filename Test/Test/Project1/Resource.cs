/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/20/2015
 * Time: 4:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Project1
{
	/// <summary>
	/// Description of Resource.
	/// </summary>
	public struct Resource : IEquatable<Resource>
	{
		public string lastName;
		public string firstName;
		public string status;
				 
		public bool Equals(Resource other)
		{
			// add comparisions for all members here
			
			return this.lastName == other.lastName && this.firstName == other.firstName;
		}
		
		
	}
}
