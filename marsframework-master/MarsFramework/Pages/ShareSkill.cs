using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System.Threading;
using MarsFramework.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    public class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        //Select the Hourly Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyServiceType { get; set; }

        //Select On-Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffServiceType { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }
        //Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement OnSiteLocationType { get; set; }

        //Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement OnlineLocationType { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

       // [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[1]//div[1]//input[1]")]
      //  private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement Credit { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchange { get; set; }

        //Enter Skill Exchange tag
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Find Active Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveButton { get; set; }

        //Find Hidden Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenButton { get; set; }

        //Click on Work Sample button
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSample { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        public void EnterShareSkill()
        {
            ShareSkillButton.WaitForElementClickable(GlobalDefinitions.driver, 60);
            ShareSkillButton.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            CategoryDropDown.Click();
            SelectElement selectCategory = new SelectElement(CategoryDropDown);
            selectCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            SubCategoryDropDown.Click();
            SelectElement selectSubCategory = new SelectElement(SubCategoryDropDown);
            selectSubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            String ServiceType = ((GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType")));
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyServiceType.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OneOffServiceType.Click();
            }
            //Select Location Type
            String LocationType = ((GlobalDefinitions.ExcelLib.ReadData(2, "LocationType")));
            if (LocationType.Equals("On-site"))
            {
                OnSiteLocationType.Click();
            }
            else if (LocationType.Equals("Online"))
            {
                OnlineLocationType.Click();
            }
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Click Checkboxes
            IList<IWebElement> AvailableCheckboxes = Days.FindElements(By.Name("Available"));
            String AvailableDaysValue = GlobalDefinitions.ExcelLib.ReadData(2, "SelectDay");
            IList<String> AvailableDays = AvailableDaysValue.Split(',');
            for (int i = 0; i < WeekDays.Count(); i++)
            {
                if (AvailableDays.Contains(WeekDays[i]))
                {
                    AvailableCheckboxes[i].Click();
                }
                
            }
            //Set Start times
            IList<IWebElement> AvailableStartTimeInputs = Days.FindElements(By.Name("StartTime"));
            String AvailableStartTimesValue = GlobalDefinitions.ExcelLib.ReadData(2, "StartingTime");
            IList<String> AvailableStartTimes = AvailableStartTimesValue.Split(',');
            for (int i = 0; i < AvailableStartTimes.Count(); i++)
            {
                IList<String> startTimeInfo = AvailableStartTimes[i].Split(':');
                String startTimeDay = startTimeInfo[0];
                String startTimeValue = startTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, startTimeDay);
                AvailableStartTimeInputs[indexOfDay].SendKeys(startTimeValue);

            }

            //Set End time
            IList<IWebElement> AvailableEndTimeInputs = Days.FindElements(By.Name("EndTime"));
            String AvailableEndTimesValue = GlobalDefinitions.ExcelLib.ReadData(2, "EndingTime");
            IList<String> AvailableEndTimes = AvailableEndTimesValue.Split(',');
            for (int i = 0; i < AvailableEndTimes.Count(); i++)
            {
                IList<String> endTimeInfo = AvailableEndTimes[i].Split(':');
                String endTimeDay = endTimeInfo[0];
                String endTimeValue = endTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, endTimeDay);
                AvailableEndTimeInputs[indexOfDay].SendKeys(endTimeValue);
            }

            //Select Skill Exchange Type
            String SkillTradeType = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTradeType");
            if (SkillTradeType.Equals("Skill-exchange"))
            {
                SkillExchange.Click();
                SkillExchangeTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangeTag"));
                SkillExchangeTag.SendKeys(Keys.Enter);
            }
            else if (SkillTradeType.Equals("Credit"))
            {
                Credit.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CreditAmount"));

            }

            WorkSample.Click();
            Thread.Sleep(2000);
            using (Process exeProcess = Process.Start(@"D:\Competition Task\marsframework-master\FileUploadWorkSample.exe"))
            {
                exeProcess.WaitForExit();
            }

           // Thread.Sleep(2000);
            //Select Active Status Button
            String ActiveType = GlobalDefinitions.ExcelLib.ReadData(2, "Status");
            if (SkillTradeType.Equals("Active"))
            {
                ActiveButton.Click();
            }
            else if (SkillTradeType.Equals("Hidden"))
            {
                HiddenButton.Click();
            }
          //  Thread.Sleep(2000);
                     
            Save.Click();
          
            // Validate Record
            GlobalDefinitions.wait(10);
           
               
                string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
                Assert.AreEqual(searchInput1, ExcelLib.ReadData(2, "Category"));
                string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
                Assert.AreEqual(searchInput2, ExcelLib.ReadData(2, "Title"));

                string searchInput3 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
                Assert.AreEqual(searchInput3, ExcelLib.ReadData(2, "Description"));
                Assert.AreEqual("ListingManagement", GlobalDefinitions.driver.Title);
            
                Console.WriteLine("Test Passed");
          
        }


        public void EditShareSkill()
         {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EditShareSkill");
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            CategoryDropDown.Click();
            SelectElement selectCategory = new SelectElement(CategoryDropDown);
            selectCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            SubCategoryDropDown.Click();
            SelectElement selectSubCategory = new SelectElement(SubCategoryDropDown);
            selectSubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            Save.Click();

            //Validate Record
            GlobalDefinitions.wait(20);
            string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
            Assert.AreEqual(searchInput1, ExcelLib.ReadData(2, "Category"));
            string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(searchInput2, ExcelLib.ReadData(2, "Title"));

            string searchInput3 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
            Assert.AreEqual(searchInput3, ExcelLib.ReadData(2, "Description"));
            Assert.AreEqual("ListingManagement", GlobalDefinitions.driver.Title);
            Console.WriteLine("Record Edited Successfully");


        }
    }
        }
   


