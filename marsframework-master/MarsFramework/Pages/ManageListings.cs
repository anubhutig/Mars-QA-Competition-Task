using MarsFramework.Global;
using MarsFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static MarsFramework.Global.GlobalDefinitions;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesDelete { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");


        }

        public void ManageListingsEditListingSteps()
        {
            //Click on Manage Listings button
            manageListingsLink.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            manageListingsLink.Click();
            GlobalDefinitions.wait(10);


            //Click on Manage Listings edit button
            edit.Click();
            GlobalDefinitions.wait(10);
            ShareSkill ShareSkillPage = new ShareSkill();
            ShareSkillPage.EditShareSkill();
        }

        public void DeleteShareSkill()
        {
            // navigate to ManageListings page
            manageListingsLink.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            manageListingsLink.Click();

            //Identify and click on delete button
            delete.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            delete.Click();
            GlobalDefinitions.wait(2);
            // Switch to Popup button
            YesDelete.WaitForElementClickable(GlobalDefinitions.driver, 60);
            YesDelete.Click();
            GlobalDefinitions.wait(2);

            string message = (GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"))).Text;
            GlobalDefinitions.wait(5);
            if (message.Contains("has been deleted"))
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
           // Assert.True(message.Contains("has been deleted"));
        }

        public void ViewShareSkill()
        {
            // navigate to ManageListings page
            manageListingsLink.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            manageListingsLink.Click();

            //Identify and click on view button
            view.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            view.Click();
            GlobalDefinitions.wait(2);

            


        }
    }
}
