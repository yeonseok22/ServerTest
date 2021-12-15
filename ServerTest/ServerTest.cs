using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTest
{
    public partial class serverTest : Form
    {
        public serverTest()
        {
            InitializeComponent();
        }

        #region AddText(string str, int i);

        delegate void cdAddText(string str, int i);     // C/C++의 포인터 역할
        /// <summary>
        /// i == 1 : 라즈베리파이 서버 로그용 //
        /// i == 2 : 안드로이드 서버 로그용
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i"></param>
        void AddText(string str, int i)
        {
            string logs = str + "\r\n";


            if(tbPiServer.InvokeRequired || tbAndServer.InvokeRequired)
            {
                cdAddText cb = new cdAddText(AddText);
                object[] obj = { str, i };
                Invoke(cb, obj);
            }
            else
            {
                switch (i)
                {
                    case 1:
                        tbPiServer.Text += logs;
                        break;

                    case 2:
                        tbAndServer.Text += logs;
                        break;
                }
            }
        }
        #endregion

        #region 소켓 프로그래밍 변수들

        Socket PiSock = null;
        Socket AndSock = null;
        Thread PiThreadRead = null;
        Thread PiThreadDebug = null;
        Thread AndThreadRead = null;
        Thread AndThreadDebug = null;

        #endregion



        #region 안드로이드 통신 Part (for Debugging)


        #region 안드로이드 통신 버튼 함수

        /// <summary>
        /// 안드로이드 연결 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnd_Conn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AndSock != null)
                {
                    if (MessageBox.Show("안드로이드 연결을 다시 수립하시겠습니까?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AndSock.Close();
                        if(AndThreadRead != null) AndThreadRead.Abort();
                    }
                }
                AndSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                AndSock.Connect(tbAnd_IP.Text, int.Parse(tbAnd_Port.Text));
                AddText($"Android Server [{tbAnd_IP.Text}:{tbAnd_Port.Text}] Connected OK.", 2);
                AndThreadRead = new Thread(AndroidReadProcess);
                AndThreadRead.Start();

                // 접속되었다고 확인 메시지 보내기
                //byte[] bArr = Encoding.UTF8.GetBytes("안드로이드 연결 완료!\r\n");
                //AndSock.Send(bArr);

                //byte[] cArr = Encoding.Convert(Encoding.Default, Encoding.UTF8, bArr);      // ANSI -> UTF8
                //PiSock.Send(cArr);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "\n문제 : 안드로이드 연결");
            }
        }

        #region 안드로이드 스레드 함수

        void AndroidReadProcess()
        {
            byte[] bArr = new byte[512];
            while (true)
            {
                if (AndSock.Available > 0)
                {
                    int n = AndSock.Receive(bArr);
                    AddText(Encoding.UTF8.GetString(bArr, 0, n), 2);
                    //byte[] cArr = Encoding.Convert(Encoding.UTF8, Encoding.Default, bArr);      // UTF8 -> ANSI
                    //AddText(Encoding.Default.GetString(cArr, 0, n), 2);
                }
                Thread.Sleep(100);
            }
        }
        #endregion

        /// <summary>
        /// 안드로이드 연결 끊기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnd_DisConn_Click(object sender, EventArgs e)
        {
            string str = "안드로이드 연결이 종료되었습니다.";
            //byte[] bArr = Encoding.Default.GetBytes(str + "\r\n");
            byte[] bArr = Encoding.UTF8.GetBytes(str + "\r\n");
            if (AndSock != null)
            {
                if (MessageBox.Show("안드로이드 연결을 끊으시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AndSock.Send(bArr);
                    AndSock.Close();
                    AndThreadRead.Abort();
                }
                AddText(str, 2);
            }

        }
        /// <summary>
        /// 안드로이드 디버깅 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnd_Debug_Click(object sender, EventArgs e)
        {
            if (AndThreadDebug != null) AndThreadDebug.Abort();
            AndThreadDebug = new Thread(AndDebug);
            AndThreadDebug.Start();
        }

        void AndDebug()
        {
            Thread.Sleep(1000);
            try
            {
                while (true)
                {
                    if (AndSock != null)
                    {
                        string str = "30,40,1";
                        byte[] bArr = Encoding.UTF8.GetBytes(str + "\r\n");
                        AddText(str, 2);
                        AndSock.Send(bArr);
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }
        }

        /// <summary>
        /// 안드로이드 메시지 보내기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnd_Send_Click(object sender, EventArgs e)
        {
            if (AndSock != null)
            {
                string str = tbAnd_Msg.Text;
                byte[] bArr = Encoding.Default.GetBytes(str + "\r\n");
                //AndSock.Send(bArr);
                AddText(str, 2);
                byte[] cArr = Encoding.Convert(Encoding.Default, Encoding.UTF8, bArr);      // ANSI -> UTF8
                AndSock.Send(cArr);
            }
        }

        #endregion

        #endregion

        #region 라즈베리파이 통신 Part (For Debugging)

        #region 라즈베리파이 스레드 함수

        #endregion

        #region 라즈베리파이 통신 버튼 함수

        /// <summary>
        /// 라즈베리파이 연결 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPi_Conn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PiSock != null)
                {
                    if (MessageBox.Show("라즈베리파이 연결을 다시 수립하시겠습니까?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PiSock.Close();
                        if(PiThreadRead != null) PiThreadRead.Abort();
                    }   
                }
                PiSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                PiSock.Connect(tbPi_IP.Text, int.Parse(tbPi_Port.Text));
                AddText($"Pi Server [{tbPi_IP.Text}:{tbPi_Port.Text}] Connected OK.", 1);
                PiThreadRead = new Thread(PiReadProcess);
                PiThreadRead.Start();

                // 접속되었다고 확인 메시지 보내기
                //byte[] bArr = Encoding.UTF8.GetBytes("라즈베리파이 연결 완료!\r\n");
                //PiSock.Send(bArr);
                //byte[] cArr = Encoding.Convert(Encoding.Default, Encoding.UTF8, bArr);      // ANSI -> UTF8
                //PiSock.Send(cArr);


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "\n문제 : 라즈베리파이 연결");
            }
        }

        #region 라즈베리파이 스레드 함수
        void PiReadProcess()
        {
            byte[] bArr = new byte[512];
            while (true)
            {
                if (PiSock.Available > 0)
                {
                    int n = PiSock.Receive(bArr);
                    AddText(Encoding.UTF8.GetString(bArr, 0, n), 1);
                    //AddText(Encoding.Default.GetString(bArr, 0, n), 1);
                }
                Thread.Sleep(100);
            }
        }
        #endregion

        /// <summary>
        /// 라즈베리파이 연결 끊기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPi_DisConn_Click(object sender, EventArgs e)
        {
            string str = "라즈베리파이 연결이 종료되었습니다.";
            //byte[] bArr = Encoding.Default.GetBytes(str + "\r\n");
            byte[] bArr = Encoding.UTF8.GetBytes(str + "\r\n");
            if (PiSock != null)
            {
                if (MessageBox.Show("라즈베리파이 연결을 끊으시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PiSock.Send(bArr);
                    PiSock.Close();
                    PiThreadRead.Abort();
                }
                AddText(str, 1);
            }
        }
        /// <summary>
        /// 라즈베리파이 메시지 보내기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPi_Send_Click(object sender, EventArgs e)
        {
            if (PiSock != null)
            {
                string str = tbPi_Msg.Text;
                byte[] bArr = Encoding.Default.GetBytes(str + "\r\n");
                //AndSock.Send(bArr);
                AddText(str, 1);
                byte[] cArr = Encoding.Convert(Encoding.Default, Encoding.UTF8, bArr);      // ANSI -> UTF8
                PiSock.Send(cArr);
            }
        }


    /// <summary>
    /// 라즈베리파이 디버깅 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void btnPi_Debug_Click(object sender, EventArgs e)
        {
            if (PiThreadDebug != null) PiThreadDebug.Abort();
            PiThreadDebug = new Thread(PiDebug);
            PiThreadDebug.Start();
        }

        void PiDebug()
        {
            Thread.Sleep(1000);
            try
            {
                while (true)
                {
                    if (PiSock != null)
                    {
                        string str = "34,25,1,1,25,50,1,1,1";
                        byte[] bArr = Encoding.UTF8.GetBytes(str + "\r\n");
                        AddText(str, 1);
                        PiSock.Send(bArr);
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }
        }

        #endregion

        #endregion

        #region 프로그램 종료
        private void serverTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PiThreadRead != null) PiThreadRead.Abort();
            if (PiThreadDebug != null) PiThreadDebug.Abort();
            if (AndThreadRead != null) AndThreadRead.Abort();
            if (AndThreadDebug != null) AndThreadDebug.Abort();
        }
        #endregion
    }
}
