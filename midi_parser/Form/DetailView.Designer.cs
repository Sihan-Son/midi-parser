namespace midi_parser
{
    partial class DetailView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbDetailBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHistoDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDetailBody
            // 
            this.tbDetailBody.Location = new System.Drawing.Point(13, 30);
            this.tbDetailBody.Multiline = true;
            this.tbDetailBody.Name = "tbDetailBody";
            this.tbDetailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetailBody.Size = new System.Drawing.Size(272, 619);
            this.tbDetailBody.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parsing Detail";
            // 
            // chHistogram
            // 
            chartArea2.Name = "ChartArea1";
            this.chHistogram.ChartAreas.Add(chartArea2);
            this.chHistogram.Location = new System.Drawing.Point(291, 30);
            this.chHistogram.Name = "chHistogram";
            this.chHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chHistogram.Series.Add(series2);
            this.chHistogram.Size = new System.Drawing.Size(521, 300);
            this.chHistogram.TabIndex = 2;
            this.chHistogram.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Histogram";
            // 
            // tbHistoDetail
            // 
            this.tbHistoDetail.Location = new System.Drawing.Point(291, 356);
            this.tbHistoDetail.Multiline = true;
            this.tbHistoDetail.Name = "tbHistoDetail";
            this.tbHistoDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHistoDetail.Size = new System.Drawing.Size(205, 293);
            this.tbHistoDetail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Histogram detail";
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(502, 356);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(310, 293);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 6;
            this.pbImg.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 21);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHistoDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chHistogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDetailBody);
            this.Name = "DetailView";
            this.Text = "DetailView";
            this.Load += new System.EventHandler(this.DetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDetailBody;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHistogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHistoDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}