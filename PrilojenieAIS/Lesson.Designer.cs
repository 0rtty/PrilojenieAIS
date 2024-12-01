namespace PrilojenieAIS
{
    partial class Lesson
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
            this.readPanel = new System.Windows.Forms.Panel();
            this.readingZone = new System.Windows.Forms.PictureBox();
            this.readPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingZone)).BeginInit();
            this.SuspendLayout();
            // 
            // readPanel
            // 
            this.readPanel.AutoScroll = true;
            this.readPanel.BackColor = System.Drawing.Color.Pink;
            this.readPanel.Controls.Add(this.readingZone);
            this.readPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readPanel.Location = new System.Drawing.Point(0, 0);
            this.readPanel.Name = "readPanel";
            this.readPanel.Size = new System.Drawing.Size(1050, 563);
            this.readPanel.TabIndex = 3;
            // 
            // readingZone
            // 
            this.readingZone.BackColor = System.Drawing.Color.MistyRose;
            this.readingZone.Dock = System.Windows.Forms.DockStyle.Top;
            this.readingZone.Location = new System.Drawing.Point(0, 0);
            this.readingZone.Name = "readingZone";
            this.readingZone.Size = new System.Drawing.Size(1029, 1698);
            this.readingZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.readingZone.TabIndex = 0;
            this.readingZone.TabStop = false;
            this.readingZone.WaitOnLoad = true;
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.readPanel);
            this.Name = "Lesson";
            this.Size = new System.Drawing.Size(1050, 563);
            this.readPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readingZone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel readPanel;
        private System.Windows.Forms.PictureBox readingZone;
    }
}
