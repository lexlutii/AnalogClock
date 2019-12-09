namespace AnalogClockControlLibrary
{
    partial class AnalogClockTimeZoneControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.analogClockControl1 = new AnalogClock3.AnalogClockControl();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // analogClockControl1
            // 
            this.analogClockControl1.Location = new System.Drawing.Point(0, 0);
            this.analogClockControl1.Name = "analogClockControl1";
            this.analogClockControl1.Size = new System.Drawing.Size(256, 256);
            this.analogClockControl1.TabIndex = 0;
            // 
            // AnalogClockTimeZoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.analogClockControl1);
            this.Name = "AnalogClockTimeZoneControl";
            this.Size = new System.Drawing.Size(259, 287);
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClock3.AnalogClockControl analogClockControl1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
