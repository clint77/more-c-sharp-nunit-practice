using NUnit.Framework;
using System;

namespace BookParsingCv2
{
	[TestFixture ()]
	public class BookParsingTest
	{
		[Test ()]
		public void ItShouldTakeATextFileAndConvertTolowerCase ()
		{
			BookParsing program = new BookParsing ();
			Assert.AreEqual ("", "");
		}
	}
}

