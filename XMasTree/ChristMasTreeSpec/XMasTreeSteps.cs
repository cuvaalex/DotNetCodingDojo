using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ChristMasTree;
using NUnit.Framework;

namespace ChristMasTreeSpec
{
    [Binding]
    public class XMasTreeSteps
    {
        [Given(@"I have entered (\d+) into XMas Tree Software")]
        public void GivenIHaveEntered3IntoXmasTreeSoftware(int treeSize)
        {
            try
            {
                XMasTree tree = new XMasTree(treeSize);
                ScenarioContext.Current.Add("XMasTree", tree);
            }
            catch (ArgumentOutOfRangeException e)
            {
                ScenarioContext.Current.Add("Exception", e);
            }
        }

        [When(@"I press Draw")]
        public void WhenIPressDraw()
        {
            if(ScenarioContext.Current.ContainsKey("XMasTree")) {
                XMasTree tree = ScenarioContext.Current.Get<XMasTree>("XMasTree");
                tree.Draw();
            }
        }

        [Then(@"the result should be ""The tree should have a size at least of 3""")]
        public void ThenTheResultShouldBeTheTreeShouldHaveASizeAtLeastOf3()
        {
            String expected = "The tree should have a size at least of 3";

            if (ScenarioContext.Current.ContainsKey("Exception"))
            {
                ArgumentOutOfRangeException e 
                    = ScenarioContext.Current.Get<ArgumentOutOfRangeException>("Exception");
                Assert.That(e.ParamName, Is.EqualTo(expected));
            }
            else
            {
                Assert.Fail("There where no Exception");
            }
        }
        
        //When there is a multiline value, it's always like bellow
        [Then(@"the result on the screen should be :")]
        public void ThenTheResultShouldBeXXAndATrunkOfXXOnTheScreen(String expectedPattern)
        {

            if (ScenarioContext.Current.ContainsKey("XMasTree"))
            {                                
                XMasTree tree = ScenarioContext.Current.Get<XMasTree>("XMasTree");
                String result = tree.ToString();

                Assert.That(result, Is.StringContaining(expectedPattern));
            }
            else
            {
                Assert.Fail("There whas an unexpected Exception");
            }
            
        }
    }
}
