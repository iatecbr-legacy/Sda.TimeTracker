namespace Sda.TimeTracker.VSTS.Desktop
{
    partial class fmSelectQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSelectQuery));
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxShowBugs = new System.Windows.Forms.CheckBox();
            this.labelWorkItems = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(856, 470);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 33);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamProject,
            this.Id,
            this.Title,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(13, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // TeamProject
            // 
            this.TeamProject.DataPropertyName = "TeamProject";
            this.TeamProject.FillWeight = 200F;
            this.TeamProject.HeaderText = "TeamProject";
            this.TeamProject.Name = "TeamProject";
            this.TeamProject.ReadOnly = true;
            this.TeamProject.Width = 200;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 300F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 300;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(737, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxShowBugs
            // 
            this.checkBoxShowBugs.AutoSize = true;
            this.checkBoxShowBugs.Location = new System.Drawing.Point(529, 20);
            this.checkBoxShowBugs.Name = "checkBoxShowBugs";
            this.checkBoxShowBugs.Size = new System.Drawing.Size(100, 21);
            this.checkBoxShowBugs.TabIndex = 3;
            this.checkBoxShowBugs.Text = "Show Bugs";
            this.checkBoxShowBugs.UseVisualStyleBackColor = true;
            this.checkBoxShowBugs.CheckedChanged += new System.EventHandler(this.checkBoxShowBugs_CheckedChanged);
            // 
            // labelWorkItems
            // 
            this.labelWorkItems.AutoSize = true;
            this.labelWorkItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkItems.Location = new System.Drawing.Point(13, 18);
            this.labelWorkItems.Name = "labelWorkItems";
            this.labelWorkItems.Size = new System.Drawing.Size(232, 20);
            this.labelWorkItems.TabIndex = 4;
            this.labelWorkItems.Text = "WorkItems assigned to me";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Location = new System.Drawing.Point(814, 17);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(124, 22);
            this.textBoxCode.TabIndex = 5;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            // 
            // labelCode
            // 
            this.labelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(781, 20);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(27, 17);
            this.labelCode.TabIndex = 6;
            this.labelCode.Text = "#Id";
            // 
            // buttonLink
            // 
            this.buttonLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLink.BackColor = System.Drawing.Color.Transparent;
            this.buttonLink.BackgroundImage = global::Sda.TimeTracker.VSTS.Desktop.Properties.Resources.glyphicons_82_refresh;
            this.buttonLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLink.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonLink.FlatAppearance.BorderSize = 0;
            this.buttonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLink.Location = new System.Drawing.Point(945, 17);
            this.buttonLink.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(23, 23);
            this.buttonLink.TabIndex = 22;
            this.buttonLink.UseVisualStyleBackColor = false;
            this.buttonLink.Click += new System.EventHandler(this.buttonLink_Click);
            // 
            // fmSelectQuery
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelWorkItems);
            this.Controls.Add(this.checkBoxShowBugs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmSelectQuery";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select WorkItem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fmSelectQuery_Load);
            this.Shown += new System.EventHandler(this.fmSelectQuery_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxShowBugs;
        private System.Windows.Forms.Label labelWorkItems;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button buttonLink;
    }
}