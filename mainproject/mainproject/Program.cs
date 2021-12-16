using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace mainproject

{
    class Program
    {
     

        static void Main(string[] args)
        {
            //Open chrome browser

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            //Launching turnup portalOpenQA.Selenium.NoSuchElementException has been thrown

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Indentyfy username tesxtbox and enter valid username

            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");



            //Identyfy Password textboxand enter valid password

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Click on login button

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //check if user login successfully
            IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            

            if (Hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else

            {
                Console.WriteLine("Login failed, test failed");

            }
        }
    }

}

