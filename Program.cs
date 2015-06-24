using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmailExtrapolator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//dem string vars tho...
			string word = "";
			string input = "";
			string line;

			//This takes data from clipboard and adds it to input one line at a time.
			//You Must write enter "end"
			do 
			{
				line = Console.ReadLine ();
				input += line + " ";
			} while (line == "end");

			//Lists to store input words and emails
			List<string> allData = new List<string> ();
			List<string> emails = new List<string> ();


			//add a space to the end of input to read the last word
			input += " ";

			//iterate through input string and add words to allData list
			foreach (char element in input)
			{
				if (element != ' ' && element != '\t') {
					if (element != ',')
					{
						word += element;
					}
				} else {
					allData.Add (word);
					word = "";
				}
			}

			//uncomment to print allData list
			//Console.WriteLine (string.Join(",", allData.ToArray() ));

			//iterate through allData
			foreach (string element in allData)
			{
				//iterate through elements in allData
				foreach(char character in element)
				{
					//if the element contains an '@' character add it to emails
					if (character == '@')
					{
						emails.Add (element);
					}
				}
			}

			using (StreamWriter outfile = new StreamWriter(".//emails.txt"))
			{
				outfile.Write(string.Join(" ", emails.ToArray() ));
			}

			//print string of emails separated by spaces
			Console.WriteLine (string.Join(" ", emails.ToArray() ));
		}
	}
}