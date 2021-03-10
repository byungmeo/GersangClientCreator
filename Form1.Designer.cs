
namespace GersangMultipleClientCreator
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
            this.components = new System.ComponentModel.Container();
            this.tb_MasterPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_FindMaster = new System.Windows.Forms.Button();
            this.tb_SecondName = new System.Windows.Forms.TextBox();
            this.tb_ThirdName = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lb_Master = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MasterPath
            // 
            this.tb_MasterPath.Location = new System.Drawing.Point(107, 36);
            this.tb_MasterPath.Name = "tb_MasterPath";
            this.tb_MasterPath.Size = new System.Drawing.Size(169, 23);
            this.tb_MasterPath.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btn_FindMaster
            // 
            this.btn_FindMaster.Location = new System.Drawing.Point(282, 36);
            this.btn_FindMaster.Name = "btn_FindMaster";
            this.btn_FindMaster.Size = new System.Drawing.Size(38, 21);
            this.btn_FindMaster.TabIndex = 1;
            this.btn_FindMaster.Text = "...";
            this.btn_FindMaster.UseVisualStyleBackColor = true;
            this.btn_FindMaster.Click += new System.EventHandler(this.btn_FindMaster_Click);
            // 
            // tb_SecondName
            // 
            this.tb_SecondName.Location = new System.Drawing.Point(107, 65);
            this.tb_SecondName.Name = "tb_SecondName";
            this.tb_SecondName.Size = new System.Drawing.Size(92, 23);
            this.tb_SecondName.TabIndex = 6;
            // 
            // tb_ThirdName
            // 
            this.tb_ThirdName.Location = new System.Drawing.Point(107, 94);
            this.tb_ThirdName.Name = "tb_ThirdName";
            this.tb_ThirdName.Size = new System.Drawing.Size(92, 23);
            this.tb_ThirdName.TabIndex = 7;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(134, 153);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 8;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lb_Master
            // 
            this.lb_Master.AutoSize = true;
            this.lb_Master.Location = new System.Drawing.Point(30, 39);
            this.lb_Master.Name = "lb_Master";
            this.lb_Master.Size = new System.Drawing.Size(71, 15);
            this.lb_Master.TabIndex = 9;
            this.lb_Master.Text = "본클라 경로";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "2클 폴더 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "3클 폴더 이름";
            // 
            // bindingSource1
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Master);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.tb_ThirdName);
            this.Controls.Add(this.tb_SecondName);
            this.Controls.Add(this.btn_FindMaster);
            this.Controls.Add(this.tb_MasterPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "거상 다중 클라이언트 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

