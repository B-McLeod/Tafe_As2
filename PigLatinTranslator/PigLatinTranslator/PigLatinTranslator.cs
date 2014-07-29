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
		private static String vowels2 = "AEIOUYaeiouy";
		private static String specChar = "~ ` ! @ # $ % ^ & * ( ) - _ = + | \\ } ] { [ : ; < , > . \" 0 1 2 3 4 5 6 7 8 9";
		private static String[] specialCharacters = specChar.Split(' ');
		/* ------------------------------------------ */

		public frmPigLatinTranslator()
		{
			InitializeComponent();
			txtEnglish.Focus();
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
			if (String.IsNullOrEmpty(txtEnglish.Text))
			{
				MessageBox.Show("Uh oh! You forgot to add text to translate!", "Error");
			}
			else if (String.IsNullOrWhiteSpace(txtEnglish.Text))
			{
				MessageBox.Show("Uh oh! You forgot to add text to translate!", "Error");
			}
			else
			{
				TranslateText();
				txtEnglish.Focus();
			}
		}

		/* Translate Text */
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

				/* Ending with punctuation
				 * Known issue: If myWord ends with multiple puncuations, it will not translate */
				if (isEndingInPuncuation(myWord) == true)
				{
					lastCharacter = myWord.Substring(myWord.Length - 1, 1);
					myWord = myWord.Remove(myWord.Length - 1, 1);
				}

				/* If myWord is not blank and doesn't contain any special characters */
				if (!myWord.Equals("") && !specialCharacters.Any(myWord.Contains))
				{
					/* VOWEL OR CONTAINING 'Y' */
					if (vowels.Contains(firstLetter))
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


		/* Get index of first vowel or Y */
		private static int GetVowelIndex(String word)
		{
			int index = 0;
			if (word.ToLower().Substring(1, word.Length - 1).Contains('y'))
			{
				for (int i = 1; i < word.Length; i++)
				{
					if (vowels2.Contains(word[i]))
					{
						index = i;
						break;
					}
				}
				return index;
			}
			else
			{
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
		}


		/* Recreate the consonant word */
		private static String processConsonant(String word)
		{
			int vowelIndex = GetVowelIndex(word);
			String consanantWord = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
			return consanantWord;
		}


		/* Test if word is ending with punctuation */
		private static bool isEndingInPuncuation(String word)
		{
			Char lastCharacter = System.Convert.ToChar(word.Substring(word.Length - 1, 1));

			if (Char.IsPunctuation(lastCharacter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}