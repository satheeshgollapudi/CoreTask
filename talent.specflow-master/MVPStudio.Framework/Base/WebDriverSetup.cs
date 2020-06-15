using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MVPStudio.Framework.Base
{
    public class WebDriverSetup
    {
        private readonly IObjectContainer _objectContainer;
        public IWebDriver Driver { get; set; }

        public WebDriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            // to stop the exception "The HTTP request to the remote WebDriver server for URL http://localhost:52847/session/... timed out after 60 seconds.'
           var options = new ChromeOptions();
             options.AddArgument("no-sandbox");
             Driver = new ChromeDriver(options);
           // Driver = new FirefoxDriver(); 
            _objectContainer.RegisterInstanceAs(Driver);

        }
    }
}