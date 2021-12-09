using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numpy;
using Keras;
using Keras.Models;
using Keras.Layers;
using System.IO;
using Keras.Datasets;
using Keras.Optimizers;
using Keras.Utils;
using System.Diagnostics;

namespace test_keras_net
{
    public partial class Form1 : Form
    {
        string app_startup_path = "";
        string models_path = "";
        string model_file = "";
        Stopwatch sw = new Stopwatch();
        NDarray x_slr = null;
        NDarray x_mlr = null;
        NDarray x_bc = null;
        NDarray x_fashion = null;
        string[] class_names = null;
        Keras.Models.BaseModel slr_model = null;
        Keras.Models.BaseModel mlr_model = null;
        Keras.Models.BaseModel bc_model = null;
        Keras.Models.BaseModel fashion_model = null;
        byte[] byteImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            app_startup_path = Application.StartupPath;
            int pos = app_startup_path.IndexOf("test_keras_net\\bin");
            models_path = app_startup_path.Substring(0, pos) + "models";
            lblXData.Text = "8316, 7885, 8287, 7878, 128, 48, 12, 4, 114, 0.234, 0.363, 46, 52.237, 21, 5.247, 17, 80, 0";

            class_names = new string[] { "T-shirt/top", "Trouser", "Pullover", "Dress", "Coat",
                           "Sandal", "Shirt", "Sneaker", "Bag", "Ankle boot" };
        }

        private void btnLoadModelSLR_Click(object sender, EventArgs e)
        {
            model_file = Path.Combine(models_path, "slr_model.h5");
            sw.Reset();
            sw.Start(); // 시간 측정 시작
            slr_model = Sequential.LoadModel(model_file);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            string strResult = string.Format("LoadModel : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void btnPredictSLR_Click(object sender, EventArgs e)
        {
            if (slr_model == null)
                return;

            float x = 0;
            if (!float.TryParse(txtInputSLR.Text, out x))
            {
                MessageBox.Show("Wrong float number! Input Again !");
                return;
            }

            sw.Reset();
            sw.Start(); // 시간 측정 시작
            x_slr = np.array(new float[] { x });
            var pred = slr_model.Predict(x_slr);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            float[] res = pred.GetData<float>();
            string strResult = string.Format("Result : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void btnLoadModelMLR_Click(object sender, EventArgs e)
        {
            model_file = Path.Combine(models_path, "mlr_model.h5");
            sw.Reset();
            sw.Start(); // 시간 측정 시작
            mlr_model = Sequential.LoadModel(model_file);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            string strResult = string.Format("LoadModel : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void btnPredictMLR_Click(object sender, EventArgs e)
        {
            if (mlr_model == null)
                return;

            float x1 = 0;
            float x2 = 0;
            float x3 = 0;
            if (!float.TryParse(txtInputMLR1.Text, out x1))
            {
                MessageBox.Show("Wrong float number! Input Again !");
                return;
            }
            if (!float.TryParse(txtInputMLR2.Text, out x2))
            {
                MessageBox.Show("Wrong float number! Input Again !");
                return;
            }
            if (!float.TryParse(txtInputMLR3.Text, out x3))
            {
                MessageBox.Show("Wrong float number! Input Again !");
                return;
            }

            sw.Reset();
            sw.Start(); // 시간 측정 시작
            x_mlr = np.array(new float[,] { { x1, x2, x3 } });
            var pred = mlr_model.Predict(x_mlr);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            float[] res = pred.GetData<float>();
            string strResult = string.Format("Result : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void btnLoadModelBC_Click(object sender, EventArgs e)
        {
            model_file = Path.Combine(models_path, "bc_model.h5");
            sw.Reset();
            sw.Start(); // 시간 측정 시작
            bc_model = Sequential.LoadModel(model_file);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            string strResult = string.Format("LoadModel : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void radX0_CheckedChanged(object sender, EventArgs e)
        {
            lblXData.Text = "2001, 3079, 1994, 3075, 148, 17, 12, 4, 45, 0.687, 0.363, 225, 56.614, 94, 58.629, 46, 153, 0";
        }

        private void radX4_CheckedChanged(object sender, EventArgs e)
        {
            lblXData.Text = "8690, 7883, 8673, 7873, 272, 37, 17, 3, 93, 0.444, 0.375, 86, 64.661, 20, 11.059, 17, 80, 0";
        }
        private void radX6_CheckedChanged(object sender, EventArgs e)
        {
            lblXData.Text = "8316, 7885, 8287, 7878, 128, 48, 12, 4, 114, 0.234, 0.363, 46, 52.237, 21, 5.247, 17, 80, 0";
        }

        private void btnPredictBC_Click(object sender, EventArgs e)
        {
            if (bc_model == null)
                return;

            sw.Reset();
            sw.Start(); // 시간 측정 시작
            if (radX0.Checked)
                x_bc = np.array(new float[,] { { 2001, 3079, 1994, 3075, 148, 17, 12, 4, 45, 0.687f, 0.363f, 225, 56.614f, 94, 58.629f, 46, 153, 0 } });
            else if (radX4.Checked)
                x_bc = np.array(new float[,] { { 8690, 7883, 8673, 7873, 272, 37, 17, 3, 93, 0.444f, 0.375f, 86, 64.661f, 20, 11.059f, 17, 80, 0 } });
            else if (radX6.Checked)
                x_bc = np.array(new float[,] { { 8316, 7885, 8287, 7878, 128, 48, 12, 4, 114, 0.234f, 0.363f, 46, 52.237f, 21, 5.247f, 17, 80, 0 } });

            var pred = bc_model.Predict(x_bc);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            float[] res = pred.GetData<float>();
            string strResult = string.Format("Result : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images (*.BMP)|*.BMP|" + "All files (*.*)|*.*";
            openFileDialog1.Title = "Select Fashion Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap myBitmap = new Bitmap(openFileDialog1.FileName);
                picImage.Image = myBitmap;

                // Image to Byte Array
                Rectangle rect = new Rectangle(0, 0, myBitmap.Width, myBitmap.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    myBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    myBitmap.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * myBitmap.Height;
                byteImage = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, byteImage, 0, bytes);

                // Unlock the bits.
                myBitmap.UnlockBits(bmpData);
            }
        }

        private void btnLoadModelFashion_Click(object sender, EventArgs e)
        {
            model_file = Path.Combine(models_path, "fashion_model.h5");
            sw.Reset();
            sw.Start(); // 시간 측정 시작
            fashion_model = Sequential.LoadModel(model_file);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            string strResult = string.Format("LoadModel : {0} (Elapsed Time : {1:0.000} [msec])", model_file, sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }

        private void btnPredictFashion_Click(object sender, EventArgs e)
        {
            if (fashion_model == null || picImage.Image == null)
                return;

            int n = byteImage.Length;
            double[] doubleArr = new double[n];
            for (int i = 0; i < n; i++)
            {
                doubleArr[i] = byteImage[i] / (double)255;
            }

            sw.Reset();
            sw.Start(); // 시간 측정 시작
            x_fashion = np.array(doubleArr);
            //fashion = x_fashion / 255;
            x_fashion = x_fashion.reshape(1, 28, 28);
            var pred = fashion_model.Predict(x_fashion);
            if (sw.IsRunning) sw.Stop(); // 시간 측정 끝
            var vmax = pred.argmax();
            string str_max = vmax.str;
            int imax = int.Parse(str_max);
            string strResult = string.Format("Result : {0} (Elapsed Time : {1:0.000} [msec])", class_names[imax], sw.ElapsedTicks / Stopwatch.Frequency * 1E3);
            lblResult.Text = strResult;
        }
    }
}
