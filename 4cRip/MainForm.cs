using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _4cRip
{
    public partial class MainForm : Form
    {
        private readonly string[] m_boardNames = new string[]
        {
            "b",
        };

        public MainForm()
        {
            InitializeComponent();
            
            txtOutput.Text = Environment.CurrentDirectory;

            foreach (string board in m_boardNames)
            {
                comboBoard.Items.Add(string.Concat('/', board, '/'));
            }

            comboBoard.SelectedIndex = 0;
        }

        private void SetLabel(string fmt, params object[] args)
        {
            statusLabel.Text = string.Format(fmt, args);
        }
        private void SetControls(bool enabled)
        {
            comboBoard.Enabled = enabled;
            btnBrowse.Enabled = enabled;
            btnDownload.Enabled = enabled;
            numThread.Enabled = enabled;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dialogOutput.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dialogOutput.SelectedPath;
            }
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtOutput.Text) == false)
            {
                SetLabel("Output path does not exist");
                return;
            }

            WebClient wc = new WebClient();

            SetControls(false);

            string board = m_boardNames[comboBoard.SelectedIndex];
            string threadUrl = string.Format("https://api.4chan.org/{0}/res/{1}.json", board, (long)numThread.Value);

            try
            {
                SetLabel("Downloading thread");
                string json = await wc.DownloadStringTaskAsync(threadUrl);

                SetLabel("Deserializing thread");
                RootObject root = await JsonConvert.DeserializeObjectAsync<RootObject>(json);

                int imageCount = 1;

                foreach (Post post in root.posts)
                {
                    if (post.tim == null || post.ext == null)
                        continue;

                    string fileName = string.Concat(post.tim, post.ext);
                    string imageUrl = string.Format("https://images.4chan.org/{0}/src/{1}", board, fileName);
                    string filePath = Path.Combine(txtOutput.Text, fileName);

                    SetLabel("Downloading image #{0}", imageCount++);
                    await wc.DownloadFileTaskAsync(imageUrl, filePath);
                }

                MessageBox.Show("Finished", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                wc.Dispose();
                SetControls(true);
                SetLabel("Idle");
            }
        }
    }
}
