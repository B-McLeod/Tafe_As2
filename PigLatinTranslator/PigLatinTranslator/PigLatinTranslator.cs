using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PigLatinTranslator
{
	public partial class frmPigLatinTranslator : Form
	{
		private static string vowels = "AEIOUaeiuoYy";
		private static string specialCharacters = " ~`!@#$%^&*()-_=+|\\}]{[':;<,>.\"0123456789";

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
			TranslateText();
		}

		private void TranslateText()
		{
			String phrase = txtEnglish.Text.Trim();							// Clean-up start and finish spaces.
			String[] wordsArray = phrase.Split(' ');							// Split words into the 'words' array.
			StringBuilder sb = new StringBuilder();

			foreach (String word in wordsArray)
			{
				String myWord = word;
				if (!myWord.Equals(""))									// If word is not blank
				{
					String firstLetter = myWord.Substring(0, 1);			// Get first letter of word

					if (firstLetter.Equals("A") || firstLetter.Equals("E") || firstLetter.Equals("I") || firstLetter.Equals("O") || 
						firstLetter.Equals("U") || firstLetter.Equals("a") || firstLetter.Equals("e") || firstLetter.Equals("i") || 
						firstLetter.Equals("o") || firstLetter.Equals("u") || firstLetter.Equals("Y") || firstLetter.Equals("y"))								// If word starts with vowel, add 'way' at the end.
					{
						myWord += "way";
					}
					else															// If word does not start with a vowel, remove first letter
					{																// and move it to the end of the word + 'ay'
						if (!firstLetter.Equals(vowels))
						{
							myWord = word.Remove(0, 1);
							myWord += firstLetter.ToString() + "ay";
						}
					}
				}
				sb.Append(myWord + " ");
				txtPigLatin.Text = sb.ToString();
			}
		}
	}
}