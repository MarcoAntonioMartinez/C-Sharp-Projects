//this is a program that is built around certain concepts that were learned from assignment 1 from my class
//including: file IO, enumeration, private and readonly data ..., whatever is happening in this line -> Student:ICompareable,
//	whatever this method call is called:  method -> method(arguments), overriding ToString(), working with a list, and gui

using System;
using System.IO;
using System.Collections.Generic;


namespace 
{
    class Program
	{
	
		public static List<Employee> EmployeeList = new string List<Employee>;
		
		public static void Main()
		{
			string holdLine = "";	//hold a read line one at a time
			
			string[] splitted;
			
			try
			{
				using(StreamReader inFile = new StreamReader("..\\..\\EmployeeInput.txt")
				{
					while(!inFile.EndOfStream)
					{
					 holdLine = inFile.ReadLine();
					 
					}
				}
			}
			catch(System.IO.FileNotFoundException)
			{
				Console.Writeline("The file was not found");
				Environment.Exit(1);
			}
		}
	}