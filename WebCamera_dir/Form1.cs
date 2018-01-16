using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebCamera_dir
{
    public partial class WebCamera : Form
    {
        public WebCamera()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            axVLC.playlist.add("rtmp://live.qab.co.jp:1935/live/livenahacity.sdp");
            axVLC.playlist.play();
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            axVLC.video.takeSnapshot();
        }
    }
}
