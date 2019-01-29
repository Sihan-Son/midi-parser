namespace midi_parser
{
    partial class Midi
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
            this.midiText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.fnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbPlayTime = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // midiText
            // 
            this.midiText.Location = new System.Drawing.Point(14, 82);
            this.midiText.Multiline = true;
            this.midiText.Name = "midiText";
            this.midiText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.midiText.Size = new System.Drawing.Size(259, 208);
            this.midiText.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(13, 13);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(178, 21);
            this.filePath.TabIndex = 2;
            // 
            // fnBtn
            // 
            this.fnBtn.Location = new System.Drawing.Point(198, 13);
            this.fnBtn.Name = "fnBtn";
            this.fnBtn.Size = new System.Drawing.Size(75, 23);
            this.fnBtn.TabIndex = 3;
            this.fnBtn.Text = "open";
            this.fnBtn.UseVisualStyleBackColor = true;
            this.fnBtn.Click += new System.EventHandler(this.fnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(80, 45);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(111, 21);
            this.fileName.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(198, 45);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(15, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 39);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(193, 347);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 39);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbPlayTime
            // 
            this.tbPlayTime.Location = new System.Drawing.Point(15, 296);
            this.tbPlayTime.Maximum = 100;
            this.tbPlayTime.Name = "tbPlayTime";
            this.tbPlayTime.Size = new System.Drawing.Size(258, 45);
            this.tbPlayTime.TabIndex = 9;
            this.tbPlayTime.TickFrequency = 0;
            this.tbPlayTime.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(101, 347);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(86, 39);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Midi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 390);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.tbPlayTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnBtn);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.midiText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Midi";
            this.Text = "MIDI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPlayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox midiText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button fnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar tbPlayTime;
        private System.Windows.Forms.Button btnPause;
    }
}