namespace moGray
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printScaleSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.printCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printFileButton = new System.Windows.Forms.Button();
            this.printFileText = new System.Windows.Forms.TextBox();
            this.printImageSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.printEncoderBit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printScaleSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printEncoderBit)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Энкодеры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.printScaleSize);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.printCreate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.printImageSize);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.printEncoderBit);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Печать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printScaleSize
            // 
            this.printScaleSize.Location = new System.Drawing.Point(203, 94);
            this.printScaleSize.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.printScaleSize.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.printScaleSize.Name = "printScaleSize";
            this.printScaleSize.Size = new System.Drawing.Size(108, 20);
            this.printScaleSize.TabIndex = 10;
            this.printScaleSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размер шкалы энкодера, пикселей:";
            // 
            // printCreate
            // 
            this.printCreate.Location = new System.Drawing.Point(225, 189);
            this.printCreate.Name = "printCreate";
            this.printCreate.Size = new System.Drawing.Size(86, 38);
            this.printCreate.TabIndex = 8;
            this.printCreate.Text = "Создать";
            this.printCreate.UseVisualStyleBackColor = true;
            this.printCreate.Click += new System.EventHandler(this.printCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printFileButton);
            this.groupBox1.Controls.Add(this.printFileText);
            this.groupBox1.Location = new System.Drawing.Point(9, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к файлу";
            // 
            // printFileButton
            // 
            this.printFileButton.Location = new System.Drawing.Point(182, 18);
            this.printFileButton.Name = "printFileButton";
            this.printFileButton.Size = new System.Drawing.Size(120, 23);
            this.printFileButton.TabIndex = 1;
            this.printFileButton.Text = "Выбрать";
            this.printFileButton.UseVisualStyleBackColor = true;
            this.printFileButton.Click += new System.EventHandler(this.printFileButton_Click);
            // 
            // printFileText
            // 
            this.printFileText.Location = new System.Drawing.Point(7, 20);
            this.printFileText.Name = "printFileText";
            this.printFileText.Size = new System.Drawing.Size(164, 20);
            this.printFileText.TabIndex = 0;
            this.printFileText.Text = "C:\\ASTRO\\test.jpg";
            // 
            // printImageSize
            // 
            this.printImageSize.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.printImageSize.Location = new System.Drawing.Point(203, 71);
            this.printImageSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.printImageSize.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.printImageSize.Name = "printImageSize";
            this.printImageSize.Size = new System.Drawing.Size(108, 20);
            this.printImageSize.TabIndex = 6;
            this.printImageSize.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер изображения, пикселей:";
            // 
            // printEncoderBit
            // 
            this.printEncoderBit.Location = new System.Drawing.Point(203, 50);
            this.printEncoderBit.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.printEncoderBit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.printEncoderBit.Name = "printEncoderBit";
            this.printEncoderBit.Size = new System.Drawing.Size(108, 20);
            this.printEncoderBit.TabIndex = 4;
            this.printEncoderBit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точность энкодера, бит:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подготовка изображения для печати энкодерного круга";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "moGray";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printScaleSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printImageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printEncoderBit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown printEncoderBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown printImageSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button printFileButton;
        private System.Windows.Forms.TextBox printFileText;
        private System.Windows.Forms.Button printCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown printScaleSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

