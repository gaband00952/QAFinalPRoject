using OpenQA.Selenium;
using System;

namespace FinalProject
{
    internal class SelectElement
    {
        private IWebElement webElement;

        public SelectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        internal void SelectByText(string province)
        {
            throw new NotImplementedException();
        }
    }
}