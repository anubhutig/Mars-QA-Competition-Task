using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            

            [Test,Order(1)]
           
            public void CreateShareSkill()
            {
                //Start the Reports
                test = extent.StartTest("Create ShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Created");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                //Create Share Skills      
                ShareSkill skillObj = new ShareSkill();
                skillObj.EnterShareSkill();
                //skillObj.ValidateCreateListing();


            }

        

            [Test, Order(2)]
            public void ViewRecord()
            {
                //Start the Reports
                test = extent.StartTest("ViewRecord");
                test.Log(LogStatus.Info, "ShareSkills Record Visible");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                ManageListings manageListingsobj = new ManageListings();
                manageListingsobj.ViewShareSkill();
            }
            [Test, Order(4)]
            public void DeleteRecord()
            {
                //Start the Reports
                test = extent.StartTest("DeleteShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Deleted");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                ManageListings manageListingsobj = new ManageListings();
                manageListingsobj.DeleteShareSkill();
            }
            [Test, Order(3)]

            public void EditRecord()
            {
                //Start the Reports
                test = extent.StartTest("EditShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Edited");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                ManageListings manageListingsObj = new ManageListings();
                manageListingsObj.ManageListingsEditListingSteps();
            }

        }
    }
}
