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
		private static String specChar = "~ ` ! @ # $ % ^ & * ( ) - _ = + | \\ } ] { [ ' : ; < , > . \" 0 1 2 3 4 5 6 7 8 9";
		private static String[] specialCharacters = specChar.Split(' ');
		/* ------------------------------------------ */

		public frmPigLatinTranslator()
		{
			InitializeComponent();
			txtEnglish.Focus();
			txtEnglish.Text = "This application will translate the English text you enter into Pig Latin. It will retain CASE and punctuation. It will also translate contractions, but it won't translate words that contain numbers or symbols, such as 86, bill@microsoft.com, or C#.";
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
			if (txtPigLatin.Text.Equals("Isthay applicationway illway anslatetray ethay Englishway exttay ouyay enterway intoway lgpay Atinlay. Itway illway etainray ASECAY andway unctuationpay. Itway illway alsoway anslatetray ontractionscay, utbay itway on'tway anslatetray ordsway attay ontaincay umbersnay orway ymbolssay, uchsay asway 86, bill@microsoft.com, orway C#."))
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

				/* If myWord is not blank and doesn't contain any special characters */
				if (!myWord.Equals("") && !specialCharacters.Any(myWord.Contains))
				{
				/* VOWEL OR CONTAINING 'Y'*/
					if (vowels.Contains(firstLetter) || myWord.ToLower().Substring(1, myWord.Length-1).Contains('y'))
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
				/* Y */
					else if  (firstLetter.ToLower().Equals('y'))
					{
						int index = GetVowelIndex(myWord);
						String untilFirstVowel = myWord.Substring(0, 1);
					}
				/* CONSONANT */
					else
					{
						if (!vowels.Contains(firstLetter))
						{							
							/* UPPER CASE */
							if ( myWord.Equals( myWord.ToUpper() ))
							{
								myWord = processConsonant(myWord).ToUpper();
							}
							/* Title Case */
							else if ( firstLetter.Equals( firstLetter.ToUpper() ))
							{
								myWord = processConsonant(myWord);
								myWord = myWord.Substring(0, 1).ToUpper() + myWord.Substring(1, myWord.Length-1);
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
				sb.Append(myWord + " ");
				txtPigLatin.Text = sb.ToString();
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
	}
}