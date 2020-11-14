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
    public partial class SignIn : Form
    {
        static string Usernames = @"c:\Chat\Login.txt";
        static string Pass = @"c:\Chat\Pass.txt";
        static string onlinePath = @"c:\Chat\Online.txt";
        public SignIn()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (EnterUser.Text != null && EnterPass.Text != null)
            {
                if (File.Exists(Usernames) && File.Exists(Pass))
                {
                    using (StreamWriter sw = File.AppendText(Usernames))
                    {
                        sw.WriteLine(EnterUser.Text);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(Usernames))
                    {
                        sw.WriteLine(EnterUser.Text);
                        sw.Close();
                    }
                    using (StreamWriter sw = File.CreateText(Pass))
                    {
                        sw.WriteLine(EnterUser.Text + "/" + EnterPass.Text);
                        sw.Close();
                    }
                }
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Password.Text != "")
            {
                string user = "";
                if (File.Exists(Usernames))
                {
                    using (StreamReader sr = File.OpenText(Usernames))
                    {
                        sr.BaseStream.Position = 0;
                        if ((user = sr.ReadToEnd()) != null)
                        {
                        }
                        sr.Close();
                    }
                }
                else
                {
                    return;
                }
                if (user.Contains(Username.Text + Environment.NewLine))
                {
                    string pass = "";
                    if (File.Exists(Pass))
                    {
                        using (StreamReader sr = File.OpenText(Pass))
                        {
                            sr.BaseStream.Position = 0;
                            if ((pass = sr.ReadToEnd()) != null)
                            {
                            }
                            sr.Close();
                        }
                        if (pass.Contains(Username.Text + "/" + Password.Text + Environment.NewLine))
                        {


                            using (StreamReader sr = File.OpenText(Pass))
                            {
                                sr.BaseStream.Position = 0;
                                if ((user = sr.ReadToEnd()) != null)
                                {

                                }
                                sr.Close();
                            }
                            if (File.Exists(onlinePath))
                            {
                                using (StreamWriter sw = File.AppendText(onlinePath))
                                {
                                    sw.WriteLine(Username.Text);
                                    sw.Close();
                                }
                            }
                            else
                            {
                                using (StreamWriter sw = File.CreateText(onlinePath))
                                {
                                    sw.WriteLine(Username.Text);
                                    sw.Close();
                                }
                            }
                            Chat chat = new Chat
                            {
                                name = Username.Text
                            };
                            chat.Show();
                            Hide();
                        }
                    }
                }
            }
        }
    }
}
