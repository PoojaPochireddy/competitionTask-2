using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using MarsQACompetitionTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections;
namespace MarsQACompetitionTask.Pages 
{
    /*
   public class Certifications : CommonDriver
    {
        [Test]
        public void TestData()
        {
           driver.Navigate().GoToUrl(Utilities.ReadJsonData.GetData("Education[0].country"));
           Console.WriteLine(Utilities.ReadJsonData.GetData("Education[0].country"));
        }
       
    }*/
    public class Certification
    {
        private readonly IWebDriver driver;
        private IWebElement CertificationTab1 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private IWebElement AddNewBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement CName => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private IWebElement CertifiedFrom => driver.FindElement(By.Name("certificationFrom"));
        private IWebElement CYearDrpdown => driver.FindElement(By.Name("certificationYear"));
        private IWebElement AddCertification => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement CancelCertification => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private IWebElement EditCertification => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
        private IWebElement CUpdateBtn => driver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement CancelCBtn1 => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private IWebElement DeleteCertification => driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]"));
        private IWebElement DelMessage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]"));
        private IWebElement RemoveButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));


        //Duplicate Certifications Details cant be added so cleanup the existing education records first //
        public void CleanEducationTable()
        {
            try
            {
                while (RemoveButton.Displayed) //once all Certification details are deleted, remove button wont be displayed and loop will end
                {
                    RemoveButton.Click();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Certification(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CertificationTab()
        {
            CertificationTab1.Click();
        }
        public void CreateCertification()
        {
            IList certdetails;
            certdetails = Utilities.ReadJsonData.GetDataObject2("Certification[*]");
            int j = 0;
            j = certdetails.Count;

            Console.WriteLine("cert details '''''", j);


            for (int i = 0; i < j; i++)
            { 

            AddNewBtn.Click();
            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            CertifiedFrom.Click();
            CertifiedFrom.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertifiedFrom"));

            CYearDrpdown.Click();
                CYearDrpdown.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CyrDropdown"));


            AddCertification.Click();
            Thread.Sleep(1000);
        }

        }
        public void CancelAddedCertification()
        {

            CertificationTab1.Click();

            int i = 0;

            AddNewBtn.Click();

           
            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            CertifiedFrom.Click();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertifiedFrom"));


            CYearDrpdown.Click();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CyrDropdown"));

            CancelCertification.Click();
        }

        public void EditCertification1()
        {
            Thread.Sleep(2000);
            EditCertification.Click();
            int i = 0;

            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));


            CUpdateBtn.Click();

        }
        public void CancelEditCertification()
        {
            Thread.Sleep(2000);
            EditCertification.Click();

            int i = 0;

            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            CancelCBtn1.Click();
        }
        public void DeleteCertification1()
        { 
            DeleteCertification.Click();

            if (DelMessage.Text == "Certification Entry Successfully Removed")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}
