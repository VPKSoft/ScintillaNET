﻿namespace Scintilla.NET.TestApp
{
    partial class FormMain
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
            this.scintilla = new ScintillaNET.Scintilla();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.lexillaTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLexersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odFile = new System.Windows.Forms.OpenFileDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.AutoCMaxHeight = 9;
            this.scintilla.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.scintilla.CaretLineBackColor = System.Drawing.Color.White;
            this.scintilla.CaretLineVisible = true;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.LexerName = null;
            this.scintilla.Location = new System.Drawing.Point(0, 24);
            this.scintilla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scintilla.Name = "scintilla";
            this.scintilla.ScrollWidth = 6;
            this.scintilla.Size = new System.Drawing.Size(800, 426);
            this.scintilla.TabIndents = true;
            this.scintilla.TabIndex = 0;
            this.scintilla.UseRightToLeftReadingLayout = false;
            this.scintilla.WrapMode = ScintillaNET.WrapMode.None;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTestMethod,
            this.lexillaTestsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(124, 22);
            this.mnuOpen.Text = "Open File";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(124, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTestMethod
            // 
            this.mnuTestMethod.Name = "mnuTestMethod";
            this.mnuTestMethod.Size = new System.Drawing.Size(160, 20);
            this.mnuTestMethod.Text = "Test some Scintilla method";
            this.mnuTestMethod.Click += new System.EventHandler(this.mnuTestMethod_Click);
            // 
            // lexillaTestsToolStripMenuItem
            // 
            this.lexillaTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listLexersToolStripMenuItem});
            this.lexillaTestsToolStripMenuItem.Name = "lexillaTestsToolStripMenuItem";
            this.lexillaTestsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.lexillaTestsToolStripMenuItem.Text = "Lexilla Tests";
            // 
            // listLexersToolStripMenuItem
            // 
            this.listLexersToolStripMenuItem.Name = "listLexersToolStripMenuItem";
            this.listLexersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listLexersToolStripMenuItem.Text = "List Lexers";
            this.listLexersToolStripMenuItem.Click += new System.EventHandler(this.listLexersToolStripMenuItem_Click);
            // 
            // odFile
            // 
            this.odFile.DefaultExt = "*.*";
            this.odFile.Filter = "All Files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "ScintillaNET.TestApp";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.OpenFileDialog odFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTestMethod;
        private System.Windows.Forms.ToolStripMenuItem lexillaTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLexersToolStripMenuItem;
    }
}

