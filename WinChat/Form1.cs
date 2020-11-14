using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinChat
{
    public partial class Chat : Form
    {
        public bool isReset;
        public int resetLeft = 15;
        static string chatPath = @"c:\Chat\Chat.txt";
        static string onlinePath = @"c:\Chat\Online.txt";
        string activeCommand = null;
        bool commandActive = false;
        public string name = "";
        public Chat()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string send = InputBox.Text;
            InputBox.ResetText();
            if (!File.Exists(chatPath))
            {
                using (StreamWriter sw = File.CreateText(chatPath))
                {
                    sw.WriteLine(name + ": " + send);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(chatPath))
                {
                    sw.WriteLine(name + ": " + send);
                    sw.Close();
                }
            }
            if (send == "!resetChat") // this is kinda broken, chaning the channel changes currect target
            {
                if (commandActive)
                {
                    using (StreamWriter sw = File.AppendText(chatPath))
                    {
                        sw.WriteLine("System: Command Already Active");
                        sw.Close();
                    }
                    return;
                }
                commandActive = true;
                activeCommand = chatPath;
                ResetTimer.Enabled = true;
                isReset = true;
            }
        }

        private void RecieveTick_Tick(object sender, EventArgs e)
        {
            chatPath = @"c:\Chat\" + ChatChoice.SelectedTab.Text + ".txt";
            if (!File.Exists(chatPath))
            {
                using (StreamWriter sw = File.CreateText(chatPath))
                {
                    sw.Close();
                }
            }
            using (StreamReader sr = File.OpenText(chatPath))
            {
                string s = "";
                if ((s = sr.ReadToEnd()) != null)
                {
                    ChatBox.Text = s;
                }
                sr.Close();
            }
            if (File.Exists(onlinePath))
            {
                using (StreamReader sr = File.OpenText(onlinePath))
                {
                    string s = "";
                    if ((s = sr.ReadToEnd()) != null)
                    {
                        textBox1.Text = "Online:" + Environment.NewLine + s;
                    }
                    sr.Close();
                }
            }
            else
            {
                textBox1.Text = "Error: No users online or File Not Found Exception.";
            }
        }

        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            if (isReset)
            {
                if(resetLeft <= 0)
                {
                    using (StreamWriter sw = File.CreateText(activeCommand))
                    {
                        sw.Close();
                        isReset = false;
                        commandActive = false;
                        activeCommand = null;
                        resetLeft = 15;
                    }
                }
                else
                {
                    string toSend;
                    if(resetLeft == 15 || resetLeft == 10 || resetLeft == 5 || resetLeft == 3 || resetLeft == 2 || resetLeft == 1)
                    {
                        toSend = resetLeft + "s To Reset";
                        using (StreamWriter sw = File.AppendText(activeCommand))
                        {
                            sw.WriteLine("Server: " + toSend);
                            sw.Close();
                        }
                    }
                    resetLeft--;
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (File.Exists(onlinePath)) {
                using (StreamReader sr = File.OpenText(onlinePath))
                { 
                    if (sr.ReadToEnd().Contains(name))
                    {
                        sr.Close();
                        var tempFile = Path.GetTempFileName();
                        var linesToKeep = File.ReadLines(onlinePath).Where(l => l != name);

                        File.WriteAllLines(tempFile, linesToKeep);

                        File.Delete(onlinePath);
                        File.Move(tempFile, onlinePath);
                    }
                }
            }
            Application.Exit();
        }
    }
}
