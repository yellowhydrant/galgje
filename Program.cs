using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
	static List<char> validCharacters = new List<char>(validCharacterString);
	const string validCharacterString = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
	
	public static void Main()
	{
		var triesLeft = 8;
		var correctCharacters = new List<char>();
		var incorrectCharacters = new List<char>();
		var guessedCharacters = new List<char>();
		
		Console.WriteLine("Please enter the word you want to guess! The word can only contain the following characters: \"{0}\"", validCharacterString);
		var word = string.Empty;
		while (true)
		{
			word = Console.ReadLine();
			if(IsWordValid(word))
				break;
			else
				Console.WriteLine("Invalid input! Please enter a word that only contains the following characters: \"{0}\"", validCharacterString);
		}
		
		foreach(var c in validCharacters)
		{
			if(word.Contains(c.ToString()))
				correctCharacters.Add(c);
			else
				incorrectCharacters.Add(c);
		}
		
		while(true)
		{
			Console.Clear();
			var guessedCharacterString = new StringBuilder();
			for(int i = 0; i < word.Length; i++)
				if(guessedCharacters.Contains(word[i]))
					guessedCharacterString.Append(word[i]);
				else
					guessedCharacterString.Append("-");
			Console.WriteLine("Currently guessed characters {0}", guessedCharacterString);
			
			var guess = Console.ReadLine();
			
		}
	}

	public static bool IsWordValid(string word)
	{
		for (int i = 0; i < word.Length; i++)
		{
			if (!validCharacters.Contains(word[i]))
				return false;
		}

		return true;
	}
}
