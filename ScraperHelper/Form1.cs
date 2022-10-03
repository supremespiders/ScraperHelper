using System.Diagnostics;
using System.Text;
using Microsoft.Playwright;
using ScraperHelper.Extensions;
using ScraperHelper.Models;
using ScraperHelper.Services;

namespace ScraperHelper
{
    public partial class Form1 : Form
    {
        private readonly BrowserService _browserService = new();
        private readonly HttpService _httpService = new();
        private Request _requestOnDebug;

        public Form1()
        {
            InitializeComponent();
        }

        private async void openBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _browserService.StartBrowser(false, urlT.Text);
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
            _browserService.SearchTerm = searchTermT.Text;
        }

        private void OnRequestCaptured(object sender, IRequest e)
        {
            Invoke((MethodInvoker)delegate
            {
                var req = new Request(e);
                requestsGrid.Rows.Add(req.Method, req.Url, req.ResourceType, req);
                SaveConfig();
            });
        }

        private void OnXpathChanged(object sender, string e)
        {
            Invoke((MethodInvoker)delegate { xpathT.Text = e; });
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
            var targetedRequests = requestsGrid.Rows.Cast<DataGridViewRow>()
                .Select(row => (Request)row.Cells[3].Value).ToList();

            var req = GetRequestFromUi();
            var config = new Config()
            {
                Url = urlT.Text,
                Xpath = xpathT.Text,
                SearchTerm = searchTermT.Text,
                TargetedRequests = targetedRequests,
                RequestInDebug = req
            };
            config.Save();
            Display("Saved!");
        }

        void LoadConfig()
        {
            var config = new Config().Load();
            if (config == null) return;
            urlT.Text = config.Url;
            xpathT.Text = config.Xpath;
            searchTermT.Text = config.SearchTerm;
            if (config.TargetedRequests != null)
                foreach (var r in config.TargetedRequests)
                    requestsGrid.Rows.Add(r.Method, r.Url, r.ResourceType, r);
            SetReqOnUI(config.RequestInDebug);
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _browserService.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
            _browserService.SearchTerm = searchTermT.Text;
        }

        private void optimizeButton_Click(object sender, EventArgs e)
        {
        }

        private void startListeningButton_Click(object sender, EventArgs e)
        {
            _browserService.Subscribe();
            Display("Listening to mouse click , shift + click to capture xpath");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            requestsGrid.Rows.Clear();
            SaveConfig();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requestsGrid.SelectedRows.Count < 1) return;
            var req =(Request)requestsGrid.SelectedRows[0].Cells[3].Value;
            _requestOnDebug = req;
            SetReqOnUI(req);
            SaveConfig();
        }

        private void SetReqOnUI(Request req)
        {
            if (req == null) return;
            reqUrlT.Text = req.Url;
            httpMethodT.Text = req.Method == Method.Get ? "GET" : "POST";
            var headers = new StringBuilder();
            foreach (var reqHeader in req.Headers) headers.AppendLine($"{reqHeader.Key} : {reqHeader.Value}");
            var cookies = new StringBuilder();
            foreach (var c in req.Cookies) cookies.AppendLine($"{c.Key} : {c.Value}");
            headersT.Text = headers.ToString();
            cookiesT.Text = cookies.ToString();
            tabControl1.SelectedIndex = 1;
        }

        private Request GetRequestFromUi()
        {
            var headers = new Dictionary<string, string>();
            if (headersT.Text != "")
            {
                headers = headersT.Text.ParseHeader();
            }
            var cookies = new Dictionary<string, string>();
            if (cookiesT.Text != "")
                cookies = cookiesT.Text.ParseHeader();
            var request = new Request
            {
                Method = httpMethodT.SelectedIndex == 0 ? Method.Get : Method.Post,
                Url = urlT.Text,
                Headers = headers,
                Cookies = cookies
            };
            return request;
        }


        private async void execRequestButton_Click(object sender, EventArgs e)
        {
            Display("Requesting..");
            resultT.Text = "";
            try
            {
                var req = GetRequestFromUi();
                resultT.Text = await _httpService.Execute(req);
                termExistL.Text = resultT.Text.Contains(searchTermT.Text) ? "Exist!" : "not there..";
                Display("completed");
            }
            catch (Exception exception)
            {
                Debug.Write(exception);
                Display($"error : {exception.Message}");
            }
        }

        private async void optimizeRequestButton_Click(object sender, EventArgs e)
        {
            Display("Start optimizing..");
            try
            {
                var req = GetRequestFromUi();
                var optimized = await _httpService.Optimize(req, searchTermT.Text);
                SetReqOnUI(optimized);
                Display("optimization completed");
            }
            catch (Exception exception)
            {
               Display($"Error : {exception.Message}");
            }
            
        }
    }
}