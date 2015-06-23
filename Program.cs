using System;
using System.Collections.Generic;

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
			//You Must write enter "end" or 3 blank lines to exit the loop.
			int i = 0;
			do {
				line = Console.ReadLine ();
				input += line + " ";
				Console.WriteLine(line);
				i = 0;
				if (line == "")
				{
					//Console.WriteLine(i);
					i++;
				}
				if (line == "end")
				{
					i = 4;
				}
			} while (i < 3);

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

			//print string of emails separated by spaces
			Console.WriteLine (string.Join(" ", emails.ToArray() ));
		}
	}
}
