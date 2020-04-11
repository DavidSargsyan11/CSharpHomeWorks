using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Mp3Player : IDisposable
    {
        public bool isPause = false;
        public bool isPlay = false;

        public bool Repeat { get; set; }
        public bool isPaused
        {
            get { return isPause; }
            set { isPause = value; }
        }
        public bool isPlaying
        {
            get { return isPlay; }
            set { isPlay = value; }
        }



        public Mp3Player(string fileName)
        {
            const string FORMAT = @"open ""{0}"" type mpegvideo alias MediaFile";
            string command = String.Format(FORMAT, fileName);
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            string _command = " ";
            if (isPlay == false && isPause == false)
            {
                _command = "play MediaFile";
                isPlay = true;
                isPause = false;
            }
            
            if (isPlay == true && isPause == false)
            {
                _command = "pause MediaFile";
                isPlay = false;
                isPause = true;
            }

            if(isPlay == false && isPause == true)
            {
                _command = "resume MediaFile";
                isPlay = true;
                isPause = false;
            }
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand,
            StringBuilder strReturn, int iReturtLength, IntPtr hwndCallBack);

        public void Dispose()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void SetVolume(int volume)
        {
            var command = "setaudio MediaFile volume to " + volume.ToString();
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
