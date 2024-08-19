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
            button1 = new Button();
            panelMain = new Panel();
            panel1 = new Panel();
            devicePage1 = new DevicePage();
            layoutPanelLegionSlim.SuspendLayout();
            panelL.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
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
            layoutPanelLegionSlim.Size = new Size(1801, 72);
            layoutPanelLegionSlim.TabIndex = 1;
            // 
            // buttonU
            // 
            buttonU.Dock = DockStyle.Fill;
            buttonU.FlatStyle = FlatStyle.Flat;
            buttonU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonU.ForeColor = SystemColors.Control;
            buttonU.Location = new Point(1623, 3);
            buttonU.Name = "buttonU";
            buttonU.Size = new Size(175, 66);
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
            buttonSupport.Location = new Point(1443, 3);
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Size = new Size(174, 66);
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
            buttonSecurity.Location = new Point(1263, 3);
            buttonSecurity.Name = "buttonSecurity";
            buttonSecurity.Size = new Size(174, 66);
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
            buttonDevice.Location = new Point(1083, 3);
            buttonDevice.Name = "buttonDevice";
            buttonDevice.Size = new Size(174, 66);
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
            labelLegionSlim.Location = new Point(93, 34);
            labelLegionSlim.Name = "labelLegionSlim";
            labelLegionSlim.Size = new Size(984, 38);
            labelLegionSlim.TabIndex = 0;
            labelLegionSlim.Text = "Legion Slim 5 16APH8";
            // 
            // panelL
            // 
            panelL.BackColor = Color.LightSeaGreen;
            panelL.Controls.Add(button1);
            panelL.Dock = DockStyle.Fill;
            panelL.Location = new Point(3, 3);
            panelL.Name = "panelL";
            panelL.Size = new Size(84, 66);
            panelL.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(84, 66);
            button1.TabIndex = 0;
            button1.Text = "L";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.DarkSlateGray;
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 72);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1801, 1010);
            panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(devicePage1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1801, 1010);
            panel1.TabIndex = 0;
            // 
            // devicePage1
            // 
            devicePage1.AutoScroll = true;
            devicePage1.BackColor = SystemColors.ControlDarkDark;
            devicePage1.Location = new Point(0, 0);
            devicePage1.Name = "devicePage1";
            devicePage1.Size = new Size(1775, 1200);
            devicePage1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 1082);
            Controls.Add(panelMain);
            Controls.Add(layoutPanelLegionSlim);
            MinimumSize = new Size(1743, 992);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            layoutPanelLegionSlim.ResumeLayout(false);
            layoutPanelLegionSlim.PerformLayout();
            panelL.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Button button1;
        private Panel panelMain;
        private Panel panel1;
        private DevicePage devicePage1;
    }
}
