using Microsoft.Playwright;
using ScraperHelper.Extensions;
using ScraperHelper.Models;
using ScraperHelper.Services;

namespace ScraperHelper
{
    public partial class Form1 : Form
    {
        private readonly BrowserService _browserService = new BrowserService();

        public Form1()
        {
            InitializeComponent();
        }

        private async void openBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _browserService.StartBrowser(false,urlT.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private delegate void DisplayD(string s);

        private void Display(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new DisplayD(Display), s);
                return;
            }

            displayT.Text = s;
        }

        private void OnDisplay(object sender, string e)
        {
            Display(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Notifier.OnDisplay += OnDisplay;
            _browserService.OnXpathChanged += OnXpathChanged;
            _browserService.OnRequestCaptured += OnRequestCaptured;
            LoadConfig();
            _browserService.SearchTerm=searchTermT.Text;
        }

        private void OnRequestCaptured(object sender, IRequest e)
        {
            Invoke((MethodInvoker)delegate
            {
                requestsGrid.Rows.Add(e.Method, e.Url, e.ResourceType);
            });
        }

        private void OnXpathChanged(object sender, string e)
        {
           Invoke((MethodInvoker)delegate
           {
               xpathT.Text = e;
           });
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), @"Unhandled Thread Exception");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception)?.ToString(), @"Unhandled UI Exception");
        }

        void SaveConfig()
        {
            var config = new Config()
            {
                Url = urlT.Text,
                Xpath = xpathT.Text,
                SearchTerm = searchTermT.Text
            };
            config.Save();
            Display("Saved!");
        }

        void LoadConfig()
        {
            var config = new Config().Load();
            if (config == null) return;
            urlT.Text = config.Url;
            xpathT.Text=config.Xpath;
            searchTermT.Text=config.SearchTerm;
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _browserService.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
            _browserService.SearchTerm=searchTermT.Text;
        }

        private void optimizeButton_Click(object sender, EventArgs e)
        {

        }

        private void startListeningButton_Click(object sender, EventArgs e)
        {
            _browserService.Subscribe();
            Display("Listening to mouse click , shift + click to capture xpath");
        }
    }
}