using System.Diagnostics;
using System.Net;
using System.Text;
using Microsoft.Playwright;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            _browserService.SearchTerm = localSearchTermT.Text;
            tabControl1.SelectedIndex = 1;
            // var t = "https://www.upwork.com/ab/messages/rooms/room_dca021eab02a97d4f52fffecb972b266?companyReference=424280317397024769&sidebar=true";
            // var y = new Uri(t);
        }

        private async void OnRequestCaptured(object sender, Response response)
        {
            Invoke((MethodInvoker)async delegate
            {
                try
                {
                    requestsGrid.Rows.Add(response.Request.Method, response.Request.Url, response.Request.ResourceType, response);
                    SaveConfig();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                }
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

            var req = GetRequestFromUi();
            var config = new Config()
            {
                Url = urlT.Text,
                Xpath = xpathT.Text,
                SearchTerm = localSearchTermT.Text,
                RequestInDebug = req,
                Result = resultT.Text,
                LocalSearchTerm = localSearchTermT.Text,
                SameDomain = sameDomainC.Checked
            };
            config.Save();
            _browserService.Config = config;
            _browserService.SaveRequests();
            Display("Saved!");
        }

        void LoadConfig()
        {
            var config = new Config().Load();
            if (config == null) return;
            urlT.Text = config.Url;
            xpathT.Text = config.Xpath;
            localSearchTermT.Text = config.SearchTerm;
            localSearchTermT.Text = config.LocalSearchTerm;
            sameDomainC.Checked = config.SameDomain;
            _browserService.Config = config;
            SetReqOnUI(config.RequestInDebug);
            _browserService.LoadRequests();
            PopulateRequestsGrid();
        }

        void PopulateRequestsGrid()
        {
            // if (config.TargetedRequests != null)
            //     foreach (var r in config.TargetedRequests)
            //         requestsGrid.Rows.Add(r.Method, r.Url, r.ResourceType, r);
            var requests = _browserService.AllRequests;
            foreach (var r in requests)
                    requestsGrid.Rows.Add(r.Request.Method, r.Request.Url, r.Request.ResourceType, r);
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _browserService.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
            _browserService.SearchTerm = localSearchTermT.Text;
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
            var response = (Response)requestsGrid.SelectedRows[0].Cells[3].Value;
            _requestOnDebug = response.Request;
            SetResponseOnUI(response);
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
            var formData = new StringBuilder();
            if (req.FormData != null) foreach (var f in req.FormData) formData.AppendLine($"{f.Key} : {f.Value}");
            headersT.Text = headers.ToString();
            cookiesT.Text = cookies.ToString();
            formDataT.Text = formData.ToString();
            if (!string.IsNullOrEmpty(req.FormBody)) 
                formDataT.Text = req.FormBody.BeautifyIfJson();
            tabControl1.SelectedIndex = 1;
        }
        private void SetResponseOnUI(Response response)
        {
            var req = response.Request;
            if (req == null) return;
            reqUrlT.Text = req.Url;
            httpMethodT.Text = req.Method == Method.Get ? "GET" : "POST";
            var headers = new StringBuilder();
            foreach (var reqHeader in req.Headers) headers.AppendLine($"{reqHeader.Key} : {reqHeader.Value}");
            var cookies = new StringBuilder();
            foreach (var c in req.Cookies) cookies.AppendLine($"{c.Key} : {c.Value}");
            var formData = new StringBuilder();
            if (req.FormData != null) foreach (var f in req.FormData) formData.AppendLine($"{f.Key} : {f.Value}");
            headersT.Text = headers.ToString();
            cookiesT.Text = cookies.ToString();
            formDataT.Text = formData.ToString();
            if (!string.IsNullOrEmpty(req.FormBody))
                formDataT.Text = req.FormBody.BeautifyIfJson();
            resultT.Text = response.Content.BeautifyIfJson();
            resultHeadersT.Text = response.Headers.DictionaryToText();
            SearchRequestsForKeyword();
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

            string reqBody = null;
            Dictionary<string, string> formData = null;
            if (headers.ContainsKey("content-type"))
                switch (headers["content-type"])
                {
                    case "application/x-www-form-urlencoded":
                        formData = formDataT.Text.ParseHeader();
                        break;
                    case "application/json":
                        reqBody = formDataT.Text;
                        break;
                }

            var request = new Request
            {
                Method = httpMethodT.SelectedIndex == 0 ? Method.Get : Method.Post,
                Url = reqUrlT.Text,
                Headers = headers,
                Cookies = cookies,
                FormBody = reqBody,
                FormData = formData
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
                var result = await _httpService.Execute(req);
                resultT.Text = result.body.BeautifyIfJson();
                resultHeadersT.Text = result.headers.DictionaryToText();
                var y=resultHeadersT.HighlightText(localSearchTermT.Text);
                howManyInHeadersL.Text = y.ToString();
                var x=resultT.HighlightText(localSearchTermT.Text);
                howManyInBodyL.Text = x.ToString();
                termExistL.Text = resultT.Text.Contains(localSearchTermT.Text) ? "Exist!" : "not there..";
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
            if (localSearchTermT.Text == "")
            {
                Display("you need to specify a search term to optimize");
                return;
            }
            Display("Start optimizing..");
            try
            {
                var req = GetRequestFromUi();
                var optimized = await _httpService.Optimize(req, localSearchTermT.Text);
                SetReqOnUI(optimized);
                Display("optimization completed");
            }
            catch (Exception exception)
            {
                Display($"Error : {exception.Message}");
            }
        }

        private void generateRequestCodeButton_Click(object sender, EventArgs e)
        {
            var req = GetRequestFromUi();
            resultT.Text = req.GenerateCode();
        }

        private void decodeUrlButton_Click(object sender, EventArgs e)
        {
            reqUrlT.Text = WebUtility.UrlDecode(reqUrlT.Text);
        }

        private async void openOnBrowserButton_Click(object sender, EventArgs e)
        {
            // await _browserService.SetHtml(resultT.Text);
            await File.WriteAllTextAsync("html.html",resultT.Text);
            var psi = new ProcessStartInfo
            {
                FileName = "html.html",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private async void getNeededRequestsButton_Click(object sender, EventArgs e)
        {
            var search = Clipboard.GetText();
            if (string.IsNullOrEmpty(search)) return;
            await _browserService.GetNeededRequests(search);
        }

        private void startNewCaptureButton_Click(object sender, EventArgs e)
        {
            requestsGrid.Rows.Clear();
            SaveConfig();
            _browserService.StartNewCapture();
        }

        private void addToFinalRequestsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchRequestsButton_Click(object sender, EventArgs e)
        {
            SearchRequestsForKeyword();
        }

        private void SearchRequestsForKeyword()
        {
            if (localSearchTermT.Text == "") return;
            foreach (DataGridViewRow r in requestsGrid.Rows)
            {
                var response = (Response)r.Cells[3].Value;
                if (response.ContainKeyword(localSearchTermT.Text))
                {
                    r.DefaultCellStyle.BackColor=Color.Green;
                }else if (response.Request.ContainKeyword(localSearchTermT.Text))
                {
                    r.DefaultCellStyle.BackColor=Color.Yellow;
                }
                else
                {
                    r.Visible = !hideIrreleventReqCheckbox.Checked;
                    r.DefaultCellStyle.BackColor=Color.White;
                }
            }
            var y=resultHeadersT.HighlightText(localSearchTermT.Text);
            howManyInHeadersL.Text = y.ToString();
            var x=resultT.HighlightText(localSearchTermT.Text);
            howManyInBodyL.Text = x.ToString();
            headersT.HighlightText(localSearchTermT.Text);
            formDataT.HighlightText(localSearchTermT.Text);
            cookiesT.HighlightText(localSearchTermT.Text);
        }

        private void stopCaptureButton_Click(object sender, EventArgs e)
        {
            _browserService.CaptureRequestsEnabled = false;
        }

        private void allRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myScenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToScenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}