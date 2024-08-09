namespace LenovoUI.Winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            leftTableLayout = new TableLayoutPanel();
            label1 = new Label();
            buttonVRAM = new Button();
            buttonGpu = new Button();
            buttonCPU = new Button();
            labelGPU = new Label();
            labelVRAM = new Label();
            labelSSD = new Label();
            buttonStorage = new Button();
            buttonMacroKey = new Button();
            buttonPower = new Button();
            buttonMedia = new Button();
            buttonHardwareScan = new Button();
            labelSystemTools = new Label();
            buttonSystemUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            leftTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = SystemColors.ControlDarkDark;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.ForeColor = SystemColors.ControlText;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlDarkDark;
            splitContainer.Panel1.Controls.Add(leftTableLayout);
            splitContainer.Panel1.Padding = new Padding(50);
            splitContainer.Size = new Size(1876, 1013);
            splitContainer.SplitterDistance = 1170;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.BackColor = Color.DarkSlateGray;
            leftTableLayout.ColumnCount = 5;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.Controls.Add(label1, 0, 5);
            leftTableLayout.Controls.Add(buttonVRAM, 2, 0);
            leftTableLayout.Controls.Add(buttonGpu, 0, 0);
            leftTableLayout.Controls.Add(buttonCPU, 1, 0);
            leftTableLayout.Controls.Add(labelGPU, 0, 1);
            leftTableLayout.Controls.Add(labelVRAM, 2, 1);
            leftTableLayout.Controls.Add(labelSSD, 4, 1);
            leftTableLayout.Controls.Add(buttonStorage, 4, 0);
            leftTableLayout.Controls.Add(buttonMacroKey, 1, 3);
            leftTableLayout.Controls.Add(buttonPower, 2, 3);
            leftTableLayout.Controls.Add(buttonMedia, 3, 3);
            leftTableLayout.Controls.Add(buttonHardwareScan, 4, 3);
            leftTableLayout.Controls.Add(labelSystemTools, 0, 2);
            leftTableLayout.Controls.Add(buttonSystemUpdate, 0, 3);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.ForeColor = SystemColors.Control;
            leftTableLayout.Location = new Point(50, 50);
            leftTableLayout.Margin = new Padding(0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.Padding = new Padding(40);
            leftTableLayout.RowCount = 6;
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            leftTableLayout.Size = new Size(1070, 913);
            leftTableLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 732);
            label1.Margin = new Padding(0, 1, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 13;
            label1.Text = "System Health";
            // 
            // buttonVRAM
            // 
            buttonVRAM.Dock = DockStyle.Fill;
            buttonVRAM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVRAM.ForeColor = SystemColors.ControlText;
            buttonVRAM.Location = new Point(506, 70);
            buttonVRAM.Margin = new Padding(70, 30, 70, 30);
            buttonVRAM.Name = "buttonVRAM";
            buttonVRAM.Size = new Size(58, 263);
            buttonVRAM.TabIndex = 2;
            buttonVRAM.UseVisualStyleBackColor = true;
            // 
            // buttonGpu
            // 
            buttonGpu.Dock = DockStyle.Fill;
            buttonGpu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGpu.ForeColor = SystemColors.ControlText;
            buttonGpu.Location = new Point(110, 70);
            buttonGpu.Margin = new Padding(70, 30, 70, 30);
            buttonGpu.Name = "buttonGpu";
            buttonGpu.Size = new Size(58, 263);
            buttonGpu.TabIndex = 1;
            buttonGpu.UseVisualStyleBackColor = true;
            // 
            // buttonCPU
            // 
            buttonCPU.Dock = DockStyle.Fill;
            buttonCPU.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCPU.ForeColor = SystemColors.ControlText;
            buttonCPU.Location = new Point(268, 70);
            buttonCPU.Margin = new Padding(30);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Size = new Size(138, 263);
            buttonCPU.TabIndex = 0;
            buttonCPU.Text = "CPU";
            buttonCPU.UseVisualStyleBackColor = true;
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.BackColor = Color.Transparent;
            labelGPU.Dock = DockStyle.Top;
            labelGPU.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGPU.ForeColor = Color.Transparent;
            labelGPU.Location = new Point(110, 364);
            labelGPU.Margin = new Padding(70, 1, 60, 0);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(68, 30);
            labelGPU.TabIndex = 4;
            labelGPU.Text = "GPU";
            // 
            // labelVRAM
            // 
            labelVRAM.AutoSize = true;
            labelVRAM.Dock = DockStyle.Top;
            labelVRAM.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVRAM.Location = new Point(496, 364);
            labelVRAM.Margin = new Padding(60, 1, 50, 0);
            labelVRAM.Name = "labelVRAM";
            labelVRAM.Size = new Size(88, 30);
            labelVRAM.TabIndex = 5;
            labelVRAM.Text = "VRAM";
            // 
            // labelSSD
            // 
            labelSSD.AutoSize = true;
            labelSSD.Dock = DockStyle.Top;
            labelSSD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSSD.ForeColor = SystemColors.Control;
            labelSSD.Location = new Point(902, 364);
            labelSSD.Margin = new Padding(70, 1, 70, 0);
            labelSSD.Name = "labelSSD";
            labelSSD.Size = new Size(58, 30);
            labelSSD.TabIndex = 6;
            labelSSD.Text = "SSD";
            // 
            // buttonStorage
            // 
            buttonStorage.Dock = DockStyle.Fill;
            buttonStorage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStorage.ForeColor = SystemColors.ControlText;
            buttonStorage.Location = new Point(852, 100);
            buttonStorage.Margin = new Padding(20, 60, 20, 30);
            buttonStorage.Name = "buttonStorage";
            buttonStorage.Size = new Size(158, 233);
            buttonStorage.TabIndex = 3;
            buttonStorage.Text = "88%";
            buttonStorage.UseVisualStyleBackColor = true;
            // 
            // buttonMacroKey
            // 
            buttonMacroKey.Dock = DockStyle.Fill;
            buttonMacroKey.ForeColor = SystemColors.ControlText;
            buttonMacroKey.Location = new Point(258, 567);
            buttonMacroKey.Margin = new Padding(20);
            buttonMacroKey.Name = "buttonMacroKey";
            buttonMacroKey.Size = new Size(158, 98);
            buttonMacroKey.TabIndex = 9;
            buttonMacroKey.Text = "Macro Key";
            buttonMacroKey.UseVisualStyleBackColor = true;
            // 
            // buttonPower
            // 
            buttonPower.Dock = DockStyle.Fill;
            buttonPower.ForeColor = SystemColors.ControlText;
            buttonPower.Location = new Point(456, 567);
            buttonPower.Margin = new Padding(20);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(158, 98);
            buttonPower.TabIndex = 10;
            buttonPower.Text = "Power";
            buttonPower.UseVisualStyleBackColor = true;
            // 
            // buttonMedia
            // 
            buttonMedia.Dock = DockStyle.Fill;
            buttonMedia.ForeColor = SystemColors.ControlText;
            buttonMedia.Location = new Point(654, 567);
            buttonMedia.Margin = new Padding(20);
            buttonMedia.Name = "buttonMedia";
            buttonMedia.Size = new Size(158, 98);
            buttonMedia.TabIndex = 12;
            buttonMedia.Text = "Media";
            buttonMedia.UseVisualStyleBackColor = true;
            // 
            // buttonHardwareScan
            // 
            buttonHardwareScan.Dock = DockStyle.Fill;
            buttonHardwareScan.ForeColor = SystemColors.ControlText;
            buttonHardwareScan.Location = new Point(852, 567);
            buttonHardwareScan.Margin = new Padding(20);
            buttonHardwareScan.Name = "buttonHardwareScan";
            buttonHardwareScan.Size = new Size(158, 98);
            buttonHardwareScan.TabIndex = 11;
            buttonHardwareScan.Text = "Hardware Scan";
            buttonHardwareScan.UseVisualStyleBackColor = true;
            // 
            // labelSystemTools
            // 
            labelSystemTools.AutoSize = true;
            labelSystemTools.Dock = DockStyle.Bottom;
            labelSystemTools.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSystemTools.Location = new Point(40, 509);
            labelSystemTools.Margin = new Padding(0);
            labelSystemTools.Name = "labelSystemTools";
            labelSystemTools.Size = new Size(198, 38);
            labelSystemTools.TabIndex = 7;
            labelSystemTools.Text = "System Tools";
            // 
            // buttonSystemUpdate
            // 
            buttonSystemUpdate.Dock = DockStyle.Fill;
            buttonSystemUpdate.ForeColor = SystemColors.ControlText;
            buttonSystemUpdate.Location = new Point(60, 567);
            buttonSystemUpdate.Margin = new Padding(20);
            buttonSystemUpdate.Name = "buttonSystemUpdate";
            buttonSystemUpdate.Size = new Size(158, 98);
            buttonSystemUpdate.TabIndex = 8;
            buttonSystemUpdate.Text = "System Update";
            buttonSystemUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 1013);
            Controls.Add(splitContainer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            leftTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TableLayoutPanel leftTableLayout;
        private Button buttonCPU;
        private Button buttonVRAM;
        private Button buttonGpu;
        private Button buttonStorage;
        private Label labelGPU;
        private Label labelVRAM;
        private Label labelSSD;
        private Label labelSystemTools;
        private Button buttonSystemUpdate;
        private Button buttonMacroKey;
        private Button buttonPower;
        private Button buttonMedia;
        private Button buttonHardwareScan;
        private Label label1;
    }
}
