namespace IIS_Mover
{
    partial class IISMoverMainWindow
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
            this.FunctionListBox = new System.Windows.Forms.ListBox();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.processButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.upBotton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.copyCompressGroupBox = new System.Windows.Forms.GroupBox();
            this.apiGroupBox = new System.Windows.Forms.GroupBox();
            this.apiCallTextBox = new System.Windows.Forms.TextBox();
            this.CallText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apiTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.apiListBox = new System.Windows.Forms.ListBox();
            this.taskDeleteButton = new System.Windows.Forms.Button();
            this.waitGroupBox = new System.Windows.Forms.GroupBox();
            this.waitMessageTextBox = new System.Windows.Forms.TextBox();
            this.waitTimeOutTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appPoolListBox = new System.Windows.Forms.ListBox();
            this.appPoolGroupBox = new System.Windows.Forms.GroupBox();
            this.apiActionGroupBox = new System.Windows.Forms.GroupBox();
            this.appPoolStopRB = new System.Windows.Forms.RadioButton();
            this.appPoolStartRB = new System.Windows.Forms.RadioButton();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.copyCompressGroupBox.SuspendLayout();
            this.apiGroupBox.SuspendLayout();
            this.waitGroupBox.SuspendLayout();
            this.appPoolGroupBox.SuspendLayout();
            this.apiActionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionListBox
            // 
            this.FunctionListBox.FormattingEnabled = true;
            this.FunctionListBox.Location = new System.Drawing.Point(12, 12);
            this.FunctionListBox.Name = "FunctionListBox";
            this.FunctionListBox.Size = new System.Drawing.Size(75, 69);
            this.FunctionListBox.TabIndex = 1;
            this.FunctionListBox.SelectedIndexChanged += new System.EventHandler(this.FunctionListBox_SelectedIndexChanged);
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(392, 12);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(162, 186);
            this.taskListBox.TabIndex = 2;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskListBox_SelectedIndexChanged);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(12, 87);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 117);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 147);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 177);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 207);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // upBotton
            // 
            this.upBotton.Location = new System.Drawing.Point(392, 207);
            this.upBotton.Name = "upBotton";
            this.upBotton.Size = new System.Drawing.Size(50, 23);
            this.upBotton.TabIndex = 8;
            this.upBotton.Text = "Up";
            this.upBotton.UseVisualStyleBackColor = true;
            this.upBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(448, 207);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(50, 23);
            this.downButton.TabIndex = 9;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(6, 19);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 23);
            this.sourceButton.TabIndex = 10;
            this.sourceButton.Text = "Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click_1);
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(6, 44);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(75, 23);
            this.targetButton.TabIndex = 11;
            this.targetButton.Text = "Target";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(88, 19);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(200, 20);
            this.sourceTextBox.TabIndex = 12;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(88, 44);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(200, 20);
            this.targetTextBox.TabIndex = 13;
            // 
            // copyCompressGroupBox
            // 
            this.copyCompressGroupBox.Controls.Add(this.sourceButton);
            this.copyCompressGroupBox.Controls.Add(this.targetTextBox);
            this.copyCompressGroupBox.Controls.Add(this.targetButton);
            this.copyCompressGroupBox.Controls.Add(this.sourceTextBox);
            this.copyCompressGroupBox.Location = new System.Drawing.Point(93, 12);
            this.copyCompressGroupBox.Name = "copyCompressGroupBox";
            this.copyCompressGroupBox.Size = new System.Drawing.Size(293, 78);
            this.copyCompressGroupBox.TabIndex = 14;
            this.copyCompressGroupBox.TabStop = false;
            this.copyCompressGroupBox.Text = "Copy/Compress";
            this.copyCompressGroupBox.Enter += new System.EventHandler(this.copyCompressGroupBox_Enter);
            // 
            // apiGroupBox
            // 
            this.apiGroupBox.Controls.Add(this.apiCallTextBox);
            this.apiGroupBox.Controls.Add(this.CallText);
            this.apiGroupBox.Controls.Add(this.label1);
            this.apiGroupBox.Controls.Add(this.apiTimeoutTextBox);
            this.apiGroupBox.Controls.Add(this.apiListBox);
            this.apiGroupBox.Enabled = false;
            this.apiGroupBox.Location = new System.Drawing.Point(93, 12);
            this.apiGroupBox.Name = "apiGroupBox";
            this.apiGroupBox.Size = new System.Drawing.Size(293, 104);
            this.apiGroupBox.TabIndex = 15;
            this.apiGroupBox.TabStop = false;
            this.apiGroupBox.Text = "API Call";
            // 
            // apiCallTextBox
            // 
            this.apiCallTextBox.Location = new System.Drawing.Point(91, 72);
            this.apiCallTextBox.Name = "apiCallTextBox";
            this.apiCallTextBox.Size = new System.Drawing.Size(191, 20);
            this.apiCallTextBox.TabIndex = 20;
            this.apiCallTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CallText
            // 
            this.CallText.AutoSize = true;
            this.CallText.Location = new System.Drawing.Point(147, 51);
            this.CallText.Name = "CallText";
            this.CallText.Size = new System.Drawing.Size(48, 13);
            this.CallText.TabIndex = 19;
            this.CallText.Text = "Call Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Timeout in Seconds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // apiTimeoutTextBox
            // 
            this.apiTimeoutTextBox.Location = new System.Drawing.Point(195, 17);
            this.apiTimeoutTextBox.Name = "apiTimeoutTextBox";
            this.apiTimeoutTextBox.Size = new System.Drawing.Size(87, 20);
            this.apiTimeoutTextBox.TabIndex = 17;
            // 
            // apiListBox
            // 
            this.apiListBox.FormattingEnabled = true;
            this.apiListBox.Location = new System.Drawing.Point(6, 19);
            this.apiListBox.Name = "apiListBox";
            this.apiListBox.Size = new System.Drawing.Size(75, 82);
            this.apiListBox.TabIndex = 16;
            this.apiListBox.SelectedIndexChanged += new System.EventHandler(this.apiListBox_SelectedIndexChanged);
            // 
            // taskDeleteButton
            // 
            this.taskDeleteButton.Location = new System.Drawing.Point(504, 207);
            this.taskDeleteButton.Name = "taskDeleteButton";
            this.taskDeleteButton.Size = new System.Drawing.Size(50, 23);
            this.taskDeleteButton.TabIndex = 16;
            this.taskDeleteButton.Text = "Delete";
            this.taskDeleteButton.UseVisualStyleBackColor = true;
            this.taskDeleteButton.Click += new System.EventHandler(this.taskDeleteButton_Click);
            // 
            // waitGroupBox
            // 
            this.waitGroupBox.Controls.Add(this.waitMessageTextBox);
            this.waitGroupBox.Controls.Add(this.waitTimeOutTextBox);
            this.waitGroupBox.Controls.Add(this.label3);
            this.waitGroupBox.Controls.Add(this.label2);
            this.waitGroupBox.Location = new System.Drawing.Point(93, 12);
            this.waitGroupBox.Name = "waitGroupBox";
            this.waitGroupBox.Size = new System.Drawing.Size(293, 100);
            this.waitGroupBox.TabIndex = 17;
            this.waitGroupBox.TabStop = false;
            this.waitGroupBox.Text = "Wait";
            // 
            // waitMessageTextBox
            // 
            this.waitMessageTextBox.Location = new System.Drawing.Point(97, 44);
            this.waitMessageTextBox.Name = "waitMessageTextBox";
            this.waitMessageTextBox.Size = new System.Drawing.Size(185, 20);
            this.waitMessageTextBox.TabIndex = 3;
            this.waitMessageTextBox.TextChanged += new System.EventHandler(this.waitMessageTextBox_TextChanged);
            // 
            // waitTimeOutTextBox
            // 
            this.waitTimeOutTextBox.Location = new System.Drawing.Point(97, 17);
            this.waitTimeOutTextBox.Name = "waitTimeOutTextBox";
            this.waitTimeOutTextBox.Size = new System.Drawing.Size(75, 20);
            this.waitTimeOutTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text to display";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wait in Seconds";
            // 
            // appPoolListBox
            // 
            this.appPoolListBox.FormattingEnabled = true;
            this.appPoolListBox.Location = new System.Drawing.Point(13, 19);
            this.appPoolListBox.Name = "appPoolListBox";
            this.appPoolListBox.Size = new System.Drawing.Size(182, 69);
            this.appPoolListBox.TabIndex = 18;
            this.appPoolListBox.SelectedIndexChanged += new System.EventHandler(this.appPoolListBox_SelectedIndexChanged);
            // 
            // appPoolGroupBox
            // 
            this.appPoolGroupBox.Controls.Add(this.apiActionGroupBox);
            this.appPoolGroupBox.Controls.Add(this.appPoolListBox);
            this.appPoolGroupBox.Location = new System.Drawing.Point(93, 12);
            this.appPoolGroupBox.Name = "appPoolGroupBox";
            this.appPoolGroupBox.Size = new System.Drawing.Size(293, 100);
            this.appPoolGroupBox.TabIndex = 19;
            this.appPoolGroupBox.TabStop = false;
            this.appPoolGroupBox.Text = "App Pool";
            // 
            // apiActionGroupBox
            // 
            this.apiActionGroupBox.Controls.Add(this.appPoolStopRB);
            this.apiActionGroupBox.Controls.Add(this.appPoolStartRB);
            this.apiActionGroupBox.Location = new System.Drawing.Point(206, 19);
            this.apiActionGroupBox.Name = "apiActionGroupBox";
            this.apiActionGroupBox.Size = new System.Drawing.Size(76, 67);
            this.apiActionGroupBox.TabIndex = 20;
            this.apiActionGroupBox.TabStop = false;
            this.apiActionGroupBox.Text = "Action";
            this.apiActionGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // appPoolStopRB
            // 
            this.appPoolStopRB.AutoSize = true;
            this.appPoolStopRB.Location = new System.Drawing.Point(6, 42);
            this.appPoolStopRB.Name = "appPoolStopRB";
            this.appPoolStopRB.Size = new System.Drawing.Size(47, 17);
            this.appPoolStopRB.TabIndex = 21;
            this.appPoolStopRB.TabStop = true;
            this.appPoolStopRB.Text = "Stop";
            this.appPoolStopRB.UseVisualStyleBackColor = true;
            this.appPoolStopRB.CheckedChanged += new System.EventHandler(this.appPoolStopRB_CheckedChanged);
            // 
            // appPoolStartRB
            // 
            this.appPoolStartRB.AutoSize = true;
            this.appPoolStartRB.Location = new System.Drawing.Point(6, 19);
            this.appPoolStartRB.Name = "appPoolStartRB";
            this.appPoolStartRB.Size = new System.Drawing.Size(47, 17);
            this.appPoolStartRB.TabIndex = 21;
            this.appPoolStartRB.TabStop = true;
            this.appPoolStartRB.Text = "Start";
            this.appPoolStartRB.UseVisualStyleBackColor = true;
            this.appPoolStartRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(94, 122);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(292, 108);
            this.resultsTextBox.TabIndex = 20;
            this.resultsTextBox.Text = "";
            this.resultsTextBox.TextChanged += new System.EventHandler(this.resultsTextBox_TextChanged);
            // 
            // IISMoverMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(564, 237);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.taskDeleteButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upBotton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.FunctionListBox);
            this.Controls.Add(this.apiGroupBox);
            this.Controls.Add(this.copyCompressGroupBox);
            this.Controls.Add(this.appPoolGroupBox);
            this.Controls.Add(this.waitGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IISMoverMainWindow";
            this.Text = "IIS Mover";
            this.copyCompressGroupBox.ResumeLayout(false);
            this.copyCompressGroupBox.PerformLayout();
            this.apiGroupBox.ResumeLayout(false);
            this.apiGroupBox.PerformLayout();
            this.waitGroupBox.ResumeLayout(false);
            this.waitGroupBox.PerformLayout();
            this.appPoolGroupBox.ResumeLayout(false);
            this.apiActionGroupBox.ResumeLayout(false);
            this.apiActionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FunctionListBox;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button upBotton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.GroupBox copyCompressGroupBox;
        private System.Windows.Forms.GroupBox apiGroupBox;
        private System.Windows.Forms.ListBox apiListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiTimeoutTextBox;
        private System.Windows.Forms.Button taskDeleteButton;
        private System.Windows.Forms.TextBox apiCallTextBox;
        private System.Windows.Forms.Label CallText;
        private System.Windows.Forms.GroupBox waitGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox waitMessageTextBox;
        private System.Windows.Forms.TextBox waitTimeOutTextBox;
        private System.Windows.Forms.ListBox appPoolListBox;
        private System.Windows.Forms.GroupBox appPoolGroupBox;
        private System.Windows.Forms.GroupBox apiActionGroupBox;
        private System.Windows.Forms.RadioButton appPoolStartRB;
        private System.Windows.Forms.RadioButton appPoolStopRB;
        private System.Windows.Forms.RichTextBox resultsTextBox;
    }
}

