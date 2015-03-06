// <copyright file="RomanNumeralGeneratorTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator;

namespace RomanNumeralGenerator
{
    [TestClass]
    [PexClass(typeof(global::RomanNumeralGenerator.RomanNumeralGenerator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RomanNumeralGeneratorTest
    {
		[PexMethod]
		public string Generate([PexAssumeUnderTest]global::RomanNumeralGenerator.RomanNumeralGenerator target, int number)
		{
			string result = target.Generate(number);
			return result;
			// TODO: add assertions to method RomanNumeralGeneratorTest.Generate(RomanNumeralGenerator, Int32)
		}
	}
}
