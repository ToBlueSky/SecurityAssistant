namespace SecurityAssistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.bluetoothNameInput = new System.Windows.Forms.TextBox();
            this.bLuetoothName = new System.Windows.Forms.Label();
            this.ReadMe = new System.Windows.Forms.Label();
            this.ConnectStatusLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.RunningStatusLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(64, 83);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // bluetoothNameInput
            // 
            this.bluetoothNameInput.Location = new System.Drawing.Point(241, 38);
            this.bluetoothNameInput.Name = "bluetoothNameInput";
            this.bluetoothNameInput.Size = new System.Drawing.Size(253, 20);
            this.bluetoothNameInput.TabIndex = 2;
            // 
            // bLuetoothName
            // 
            this.bLuetoothName.AutoSize = true;
            this.bLuetoothName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLuetoothName.Location = new System.Drawing.Point(60, 37);
            this.bLuetoothName.Name = "bLuetoothName";
            this.bLuetoothName.Size = new System.Drawing.Size(135, 21);
            this.bLuetoothName.TabIndex = 3;
            this.bLuetoothName.Text = "BLuetoothName";
            // 
            // ReadMe
            // 
            this.ReadMe.AutoSize = true;
            this.ReadMe.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadMe.Location = new System.Drawing.Point(60, 177);
            this.ReadMe.Name = "ReadMe";
            this.ReadMe.Size = new System.Drawing.Size(627, 231);
            this.ReadMe.TabIndex = 4;
            this.ReadMe.Text = resources.GetString("ReadMe.Text");
            // 
            // ConnectStatusLabel
            // 
            this.ConnectStatusLabel.AutoSize = true;
            this.ConnectStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectStatusLabel.Location = new System.Drawing.Point(270, 91);
            this.ConnectStatusLabel.Name = "ConnectStatusLabel";
            this.ConnectStatusLabel.Size = new System.Drawing.Size(121, 21);
            this.ConnectStatusLabel.TabIndex = 5;
            this.ConnectStatusLabel.Text = "ConnectStatus";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(168, 83);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 37);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RunningStatusLabel
            // 
            this.RunningStatusLabel.AutoSize = true;
            this.RunningStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningStatusLabel.Location = new System.Drawing.Point(420, 91);
            this.RunningStatusLabel.Name = "RunningStatusLabel";
            this.RunningStatusLabel.Size = new System.Drawing.Size(121, 21);
            this.RunningStatusLabel.TabIndex = 7;
            this.RunningStatusLabel.Text = "RunningStatus";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(486, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(237, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ToBlueSky/SecurityAssistant";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 440);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RunningStatusLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ConnectStatusLabel);
            this.Controls.Add(this.ReadMe);
            this.Controls.Add(this.bLuetoothName);
            this.Controls.Add(this.bluetoothNameInput);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SecurityAssistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox bluetoothNameInput;
        private System.Windows.Forms.Label bLuetoothName;
        private System.Windows.Forms.Label ReadMe;
        public System.Windows.Forms.Label ConnectStatusLabel;
        private System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.Label RunningStatusLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

