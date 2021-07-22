using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeleniumTutorial
{
    public partial class MainWindow : Form
    {
        IWebDriver seleniumDriver;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_SeleniumTest01_Click(object sender, EventArgs e)
        {
            FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
            driverServiceFF.HideCommandPromptWindow = true;

            FirefoxOptions optionsFF = new FirefoxOptions();
            optionsFF.AddArgument("-headless");
            seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

            //seleniumDriver = new FirefoxDriver();
            seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

            IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
            txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

            if (double.TryParse(childElement.Text.Replace(",","."), out double cooperPriceDouble))
            {
                //string temp = string.Format("{0:N2}", cooperPriceDouble);
                string temp = cooperPriceDouble.ToString("0.00", CultureInfo.InvariantCulture);
                txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
            }
        }

        private void Btn_CloseSelenium_Click(object sender, EventArgs e)
        {
            seleniumDriver.Close();
            seleniumDriver.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
            driverServiceChrome.HideCommandPromptWindow = true;

            ChromeOptions optionChrome = new ChromeOptions();
            optionChrome.AddArgument("-headless");
            seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

            //seleniumDriver = new FirefoxDriver();
            seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

            IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
            txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

            if (double.TryParse(childElement.Text, out double cooperPriceDouble))
            {
                string temp = string.Format("{0:N2}", cooperPriceDouble);
                txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                try {
                    ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
                    driverServiceChrome.HideCommandPromptWindow = true;

                    ChromeOptions optionChrome = new ChromeOptions();
                    optionChrome.AddArgument("-headless");
                    seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

                    //seleniumDriver = new FirefoxDriver();
                    seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                    IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                    txt_MainTestResults.Text += parentElement.Text;
                    txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

                    IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                    txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

                    if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                    {
                        string temp = string.Format("{0:N2}", cooperPriceDouble);
                        txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                    }
                } catch { }
                try {
                    FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
                    driverServiceFF.HideCommandPromptWindow = true;

                    FirefoxOptions optionsFF = new FirefoxOptions();
                    optionsFF.AddArgument("-headless");
                    seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

                    //seleniumDriver = new FirefoxDriver();
                    seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                    IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                    txt_MainTestResults.Text += parentElement.Text;
                    txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

                    IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                    txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

                    if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                    {
                        string temp = string.Format("{0:N2}", cooperPriceDouble);
                        txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                    }
                } catch { }
            } catch { }



            seleniumDriver.Close();
            seleniumDriver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            txt_MainTestResults.Text = culture.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
            //driverServiceFF.HideCommandPromptWindow = true;

            //FirefoxOptions optionsFF = new FirefoxOptions();
            //optionsFF.AddArgument("-headless");
            //seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

            seleniumDriver = new FirefoxDriver();
            seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

            IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
            txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

            if (double.TryParse(childElement.Text, out double cooperPriceDouble))
            {
                string temp = string.Format("{0:N2}", cooperPriceDouble);
                txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
            //driverServiceChrome.HideCommandPromptWindow = true;

            //ChromeOptions optionChrome = new ChromeOptions();
            //optionChrome.AddArgument("-headless");
            //seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

            seleniumDriver = new ChromeDriver();
            seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

            IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
            txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

            if (double.TryParse(childElement.Text, out double cooperPriceDouble))
            {
                string temp = string.Format("{0:N2}", cooperPriceDouble);
                txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    //ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
                    //driverServiceChrome.HideCommandPromptWindow = true;

                    //ChromeOptions optionChrome = new ChromeOptions();
                    //optionChrome.AddArgument("-headless");
                    //seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

                    seleniumDriver = new ChromeDriver();
                    seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                    IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                    txt_MainTestResults.Text += parentElement.Text;
                    txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

                    IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                    txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

                    if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                    {
                        string temp = string.Format("{0:N2}", cooperPriceDouble);
                        txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                    }
                }
                catch { }
                try
                {
                    //FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
                    //driverServiceFF.HideCommandPromptWindow = true;

                    //FirefoxOptions optionsFF = new FirefoxOptions();
                    //optionsFF.AddArgument("-headless");
                    //seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

                    seleniumDriver = new FirefoxDriver();
                    seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                    IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                    txt_MainTestResults.Text += parentElement.Text;
                    txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

                    IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                    txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

                    if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                    {
                        string temp = string.Format("{0:N2}", cooperPriceDouble);
                        txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                    }
                }
                catch { }
            }
            catch { }



            seleniumDriver.Close();
            seleniumDriver.Quit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string region = culture.ToString().Split('-')[1];

            Regex regex = new Regex(@"-.+");
            Match match = regex.Match(culture.ToString());
            int stopper = 0;
            //if (region == "US")
            //else if (region == "DE")
                    
            if (match.Value == "-US")
            {
                try
                {
                    try
                    {
                        ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
                        driverServiceChrome.HideCommandPromptWindow = true;

                        ChromeOptions optionChrome = new ChromeOptions();
                        optionChrome.AddArgument("-headless");
                        seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

                        //seleniumDriver = new ChromeDriver();
                        seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                        IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                        //txt_MainTestResults.Text += parentElement.Text;
                        //txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;
                        string parente = parentElement.Text;
                        IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                        txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;
                        string childe = childElement.Text;
                        stopper++;
                        if (double.TryParse(childElement.Text.Replace(",", "."), out double cooperPriceDouble))
                        {
                            //string temp = string.Format("{0:N2}", cooperPriceDouble);
                            string temp = cooperPriceDouble.ToString("0.00", CultureInfo.InvariantCulture);
                            txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                        }
                    }
                    catch { }
                    try
                    {
                        FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
                        driverServiceFF.HideCommandPromptWindow = true;

                        FirefoxOptions optionsFF = new FirefoxOptions();
                        optionsFF.AddArgument("-headless");
                        seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

                        //seleniumDriver = new FirefoxDriver();
                        seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                        IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                        //txt_MainTestResults.Text += parentElement.Text;
                        //txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;
                        string parente = parentElement.Text;
                        IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                        txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;
                        string childe = childElement.Text;
                        stopper++;
                        if (double.TryParse(childElement.Text.Replace(",", "."), out double cooperPriceDouble))
                        {
                            //string temp = string.Format("{0:N2}", cooperPriceDouble);
                            string temp = cooperPriceDouble.ToString("0.00", CultureInfo.InvariantCulture);
                            txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                        }
                    }
                    catch { }
                }
                catch { }



                seleniumDriver.Close();
                seleniumDriver.Quit();
            } 
            else if (match.Value == "-DE") 
            {
                try
                {
                    try
                    {
                        ChromeDriverService driverServiceChrome = ChromeDriverService.CreateDefaultService();
                        driverServiceChrome.HideCommandPromptWindow = true;

                        ChromeOptions optionChrome = new ChromeOptions();
                        optionChrome.AddArgument("-headless");
                        seleniumDriver = new ChromeDriver(driverServiceChrome, optionChrome);

                        //seleniumDriver = new ChromeDriver();
                        seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                        IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                        //txt_MainTestResults.Text += parentElement.Text;
                        //txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

                        IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                        txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;


                        if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                        {
                            string temp = string.Format("{0:N2}", cooperPriceDouble);
                            txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
                        }
                    }
                    catch { }
                    try
                    {
                        FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
                        driverServiceFF.HideCommandPromptWindow = true;

                        FirefoxOptions optionsFF = new FirefoxOptions();
                        optionsFF.AddArgument("-headless");
                        seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

                        //seleniumDriver = new FirefoxDriver();
                        seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

                        IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
                        //txt_MainTestResults.Text += parentElement.Text;
                        //txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;
                        string parente = parentElement.Text;
                        IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
                        //txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;
                        string childe = childElement.Text;
                        stopper++;

                        if (double.TryParse(childElement.Text, out double cooperPriceDouble))
                        {
                            string temp = string.Format("{0:N2}", cooperPriceDouble);
                            txt_MainTestResults.Text += temp;
                        }

                    }
                    catch { }
                }
                catch { }



                seleniumDriver.Close();
                seleniumDriver.Quit();
            }
        }

        private void btSearchOnline_Click(object sender, EventArgs e)
        {
            FirefoxDriverService driverServiceFF = FirefoxDriverService.CreateDefaultService();
            driverServiceFF.HideCommandPromptWindow = true;

            FirefoxOptions optionsFF = new FirefoxOptions();
            seleniumDriver = new FirefoxDriver(driverServiceFF, optionsFF);

            //seleniumDriver = new FirefoxDriver();
            seleniumDriver.Url = "https://www.google.com/search?q=" + tbSearch.Text;

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("yuRUbf"));
                        
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;


            IWebElement childElement1 = seleniumDriver.FindElement(By.ClassName("IsZvec"));
            txt_MainTestResults.Text += Environment.NewLine + "Descriere: " + childElement1.Text;
            
        }

        private void btnEdgeSelenium_Click(object sender, EventArgs e)
        {
            EdgeDriverService driverServiceEdge = EdgeDriverService.CreateDefaultService(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SeleniumDrivers");
            driverServiceEdge.HideCommandPromptWindow = true;

            EdgeOptions optionsEdge = new EdgeOptions();
            seleniumDriver = new EdgeDriver(driverServiceEdge, optionsEdge);

            seleniumDriver.Url = "https://www.helukabel.de/de-de/Service/Metallnotierung/index.html";

            IWebElement parentElement = seleniumDriver.FindElement(By.ClassName("microservice-metal-notation__table"));
            txt_MainTestResults.Text += parentElement.Text;
            txt_MainTestResults.Text += Environment.NewLine + "***" + Environment.NewLine;

            IWebElement childElement = parentElement.FindElement(By.ClassName("microservice-metal-notation__tb-row-data-right"));
            txt_MainTestResults.Text += Environment.NewLine + "The price for cooper is: " + childElement.Text;

            if (double.TryParse(childElement.Text.Replace(",", "."), out double cooperPriceDouble))
            {
                //string temp = string.Format("{0:N2}", cooperPriceDouble);
                string temp = cooperPriceDouble.ToString("0.00", CultureInfo.InvariantCulture);
                txt_MainTestResults.Text += Environment.NewLine + "Sucesfully converted to double: " + temp;
            }
        }
    }
}


/** Sources
 * https://www.toolsqa.com/selenium-c-sharp/
 * https://www.toolsqa.com/selenium-webdriver/c-sharp/findelement-and-findelements-commands-in-c/
 * https://stackoverflow.com/a/48569625 (hide the browser)
 * https://stackoverflow.com/a/60115129 (hide the CMD)
 * https://yizeng.me/2014/03/05/hide-command-prompt-window-in-selenium-webdriver-net-binding/ (also hide the cmd)
 */
