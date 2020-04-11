using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Speech.Recognition;
using Microsoft.Win32;
using Microsoft.Speech.Synthesis;
using System.Reflection;

namespace SpeechRecognition
{
    public partial class Form1 : Form
    {
        static Label l;

        public Form1()
        {
            InitializeComponent();
            
        }
        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Choices active = new Choices();
            
            if (e.Result.Confidence > 0.8)
            {
                
                l.Text = e.Result.Text;
                Process p = new Process();
                switch (e.Result.Text)
                {
                    case "Отключи себя":
                        Application.Exit();
                        break;
                    case "Включи Фотошоп":
                        p.StartInfo.FileName = "Photoshop.exe";
                        p.Start();
                        
                        break;
                    case "Включи Визуал Студио":
                        p.StartInfo.FileName = "devenv.exe";
                        p.Start();
                        break;
                    case "Включи Стим":
                        p.StartInfo.FileName = "D:\\Games\\Steam\\steam.exe";
                        p.Start();
                        break;
                    case "Включи Хром":
                        p.StartInfo.FileName = "chrome.exe";
                        p.Start();
                        break;
                    case "Зайди вконтакте":
                        Process.Start("chrome.exe", "https://www.vk.com");
                        break;
                }
                Process[] pchrome =  Process.GetProcessesByName("chrome");  
                if (pchrome.Length != 0)
                    switch (e.Result.Text)
                    {
                        case "Новый Хром":
                            SendKeys.Send("^n");
                            break;
                        case "Закрыть вкладку":
                            SendKeys.Send("^w");
                            break;
                        case "Инкогнито":
                            SendKeys.Send("^+n");
                            break;
                        case "Закрой Хром":
                            for (int i = 0; i < pchrome.Length; i++)
                                pchrome[i].Kill();  
                            break;
                        case "Новая вкладка":
                            SendKeys.Send("^t");
                            break;
                        case "Фулскрин":
                            SendKeys.Send("{f11}");
                            break;
                    }
                
                    switch (e.Result.Text)
                    {
                        case "скриншот":
                            SendKeys.Send("`");
                            break;
                    }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            l = label1;
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            Choices numbers = new Choices();
            numbers.Add(new string[] { "Включи Визуал Студио", " Включи Стим", "Отключи себя", "Включи Юнити", "Включи Фотошоп", "Зайди вконтакте", "Включи Хром" });

            numbers.Add(new string[] { "Новая вкладка" , "Инкогнито" , "Новый Хром" , "Закрыть вкладку" , "Закрой Хром" , "Фулскрин" , "скриншот" });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(numbers);

            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);
            sre.RecognizeAsync(RecognizeMode.Multiple);

            setAutoRunValue(true, Assembly.GetExecutingAssembly().Location);

            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private bool setAutoRunValue(bool autorun, string path)
        {
            const string AutoFileName = "Speech Recognition";

            string ExePath = path;

            RegistryKey Reg;

            Reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            try
            {
                if (autorun)
                    Reg.SetValue(AutoFileName, ExePath);
                else
                    Reg.DeleteValue(AutoFileName);
            

            Reg.Flush();

            Reg.Close();
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }    
}
