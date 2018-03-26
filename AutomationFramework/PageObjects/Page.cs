

namespace AutomationFramework.PageObjects
{
    public abstract class Page
    {
        public Page(string url)
        {
            this.url = url; 
        }

        private string url;

        public void Open()
        {
            Browser.Instance.Navigate().GoToUrl(url);
        }

        public bool IsOpened
        {
            get
            {
                return Browser.Instance.Url.StartsWith(url);
            }
        }

    }
}
