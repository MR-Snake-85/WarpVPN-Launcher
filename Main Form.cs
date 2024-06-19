using Microsoft.Win32;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Warp
{
    public partial class Main_Form : Form
    {
        Proxy PRoxy;
        Process process;
        string PAddress = "127.0.0.1:8086";
        byte useCfon = 0;
        string WarpCommand = "";
        int pid = 0;
        string WarpPath = "";


        public void Reset_Stats()
        {
            PRoxy = new Proxy();
            label5.Text = PRoxy.GetStats_Address();
            label4.Text = PRoxy.GetStats();
        }
        public Main_Form()
        {
            InitializeComponent();
            ListLocations.Enabled = false;
            Reset_Stats();
            WarpPath = $@"{Directory.GetCurrentDirectory()}\WarpApp\warp.exe";

        }
        private void SPButton_Click(object sender, EventArgs e)
        {
            PRoxy = new Proxy();
            PRoxy.SetProxy(PAddress);
            Reset_Stats();
        }

        private void RStats_button_Click(object sender, EventArgs e)
        {
            Reset_Stats();

        }

        private void UProxy_button_Click(object sender, EventArgs e)
        {
            PRoxy = new Proxy();
            PRoxy.UnSetProxy();
            Reset_Stats();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = ListLocations.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (useCfon)
                {
                    case 0:
                        WarpCommand = $"/k {WarpPath} echo";
                        PAddress = "127.0.0.1:8086";
                        break;

                    case 1:
                        CheckList checkList = new CheckList();
                        WarpCommand = $"/k {WarpPath} -cfon -country {checkList.Check(ListLocations.SelectedItem.ToString())} echo";
                        PAddress = "socks=127.0.0.1:8086";
                        break;

                    default:
                        WarpCommand = $"/k {WarpPath} echo";
                        PAddress = "127.0.0.1:8086";
                        break;
                }

                Proxy proxy = new Proxy();
                proxy.SetProxy(PAddress);
                Reset_Stats();


                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,                    
                    Arguments = WarpCommand,

                };

                process = new Process() { StartInfo = startInfo };
                process.OutputDataReceived += Process_OutputDataReceived;
                process.Start();
                pid = process.Id;
                process.BeginOutputReadLine();

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Please Choose The Location", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            
            if (e.Data != null)
            {
                LogBox.AppendText(e.Data + Environment.NewLine);
            }
        }

        private void CheckBoxLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxLocation.CheckState == CheckState.Unchecked)
            {
                ListLocations.Enabled = false;
                useCfon = 0;
                label7.Text = string.Empty;

            }
            else
            {
                ListLocations.Enabled = true;
                useCfon = 1;

            }
        }

        private void StopWarp_button_Click(object sender, EventArgs e)
        {
            
            //try
            {

                useCfon = 0;
                ListLocations.Enabled = false;
                CheckBoxLocation.Checked = false;
                label7.Text = string.Empty;
                LogBox.AppendText(Environment.NewLine + "Closing The Warp .....");
                StopWarp();
                Thread.Sleep(3000);
                LogBox.Text = string.Empty;
                Proxy p = new Proxy();
                p.UnSetProxy();
                Reset_Stats();



                
            }
            //catch (NullReferenceException)
            //{
            //    MessageBox.Show("Warp Not runnig", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

            StopWarp();
            Proxy p = new Proxy();
            p.UnSetProxy();
            Reset_Stats();

            this.Dispose();

        }


        private void StopWarp() 
        {
            // Find the process by name
            Process[] warpProcesses = Process.GetProcessesByName("warp");

            if (warpProcesses.Length > 0)
            {
                // Close the process nicely, if possible
                warpProcesses[0].CloseMainWindow();

                // Wait for a short period to allow the process to exit
                System.Threading.Thread.Sleep(100);

                // If the process is still running, kill it forcefully
                if (!warpProcesses[0].HasExited)
                {
                    warpProcesses[0].Kill();
                }
                LogBox.Text = "";
            }
            Process cmdProcesses = Process.GetProcessesByName("cmd").Where(c => c.Id == pid).SingleOrDefault();
            if (cmdProcesses!= null)
            {
                // Close the process nicely, if possible
                cmdProcesses.CloseMainWindow();

                // Wait for a short period to allow the process to exit
                System.Threading.Thread.Sleep(100);

                // If the process is still running, kill it forcefully
                if (!cmdProcesses.HasExited)
                {
                    cmdProcesses.Kill();
                }
                LogBox.Text = "";

            }

            LogBox.Text = "";


        }






    }
}
