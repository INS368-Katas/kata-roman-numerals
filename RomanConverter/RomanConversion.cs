using System.Collections.Generic;

namespace RomanConverter
{
	public class RomanConversion
	{
		private static Dictionary<char, int> romanNumerals = new Dictionary<char, int>() {
			{'I', 1},
			{'V', 5},
			{'X', 10},
			{'L', 50},
			{'C', 100},
			{'D', 500},
			{'M', 1000},
		};


		public static int ToArab(string romanValue)
		{
			int arabSum = 0;

			char[] romanChar = romanValue.ToCharArray();

			for (int i = 0; i < romanValue.Length; i++)
			{
				char currentLetter = romanChar[i];

				int romanNum = romanNumerals[currentLetter];

				if (i == romanValue.Length - 1)
				{
					arabSum += romanNum;
					continue;
				}

				int romanNextNum = romanNumerals[romanChar[i + 1]];

				if (romanNum < romanNextNum)
				{
					arabSum += romanNextNum;
					arabSum -= romanNum;
					i++;
				}
				else
				{
					arabSum += romanNum;
				}

			}

			if (arabSum < 1 || arabSum > 3999)
				return 0;

			return arabSum;
		}
		public static string ToRoman(int arabicValue)
		{
			if (arabicValue < 1 || arabicValue > 3999)
			{
				return "0";
			}
			string romanValue = "";
			while (arabicValue != 0)
			{
				if (arabicValue >= 1000)
				{
					arabicValue -= 1000;
					romanValue += "M";
				}
				else if (arabicValue < 1000 && arabicValue >= 500)
				{
					if (arabicValue >= 900)
					{
						arabicValue -= 900;
						romanValue += "CM";
					}
					else
					{
						arabicValue -= 500;
						romanValue += "D";
					}
				}
				else if (arabicValue < 500 && arabicValue >= 100)
				{
					if (arabicValue >= 400)
					{
						arabicValue -= 400;
						romanValue += "CD";
					}
					else
					{
						arabicValue -= 100;
						romanValue += "C";
					}
				}
				else if (arabicValue < 100 && arabicValue >= 50)
				{
					if (arabicValue >= 90)
					{
						arabicValue -= 90;
						romanValue += "XC";
					}
					else
					{
						arabicValue -= 50;
						romanValue += "L";
					}
				}
				else if (arabicValue < 50 && arabicValue >= 10)
				{
					if (arabicValue >= 40)
					{
						arabicValue -= 40;
						romanValue += "XL";
					}
					else
					{
						arabicValue -= 10;
						romanValue += "X";
					}
				}
				else if (arabicValue < 10 && arabicValue >= 5)
				{
					if (arabicValue >= 9)
					{
						arabicValue -= 9;
						romanValue += "IX";
					}
					else
					{
						arabicValue -= 5;
						romanValue += "V";
					}
				}
				else if (arabicValue < 5 && arabicValue >= 1)
				{
					if (arabicValue >= 4)
					{
						arabicValue -= 4;
						romanValue += "IV";
					}
					else
					{
						arabicValue -= 1;
						romanValue += "I";
					}
				}
			}
			return romanValue;
		}
	}
}