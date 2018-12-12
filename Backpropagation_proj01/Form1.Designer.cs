namespace Backpropagation_proj01
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
            this.trainning_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowMe = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TestingPanel = new System.Windows.Forms.Panel();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Output0 = new System.Windows.Forms.Button();
            this.Output1 = new System.Windows.Forms.Button();
            this.Output2 = new System.Windows.Forms.Button();
            this.Output3 = new System.Windows.Forms.Button();
            this.Output4 = new System.Windows.Forms.Button();
            this.Output5 = new System.Windows.Forms.Button();
            this.Output6 = new System.Windows.Forms.Button();
            this.Output7 = new System.Windows.Forms.Button();
            this.Output8 = new System.Windows.Forms.Button();
            this.Output9 = new System.Windows.Forms.Button();
            this.InputBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainning_panel
            // 
            this.trainning_panel.BackColor = System.Drawing.Color.White;
            this.trainning_panel.Location = new System.Drawing.Point(735, 333);
            this.trainning_panel.Name = "trainning_panel";
            this.trainning_panel.Size = new System.Drawing.Size(200, 200);
            this.trainning_panel.TabIndex = 0;
            this.trainning_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Trainningpanel_Paint);
            this.trainning_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Trainningpanel_MouseDown);
            this.trainning_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Trainningpanel_MouseMove);
            this.trainning_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Trainningpanel_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(801, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowMe
            // 
            this.ShowMe.Location = new System.Drawing.Point(73, 333);
            this.ShowMe.Name = "ShowMe";
            this.ShowMe.Size = new System.Drawing.Size(75, 23);
            this.ShowMe.TabIndex = 3;
            this.ShowMe.Text = "showme";
            this.ShowMe.UseVisualStyleBackColor = true;
            this.ShowMe.Click += new System.EventHandler(this.ShowMe_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(73, 362);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 168);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // TestingPanel
            // 
            this.TestingPanel.BackColor = System.Drawing.Color.White;
            this.TestingPanel.Location = new System.Drawing.Point(73, 31);
            this.TestingPanel.Name = "TestingPanel";
            this.TestingPanel.Size = new System.Drawing.Size(200, 200);
            this.TestingPanel.TabIndex = 1;
            this.TestingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TestingPanel_Paint);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(393, 33);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(195, 93);
            this.AnswerBox.TabIndex = 6;
            this.AnswerBox.Text = "";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(735, 304);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Output0
            // 
            this.Output0.Location = new System.Drawing.Point(629, 538);
            this.Output0.Name = "Output0";
            this.Output0.Size = new System.Drawing.Size(26, 21);
            this.Output0.TabIndex = 8;
            this.Output0.Text = "0";
            this.Output0.UseVisualStyleBackColor = true;
            // 
            // Output1
            // 
            this.Output1.Location = new System.Drawing.Point(661, 538);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(26, 21);
            this.Output1.TabIndex = 9;
            this.Output1.Text = "1";
            this.Output1.UseVisualStyleBackColor = true;
            // 
            // Output2
            // 
            this.Output2.Location = new System.Drawing.Point(693, 538);
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(26, 21);
            this.Output2.TabIndex = 10;
            this.Output2.Text = "2";
            this.Output2.UseVisualStyleBackColor = true;
            // 
            // Output3
            // 
            this.Output3.Location = new System.Drawing.Point(725, 538);
            this.Output3.Name = "Output3";
            this.Output3.Size = new System.Drawing.Size(26, 21);
            this.Output3.TabIndex = 11;
            this.Output3.Text = "3";
            this.Output3.UseVisualStyleBackColor = true;
            // 
            // Output4
            // 
            this.Output4.Location = new System.Drawing.Point(757, 538);
            this.Output4.Name = "Output4";
            this.Output4.Size = new System.Drawing.Size(26, 21);
            this.Output4.TabIndex = 12;
            this.Output4.Text = "4";
            this.Output4.UseVisualStyleBackColor = true;
            // 
            // Output5
            // 
            this.Output5.Location = new System.Drawing.Point(789, 538);
            this.Output5.Name = "Output5";
            this.Output5.Size = new System.Drawing.Size(26, 21);
            this.Output5.TabIndex = 13;
            this.Output5.Text = "5";
            this.Output5.UseVisualStyleBackColor = true;
            // 
            // Output6
            // 
            this.Output6.Location = new System.Drawing.Point(821, 538);
            this.Output6.Name = "Output6";
            this.Output6.Size = new System.Drawing.Size(26, 21);
            this.Output6.TabIndex = 14;
            this.Output6.Text = "6";
            this.Output6.UseVisualStyleBackColor = true;
            // 
            // Output7
            // 
            this.Output7.Location = new System.Drawing.Point(853, 538);
            this.Output7.Name = "Output7";
            this.Output7.Size = new System.Drawing.Size(26, 21);
            this.Output7.TabIndex = 15;
            this.Output7.Text = "7";
            this.Output7.UseVisualStyleBackColor = true;
            // 
            // Output8
            // 
            this.Output8.Location = new System.Drawing.Point(885, 539);
            this.Output8.Name = "Output8";
            this.Output8.Size = new System.Drawing.Size(26, 21);
            this.Output8.TabIndex = 16;
            this.Output8.Text = "8";
            this.Output8.UseVisualStyleBackColor = true;
            // 
            // Output9
            // 
            this.Output9.Location = new System.Drawing.Point(917, 539);
            this.Output9.Name = "Output9";
            this.Output9.Size = new System.Drawing.Size(26, 21);
            this.Output9.TabIndex = 17;
            this.Output9.Text = "9";
            this.Output9.UseVisualStyleBackColor = true;
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(735, 191);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(75, 23);
            this.InputBtn.TabIndex = 18;
            this.InputBtn.Text = "Input";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 638);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.Output9);
            this.Controls.Add(this.Output8);
            this.Controls.Add(this.Output7);
            this.Controls.Add(this.Output6);
            this.Controls.Add(this.Output5);
            this.Controls.Add(this.Output4);
            this.Controls.Add(this.Output3);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.Output0);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.TestingPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowMe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trainning_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel trainning_panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowMe;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel TestingPanel;
        private System.Windows.Forms.RichTextBox AnswerBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Output0;
        private System.Windows.Forms.Button Output1;
        private System.Windows.Forms.Button Output2;
        private System.Windows.Forms.Button Output3;
        private System.Windows.Forms.Button Output4;
        private System.Windows.Forms.Button Output5;
        private System.Windows.Forms.Button Output6;
        private System.Windows.Forms.Button Output7;
        private System.Windows.Forms.Button Output8;
        private System.Windows.Forms.Button Output9;
        private System.Windows.Forms.Button InputBtn;
    }
}

