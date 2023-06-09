using Microsoft.VisualBasic.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string text;
        private string exampleText;
        int time = 0;
        public Form1()
        {
            InitializeComponent();
            text = File.ReadAllText("words.txt");
            exampleText = string.Empty;
            Clear();
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            userEnter.Clear();
            exampleText = text[0..getLastTextPos(text, ((int)wordsCount.Value))];
            wordsExample.Text = exampleText;
            timer1.Start();
            progressBar.Maximum = wordsExample.Text.Length;
            userEnter.TextChanged += userTextChanged;
            userEnter.Focus();
            startButton.Enabled = false;
            yesRadioButton.Enabled = false;
            noRadioButton.Enabled = false;
            wordsCount.Enabled = false;
        }

        private int getLastTextPos(string text, int count)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') count--;
                if (count == 0) return i;
            }
            wordsCount.Value -= count;
            return text.Length - 1;
        }

        private void timerTick(object sender, EventArgs e)
        {
            time++;
            if (time % 10 == 0) TimeLabel.Text = $"Time : {time / 10} s";
        }


        private void userTextChanged(object sender, EventArgs e)
        {
            
            wordsExample.Clear();
            wordsExample.SelectionStart = wordsExample.TextLength;
            wordsExample.SelectionLength = 0;
            wordsExample.SelectionColor = Color.Red;
            wordsExample.AppendText(exampleText[0..userEnter.Text.Length]);
            wordsExample.SelectionColor = wordsExample.ForeColor;
            wordsExample.AppendText(exampleText[userEnter.Text.Length..]);
            userEnter.Focus();
            

            bool charEqual = yesRadioButton.Checked ? userEnter.Text.Last() == wordsExample.Text[userEnter.Text.Length - 1]
                        : Char.ToLower(userEnter.Text.Last()) == Char.ToLower(wordsExample.Text[userEnter.Text.Length - 1]);

            if (charEqual)
            {
                ++progressBar.Value;
                rChar.Text = $"{progressBar.Value}/{wordsExample.Text.Length}";
            }
            else
            {
                userEnter.TextChanged -= userTextChanged;
                userEnter.Text = userEnter.Text[0..^1] + '*';
                userEnter.SelectionStart = userEnter.Text.Length;
                userEnter.TextChanged += userTextChanged;
            }
            
            if(userEnter.Text.Length == wordsExample.TextLength)
            {
                userEnter.TextChanged -= userTextChanged;
                timer1.Stop();
                MessageBox.Show($"Your result : {(time != 0 ? (int)Math.Round((progressBar.Value / (float)time) * 600) : 0)} char by minute", "Result");
                Clear();
                startButton.Enabled = true;
                yesRadioButton.Enabled = true;
                noRadioButton.Enabled = true;
                wordsCount.Enabled = true;
            }
        }

        private void Clear()
        {
            time = 0;
            progressBar.Value = progressBar.Minimum;
            userEnter.Clear();
            wordsExample.Clear();
            rChar.Text = $"0/0";
            TimeLabel.Text = $"Time : 0 s";
        }

        private void Exit(object sender, EventArgs e) => Close();

    }
}