using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using RomanNumeral;
using NUnit.Framework;

namespace RomanNumeralSpec
{
    [Binding]
    public class RomanNumerialSteps
    {
        RomanNumerial romanNumeral;

        [Given(@"I have entered (.*) as Romanum")]
        public void GivenIHaveEnteredRomanum(String roman)
        {
            romanNumeral = new RomanNumerial(romanNumerial: roman);
        }

        [Given(@"I have entered (\d+) as Arabic")]
        public void GivenIHaveEnteredArabic(int arabic)
        {
            romanNumeral = new RomanNumerial(arabicNumber: arabic);        
        }

        [When(@"I press convert")]
        public void WhenIPressConvert()
        {
            romanNumeral.Convert();
        }

        [Then(@"the result should be (.*) as Arabic")]
        public void ThenTheResultShouldBeArabic(String expected)
        {
            if (expected == "ERROR")
            {
                Assert.That(ScenarioContext.Current.ContainsKey("ERROR"), Is.True);
                Assert.That(ScenarioContext.Current["ERROR"], Is.TypeOf(typeof(OverflowException)));
            }
            else
            {
                Assert.That(romanNumeral.ToInt(), Is.EqualTo(Int32.Parse(expected)));
            }
        }

        [Then(@"the result should be (.*) as Romanum")]
        public void ThenTheResultShouldBeRomanum(String expected)
        {
            if (expected == "ERROR")
            {
                Assert.That(ScenarioContext.Current.ContainsKey("ERROR"), Is.True);
                Assert.That(ScenarioContext.Current["ERROR"], Is.TypeOf(typeof(OverflowException)));
            }
            else
            {
                Assert.That(romanNumeral.ToString(), Is.EqualTo(expected));
            }
        }

    }
}
