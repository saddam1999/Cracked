// Decompiled with JetBrains decompiler
// Type: SHREDDER_AIO_TOOL.UserControl3
// Assembly: OASIS AIO TOOL, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5CDD5355-9DF5-4ADD-83F8-00F1021EE824
// Assembly location: C:\Users\op\Downloads\B7BSH\OASIS AIO TOOL_4.3_dump-cleaned.exe

using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace SHREDDER_AIO_TOOL
{
  public class UserControl3 : UserControl
  {
    private BackgroundWorker backgroundWorker_0;
    private WebClient webClient_0;
    public string userName;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_13;
    private string string_14;
    private IContainer icontainer_0;
    private Label label1;
    private SiticoneButton siticoneButton6;
    private SiticoneLabel lblStatus;
    private SiticoneLabel siticoneLabel1;
    private SiticoneProgressBar siticoneProgressBar1;
    private SiticoneButton siticoneButton1;
    private SiticoneButton siticoneButton2;
    private SiticoneButton siticoneButton3;
    private SiticoneButton siticoneButton4;
    private SiticoneButton siticoneButton5;
    private SiticoneButton siticoneButton7;
    private SiticoneButton siticoneButton8;
    private SiticoneButton siticoneButton9;
    private SiticoneButton siticoneButton10;
    private SiticoneLabel lblIn;
    private SiticoneButton siticoneButton11;
    private SiticoneButton siticoneButton13;
    private SiticoneButton siticoneButton12;
    private SiticoneButton siticoneButton14;
    private SiticoneButton siticoneButton15;
    private SiticoneButton siticoneButton16;
    internal static UserControl3 kfsUPZWmrQy1cQEwshq;

    public UserControl3()
    {
      Class2.V1XjF0uzuv5J3();
      this.backgroundWorker_0 = new BackgroundWorker();
      this.userName = Environment.UserName;
      this.string_0 = string.Empty;
      this.string_1 = string.Empty;
      this.string_2 = string.Empty;
      this.string_3 = string.Empty;
      this.string_4 = string.Empty;
      this.string_5 = string.Empty;
      this.string_6 = string.Empty;
      this.string_7 = string.Empty;
      this.string_8 = string.Empty;
      this.string_9 = string.Empty;
      this.string_10 = string.Empty;
      this.string_11 = string.Empty;
      this.string_12 = string.Empty;
      this.string_13 = string.Empty;
      this.string_14 = string.Empty;
      this.icontainer_0 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void method_0(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    private void siticoneButton6_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Oasis GaGa.rar"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_6 = this.webClient_0.DownloadString("https://textbin.net/raw/pE82cJYBKq");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_6), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Oasis GaGa.rar");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void webClient_0_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
      int num = (int) MessageBox.Show("Download Completed!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.siticoneProgressBar1.Value = 0;
      this.lblIn.Text = "";
      this.lblStatus.Text = "";
    }

    private void webClient_0_DownloadProgressChanged(
      object sender,
      DownloadProgressChangedEventArgs e)
    {
      UserControl3 userControl3_0 = this;
      DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0 = e;
      this.Invoke((Delegate) (() =>
      {
        userControl3_0.siticoneProgressBar1.Minimum = 0;
        double d = double.Parse(downloadProgressChangedEventArgs_0.BytesReceived.ToString()) / double.Parse(downloadProgressChangedEventArgs_0.TotalBytesToReceive.ToString()) * 100.0;
        userControl3_0.lblStatus.Text = string.Format("{0:0.#}", (object) d) + "%";
        SiticoneLabel lblIn = userControl3_0.lblIn;
        double num = (double) downloadProgressChangedEventArgs_0.BytesReceived / 1024.0 / 1024.0;
        string str1 = num.ToString("0.00");
        num = (double) downloadProgressChangedEventArgs_0.TotalBytesToReceive / 1024.0 / 1024.0;
        string str2 = num.ToString("0.00");
        string str3 = string.Format("{0} MB's / {1} MB's", (object) str1, (object) str2);
        lblIn.Text = str3;
        userControl3_0.siticoneProgressBar1.Value = int.Parse(Math.Truncate(d).ToString());
      }));
    }

    private void siticoneButton1_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\SmartGaga.v1.1.646.1.exe"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_3 = this.webClient_0.DownloadString("https://textbin.net/raw/wTTKIfHaeX");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_3), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\SmartGaga.v1.1.646.1.exe");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton10_Click(object sender, EventArgs e) => Process.Start("explorer.exe", "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");

    private void siticoneButton2_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\twitter.apk"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_9 = this.webClient_0.DownloadString("https://textbin.net/raw/g3L52SCnE9");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_9), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\twitter.apk");
      }
    }

    private void siticoneButton3_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\fx.apk"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_2 = this.webClient_0.DownloadString("https://textbin.net/raw/Zy1r3TUVzm");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_2), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\fx.apk");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton9_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\AIO Runtimes.exe"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_0 = this.webClient_0.DownloadString("https://textbin.net/raw/ntHBazNLhW");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_0), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\AIO Runtimes.exe");
      }
    }

    private void siticoneButton4_Click(object sender, EventArgs e)
    {
      this.backgroundWorker_0.RunWorkerAsync();
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_GLOBAL.rar"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_4 = this.webClient_0.DownloadString("https://textbin.net/raw/rmQuHPbZY0");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_4), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_GLOBAL.rar");
      }
    }

    private void siticoneButton5_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_KOREA.zip"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_5 = this.webClient_0.DownloadString("https://textbin.net/raw/pOmTx8fhkQ");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_5), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_KOREA.zip");
      }
    }

    private void siticoneButton7_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_VNG.zip"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_10 = this.webClient_0.DownloadString("https://textbin.net/raw/roh5pDULmL");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_10), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_VNG.zip");
      }
    }

    private void siticoneButton8_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_TAIWAN.zip"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_8 = this.webClient_0.DownloadString("https://textbin.net/raw/tZ7wDtAzVt");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_8), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\PUBG_TAIWAN.zip");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton11_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Full Driver.zip"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_1 = this.webClient_0.DownloadString("https://textbin.net/raw/kZYxfFBtrP");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_1), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Full Driver.zip");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton13_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\services.rar"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_7 = this.webClient_0.DownloadString("https://textbin.net/raw/ipz3rhbf0j");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_7), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\services.rar");
      }
    }

    private void UserControl3_Load(object sender, EventArgs e)
    {
    }

    public void ProcessFile(StreamReader Reader)
    {
      this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.ewtFdumuaZ);
      this.backgroundWorker_0.RunWorkerAsync((object) Reader);
    }

    public void CancelProcessFile() => this.backgroundWorker_0.CancelAsync();

    private void ewtFdumuaZ(object sender, DoWorkEventArgs e)
    {
      if (!(e.Argument is StreamReader streamReader))
        return;
      while ((streamReader.Peek() == -1 ? 0 : (!((BackgroundWorker) sender).CancellationPending ? 1 : 0)) != 0)
        streamReader.ReadLine();
    }

    private void siticoneButton12_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop_4.4.exe"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_13 = this.webClient_0.DownloadString("https://textbin.net/raw/w8j2enikto");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_13), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop_4.4.exe");
      }
    }

    private void siticoneButton14_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop7.1China.exe"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_14 = this.webClient_0.DownloadString("https://textbin.net/raw/ipz3rhbf0j");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_14), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop7.1China.exe");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton16_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (!System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop7.1Global.exe"))
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_14 = this.webClient_0.DownloadString("https://textbin.net/raw/7ahhq8i3rs");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_14), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop7.1Global.exe");
      }
      else
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void siticoneButton15_Click(object sender, EventArgs e)
    {
      string path = Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
      try
      {
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
      if (System.IO.File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop4.4China.exe"))
      {
        int num = (int) MessageBox.Show("File Already Downloaded. Please Open OASIS Downloads Folder.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.webClient_0 = new WebClient();
        this.webClient_0.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.webClient_0_DownloadProgressChanged);
        this.webClient_0.DownloadFileCompleted += new AsyncCompletedEventHandler(this.webClient_0_DownloadFileCompleted);
        this.string_13 = this.webClient_0.DownloadString("https://textbin.net/raw/iqlfiur3j8");
        this.webClient_0.DownloadFileAsync(new Uri(this.string_13), "C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\Gameloop4.4China.exe");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.icontainer_0 != null ? 1 : 0)) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.siticoneButton6 = new SiticoneButton();
      this.lblStatus = new SiticoneLabel();
      this.siticoneLabel1 = new SiticoneLabel();
      this.siticoneProgressBar1 = new SiticoneProgressBar();
      this.siticoneButton1 = new SiticoneButton();
      this.siticoneButton2 = new SiticoneButton();
      this.siticoneButton3 = new SiticoneButton();
      this.siticoneButton4 = new SiticoneButton();
      this.siticoneButton5 = new SiticoneButton();
      this.siticoneButton7 = new SiticoneButton();
      this.siticoneButton8 = new SiticoneButton();
      this.siticoneButton9 = new SiticoneButton();
      this.siticoneButton10 = new SiticoneButton();
      this.lblIn = new SiticoneLabel();
      this.siticoneButton11 = new SiticoneButton();
      this.siticoneButton13 = new SiticoneButton();
      this.siticoneButton12 = new SiticoneButton();
      this.siticoneButton14 = new SiticoneButton();
      this.siticoneButton15 = new SiticoneButton();
      this.siticoneButton16 = new SiticoneButton();
      this.SuspendLayout();
      this.label1.Font = new Font("Georgia", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(3, 198, 253);
      this.label1.Location = new Point(207, 6);
      this.label1.Name = "label1";
      this.label1.Size = new Size(422, 34);
      this.label1.TabIndex = 10;
      this.label1.Text = "DOWNLOADS";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.siticoneButton6.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.BorderRadius = 1;
      this.siticoneButton6.BorderThickness = 1;
      this.siticoneButton6.CheckedState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.CustomImages.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.FillColor = Color.Transparent;
      this.siticoneButton6.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.HoveredState.ForeColor = Color.White;
      this.siticoneButton6.HoveredState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.ImageSize = new Size(40, 40);
      this.siticoneButton6.Location = new Point(360, (int) sbyte.MaxValue);
      this.siticoneButton6.Name = "siticoneButton6";
      this.siticoneButton6.ShadowDecoration.Parent = (Control) this.siticoneButton6;
      this.siticoneButton6.Size = new Size(129, 42);
      this.siticoneButton6.TabIndex = 17;
      this.siticoneButton6.Text = "OASIS GaGa";
      this.siticoneButton6.Click += new EventHandler(this.siticoneButton6_Click);
      this.lblStatus.AutoSize = false;
      this.lblStatus.BackColor = Color.Transparent;
      this.lblStatus.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblStatus.ForeColor = Color.FromArgb(3, 198, 252);
      this.lblStatus.Location = new Point(482, 271);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(73, 18);
      this.lblStatus.TabIndex = 18;
      this.lblStatus.Text = (string) null;
      this.lblStatus.TextAlignment = ContentAlignment.MiddleCenter;
      this.siticoneLabel1.AutoSize = false;
      this.siticoneLabel1.BackColor = Color.Transparent;
      this.siticoneLabel1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneLabel1.ForeColor = Color.FromArgb(3, 198, 252);
      this.siticoneLabel1.Location = new Point(86, 258);
      this.siticoneLabel1.Name = "siticoneLabel1";
      this.siticoneLabel1.Size = new Size(112, 19);
      this.siticoneLabel1.TabIndex = 20;
      this.siticoneLabel1.Text = "Download Status :";
      this.siticoneProgressBar1.BorderColor = Color.White;
      this.siticoneProgressBar1.BorderRadius = 1;
      this.siticoneProgressBar1.BorderThickness = 1;
      this.siticoneProgressBar1.FillColor = Color.White;
      this.siticoneProgressBar1.GradientMode = LinearGradientMode.Horizontal;
      this.siticoneProgressBar1.Location = new Point(238, 245);
      this.siticoneProgressBar1.Name = "siticoneProgressBar1";
      this.siticoneProgressBar1.ProgressColor = Color.Aqua;
      this.siticoneProgressBar1.ProgressColor2 = Color.Navy;
      this.siticoneProgressBar1.ShadowDecoration.Parent = (Control) this.siticoneProgressBar1;
      this.siticoneProgressBar1.Size = new Size(305, 18);
      this.siticoneProgressBar1.TabIndex = 21;
      this.siticoneProgressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
      this.siticoneButton1.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.BorderRadius = 1;
      this.siticoneButton1.BorderThickness = 1;
      this.siticoneButton1.CheckedState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.CustomImages.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.FillColor = Color.Transparent;
      this.siticoneButton1.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.HoveredState.ForeColor = Color.White;
      this.siticoneButton1.HoveredState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.ImageSize = new Size(40, 40);
      this.siticoneButton1.Location = new Point(198, 179);
      this.siticoneButton1.Name = "siticoneButton1";
      this.siticoneButton1.ShadowDecoration.Parent = (Control) this.siticoneButton1;
      this.siticoneButton1.Size = new Size(129, 42);
      this.siticoneButton1.TabIndex = 22;
      this.siticoneButton1.Text = "Original GaGa";
      this.siticoneButton1.Click += new EventHandler(this.siticoneButton1_Click);
      this.siticoneButton2.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.BorderRadius = 1;
      this.siticoneButton2.BorderThickness = 1;
      this.siticoneButton2.CheckedState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.CustomImages.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.FillColor = Color.Transparent;
      this.siticoneButton2.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.HoveredState.ForeColor = Color.White;
      this.siticoneButton2.HoveredState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.ImageSize = new Size(40, 40);
      this.siticoneButton2.Location = new Point(40, 122);
      this.siticoneButton2.Name = "siticoneButton2";
      this.siticoneButton2.ShadowDecoration.Parent = (Control) this.siticoneButton2;
      this.siticoneButton2.Size = new Size(129, 42);
      this.siticoneButton2.TabIndex = 23;
      this.siticoneButton2.Text = "Twitter";
      this.siticoneButton2.Click += new EventHandler(this.siticoneButton2_Click);
      this.siticoneButton3.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.BorderRadius = 1;
      this.siticoneButton3.BorderThickness = 1;
      this.siticoneButton3.CheckedState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.CustomImages.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.FillColor = Color.Transparent;
      this.siticoneButton3.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.HoveredState.ForeColor = Color.White;
      this.siticoneButton3.HoveredState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.ImageSize = new Size(40, 40);
      this.siticoneButton3.Location = new Point(198, 122);
      this.siticoneButton3.Name = "siticoneButton3";
      this.siticoneButton3.ShadowDecoration.Parent = (Control) this.siticoneButton3;
      this.siticoneButton3.Size = new Size(129, 42);
      this.siticoneButton3.TabIndex = 24;
      this.siticoneButton3.Text = "FX File Manager";
      this.siticoneButton3.Click += new EventHandler(this.siticoneButton3_Click);
      this.siticoneButton4.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.BorderRadius = 1;
      this.siticoneButton4.BorderThickness = 1;
      this.siticoneButton4.CheckedState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.CustomImages.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.FillColor = Color.Transparent;
      this.siticoneButton4.Font = new Font("Georgia", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.HoveredState.ForeColor = Color.White;
      this.siticoneButton4.HoveredState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.ImageSize = new Size(40, 40);
      this.siticoneButton4.Location = new Point(40, 62);
      this.siticoneButton4.Name = "siticoneButton4";
      this.siticoneButton4.ShadowDecoration.Parent = (Control) this.siticoneButton4;
      this.siticoneButton4.Size = new Size(129, 42);
      this.siticoneButton4.TabIndex = 25;
      this.siticoneButton4.Text = "PUBG Global";
      this.siticoneButton4.Click += new EventHandler(this.siticoneButton4_Click);
      this.siticoneButton5.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.BorderRadius = 1;
      this.siticoneButton5.BorderThickness = 1;
      this.siticoneButton5.CheckedState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.CustomImages.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.FillColor = Color.Transparent;
      this.siticoneButton5.Font = new Font("Georgia", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.HoveredState.ForeColor = Color.White;
      this.siticoneButton5.HoveredState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.ImageSize = new Size(40, 40);
      this.siticoneButton5.Location = new Point(198, 62);
      this.siticoneButton5.Name = "siticoneButton5";
      this.siticoneButton5.ShadowDecoration.Parent = (Control) this.siticoneButton5;
      this.siticoneButton5.Size = new Size(129, 42);
      this.siticoneButton5.TabIndex = 26;
      this.siticoneButton5.Text = "PUBG Korea";
      this.siticoneButton5.Click += new EventHandler(this.siticoneButton5_Click);
      this.siticoneButton7.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton7.BorderRadius = 1;
      this.siticoneButton7.BorderThickness = 1;
      this.siticoneButton7.CheckedState.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.CustomImages.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.FillColor = Color.Transparent;
      this.siticoneButton7.Font = new Font("Georgia", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton7.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton7.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton7.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton7.HoveredState.ForeColor = Color.White;
      this.siticoneButton7.HoveredState.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.ImageSize = new Size(40, 40);
      this.siticoneButton7.Location = new Point(528, 62);
      this.siticoneButton7.Name = "siticoneButton7";
      this.siticoneButton7.ShadowDecoration.Parent = (Control) this.siticoneButton7;
      this.siticoneButton7.Size = new Size(129, 42);
      this.siticoneButton7.TabIndex = 27;
      this.siticoneButton7.Text = "PUBG VNG";
      this.siticoneButton7.Click += new EventHandler(this.siticoneButton7_Click);
      this.siticoneButton8.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton8.BorderRadius = 1;
      this.siticoneButton8.BorderThickness = 1;
      this.siticoneButton8.CheckedState.Parent = (CustomButtonBase) this.siticoneButton8;
      this.siticoneButton8.CustomImages.Parent = (CustomButtonBase) this.siticoneButton8;
      this.siticoneButton8.FillColor = Color.Transparent;
      this.siticoneButton8.Font = new Font("Georgia", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton8.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton8.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton8.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton8.HoveredState.ForeColor = Color.White;
      this.siticoneButton8.HoveredState.Parent = (CustomButtonBase) this.siticoneButton8;
      this.siticoneButton8.ImageSize = new Size(40, 40);
      this.siticoneButton8.Location = new Point(360, 62);
      this.siticoneButton8.Name = "siticoneButton8";
      this.siticoneButton8.ShadowDecoration.Parent = (Control) this.siticoneButton8;
      this.siticoneButton8.Size = new Size(129, 42);
      this.siticoneButton8.TabIndex = 28;
      this.siticoneButton8.Text = "PUBG Taiwan";
      this.siticoneButton8.Click += new EventHandler(this.siticoneButton8_Click);
      this.siticoneButton9.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton9.BorderRadius = 1;
      this.siticoneButton9.BorderThickness = 1;
      this.siticoneButton9.CheckedState.Parent = (CustomButtonBase) this.siticoneButton9;
      this.siticoneButton9.CustomImages.Parent = (CustomButtonBase) this.siticoneButton9;
      this.siticoneButton9.FillColor = Color.Transparent;
      this.siticoneButton9.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton9.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton9.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton9.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton9.HoveredState.ForeColor = Color.White;
      this.siticoneButton9.HoveredState.Parent = (CustomButtonBase) this.siticoneButton9;
      this.siticoneButton9.ImageSize = new Size(40, 40);
      this.siticoneButton9.Location = new Point(38, 179);
      this.siticoneButton9.Name = "siticoneButton9";
      this.siticoneButton9.ShadowDecoration.Parent = (Control) this.siticoneButton9;
      this.siticoneButton9.Size = new Size(131, 42);
      this.siticoneButton9.TabIndex = 29;
      this.siticoneButton9.Text = "AIO Runtimes";
      this.siticoneButton9.Click += new EventHandler(this.siticoneButton9_Click);
      this.siticoneButton10.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton10.BorderRadius = 1;
      this.siticoneButton10.BorderThickness = 1;
      this.siticoneButton10.CheckedState.Parent = (CustomButtonBase) this.siticoneButton10;
      this.siticoneButton10.CustomImages.Parent = (CustomButtonBase) this.siticoneButton10;
      this.siticoneButton10.FillColor = Color.Transparent;
      this.siticoneButton10.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton10.ForeColor = Color.White;
      this.siticoneButton10.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton10.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton10.HoveredState.ForeColor = Color.White;
      this.siticoneButton10.HoveredState.Parent = (CustomButtonBase) this.siticoneButton10;
      this.siticoneButton10.ImageSize = new Size(40, 40);
      this.siticoneButton10.Location = new Point(622, 247);
      this.siticoneButton10.Name = "siticoneButton10";
      this.siticoneButton10.ShadowDecoration.Parent = (Control) this.siticoneButton10;
      this.siticoneButton10.Size = new Size(129, 42);
      this.siticoneButton10.TabIndex = 30;
      this.siticoneButton10.Text = "Open Downloads";
      this.siticoneButton10.Click += new EventHandler(this.siticoneButton10_Click);
      this.lblIn.AutoSize = false;
      this.lblIn.BackColor = Color.Transparent;
      this.lblIn.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblIn.ForeColor = Color.FromArgb(3, 198, 252);
      this.lblIn.Location = new Point(238, 267);
      this.lblIn.Name = "lblIn";
      this.lblIn.Size = new Size(238, 21);
      this.lblIn.TabIndex = 32;
      this.lblIn.Text = (string) null;
      this.lblIn.TextAlignment = ContentAlignment.MiddleLeft;
      this.siticoneButton11.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton11.BorderRadius = 1;
      this.siticoneButton11.BorderThickness = 1;
      this.siticoneButton11.CheckedState.Parent = (CustomButtonBase) this.siticoneButton11;
      this.siticoneButton11.CustomImages.Parent = (CustomButtonBase) this.siticoneButton11;
      this.siticoneButton11.FillColor = Color.Transparent;
      this.siticoneButton11.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton11.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton11.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton11.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton11.HoveredState.ForeColor = Color.White;
      this.siticoneButton11.HoveredState.Parent = (CustomButtonBase) this.siticoneButton11;
      this.siticoneButton11.ImageSize = new Size(40, 40);
      this.siticoneButton11.Location = new Point(360, 179);
      this.siticoneButton11.Name = "siticoneButton11";
      this.siticoneButton11.ShadowDecoration.Parent = (Control) this.siticoneButton11;
      this.siticoneButton11.Size = new Size(129, 42);
      this.siticoneButton11.TabIndex = 33;
      this.siticoneButton11.Text = "Full Drivers";
      this.siticoneButton11.Click += new EventHandler(this.siticoneButton11_Click);
      this.siticoneButton13.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton13.BorderRadius = 1;
      this.siticoneButton13.BorderThickness = 1;
      this.siticoneButton13.CheckedState.Parent = (CustomButtonBase) this.siticoneButton13;
      this.siticoneButton13.CustomImages.Parent = (CustomButtonBase) this.siticoneButton13;
      this.siticoneButton13.FillColor = Color.Transparent;
      this.siticoneButton13.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton13.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton13.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton13.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton13.HoveredState.ForeColor = Color.White;
      this.siticoneButton13.HoveredState.Parent = (CustomButtonBase) this.siticoneButton13;
      this.siticoneButton13.ImageSize = new Size(40, 40);
      this.siticoneButton13.Location = new Point(528, 122);
      this.siticoneButton13.Name = "siticoneButton13";
      this.siticoneButton13.ShadowDecoration.Parent = (Control) this.siticoneButton13;
      this.siticoneButton13.Size = new Size(129, 42);
      this.siticoneButton13.TabIndex = 35;
      this.siticoneButton13.Text = "Google Services Fix";
      this.siticoneButton13.Click += new EventHandler(this.siticoneButton13_Click);
      this.siticoneButton12.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton12.BorderRadius = 1;
      this.siticoneButton12.BorderThickness = 1;
      this.siticoneButton12.CheckedState.Parent = (CustomButtonBase) this.siticoneButton12;
      this.siticoneButton12.CustomImages.Parent = (CustomButtonBase) this.siticoneButton12;
      this.siticoneButton12.FillColor = Color.Transparent;
      this.siticoneButton12.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton12.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton12.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton12.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton12.HoveredState.ForeColor = Color.White;
      this.siticoneButton12.HoveredState.Parent = (CustomButtonBase) this.siticoneButton12;
      this.siticoneButton12.ImageSize = new Size(40, 40);
      this.siticoneButton12.Location = new Point(528, 179);
      this.siticoneButton12.Name = "siticoneButton12";
      this.siticoneButton12.ShadowDecoration.Parent = (Control) this.siticoneButton12;
      this.siticoneButton12.Size = new Size(129, 42);
      this.siticoneButton12.TabIndex = 36;
      this.siticoneButton12.Text = "Gameloop 4.4";
      this.siticoneButton12.Click += new EventHandler(this.siticoneButton12_Click);
      this.siticoneButton14.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton14.BorderRadius = 1;
      this.siticoneButton14.BorderThickness = 1;
      this.siticoneButton14.CheckedState.Parent = (CustomButtonBase) this.siticoneButton14;
      this.siticoneButton14.CustomImages.Parent = (CustomButtonBase) this.siticoneButton14;
      this.siticoneButton14.FillColor = Color.Transparent;
      this.siticoneButton14.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton14.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton14.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton14.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton14.HoveredState.ForeColor = Color.White;
      this.siticoneButton14.HoveredState.Parent = (CustomButtonBase) this.siticoneButton14;
      this.siticoneButton14.ImageSize = new Size(40, 40);
      this.siticoneButton14.Location = new Point(687, 62);
      this.siticoneButton14.Name = "siticoneButton14";
      this.siticoneButton14.ShadowDecoration.Parent = (Control) this.siticoneButton14;
      this.siticoneButton14.Size = new Size(129, 42);
      this.siticoneButton14.TabIndex = 37;
      this.siticoneButton14.Text = "Gameloop 7.1 Chinese";
      this.siticoneButton14.Click += new EventHandler(this.siticoneButton14_Click);
      this.siticoneButton15.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton15.BorderRadius = 1;
      this.siticoneButton15.BorderThickness = 1;
      this.siticoneButton15.CheckedState.Parent = (CustomButtonBase) this.siticoneButton15;
      this.siticoneButton15.CustomImages.Parent = (CustomButtonBase) this.siticoneButton15;
      this.siticoneButton15.FillColor = Color.Transparent;
      this.siticoneButton15.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton15.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton15.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton15.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton15.HoveredState.ForeColor = Color.White;
      this.siticoneButton15.HoveredState.Parent = (CustomButtonBase) this.siticoneButton15;
      this.siticoneButton15.ImageSize = new Size(40, 40);
      this.siticoneButton15.Location = new Point(687, 179);
      this.siticoneButton15.Name = "siticoneButton15";
      this.siticoneButton15.ShadowDecoration.Parent = (Control) this.siticoneButton15;
      this.siticoneButton15.Size = new Size(129, 42);
      this.siticoneButton15.TabIndex = 38;
      this.siticoneButton15.Text = "Gamelopp 4.4 Chinese";
      this.siticoneButton15.Click += new EventHandler(this.siticoneButton15_Click);
      this.siticoneButton16.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton16.BorderRadius = 1;
      this.siticoneButton16.BorderThickness = 1;
      this.siticoneButton16.CheckedState.Parent = (CustomButtonBase) this.siticoneButton16;
      this.siticoneButton16.CustomImages.Parent = (CustomButtonBase) this.siticoneButton16;
      this.siticoneButton16.FillColor = Color.Transparent;
      this.siticoneButton16.Font = new Font("Georgia", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton16.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton16.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton16.HoveredState.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton16.HoveredState.ForeColor = Color.White;
      this.siticoneButton16.HoveredState.Parent = (CustomButtonBase) this.siticoneButton16;
      this.siticoneButton16.ImageSize = new Size(40, 40);
      this.siticoneButton16.Location = new Point(687, 122);
      this.siticoneButton16.Name = "siticoneButton16";
      this.siticoneButton16.ShadowDecoration.Parent = (Control) this.siticoneButton16;
      this.siticoneButton16.Size = new Size(129, 42);
      this.siticoneButton16.TabIndex = 39;
      this.siticoneButton16.Text = "Gamelopp 7.1";
      this.siticoneButton16.Click += new EventHandler(this.siticoneButton16_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.siticoneButton16);
      this.Controls.Add((Control) this.siticoneButton15);
      this.Controls.Add((Control) this.siticoneButton14);
      this.Controls.Add((Control) this.siticoneButton12);
      this.Controls.Add((Control) this.siticoneButton13);
      this.Controls.Add((Control) this.siticoneButton11);
      this.Controls.Add((Control) this.lblIn);
      this.Controls.Add((Control) this.siticoneButton10);
      this.Controls.Add((Control) this.siticoneButton9);
      this.Controls.Add((Control) this.siticoneButton8);
      this.Controls.Add((Control) this.siticoneButton7);
      this.Controls.Add((Control) this.siticoneButton5);
      this.Controls.Add((Control) this.siticoneButton4);
      this.Controls.Add((Control) this.siticoneButton3);
      this.Controls.Add((Control) this.siticoneButton2);
      this.Controls.Add((Control) this.siticoneButton1);
      this.Controls.Add((Control) this.siticoneProgressBar1);
      this.Controls.Add((Control) this.siticoneLabel1);
      this.Controls.Add((Control) this.lblStatus);
      this.Controls.Add((Control) this.siticoneButton6);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (UserControl3);
      this.Size = new Size(836, 299);
      this.Load += new EventHandler(this.UserControl3_Load);
      this.ResumeLayout(false);
    }

    internal static bool kjEmySWfrkpoZelurtp() => UserControl3.kfsUPZWmrQy1cQEwshq == null;
  }
}
