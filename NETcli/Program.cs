using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NETcli
{
    class Program
    {
/*	public FileStream createFile(string path)
	{
		FileStream fs = File.Create(path);
		Console.Write("Creating file with the name " + path);
		return fs;
	}	*/
        static void Main(string[] args)
	{ 
		//input path
		Console.Write("What is the path of the file you would like to create: ");
		string writePath = Console.ReadLine();
		//text to output
		Console.Write("What text would you like to enter in the file: ");
		string outputText = Console.ReadLine();
		//writing text to path 
		using(FileStream fs = File.Create(writePath))
		{
			byte[] info = new UTF8Encoding(true).GetBytes(outputText+"\n");
			fs.Write(info, 0, info.Length);
		}
		//ask to remove the program
		Console.Write("Would you like to remove the file [yes/no]");
		string removeProgram = Console.ReadLine();
		if(removeProgram != "no")
		{
			Console.Write("Deleting the file...");
			File.Delete(writePath);
			Console.Write("Done!\n");
		}

		//read path
		Console.Write("What file would you like to read from: ");
		string path = Console.ReadLine();
		List<string> lines = new List<string>();
		lines = File.ReadAllLines(path).ToList();
		//print out lines of file
		foreach(String line in lines)
		{
			Console.Write(line+"\n");
		}
        }
    }
}
