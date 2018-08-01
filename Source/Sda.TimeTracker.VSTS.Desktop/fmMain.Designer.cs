namespace Sda.TimeTracker.VSTS.Desktop
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnSelectQuery = new System.Windows.Forms.Button();
            this.timerElapsed = new System.Windows.Forms.Timer(this.components);
            this.labelTaskValue = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.checkBoxInativity = new System.Windows.Forms.CheckBox();
            this.buttonLink = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.panelTracking = new System.Windows.Forms.Panel();
            this.panelInativity = new System.Windows.Forms.Panel();
            this.labelPaused = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelEstimative = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelEstimativeValue = new System.Windows.Forms.Label();
            this.globalEventProvider1 = new Gma.UserActivityMonitor.GlobalEventProvider();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResize = new System.Windows.Forms.Button();
            this.panelDescription.SuspendLayout();
            this.panelTracking.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectQuery
            // 
            this.btnSelectQuery.Location = new System.Drawing.Point(912, 21);
            this.btnSelectQuery.Name = "btnSelectQuery";
            this.btnSelectQuery.Size = new System.Drawing.Size(82, 31);
            this.btnSelectQuery.TabIndex = 0;
            this.btnSelectQuery.Text = "Select";
            this.btnSelectQuery.UseVisualStyleBackColor = true;
            this.btnSelectQuery.Click += new System.EventHandler(this.btnSelectQuery_Click);
            // 
            // timerElapsed
            // 
            this.timerElapsed.Enabled = true;
            this.timerElapsed.Interval = 1000;
            this.timerElapsed.Tick += new System.EventHandler(this.timerElapsed_Tick);
            // 
            // labelTaskValue
            // 
            this.labelTaskValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTaskValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskValue.Location = new System.Drawing.Point(4, 21);
            this.labelTaskValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskValue.MaximumSize = new System.Drawing.Size(395, 29);
            this.labelTaskValue.Name = "labelTaskValue";
            this.labelTaskValue.Size = new System.Drawing.Size(360, 29);
            this.labelTaskValue.TabIndex = 12;
            this.labelTaskValue.Text = "Select a WorkItem";
            this.labelTaskValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelTaskValue_MouseDoubleClick);
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.SystemColors.Window;
            this.panelDescription.Controls.Add(this.checkBoxInativity);
            this.panelDescription.Controls.Add(this.buttonLink);
            this.panelDescription.Controls.Add(this.buttonSelect);
            this.panelDescription.Controls.Add(this.labelTaskValue);
            this.panelDescription.Controls.Add(this.labelTask);
            this.panelDescription.Location = new System.Drawing.Point(97, 2);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(4);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(456, 54);
            this.panelDescription.TabIndex = 20;
            this.panelDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmMain_MouseDown);
            // 
            // checkBoxInativity
            // 
            this.checkBoxInativity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxInativity.AutoSize = true;
            this.checkBoxInativity.Checked = true;
            this.checkBoxInativity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInativity.Location = new System.Drawing.Point(329, 3);
            this.checkBoxInativity.Name = "checkBoxInativity";
            this.checkBoxInativity.Size = new System.Drawing.Size(120, 21);
            this.checkBoxInativity.TabIndex = 23;
            this.checkBoxInativity.Text = "Check Inativity";
            this.checkBoxInativity.UseVisualStyleBackColor = true;
            // 
            // buttonLink
            // 
            this.buttonLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLink.BackColor = System.Drawing.Color.Transparent;
            this.buttonLink.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.glyphicons_152_new_window;
            this.buttonLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLink.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonLink.FlatAppearance.BorderSize = 0;
            this.buttonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLink.Location = new System.Drawing.Point(384, 25);
            this.buttonLink.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(30, 23);
            this.buttonLink.TabIndex = 21;
            this.buttonLink.UseVisualStyleBackColor = false;
            this.buttonLink.Visible = false;
            this.buttonLink.Click += new System.EventHandler(this.buttonLink_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.glyphicons_145_folder_open;
            this.buttonSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSelect.Location = new System.Drawing.Point(419, 25);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(30, 23);
            this.buttonSelect.TabIndex = 20;
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(9, 5);
            this.labelTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(39, 17);
            this.labelTask.TabIndex = 11;
            this.labelTask.Text = "Task";
            // 
            // panelTracking
            // 
            this.panelTracking.Controls.Add(this.panelInativity);
            this.panelTracking.Controls.Add(this.labelPaused);
            this.panelTracking.Controls.Add(this.labelStatus);
            this.panelTracking.Controls.Add(this.labelEstimative);
            this.panelTracking.Controls.Add(this.buttonStartStop);
            this.panelTracking.Controls.Add(this.labelHoras);
            this.panelTracking.Controls.Add(this.labelEstimativeValue);
            this.panelTracking.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTracking.Location = new System.Drawing.Point(555, 0);
            this.panelTracking.Margin = new System.Windows.Forms.Padding(4);
            this.panelTracking.Name = "panelTracking";
            this.panelTracking.Padding = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.panelTracking.Size = new System.Drawing.Size(331, 59);
            this.panelTracking.TabIndex = 25;
            this.panelTracking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmMain_MouseDown);
            // 
            // panelInativity
            // 
            this.panelInativity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelInativity.Location = new System.Drawing.Point(314, -60);
            this.panelInativity.Name = "panelInativity";
            this.panelInativity.Size = new System.Drawing.Size(11, 119);
            this.panelInativity.TabIndex = 20;
            // 
            // labelPaused
            // 
            this.labelPaused.AutoSize = true;
            this.labelPaused.BackColor = System.Drawing.Color.Transparent;
            this.labelPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaused.ForeColor = System.Drawing.Color.Red;
            this.labelPaused.Location = new System.Drawing.Point(109, 39);
            this.labelPaused.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaused.Name = "labelPaused";
            this.labelPaused.Size = new System.Drawing.Size(112, 31);
            this.labelPaused.TabIndex = 19;
            this.labelPaused.Text = "Paused";
            this.labelPaused.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(110, 23);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(119, 29);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "00:00:00";
            // 
            // labelEstimative
            // 
            this.labelEstimative.AutoSize = true;
            this.labelEstimative.Location = new System.Drawing.Point(24, 7);
            this.labelEstimative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstimative.Name = "labelEstimative";
            this.labelEstimative.Size = new System.Drawing.Size(72, 17);
            this.labelEstimative.TabIndex = 17;
            this.labelEstimative.Text = "Estimativa";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartStop.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.Play;
            this.buttonStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonStartStop.FlatAppearance.BorderSize = 0;
            this.buttonStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartStop.Location = new System.Drawing.Point(244, 4);
            this.buttonStartStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(53, 50);
            this.buttonStartStop.TabIndex = 16;
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Visible = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(114, 7);
            this.labelHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(48, 17);
            this.labelHoras.TabIndex = 15;
            this.labelHoras.Text = "Status";
            // 
            // labelEstimativeValue
            // 
            this.labelEstimativeValue.AutoSize = true;
            this.labelEstimativeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimativeValue.Location = new System.Drawing.Point(5, 24);
            this.labelEstimativeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstimativeValue.MaximumSize = new System.Drawing.Size(93, 0);
            this.labelEstimativeValue.MinimumSize = new System.Drawing.Size(93, 0);
            this.labelEstimativeValue.Name = "labelEstimativeValue";
            this.labelEstimativeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEstimativeValue.Size = new System.Drawing.Size(93, 29);
            this.labelEstimativeValue.TabIndex = 14;
            this.labelEstimativeValue.Text = "000";
            // 
            // globalEventProvider1
            // 
            this.globalEventProvider1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.globalEventProvider1_MouseMove);
            this.globalEventProvider1.MouseMoveExt += new System.EventHandler<Gma.UserActivityMonitor.MouseEventExtArgs>(this.globalEventProvider1_MouseMoveExt);
            this.globalEventProvider1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider1_KeyDown);
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.glyphicons_137_cogwheel;
            this.buttonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfig.Location = new System.Drawing.Point(61, 17);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(24, 24);
            this.buttonConfig.TabIndex = 27;
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.glyphicons_208_remove;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(21, 17);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 24);
            this.buttonClose.TabIndex = 26;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.MoveIcon_fw;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(886, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 59);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmMain_MouseDown);
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResize.BackgroundImage")));
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResize.CausesValidation = false;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonResize.FlatAppearance.BorderSize = 0;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Location = new System.Drawing.Point(0, 0);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(13, 59);
            this.buttonResize.TabIndex = 21;
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(898, 59);
            this.Controls.Add(this.panelTracking);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.btnSelectQuery);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmMain";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.Shown += new System.EventHandler(this.fmMain_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmMain_MouseDown);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelTracking.ResumeLayout(false);
            this.panelTracking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectQuery;
        private System.Windows.Forms.Timer timerElapsed;
        private System.Windows.Forms.Label labelTaskValue;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTracking;
        private System.Windows.Forms.Label labelPaused;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelEstimative;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelEstimativeValue;
        private System.Windows.Forms.Panel panelInativity;
        private System.Windows.Forms.CheckBox checkBoxInativity;
        private Gma.UserActivityMonitor.GlobalEventProvider globalEventProvider1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConfig;
    }
}