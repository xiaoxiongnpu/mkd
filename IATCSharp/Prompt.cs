﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfIATCSharp
{
    class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 400 };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            textBox.PasswordChar = '*';
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Height=30, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static string Library(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 1100,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 1000 };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 1000 };
            //textBox.PasswordChar = '*';
            Button confirmation = new Button() { Text = "Ok", Left = 800, Width = 100, Height = 30, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            Button cancellation = new Button() { Text = "Cancel", Left = 930, Width = 100, Height = 30, Top = 90, DialogResult = DialogResult.Cancel };
            cancellation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancellation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancellation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
