namespace PrilojenieAIS
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
            this.buttonSQL = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSQL
            // 
            this.buttonSQL.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSQL.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSQL.ForeColor = System.Drawing.Color.White;
            this.buttonSQL.Location = new System.Drawing.Point(872, 0);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(178, 59);
            this.buttonSQL.TabIndex = 5;
            this.buttonSQL.Text = "Таблицы:";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Pink;
            this.topPanel.Controls.Add(this.Title);
            this.topPanel.Controls.Add(this.buttonMenu);
            this.topPanel.Controls.Add(this.buttonSQL);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1050, 59);
            this.topPanel.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.CausesValidation = false;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(246, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(626, 59);
            this.Title.TabIndex = 7;
            this.Title.TabStop = false;
            this.Title.Text = "Урок 0 : основы работы с программой";
            this.Title.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.LightPink;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(246, 59);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Меню уроков:";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.Menu_Show);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoScroll = true;
            this.menuStrip.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(246, 563);
            this.menuStrip.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip);
            this.panel3.Controls.Add(this.userControlPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 563);
            this.panel3.TabIndex = 8;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1050, 563);
            this.userControlPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1050, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Слоняра";
            this.Click += new System.EventHandler(this.Menu_Show);
            this.topPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSQL;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.Button buttonMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel menuStrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel userControlPanel;
    }
}

