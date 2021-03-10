using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Configuration;

namespace GersangMultipleClientCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            string masterPath = tb_MasterPath.Text;
            string secondPath = tb_SecondName.Text;
            string thirdPath = tb_ThirdName.Text;

            foreach (string target in targetDirectorys)
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
            if (tb_MasterPath == null || tb_SecondName == null || tb_ThirdName == null)
            {
                MessageBox.Show("본클 경로 또는 2,3클 폴더 이름을 지정해주세요.");
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

            //DEBUG//
            //
            //string resultValue = p.StandardOutput.ReadToEnd();
            //
            //DEBUG//

            p.WaitForExit();
            p.Close();

            //DEBUG//
            //
            //MessageBox.Show(resultValue);
            //
            //DEBUG//

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["masterPath"].Value = tb_MasterPath.Text;
            config.AppSettings.Settings["secondName"].Value = tb_SecondName.Text;
            config.AppSettings.Settings["thirdName"].Value = tb_ThirdName.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

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
    }
}
