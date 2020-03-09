namespace ImageProcessing101
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Panel panel4;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Panel panel5;
            System.Windows.Forms.Panel panel6;
            System.Windows.Forms.Panel panel7;
            System.Windows.Forms.Label label15;
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnBrighten = new System.Windows.Forms.Button();
            this.btnThresOtsu = new System.Windows.Forms.Button();
            this.btnGrayMaxium = new System.Windows.Forms.Button();
            this.btnGrayMeanValue = new System.Windows.Forms.Button();
            this.btnGrayMeanWeight = new System.Windows.Forms.Button();
            this.btnSegKMean = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtKValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.txtOriginalSize = new System.Windows.Forms.Label();
            this.picOriginalR = new System.Windows.Forms.PictureBox();
            this.picOriginalG = new System.Windows.Forms.PictureBox();
            this.picOriginalB = new System.Windows.Forms.PictureBox();
            this.picResultB = new System.Windows.Forms.PictureBox();
            this.picResultG = new System.Windows.Forms.PictureBox();
            this.picResultR = new System.Windows.Forms.PictureBox();
            this.txtResultSize = new System.Windows.Forms.Label();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtReWidth = new System.Windows.Forms.TextBox();
            this.txtReHeight = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSharpening = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLagarithmic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            label15 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 12);
            label1.TabIndex = 2;
            label1.Text = "Original Image";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 647);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 12);
            label5.TabIndex = 8;
            label5.Text = "Log Cat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(475, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 12);
            label4.TabIndex = 12;
            label4.Text = "Result Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(984, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 12);
            label2.TabIndex = 23;
            label2.Text = "Width:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(982, 157);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 12);
            label3.TabIndex = 24;
            label3.Text = "Height:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1143, 118);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 12);
            label6.TabIndex = 27;
            label6.Text = "pixels";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(1143, 157);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(32, 12);
            label7.TabIndex = 28;
            label7.Text = "pixels";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel1.Controls.Add(this.btnDarken);
            panel1.Controls.Add(this.btnBrighten);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(this.btnThresOtsu);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(this.btnGrayMaxium);
            panel1.Controls.Add(this.btnGrayMeanValue);
            panel1.Controls.Add(this.btnGrayMeanWeight);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(901, 200);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(261, 141);
            panel1.TabIndex = 30;
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(95, 112);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(75, 23);
            this.btnDarken.TabIndex = 42;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            // 
            // btnBrighten
            // 
            this.btnBrighten.Location = new System.Drawing.Point(14, 112);
            this.btnBrighten.Name = "btnBrighten";
            this.btnBrighten.Size = new System.Drawing.Size(75, 23);
            this.btnBrighten.TabIndex = 41;
            this.btnBrighten.Text = "Brighten";
            this.btnBrighten.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 97);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(54, 12);
            label10.TabIndex = 40;
            label10.Text = "Brightness";
            // 
            // btnThresOtsu
            // 
            this.btnThresOtsu.Location = new System.Drawing.Point(14, 71);
            this.btnThresOtsu.Name = "btnThresOtsu";
            this.btnThresOtsu.Size = new System.Drawing.Size(90, 23);
            this.btnThresOtsu.TabIndex = 39;
            this.btnThresOtsu.Text = "Otsu\'s method";
            this.btnThresOtsu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 56);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 12);
            label9.TabIndex = 38;
            label9.Text = "Thresholding";
            // 
            // btnGrayMaxium
            // 
            this.btnGrayMaxium.Location = new System.Drawing.Point(176, 27);
            this.btnGrayMaxium.Name = "btnGrayMaxium";
            this.btnGrayMaxium.Size = new System.Drawing.Size(75, 23);
            this.btnGrayMaxium.TabIndex = 37;
            this.btnGrayMaxium.Text = "Maxium";
            this.btnGrayMaxium.UseVisualStyleBackColor = true;
            // 
            // btnGrayMeanValue
            // 
            this.btnGrayMeanValue.Location = new System.Drawing.Point(95, 27);
            this.btnGrayMeanValue.Name = "btnGrayMeanValue";
            this.btnGrayMeanValue.Size = new System.Drawing.Size(75, 23);
            this.btnGrayMeanValue.TabIndex = 36;
            this.btnGrayMeanValue.Text = "Mean-Value";
            this.btnGrayMeanValue.UseVisualStyleBackColor = true;
            // 
            // btnGrayMeanWeight
            // 
            this.btnGrayMeanWeight.Location = new System.Drawing.Point(14, 27);
            this.btnGrayMeanWeight.Name = "btnGrayMeanWeight";
            this.btnGrayMeanWeight.Size = new System.Drawing.Size(75, 23);
            this.btnGrayMeanWeight.TabIndex = 35;
            this.btnGrayMeanWeight.Text = "Mean-Weight";
            this.btnGrayMeanWeight.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 12);
            label8.TabIndex = 25;
            label8.Text = "Grayscale";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LemonChiffon;
            panel2.Controls.Add(this.btnSegKMean);
            panel2.Controls.Add(this.textBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(this.txtKValue);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(1168, 200);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(261, 141);
            panel2.TabIndex = 31;
            // 
            // btnSegKMean
            // 
            this.btnSegKMean.Location = new System.Drawing.Point(16, 105);
            this.btnSegKMean.Name = "btnSegKMean";
            this.btnSegKMean.Size = new System.Drawing.Size(75, 23);
            this.btnSegKMean.TabIndex = 43;
            this.btnSegKMean.Text = "K Means";
            this.btnSegKMean.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(14, 71);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(79, 12);
            label13.TabIndex = 29;
            label13.Text = "Interation Level";
            // 
            // txtKValue
            // 
            this.txtKValue.Location = new System.Drawing.Point(99, 38);
            this.txtKValue.Name = "txtKValue";
            this.txtKValue.Size = new System.Drawing.Size(100, 22);
            this.txtKValue.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(50, 43);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(43, 12);
            label12.TabIndex = 27;
            label12.Text = "K Value";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(14, 12);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(68, 12);
            label11.TabIndex = 26;
            label11.Text = "Segmentation";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel3.Location = new System.Drawing.Point(1168, 347);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(261, 141);
            panel3.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.LemonChiffon;
            panel4.Controls.Add(this.btnLagarithmic);
            panel4.Controls.Add(this.btnNegative);
            panel4.Controls.Add(this.btnSharpening);
            panel4.Controls.Add(this.button1);
            panel4.Controls.Add(label14);
            panel4.Location = new System.Drawing.Point(901, 347);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(261, 141);
            panel4.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Histogram equalization";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(12, 12);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(44, 12);
            label14.TabIndex = 26;
            label14.Text = "Contrast";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.LemonChiffon;
            panel5.Location = new System.Drawing.Point(1168, 494);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(261, 141);
            panel5.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel6.Controls.Add(this.button6);
            panel6.Controls.Add(this.button5);
            panel6.Controls.Add(this.button4);
            panel6.Controls.Add(this.button3);
            panel6.Controls.Add(this.button2);
            panel6.Controls.Add(label15);
            panel6.Location = new System.Drawing.Point(901, 494);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(261, 141);
            panel6.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.LemonChiffon;
            panel7.Location = new System.Drawing.Point(901, 641);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(261, 141);
            panel7.TabIndex = 34;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(21, 26);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(122, 26);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picOriginal.Location = new System.Drawing.Point(31, 113);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(400, 400);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 3;
            this.picOriginal.TabStop = false;
            // 
            // txtOriginalSize
            // 
            this.txtOriginalSize.AutoSize = true;
            this.txtOriginalSize.Location = new System.Drawing.Point(397, 85);
            this.txtOriginalSize.Name = "txtOriginalSize";
            this.txtOriginalSize.Size = new System.Drawing.Size(23, 12);
            this.txtOriginalSize.TabIndex = 4;
            this.txtOriginalSize.Text = "0x0";
            // 
            // picOriginalR
            // 
            this.picOriginalR.BackColor = System.Drawing.Color.White;
            this.picOriginalR.Location = new System.Drawing.Point(31, 520);
            this.picOriginalR.Name = "picOriginalR";
            this.picOriginalR.Size = new System.Drawing.Size(129, 110);
            this.picOriginalR.TabIndex = 9;
            this.picOriginalR.TabStop = false;
            // 
            // picOriginalG
            // 
            this.picOriginalG.BackColor = System.Drawing.Color.White;
            this.picOriginalG.Location = new System.Drawing.Point(166, 519);
            this.picOriginalG.Name = "picOriginalG";
            this.picOriginalG.Size = new System.Drawing.Size(129, 110);
            this.picOriginalG.TabIndex = 10;
            this.picOriginalG.TabStop = false;
            // 
            // picOriginalB
            // 
            this.picOriginalB.BackColor = System.Drawing.Color.White;
            this.picOriginalB.Location = new System.Drawing.Point(301, 519);
            this.picOriginalB.Name = "picOriginalB";
            this.picOriginalB.Size = new System.Drawing.Size(129, 110);
            this.picOriginalB.TabIndex = 11;
            this.picOriginalB.TabStop = false;
            // 
            // picResultB
            // 
            this.picResultB.BackColor = System.Drawing.Color.White;
            this.picResultB.Location = new System.Drawing.Point(747, 519);
            this.picResultB.Name = "picResultB";
            this.picResultB.Size = new System.Drawing.Size(129, 110);
            this.picResultB.TabIndex = 17;
            this.picResultB.TabStop = false;
            // 
            // picResultG
            // 
            this.picResultG.BackColor = System.Drawing.Color.White;
            this.picResultG.Location = new System.Drawing.Point(612, 519);
            this.picResultG.Name = "picResultG";
            this.picResultG.Size = new System.Drawing.Size(129, 110);
            this.picResultG.TabIndex = 16;
            this.picResultG.TabStop = false;
            // 
            // picResultR
            // 
            this.picResultR.BackColor = System.Drawing.Color.White;
            this.picResultR.Location = new System.Drawing.Point(477, 520);
            this.picResultR.Name = "picResultR";
            this.picResultR.Size = new System.Drawing.Size(129, 110);
            this.picResultR.TabIndex = 15;
            this.picResultR.TabStop = false;
            // 
            // txtResultSize
            // 
            this.txtResultSize.AutoSize = true;
            this.txtResultSize.Location = new System.Drawing.Point(844, 85);
            this.txtResultSize.Name = "txtResultSize";
            this.txtResultSize.Size = new System.Drawing.Size(23, 12);
            this.txtResultSize.TabIndex = 14;
            this.txtResultSize.Text = "0x0";
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picResult.Location = new System.Drawing.Point(477, 113);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(400, 400);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 13;
            this.picResult.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 662);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(846, 105);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(801, 26);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 19;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(901, 113);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(75, 23);
            this.btnOrigin.TabIndex = 21;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(901, 152);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 22;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // txtReWidth
            // 
            this.txtReWidth.Location = new System.Drawing.Point(1028, 113);
            this.txtReWidth.Name = "txtReWidth";
            this.txtReWidth.Size = new System.Drawing.Size(100, 22);
            this.txtReWidth.TabIndex = 25;
            // 
            // txtReHeight
            // 
            this.txtReHeight.Location = new System.Drawing.Point(1028, 153);
            this.txtReHeight.Name = "txtReHeight";
            this.txtReHeight.Size = new System.Drawing.Size(100, 22);
            this.txtReHeight.TabIndex = 26;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(1194, 113);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 29;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // btnSharpening
            // 
            this.btnSharpening.Location = new System.Drawing.Point(14, 68);
            this.btnSharpening.Name = "btnSharpening";
            this.btnSharpening.Size = new System.Drawing.Size(75, 23);
            this.btnSharpening.TabIndex = 43;
            this.btnSharpening.Text = "Sharpening";
            this.btnSharpening.UseVisualStyleBackColor = true;
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(95, 68);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 23);
            this.btnNegative.TabIndex = 44;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            // 
            // btnLagarithmic
            // 
            this.btnLagarithmic.Location = new System.Drawing.Point(176, 68);
            this.btnLagarithmic.Name = "btnLagarithmic";
            this.btnLagarithmic.Size = new System.Drawing.Size(75, 23);
            this.btnLagarithmic.TabIndex = 45;
            this.btnLagarithmic.Text = "Logarithmic";
            this.btnLagarithmic.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(12, 7);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(62, 12);
            label15.TabIndex = 27;
            label15.Text = "Space Filiter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Median";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Mean";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Sol";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 47;
            this.button5.Text = "Sharpening";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "Sharpening";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 799);
            this.Controls.Add(panel7);
            this.Controls.Add(panel5);
            this.Controls.Add(panel3);
            this.Controls.Add(panel6);
            this.Controls.Add(panel2);
            this.Controls.Add(panel4);
            this.Controls.Add(panel1);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtReHeight);
            this.Controls.Add(this.txtReWidth);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnOrigin);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.picResultB);
            this.Controls.Add(this.picResultG);
            this.Controls.Add(this.picResultR);
            this.Controls.Add(this.txtResultSize);
            this.Controls.Add(this.picResult);
            this.Controls.Add(label4);
            this.Controls.Add(this.picOriginalB);
            this.Controls.Add(this.picOriginalG);
            this.Controls.Add(this.picOriginalR);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtOriginalSize);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnOpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label txtOriginalSize;
        private System.Windows.Forms.PictureBox picOriginalR;
        private System.Windows.Forms.PictureBox picOriginalG;
        private System.Windows.Forms.PictureBox picOriginalB;
        private System.Windows.Forms.PictureBox picResultB;
        private System.Windows.Forms.PictureBox picResultG;
        private System.Windows.Forms.PictureBox picResultR;
        private System.Windows.Forms.Label txtResultSize;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtReWidth;
        private System.Windows.Forms.TextBox txtReHeight;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnBrighten;
        private System.Windows.Forms.Button btnThresOtsu;
        private System.Windows.Forms.Button btnGrayMaxium;
        private System.Windows.Forms.Button btnGrayMeanValue;
        private System.Windows.Forms.Button btnGrayMeanWeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtKValue;
        private System.Windows.Forms.Button btnSegKMean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLagarithmic;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSharpening;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

