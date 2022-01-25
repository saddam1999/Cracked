// Decompiled with JetBrains decompiler
// Type: SHREDDER_AIO_TOOL.UserControl1
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
using System.Windows.Forms;

namespace SHREDDER_AIO_TOOL
{
  public class UserControl1 : UserControl
  {
    private IContainer icontainer_0;
    private SiticoneButton siticoneButton1;
    private SiticoneButton siticoneButton2;
    private SiticoneButton siticoneButton3;
    private SiticoneButton siticoneButton4;
    private SiticoneButton siticoneButton5;
    private SiticoneButton siticoneButton6;
    private Label label1;
    private static UserControl1 VpBVdD4af397ZNdUu5;

    public UserControl1()
    {
      Class2.V1XjF0uzuv5J3();
      this.icontainer_0 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void siticoneButton1_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        CreateNoWindow = true,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process.Start();
      using (StreamWriter standardInput = process.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("taskkill /f /im dnf.exe");
        standardInput.WriteLine("taskkill /f /im tensafe_1.exe");
        standardInput.WriteLine("taskkill /f /im tensafe_2.exe");
        standardInput.WriteLine("taskkill /f /im tencentdl.exe");
        standardInput.WriteLine("taskkill /f /im conime.exe");
        standardInput.WriteLine("taskkill /f /im TBSWebRenderer.exe");
        standardInput.WriteLine("taskkill /f /im qqlogin.exe");
        standardInput.WriteLine("taskkill /f /im dnfchina.exe");
        standardInput.WriteLine("taskkill /f /im dnfchinatest.exe");
        standardInput.WriteLine("taskkill /f /im txplatform.exe");
        standardInput.WriteLine("taskkill /f /im aow_exe.exe");
        standardInput.WriteLine("taskkill /F /IM TitanService.exe");
        standardInput.WriteLine("taskkill /F /IM ProjectTitan.exe");
        standardInput.WriteLine("taskkill /F /IM Auxillary.exe");
        standardInput.WriteLine("taskkill /F /IM TP3Helper.exe");
        standardInput.WriteLine("taskkill /F /IM tp3helper.dat");
        standardInput.WriteLine("TaskKill /F /IM androidemulator.exe");
        standardInput.WriteLine("TaskKill /F /IM aow_exe.exe");
        standardInput.WriteLine("TaskKill /F /IM QMEmulatorService.exe");
        standardInput.WriteLine("TaskKill /F /IM RuntimeBroker.exe");
        standardInput.WriteLine("taskkill /F /im adb.exe");
        standardInput.WriteLine("taskkill /F /im GameLoader.exe");
        standardInput.WriteLine("taskkill /F /im TBSWebRenderer.exe");
        standardInput.WriteLine("taskkill /F /im AppMarket.exe");
        standardInput.WriteLine("taskkill /F /im AndroidEmulator.exe");
        standardInput.WriteLine("taskkill /F /im syzs_dl_svr.exe");
        standardInput.WriteLine("taskkill /F /im QMEmulatorService.exe");
        standardInput.WriteLine("net stop QMEmulatorService");
        standardInput.WriteLine("net stop aow_drv");
        standardInput.WriteLine("del C:\aow_drv.log");
      }
      process.WaitForExit();
      int num = (int) MessageBox.Show("All EMULATOR AND BACKGROUND PROCESSES TERMINATED.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void siticoneButton2_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        CreateNoWindow = true,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process.Start();
      using (StreamWriter standardInput = process.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("net stop aow_drv & del /s /f /q C:\\Windows\\Prefetch\\ & del /s /f /q C:\\Windows\\Temp\\ & del /s /f /q %USERPROFILE%\\AppData\\Local\\Temp\\");
      }
      process.WaitForExit();
      DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath());
      foreach (FileInfo file in directoryInfo.GetFiles())
      {
        try
        {
          file.Delete();
        }
        catch (Exception ex)
        {
        }
      }
      foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
      {
        try
        {
          directory.Delete(true);
        }
        catch (Exception ex)
        {
        }
      }
      int num = (int) MessageBox.Show("TEMP & PREFETCH CLEARED.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void siticoneButton3_Click(object sender, EventArgs e) => new Process()
    {
      StartInfo = {
        FileName = "C:\\Windows\\Web\\Wallpaper\\adv.bat",
        Arguments = "",
        UseShellExecute = false,
        CreateNoWindow = false,
        RedirectStandardOutput = false
      }
    }.Start();

    private void siticoneButton4_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        CreateNoWindow = true,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process.Start();
      using (StreamWriter standardInput = process.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("netsh int ip reset resetlog.txt & netsh wlan refresh & netsh int ip reset all & netsh branchcache reset & netsh winsock reset all & netsh int tcp reset all & netsh int udp reset all & netsh int ipv4 reset all & netsh int ipv6 reset all &netsh int portproxy reset all & netsh int httpstunnel reset all & ipconfig /renew & ipconfig /flushdns & ipconfig /renew EL* & ipconfig /registerdns &");
      }
      process.WaitForExit();
      int num = (int) MessageBox.Show("IP AND DNS FLUSHED.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void siticoneButton5_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        CreateNoWindow = true,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process.Start();
      using (StreamWriter standardInput = process.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("netsh advfirewall reset");
      }
      process.WaitForExit();
      int num = (int) MessageBox.Show("Firewall Reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void siticoneButton6_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("CCleaner64").Length > 0U)
      {
        int num = (int) MessageBox.Show("Registry Cleaner Already Running.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
        Process.Start("C:\\Windows\\Web\\Wallpaper\\CCleaner64.exe");
    }

    private void siticoneButton6_MouseClick(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    protected override void Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.icontainer_0 != null ? 1 : 0)) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.siticoneButton1 = new SiticoneButton();
      this.siticoneButton2 = new SiticoneButton();
      this.siticoneButton3 = new SiticoneButton();
      this.siticoneButton4 = new SiticoneButton();
      this.siticoneButton5 = new SiticoneButton();
      this.siticoneButton6 = new SiticoneButton();
      this.label1 = new Label();
      this.SuspendLayout();
      this.siticoneButton1.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.BorderThickness = 1;
      this.siticoneButton1.CheckedState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.CustomImages.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.FillColor = Color.Transparent;
      this.siticoneButton1.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton1.HoveredState.ForeColor = Color.White;
      this.siticoneButton1.HoveredState.Parent = (CustomButtonBase) this.siticoneButton1;
      this.siticoneButton1.ImageSize = new Size(40, 40);
      this.siticoneButton1.Location = new Point(68, 92);
      this.siticoneButton1.Name = "siticoneButton1";
      this.siticoneButton1.ShadowDecoration.Parent = (Control) this.siticoneButton1;
      this.siticoneButton1.Size = new Size(192, 64);
      this.siticoneButton1.TabIndex = 2;
      this.siticoneButton1.Text = "CLOSE EMULATOR";
      this.siticoneButton1.Click += new EventHandler(this.siticoneButton1_Click);
      this.siticoneButton1.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton2.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.BorderThickness = 1;
      this.siticoneButton2.CheckedState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.CustomImages.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.FillColor = Color.Transparent;
      this.siticoneButton2.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton2.HoveredState.ForeColor = Color.White;
      this.siticoneButton2.HoveredState.Parent = (CustomButtonBase) this.siticoneButton2;
      this.siticoneButton2.ImageSize = new Size(40, 40);
      this.siticoneButton2.Location = new Point(334, 92);
      this.siticoneButton2.Name = "siticoneButton2";
      this.siticoneButton2.ShadowDecoration.Parent = (Control) this.siticoneButton2;
      this.siticoneButton2.Size = new Size(193, 64);
      this.siticoneButton2.TabIndex = 3;
      this.siticoneButton2.Text = "CLEAR TEMP";
      this.siticoneButton2.Click += new EventHandler(this.siticoneButton2_Click);
      this.siticoneButton2.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton3.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.BorderThickness = 1;
      this.siticoneButton3.CheckedState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.CustomImages.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.FillColor = Color.Transparent;
      this.siticoneButton3.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton3.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton3.HoveredState.ForeColor = Color.White;
      this.siticoneButton3.HoveredState.Parent = (CustomButtonBase) this.siticoneButton3;
      this.siticoneButton3.ImageSize = new Size(40, 40);
      this.siticoneButton3.Location = new Point(604, 92);
      this.siticoneButton3.Name = "siticoneButton3";
      this.siticoneButton3.ShadowDecoration.Parent = (Control) this.siticoneButton3;
      this.siticoneButton3.Size = new Size(186, 64);
      this.siticoneButton3.TabIndex = 4;
      this.siticoneButton3.Text = "ADVANCE CLEAN";
      this.siticoneButton3.Click += new EventHandler(this.siticoneButton3_Click);
      this.siticoneButton3.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton4.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.BorderThickness = 1;
      this.siticoneButton4.CheckedState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.CustomImages.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.FillColor = Color.Transparent;
      this.siticoneButton4.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton4.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton4.HoveredState.ForeColor = Color.White;
      this.siticoneButton4.HoveredState.Parent = (CustomButtonBase) this.siticoneButton4;
      this.siticoneButton4.ImageSize = new Size(40, 40);
      this.siticoneButton4.Location = new Point(68, 196);
      this.siticoneButton4.Name = "siticoneButton4";
      this.siticoneButton4.ShadowDecoration.Parent = (Control) this.siticoneButton4;
      this.siticoneButton4.Size = new Size(192, 64);
      this.siticoneButton4.TabIndex = 5;
      this.siticoneButton4.Text = "IP FLUSH";
      this.siticoneButton4.Click += new EventHandler(this.siticoneButton4_Click);
      this.siticoneButton4.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton5.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.BorderThickness = 1;
      this.siticoneButton5.CheckedState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.CustomImages.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.FillColor = Color.Transparent;
      this.siticoneButton5.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton5.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton5.HoveredState.ForeColor = Color.White;
      this.siticoneButton5.HoveredState.Parent = (CustomButtonBase) this.siticoneButton5;
      this.siticoneButton5.ImageSize = new Size(40, 40);
      this.siticoneButton5.Location = new Point(334, 196);
      this.siticoneButton5.Name = "siticoneButton5";
      this.siticoneButton5.ShadowDecoration.Parent = (Control) this.siticoneButton5;
      this.siticoneButton5.Size = new Size(193, 64);
      this.siticoneButton5.TabIndex = 6;
      this.siticoneButton5.Text = "RESET FIREWALL";
      this.siticoneButton5.Click += new EventHandler(this.siticoneButton5_Click);
      this.siticoneButton5.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.siticoneButton6.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.BorderThickness = 1;
      this.siticoneButton6.CheckedState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.CustomImages.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.FillColor = Color.Transparent;
      this.siticoneButton6.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.HoveredState.ForeColor = Color.White;
      this.siticoneButton6.HoveredState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.ImageSize = new Size(40, 40);
      this.siticoneButton6.Location = new Point(604, 196);
      this.siticoneButton6.Name = "siticoneButton6";
      this.siticoneButton6.ShadowDecoration.Parent = (Control) this.siticoneButton6;
      this.siticoneButton6.Size = new Size(186, 64);
      this.siticoneButton6.TabIndex = 7;
      this.siticoneButton6.Text = "REG CLEANER";
      this.siticoneButton6.Click += new EventHandler(this.siticoneButton6_Click);
      this.siticoneButton6.MouseClick += new MouseEventHandler(this.siticoneButton6_MouseClick);
      this.label1.Font = new Font("Georgia", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(3, 198, 253);
      this.label1.Location = new Point(205, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(422, 55);
      this.label1.TabIndex = 8;
      this.label1.Text = "CLEANER";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.siticoneButton6);
      this.Controls.Add((Control) this.siticoneButton5);
      this.Controls.Add((Control) this.siticoneButton4);
      this.Controls.Add((Control) this.siticoneButton3);
      this.Controls.Add((Control) this.siticoneButton2);
      this.Controls.Add((Control) this.siticoneButton1);
      this.Name = nameof (UserControl1);
      this.Size = new Size(836, 299);
      this.ResumeLayout(false);
    }

    internal static void KWpdBuf5tSV9DIN0MA()
    {
    }

    internal static bool RqxFco0MP5mUJk2NGQ() => UserControl1.VpBVdD4af397ZNdUu5 == null;
  }
}
