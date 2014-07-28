using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigLatinTranslator
{
	public partial class frmPigLatinTranslator : Form
	{
		/* ------------------------------------------ */
		private static String vowels = "AEIOUaeiou";
		private static String[] VowelsArray = vowels.Split();
		private static String specChar = "~ ` ! @ # $ % ^ & * ( ) - _ = + | \\ } ] { [ : ; < , > . \" 0 1 2 3 4 5 6 7 8 9";
		private static String[] specialCharacters = specChar.Split(' ');
		/* ------------------------------------------ */

		public frmPigLatinTranslator()
		{
			InitializeComponent();
			txtEnglish.Focus();
			txtEnglish.Text = "symbol";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtEnglish.Text = "";
			txtPigLatin.Text = "";
			txtEnglish.Focus();
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			TranslateText();
			if (txtPigLatin.Text.Equals("ymbolssay "))
			{
				lblCheck.Text = "Check Status: Works!";
			}
			else
			{
				lblCheck.Text = "Check Status: Not yet finished!";
			}
		}

		private void TranslateText()
		{
			StringBuilder sb = new StringBuilder();

			/* Import text and split into an array */
			String phrase = txtEnglish.Text.Trim();
			String[] wordsArray = phrase.Split(' ');

			foreach (String word in wordsArray)
			{
				String myWord = word;
				String firstLetter = myWord.Substring(0, 1);
				String lastCharacter = null;

				/* Ending with punctuation */
				bool EndsWithPunctuation = LastCharacter(myWord);
				if (EndsWithPunctuation == true)
				{
					lastCharacter = myWord.Substring(myWord.Length - 1, 1);
					myWord = myWord.Remove(myWord.Length - 1, 1);
				}

				/* If myWord is not blank and doesn't contain any special characters */
					if (!myWord.Equals("") && !specialCharacters.Any(myWord.Contains))
					{
						/* VOWEL OR CONTAINING 'Y' */
						if (vowels.Contains(firstLetter) || myWord.ToLower().Substring(1, myWord.Length - 1).Contains('y'))
						{
							/* Upper Case */
							if (myWord.Equals(myWord.ToUpper()))
							{
								myWord += "WAY";
							}
							/* Lower Case */
							else
							{
								myWord += "way";
							}
						}
						/* CONSONANT */
						else
						{
							if (!vowels.Contains(firstLetter))
							{
								/* UPPER CASE */
								if (myWord.Equals(myWord.ToUpper()))
								{
									myWord = processConsonant(myWord).ToUpper();
								}
								/* Title Case */
								else if (firstLetter.Equals(firstLetter.ToUpper()))
								{
									myWord = processConsonant(myWord);
									myWord = myWord.Substring(0, 1).ToUpper() + myWord.Substring(1, myWord.Length - 1).ToLower();
								}
								/* lower case */
								else
								{
									myWord = processConsonant(myWord).ToLower();
								}
							}
						}
					}

				/* Append to sb StringBuilder and print to screen in txtPigLatin text-box */
				sb.Append(myWord + lastCharacter + " ");
				txtPigLatin.Text = sb.ToString().TrimEnd(' ');
			}
		}

		private static int GetVowelIndex(String word)
		{
			int index = 0;
			for (int i = 0; i < word.Length; i++)
			{
				if (vowels.Contains(word[i]))
				{
					index = i;
					break;
				}
			}
		return index;
		}

		private static String processConsonant(String word)
		{
			int vowelIndex = GetVowelIndex(word);
			String consanantWord = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
		return consanantWord;
		}

		private static bool LastCharacter(String word)
		{
			foreach (String character in specialCharacters)
			{
				if (word.EndsWith(character))
					return true;
			}
			return false;
		}
	}
}