using System;
using Gauge.CSharp.Lib.Attribute;
using GaugeCalculator;
using FluentAssertions;


namespace SampleProjectGauge
{
	public class CalculatorStepImplementationGauge
	{
        private readonly Calculator _calculatorApp = new Calculator();
        private int _result;

		[Step("Then the result should be <result>.")]
		public void ThenTheResultShouldBe(int result)
		{
            _result.Should().Be(result);
		}

	
		[Step("Given the first number is <number>.")]
		public void GivenTheFirstNumberIs(int number)
		{
            _calculatorApp.FirstNumber = number;
		}
	
		[Step("And the second number is <number>.")]
		public void AndTheSecondNumberIs(int number)
		{
            _calculatorApp.SecondNumber = number;
		}
	
		[Step("When the two numbers are added.")]
		public void WhenTheTwoNumbersAreAdded()
		{
            _result = _calculatorApp.Add();
		}
	}
}
