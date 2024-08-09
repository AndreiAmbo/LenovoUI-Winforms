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
            button1 = new Button();
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
            splitContainer.Size = new Size(1728, 864);
            splitContainer.SplitterDistance = 950;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.BackColor = Color.DarkSlateGray;
            leftTableLayout.ColumnCount = 5;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            leftTableLayout.Controls.Add(button1, 1, 0);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.ForeColor = SystemColors.Control;
            leftTableLayout.Location = new Point(50, 50);
            leftTableLayout.Margin = new Padding(0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.Padding = new Padding(40);
            leftTableLayout.RowCount = 6;
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            leftTableLayout.Size = new Size(850, 764);
            leftTableLayout.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(185, 70);
            button1.Margin = new Padding(30);
            button1.Name = "button1";
            button1.Size = new Size(248, 213);
            button1.TabIndex = 0;
            button1.Text = "CPU";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 864);
            Controls.Add(splitContainer);
            Name = "Form1";
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TableLayoutPanel leftTableLayout;
        private Button button1;
    }
}
