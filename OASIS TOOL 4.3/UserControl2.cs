// Decompiled with JetBrains decompiler
// Type: SHREDDER_AIO_TOOL.UserControl2
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
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHREDDER_AIO_TOOL
{
  public class UserControl2 : UserControl
  {
    public string userName;
    private IContainer icontainer_0;
    private SiticoneButton fixpubg;
    private SiticoneButton dx;
    private SiticoneButton keymap;
    private SiticoneButton hdd;
    private SiticoneButton dep;
    private SiticoneButton def;
    private SiticoneButton guest;
    private SiticoneButton dhost;
    private SiticoneButton ohost;
    private SiticoneButton winup;
    private SiticoneRoundedComboBox cb;
    private SiticoneButton ipad;
    private SiticoneButton hibit;
    private SiticoneButton emuid;
    private SiticoneButton dblot;
    private SiticoneButton jump;
    private Label label1;
    private SiticoneMaterialRadioButton siticoneMaterialRadioButton1;
    private SiticoneMaterialRadioButton Utility;
    private SiticoneMaterialRadioButton EfnRhqcxi5;
    private SiticoneButton fps;
    private SiticonePanel siticonePanel1;
    private SiticoneButton glKEY;
    private SiticoneButton gl98;
    private SiticoneButton gles;
    private SiticoneButton core;
    private SiticoneButton gl982;
    internal static UserControl2 aCdgI933cj7m7smWyh;

    public UserControl2()
    {
      Class2.V1XjF0uzuv5J3();
      this.userName = Environment.UserName;
      this.icontainer_0 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void fixpubg_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("ProjectTitan").Length <= 0U)
      {
        int num1 = (int) MessageBox.Show("SmartGaGa Not Running. Please Open SmartGaGa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
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
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe connect emulator-5554");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\helper /data/data");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /data/data/helper /data/data/com.tencent.tinput");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
        }
        process.WaitForExit();
        int num2 = (int) MessageBox.Show("PUBG FIXED.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void dx_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("ProjectTitan").Length <= 0U)
      {
        string str = Environment.ExpandEnvironmentVariables("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\");
        Directory.Delete(str, true);
        ZipFile.ExtractToDirectory("C:\\Windows\\Web\\Wallpaper\\renderer_dx.zip", str);
        int num = (int) MessageBox.Show("Fixed Direct X.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please Close SmartGaGa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void keymap_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("ProjectTitan").Length > 0U)
      {
        int num1 = (int) MessageBox.Show("Please Close SmartGaGa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        string str = Environment.ExpandEnvironmentVariables("C:\\Users\\%USERNAME%\\AppData\\Roaming\\SmartGaGa\\");
        Directory.Delete(str, true);
        ZipFile.ExtractToDirectory("C:\\Windows\\Web\\Wallpaper\\keymapping.zip", str);
        int num2 = (int) MessageBox.Show("KEYMAPPING DONE.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void guest_Click(object sender, EventArgs e)
    {
      if (this.cb.SelectedItem != null)
      {
        if (!(this.cb.SelectedItem.ToString() == "Global"))
        {
          if (this.cb.SelectedItem.ToString() == "Korea")
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
              standardInput.WriteLine("C:\\Windows\\System32\\k.bat");
            }
            process.WaitForExit();
            int num = (int) MessageBox.Show("Guest Account Reset Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else if (!(this.cb.SelectedItem.ToString() == "VNG"))
          {
            if (!(this.cb.SelectedItem.ToString() == "Taiwan"))
              return;
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
              standardInput.WriteLine("C:\\Windows\\System32\\t.bat");
            }
            process.WaitForExit();
            int num = (int) MessageBox.Show("Guest Account Reset Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
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
              standardInput.WriteLine("C:\\Windows\\System32\\v.bat");
            }
            process.WaitForExit();
            int num = (int) MessageBox.Show("Guest Account Reset Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
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
            standardInput.WriteLine("C:\\Windows\\System32\\g.bat");
          }
          process.WaitForExit();
          int num = (int) MessageBox.Show("Guest Account Reset Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please Select PUBG Version First.", "SUAR Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void hdd_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("ChangeComputerInfo").Length <= 0U)
      {
        Process.Start("C:\\Windows\\Web\\Wallpaper\\ChangeComputerInfo.exe");
      }
      else
      {
        int num = (int) MessageBox.Show("Software Already Running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dep_Click(object sender, EventArgs e)
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
        standardInput.WriteLine("systempropertiesdataexecutionprevention.exe");
      }
    }

    private void def_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("DefenderControl").Length <= 0U)
      {
        Process.Start("C:\\Windows\\Web\\Wallpaper\\DefenderControl.exe");
      }
      else
      {
        int num = (int) MessageBox.Show("Software Already Running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dhost_Click(object sender, EventArgs e)
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
        standardInput.WriteLine("cd C:\\Windows\\System32\\drivers\\etc\\");
        standardInput.WriteLine("del hosts");
      }
      process.WaitForExit();
      UserControl2.Extract("SHREDDER_AIO_TOOL", "C:\\Windows\\System32\\drivers\\etc", "files", "hosts");
      int num = (int) MessageBox.Show("BACK TO DEFAULT HOST.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static void Extract(
      string nameSpace,
      string outDirectory,
      string internalFilePath,
      string resourceName)
    {
      using (Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + (!(internalFilePath == "") ? internalFilePath + "." : "") + resourceName))
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

    private void method_0(object sender, EventArgs e)
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

    private void ohost_Click(object sender, EventArgs e) => Process.Start("explorer.exe", "C:\\Windows\\System32\\drivers\\etc");

    private void winup_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("WinUpdatesDisabler_x64").Length <= 0U)
      {
        Process.Start("C:\\Windows\\Web\\Wallpaper\\WinUpdatesDisabler_x64");
      }
      else
      {
        int num = (int) MessageBox.Show("SoftWare Already Running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void winup_MouseClick(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    private void method_1(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    private void method_2(object sender, EventArgs e)
    {
      Process process1 = new Process();
      Process process2 = new Process();
      process2.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        CreateNoWindow = true,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process2.Start();
      using (StreamWriter standardInput = process2.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("adb kill-server");
        standardInput.WriteLine("adb start-server");
        standardInput.WriteLine("adb -s emulator-5554 push C:/Windows/Web/Wallpaper/UserCustom.ini /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/Active.sav");
        standardInput.WriteLine("Taskkill /F /IM adb.exe");
      }
      process2.WaitForExit();
      int num = (int) MessageBox.Show("Fixed. Now You Can Play On Extreme Settings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void cb_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void ipad_Click(object sender, EventArgs e)
    {
      if (this.cb.SelectedItem == null)
      {
        int num1 = (int) MessageBox.Show("Please Select PUBG Version First.", "SUAR Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (!(this.cb.SelectedItem.ToString() == "Global"))
      {
        if (this.cb.SelectedItem.ToString() == "Korea")
        {
          Process process1 = new Process();
          Process process2 = new Process();
          process2.StartInfo = new ProcessStartInfo()
          {
            FileName = "cmd.exe",
            CreateNoWindow = true,
            RedirectStandardInput = true,
            UseShellExecute = false
          };
          process2.Start();
          using (StreamWriter standardInput = process2.StandardInput)
          {
            if (!standardInput.BaseStream.CanWrite)
              return;
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /mnt/shell//emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          }
          process2.WaitForExit();
          int num2 = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (this.cb.SelectedItem.ToString() == "Taiwan")
        {
          Process process3 = new Process();
          Process process4 = new Process();
          process4.StartInfo = new ProcessStartInfo()
          {
            FileName = "cmd.exe",
            CreateNoWindow = true,
            RedirectStandardInput = true,
            UseShellExecute = false
          };
          process4.Start();
          using (StreamWriter standardInput = process4.StandardInput)
          {
            if (!standardInput.BaseStream.CanWrite)
              return;
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /mnt/shell//emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          }
          process4.WaitForExit();
          int num3 = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          if (!(this.cb.SelectedItem.ToString() == "VNG"))
            return;
          Process process5 = new Process();
          Process process6 = new Process();
          process6.StartInfo = new ProcessStartInfo()
          {
            FileName = "cmd.exe",
            CreateNoWindow = true,
            RedirectStandardInput = true,
            UseShellExecute = false
          };
          process6.Start();
          using (StreamWriter standardInput = process6.StandardInput)
          {
            if (!standardInput.BaseStream.CanWrite)
              return;
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /mnt/shell//emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /storage/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          }
          process6.WaitForExit();
          int num4 = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        Process process7 = new Process();
        Process process8 = new Process();
        process8.StartInfo = new ProcessStartInfo()
        {
          FileName = "cmd.exe",
          CreateNoWindow = true,
          RedirectStandardInput = true,
          UseShellExecute = false
        };
        process8.Start();
        using (StreamWriter standardInput = process8.StandardInput)
        {
          if (!standardInput.BaseStream.CanWrite)
            return;
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /mnt/shell//emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine.ini /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
        }
        process8.WaitForExit();
        int num5 = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void method_3(object sender, EventArgs e)
    {
    }

    private void hibit_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("HiBit").Length <= 0U)
      {
        Process.Start("C:\\Windows\\Web\\Wallpaper\\HiBit");
      }
      else
      {
        int num = (int) MessageBox.Show("SoftWare Already Running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void emuid_Click(object sender, EventArgs e)
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
        standardInput.WriteLine("C:\\Windows\\System32\\device.bat");
      }
      process.WaitForExit();
      int num = (int) MessageBox.Show("Emulator ID Reset Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void dblot_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "powershell.exe",
        CreateNoWindow = false,
        RedirectStandardInput = true,
        UseShellExecute = false
      };
      process.Start();
      using (StreamWriter standardInput = process.StandardInput)
      {
        if (!standardInput.BaseStream.CanWrite)
          return;
        standardInput.WriteLine("iex ((New-Object System.Net.WebClient).DownloadString('https://git.io/debloat'))");
      }
    }

    private void jump_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("DnsJumper").Length > 0U)
      {
        int num = (int) MessageBox.Show("SoftWare Already Running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
        Process.Start("C:\\Windows\\Web\\Wallpaper\\DnsJumper");
    }

    private void siticoneMaterialRadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.siticoneMaterialRadioButton1.Checked)
        return;
      this.keymap.Visible = true;
      this.dx.Visible = true;
      this.fixpubg.Visible = true;
      this.cb.Visible = true;
      this.guest.Visible = true;
      this.ipad.Visible = true;
      this.emuid.Visible = true;
      this.hdd.Visible = false;
      this.ohost.Visible = false;
      this.hibit.Visible = false;
      this.dep.Visible = false;
      this.winup.Visible = false;
      this.dblot.Visible = false;
      this.def.Visible = false;
      this.dhost.Visible = false;
      this.jump.Visible = false;
      this.fps.Visible = true;
      this.core.Visible = true;
      this.gl98.Visible = false;
      this.gles.Visible = false;
      this.glKEY.Visible = false;
      this.gl982.Visible = false;
    }

    private void EfnRhqcxi5_CheckedChanged(object sender, EventArgs e)
    {
      this.keymap.Visible = false;
      this.dx.Visible = false;
      this.fixpubg.Visible = false;
      this.cb.Visible = false;
      this.guest.Visible = false;
      this.ipad.Visible = false;
      this.emuid.Visible = false;
      this.hdd.Visible = true;
      this.ohost.Visible = true;
      this.hibit.Visible = true;
      this.dep.Visible = true;
      this.winup.Visible = true;
      this.dblot.Visible = true;
      this.def.Visible = true;
      this.dhost.Visible = true;
      this.jump.Visible = true;
      this.fps.Visible = false;
      this.core.Visible = false;
      this.gl98.Visible = false;
      this.gles.Visible = false;
      this.glKEY.Visible = false;
      this.gl982.Visible = false;
    }

    private void Utility_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.Utility.Checked)
        return;
      this.keymap.Visible = false;
      this.dx.Visible = false;
      this.fixpubg.Visible = false;
      this.guest.Visible = true;
      this.ipad.Visible = true;
      this.emuid.Visible = true;
      this.hdd.Visible = false;
      this.ohost.Visible = false;
      this.hibit.Visible = false;
      this.dep.Visible = false;
      this.winup.Visible = false;
      this.dblot.Visible = false;
      this.def.Visible = false;
      this.dhost.Visible = false;
      this.jump.Visible = false;
      this.fps.Visible = true;
      this.gl98.Visible = true;
      this.gles.Visible = true;
      this.glKEY.Visible = true;
      this.cb.Visible = true;
      this.core.Visible = false;
      this.gl98.Visible = true;
      this.gles.Visible = true;
      this.glKEY.Visible = true;
      this.gl982.Visible = true;
    }

    private void UserControl2_Load(object sender, EventArgs e)
    {
    }

    private void gles_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("AndroidEmulator").Length <= 0U)
      {
        int num1 = (int) MessageBox.Show("Gameloop not Running in Background.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        Environment.ExpandEnvironmentVariables("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS");
        if (!File.Exists("C:\\Users\\" + this.userName + "\\Desktop\\OASIS DOWNLOADS\\fx.apk"))
        {
          int num2 = (int) MessageBox.Show("File Not Found. Please It First From The Download Section.", "Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
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
            standardInput.WriteLine("cd C:\\Users\\%USERNAME%\\Desktop\\OASIS DOWNLOADS");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe install fx.apk");
          }
          process.WaitForExit();
          int num3 = (int) MessageBox.Show("App Installed Completely.", "TEAM OASIS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    private void fps_Click(object sender, EventArgs e)
    {
      if (this.cb.SelectedItem != null)
      {
        if (!(this.cb.SelectedItem.ToString() == "Global"))
        {
          if (!(this.cb.SelectedItem.ToString() == "Korea"))
          {
            if (!(this.cb.SelectedItem.ToString() == "Taiwan"))
            {
              if (!(this.cb.SelectedItem.ToString() == "VNG"))
                return;
              Process process1 = new Process();
              Process process2 = new Process();
              process2.StartInfo = new ProcessStartInfo()
              {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
              };
              process2.Start();
              using (StreamWriter standardInput = process2.StandardInput)
              {
                if (!standardInput.BaseStream.CanWrite)
                  return;
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /mnt/shell//emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /storage/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
              }
              process2.WaitForExit();
              int num = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
              Process process3 = new Process();
              Process process4 = new Process();
              process4.StartInfo = new ProcessStartInfo()
              {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
              };
              process4.Start();
              using (StreamWriter standardInput = process4.StandardInput)
              {
                if (!standardInput.BaseStream.CanWrite)
                  return;
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /mnt/shell//emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /storage/emulated/0/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
                standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
              }
              process4.WaitForExit();
              int num = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
          }
          else
          {
            Process process5 = new Process();
            Process process6 = new Process();
            process6.StartInfo = new ProcessStartInfo()
            {
              FileName = "cmd.exe",
              CreateNoWindow = true,
              RedirectStandardInput = true,
              UseShellExecute = false
            };
            process6.Start();
            using (StreamWriter standardInput = process6.StandardInput)
            {
              if (!standardInput.BaseStream.CanWrite)
                return;
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /mnt/shell//emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
              standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
            }
            process6.WaitForExit();
            int num = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          Process process7 = new Process();
          Process process8 = new Process();
          process8.StartInfo = new ProcessStartInfo()
          {
            FileName = "cmd.exe",
            CreateNoWindow = true,
            RedirectStandardInput = true,
            UseShellExecute = false
          };
          process8.Start();
          using (StreamWriter standardInput = process8.StandardInput)
          {
            if (!standardInput.BaseStream.CanWrite)
              return;
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe start-server");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe shell mkdir /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /mnt/shell//emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe push C:\\\\Windows\\\\Web\\\\Wallpaper\\\\UserEngine1.ini /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Config/UserEngine.ini");
            standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
          }
          process8.WaitForExit();
          int num = (int) MessageBox.Show("Ultra HDR & ipad VIEW UNLOCKED. ENJOY!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please Select PUBG Version First.", "SUAR Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void core_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("ProjectTitan").Length <= 0U)
      {
        if (!Directory.Exists("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2"))
        {
          int num1 = (int) MessageBox.Show("SmartGaGa Not Found. Please Install SmartGaGa in C drive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          Process.Start("C:\\Windows\\Fonts\\Fix Download.exe");
          Task.Delay(4000);
          Process.Start("C:\\Windows\\Fonts\\Fix98.exe");
          Task.Delay(1000);
          int num2 = (int) MessageBox.Show("Data Corrupt & 98% Stuck Fixed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num3 = (int) MessageBox.Show("Close SmartGaGa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void glKEY_Click(object sender, EventArgs e)
    {
      string str1 = "C:\\Program Files\\TxGameAssistant\\ui\\smka.conf";
      string str2 = "C:\\Program Files\\TxGameAssistant\\ui\\smk.conf";
      string str3 = "C:\\Program Files\\TxGameAssistant\\ui\\DefaultKeyMapping.xml";
      string str4 = "C:\\Program Files\\TxGameAssistant\\ui\\ConfigFile\\smka.conf";
      string str5 = "C:\\Program Files\\TxGameAssistant\\ui\\ConfigFile\\smk.conf";
      string str6 = "C:\\Program Files\\TxGameAssistant\\ui\\ConfigFile\\DefaultKeyMapping.xml";
      string sourceFileName1 = "C:\\Windows\\Fonts\\smka.conf";
      string sourceFileName2 = "C:\\Windows\\Fonts\\smk.conf";
      string sourceFileName3 = "C:\\Windows\\Fonts\\DefaultKeyMapping.xml";
      string path1 = "C:\\Program Files\\TxGameAssistant\\ui";
      string path2 = "C:\\Program Files\\TxGameAssistant\\ui\\ConfigFile";
      if ((uint) Process.GetProcessesByName("AndroidEmulator").Length > 0U)
      {
        int num1 = (int) MessageBox.Show("Close Gameloop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        if (!Directory.Exists(path1))
        {
          int num2 = (int) MessageBox.Show("Unable To Find UI Folder. Please Install Gameloop in C Drive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        try
        {
          if (!File.Exists(str3))
          {
            File.Copy(sourceFileName3, str3);
          }
          else
          {
            File.Delete("C:\\Program Files\\TxGameAssistant\\ui\\DefaultKeyMapping.xml");
            File.Copy(sourceFileName3, str3);
          }
          if (!File.Exists(str2))
          {
            File.Copy(sourceFileName2, str2);
          }
          else
          {
            File.Delete(str2);
            File.Copy(sourceFileName2, str2);
          }
          if (!File.Exists(str1))
          {
            File.Copy(sourceFileName1, str1);
          }
          else
          {
            File.Delete(str1);
            File.Copy(sourceFileName1, str1);
          }
          if (!Directory.Exists(path2))
            Directory.CreateDirectory(path2);
          Task.Delay(2000);
          if (!File.Exists(str6))
          {
            File.Copy(sourceFileName3, str6);
          }
          else
          {
            File.Delete(str6);
            File.Copy(sourceFileName3, str6);
          }
          if (File.Exists(str4))
          {
            File.Delete(str4);
            File.Copy(sourceFileName2, str4);
          }
          else
            File.Copy(sourceFileName2, str4);
          if (!File.Exists(str5))
          {
            File.Copy(sourceFileName1, str5);
          }
          else
          {
            File.Delete(str5);
            File.Copy(sourceFileName1, str5);
          }
          int num3 = (int) MessageBox.Show("Keymapping Done.", "Team Oasis", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch
        {
        }
      }
    }

    private void gl98_Click(object sender, EventArgs e)
    {
      string path1 = "C:\\Program Files\\TxGameAssistant\\AOW_Rootfs\\0\\0";
      string path2 = "C:\\Program Files\\TxGameAssistant\\AOW_Rootfs\\0\\0.ini";
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
      try
      {
        if (!File.Exists(path1))
        {
          int num = (int) MessageBox.Show("Its Already Fixed or No Files Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          File.Delete(path1);
        if (!File.Exists(path2))
          return;
        File.Delete(path2);
      }
      catch
      {
      }
    }

    private void gl982_Click(object sender, EventArgs e)
    {
      if ((uint) Process.GetProcessesByName("AndroidEmulator").Length <= 0U)
      {
        int num1 = (int) MessageBox.Show("Please Open Gameloop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
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
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe  kill-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe  start-server");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libdvm.txt /system/lib/libdvm.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libhardware.txt /system/lib/libhardware.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libhardware_legacy.txt /system/lib/libhardware_legacy.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libreference-ril.txt /system/lib/libreference-ril.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /init.vbox86.rc1 /init.vbox86.rc");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /init.vbox86.r0 /init.vbox86.rc");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libhoudini_415c.txt /system/lib/libhoudini_415c.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /system/lib/libhoudini_408p.txt /system/lib/libhoudini_408p.so");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe -s emulator-5554 shell mv /ueventd.vbox86.r0 /ueventd.vbox86.rc");
          standardInput.WriteLine("C:\\Windows\\Web\\Wallpaper\\adb.exe kill-server");
        }
        process.WaitForExit();
        int num2 = (int) MessageBox.Show("Done Fixing. Now Try Restarting Emulator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if ((disposing ? (this.icontainer_0 != null ? 1 : 0) : 0) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.fixpubg = new SiticoneButton();
      this.dx = new SiticoneButton();
      this.keymap = new SiticoneButton();
      this.hdd = new SiticoneButton();
      this.dep = new SiticoneButton();
      this.def = new SiticoneButton();
      this.guest = new SiticoneButton();
      this.dhost = new SiticoneButton();
      this.ohost = new SiticoneButton();
      this.winup = new SiticoneButton();
      this.cb = new SiticoneRoundedComboBox();
      this.ipad = new SiticoneButton();
      this.hibit = new SiticoneButton();
      this.emuid = new SiticoneButton();
      this.dblot = new SiticoneButton();
      this.jump = new SiticoneButton();
      this.label1 = new Label();
      this.siticoneMaterialRadioButton1 = new SiticoneMaterialRadioButton();
      this.Utility = new SiticoneMaterialRadioButton();
      this.EfnRhqcxi5 = new SiticoneMaterialRadioButton();
      this.fps = new SiticoneButton();
      this.siticonePanel1 = new SiticonePanel();
      this.glKEY = new SiticoneButton();
      this.gl98 = new SiticoneButton();
      this.gles = new SiticoneButton();
      this.core = new SiticoneButton();
      this.gl982 = new SiticoneButton();
      this.siticonePanel1.SuspendLayout();
      this.SuspendLayout();
      this.fixpubg.BorderColor = Color.FromArgb(16, 167, 254);
      this.fixpubg.BorderRadius = 1;
      this.fixpubg.BorderThickness = 1;
      this.fixpubg.CheckedState.Parent = (CustomButtonBase) this.fixpubg;
      this.fixpubg.CustomImages.Parent = (CustomButtonBase) this.fixpubg;
      this.fixpubg.FillColor = Color.Transparent;
      this.fixpubg.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.fixpubg.ForeColor = Color.FromArgb(16, 167, 254);
      this.fixpubg.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.fixpubg.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.fixpubg.HoveredState.ForeColor = Color.White;
      this.fixpubg.HoveredState.Parent = (CustomButtonBase) this.fixpubg;
      this.fixpubg.ImageSize = new Size(40, 40);
      this.fixpubg.Location = new Point(610, 169);
      this.fixpubg.Name = "fixpubg";
      this.fixpubg.ShadowDecoration.Parent = (Control) this.fixpubg;
      this.fixpubg.Size = new Size(175, 49);
      this.fixpubg.TabIndex = 16;
      this.fixpubg.Text = "FIX PUBG";
      this.fixpubg.Visible = false;
      this.fixpubg.Click += new EventHandler(this.fixpubg_Click);
      this.dx.BorderColor = Color.FromArgb(16, 167, 254);
      this.dx.BorderRadius = 1;
      this.dx.BorderThickness = 1;
      this.dx.CheckedState.Parent = (CustomButtonBase) this.dx;
      this.dx.CustomImages.Parent = (CustomButtonBase) this.dx;
      this.dx.FillColor = Color.Transparent;
      this.dx.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dx.ForeColor = Color.FromArgb(16, 167, 254);
      this.dx.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.dx.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dx.HoveredState.ForeColor = Color.White;
      this.dx.HoveredState.Parent = (CustomButtonBase) this.dx;
      this.dx.ImageSize = new Size(40, 40);
      this.dx.Location = new Point(88, 235);
      this.dx.Name = "dx";
      this.dx.ShadowDecoration.Parent = (Control) this.dx;
      this.dx.Size = new Size(174, 48);
      this.dx.TabIndex = 17;
      this.dx.Text = "FIX DIRECT X";
      this.dx.Visible = false;
      this.dx.Click += new EventHandler(this.dx_Click);
      this.dx.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.keymap.BorderColor = Color.FromArgb(16, 167, 254);
      this.keymap.BorderRadius = 1;
      this.keymap.BorderThickness = 1;
      this.keymap.CheckedState.Parent = (CustomButtonBase) this.keymap;
      this.keymap.CustomImages.Parent = (CustomButtonBase) this.keymap;
      this.keymap.FillColor = Color.Transparent;
      this.keymap.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.keymap.ForeColor = Color.FromArgb(16, 167, 254);
      this.keymap.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.keymap.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.keymap.HoveredState.ForeColor = Color.White;
      this.keymap.HoveredState.Parent = (CustomButtonBase) this.keymap;
      this.keymap.ImageSize = new Size(40, 40);
      this.keymap.Location = new Point(88, 104);
      this.keymap.Name = "keymap";
      this.keymap.ShadowDecoration.Parent = (Control) this.keymap;
      this.keymap.Size = new Size(174, 49);
      this.keymap.TabIndex = 18;
      this.keymap.Text = "KEYMAPPPING";
      this.keymap.Visible = false;
      this.keymap.Click += new EventHandler(this.keymap_Click);
      this.keymap.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.hdd.BorderColor = Color.FromArgb(16, 167, 254);
      this.hdd.BorderRadius = 1;
      this.hdd.BorderThickness = 1;
      this.hdd.CheckedState.Parent = (CustomButtonBase) this.hdd;
      this.hdd.CustomImages.Parent = (CustomButtonBase) this.hdd;
      this.hdd.FillColor = Color.Transparent;
      this.hdd.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.hdd.ForeColor = Color.FromArgb(16, 167, 254);
      this.hdd.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.hdd.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.hdd.HoveredState.ForeColor = Color.White;
      this.hdd.HoveredState.Parent = (CustomButtonBase) this.hdd;
      this.hdd.ImageSize = new Size(40, 40);
      this.hdd.Location = new Point(47, 72);
      this.hdd.Name = "hdd";
      this.hdd.ShadowDecoration.Parent = (Control) this.hdd;
      this.hdd.Size = new Size(160, 50);
      this.hdd.TabIndex = 19;
      this.hdd.Text = "PC Info Changer";
      this.hdd.Click += new EventHandler(this.hdd_Click);
      this.hdd.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.dep.BorderColor = Color.FromArgb(16, 167, 254);
      this.dep.BorderRadius = 1;
      this.dep.BorderThickness = 1;
      this.dep.CheckedState.Parent = (CustomButtonBase) this.dep;
      this.dep.CustomImages.Parent = (CustomButtonBase) this.dep;
      this.dep.FillColor = Color.Transparent;
      this.dep.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dep.ForeColor = Color.FromArgb(16, 167, 254);
      this.dep.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.dep.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dep.HoveredState.ForeColor = Color.White;
      this.dep.HoveredState.Parent = (CustomButtonBase) this.dep;
      this.dep.ImageSize = new Size(40, 40);
      this.dep.Location = new Point(329, 72);
      this.dep.Name = "dep";
      this.dep.ShadowDecoration.Parent = (Control) this.dep;
      this.dep.Size = new Size(176, 50);
      this.dep.TabIndex = 20;
      this.dep.Text = "OPEN DEP";
      this.dep.Click += new EventHandler(this.dep_Click);
      this.dep.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.def.BorderColor = Color.FromArgb(16, 167, 254);
      this.def.BorderRadius = 1;
      this.def.BorderThickness = 1;
      this.def.CheckedState.Parent = (CustomButtonBase) this.def;
      this.def.CustomImages.Parent = (CustomButtonBase) this.def;
      this.def.FillColor = Color.Transparent;
      this.def.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.def.ForeColor = Color.FromArgb(16, 167, 254);
      this.def.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.def.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.def.HoveredState.ForeColor = Color.White;
      this.def.HoveredState.Parent = (CustomButtonBase) this.def;
      this.def.ImageSize = new Size(40, 40);
      this.def.Location = new Point(625, 72);
      this.def.Name = "def";
      this.def.ShadowDecoration.Parent = (Control) this.def;
      this.def.Size = new Size(160, 50);
      this.def.TabIndex = 21;
      this.def.Text = "DEFENDER CONTROL";
      this.def.Click += new EventHandler(this.def_Click);
      this.def.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.guest.BorderColor = Color.FromArgb(16, 167, 254);
      this.guest.BorderRadius = 1;
      this.guest.BorderThickness = 1;
      this.guest.CheckedState.Parent = (CustomButtonBase) this.guest;
      this.guest.CustomImages.Parent = (CustomButtonBase) this.guest;
      this.guest.FillColor = Color.Transparent;
      this.guest.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.guest.ForeColor = Color.FromArgb(16, 167, 254);
      this.guest.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.guest.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.guest.HoveredState.ForeColor = Color.White;
      this.guest.HoveredState.Parent = (CustomButtonBase) this.guest;
      this.guest.ImageSize = new Size(40, 40);
      this.guest.Location = new Point(331, 104);
      this.guest.Name = "guest";
      this.guest.ShadowDecoration.Parent = (Control) this.guest;
      this.guest.Size = new Size(182, 49);
      this.guest.TabIndex = 22;
      this.guest.Text = "GUEST RESET";
      this.guest.Visible = false;
      this.guest.Click += new EventHandler(this.guest_Click);
      this.guest.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.dhost.BorderColor = Color.FromArgb(16, 167, 254);
      this.dhost.BorderRadius = 1;
      this.dhost.BorderThickness = 1;
      this.dhost.CheckedState.Parent = (CustomButtonBase) this.dhost;
      this.dhost.CustomImages.Parent = (CustomButtonBase) this.dhost;
      this.dhost.FillColor = Color.Transparent;
      this.dhost.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dhost.ForeColor = Color.FromArgb(16, 167, 254);
      this.dhost.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.dhost.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dhost.HoveredState.ForeColor = Color.White;
      this.dhost.HoveredState.Parent = (CustomButtonBase) this.dhost;
      this.dhost.ImageSize = new Size(40, 40);
      this.dhost.Location = new Point(625, 155);
      this.dhost.Name = "dhost";
      this.dhost.ShadowDecoration.Parent = (Control) this.dhost;
      this.dhost.Size = new Size(160, 50);
      this.dhost.TabIndex = 23;
      this.dhost.Text = "DEFAULT HOST";
      this.dhost.Click += new EventHandler(this.dhost_Click);
      this.dhost.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.ohost.BorderColor = Color.FromArgb(16, 167, 254);
      this.ohost.BorderRadius = 1;
      this.ohost.BorderThickness = 1;
      this.ohost.CheckedState.Parent = (CustomButtonBase) this.ohost;
      this.ohost.CustomImages.Parent = (CustomButtonBase) this.ohost;
      this.ohost.FillColor = Color.Transparent;
      this.ohost.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ohost.ForeColor = Color.FromArgb(16, 167, 254);
      this.ohost.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.ohost.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ohost.HoveredState.ForeColor = Color.White;
      this.ohost.HoveredState.Parent = (CustomButtonBase) this.ohost;
      this.ohost.ImageSize = new Size(40, 40);
      this.ohost.Location = new Point(47, 155);
      this.ohost.Name = "ohost";
      this.ohost.ShadowDecoration.Parent = (Control) this.ohost;
      this.ohost.Size = new Size(160, 50);
      this.ohost.TabIndex = 25;
      this.ohost.Text = "OPEN HOSTS";
      this.ohost.Click += new EventHandler(this.ohost_Click);
      this.ohost.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.winup.BorderColor = Color.FromArgb(16, 167, 254);
      this.winup.BorderRadius = 1;
      this.winup.BorderThickness = 1;
      this.winup.CheckedState.Parent = (CustomButtonBase) this.winup;
      this.winup.CustomImages.Parent = (CustomButtonBase) this.winup;
      this.winup.FillColor = Color.Transparent;
      this.winup.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.winup.ForeColor = Color.FromArgb(16, 167, 254);
      this.winup.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.winup.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.winup.HoveredState.ForeColor = Color.White;
      this.winup.HoveredState.Parent = (CustomButtonBase) this.winup;
      this.winup.ImageSize = new Size(40, 40);
      this.winup.Location = new Point(329, 155);
      this.winup.Name = "winup";
      this.winup.ShadowDecoration.Parent = (Control) this.winup;
      this.winup.Size = new Size(176, 50);
      this.winup.TabIndex = 26;
      this.winup.Text = "WINDOWS UPDATES";
      this.winup.Click += new EventHandler(this.winup_Click);
      this.winup.MouseClick += new MouseEventHandler(this.winup_MouseClick);
      this.cb.BackColor = Color.Transparent;
      this.cb.DrawMode = DrawMode.OwnerDrawFixed;
      this.cb.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb.Font = new Font("Segoe UI", 10f);
      this.cb.ForeColor = Color.FromArgb(68, 88, 112);
      this.cb.FormattingEnabled = true;
      this.cb.HoveredState.Parent = (Siticone.UI.WinForms.Suite.ComboBox) this.cb;
      this.cb.ItemHeight = 30;
      this.cb.Items.AddRange(new object[4]
      {
        (object) "Global",
        (object) "Korea",
        (object) "VNG",
        (object) "Taiwan"
      });
      this.cb.ItemsAppearance.Parent = (Siticone.UI.WinForms.Suite.ComboBox) this.cb;
      this.cb.Location = new Point(345, 58);
      this.cb.Name = "cb";
      this.cb.ShadowDecoration.Parent = (Control) this.cb;
      this.cb.Size = new Size(160, 36);
      this.cb.TabIndex = 27;
      this.cb.Visible = false;
      this.cb.SelectedIndexChanged += new EventHandler(this.cb_SelectedIndexChanged);
      this.ipad.BorderColor = Color.FromArgb(16, 167, 254);
      this.ipad.BorderRadius = 1;
      this.ipad.BorderThickness = 1;
      this.ipad.CheckedState.Parent = (CustomButtonBase) this.ipad;
      this.ipad.CustomImages.Parent = (CustomButtonBase) this.ipad;
      this.ipad.FillColor = Color.Transparent;
      this.ipad.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ipad.ForeColor = Color.FromArgb(16, 167, 254);
      this.ipad.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.ipad.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ipad.HoveredState.ForeColor = Color.White;
      this.ipad.HoveredState.Parent = (CustomButtonBase) this.ipad;
      this.ipad.ImageSize = new Size(40, 40);
      this.ipad.Location = new Point(331, 236);
      this.ipad.Name = "ipad";
      this.ipad.ShadowDecoration.Parent = (Control) this.ipad;
      this.ipad.Size = new Size(184, 49);
      this.ipad.TabIndex = 28;
      this.ipad.Text = "IPAD+90FPS UltraHDR";
      this.ipad.Visible = false;
      this.ipad.Click += new EventHandler(this.ipad_Click);
      this.hibit.BorderColor = Color.FromArgb(16, 167, 254);
      this.hibit.BorderRadius = 1;
      this.hibit.BorderThickness = 1;
      this.hibit.CheckedState.Parent = (CustomButtonBase) this.hibit;
      this.hibit.CustomImages.Parent = (CustomButtonBase) this.hibit;
      this.hibit.FillColor = Color.Transparent;
      this.hibit.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.hibit.ForeColor = Color.FromArgb(16, 167, 254);
      this.hibit.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.hibit.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.hibit.HoveredState.ForeColor = Color.White;
      this.hibit.HoveredState.Parent = (CustomButtonBase) this.hibit;
      this.hibit.ImageSize = new Size(40, 40);
      this.hibit.Location = new Point(47, 236);
      this.hibit.Name = "hibit";
      this.hibit.ShadowDecoration.Parent = (Control) this.hibit;
      this.hibit.Size = new Size(160, 48);
      this.hibit.TabIndex = 29;
      this.hibit.Text = "HIBIT UNINSTALLER";
      this.hibit.Click += new EventHandler(this.hibit_Click);
      this.emuid.BorderColor = Color.FromArgb(16, 167, 254);
      this.emuid.BorderRadius = 1;
      this.emuid.BorderThickness = 1;
      this.emuid.CheckedState.Parent = (CustomButtonBase) this.emuid;
      this.emuid.CustomImages.Parent = (CustomButtonBase) this.emuid;
      this.emuid.FillColor = Color.Transparent;
      this.emuid.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.emuid.ForeColor = Color.FromArgb(16, 167, 254);
      this.emuid.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.emuid.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.emuid.HoveredState.ForeColor = Color.White;
      this.emuid.HoveredState.Parent = (CustomButtonBase) this.emuid;
      this.emuid.ImageSize = new Size(40, 40);
      this.emuid.Location = new Point(610, 104);
      this.emuid.Name = "emuid";
      this.emuid.ShadowDecoration.Parent = (Control) this.emuid;
      this.emuid.Size = new Size(175, 49);
      this.emuid.TabIndex = 30;
      this.emuid.Text = "Emulator ID RESET";
      this.emuid.Visible = false;
      this.emuid.Click += new EventHandler(this.emuid_Click);
      this.dblot.BorderColor = Color.FromArgb(16, 167, 254);
      this.dblot.BorderRadius = 1;
      this.dblot.BorderThickness = 1;
      this.dblot.CheckedState.Parent = (CustomButtonBase) this.dblot;
      this.dblot.CustomImages.Parent = (CustomButtonBase) this.dblot;
      this.dblot.FillColor = Color.Transparent;
      this.dblot.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dblot.ForeColor = Color.FromArgb(16, 167, 254);
      this.dblot.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.dblot.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dblot.HoveredState.ForeColor = Color.White;
      this.dblot.HoveredState.Parent = (CustomButtonBase) this.dblot;
      this.dblot.ImageSize = new Size(40, 40);
      this.dblot.Location = new Point(329, 248);
      this.dblot.Name = "dblot";
      this.dblot.ShadowDecoration.Parent = (Control) this.dblot;
      this.dblot.Size = new Size(176, 48);
      this.dblot.TabIndex = 31;
      this.dblot.Text = "Windows Debloater";
      this.dblot.Click += new EventHandler(this.dblot_Click);
      this.jump.BorderColor = Color.FromArgb(16, 167, 254);
      this.jump.BorderRadius = 1;
      this.jump.BorderThickness = 1;
      this.jump.CheckedState.Parent = (CustomButtonBase) this.jump;
      this.jump.CustomImages.Parent = (CustomButtonBase) this.jump;
      this.jump.FillColor = Color.Transparent;
      this.jump.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.jump.ForeColor = Color.FromArgb(16, 167, 254);
      this.jump.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.jump.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.jump.HoveredState.ForeColor = Color.White;
      this.jump.HoveredState.Parent = (CustomButtonBase) this.jump;
      this.jump.ImageSize = new Size(40, 40);
      this.jump.Location = new Point(625, 236);
      this.jump.Name = "jump";
      this.jump.ShadowDecoration.Parent = (Control) this.jump;
      this.jump.Size = new Size(160, 48);
      this.jump.TabIndex = 32;
      this.jump.Text = "DNS JUMPER";
      this.jump.Click += new EventHandler(this.jump_Click);
      this.label1.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(3, 198, 253);
      this.label1.Location = new Point(21, 3);
      this.label1.Name = "label1";
      this.label1.Size = new Size(144, 35);
      this.label1.TabIndex = 9;
      this.label1.Text = "Select Emulator:";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.siticoneMaterialRadioButton1.BackColor = Color.Transparent;
      this.siticoneMaterialRadioButton1.BorderColor = Color.MediumTurquoise;
      this.siticoneMaterialRadioButton1.BorderStyle = DashStyle.Dash;
      this.siticoneMaterialRadioButton1.Checked = false;
      this.siticoneMaterialRadioButton1.CheckedBorderColor = Color.White;
      this.siticoneMaterialRadioButton1.CheckedFillColor = Color.DodgerBlue;
      this.siticoneMaterialRadioButton1.CheckedTextColor = Color.White;
      this.siticoneMaterialRadioButton1.Font = new Font("Georgia", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneMaterialRadioButton1.ForeColor = Color.White;
      this.siticoneMaterialRadioButton1.HoverBorderColor = Color.White;
      this.siticoneMaterialRadioButton1.HoverFillColor = Color.DodgerBlue;
      this.siticoneMaterialRadioButton1.HoverTextColor = Color.DodgerBlue;
      this.siticoneMaterialRadioButton1.Location = new Point(260, 8);
      this.siticoneMaterialRadioButton1.Name = "siticoneMaterialRadioButton1";
      this.siticoneMaterialRadioButton1.ReadOnly = false;
      this.siticoneMaterialRadioButton1.Size = new Size(104, 20);
      this.siticoneMaterialRadioButton1.TabIndex = 33;
      this.siticoneMaterialRadioButton1.Text = "SmartGaGa";
      this.siticoneMaterialRadioButton1.TextColor = Color.White;
      this.siticoneMaterialRadioButton1.TextLeftAlign = 0;
      this.siticoneMaterialRadioButton1.CheckedChanged += new EventHandler(this.siticoneMaterialRadioButton1_CheckedChanged);
      this.Utility.BackColor = Color.Transparent;
      this.Utility.BorderColor = Color.LightSeaGreen;
      this.Utility.BorderStyle = DashStyle.Dash;
      this.Utility.Checked = false;
      this.Utility.CheckedBorderColor = Color.White;
      this.Utility.CheckedFillColor = Color.DodgerBlue;
      this.Utility.CheckedTextColor = Color.White;
      this.Utility.Cursor = Cursors.Hand;
      this.Utility.Font = new Font("Georgia", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Utility.ForeColor = Color.White;
      this.Utility.HoverBorderColor = Color.White;
      this.Utility.HoverFillColor = Color.DodgerBlue;
      this.Utility.HoverTextColor = Color.DodgerBlue;
      this.Utility.Location = new Point(389, 8);
      this.Utility.Name = "Utility";
      this.Utility.ReadOnly = false;
      this.Utility.Size = new Size(128, 20);
      this.Utility.TabIndex = 34;
      this.Utility.Text = "GameLoop 4.4";
      this.Utility.TextColor = Color.White;
      this.Utility.TextLeftAlign = 0;
      this.Utility.CheckedChanged += new EventHandler(this.Utility_CheckedChanged);
      this.EfnRhqcxi5.BackColor = Color.Transparent;
      this.EfnRhqcxi5.BorderColor = Color.LightSeaGreen;
      this.EfnRhqcxi5.BorderStyle = DashStyle.Dash;
      this.EfnRhqcxi5.Checked = false;
      this.EfnRhqcxi5.CheckedBorderColor = Color.White;
      this.EfnRhqcxi5.CheckedFillColor = Color.DodgerBlue;
      this.EfnRhqcxi5.CheckedTextColor = Color.White;
      this.EfnRhqcxi5.Cursor = Cursors.Hand;
      this.EfnRhqcxi5.Font = new Font("Georgia", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.EfnRhqcxi5.ForeColor = Color.White;
      this.EfnRhqcxi5.HoverBorderColor = Color.White;
      this.EfnRhqcxi5.HoverFillColor = Color.DodgerBlue;
      this.EfnRhqcxi5.HoverTextColor = Color.DodgerBlue;
      this.EfnRhqcxi5.Location = new Point(171, 8);
      this.EfnRhqcxi5.Name = "siticoneMaterialRadioButton3";
      this.EfnRhqcxi5.ReadOnly = false;
      this.EfnRhqcxi5.Size = new Size(76, 20);
      this.EfnRhqcxi5.TabIndex = 35;
      this.EfnRhqcxi5.Text = "Utility";
      this.EfnRhqcxi5.TextColor = Color.White;
      this.EfnRhqcxi5.TextLeftAlign = 0;
      this.EfnRhqcxi5.CheckedChanged += new EventHandler(this.EfnRhqcxi5_CheckedChanged);
      this.fps.BorderColor = Color.FromArgb(16, 167, 254);
      this.fps.BorderRadius = 1;
      this.fps.BorderThickness = 1;
      this.fps.CheckedState.Parent = (CustomButtonBase) this.fps;
      this.fps.CustomImages.Parent = (CustomButtonBase) this.fps;
      this.fps.FillColor = Color.Transparent;
      this.fps.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.fps.ForeColor = Color.FromArgb(16, 167, 254);
      this.fps.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.fps.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.fps.HoveredState.ForeColor = Color.White;
      this.fps.HoveredState.Parent = (CustomButtonBase) this.fps;
      this.fps.ImageSize = new Size(40, 40);
      this.fps.Location = new Point(331, 169);
      this.fps.Name = "fps";
      this.fps.ShadowDecoration.Parent = (Control) this.fps;
      this.fps.Size = new Size(182, 49);
      this.fps.TabIndex = 36;
      this.fps.Text = "60FPS.UltraHDR";
      this.fps.Visible = false;
      this.fps.Click += new EventHandler(this.fps_Click);
      this.siticonePanel1.BackColor = Color.Transparent;
      this.siticonePanel1.BorderColor = Color.FromArgb(72, 167, 254);
      this.siticonePanel1.BorderRadius = 1;
      this.siticonePanel1.BorderThickness = 1;
      this.siticonePanel1.Controls.Add((Control) this.label1);
      this.siticonePanel1.Controls.Add((Control) this.EfnRhqcxi5);
      this.siticonePanel1.Controls.Add((Control) this.siticoneMaterialRadioButton1);
      this.siticonePanel1.Controls.Add((Control) this.Utility);
      this.siticonePanel1.Location = new Point(160, 14);
      this.siticonePanel1.Name = "siticonePanel1";
      this.siticonePanel1.ShadowDecoration.Parent = (Control) this.siticonePanel1;
      this.siticonePanel1.Size = new Size(520, 38);
      this.siticonePanel1.TabIndex = 37;
      this.glKEY.BorderColor = Color.FromArgb(16, 167, 254);
      this.glKEY.BorderRadius = 1;
      this.glKEY.BorderThickness = 1;
      this.glKEY.CheckedState.Parent = (CustomButtonBase) this.glKEY;
      this.glKEY.CustomImages.Parent = (CustomButtonBase) this.glKEY;
      this.glKEY.FillColor = Color.Transparent;
      this.glKEY.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.glKEY.ForeColor = Color.FromArgb(16, 167, 254);
      this.glKEY.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.glKEY.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.glKEY.HoveredState.ForeColor = Color.White;
      this.glKEY.HoveredState.Parent = (CustomButtonBase) this.glKEY;
      this.glKEY.ImageSize = new Size(40, 40);
      this.glKEY.Location = new Point(59, 104);
      this.glKEY.Name = "glKEY";
      this.glKEY.ShadowDecoration.Parent = (Control) this.glKEY;
      this.glKEY.Size = new Size(188, 49);
      this.glKEY.TabIndex = 38;
      this.glKEY.Text = "KEYMAPPPING";
      this.glKEY.Visible = false;
      this.glKEY.Click += new EventHandler(this.glKEY_Click);
      this.gl98.BorderColor = Color.FromArgb(16, 167, 254);
      this.gl98.BorderRadius = 1;
      this.gl98.BorderThickness = 1;
      this.gl98.CheckedState.Parent = (CustomButtonBase) this.gl98;
      this.gl98.CustomImages.Parent = (CustomButtonBase) this.gl98;
      this.gl98.FillColor = Color.Transparent;
      this.gl98.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gl98.ForeColor = Color.FromArgb(16, 167, 254);
      this.gl98.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.gl98.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gl98.HoveredState.ForeColor = Color.White;
      this.gl98.HoveredState.Parent = (CustomButtonBase) this.gl98;
      this.gl98.ImageSize = new Size(40, 40);
      this.gl98.Location = new Point(59, 169);
      this.gl98.Name = "gl98";
      this.gl98.ShadowDecoration.Parent = (Control) this.gl98;
      this.gl98.Size = new Size(188, 49);
      this.gl98.TabIndex = 39;
      this.gl98.Text = "98% FIX";
      this.gl98.Visible = false;
      this.gl98.Click += new EventHandler(this.gl98_Click);
      this.gles.BorderColor = Color.FromArgb(16, 167, 254);
      this.gles.BorderRadius = 1;
      this.gles.BorderThickness = 1;
      this.gles.CheckedState.Parent = (CustomButtonBase) this.gles;
      this.gles.CustomImages.Parent = (CustomButtonBase) this.gles;
      this.gles.FillColor = Color.Transparent;
      this.gles.Font = new Font("Georgia", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gles.ForeColor = Color.FromArgb(16, 167, 254);
      this.gles.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.gles.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gles.HoveredState.ForeColor = Color.White;
      this.gles.HoveredState.Parent = (CustomButtonBase) this.gles;
      this.gles.ImageSize = new Size(40, 40);
      this.gles.Location = new Point(610, 169);
      this.gles.Name = "gles";
      this.gles.ShadowDecoration.Parent = (Control) this.gles;
      this.gles.Size = new Size(175, 49);
      this.gles.TabIndex = 40;
      this.gles.Text = "INSTALL FX MANAGER";
      this.gles.Visible = false;
      this.gles.Click += new EventHandler(this.gles_Click);
      this.core.BorderColor = Color.FromArgb(16, 167, 254);
      this.core.BorderRadius = 1;
      this.core.BorderThickness = 1;
      this.core.CheckedState.Parent = (CustomButtonBase) this.core;
      this.core.CustomImages.Parent = (CustomButtonBase) this.core;
      this.core.FillColor = Color.Transparent;
      this.core.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.core.ForeColor = Color.FromArgb(16, 167, 254);
      this.core.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.core.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.core.HoveredState.ForeColor = Color.White;
      this.core.HoveredState.Parent = (CustomButtonBase) this.core;
      this.core.ImageSize = new Size(40, 40);
      this.core.Location = new Point(88, 169);
      this.core.Name = "core";
      this.core.ShadowDecoration.Parent = (Control) this.core;
      this.core.Size = new Size(174, 49);
      this.core.TabIndex = 42;
      this.core.Text = "Core Data Corrupt and 98% Fix";
      this.core.Visible = false;
      this.core.Click += new EventHandler(this.core_Click);
      this.gl982.BorderColor = Color.FromArgb(16, 167, 254);
      this.gl982.BorderRadius = 1;
      this.gl982.BorderThickness = 1;
      this.gl982.CheckedState.Parent = (CustomButtonBase) this.gl982;
      this.gl982.CustomImages.Parent = (CustomButtonBase) this.gl982;
      this.gl982.FillColor = Color.Transparent;
      this.gl982.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gl982.ForeColor = Color.FromArgb(16, 167, 254);
      this.gl982.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.gl982.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gl982.HoveredState.ForeColor = Color.White;
      this.gl982.HoveredState.Parent = (CustomButtonBase) this.gl982;
      this.gl982.ImageSize = new Size(40, 40);
      this.gl982.Location = new Point(59, 236);
      this.gl982.Name = "gl982";
      this.gl982.ShadowDecoration.Parent = (Control) this.gl982;
      this.gl982.Size = new Size(188, 49);
      this.gl982.TabIndex = 43;
      this.gl982.Text = "98% FIX 2nd Method ";
      this.gl982.Visible = false;
      this.gl982.Click += new EventHandler(this.gl982_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.Controls.Add((Control) this.gl982);
      this.Controls.Add((Control) this.gles);
      this.Controls.Add((Control) this.gl98);
      this.Controls.Add((Control) this.glKEY);
      this.Controls.Add((Control) this.core);
      this.Controls.Add((Control) this.ipad);
      this.Controls.Add((Control) this.fps);
      this.Controls.Add((Control) this.cb);
      this.Controls.Add((Control) this.siticonePanel1);
      this.Controls.Add((Control) this.guest);
      this.Controls.Add((Control) this.fixpubg);
      this.Controls.Add((Control) this.dx);
      this.Controls.Add((Control) this.keymap);
      this.Controls.Add((Control) this.jump);
      this.Controls.Add((Control) this.dblot);
      this.Controls.Add((Control) this.emuid);
      this.Controls.Add((Control) this.hibit);
      this.Controls.Add((Control) this.winup);
      this.Controls.Add((Control) this.ohost);
      this.Controls.Add((Control) this.dhost);
      this.Controls.Add((Control) this.def);
      this.Controls.Add((Control) this.dep);
      this.Controls.Add((Control) this.hdd);
      this.Name = nameof (UserControl2);
      this.Size = new Size(836, 299);
      this.Load += new EventHandler(this.UserControl2_Load);
      this.siticonePanel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal static void bwji4rucHA1u4aYYCs()
    {
    }

    internal static bool HDJYk0JaXdQl7y14gE() => UserControl2.aCdgI933cj7m7smWyh == null;
  }
}
