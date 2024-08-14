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
            panelMain = new Panel();
            panelLegion = new Panel();
            label1 = new Label();
            panelCPU = new Panel();
            layoutPanelCPU = new TableLayoutPanel();
            buttonCPU = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            layoutPanelLegionSlim.SuspendLayout();
            panelMain.SuspendLayout();
            panelLegion.SuspendLayout();
            panelCPU.SuspendLayout();
            layoutPanelCPU.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanelLegionSlim
            // 
            layoutPanelLegionSlim.BackColor = Color.DarkSlateGray;
            layoutPanelLegionSlim.ColumnCount = 5;
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            layoutPanelLegionSlim.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            layoutPanelLegionSlim.Controls.Add(buttonU, 4, 0);
            layoutPanelLegionSlim.Controls.Add(buttonSupport, 3, 0);
            layoutPanelLegionSlim.Controls.Add(buttonSecurity, 2, 0);
            layoutPanelLegionSlim.Controls.Add(buttonDevice, 1, 0);
            layoutPanelLegionSlim.Controls.Add(labelLegionSlim, 0, 0);
            layoutPanelLegionSlim.Dock = DockStyle.Top;
            layoutPanelLegionSlim.Location = new Point(0, 0);
            layoutPanelLegionSlim.Name = "layoutPanelLegionSlim";
            layoutPanelLegionSlim.RowCount = 1;
            layoutPanelLegionSlim.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPanelLegionSlim.Size = new Size(2246, 70);
            layoutPanelLegionSlim.TabIndex = 0;
            // 
            // buttonU
            // 
            buttonU.Dock = DockStyle.Fill;
            buttonU.FlatStyle = FlatStyle.Flat;
            buttonU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonU.ForeColor = SystemColors.Control;
            buttonU.Location = new Point(2091, 3);
            buttonU.Name = "buttonU";
            buttonU.Size = new Size(152, 64);
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
            buttonSupport.Location = new Point(1934, 3);
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Size = new Size(151, 64);
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
            buttonSecurity.Location = new Point(1777, 3);
            buttonSecurity.Name = "buttonSecurity";
            buttonSecurity.Size = new Size(151, 64);
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
            buttonDevice.Location = new Point(1620, 3);
            buttonDevice.Name = "buttonDevice";
            buttonDevice.Size = new Size(151, 64);
            buttonDevice.TabIndex = 0;
            buttonDevice.Text = "Device";
            buttonDevice.UseVisualStyleBackColor = true;
            // 
            // labelLegionSlim
            // 
            labelLegionSlim.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelLegionSlim.AutoSize = true;
            labelLegionSlim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLegionSlim.ForeColor = SystemColors.Control;
            labelLegionSlim.Location = new Point(3, 32);
            labelLegionSlim.Name = "labelLegionSlim";
            labelLegionSlim.Size = new Size(291, 38);
            labelLegionSlim.TabIndex = 0;
            labelLegionSlim.Text = "Legion Slim 5 16APH8";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = SystemColors.ControlDarkDark;
            panelMain.Controls.Add(panelLegion);
            panelMain.Controls.Add(panelCPU);
            panelMain.Dock = DockStyle.Top;
            panelMain.Location = new Point(0, 70);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(2246, 1187);
            panelMain.TabIndex = 1;
            // 
            // panelLegion
            // 
            panelLegion.BackColor = Color.LightSeaGreen;
            panelLegion.Controls.Add(label1);
            panelLegion.Dock = DockStyle.Top;
            panelLegion.Location = new Point(0, 0);
            panelLegion.Name = "panelLegion";
            panelLegion.Size = new Size(2246, 82);
            panelLegion.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(160, 54);
            label1.TabIndex = 1;
            label1.Text = "LEGION";
            // 
            // panelCPU
            // 
            panelCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelCPU.BackColor = Color.DarkSlateGray;
            panelCPU.BorderStyle = BorderStyle.Fixed3D;
            panelCPU.Controls.Add(layoutPanelCPU);
            panelCPU.Location = new Point(46, 80);
            panelCPU.Name = "panelCPU";
            panelCPU.Padding = new Padding(20);
            panelCPU.Size = new Size(1315, 544);
            panelCPU.TabIndex = 1;
            // 
            // layoutPanelCPU
            // 
            layoutPanelCPU.ColumnCount = 4;
            layoutPanelCPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelCPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutPanelCPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanelCPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            layoutPanelCPU.Controls.Add(buttonCPU, 1, 1);
            layoutPanelCPU.Controls.Add(button3, 2, 1);
            layoutPanelCPU.Controls.Add(button2, 3, 0);
            layoutPanelCPU.Controls.Add(button1, 0, 1);
            layoutPanelCPU.Dock = DockStyle.Fill;
            layoutPanelCPU.Location = new Point(20, 20);
            layoutPanelCPU.Name = "layoutPanelCPU";
            layoutPanelCPU.RowCount = 3;
            layoutPanelCPU.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            layoutPanelCPU.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            layoutPanelCPU.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            layoutPanelCPU.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutPanelCPU.Size = new Size(1271, 500);
            layoutPanelCPU.TabIndex = 0;
            // 
            // buttonCPU
            // 
            buttonCPU.Dock = DockStyle.Bottom;
            buttonCPU.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCPU.ForeColor = SystemColors.ControlText;
            buttonCPU.Location = new Point(277, 178);
            buttonCPU.Margin = new Padding(150, 0, 150, 0);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Size = new Size(335, 272);
            buttonCPU.TabIndex = 3;
            buttonCPU.Text = "CPU";
            buttonCPU.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(802, 90);
            button3.Margin = new Padding(40, 40, 40, 10);
            button3.Name = "button3";
            button3.Size = new Size(47, 350);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1156, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 44);
            button2.TabIndex = 1;
            button2.Text = "INFO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(40, 90);
            button1.Margin = new Padding(40, 40, 40, 10);
            button1.Name = "button1";
            button1.Size = new Size(47, 350);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(2272, 1187);
            Controls.Add(panelMain);
            Controls.Add(layoutPanelLegionSlim);
            MinimumSize = new Size(1743, 992);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LenovoUI";
            layoutPanelLegionSlim.ResumeLayout(false);
            layoutPanelLegionSlim.PerformLayout();
            panelMain.ResumeLayout(false);
            panelLegion.ResumeLayout(false);
            panelLegion.PerformLayout();
            panelCPU.ResumeLayout(false);
            layoutPanelCPU.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TableLayoutPanel layoutPanelLegionSlim;
        private Button buttonSecurity;
        private Label labelLegionSlim;
        private Button buttonDevice;
        private Button buttonSupport;
        private Button buttonU;
        private Panel panelMain;
        private Panel panelCPU;
        private Panel panelLegion;
        private Label label1;
        private TableLayoutPanel layoutPanelCPU;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button buttonCPU;
    }
}
