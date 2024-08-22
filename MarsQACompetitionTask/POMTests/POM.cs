using MarsQACompetitionTask.Pages;
using MarsQACompetitionTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.DevTools.V114.Profiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQACompetitionTask.POMTests
{
    [TestFixture]
    public class EducationAndCertificationTests  : CommonDriver
    {
        /*public IWebDriver driver;
        public SignIn SignInObj;
        public Education EducationObj;
        public Certifications CertificationObj;*/
        

        [Test, Order(1), Description("Create Record")]
        public void CreateEducationTests()
        {
            SignInObj.SigninStep();
            EducationObj.EducationTab();
            EducationObj.CleanEducationTable();
            Assert.AreEqual("Education has been added", EducationObj.CreateEducation());
        }

        [Test, Order(2), Description("Cancel Record")]
        public void CancelEducationTests()
        {
            SignInObj.SigninStep();
            EducationObj.EducationTab();
            EducationObj.CancelAddedEducation();
        }
        [Test, Order(3), Description("Edit or update Record")]
        public void UpdateEducationTests()
        {
            SignInObj.SigninStep();
            EducationObj.EducationTab();
            EducationObj.CleanEducationTable();
            Assert.AreEqual("Education has been added", EducationObj.CreateEducation());
            Assert.AreEqual("Education as been updated", EducationObj.EditEducation());
        }
        [Test, Order(4), Description("CancelUpdated Record")]
        public void CancelUpdatedEducationTests()
        {
            SignInObj.SigninStep();
            EducationObj.EducationTab();
            EducationObj.CancelEditEducation();
        }
        [Test, Order(5), Description("Delete Record")]
        public void DeleteEducationTests()
        {
            SignInObj.SigninStep();
            EducationObj.EducationTab();
            EducationObj.DeleteEducation();
            Thread.Sleep(1000);
        }
        [Test, Order(6), Description("Create CRecord")]
        public void CreateCertificationsTests()
        {
            SignInObj.SigninStep();
            CertificationObj.CertificationTab();
            CertificationObj.CreateCertification();
        }

        [Test, Order(7), Description("Cancel Record")]
        public void CancelAddedCertifications()
        {
            SignInObj.SigninStep();
            CertificationObj.CertificationTab();
            CertificationObj.CancelAddedCertification();
        }
        [Test, Order(8), Description("Edit or update Record")]
        public void UpdateCertification()
        {
            SignInObj.SigninStep();
            CertificationObj.CertificationTab();
            CertificationObj.EditCertification1();

        }
        [Test, Order(9), Description("CancelUpdated Record")]
        public void CancelUpdatedCertificationTests()
        {
            SignInObj.SigninStep();
            CertificationObj.CertificationTab();
            CertificationObj.CancelEditCertification();
        }
        [Test, Order(10), Description("Delete Record")]
        public void DeleteCertificationTests()
        {
            SignInObj.SigninStep();
            CertificationObj.CertificationTab();
            CertificationObj.DeleteCertification1();
            Thread.Sleep(1000);
        }

    }
}
