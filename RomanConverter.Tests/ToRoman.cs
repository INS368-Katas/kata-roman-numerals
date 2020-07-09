using NUnit.Framework;
using RomanConverter;

namespace RomanConverter.Tests
{
	public class ToRoman
	{
		[Test]
		public void Assert_RomannValue_Equals_RomanString()
		{
			int arabicValue = 2666;
			string expected = "MMDCLXVI";
			string result = RomanConversion.ToRoman(arabicValue);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Assert_ArabicValue_Exceeds_Limits()
		{
			int arabicValue = 4000;
			string expected = "0";
			string result = RomanConversion.ToRoman(arabicValue);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Assert_RomanValue_Equals_ArabicValue()
		{
			int arabicValue = 3999;
			string expected = "MMMCMXCIX";
			string result = RomanConversion.ToRoman(arabicValue);
			Assert.AreEqual(expected, result);
		}
	}
}