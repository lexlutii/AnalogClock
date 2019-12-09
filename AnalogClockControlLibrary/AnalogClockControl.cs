using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace AnalogClock3
{
    public partial class AnalogClockControl : UserControl
    {
        public struct handTheme {
            public Color color;
            public float width;
            public float length;
        }
        public handTheme[] handThems;


        public Color labelColor;
        public float labelWidth;
        public float labelLength;
        public float labelRadius;

        public Color textLabelColor;
        public float textLabelRadius;
        public float textLabelSize;
        public Font textLabelFont;

        public TimeZoneInfo timeZone;

        public AnalogClockControl()
        {
            InitializeComponent();
            handThems = new handTheme[3];
            handThems[0].color = Color.Red;
            handThems[0].length = Width / 2.7f;
            handThems[0].width = 1;
            handThems[1].color = Color.Blue;
            handThems[1].length = Width / 3f;
            handThems[1].width = 2;
            handThems[2].color = Color.Green;
            handThems[2].length = Width / 4f;
            handThems[2].width = 4;

            labelColor = Color.Black;
            labelWidth = 2;
            labelLength = 6;
            labelRadius = Width / 2.1f;

            textLabelColor = Color.Black;
            textLabelSize = 15f;
            textLabelFont = new Font("Times New Roman", textLabelSize);
            textLabelRadius = Width / 2.6f;

            DoubleBuffered = true;
            timeZone = TimeZoneInfo.Local;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Thread updateThread = new Thread(redrawing);
            updateThread.Start();
        }

        private void redrawing() {
            while (true) {
                Thread.Sleep(1000 / 30);
                Invalidate();
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            DrawDialLabels(g);
            DrawDialTextLabels(g);
            DrawDialHands(g);
        }

        private void DrawDialLabels(Graphics g)
        {

            PointF center = new PointF(this.Width / 2, this.Height / 2);
            Pen dialLabelPen = new Pen(labelColor, labelWidth);

            PointF label1 = new PointF(center.X, center.Y);
            label1.Y -= labelRadius;
            PointF label2 = new PointF(center.X, center.Y);
            label2.Y -= labelRadius - labelLength;

            for (int i = 0; i < 60; i++)
            {
                float angle = 6 * i;
                PointF[] labelVector = { label1, label2 };

                if (i % 5 == 0)
                    labelVector[1].Y+=(labelLength*0.75f);

                RotateAt(labelVector, angle, center.X, center.Y);
                g.DrawLine(dialLabelPen, labelVector[0], labelVector[1]);
            }
        }

        private void DrawDialTextLabels(Graphics g)
        {
            string[] romanTextLabels = { "XII", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI" };

            Brush textBrush = new SolidBrush(textLabelColor);
            PointF center = new PointF(this.Width / 2, this.Height / 2);
            PointF textPoint = new PointF(center.X, center.Y - textLabelRadius);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            for (int i = 0; i < 12; i++)
            {
                float angle = 30 * i;
                PointF[] vector = { textPoint, center };
                RotateAt(vector, angle, center.X, center.Y);
                
                DrawRotatedTextAt(g, angle, romanTextLabels[i], vector[0].X, vector[0].Y, textLabelFont, textBrush, format);
            }
        }

        // Draw a rotated string at a particular position.
        private void DrawRotatedTextAt(Graphics gr, float angle,
            string txt, float x, float y, Font the_font, Brush the_brush, StringFormat sf)

        {
            // Save the graphics state.
            GraphicsState state = gr.Save();
            gr.ResetTransform();

            // Rotate.
            gr.RotateTransform(angle);

            // Translate to desired position. Be sure to append
            // the rotation so it occurs after the rotation.
            gr.TranslateTransform(x, y, MatrixOrder.Append);

            // Draw the text at the origin.
            gr.DrawString(txt, the_font, the_brush, 0, 0, sf);

            // Restore the graphics state.
            gr.Restore(state);
        }

        private void DrawDialHands(Graphics g) {
            PointF center = new PointF(this.Width / 2, this.Height / 2);
            DateTime dateTime = DateTime.UtcNow;
            dateTime= TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);

            float[] angles = new float[3];
            angles[0] = dateTime.Second * 6f + dateTime.Millisecond * 0.006f;
            angles[1] = dateTime.Minute * 6f + dateTime.Second * 0.1f;
            angles[2] = dateTime.Hour * 30f + dateTime.Minute * 0.5f;

            Pen handPen = new Pen(Color.Black);
            for (int i = 2; i >= 0; i--) {
                PointF[] handVector = {
                    center, new PointF(center.X, center.Y- handThems[i].length)
                };

                RotateAt(handVector, angles[i], center.X, center.Y);
                handPen.Color = handThems[i].color;
                handPen.Width = handThems[i].width;
                g.DrawLine(handPen, handVector[0], handVector[1]);
            }
        }

        public void RotateAt(PointF[] vector, float angle, float cx, float cy)
        {
            using (var gp = new GraphicsPath())
            {
                gp.AddLine(vector[0], vector[1]);
                using (var m = new Matrix())
                {
                    m.RotateAt(angle, new PointF(cx, cy));
                    gp.Transform(m);
                }
                var ps = gp.PathPoints;
                for (var i = 0; i < ps.Length; i++)
                    vector[i] = ps[i];
            }
        }
    }
}
