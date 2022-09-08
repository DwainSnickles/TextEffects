
namespace TextEffects
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.picText = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlShadowColor = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTextOutLineColor1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTextOutLineColor2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTextGradient1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTextGradient2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.nudShadowThickness = new System.Windows.Forms.NumericUpDown();
            this.cmbgradientType = new System.Windows.Forms.ComboBox();
            this.cmbReflection = new System.Windows.Forms.ComboBox();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDrawText = new System.Windows.Forms.Button();
            this.btnShawdowColor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnTextGradient2 = new System.Windows.Forms.Button();
            this.btnTextGradient1 = new System.Windows.Forms.Button();
            this.btnTextOutLineColor2 = new System.Windows.Forms.Button();
            this.btnTextOutLineColor1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHideShadow = new System.Windows.Forms.RadioButton();
            this.rbShowShadow = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShadowThickness)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShadowThickness";
            // 
            // picText
            // 
            this.picText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picText.Location = new System.Drawing.Point(229, 103);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(25, 25);
            this.picText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picText.TabIndex = 1;
            this.picText.TabStop = false;
            this.picText.Paint += new System.Windows.Forms.PaintEventHandler(this.picturebox1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Text to write.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reflection";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gradient Type";
            // 
            // pnlShadowColor
            // 
            this.pnlShadowColor.BackColor = System.Drawing.Color.Red;
            this.pnlShadowColor.Location = new System.Drawing.Point(110, 26);
            this.pnlShadowColor.Name = "pnlShadowColor";
            this.pnlShadowColor.Size = new System.Drawing.Size(44, 20);
            this.pnlShadowColor.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Shadow Color";
            // 
            // pnlTextOutLineColor1
            // 
            this.pnlTextOutLineColor1.BackColor = System.Drawing.Color.Maroon;
            this.pnlTextOutLineColor1.Location = new System.Drawing.Point(111, 51);
            this.pnlTextOutLineColor1.Name = "pnlTextOutLineColor1";
            this.pnlTextOutLineColor1.Size = new System.Drawing.Size(44, 20);
            this.pnlTextOutLineColor1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "TextOutLineColor1";
            // 
            // pnlTextOutLineColor2
            // 
            this.pnlTextOutLineColor2.BackColor = System.Drawing.Color.Yellow;
            this.pnlTextOutLineColor2.Location = new System.Drawing.Point(111, 76);
            this.pnlTextOutLineColor2.Name = "pnlTextOutLineColor2";
            this.pnlTextOutLineColor2.Size = new System.Drawing.Size(44, 20);
            this.pnlTextOutLineColor2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "TextOutLineColor2";
            // 
            // pnlTextGradient1
            // 
            this.pnlTextGradient1.BackColor = System.Drawing.Color.Black;
            this.pnlTextGradient1.Location = new System.Drawing.Point(111, 101);
            this.pnlTextGradient1.Name = "pnlTextGradient1";
            this.pnlTextGradient1.Size = new System.Drawing.Size(44, 20);
            this.pnlTextGradient1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(15, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "TextGradient1";
            // 
            // pnlTextGradient2
            // 
            this.pnlTextGradient2.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTextGradient2.Location = new System.Drawing.Point(111, 126);
            this.pnlTextGradient2.Name = "pnlTextGradient2";
            this.pnlTextGradient2.Size = new System.Drawing.Size(44, 20);
            this.pnlTextGradient2.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "TextGradient2";
            // 
            // nudShadowThickness
            // 
            this.nudShadowThickness.Location = new System.Drawing.Point(108, 267);
            this.nudShadowThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudShadowThickness.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudShadowThickness.Name = "nudShadowThickness";
            this.nudShadowThickness.Size = new System.Drawing.Size(44, 20);
            this.nudShadowThickness.TabIndex = 20;
            this.nudShadowThickness.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShadowThickness.ValueChanged += new System.EventHandler(this.nudShadowThickness_ValueChanged);
            // 
            // cmbgradientType
            // 
            this.cmbgradientType.FormattingEnabled = true;
            this.cmbgradientType.Items.AddRange(new object[] {
            "Linear",
            "Sinusoid"});
            this.cmbgradientType.Location = new System.Drawing.Point(15, 307);
            this.cmbgradientType.Name = "cmbgradientType";
            this.cmbgradientType.Size = new System.Drawing.Size(92, 21);
            this.cmbgradientType.TabIndex = 21;
            this.cmbgradientType.Text = "Linear";
            // 
            // cmbReflection
            // 
            this.cmbReflection.FormattingEnabled = true;
            this.cmbReflection.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbReflection.Location = new System.Drawing.Point(323, 44);
            this.cmbReflection.Name = "cmbReflection";
            this.cmbReflection.Size = new System.Drawing.Size(79, 21);
            this.cmbReflection.TabIndex = 22;
            this.cmbReflection.Text = "False";
            this.cmbReflection.Visible = false;
            this.cmbReflection.SelectedIndexChanged += new System.EventHandler(this.cmbReflection_SelectedIndexChanged);
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Location = new System.Drawing.Point(15, 26);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(200, 20);
            this.txtDisplayText.TabIndex = 24;
            this.txtDisplayText.Text = "Hello World";
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BackColor = System.Drawing.Color.Gold;
            this.pnlTextColor.Location = new System.Drawing.Point(320, 12);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(44, 20);
            this.pnlTextColor.TabIndex = 25;
            this.pnlTextColor.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "TextColor";
            this.label8.Visible = false;
            // 
            // btnDrawText
            // 
            this.btnDrawText.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDrawText.Location = new System.Drawing.Point(12, 334);
            this.btnDrawText.Name = "btnDrawText";
            this.btnDrawText.Size = new System.Drawing.Size(138, 23);
            this.btnDrawText.TabIndex = 29;
            this.btnDrawText.Text = "Draw Shadowed Text";
            this.btnDrawText.UseVisualStyleBackColor = false;
            this.btnDrawText.Click += new System.EventHandler(this.btnDrawText_Click);
            // 
            // btnShawdowColor
            // 
            this.btnShawdowColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShawdowColor.ImageIndex = 1;
            this.btnShawdowColor.ImageList = this.imageList1;
            this.btnShawdowColor.Location = new System.Drawing.Point(153, 23);
            this.btnShawdowColor.Name = "btnShawdowColor";
            this.btnShawdowColor.Size = new System.Drawing.Size(24, 24);
            this.btnShawdowColor.TabIndex = 31;
            this.btnShawdowColor.UseVisualStyleBackColor = true;
            this.btnShawdowColor.Click += new System.EventHandler(this.btnShawdowColor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fill.png");
            this.imageList1.Images.SetKeyName(1, "Color1.png");
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(362, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnTextGradient2
            // 
            this.btnTextGradient2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextGradient2.ImageIndex = 1;
            this.btnTextGradient2.ImageList = this.imageList1;
            this.btnTextGradient2.Location = new System.Drawing.Point(153, 124);
            this.btnTextGradient2.Name = "btnTextGradient2";
            this.btnTextGradient2.Size = new System.Drawing.Size(24, 24);
            this.btnTextGradient2.TabIndex = 34;
            this.btnTextGradient2.UseVisualStyleBackColor = true;
            this.btnTextGradient2.Click += new System.EventHandler(this.btnTextGradient2_Click);
            // 
            // btnTextGradient1
            // 
            this.btnTextGradient1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextGradient1.ImageIndex = 1;
            this.btnTextGradient1.ImageList = this.imageList1;
            this.btnTextGradient1.Location = new System.Drawing.Point(153, 98);
            this.btnTextGradient1.Name = "btnTextGradient1";
            this.btnTextGradient1.Size = new System.Drawing.Size(24, 24);
            this.btnTextGradient1.TabIndex = 33;
            this.btnTextGradient1.UseVisualStyleBackColor = true;
            this.btnTextGradient1.Click += new System.EventHandler(this.btnTextGradient1_Click);
            // 
            // btnTextOutLineColor2
            // 
            this.btnTextOutLineColor2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextOutLineColor2.ImageIndex = 1;
            this.btnTextOutLineColor2.ImageList = this.imageList1;
            this.btnTextOutLineColor2.Location = new System.Drawing.Point(153, 74);
            this.btnTextOutLineColor2.Name = "btnTextOutLineColor2";
            this.btnTextOutLineColor2.Size = new System.Drawing.Size(24, 24);
            this.btnTextOutLineColor2.TabIndex = 36;
            this.btnTextOutLineColor2.UseVisualStyleBackColor = true;
            this.btnTextOutLineColor2.Click += new System.EventHandler(this.btnTextOutLineColor2_Click);
            // 
            // btnTextOutLineColor1
            // 
            this.btnTextOutLineColor1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextOutLineColor1.ImageIndex = 1;
            this.btnTextOutLineColor1.ImageList = this.imageList1;
            this.btnTextOutLineColor1.Location = new System.Drawing.Point(153, 50);
            this.btnTextOutLineColor1.Name = "btnTextOutLineColor1";
            this.btnTextOutLineColor1.Size = new System.Drawing.Size(24, 24);
            this.btnTextOutLineColor1.TabIndex = 35;
            this.btnTextOutLineColor1.UseVisualStyleBackColor = true;
            this.btnTextOutLineColor1.Click += new System.EventHandler(this.btnTextOutLineColor1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTextGradient1);
            this.groupBox1.Controls.Add(this.pnlShadowColor);
            this.groupBox1.Controls.Add(this.pnlTextOutLineColor1);
            this.groupBox1.Controls.Add(this.pnlTextGradient2);
            this.groupBox1.Controls.Add(this.pnlTextOutLineColor2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnTextOutLineColor2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnTextOutLineColor1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTextGradient2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnTextGradient1);
            this.groupBox1.Controls.Add(this.btnShawdowColor);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 163);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Color Options ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHideShadow);
            this.groupBox2.Controls.Add(this.rbShowShadow);
            this.groupBox2.Location = new System.Drawing.Point(15, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 44);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shadow Options";
            // 
            // rbHideShadow
            // 
            this.rbHideShadow.AutoSize = true;
            this.rbHideShadow.Location = new System.Drawing.Point(107, 16);
            this.rbHideShadow.Name = "rbHideShadow";
            this.rbHideShadow.Size = new System.Drawing.Size(89, 17);
            this.rbHideShadow.TabIndex = 1;
            this.rbHideShadow.TabStop = true;
            this.rbHideShadow.Text = "Hide Shadow";
            this.rbHideShadow.UseVisualStyleBackColor = true;
            this.rbHideShadow.CheckedChanged += new System.EventHandler(this.rbHideShadow_CheckedChanged);
            // 
            // rbShowShadow
            // 
            this.rbShowShadow.AutoSize = true;
            this.rbShowShadow.Checked = true;
            this.rbShowShadow.Location = new System.Drawing.Point(5, 16);
            this.rbShowShadow.Name = "rbShowShadow";
            this.rbShowShadow.Size = new System.Drawing.Size(94, 17);
            this.rbShowShadow.TabIndex = 0;
            this.rbShowShadow.TabStop = true;
            this.rbShowShadow.Text = "Show Shadow";
            this.rbShowShadow.UseVisualStyleBackColor = true;
            this.rbShowShadow.CheckedChanged += new System.EventHandler(this.rbShowShadow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sample Text Image Display.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTextColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picText);
            this.Controls.Add(this.btnDrawText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.cmbReflection);
            this.Controls.Add(this.cmbgradientType);
            this.Controls.Add(this.nudShadowThickness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Shadowed Text";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShadowThickness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlShadowColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTextOutLineColor1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlTextOutLineColor2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlTextGradient1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlTextGradient2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudShadowThickness;
        private System.Windows.Forms.ComboBox cmbgradientType;
        private System.Windows.Forms.ComboBox cmbReflection;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDrawText;
        private System.Windows.Forms.Button btnShawdowColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTextGradient2;
        private System.Windows.Forms.Button btnTextGradient1;
        private System.Windows.Forms.Button btnTextOutLineColor2;
        private System.Windows.Forms.Button btnTextOutLineColor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHideShadow;
        private System.Windows.Forms.RadioButton rbShowShadow;
        private System.Windows.Forms.Label label2;
    }
}

