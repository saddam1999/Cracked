// Decompiled with JetBrains decompiler
// Type: SHREDDER_AIO_TOOL.Form1
// Assembly: OASIS AIO TOOL, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5CDD5355-9DF5-4ADD-83F8-00F1021EE824
// Assembly location: C:\Users\op\Downloads\B7BSH\OASIS AIO TOOL_4.3_dump-cleaned.exe

using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SHREDDER_AIO_TOOL
{
  public class Form1 : Form
  {
    private string string_0;
    public string userName;
    private string string_1;
    private IContainer icontainer_0;
    private System.Windows.Forms.Panel OdXdxChp4;
    private System.Windows.Forms.Panel panel2;
    private SiticoneButton siticoneButton4;
    private SiticoneButton siticoneButton3;
    private SiticoneButton siticoneButton2;
    private SiticoneButton siticoneButton1;
    private SiticoneButton siticoneButton5;
    private System.Windows.Forms.PictureBox pictureBox1;
    private SiticoneButton siticoneButton6;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private UserControl1 userControl11;
    private UserControl2 userControl21;
    private UserControl3 userControl31;
    private UserControl4 userControl41;
    private SiticoneDragControl siticoneDragControl_0;
    private SiticoneDragControl siticoneDragControl_1;
    private SiticoneDragControl siticoneDragControl_2;
    private SiticoneDragControl siticoneDragControl_3;
    private SiticoneDragControl siticoneDragControl_4;
    private SiticoneDragControl siticoneDragControl_5;
    private SiticoneDragControl siticoneDragControl_6;
    private SiticoneDragControl siticoneDragControl_7;
    private SiticoneDragControl siticoneDragControl_8;
    private SiticoneDragControl siticoneDragControl_9;
    private SiticoneDragControl siticoneDragControl_10;
    private SiticoneDragControl siticoneDragControl_11;
    private Label label5;
    private SiticoneButton siticoneButton7;
    internal static Form1 cB1bXTNUqtTfFWwgkG;

    [DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      int int_4,
      int int_5);

    public Form1()
    {
      Class2.V1XjF0uzuv5J3();
      this.string_0 = string.Empty;
      this.userName = Environment.UserName;
      this.string_1 = string.Empty;
      this.icontainer_0 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vnoGjUsGH();
      this.FormBorderStyle = FormBorderStyle.None;
      this.Region = Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40));
      try
      {
        if (!new WebClient().DownloadString("https://textbin.net/raw/2wt053nwn8").Contains("close 4.3"))
          return;
        int num = (int) MessageBox.Show("Update Available!!! Join Discord For Latest Version.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        using (WebClient webClient = new WebClient())
          this.string_0 = webClient.DownloadString("https://textbin.net/raw/CjdGDRaNxe");
        Process.Start(this.string_0);
        Application.Exit();
        Environment.Exit(0);
      }
      catch
      {
        int num = (int) MessageBox.Show("Offline Mode. Reason:- Either your offline or server down.");
      }
    }

    private void siticoneButton1_Click(object sender, EventArgs e)
    {
      this.userControl11.Hide();
      this.userControl21.Hide();
      this.userControl31.Hide();
      this.userControl41.Hide();
    }

    private void method_0(object sender, EventArgs e)
    {
    }

    private void method_1(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        using (WebClient webClient = new WebClient())
          this.string_1 = webClient.DownloadString("https://textbin.net/raw/FEwyHGW1fs");
        this.label5.Text = this.string_1;
      }
      catch
      {
      }
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
      this.userControl11.Hide();
      this.userControl21.Hide();
      this.userControl31.Hide();
      this.userControl41.Hide();
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "adb.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "AdbWinApi.dll");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "normal.ico");
      this.Cursor = new Cursor("C:\\Windows\\Web\\Wallpaper\\normal.ico");
      string currentDirectory = Environment.CurrentDirectory;
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "adv.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "CCleaner64.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "helper");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "renderer_dx.zip");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32", "files", "g.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32", "files", "k.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32", "files", "v.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32", "files", "t.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "ChangeComputerInfo.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "DefenderControl.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "keymapping.zip");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "click.wav");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "WinUpdatesDisabler_x64.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "UserEngine.ini");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "UserEngine1.ini");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "HiBit.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32", "files", "device.bat");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "guest");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Web\\Wallpaper", "files", "DnsJumper.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Fonts", "files", "Fix Download.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Fonts", "files", "Fix98.exe");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Fonts", "files", "smka.conf");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Fonts", "files", "smk.conf");
      Form1.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\Fonts", "files", "DefaultKeyMapping.xml");
    }

    private void siticoneButton2_Click(object sender, EventArgs e)
    {
      this.userControl31.Hide();
      this.userControl41.Hide();
      this.userControl21.Hide();
      this.userControl11.Show();
      this.userControl11.BringToFront();
    }

    private void userControl21_Load(object sender, EventArgs e)
    {
    }

    private void siticoneButton3_Click(object sender, EventArgs e)
    {
      this.userControl31.Hide();
      this.userControl41.Hide();
      this.userControl11.Hide();
      this.userControl21.Show();
      this.userControl21.BringToFront();
    }

    private void siticoneButton4_Click(object sender, EventArgs e)
    {
      this.userControl11.Hide();
      this.userControl21.Hide();
      this.userControl41.Hide();
      this.userControl31.Show();
      this.userControl31.BringToFront();
    }

    private void siticoneButton5_Click(object sender, EventArgs e)
    {
      this.userControl11.Hide();
      this.userControl21.Hide();
      this.userControl31.Hide();
      this.userControl41.Show();
      this.userControl41.BringToFront();
    }

    private void siticoneButton6_Click(object sender, EventArgs e)
    {
      try
      {
        System.IO.File.Delete("C:\\Windows\\Web\\Wallpaper\\adb.exe");
        System.IO.File.Delete("C:\\Windows\\Web\\Wallpaper\\AdbWinApi.dll");
        System.IO.File.Delete("C:\\Windows\\Web\\Wallpaper\\ChangeComputerInfo.exe");
      }
      catch
      {
      }
      Application.Exit();
    }

    public static void Extract(
      string nameSpace,
      string outDirectory,
      string internalFilePath,
      string resourceName)
    {
      using (Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
      {
        using (BinaryReader binaryReader = new BinaryReader(manifestResourceStream))
        {
          using (FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
          {
            using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
              binaryWriter.Write(binaryReader.ReadBytes((int) manifestResourceStream.Length));
          }
        }
      }
    }

    private void siticoneButton6_MouseClick(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    private void siticoneButton7_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    protected override void Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.icontainer_0 != null ? 1 : 0)) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void vnoGjUsGH()
    {
      this.icontainer_0 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.OdXdxChp4 = new System.Windows.Forms.Panel();
      this.siticoneButton5 = new SiticoneButton();
      this.siticoneButton4 = new SiticoneButton();
      this.siticoneButton3 = new SiticoneButton();
      this.siticoneButton2 = new SiticoneButton();
      this.siticoneButton1 = new SiticoneButton();
      this.panel2 = new System.Windows.Forms.Panel();
      this.siticoneButton7 = new SiticoneButton();
      this.siticoneButton6 = new SiticoneButton();
      this.label1 = new Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.siticoneDragControl_0 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_1 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_2 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_3 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_4 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_5 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_6 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_7 = new SiticoneDragControl(this.icontainer_0);
      this.label5 = new Label();
      this.userControl21 = new UserControl2();
      this.userControl11 = new UserControl1();
      this.userControl41 = new UserControl4();
      this.userControl31 = new UserControl3();
      this.siticoneDragControl_8 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_9 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_10 = new SiticoneDragControl(this.icontainer_0);
      this.siticoneDragControl_11 = new SiticoneDragControl(this.icontainer_0);
      this.OdXdxChp4.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.OdXdxChp4.BackColor = Color.FromArgb(0, 1, 22);
      this.OdXdxChp4.Controls.Add((Control) this.siticoneButton5);
      this.OdXdxChp4.Controls.Add((Control) this.siticoneButton4);
      this.OdXdxChp4.Controls.Add((Control) this.siticoneButton3);
      this.OdXdxChp4.Controls.Add((Control) this.siticoneButton2);
      this.OdXdxChp4.Controls.Add((Control) this.siticoneButton1);
      this.OdXdxChp4.Dock = DockStyle.Bottom;
      this.OdXdxChp4.Location = new Point(0, 370);
      this.OdXdxChp4.Name = "panel1";
      this.OdXdxChp4.Size = new Size(855, 87);
      this.OdXdxChp4.TabIndex = 0;
      this.siticoneButton5.CheckedState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.CustomImages.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.FillColor = Color.Transparent;
      this.siticoneButton5.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.HoveredState.ForeColor = Color.White;
      this.siticoneButton5.HoveredState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.Image = (Image) componentResourceManager.GetObject("siticoneButton5.Image");
      this.siticoneButton5.ImageSize = new Size(40, 40);
      this.siticoneButton5.Location = new Point(683, 11);
      this.siticoneButton5.Name = "siticoneButton5";
      this.siticoneButton5.ShadowDecoration.Parent = (Control) this.siticoneButton5;
      this.siticoneButton5.Size = new Size(160, 64);
      this.siticoneButton5.TabIndex = 3;
      this.siticoneButton5.Text = "SUPPORT";
      this.siticoneButton5.Click += new EventHandler(this.siticoneButton5_Click);
      this.siticoneButton5.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton4.CheckedState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.CustomImages.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.FillColor = Color.Transparent;
      this.siticoneButton4.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.HoveredState.ForeColor = Color.White;
      this.siticoneButton4.HoveredState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.Image = (Image) componentResourceManager.GetObject("siticoneButton4.Image");
      this.siticoneButton4.ImageSize = new Size(40, 40);
      this.siticoneButton4.Location = new Point(505, 11);
      this.siticoneButton4.Name = "siticoneButton4";
      this.siticoneButton4.ShadowDecoration.Parent = (Control) this.siticoneButton4;
      this.siticoneButton4.Size = new Size(172, 64);
      this.siticoneButton4.TabIndex = 2;
      this.siticoneButton4.Text = "DOWNLOAD";
      this.siticoneButton4.Click += new EventHandler(this.siticoneButton4_Click);
      this.siticoneButton4.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton3.CheckedState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.CustomImages.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.FillColor = Color.Transparent;
      this.siticoneButton3.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.HoveredState.ForeColor = Color.White;
      this.siticoneButton3.HoveredState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.Image = (Image) componentResourceManager.GetObject("siticoneButton3.Image");
      this.siticoneButton3.ImageSize = new Size(40, 40);
      this.siticoneButton3.Location = new Point(317, 11);
      this.siticoneButton3.Name = "siticoneButton3";
      this.siticoneButton3.ShadowDecoration.Parent = (Control) this.siticoneButton3;
      this.siticoneButton3.Size = new Size(173, 64);
      this.siticoneButton3.TabIndex = 2;
      this.siticoneButton3.Text = "TOOLS";
      this.siticoneButton3.Click += new EventHandler(this.siticoneButton3_Click);
      this.siticoneButton3.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton2.CheckedState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.CustomImages.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.FillColor = Color.Transparent;
      this.siticoneButton2.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.HoveredState.ForeColor = Color.White;
      this.siticoneButton2.HoveredState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.Image = (Image) componentResourceManager.GetObject("siticoneButton2.Image");
      this.siticoneButton2.ImageSize = new Size(40, 40);
      this.siticoneButton2.Location = new Point(172, 11);
      this.siticoneButton2.Name = "siticoneButton2";
      this.siticoneButton2.ShadowDecoration.Parent = (Control) this.siticoneButton2;
      this.siticoneButton2.Size = new Size(148, 64);
      this.siticoneButton2.TabIndex = 2;
      this.siticoneButton2.Text = "CLEAN";
      this.siticoneButton2.Click += new EventHandler(this.siticoneButton2_Click);
      this.siticoneButton2.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton1.CheckedState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.CustomImages.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.FillColor = Color.Transparent;
      this.siticoneButton1.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.HoveredState.ForeColor = Color.White;
      this.siticoneButton1.HoveredState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.Image = (Image) componentResourceManager.GetObject("siticoneButton1.Image");
      this.siticoneButton1.ImageSize = new Size(40, 40);
      this.siticoneButton1.Location = new Point(12, 11);
      this.siticoneButton1.Name = "siticoneButton1";
      this.siticoneButton1.ShadowDecoration.Parent = (Control) this.siticoneButton1;
      this.siticoneButton1.Size = new Size(154, 64);
      this.siticoneButton1.TabIndex = 1;
      this.siticoneButton1.Text = "HOME";
      this.siticoneButton1.Click += new EventHandler(this.siticoneButton1_Click);
      this.siticoneButton1.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.panel2.BackColor = Color.FromArgb(0, 1, 22);
      this.panel2.Controls.Add((Control) this.siticoneButton7);
      this.panel2.Controls.Add((Control) this.siticoneButton6);
      this.panel2.Controls.Add((Control) this.label1);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(855, 71);
      this.panel2.TabIndex = 1;
      this.siticoneButton7.CheckedState.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.CustomImages.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.FillColor = Color.Transparent;
      this.siticoneButton7.Font = new Font("Segoe UI", 48f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton7.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton7.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton7.HoveredState.ForeColor = Color.White;
      this.siticoneButton7.HoveredState.Parent = (CustomButtonBase) this.siticoneButton7;
      this.siticoneButton7.ImageSize = new Size(30, 30);
      this.siticoneButton7.Location = new Point(717, 9);
      this.siticoneButton7.Name = "siticoneButton7";
      this.siticoneButton7.ShadowDecoration.Parent = (Control) this.siticoneButton7;
      this.siticoneButton7.Size = new Size(60, 44);
      this.siticoneButton7.TabIndex = 4;
      this.siticoneButton7.Text = "-";
      this.siticoneButton7.Click += new EventHandler(this.siticoneButton7_Click);
      this.siticoneButton6.CheckedState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.CustomImages.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.FillColor = Color.Transparent;
      this.siticoneButton6.Font = new Font("Constantia", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.ForeColor = Color.White;
      this.siticoneButton6.HoveredState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.ImageSize = new Size(30, 30);
      this.siticoneButton6.Location = new Point(783, 9);
      this.siticoneButton6.Name = "siticoneButton6";
      this.siticoneButton6.ShadowDecoration.Parent = (Control) this.siticoneButton6;
      this.siticoneButton6.Size = new Size(60, 44);
      this.siticoneButton6.TabIndex = 3;
      this.siticoneButton6.Text = "x";
      this.siticoneButton6.Click += new EventHandler(this.siticoneButton6_Click);
      this.siticoneButton6.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.label1.Font = new Font("Georgia", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(3, 198, 253);
      this.label1.Location = new Point(198, 7);
      this.label1.Name = "label1";
      this.label1.Size = new Size(453, 55);
      this.label1.TabIndex = 3;
      this.label1.Text = "THE OASIS TEAM AIO TOOL";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.pictureBox1.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox1.BackgroundImage");
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
      this.pictureBox1.Location = new Point(527, 77);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(328, 287);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.label2.BackColor = Color.FromArgb(0, 1, 22);
      this.label2.Font = new Font("Georgia", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.FromArgb(3, 198, 253);
      this.label2.Location = new Point(53, 95);
      this.label2.Name = "label2";
      this.label2.Size = new Size(422, 55);
      this.label2.TabIndex = 4;
      this.label2.Text = "WELCOME TO AIO TOOL";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.label3.BackColor = Color.FromArgb(0, 1, 22);
      this.label3.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.FromArgb(3, 198, 253);
      this.label3.Location = new Point(56, 171);
      this.label3.Name = "label3";
      this.label3.Size = new Size(452, 55);
      this.label3.TabIndex = 5;
      this.label3.Text = "THIS TOOL MADE FOR GAMELOOP AND SMARTGAGA.\r\n";
      this.label3.TextAlign = ContentAlignment.MiddleCenter;
      this.label4.BackColor = Color.FromArgb(0, 1, 22);
      this.label4.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.FromArgb(3, 198, 253);
      this.label4.Location = new Point(56, 226);
      this.label4.Name = "label4";
      this.label4.Size = new Size(452, 55);
      this.label4.TabIndex = 6;
      this.label4.Text = "THIS TOOL HELPS YOU TO CLEAN YOUR PC AND SAVE FROM 10 MINUTE BAN.\r\n\r\n";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      this.siticoneDragControl_0.TargetControl = (Control) this;
      this.siticoneDragControl_1.TargetControl = (Control) this.label1;
      this.siticoneDragControl_2.TargetControl = (Control) this.label2;
      this.siticoneDragControl_3.TargetControl = (Control) this.label3;
      this.siticoneDragControl_4.TargetControl = (Control) this.label4;
      this.siticoneDragControl_5.TargetControl = (Control) this.OdXdxChp4;
      this.siticoneDragControl_6.TargetControl = (Control) this.panel2;
      this.siticoneDragControl_7.TargetControl = (Control) this.pictureBox1;
      this.label5.BackColor = Color.FromArgb(0, 1, 22);
      this.label5.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.FromArgb(3, 198, 253);
      this.label5.Location = new Point(12, 309);
      this.label5.Name = "label5";
      this.label5.Size = new Size(509, 55);
      this.label5.TabIndex = 11;
      this.label5.Text = "No Internet!!!";
      this.label5.TextAlign = ContentAlignment.MiddleCenter;
      this.userControl21.BackColor = Color.FromArgb(0, 1, 22);
      this.userControl21.Dock = DockStyle.Fill;
      this.userControl21.Location = new Point(0, 0);
      this.userControl21.Margin = new Padding(4);
      this.userControl21.Name = "userControl21";
      this.userControl21.Size = new Size(855, 457);
      this.userControl21.TabIndex = 8;
      this.userControl21.Load += new EventHandler(this.userControl21_Load);
      this.userControl11.Dock = DockStyle.Fill;
      this.userControl11.Location = new Point(0, 0);
      this.userControl11.Margin = new Padding(4);
      this.userControl11.Name = "userControl11";
      this.userControl11.Size = new Size(855, 457);
      this.userControl11.TabIndex = 7;
      this.userControl41.Dock = DockStyle.Fill;
      this.userControl41.Location = new Point(0, 0);
      this.userControl41.Margin = new Padding(4);
      this.userControl41.Name = "userControl41";
      this.userControl41.Size = new Size(855, 457);
      this.userControl41.TabIndex = 10;
      this.userControl31.Dock = DockStyle.Fill;
      this.userControl31.Location = new Point(0, 0);
      this.userControl31.Margin = new Padding(4);
      this.userControl31.Name = "userControl31";
      this.userControl31.Size = new Size(855, 457);
      this.userControl31.TabIndex = 9;
      this.siticoneDragControl_8.TargetControl = (Control) this.userControl11;
      this.siticoneDragControl_9.TargetControl = (Control) this.userControl21;
      this.siticoneDragControl_10.TargetControl = (Control) this.userControl31;
      this.siticoneDragControl_11.TargetControl = (Control) this.userControl41;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(0, 1, 22);
      this.ClientSize = new Size(855, 457);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.OdXdxChp4);
      this.Controls.Add((Control) this.userControl21);
      this.Controls.Add((Control) this.userControl11);
      this.Controls.Add((Control) this.userControl41);
      this.Controls.Add((Control) this.userControl31);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.OdXdxChp4.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    internal static void bWKpde538vMytI8i4t()
    {
    }

    internal static bool fxiM1KRksVnRRHLVfi() => Form1.cB1bXTNUqtTfFWwgkG == null;
  }
}
