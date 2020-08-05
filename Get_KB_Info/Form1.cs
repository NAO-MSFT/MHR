using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using AngleSharp.Html.Parser;

namespace Get_KB_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView1.DOMContentLoaded += webView1_DOMContentLoaded;
            webView1.NavigationCompleted += webView1_NavigationCompleted;
        }

        public struct MyEntry
        {
            public int iIndex;
            public bool bLoadFinish;
        }

        public class ClassEntry
        {
            public int iIndex { get; set; }
            public bool bFinish { get; set; }
        }
        public List<ClassEntry> TargetList { get; set; } = new List<ClassEntry>();
        private bool bStopRequested { get; set; } = false;
        private int iLoop { get; set; } = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            Form2 dialog = new Form2(dataGridView1);
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            // Disable the button until the operation is complete.
            button2.Enabled = false;
            button3.Enabled = true;

            // One-step async call.
            await SumPageSizesAsync();

            // Reenable the button in case you want to run the operation again.
            button2.Enabled = true;
            button3.Enabled = false;
        }

        public async Task SumPageSizesAsync()
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            var iIndex = 0;
            TargetList.Clear();

            // calculates total count of websites
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[clmLoad.Name].Value != null)
                {
                    if ((bool)row.Cells[clmLoad.Name].Value)
                    {
                        ClassEntry e = new ClassEntry();
                        e.iIndex = iIndex;
                        e.bFinish = false;
                        TargetList.Add(e);
                    }
                }
                iIndex++;
            }

            // One-step async call.
            await DoNavigateAsync();

            MessageBox.Show("Finish!");
        }

        public async Task DoNavigateAsync()
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            for (iLoop = 0; iLoop < TargetList.Count; iLoop++)
            {
                dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[clmLoad.Name].Value = false;
                txtTBURL.Text = dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[clmURL.Name].Value.ToString();

                webView1.IsJavaScriptEnabled = true;
                webView1.Navigate(txtTBURL.Text);

                while (!TargetList[iLoop].bFinish)
                {
                    await Task.Delay(1000);
                }

                if (webView1.DocumentTitle.IndexOf("Microsoft Support") >= 0 || webView1.DocumentTitle.IndexOf("Microsoft サポート") >= 0)
                    dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[2].Value = "404 Not Found";
                else
                {
                    dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[2].Value = webView1.DocumentTitle;

                    webView1.IsScriptNotifyAllowed = true;
                    string html = webView1.InvokeScript("eval", new string[] { "document.documentElement.innerHTML;" });

                    var parser = new HtmlParser();
                    var doc = parser.ParseDocument(html);
                    var LastUpdate = doc.GetElementsByClassName("article-last-updated");
                    foreach (var element in LastUpdate)
                    {
                        dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[3].Value = element.Attributes["datetime"].Value;
                    }
                    var Product = doc.GetElementsByName("ms.productNames");
                    foreach (var element in Product)
                    {
                        dataGridView1.Rows[TargetList[iLoop].iIndex].Cells[4].Value = element.Attributes["content"].Value;
                    }
                }

                // Stop it?
                if (this.bStopRequested)
                {
                    this.bStopRequested = false;
                    break;
                }
            }
        }

        private void webView1_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            TargetList[iLoop].bFinish = true;
        }

        private void webView1_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            // For debugging
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name +
                " - ID: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            if (e.IsSuccess)
            {
                // 表示に成功した
                // 例えば、e.Uriが、表示したWebページのURI
                // WebView1.DocumentTitleが、Webページのタイトル
            }
            else
            {
                // 表示に失敗した
                // e.WebErrorStatusでエラーが分かる
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bStopRequested = true;
        }
    }

}
