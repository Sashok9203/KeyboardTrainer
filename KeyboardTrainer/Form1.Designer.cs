namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            startButton = new Button();
            wCount = new Label();
            wordsCount = new NumericUpDown();
            label2 = new Label();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            userEnter = new TextBox();
            TimeLabel = new Label();
            label3 = new Label();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            rChar = new Label();
            wordsExample = new RichTextBox();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)wordsCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(251, 32);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 0;
            label1.Text = "Keyboard Trainer";
            // 
            // startButton
            // 
            startButton.Location = new Point(52, 91);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButtonClick;
            // 
            // wCount
            // 
            wCount.AutoSize = true;
            wCount.Location = new Point(319, 95);
            wCount.Name = "wCount";
            wCount.Size = new Size(47, 15);
            wCount.TabIndex = 3;
            wCount.Text = "Words :";
            // 
            // wordsCount
            // 
            wordsCount.Location = new Point(372, 92);
            wordsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wordsCount.Name = "wordsCount";
            wordsCount.Size = new Size(52, 23);
            wordsCount.TabIndex = 4;
            wordsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 94);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Case Sensetive:";
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Checked = true;
            yesRadioButton.Location = new Point(610, 93);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(42, 19);
            yesRadioButton.TabIndex = 6;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(658, 94);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(41, 19);
            noRadioButton.TabIndex = 7;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // userEnter
            // 
            userEnter.Location = new Point(52, 257);
            userEnter.Multiline = true;
            userEnter.Name = "userEnter";
            userEnter.Size = new Size(651, 139);
            userEnter.TabIndex = 8;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(53, 430);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(39, 15);
            TimeLabel.TabIndex = 9;
            TimeLabel.Text = "Time :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 430);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Progress:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(187, 431);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(429, 14);
            progressBar.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Tick += timerTick;
            // 
            // rChar
            // 
            rChar.AutoSize = true;
            rChar.Location = new Point(645, 431);
            rChar.Name = "rChar";
            rChar.Size = new Size(24, 15);
            rChar.TabIndex = 12;
            rChar.Text = "0/0";
            // 
            // wordsExample
            // 
            wordsExample.AutoWordSelection = true;
            wordsExample.Enabled = false;
            wordsExample.Location = new Point(53, 120);
            wordsExample.Name = "wordsExample";
            wordsExample.ReadOnly = true;
            wordsExample.Size = new Size(650, 120);
            wordsExample.TabIndex = 13;
            wordsExample.Text = "";
            // 
            // exit
            // 
            exit.Location = new Point(133, 91);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += Exit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 469);
            Controls.Add(exit);
            Controls.Add(wordsExample);
            Controls.Add(rChar);
            Controls.Add(progressBar);
            Controls.Add(label3);
            Controls.Add(TimeLabel);
            Controls.Add(userEnter);
            Controls.Add(noRadioButton);
            Controls.Add(yesRadioButton);
            Controls.Add(label2);
            Controls.Add(wordsCount);
            Controls.Add(wCount);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Keyboard Trainer";
            ((System.ComponentModel.ISupportInitialize)wordsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startButton;
        private Label wCount;
        private NumericUpDown wordsCount;
        private Label label2;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
        private TextBox userEnter;
        private Label TimeLabel;
        private Label label3;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private Label rChar;
        private RichTextBox wordsExample;
        private Button exit;
    }
}