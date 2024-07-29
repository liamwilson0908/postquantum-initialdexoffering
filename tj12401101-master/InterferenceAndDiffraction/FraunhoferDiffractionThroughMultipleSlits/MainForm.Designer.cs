namespace FraunhoferDiffractionThroughMultipleSlits
{
    partial class MainForm
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
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonStartDrawing = new System.Windows.Forms.Button();
            this.textBoxOfA0 = new System.Windows.Forms.TextBox();
            this.textBoxOfa = new System.Windows.Forms.TextBox();
            this.textBoxOfN = new System.Windows.Forms.TextBox();
            this.textBoxOfLambda = new System.Windows.Forms.TextBox();
            this.textBoxOfb = new System.Windows.Forms.TextBox();
            this.labelOfA0 = new System.Windows.Forms.Label();
            this.labelOfa = new System.Windows.Forms.Label();
            this.labelOfN = new System.Windows.Forms.Label();
            this.labelOfb = new System.Windows.Forms.Label();
            this.labelOfLambda = new System.Windows.Forms.Label();
            this.labelForPrompt = new System.Windows.Forms.Label();
            this.panelOfChart = new System.Windows.Forms.Panel();
            this.textBoxOfStart = new System.Windows.Forms.TextBox();
            this.labelOfStart = new System.Windows.Forms.Label();
            this.textBoxOfEnd = new System.Windows.Forms.TextBox();
            this.labelOfEnd = new System.Windows.Forms.Label();
            this.textBoxOfUpper = new System.Windows.Forms.TextBox();
            this.labelOfUpper = new System.Windows.Forms.Label();
            this.textBoxOfLower = new System.Windows.Forms.TextBox();
            this.labelOfLower = new System.Windows.Forms.Label();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.labelOfStepCount = new System.Windows.Forms.Label();
            this.textBoxOfStepCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "图像文件|*.png";
            // 
            // buttonStartDrawing
            // 
            this.buttonStartDrawing.Location = new System.Drawing.Point(88, 337);
            this.buttonStartDrawing.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartDrawing.Name = "buttonStartDrawing";
            this.buttonStartDrawing.Size = new System.Drawing.Size(107, 28);
            this.buttonStartDrawing.TabIndex = 0;
            this.buttonStartDrawing.Text = "绘制";
            this.buttonStartDrawing.UseVisualStyleBackColor = true;
            this.buttonStartDrawing.Click += new System.EventHandler(this.ButtonStartDrawingClick);
            // 
            // textBoxOfA0
            // 
            this.textBoxOfA0.Location = new System.Drawing.Point(88, 15);
            this.textBoxOfA0.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfA0.Name = "textBoxOfA0";
            this.textBoxOfA0.Size = new System.Drawing.Size(258, 28);
            this.textBoxOfA0.TabIndex = 2;
            this.textBoxOfA0.Text = "1";
            // 
            // textBoxOfa
            // 
            this.textBoxOfa.Location = new System.Drawing.Point(88, 51);
            this.textBoxOfa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfa.Name = "textBoxOfa";
            this.textBoxOfa.Size = new System.Drawing.Size(258, 28);
            this.textBoxOfa.TabIndex = 3;
            this.textBoxOfa.Text = "0.2E-6";
            // 
            // textBoxOfN
            // 
            this.textBoxOfN.Location = new System.Drawing.Point(88, 86);
            this.textBoxOfN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfN.Name = "textBoxOfN";
            this.textBoxOfN.Size = new System.Drawing.Size(258, 28);
            this.textBoxOfN.TabIndex = 4;
            this.textBoxOfN.Text = "8";
            // 
            // textBoxOfLambda
            // 
            this.textBoxOfLambda.Location = new System.Drawing.Point(88, 158);
            this.textBoxOfLambda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfLambda.Name = "textBoxOfLambda";
            this.textBoxOfLambda.Size = new System.Drawing.Size(258, 28);
            this.textBoxOfLambda.TabIndex = 5;
            this.textBoxOfLambda.Text = "600E-9";
            // 
            // textBoxOfb
            // 
            this.textBoxOfb.Location = new System.Drawing.Point(88, 122);
            this.textBoxOfb.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfb.Name = "textBoxOfb";
            this.textBoxOfb.Size = new System.Drawing.Size(258, 28);
            this.textBoxOfb.TabIndex = 6;
            this.textBoxOfb.Text = "0.3E-6";
            // 
            // labelOfA0
            // 
            this.labelOfA0.AutoSize = true;
            this.labelOfA0.Location = new System.Drawing.Point(50, 18);
            this.labelOfA0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfA0.Name = "labelOfA0";
            this.labelOfA0.Size = new System.Drawing.Size(30, 21);
            this.labelOfA0.TabIndex = 7;
            this.labelOfA0.Text = "A0";
            // 
            // labelOfa
            // 
            this.labelOfa.AutoSize = true;
            this.labelOfa.Location = new System.Drawing.Point(61, 54);
            this.labelOfa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfa.Name = "labelOfa";
            this.labelOfa.Size = new System.Drawing.Size(19, 21);
            this.labelOfa.TabIndex = 8;
            this.labelOfa.Text = "a";
            // 
            // labelOfN
            // 
            this.labelOfN.AutoSize = true;
            this.labelOfN.Location = new System.Drawing.Point(57, 89);
            this.labelOfN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfN.Name = "labelOfN";
            this.labelOfN.Size = new System.Drawing.Size(23, 21);
            this.labelOfN.TabIndex = 9;
            this.labelOfN.Text = "N";
            // 
            // labelOfb
            // 
            this.labelOfb.AutoSize = true;
            this.labelOfb.Location = new System.Drawing.Point(60, 125);
            this.labelOfb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfb.Name = "labelOfb";
            this.labelOfb.Size = new System.Drawing.Size(20, 21);
            this.labelOfb.TabIndex = 10;
            this.labelOfb.Text = "b";
            // 
            // labelOfLambda
            // 
            this.labelOfLambda.AutoSize = true;
            this.labelOfLambda.Location = new System.Drawing.Point(13, 161);
            this.labelOfLambda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfLambda.Name = "labelOfLambda";
            this.labelOfLambda.Size = new System.Drawing.Size(67, 21);
            this.labelOfLambda.TabIndex = 11;
            this.labelOfLambda.Text = "lambda";
            // 
            // labelForPrompt
            // 
            this.labelForPrompt.AutoSize = true;
            this.labelForPrompt.ForeColor = System.Drawing.Color.IndianRed;
            this.labelForPrompt.Location = new System.Drawing.Point(88, 369);
            this.labelForPrompt.Name = "labelForPrompt";
            this.labelForPrompt.Size = new System.Drawing.Size(42, 21);
            this.labelForPrompt.TabIndex = 12;
            this.labelForPrompt.Text = "提示";
            // 
            // panelOfChart
            // 
            this.panelOfChart.Location = new System.Drawing.Point(362, 14);
            this.panelOfChart.Name = "panelOfChart";
            this.panelOfChart.Size = new System.Drawing.Size(762, 583);
            this.panelOfChart.TabIndex = 13;
            // 
            // textBoxOfStart
            // 
            this.textBoxOfStart.Location = new System.Drawing.Point(88, 206);
            this.textBoxOfStart.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfStart.Name = "textBoxOfStart";
            this.textBoxOfStart.Size = new System.Drawing.Size(107, 28);
            this.textBoxOfStart.TabIndex = 14;
            this.textBoxOfStart.Text = "-1";
            // 
            // labelOfStart
            // 
            this.labelOfStart.AutoSize = true;
            this.labelOfStart.Location = new System.Drawing.Point(54, 209);
            this.labelOfStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfStart.Name = "labelOfStart";
            this.labelOfStart.Size = new System.Drawing.Size(26, 21);
            this.labelOfStart.TabIndex = 15;
            this.labelOfStart.Text = "始";
            // 
            // textBoxOfEnd
            // 
            this.textBoxOfEnd.Location = new System.Drawing.Point(239, 206);
            this.textBoxOfEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfEnd.Name = "textBoxOfEnd";
            this.textBoxOfEnd.Size = new System.Drawing.Size(107, 28);
            this.textBoxOfEnd.TabIndex = 16;
            this.textBoxOfEnd.Text = "1";
            // 
            // labelOfEnd
            // 
            this.labelOfEnd.AutoSize = true;
            this.labelOfEnd.Location = new System.Drawing.Point(205, 209);
            this.labelOfEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfEnd.Name = "labelOfEnd";
            this.labelOfEnd.Size = new System.Drawing.Size(26, 21);
            this.labelOfEnd.TabIndex = 17;
            this.labelOfEnd.Text = "末";
            // 
            // textBoxOfUpper
            // 
            this.textBoxOfUpper.Location = new System.Drawing.Point(88, 278);
            this.textBoxOfUpper.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfUpper.Name = "textBoxOfUpper";
            this.textBoxOfUpper.Size = new System.Drawing.Size(107, 28);
            this.textBoxOfUpper.TabIndex = 18;
            this.textBoxOfUpper.Text = "NaN";
            // 
            // labelOfUpper
            // 
            this.labelOfUpper.AutoSize = true;
            this.labelOfUpper.Location = new System.Drawing.Point(54, 281);
            this.labelOfUpper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfUpper.Name = "labelOfUpper";
            this.labelOfUpper.Size = new System.Drawing.Size(26, 21);
            this.labelOfUpper.TabIndex = 19;
            this.labelOfUpper.Text = "上";
            // 
            // textBoxOfLower
            // 
            this.textBoxOfLower.Location = new System.Drawing.Point(239, 278);
            this.textBoxOfLower.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfLower.Name = "textBoxOfLower";
            this.textBoxOfLower.Size = new System.Drawing.Size(107, 28);
            this.textBoxOfLower.TabIndex = 20;
            this.textBoxOfLower.Text = "NaN";
            // 
            // labelOfLower
            // 
            this.labelOfLower.AutoSize = true;
            this.labelOfLower.Location = new System.Drawing.Point(205, 281);
            this.labelOfLower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfLower.Name = "labelOfLower";
            this.labelOfLower.Size = new System.Drawing.Size(26, 21);
            this.labelOfLower.TabIndex = 21;
            this.labelOfLower.Text = "下";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(239, 337);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(107, 28);
            this.buttonSaveImage.TabIndex = 22;
            this.buttonSaveImage.Text = "保存";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.ButtonSaveImageClick);
            // 
            // labelOfStepCount
            // 
            this.labelOfStepCount.AutoSize = true;
            this.labelOfStepCount.Location = new System.Drawing.Point(54, 245);
            this.labelOfStepCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfStepCount.Name = "labelOfStepCount";
            this.labelOfStepCount.Size = new System.Drawing.Size(26, 21);
            this.labelOfStepCount.TabIndex = 24;
            this.labelOfStepCount.Text = "步";
            // 
            // textBoxOfStepCount
            // 
            this.textBoxOfStepCount.Location = new System.Drawing.Point(88, 242);
            this.textBoxOfStepCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfStepCount.Name = "textBoxOfStepCount";
            this.textBoxOfStepCount.Size = new System.Drawing.Size(107, 28);
            this.textBoxOfStepCount.TabIndex = 23;
            this.textBoxOfStepCount.Text = "3000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.labelOfStepCount);
            this.Controls.Add(this.textBoxOfStepCount);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.labelOfLower);
            this.Controls.Add(this.textBoxOfLower);
            this.Controls.Add(this.labelOfUpper);
            this.Controls.Add(this.textBoxOfUpper);
            this.Controls.Add(this.labelOfEnd);
            this.Controls.Add(this.textBoxOfEnd);
            this.Controls.Add(this.labelOfStart);
            this.Controls.Add(this.textBoxOfStart);
            this.Controls.Add(this.panelOfChart);
            this.Controls.Add(this.labelForPrompt);
            this.Controls.Add(this.labelOfLambda);
            this.Controls.Add(this.labelOfb);
            this.Controls.Add(this.labelOfN);
            this.Controls.Add(this.labelOfa);
            this.Controls.Add(this.labelOfA0);
            this.Controls.Add(this.textBoxOfb);
            this.Controls.Add(this.textBoxOfLambda);
            this.Controls.Add(this.textBoxOfN);
            this.Controls.Add(this.textBoxOfa);
            this.Controls.Add(this.textBoxOfA0);
            this.Controls.Add(this.buttonStartDrawing);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1152, 648);
            this.MinimumSize = new System.Drawing.Size(1152, 648);
            this.Name = "MainForm";
            this.Text = "多缝夫琅禾费衍射仿真计算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SaveFileDialog saveImageDialog;
        private Button buttonStartDrawing;
        private TextBox textBoxOfA0;
        private TextBox textBoxOfa;
        private TextBox textBoxOfN;
        private TextBox textBoxOfLambda;
        private TextBox textBoxOfb;
        private Label labelOfA0;
        private Label labelOfa;
        private Label labelOfN;
        private Label labelOfb;
        private Label labelOfLambda;
        private Label labelForPrompt;
        private Panel panelOfChart;
        private TextBox textBoxOfStart;
        private Label labelOfStart;
        private TextBox textBoxOfEnd;
        private Label labelOfEnd;
        private TextBox textBoxOfUpper;
        private Label labelOfUpper;
        private TextBox textBoxOfLower;
        private Label labelOfLower;
        private Button buttonSaveImage;
        private Label labelOfStepCount;
        private TextBox textBoxOfStepCount;
    }
}