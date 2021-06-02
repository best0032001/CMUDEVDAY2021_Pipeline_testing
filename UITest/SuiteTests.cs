﻿// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
using UITest;

public class SuiteTests : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
    public SuiteTests()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<String, Object>();
    }
    public void Dispose()
    {
        driver.Quit();
    }
    public string waitForWindow(int timeout)
    {
        try
        {
            Thread.Sleep(timeout);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
        var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
        if (whNow.Count > whThen.Count)
        {
            return whNow.Except(whThen).First().ToString();
        }
        else
        {
            return whNow.First().ToString();
        }
    }

    [Fact]
    public void Case1()
    {
        driver.Navigate().GoToUrl("https://mis.cmu.ac.th/TQF/TQF2/CurriculumPublicList.aspx");
        driver.Manage().Window.Size = new System.Drawing.Size(1580, 840);
        driver.FindElement(By.Id("ddlListFaculty"), 1).Click();
        {
            var dropdown = driver.FindElement(By.Id("ddlListFaculty"));
            dropdown.FindElement(By.XPath("//option[. = 'Faculty of Humanities']")).Click();
        }
        driver.FindElement(By.Id("ddlListFaculty"), 1).Click();
        driver.FindElement(By.Id("ddlStudentLevelID"), 1).Click();
        {
            var dropdown = driver.FindElement(By.Id("ddlStudentLevelID"));
            dropdown.FindElement(By.XPath("//option[. = 'Bachelor’s degree']")).Click();
        }
        driver.FindElement(By.Id("ddlStudentLevelID"), 1).Click();
        driver.FindElement(By.Id("btnSearch"), 1).Click();
        driver.FindElement(By.Id("GVCuriculumList_btnCurriculumNameTha_0"), 1).Click();
        driver.FindElement(By.Id("ddlLanguage"), 1).Click();
        {
            var dropdown = driver.FindElement(By.Id("ddlLanguage"));
            dropdown.FindElement(By.XPath("//option[. = 'THA']")).Click();
        }
        driver.FindElement(By.Id("ddlLanguage"), 1).Click();

    }
}