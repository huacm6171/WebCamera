using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AXVLC;
using System.Threading;
using System.IO;

namespace WebCamera
{
   
    public partial class Form1 : Form
    {
        //文件遍历线程
        public delegate void MyInvoke();

        private void updateFiles(){

                DirectoryInfo di = new DirectoryInfo(@"D:\vedio");
                foreach (FileInfo dChild in di.GetFiles("*.flv"))
                {
                    if( !vedioList.Items.Contains(dChild.Name))
                        vedioList.Items.Add(dChild.Name);
                }
        }

        private void doWork()
        {
            if (!this.IsHandleCreated) return;
            this.BeginInvoke(new MyInvoke(updateFiles));
        }
        public void threadmethod()
        {
            while(true)
            {
                doWork();
                Thread.Sleep(10000);
            }
        }
        public Form1()
        {
            InitializeComponent();

        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(threadmethod));
            thread.Start();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
          
           
            IPictureDisp Ipd = axVLC.video.takeSnapshot();
            
            MessageBox.Show("test", "test");
        }

        private void vedioList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string strFileName = vedioList.SelectedItem.ToString();
            string strFilePath = @"file:///D:\vedio\" + strFileName;
            //axVLC.playlist.clear();
            int iCurrentItem = axVLC.playlist.add(strFilePath);
            axVLC.playlist.playItem(iCurrentItem);
//             string strFile = @"file:///D:\vedio\20160729083009.flv";
//             axVLC.playlist.add(strFile);
//             axVLC.playlist.play();
        }

    }
}
