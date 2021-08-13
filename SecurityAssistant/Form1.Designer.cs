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
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(63, 83);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // bluetoothNameInput
            // 
            this.bluetoothNameInput.Location = new System.Drawing.Point(164, 37);
            this.bluetoothNameInput.Name = "bluetoothNameInput";
            this.bluetoothNameInput.Size = new System.Drawing.Size(129, 20);
            this.bluetoothNameInput.TabIndex = 2;
            // 
            // bLuetoothName
            // 
            this.bLuetoothName.AutoSize = true;
            this.bLuetoothName.Location = new System.Drawing.Point(60, 37);
            this.bLuetoothName.Name = "bLuetoothName";
            this.bLuetoothName.Size = new System.Drawing.Size(84, 13);
            this.bLuetoothName.TabIndex = 3;
            this.bLuetoothName.Text = "BLuetoothName";
            // 
            // ReadMe
            // 
            this.ReadMe.AutoSize = true;
            this.ReadMe.Location = new System.Drawing.Point(60, 136);
            this.ReadMe.Name = "ReadMe";
            this.ReadMe.Size = new System.Drawing.Size(386, 143);
            this.ReadMe.TabIndex = 4;
            this.ReadMe.Text = resources.GetString("ReadMe.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.ReadMe);
            this.Controls.Add(this.bLuetoothName);
            this.Controls.Add(this.bluetoothNameInput);
            this.Controls.Add(this.startButton);
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
    }
}

