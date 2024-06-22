using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMP4toWAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void selectFFmpegBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                ffmpegPath.Text = file;
            }
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folder = folderBrowserDialog1.SelectedPath;
                folderPath.Text = folder;
            }
        }


        bool isWatching = false;
        FileSystemWatcher watcher;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isWatching)
            {
                // 監視開始

                // フォルダとFFmpegが指定されているかチェック
                if (ffmpegPath.Text == "")
                {
                    MessageBox.Show("FFmpegのパスを指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (folderPath.Text == "")
                {
                    MessageBox.Show("監視するフォルダを指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ffmpeg = ffmpegPath.Text;
                string folder = folderPath.Text; // 監視するフォルダ
                string filter = "*.mp4"; // 監視するファイルの拡張子

                watcher = new FileSystemWatcher(folder); //インスタンス生成＆監視するフォルダを指定
                watcher.Filter = filter; //監視するファイルの拡張子を指定

                watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName; //監視する内容を指定
                watcher.IncludeSubdirectories = false; //サブディレクトリも監視するかどうか
                
                watcher.Created += new FileSystemEventHandler(OnCreated); //ファイルが作成された時のイベントハンドラ
                watcher.EnableRaisingEvents = true; //監視を開始する

                Debug.WriteLine("監視するフォルダ：" + folder);
                Debug.WriteLine("監視状態："+watcher.EnableRaisingEvents);
                ShowLogText("監視が開始されました");

                isWatching = true;
                button1.Text = "ていし！";

            } else {
                // 監視停止
                // 監視を停止する
                watcher.EnableRaisingEvents = false;
                
                button1.Text = "じっこう！！！";
                isWatching = false;

                Debug.WriteLine("監視状態：" + watcher.EnableRaisingEvents);
                ShowLogText("監視が停止されました");

                return;
            }
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            // ファイルが作成された時の処理
            // ファイル名を取得
            string fileName = e.Name;

            // ログに "FileNameが作成されました 日時"と表示
            Console.WriteLine(fileName + "が作成されました " + DateTime.Now);
            ShowLogText(fileName + "が作成されました");

            // 追加されたファイルのパスを取得
            string filePath = e.FullPath;

            // ffmpegでコマンドを実行
            string ffmpeg = ffmpegPath.Text;

            string cmd = "-i \"" + filePath + "\" -ac 2 -ar 44100 -acodec pcm_s16le -f wav \"" + folderPath.Text + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".wav\"";
            ShowLogText("コマンドを実行しています");
            Debug.WriteLine(cmd);
            // コマンドを実行
            var proc = new Process();
            proc.StartInfo.FileName = ffmpeg;
            proc.StartInfo.Arguments = cmd;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            
            ShowLogText("コマンドが実行されました");
        }

        private void ShowLogText(string text)
        {
            // ログにテキストを設定 "FileName"が作成されました 日時"と表示
            if (logText.InvokeRequired)
            {
                // UI スレッドで実行するために Invoke を使用
                logText.Invoke(new Action<string>(ShowLogText), text);
            }
            else
            {
                // 安全にコントロールにアクセス
                logText.Text = text + " " + DateTime.Now;
            }
        }


    }
}
