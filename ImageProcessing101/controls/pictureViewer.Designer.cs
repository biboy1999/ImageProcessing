namespace ImageProcessing101.controls
{
    partial class PictureViewer
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.picView = new System.Windows.Forms.PictureBox();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picB = new System.Windows.Forms.PictureBox();
            this.picG = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(5, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 12);
            this.lbTitle.TabIndex = 50;
            this.lbTitle.Text = "Original Image";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(375, 6);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(23, 12);
            this.lbSize.TabIndex = 52;
            this.lbSize.Text = "0x0";
            // 
            // picView
            // 
            this.picView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picView.Location = new System.Drawing.Point(0, 28);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(400, 400);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView.TabIndex = 51;
            this.picView.TabStop = false;
            // 
            // chartB
            // 
            this.chartB.BorderlineWidth = 0;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.Interval = 256D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Interval = 100D;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartB.ChartAreas.Add(chartArea1);
            this.chartB.Location = new System.Drawing.Point(269, 576);
            this.chartB.Name = "chartB";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.CustomProperties = "PointWidth=1";
            series1.Name = "B";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartB.Series.Add(series1);
            this.chartB.Size = new System.Drawing.Size(129, 110);
            this.chartB.TabIndex = 62;
            this.chartB.Text = "chart1";
            // 
            // chartR
            // 
            this.chartR.BorderlineWidth = 0;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.Interval = 256D;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX2.LineWidth = 0;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Interval = 100D;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY2.LineWidth = 0;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 0;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 100F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chartR.ChartAreas.Add(chartArea2);
            this.chartR.Location = new System.Drawing.Point(0, 577);
            this.chartR.Name = "chartR";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.CustomProperties = "PointWidth=1";
            series2.Name = "R";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chartR.Series.Add(series2);
            this.chartR.Size = new System.Drawing.Size(129, 110);
            this.chartR.TabIndex = 63;
            this.chartR.Text = "chart2";
            // 
            // chartG
            // 
            this.chartG.BorderlineWidth = 0;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX.Interval = 256D;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisX2.LineWidth = 0;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Interval = 100D;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisY2.LineWidth = 0;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.BorderWidth = 0;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 100F;
            chartArea3.InnerPlotPosition.Width = 100F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            this.chartG.ChartAreas.Add(chartArea3);
            this.chartG.Location = new System.Drawing.Point(132, 577);
            this.chartG.Name = "chartG";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Green;
            series3.CustomProperties = "PointWidth=1";
            series3.Name = "G";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.chartG.Series.Add(series3);
            this.chartG.Size = new System.Drawing.Size(131, 110);
            this.chartG.TabIndex = 64;
            this.chartG.Text = "chart3";
            // 
            // picB
            // 
            this.picB.BackColor = System.Drawing.Color.White;
            this.picB.Location = new System.Drawing.Point(271, 456);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(129, 110);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB.TabIndex = 70;
            this.picB.TabStop = false;
            // 
            // picG
            // 
            this.picG.BackColor = System.Drawing.Color.White;
            this.picG.Location = new System.Drawing.Point(136, 457);
            this.picG.Name = "picG";
            this.picG.Size = new System.Drawing.Size(129, 110);
            this.picG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picG.TabIndex = 69;
            this.picG.TabStop = false;
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.Color.White;
            this.picR.Location = new System.Drawing.Point(1, 457);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(129, 110);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picR.TabIndex = 68;
            this.picR.TabStop = false;
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picB);
            this.Controls.Add(this.picG);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.chartR);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.lbTitle);
            this.Name = "PictureViewer";
            this.Size = new System.Drawing.Size(401, 691);
            this.Load += new System.EventHandler(this.ViewComparer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.PictureBox picG;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.Label lbTitle;
    }
}
