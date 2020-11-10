namespace WindowsApplication
{
    partial class MainForm
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UpperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UpperLeftGroupBox = new System.Windows.Forms.GroupBox();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperRightGroupBox = new System.Windows.Forms.GroupBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LowerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GoogleAPIGroupBox = new System.Windows.Forms.GroupBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.APIKeyTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RouteListView = new System.Windows.Forms.ListView();
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Instruction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainTableLayoutPanel.SuspendLayout();
            this.UpperTableLayoutPanel.SuspendLayout();
            this.UpperLeftGroupBox.SuspendLayout();
            this.UpperRightGroupBox.SuspendLayout();
            this.LowerTableLayoutPanel.SuspendLayout();
            this.GoogleAPIGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Location = new System.Drawing.Point(0, 517);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusBar.Size = new System.Drawing.Size(1300, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "MainStatusBar";
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.UpperTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.LowerTableLayoutPanel, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1300, 517);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // UpperTableLayoutPanel
            // 
            this.UpperTableLayoutPanel.ColumnCount = 2;
            this.UpperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperTableLayoutPanel.Controls.Add(this.UpperLeftGroupBox, 0, 0);
            this.UpperTableLayoutPanel.Controls.Add(this.UpperRightGroupBox, 1, 0);
            this.UpperTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.UpperTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpperTableLayoutPanel.Name = "UpperTableLayoutPanel";
            this.UpperTableLayoutPanel.RowCount = 1;
            this.UpperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperTableLayoutPanel.Size = new System.Drawing.Size(1292, 242);
            this.UpperTableLayoutPanel.TabIndex = 0;
            // 
            // UpperLeftGroupBox
            // 
            this.UpperLeftGroupBox.Controls.Add(this.ZTextBox);
            this.UpperLeftGroupBox.Controls.Add(this.YTextBox);
            this.UpperLeftGroupBox.Controls.Add(this.XTextBox);
            this.UpperLeftGroupBox.Controls.Add(this.label4);
            this.UpperLeftGroupBox.Controls.Add(this.label3);
            this.UpperLeftGroupBox.Controls.Add(this.label2);
            this.UpperLeftGroupBox.Controls.Add(this.label1);
            this.UpperLeftGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperLeftGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperLeftGroupBox.Location = new System.Drawing.Point(4, 4);
            this.UpperLeftGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperLeftGroupBox.Name = "UpperLeftGroupBox";
            this.UpperLeftGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UpperLeftGroupBox.Size = new System.Drawing.Size(638, 234);
            this.UpperLeftGroupBox.TabIndex = 0;
            this.UpperLeftGroupBox.TabStop = false;
            this.UpperLeftGroupBox.Text = "XYZ Problem";
            // 
            // ZTextBox
            // 
            this.ZTextBox.Enabled = false;
            this.ZTextBox.Location = new System.Drawing.Point(276, 187);
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.Size = new System.Drawing.Size(100, 26);
            this.ZTextBox.TabIndex = 6;
            this.ZTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YTextBox
            // 
            this.YTextBox.Enabled = false;
            this.YTextBox.Location = new System.Drawing.Point(277, 146);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 26);
            this.YTextBox.TabIndex = 5;
            this.YTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XTextBox
            // 
            this.XTextBox.Enabled = false;
            this.XTextBox.Location = new System.Drawing.Point(278, 102);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 26);
            this.XTextBox.TabIndex = 4;
            this.XTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Z :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X, Y, 5, 9, 15, 23, Z - Please create a new function for finding X, Y, Z value";
            // 
            // UpperRightGroupBox
            // 
            this.UpperRightGroupBox.Controls.Add(this.CTextBox);
            this.UpperRightGroupBox.Controls.Add(this.BTextBox);
            this.UpperRightGroupBox.Controls.Add(this.label8);
            this.UpperRightGroupBox.Controls.Add(this.label7);
            this.UpperRightGroupBox.Controls.Add(this.label6);
            this.UpperRightGroupBox.Controls.Add(this.label5);
            this.UpperRightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperRightGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperRightGroupBox.Location = new System.Drawing.Point(650, 4);
            this.UpperRightGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperRightGroupBox.Name = "UpperRightGroupBox";
            this.UpperRightGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UpperRightGroupBox.Size = new System.Drawing.Size(638, 234);
            this.UpperRightGroupBox.TabIndex = 1;
            this.UpperRightGroupBox.TabStop = false;
            this.UpperRightGroupBox.Text = "BC Problem";
            // 
            // CTextBox
            // 
            this.CTextBox.Enabled = false;
            this.CTextBox.Location = new System.Drawing.Point(279, 184);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(100, 26);
            this.CTextBox.TabIndex = 5;
            this.CTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTextBox
            // 
            this.BTextBox.Enabled = false;
            this.BTextBox.Location = new System.Drawing.Point(279, 133);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(100, 26);
            this.BTextBox.TabIndex = 4;
            this.BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "C :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "B :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Please create a new function for finding B and C value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "If A = 21, A + B = 23, A + C = -21";
            // 
            // LowerTableLayoutPanel
            // 
            this.LowerTableLayoutPanel.ColumnCount = 1;
            this.LowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LowerTableLayoutPanel.Controls.Add(this.GoogleAPIGroupBox, 0, 0);
            this.LowerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerTableLayoutPanel.Location = new System.Drawing.Point(4, 254);
            this.LowerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LowerTableLayoutPanel.Name = "LowerTableLayoutPanel";
            this.LowerTableLayoutPanel.RowCount = 1;
            this.LowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LowerTableLayoutPanel.Size = new System.Drawing.Size(1292, 259);
            this.LowerTableLayoutPanel.TabIndex = 1;
            // 
            // GoogleAPIGroupBox
            // 
            this.GoogleAPIGroupBox.Controls.Add(this.GetButton);
            this.GoogleAPIGroupBox.Controls.Add(this.APIKeyTextBox);
            this.GoogleAPIGroupBox.Controls.Add(this.label9);
            this.GoogleAPIGroupBox.Controls.Add(this.RouteListView);
            this.GoogleAPIGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoogleAPIGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleAPIGroupBox.Location = new System.Drawing.Point(3, 3);
            this.GoogleAPIGroupBox.Name = "GoogleAPIGroupBox";
            this.GoogleAPIGroupBox.Size = new System.Drawing.Size(1286, 253);
            this.GoogleAPIGroupBox.TabIndex = 0;
            this.GoogleAPIGroupBox.TabStop = false;
            this.GoogleAPIGroupBox.Text = "Google API finding best route from SCG to Central World";
            // 
            // GetButton
            // 
            this.GetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetButton.Location = new System.Drawing.Point(1205, 27);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 28);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // APIKeyTextBox
            // 
            this.APIKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APIKeyTextBox.Location = new System.Drawing.Point(80, 28);
            this.APIKeyTextBox.Name = "APIKeyTextBox";
            this.APIKeyTextBox.Size = new System.Drawing.Size(1119, 26);
            this.APIKeyTextBox.TabIndex = 2;
            this.APIKeyTextBox.Text = "...enter your Google API Key...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "API Key";
            // 
            // RouteListView
            // 
            this.RouteListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteListView.AutoArrange = false;
            this.RouteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Direction,
            this.Instruction,
            this.Distance});
            this.RouteListView.HideSelection = false;
            this.RouteListView.Location = new System.Drawing.Point(6, 67);
            this.RouteListView.MultiSelect = false;
            this.RouteListView.Name = "RouteListView";
            this.RouteListView.Size = new System.Drawing.Size(1274, 180);
            this.RouteListView.TabIndex = 0;
            this.RouteListView.UseCompatibleStateImageBehavior = false;
            this.RouteListView.View = System.Windows.Forms.View.Details;
            // 
            // Direction
            // 
            this.Direction.Text = "Direction";
            this.Direction.Width = 174;
            // 
            // Instruction
            // 
            this.Instruction.Text = "Instruction";
            this.Instruction.Width = 950;
            // 
            // Distance
            // 
            this.Distance.Text = "Distance";
            this.Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 539);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.StatusBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG Digital Office - Technology Developer Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.UpperTableLayoutPanel.ResumeLayout(false);
            this.UpperLeftGroupBox.ResumeLayout(false);
            this.UpperLeftGroupBox.PerformLayout();
            this.UpperRightGroupBox.ResumeLayout(false);
            this.UpperRightGroupBox.PerformLayout();
            this.LowerTableLayoutPanel.ResumeLayout(false);
            this.GoogleAPIGroupBox.ResumeLayout(false);
            this.GoogleAPIGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel UpperTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LowerTableLayoutPanel;
        private System.Windows.Forms.GroupBox UpperLeftGroupBox;
        private System.Windows.Forms.GroupBox UpperRightGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GoogleAPIGroupBox;
        private System.Windows.Forms.ListView RouteListView;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.ColumnHeader Instruction;
        private System.Windows.Forms.ColumnHeader Distance;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox APIKeyTextBox;
        private System.Windows.Forms.Label label9;
    }
}

