using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace _3_PL.Views
{
    public partial class FrmBarCode : Form
    {
        public FrmBarCode()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public string txtBar_Code ;
        private void FrmBarCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbo_camera.Items.Add(device.Name);
                cbo_camera.SelectedIndex = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbo_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txt_barcode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_barcode.Text = result.ToString();
                }));
                pictureBox.Image = bitmap;
            }
        }

        private void FrmBarCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtBar_Code = txt_barcode.Text;
            //this.Close();
        }
    }
}
