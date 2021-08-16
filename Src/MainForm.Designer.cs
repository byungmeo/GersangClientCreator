﻿
namespace GersangClientCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_MasterPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_FindMaster = new System.Windows.Forms.Button();
            this.tb_SecondName = new System.Windows.Forms.TextBox();
            this.tb_ThirdName = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lb_Master = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_information = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_blog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_github = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.check_Music = new System.Windows.Forms.CheckBox();
            this.check_Online = new System.Windows.Forms.CheckBox();
            this.check_Shortcut = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_MasterPath
            // 
            this.tb_MasterPath.Location = new System.Drawing.Point(109, 37);
            this.tb_MasterPath.Name = "tb_MasterPath";
            this.tb_MasterPath.ReadOnly = true;
            this.tb_MasterPath.Size = new System.Drawing.Size(169, 23);
            this.tb_MasterPath.TabIndex = 10;
            this.tb_MasterPath.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btn_FindMaster
            // 
            this.btn_FindMaster.Location = new System.Drawing.Point(284, 37);
            this.btn_FindMaster.Name = "btn_FindMaster";
            this.btn_FindMaster.Size = new System.Drawing.Size(38, 21);
            this.btn_FindMaster.TabIndex = 1;
            this.btn_FindMaster.TabStop = false;
            this.btn_FindMaster.Text = "...";
            this.btn_FindMaster.UseVisualStyleBackColor = true;
            this.btn_FindMaster.Click += new System.EventHandler(this.btn_FindMaster_Click);
            // 
            // tb_SecondName
            // 
            this.tb_SecondName.Location = new System.Drawing.Point(109, 66);
            this.tb_SecondName.Name = "tb_SecondName";
            this.tb_SecondName.Size = new System.Drawing.Size(92, 23);
            this.tb_SecondName.TabIndex = 0;
            // 
            // tb_ThirdName
            // 
            this.tb_ThirdName.Location = new System.Drawing.Point(109, 95);
            this.tb_ThirdName.Name = "tb_ThirdName";
            this.tb_ThirdName.Size = new System.Drawing.Size(92, 23);
            this.tb_ThirdName.TabIndex = 1;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(131, 212);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 8;
            this.btn_Run.TabStop = false;
            this.btn_Run.Text = "생성";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lb_Master
            // 
            this.lb_Master.AutoSize = true;
            this.lb_Master.Location = new System.Drawing.Point(32, 40);
            this.lb_Master.Name = "lb_Master";
            this.lb_Master.Size = new System.Drawing.Size(71, 15);
            this.lb_Master.TabIndex = 9;
            this.lb_Master.Text = "본클라 경로";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "2클 폴더 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "3클 폴더 이름";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_information});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_information
            // 
            this.tsm_information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_blog,
            this.tsm_github});
            this.tsm_information.Name = "tsm_information";
            this.tsm_information.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.tsm_information.Size = new System.Drawing.Size(43, 23);
            this.tsm_information.Text = "정보";
            // 
            // tsm_blog
            // 
            this.tsm_blog.Name = "tsm_blog";
            this.tsm_blog.Size = new System.Drawing.Size(150, 22);
            this.tsm_blog.Text = "제작자 블로그";
            this.tsm_blog.Click += new System.EventHandler(this.tsm_blog_Click);
            // 
            // tsm_github
            // 
            this.tsm_github.Name = "tsm_github";
            this.tsm_github.Size = new System.Drawing.Size(150, 22);
            this.tsm_github.Text = "제작자 깃허브";
            this.tsm_github.Click += new System.EventHandler(this.tsm_github_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 14;
            // 
            // check_Music
            // 
            this.check_Music.AutoSize = true;
            this.check_Music.Checked = true;
            this.check_Music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Music.Enabled = false;
            this.check_Music.Location = new System.Drawing.Point(21, 174);
            this.check_Music.Name = "check_Music";
            this.check_Music.Size = new System.Drawing.Size(150, 19);
            this.check_Music.TabIndex = 15;
            this.check_Music.Text = "music폴더포함(점검중)";
            this.check_Music.UseVisualStyleBackColor = true;
            this.check_Music.MouseHover += new System.EventHandler(this.check_Music_MouseHover);
            // 
            // check_Online
            // 
            this.check_Online.AutoSize = true;
            this.check_Online.Enabled = false;
            this.check_Online.Location = new System.Drawing.Point(177, 174);
            this.check_Online.Name = "check_Online";
            this.check_Online.Size = new System.Drawing.Size(142, 19);
            this.check_Online.TabIndex = 16;
            this.check_Online.Text = "개별세팅저장(점검중)";
            this.check_Online.UseVisualStyleBackColor = true;
            this.check_Online.MouseHover += new System.EventHandler(this.check_Online_MouseHover);
            // 
            // check_Shortcut
            // 
            this.check_Shortcut.AutoSize = true;
            this.check_Shortcut.Location = new System.Drawing.Point(21, 139);
            this.check_Shortcut.Name = "check_Shortcut";
            this.check_Shortcut.Size = new System.Drawing.Size(102, 19);
            this.check_Shortcut.TabIndex = 17;
            this.check_Shortcut.Text = "바로가기 생성";
            this.check_Shortcut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(336, 251);
            this.Controls.Add(this.check_Shortcut);
            this.Controls.Add(this.check_Online);
            this.Controls.Add(this.check_Music);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Master);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.tb_ThirdName);
            this.Controls.Add(this.tb_SecondName);
            this.Controls.Add(this.btn_FindMaster);
            this.Controls.Add(this.tb_MasterPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "거상 다클생성기 v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MasterPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_FindMaster;
        private System.Windows.Forms.TextBox tb_SecondName;
        private System.Windows.Forms.TextBox tb_ThirdName;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lb_Master;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_blog;
        private System.Windows.Forms.ToolStripMenuItem tsm_information;
        private System.Windows.Forms.ToolStripMenuItem tsm_github;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_Music;
        private System.Windows.Forms.CheckBox check_Online;
        private System.Windows.Forms.CheckBox check_Shortcut;
    }
}

