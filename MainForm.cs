﻿using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Configuration;
using System.Net.Http;
using System.Collections.Generic;

namespace GersangMultipleClientCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            this.Text += Application.ProductVersion; //폼 제목에 최신버전명 붙이기

            //업데이트 유무 확인
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://github.com/byungmeo/GersangMultipleClientCreator/releases/latest");
            response.EnsureSuccessStatusCode();
            string responseUri = response.RequestMessage.RequestUri.ToString();
            string latestVersion = responseUri.Substring(responseUri.Length - 5);
            
            if (latestVersion != Application.ProductVersion)
            {
                DialogResult dr;

                dr = MessageBox.Show("새로운 업데이트 버전(v." + latestVersion + ") 이 있습니다.\n" +
                    "다운로드 주소로 접속하시겠습니까?",
                    "업데이트 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if(dr == DialogResult.OK)
                {
                    var ps = new ProcessStartInfo("https://github.com/byungmeo/GersangMultipleClientCreator/releases/latest")
                    {
                        UseShellExecute = true,
                        Verb = "open"
                    };
                    Process.Start(ps);
                }
            }

            tb_MasterPath.Text = ConfigurationManager.AppSettings["masterPath"];
            tb_SecondName.Text = ConfigurationManager.AppSettings["secondName"];
            tb_ThirdName.Text = ConfigurationManager.AppSettings["thirdName"];
        }

        private void CreateDirectory(ref Process p)
        {
            p.StandardInput.Write(@"mkdir " + tb_SecondName.Text + Environment.NewLine);
            p.StandardInput.Write(@"mkdir " + tb_ThirdName.Text + Environment.NewLine);
        }

        private void CreateSymbolicLink(ref Process p)
        {
            //char, eft, fnt, music, Online, pal, tempeft, Temporary Autopath, tile, yfnt, XIGNCODE
            string[] targetDirectorys = { "char", "eft", "fnt", "music", "Online", "pal", "tempeft", "Temporary Autopath", "tile", "yfnt", "XIGNCODE" };
            List<string> targetDirectorysList = new List<string>(targetDirectorys);

            //사운드 폴더 복사 체크 해제시
            if (!check_Sound.Checked)
            {
                targetDirectorysList.Remove("music");
            }

            string masterPath = tb_MasterPath.Text;
            string secondPath = tb_SecondName.Text;
            string thirdPath = tb_ThirdName.Text;

            foreach (string target in targetDirectorysList)
            {
                //mklink /d \Gersang\char \Gersang2\char
                p.StandardInput.Write(@"mklink /d " + secondPath + @"\" + target + " " + masterPath + @"\" + target + Environment.NewLine);
                p.StandardInput.Write(@"mklink /d " + thirdPath + @"\" + target + " " + masterPath + @"\" + target + Environment.NewLine);
            }
        }

        private void CopyFile()
        {
            //file, .dll, .exe, .ln, .gcs, .gts, .ini, .ico
            string fileName;
            string destFile;
            string sourcePath = tb_MasterPath.Text;
            string secondPath = sourcePath + @"\..\" + tb_SecondName.Text;
            string thirdPath = sourcePath + @"\..\" + tb_ThirdName.Text;

            if(Directory.Exists(sourcePath))
            {
                var Files = Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".dll") || s.EndsWith(".exe") || s.EndsWith(".ln") || s.EndsWith(".gcs")
                || s.EndsWith(".gts") || s.EndsWith(".ini") || s.EndsWith(".ico"));

                foreach (string s in Files)
                {
                    fileName = Path.GetFileName(s);

                    //second
                    destFile = Path.Combine(secondPath, fileName);
                    File.Copy(s, destFile, true);

                    //third
                    destFile = Path.Combine(thirdPath, fileName);
                    File.Copy(s, destFile, true);
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //입력창이 비어있는 경우
            if (tb_MasterPath.TextLength == 0 || tb_SecondName.TextLength == 0 || tb_ThirdName.TextLength == 0)
            {
                MessageBox.Show("본클 경로 또는 2,3클 폴더 이름을 지정해주세요.");
                return;
            }

            //2클과 3클 이름이 같은 경우
            if(tb_SecondName.Text == tb_ThirdName.Text)
            {
                MessageBox.Show("2클과 3클 폴더 이름을 각각 다르게 지정해주세요.");
                return;
            }

            //본클 경로가 거상 폴더가 아닌 경우
            if(Directory.GetFiles(tb_MasterPath.Text, "Gersang.exe", SearchOption.TopDirectoryOnly).Length <= 0)
            {
                MessageBox.Show("제대로 된 거상 경로를 지정해주세요. (Gersang.exe 파일이 있는 경로)");
                return;
            }

            ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            Process p = new System.Diagnostics.Process();

            psi.FileName = @"cmd";
            psi.WorkingDirectory = tb_MasterPath.Text + @"\..";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = false; //IF WANT DEBUG, SET "TRUE"
            psi.RedirectStandardInput = true;
            psi.RedirectStandardError = true;

            p.StartInfo = psi;
            p.Start();

            //CMD 구문 실행
            CreateDirectory(ref p);
            CreateSymbolicLink(ref p);
            Thread.Sleep(500);
            CopyFile();
            //

            p.StandardInput.Close();
            p.WaitForExit();
            p.Close();

            //경로 및 폴더이름 저장
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["masterPath"].Value = tb_MasterPath.Text;
            config.AppSettings.Settings["secondName"].Value = tb_SecondName.Text;
            config.AppSettings.Settings["thirdName"].Value = tb_ThirdName.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //

            MessageBox.Show("생성 및 경로 저장 완료");
        }

        //폴더를 선택하면 해당 폴더 경로를 파라메터인 텍스트박스에 넣는 함수입니다.
        private void FindPath(TextBox pathBox)
        {
            folderBrowserDialog1.SelectedPath = null;
            folderBrowserDialog1.ShowDialog();

            if ((folderBrowserDialog1.SelectedPath.Length) != 0)
            {
                pathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_FindMaster_Click(object sender, EventArgs e)
        {
            FindPath(tb_MasterPath);
        }

        private void tsm_github_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://github.com/byungmeo/GersangMultipleClientCreator/releases")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void tsm_blog_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("www.naver.com")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void check_Sound_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
