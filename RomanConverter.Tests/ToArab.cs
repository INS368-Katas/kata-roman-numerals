using NUnit.Framework;
using RomanConverter;

namespace RomanConverter.Tests
{
	public class ToArab
	{
		[Test]
		public void Assert_RomanValue_Equals_5()
		{
			string romanValue = "V";
			int expected = 5;

			int result = RomanConversion.ToArab(romanValue);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Assert_RomanValue_Exceeds_Limits()
		{
			string romanValue = "MMMMM";
			int expected = 0;

			int result = RomanConversion.ToArab(romanValue);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Assert_RomanValue_Equals_3999()
		{
			string romanValue = "MMMCMXCIX";
			int expected = 3999;

			int result = RomanConversion.ToArab(romanValue);
			Assert.AreEqual(expected, result);
		}
	}
}