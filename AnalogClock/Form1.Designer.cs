namespace AnalogClock3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.analogClockTimeZoneControl1 = new AnalogClockControlLibrary.AnalogClockTimeZoneControl();
            this.SuspendLayout();
            // 
            // analogClockTimeZoneControl1
            // 
            this.analogClockTimeZoneControl1.Location = new System.Drawing.Point(12, 12);
            this.analogClockTimeZoneControl1.Name = "analogClockTimeZoneControl1";
            this.analogClockTimeZoneControl1.Size = new System.Drawing.Size(259, 287);
            this.analogClockTimeZoneControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.Controls.Add(this.analogClockTimeZoneControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AnalogClockControlLibrary.AnalogClockTimeZoneControl analogClockTimeZoneControl1;
    }
}

