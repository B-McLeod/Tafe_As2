using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigLatinTranslator
{
	public partial class frmPigLatinTranslator : Form
	{
		/* ------------------------------------------ */
		private static String[] vowels = new string[12] { "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "y" };
		private static String specChar = "~ ` ! @ # $ % ^ & * ( ) - _ = + | \\ } ] { [ ' : ; < , > . \" 0 1 2 3 4 5 6 7 8 9";
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
			TranslateText();
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

				/* If myWord is not blank and doesn't contain any special characters */
				if (!myWord.Equals("") && !specialCharacters.Any(myWord.Contains))
				{
					String firstLetter = myWord.Substring(0, 1);

					/* Add 'way' if starts with Vowel or Y. */
					if (vowels.Contains(firstLetter))
					{
						/* If word is in capitals */
						if (myWord.Equals(myWord.ToUpper()))
						{
							myWord += "WAY";
						}
						/* If word is not in capitals */
						else
						{
							myWord += "way";
						}
					}
					/* If starts with consanant move first char to end and add 'ay' */
					else
					{
						if (!vowels.Contains(firstLetter))
						{
							myWord = word.Remove(0, 1);
							
							/* If word is in capitals */
							if (myWord.Equals(myWord.ToUpper()))
							{
								myWord += firstLetter.ToString() + "AY";
							}
							/* If word is in Title Case */
							/* PUT IN TITLE CASE ARGUMENT BELOW SOMEWHERE */
							else if (myWord.Substring(0, 1).Equals(myWord.Substring(0, 1).ToUpper))
							{
								myWord += firstLetter.ToString().ToLower() + "ay";
							}
							/* If word is not in capitals */
							else
							{
								myWord += firstLetter.ToString().ToLower() + "ay";
							}
						}
					}
				}

				/* Append to sb StringBuilder and print to screen in txtPigLatin text-box */
				sb.Append(myWord + " ");
				txtPigLatin.Text = sb.ToString();
			}
		}
	}
}