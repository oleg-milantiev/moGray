using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;


namespace moGray
{
    public partial class Form1 : Form
    {

        private VideoCapture cvWebCam;
        private bool _captureInProgress;

        public Form1()
        {
            InitializeComponent();

            try
            {
                cvWebCam = new VideoCapture();
                cvWebCam.ImageGrabbed += CvWebCam_ImageGrabbed;

                timer1.Start();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }

        private void CvWebCam_ImageGrabbed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void printFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG файлы (*.jpg)|*.jpg";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                printFileText.Text = saveFileDialog1.FileName;

                printCreate.Enabled = true;
            }
        }

        private void printCreate_Click(object sender, EventArgs e)
        {
            if (printScaleSize.Value > (printImageSize.Value / 2))
            {
                MessageBox.Show("Размер шкалы энкодера не может быть больше половины размера изображения", "Ошибка размера шкалы энкодера", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var bmp = new Bitmap((int) printImageSize.Value, (int) printImageSize.Value);
            var g = Graphics.FromImage(bmp);

            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.FillRectangle(whiteBrush, new Rectangle(0, 0, (int)printImageSize.Value, (int)printImageSize.Value));
//            Pen whitePen = new Pen(whiteBrush);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(blackBrush);

            Point center = new Point((int) printImageSize.Value / 2, (int) printImageSize.Value / 2);
            int segmentCount = (int) Math.Pow(2, (double) printEncoderBit.Value);
            float segmentAngleDegree = 360f / segmentCount;
            double segmentAngleRadian = 2 * Math.PI / segmentCount;

            float bitRadius = (float)printScaleSize.Value / (float)(printEncoderBit.Value + 2);

            g.FillEllipse(blackBrush, 0, 0, (float)printImageSize.Value, (float)printImageSize.Value);
            g.FillEllipse(whiteBrush, bitRadius, bitRadius, (float)printImageSize.Value - bitRadius * 2, (float)printImageSize.Value - bitRadius * 2);
            g.FillEllipse(blackBrush, (float)printScaleSize.Value - bitRadius, (float)printScaleSize.Value - bitRadius, (float)printImageSize.Value - (float)printScaleSize.Value * 2 + bitRadius*2, (float)printImageSize.Value - (float)printScaleSize.Value * 2 + bitRadius * 2);
            g.FillEllipse(whiteBrush, (float)printScaleSize.Value, (float)printScaleSize.Value, (float)printImageSize.Value - (float)printScaleSize.Value * 2, (float)printImageSize.Value - (float)printScaleSize.Value * 2);

            for (int segment = 0; segment < segmentCount; segment++)
            {
                string gray = Convert.ToString(segment ^ (segment >> 1), 2).PadLeft((int)printEncoderBit.Value, '0');

                for (int bit = 0; bit < printEncoderBit.Value; bit++)
                {
                    if (gray.Substring(gray.Length - bit - 1, 1) == "0")
                    {
                        float externalRadius = (float)(printImageSize.Value / 2) - (bitRadius * (bit+1) );
                        float internalRadius = (float)(externalRadius - bitRadius);

                        GraphicsPath p = new GraphicsPath();
                        p.AddArc(
                            new RectangleF(center.X - externalRadius, center.Y - externalRadius, externalRadius * 2, externalRadius * 2),
                            segment * segmentAngleDegree,
                            segmentAngleDegree
                            );
                        p.AddLine(
                            new Point((int)(center.X + externalRadius * Math.Cos(segmentAngleRadian * (segment + 1))), (int)(center.Y + externalRadius * Math.Sin(segmentAngleRadian * (segment + 1)))),
                            new Point((int)(center.X + internalRadius * Math.Cos(segmentAngleRadian * (segment + 1))), (int)(center.Y + internalRadius * Math.Sin(segmentAngleRadian * (segment + 1))))
                            );
                        p.AddArc(
                            new RectangleF(center.X - internalRadius, center.Y - internalRadius, internalRadius * 2, internalRadius * 2),
                            segmentAngleDegree * (segment + 1),
                            -segmentAngleDegree
                            );
                        p.AddLine(
                            new Point((int)(center.X + internalRadius * Math.Cos(segmentAngleRadian * segment)), (int)(center.Y + internalRadius * Math.Sin(segmentAngleRadian * segment))),
                            new Point((int)(center.X + externalRadius * Math.Cos(segmentAngleRadian * segment)), (int)(center.Y + externalRadius * Math.Sin(segmentAngleRadian * segment)))
                            );

                        g.FillPath(blackBrush, p);
//                        g.DrawPath(whitePen, p);
                    }
                }
            }
            
            g.Dispose();
            bmp.Save(printFileText.Text, ImageFormat.Jpeg);
            bmp.Dispose();

            if (MessageBox.Show("Изображение успешно создано. Открыть папку с изображением?", "Изображение успешно создано", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(@"c:\astro"); // @todo
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cvWebCam.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
