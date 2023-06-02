﻿namespace ja_learner
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
            timerWindowAlign = new System.Windows.Forms.Timer(components);
            tabControl = new TabControl();
            tabPageText = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            btnInputText = new Button();
            checkBoxClipboardMode = new CheckBox();
            tabPageChatGPT = new TabPage();
            tabPageSettings = new TabPage();
            btnSelectWindow = new Button();
            checkBoxAlignWindow = new CheckBox();
            textBox1 = new TextBox();
            tabControl.SuspendLayout();
            tabPageText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            tabPageSettings.SuspendLayout();
            SuspendLayout();
            // 
            // timerWindowAlign
            // 
            timerWindowAlign.Interval = 20;
            timerWindowAlign.Tick += timerWindowAlign_Tick;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageText);
            tabControl.Controls.Add(tabPageChatGPT);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(503, 256);
            tabControl.TabIndex = 2;
            // 
            // tabPageText
            // 
            tabPageText.Controls.Add(webView21);
            tabPageText.Controls.Add(panel1);
            tabPageText.Location = new System.Drawing.Point(4, 26);
            tabPageText.Name = "tabPageText";
            tabPageText.Padding = new Padding(3);
            tabPageText.Size = new Size(495, 226);
            tabPageText.TabIndex = 1;
            tabPageText.Text = "内容分析";
            tabPageText.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new System.Drawing.Point(3, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(489, 188);
            webView21.Source = new Uri("https://t.bilibili.com/", UriKind.Absolute);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInputText);
            panel1.Controls.Add(checkBoxClipboardMode);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(3, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 32);
            panel1.TabIndex = 0;
            // 
            // btnInputText
            // 
            btnInputText.Location = new System.Drawing.Point(98, 4);
            btnInputText.Name = "btnInputText";
            btnInputText.Size = new Size(115, 23);
            btnInputText.TabIndex = 1;
            btnInputText.Text = "输入要分析的句子";
            btnInputText.UseVisualStyleBackColor = true;
            // 
            // checkBoxClipboardMode
            // 
            checkBoxClipboardMode.AutoSize = true;
            checkBoxClipboardMode.Location = new System.Drawing.Point(3, 6);
            checkBoxClipboardMode.Name = "checkBoxClipboardMode";
            checkBoxClipboardMode.Size = new Size(87, 21);
            checkBoxClipboardMode.TabIndex = 0;
            checkBoxClipboardMode.Text = "剪贴板模式";
            checkBoxClipboardMode.UseVisualStyleBackColor = true;
            checkBoxClipboardMode.CheckedChanged += checkBoxClipboardMode_CheckedChanged;
            // 
            // tabPageChatGPT
            // 
            tabPageChatGPT.Location = new System.Drawing.Point(4, 26);
            tabPageChatGPT.Name = "tabPageChatGPT";
            tabPageChatGPT.Size = new Size(531, 252);
            tabPageChatGPT.TabIndex = 2;
            tabPageChatGPT.Text = "GPT帮帮我";
            tabPageChatGPT.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(btnSelectWindow);
            tabPageSettings.Controls.Add(checkBoxAlignWindow);
            tabPageSettings.Controls.Add(textBox1);
            tabPageSettings.Location = new System.Drawing.Point(4, 26);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(531, 252);
            tabPageSettings.TabIndex = 0;
            tabPageSettings.Text = "系统设置";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnSelectWindow
            // 
            btnSelectWindow.Location = new System.Drawing.Point(8, 6);
            btnSelectWindow.Name = "btnSelectWindow";
            btnSelectWindow.Size = new Size(75, 23);
            btnSelectWindow.TabIndex = 4;
            btnSelectWindow.Text = "选择窗口";
            btnSelectWindow.UseVisualStyleBackColor = true;
            btnSelectWindow.Click += btnSelectWindow_Click;
            // 
            // checkBoxAlignWindow
            // 
            checkBoxAlignWindow.AutoSize = true;
            checkBoxAlignWindow.Location = new System.Drawing.Point(195, 8);
            checkBoxAlignWindow.Name = "checkBoxAlignWindow";
            checkBoxAlignWindow.Size = new Size(99, 21);
            checkBoxAlignWindow.TabIndex = 3;
            checkBoxAlignWindow.Text = "与该程序对齐";
            checkBoxAlignWindow.UseVisualStyleBackColor = true;
            checkBoxAlignWindow.CheckedChanged += checkBoxAlignWindow_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(89, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "16672";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 256);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "KS的日语学习工具";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPageText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerWindowAlign;
        private TabControl tabControl;
        private TabPage tabPageText;
        private TabPage tabPageChatGPT;
        private TabPage tabPageSettings;
        private TextBox textBox1;
        private CheckBox checkBoxAlignWindow;
        private Button btnSelectWindow;
        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnInputText;
        private CheckBox checkBoxClipboardMode;
    }
}