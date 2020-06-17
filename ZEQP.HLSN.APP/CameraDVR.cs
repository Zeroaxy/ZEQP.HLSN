using Camera.Hikvision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera.Hikvision.Properties;

namespace PreviewDemo
{
    public partial class CameraDVR : Form
    {
        public Preview View = new Preview();

        private static Int32 m_lUserID=-1;      //用户登录标志位
        private bool m_bInitSDK = false;                                                     //初始化标志位
        public static Int32[] m_lRealHandle = new Int32[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 ,-1};  //预览标志位
        private string str;                                                                  //输出错误信息
        CHCNetSDK.LOGINRESULTCALLBACK LoginCallBack = null;
        public CHCNetSDK.NET_DVR_USER_LOGIN_INFO struLogInfo;                                //登录参数
        public CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo;                                  //预览参数
        public CHCNetSDK.NET_DVR_CLIENTINFO lpClientInfo;                                  //预览参数
        public CHCNetSDK.NET_DVR_DEVICEINFO_V40 DeviceInfo;                                  //设备参数
        public IntPtr pUser;                                                                 //用户参数

        public delegate void UpdateTextStatusCallback(string strLogStatus, IntPtr lpDeviceInfo);

        public CameraDVR()
        {
            InitializeComponent();

            lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
            lpPreviewInfo.dwStreamType = 1;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
            lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
            lpPreviewInfo.dwDisplayBufNum = 1; //播放库播放缓冲区最大缓冲帧数
            lpPreviewInfo.byProtoType = 0;
            lpPreviewInfo.byPreviewMode = 0;

            pUser = new IntPtr();//用户数据

            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            //else
            //{
            //	//保存SDK日志 To save the SDK log
            //	CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            //}
            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        #region 登录设备
        public void UpdateClientList(string strLogStatus, IntPtr lpDeviceInfo)
        {
            //列表新增报警信息
            labelLogin.Text = "登录状态（异步）：" + strLogStatus;
        }

        public void cbLoginCallBack(int lUserID, int dwResult, IntPtr lpDeviceInfo, IntPtr pUser)
        {
            string strLoginCallBack = "登录设备，lUserID：" + lUserID + "，dwResult：" + dwResult;

            if (dwResult == 0)
            {
                uint iErrCode = CHCNetSDK.NET_DVR_GetLastError();
                strLoginCallBack = strLoginCallBack + "，错误号:" + iErrCode;
            }

            //下面代码注释掉也会崩溃
            if (InvokeRequired)
            {
                object[] paras = new object[2];
                paras[0] = strLoginCallBack;
                paras[1] = lpDeviceInfo;
                labelLogin.BeginInvoke(new UpdateTextStatusCallback(UpdateClientList), paras);
            }
            else
            {
                //创建该控件的主线程直接更新信息列表 
                UpdateClientList(strLoginCallBack, lpDeviceInfo);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DVR_Login();
        }
        
        private void DVR_Login()
        {
            if (textBoxport.Text == "" ||
                textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please input IP, User name and Password!");
                return;
            }
            struLogInfo = new CHCNetSDK.NET_DVR_USER_LOGIN_INFO();


            //设备用户名
            byte[] byUserName = System.Text.Encoding.Default.GetBytes(textBoxUserName.Text);
            struLogInfo.sUserName = new byte[64];
            byUserName.CopyTo(struLogInfo.sUserName, 0);

            //设备密码
            byte[] byPassword = System.Text.Encoding.Default.GetBytes(textBoxPassword.Text);
            struLogInfo.sPassword = new byte[64];
            byPassword.CopyTo(struLogInfo.sPassword, 0);

            struLogInfo.wPort = ushort.Parse(textBoxport.Text);//设备服务端口号

            if (LoginCallBack == null)
            {
                LoginCallBack = new CHCNetSDK.LOGINRESULTCALLBACK(cbLoginCallBack);//注册回调函数                    
            }
            struLogInfo.cbLoginResult = LoginCallBack;
            struLogInfo.bUseAsynLogin = false; //是否异步登录：0- 否，1- 是 

            byte[] byIP = System.Text.Encoding.Default.GetBytes(textBoxIP.Text);

            struLogInfo.sDeviceAddress = new byte[129];
            byIP.CopyTo(struLogInfo.sDeviceAddress, 0);

            DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V40();

            if (m_lUserID < 0)
            {
                m_lUserID = CHCNetSDK.NET_DVR_Login_V40(ref struLogInfo, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    str = "连接失败 ： " + "Login_err_" + CHCNetSDK.NET_DVR_GetLastError(); //登录失败，输出错误号
                    label2.Text = str;
                }
                else
                    label2.Text = "设备连接成功";
            }
        }
        private void DVR_Logout( )
        {
            for (int i = 0; i < 9; i++)
            {
                View.Close();
                if (m_lRealHandle[i] >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[i]);
                    m_lRealHandle[i] = -1;
                }
            }          
            if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
            {
                str = "Logout_Err_" + CHCNetSDK.NET_DVR_GetLastError();
            }
            else
            {
                m_lUserID = -1;
            }

        }
        #endregion

        #region 画面预览

        public static bool btnPreview_press = true;
        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (m_lUserID < 0)
            {
                MessageBox.Show("录像机未连接");
                return;
            }
            else
            {
                View.Show();
                View.Activate();
            }                      

            if (m_lRealHandle[0] < 0 && m_lUserID >= 0)
            {
                lpPreviewInfo.lChannel = 35;//预te览的设备通道
                DVR_Preview(View.pictureBox1, 0);
            }

            return;

        }

        private string DVR_Preview(PictureBox m_pictureBox, int num)
        {
            lpPreviewInfo.hPlayWnd = m_pictureBox.Handle;//预览窗口
            m_lRealHandle[num] = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
            if (m_lRealHandle[num] < 0)
            {
                str = "Play_err_" + CHCNetSDK.NET_DVR_GetLastError(); //预览失败，输出错误号
                return str;
            }
            else
            {
                //预览成功
                return "Preview_OK";
            }
        }


        #endregion

        #region JPEG抓取

        //JPEG抓取
        private bool Capture_JPEG(int lChannel, string sJpegPic) //通道，储存地址  如 F:
        {
            //图片保存路径和文件名 the path and file name to save
            //sJpegPicFileName = "D:\\test.jpg";
            string sJpegPicFileName;
            Random rd = new Random();
            sJpegPicFileName = sJpegPic + "\\" + lChannel + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + rd.Next(10, 100).ToString() + ".jpg";
            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 2- 4CIF，0xff- Auto(使用当前码流分辨率)，抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图 Capture a JPEG picture
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                //str = "NET_DVR_CaptureJPEGPicture failed, error code= " + CHCNetSDK.NET_DVR_GetLastError();
                //MessageBox.Show(str);
                return false;
            }
            else
            {
                //str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                //MessageBox.Show(str);
                return true;
            }

        }


        #endregion


    }
}
