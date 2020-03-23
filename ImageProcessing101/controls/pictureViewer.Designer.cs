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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
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
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX.Interval = 256D;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.LineWidth = 0;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX2.LineWidth = 0;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Interval = 100D;
            chartArea4.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisY.LineWidth = 0;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisY2.LineWidth = 0;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 0;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 100F;
            chartArea4.InnerPlotPosition.Width = 100F;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            chartArea4.ShadowColor = System.Drawing.Color.Transparent;
            this.chartB.ChartAreas.Add(chartArea4);
            this.chartB.Location = new System.Drawing.Point(269, 576);
            this.chartB.Name = "chartB";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Blue;
            series4.CustomProperties = "PointWidth=1";
            series4.Name = "B";
            series4.Points.Add(dataPoint7);
            series4.Points.Add(dataPoint8);
            this.chartB.Series.Add(series4);
            this.chartB.Size = new System.Drawing.Size(129, 110);
            this.chartB.TabIndex = 62;
            this.chartB.Text = "chart1";
            // 
            // chartR
            // 
            this.chartR.BorderlineWidth = 0;
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX.Interval = 256D;
            chartArea5.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea5.AxisX.LineWidth = 0;
            chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea5.AxisX2.LineWidth = 0;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.Interval = 100D;
            chartArea5.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea5.AxisY.LineWidth = 0;
            chartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea5.AxisY2.LineWidth = 0;
            chartArea5.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.BorderWidth = 0;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 100F;
            chartArea5.InnerPlotPosition.Width = 100F;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 100F;
            chartArea5.ShadowColor = System.Drawing.Color.Transparent;
            this.chartR.ChartAreas.Add(chartArea5);
            this.chartR.Location = new System.Drawing.Point(0, 577);
            this.chartR.Name = "chartR";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.BorderWidth = 0;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Red;
            series5.CustomProperties = "PointWidth=1";
            series5.Name = "R";
            series5.Points.Add(dataPoint9);
            series5.Points.Add(dataPoint10);
            this.chartR.Series.Add(series5);
            this.chartR.Size = new System.Drawing.Size(129, 110);
            this.chartR.TabIndex = 63;
            this.chartR.Text = "chart2";
            // 
            // chartG
            // 
            this.chartG.BorderlineWidth = 0;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX.Interval = 256D;
            chartArea6.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisX.LineWidth = 0;
            chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisX2.LineWidth = 0;
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.Interval = 100D;
            chartArea6.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisY.LineWidth = 0;
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea6.AxisY2.LineWidth = 0;
            chartArea6.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.BorderWidth = 0;
            chartArea6.InnerPlotPosition.Auto = false;
            chartArea6.InnerPlotPosition.Height = 100F;
            chartArea6.InnerPlotPosition.Width = 100F;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            chartArea6.ShadowColor = System.Drawing.Color.Transparent;
            this.chartG.ChartAreas.Add(chartArea6);
            this.chartG.Location = new System.Drawing.Point(132, 577);
            this.chartG.Name = "chartG";
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series6.BorderWidth = 0;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Green;
            series6.CustomProperties = "PointWidth=1";
            series6.Name = "G";
            series6.Points.Add(dataPoint11);
            series6.Points.Add(dataPoint12);
            this.chartG.Series.Add(series6);
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
