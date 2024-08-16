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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            layoutPanelLegionSlim = new TableLayoutPanel();
            buttonU = new Button();
            buttonSupport = new Button();
            buttonSecurity = new Button();
            buttonDevice = new Button();
            labelLegionSlim = new Label();
            panelL = new Panel();
            labelL = new Label();
            panelMain = new Panel();
            devicePage1 = new DevicePage();
            layoutPanelLegionSlim.SuspendLayout();
            panelL.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanelLegionSlim
            // 
            layoutPanelLegionSlim.BackColor = Color.DarkSlateGray;
            layoutPanelLegionSlim.ColumnCount = 6;
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelLegionSlim.Controls.Add(buttonU, 5, 0);
            layoutPanelLegionSlim.Controls.Add(buttonSupport, 4, 0);
            layoutPanelLegionSlim.Controls.Add(buttonSecurity, 3, 0);
            layoutPanelLegionSlim.Controls.Add(buttonDevice, 2, 0);
            layoutPanelLegionSlim.Controls.Add(labelLegionSlim, 1, 0);
            layoutPanelLegionSlim.Controls.Add(panelL, 0, 0);
            layoutPanelLegionSlim.Dock = DockStyle.Top;
            layoutPanelLegionSlim.Location = new Point(0, 0);
            layoutPanelLegionSlim.Name = "layoutPanelLegionSlim";
            layoutPanelLegionSlim.RowCount = 1;
            layoutPanelLegionSlim.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPanelLegionSlim.Size = new Size(1904, 70);
            layoutPanelLegionSlim.TabIndex = 1;
            // 
            // buttonU
            // 
            buttonU.Dock = DockStyle.Fill;
            buttonU.FlatStyle = FlatStyle.Flat;
            buttonU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonU.ForeColor = SystemColors.Control;
            buttonU.Location = new Point(1715, 3);
            buttonU.Name = "buttonU";
            buttonU.Size = new Size(186, 64);
            buttonU.TabIndex = 3;
            buttonU.Text = "U";
            buttonU.UseVisualStyleBackColor = true;
            // 
            // buttonSupport
            // 
            buttonSupport.Dock = DockStyle.Fill;
            buttonSupport.FlatStyle = FlatStyle.Flat;
            buttonSupport.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSupport.ForeColor = SystemColors.Control;
            buttonSupport.Location = new Point(1525, 3);
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Size = new Size(184, 64);
            buttonSupport.TabIndex = 2;
            buttonSupport.Text = "Support";
            buttonSupport.UseVisualStyleBackColor = true;
            // 
            // buttonSecurity
            // 
            buttonSecurity.Dock = DockStyle.Fill;
            buttonSecurity.FlatStyle = FlatStyle.Flat;
            buttonSecurity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSecurity.ForeColor = SystemColors.Control;
            buttonSecurity.Location = new Point(1335, 3);
            buttonSecurity.Name = "buttonSecurity";
            buttonSecurity.Size = new Size(184, 64);
            buttonSecurity.TabIndex = 1;
            buttonSecurity.Text = "Security";
            buttonSecurity.UseVisualStyleBackColor = true;
            // 
            // buttonDevice
            // 
            buttonDevice.Dock = DockStyle.Fill;
            buttonDevice.FlatStyle = FlatStyle.Flat;
            buttonDevice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDevice.ForeColor = SystemColors.Control;
            buttonDevice.Location = new Point(1145, 3);
            buttonDevice.Name = "buttonDevice";
            buttonDevice.Size = new Size(184, 64);
            buttonDevice.TabIndex = 0;
            buttonDevice.Text = "Device";
            buttonDevice.UseVisualStyleBackColor = true;
            // 
            // labelLegionSlim
            // 
            labelLegionSlim.AutoSize = true;
            labelLegionSlim.Dock = DockStyle.Bottom;
            labelLegionSlim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLegionSlim.ForeColor = SystemColors.Control;
            labelLegionSlim.Location = new Point(98, 32);
            labelLegionSlim.Name = "labelLegionSlim";
            labelLegionSlim.Size = new Size(1041, 38);
            labelLegionSlim.TabIndex = 0;
            labelLegionSlim.Text = "Legion Slim 5 16APH8";
            // 
            // panelL
            // 
            panelL.BackColor = Color.LightSeaGreen;
            panelL.Controls.Add(labelL);
            panelL.Dock = DockStyle.Fill;
            panelL.Location = new Point(3, 3);
            panelL.Name = "panelL";
            panelL.Size = new Size(89, 64);
            panelL.TabIndex = 4;
            // 
            // labelL
            // 
            labelL.AutoSize = true;
            labelL.Dock = DockStyle.Right;
            labelL.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelL.ForeColor = SystemColors.Control;
            labelL.Location = new Point(-2, 0);
            labelL.Margin = new Padding(0);
            labelL.Name = "labelL";
            labelL.Padding = new Padding(20, 0, 20, 0);
            labelL.Size = new Size(91, 65);
            labelL.TabIndex = 5;
            labelL.Text = "L";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Controls.Add(devicePage1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 70);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1904, 1060);
            panelMain.TabIndex = 2;
            // 
            // devicePage1
            // 
            devicePage1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            devicePage1.AutoScroll = true;
            devicePage1.AutoSize = true;
            devicePage1.BackColor = SystemColors.ControlDarkDark;
            devicePage1.Location = new Point(0, -70);
            devicePage1.Name = "devicePage1";
            devicePage1.Size = new Size(1904, 1200);
            devicePage1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1904, 1130);
            Controls.Add(panelMain);
            Controls.Add(layoutPanelLegionSlim);
            MinimumSize = new Size(1743, 992);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            layoutPanelLegionSlim.ResumeLayout(false);
            layoutPanelLegionSlim.PerformLayout();
            panelL.ResumeLayout(false);
            panelL.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TableLayoutPanel layoutPanelLegionSlim;
        private Button buttonU;
        private Button buttonSupport;
        private Button buttonSecurity;
        private Button buttonDevice;
        private Label labelLegionSlim;
        private Panel panelL;
        private Label labelL;
        private Panel panelMain;
        private DevicePage devicePage1;
    }
}
