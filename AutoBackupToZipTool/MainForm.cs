using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderTo7z
{
    public partial class MainForm : Form
    {
        private Thread CreateZipThread;
        protected NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public MainForm()
        {
            InitializeComponent();
            SignatureLabel.Text = SignatureLabel.Text + " " + DateTime.Now.Year;
        }

        /// <summary>
        /// Function to open Folder browser dialog
        /// </summary>
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    ItemListBox.Items.Add(FolderBrowserDialog1.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "BrowseButton_Click");
            }
        }

        /// <summary>
        /// Function to remove selected items from the List View
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ItemListBox.Items.Remove(ItemListBox.SelectedItem);
            }
            catch (Exception ex)
            {
                log.Error(ex, "RemoveButton_Click");
            }
        }

        /// <summary>
        /// Function to read paths from Config file
        /// </summary>
        private void SelectFromCfgButton_Click(object sender, EventArgs e)
        {
            try
            {
                string line = string.Empty;
                int counter = 0;
                StreamReader file = new StreamReader(@"Preset.txt");
                while ((line = file.ReadLine()) != null)
                {
                    ItemListBox.Items.Add(line);
                    counter++;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "SelectFromCfgButton_Click");
            }
        }

        /// <summary>
        /// Function to convert folders in Listbox to 7z
        /// </summary>
        private void BackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                log.Trace(">> Backup");
                if(CreateZipThread != null && CreateZipThread.IsAlive)
                {
                    StatusMessageLabel.Text = "Another process is ongoing, please wait.";
                }
                else
                {
                    StatusMessageLabel.Text = "Processing, please wait..";
                    DisableButtons();
                    CreateZipThread = new Thread(new ThreadStart(CreateZipFIles));
                    CreateZipThread.Start();
                }
                log.Trace("<< Backup");
            }
            catch (Exception ex)
            {
                log.Error(ex, "BackupButton_Click");
            }
        }

        /// <summary>
        /// Function called by Thread to run CMD and create zip files
        /// </summary>
        private void CreateZipFIles()
        {
            string argumentString = "";
            foreach (string path in ItemListBox.Items)
            {
                string foldername = path.Replace(Path.GetDirectoryName(path), "");
                if (ItemListBox.Items.IndexOf(path) == 0)
                    argumentString += $"/C 7za a -t7z \"{Path.GetDirectoryName(path)}{foldername}  {DateTime.Now.ToString("dd-MM-yyy Thh-mm-ss")}\" \"{path}\" -mx=9";
                else
                    argumentString += $"&7za a -t7z \"{Path.GetDirectoryName(path)}{foldername}  {DateTime.Now.ToString("dd-MM-yyy Thh-mm-ss")}\" \"{path}\" -mx=9";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = argumentString;

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }
            SetStatusMessageText("Finished compressing to 7z.");
            ReEnableButtons();
        }

        private void DisableButtons()
        {
            BackupButton.Enabled = false;
            BrowseButton.Enabled = false;
            RemoveButton.Enabled = false;
            SelectFromCfgButton.Enabled = false;
        }


        #region Set Status Message Text
        delegate void ReEnableButtonsCallBack();

        private void ReEnableButtons()
        {
            if (this.StatusMessageLabel.InvokeRequired)
            {
                ReEnableButtonsCallBack d = new ReEnableButtonsCallBack(ReEnableButtons);
                this.Invoke(d, new object[] {  });
            }
            else
            {
                BackupButton.Enabled = true;
                BrowseButton.Enabled = true;
                RemoveButton.Enabled = true;
                SelectFromCfgButton.Enabled = true;
            }
        }
        #endregion

        #region Set Status Message Text
        delegate void SetStatusMessageTextCallBack(string text);

        private void SetStatusMessageText(string text)
        {
            if (this.StatusMessageLabel.InvokeRequired)
            {
                SetStatusMessageTextCallBack d = new SetStatusMessageTextCallBack(SetStatusMessageText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.StatusMessageLabel.Text = text;
            }
        }
        #endregion

    }
}
