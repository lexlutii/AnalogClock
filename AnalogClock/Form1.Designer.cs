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
            this.analogClockTimeZoneControl2 = new AnalogClockControlLibrary.AnalogClockTimeZoneControl();
            this.SuspendLayout();
            // 
            // analogClockTimeZoneControl2
            // 
            this.analogClockTimeZoneControl2.Location = new System.Drawing.Point(0, 0);
            this.analogClockTimeZoneControl2.Name = "analogClockTimeZoneControl2";
            this.analogClockTimeZoneControl2.Size = new System.Drawing.Size(259, 287);
            this.analogClockTimeZoneControl2.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(261, 292);
            this.Controls.Add(this.analogClockTimeZoneControl2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AnalogClockControlLibrary.AnalogClockTimeZoneControl analogClockTimeZoneControl1;
        private AnalogClockControlLibrary.AnalogClockTimeZoneControl analogClockTimeZoneControl2;
    }
}

