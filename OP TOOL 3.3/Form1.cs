// Decompiled with JetBrains decompiler
// Type: TOOL.Form1
// Assembly: TOOL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB4B0A50-BB68-477B-ACEC-619EB8F5F2A1
// Assembly location: C:\Users\op\Desktop\OP TOOL 3.3_dump_dotkill-Cleaned-cleaned.exe

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TOOL.My;

namespace TOOL
{
  [DesignerGenerated]
  public class Form1 : MetroForm
  {
    private WebClient p;
    private object Lshell;
    private string after3;
    private IContainer components;

    public Form1()
    {
      ((Form) this).Load += new EventHandler(this.Form1_Load);
      ((Form) this).FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
      this.p = new WebClient();
      this.after3 = "cmd.exe /c";
      this.InitializeComponent();
    }

    public void SaveFromResources(string FilePath, object File)
    {
      byte[] data = (byte[]) File;
      MyProject.Computer.FileSystem.WriteAllBytes(FilePath, data, true);
    }

    public string GetUserName() => Strings.Split(MyProject.User.Name, "\\")[1];

    private void MetroLink1_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/");

    private void MetroLink2_Click(object sender, EventArgs e) => Process.Start("https://t.me/OPBYPASS");

    private void MetroLink3_Click(object sender, EventArgs e) => Process.Start("https://discord.com/invite/o-gamers");

    private void MetroLink4_Click(object sender, EventArgs e) => Process.Start("https://shoppy.gg/@opbypas");

    private void MetroButton19_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Task Kill SmartGaGa";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2 & taskkill /f /im ProjectTitan.exe & taskkill /F /im TitanService.exe & taskkill /f /im adb.exe & taskkill /f /im GoogleCrashHandler64.exe & taskkill /f /im GoogleCrashHandler.exe & taskkill /f /im MicrosoftEdgeCP.exe & taskkill /f /im MicrosoftEdge.exe"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "Done";
    }

    private void MetroButton14_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Task Kill Gameloop";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "TaskKill /F /im androidemulator.exe & taskkill /F /im AppMarket.exe & taskkill /F /im GameLoader.exe & taskkill /F /im syzs_dl_svr.exe& TaskKill /F /im QMEmulatorService.exe & taskkill /f /im QQDL.EXE & net stop QMEmulatorService & taskkill /f /im adb.exe & net stop aow_drv & taskkill /f /im aow_exe.exe & TaskKill /F /im RuntimeBroker.exe & taskkill /F /im TBSWebRenderer.exe"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "Done";
    }

    private void MetroButton18_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "reset firewall";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 3"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      Interaction.Shell("netsh advfirewall reset");
      this.Label1.Text = "Done";
    }

    private void MetroButton17_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Add a host for Windows";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Windows\\System32\\drivers\\etc\\hosts");
        this.SaveFromResources("C:\\Windows\\System32\\drivers\\etc\\hosts", (object) TOOL.My.Resources.Resources.hosts);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SaveFromResources("C:\\Windows\\System32\\drivers\\etc\\hosts", (object) TOOL.My.Resources.Resources.hosts);
        ProjectData.ClearProjectError();
      }
      this.Label1.Text = "Done";
    }

    private void MetroButton15_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Computer cleaning please wait ...";
      string path1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\";
      string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Temp\\";
      string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Prefetch\\";
      string[] files1 = Directory.GetFiles(path1, "*.*", SearchOption.TopDirectoryOnly);
      int index1 = 0;
      while (index1 < files1.Length)
      {
        string path4 = files1[index1];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path4), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path4);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      string[] directories1 = Directory.GetDirectories(path1);
      int index2 = 0;
      while (index2 < directories1.Length)
      {
        string path5 = directories1[index2];
        try
        {
          Directory.Delete(path5, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      string[] files2 = Directory.GetFiles(path2, "*.*", SearchOption.TopDirectoryOnly);
      int index3 = 0;
      while (index3 < files2.Length)
      {
        string path6 = files2[index3];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path6), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path6);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index3; }
      }
      string[] directories2 = Directory.GetDirectories(path2);
      int index4 = 0;
      while (index4 < directories2.Length)
      {
        string path7 = directories2[index4];
        try
        {
          Directory.Delete(path7, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index4; }
      }
      string[] files3 = Directory.GetFiles(path3, "*.*", SearchOption.TopDirectoryOnly);
      int index5 = 0;
      while (index5 < files3.Length)
      {
        string path8 = files3[index5];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path8), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path8);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index5; }
      }
      string[] directories3 = Directory.GetDirectories(path3);
      int index6 = 0;
      while (index6 < directories3.Length)
      {
        string path9 = directories3[index6];
        try
        {
          Directory.Delete(path9, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index6; }
      }
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "rd /q /s C:\\$Recycle.Bin & %SystemRoot%System32Cmd.exe /c Cleanmgr /sageset:16 & Cleanmgr /sagerun:16 & start %userprofile%\\Recent"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "Done";
    }

    private void MetroButton10_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "SmartGaGa Emulator Is Fixed";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      List<string> list1 = ((IEnumerable<string>) Directory.GetDirectories("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\", "00000000*", SearchOption.AllDirectories)).ToList<string>();
      Action<string> action1;
      // ISSUE: reference to a compiler-generated field
      if (Form1._Closure\u0024__.\u0024I15\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        action1 = Form1._Closure\u0024__.\u0024I15\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Form1._Closure\u0024__.\u0024I15\u002D0 = action1 = (Action<string>) (x => Directory.Delete(x, true));
      }
      list1.ForEach(action1);
      FileSystem.MkDir("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000");
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\00000000", (object) TOOL.My.Resources.Resources.c1);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\00000000.metadata", (object) TOOL.My.Resources.Resources.c2);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000015d", (object) TOOL.My.Resources.Resources.c3);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000015d.metadata", (object) TOOL.My.Resources.Resources.c4);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059b", (object) TOOL.My.Resources.Resources.c5);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059b.metadata", (object) TOOL.My.Resources.Resources.c6);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059c", (object) TOOL.My.Resources.Resources.c7);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059c.metadata", (object) TOOL.My.Resources.Resources.c8);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059d", (object) TOOL.My.Resources.Resources.c9);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059d.metadata", (object) TOOL.My.Resources.Resources.c10);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059e", (object) TOOL.My.Resources.Resources.c11);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\0000059e.metadata", (object) TOOL.My.Resources.Resources.c12);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\00000248", (object) TOOL.My.Resources.Resources.c13);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\system\\00000000\\00000248.metadata", (object) TOOL.My.Resources.Resources.c14);
      List<string> list2 = ((IEnumerable<string>) Directory.GetDirectories("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\", "00000000*", SearchOption.AllDirectories)).ToList<string>();
      Action<string> action2;
      // ISSUE: reference to a compiler-generated field
      if (Form1._Closure\u0024__.\u0024I15\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        action2 = Form1._Closure\u0024__.\u0024I15\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Form1._Closure\u0024__.\u0024I15\u002D1 = action2 = (Action<string>) (x => Directory.Delete(x, true));
      }
      list2.ForEach(action2);
      FileSystem.MkDir("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\00000000");
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\00000000\\00000000", (object) TOOL.My.Resources.Resources.d1);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\00000000\\00000000.metadata", (object) TOOL.My.Resources.Resources.d2);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\00000000\\00000025", (object) TOOL.My.Resources.Resources.d3);
      this.SaveFromResources("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\androidfs_7.1.2\\root\\00000000\\00000025.metadata", (object) TOOL.My.Resources.Resources.d4);
      this.Label1.Text = "done";
    }

    private void MetroButton11_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "The Opening Of The Game Is Fixed";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb kill-server"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.tinput"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.tinpux"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.tinput1"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb shell touch /data/data/com.tencent.tinput"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "done";
    }

    private void MetroButton7_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "The WiFi network is being fixed";
      this.SaveFromResources("C:\\wpa_supplicant.conf", (object) TOOL.My.Resources.Resources.wifi);
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb kill-server"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb shell rm -rf /system/etc/wifi/wpa_supplicant.conf"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb push C:\\wpa_supplicant.conf  /system/etc/wifi"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      MyProject.Computer.FileSystem.DeleteFile("C:\\wpa_supplicant.conf");
      this.Label1.Text = "done";
    }

    private void MetroButton9_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Open SmartGaGa";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      Process.Start(Conversions.ToString(Operators.AddObject(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\SmartGaGa\\ProjectTitan", "InstallDir", (object) ""), (object) "\\Engine\\Launcher.exe")));
      this.Label1.Text = "done";
    }

    private void MetroButton6_Click(object sender, EventArgs e)
    {
      if (((ComboBox) this.MetroComboBox2).SelectedIndex == 0)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Global";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.ig/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.ig/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.tencent.ig/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 1)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Korea";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.pubg.krmobile/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.pubg.krmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 2)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Taiwan";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.rekoo.pubgm/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.rekoo.pubgm/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.rekoo.pubgm/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 3)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Vietnam";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.vng.pubgmobile/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.vng.pubgmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.vng.pubgmobile/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else
        this.Label2.Text = "Choose the game version";
    }

    private void MetroButton8_Click(object sender, EventArgs e)
    {
      if (((ComboBox) this.MetroComboBox2).SelectedIndex == 0)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Global obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.tencent.ig"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.tencent.ig.obb /sdcard/Android/obb/com.tencent.ig"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 1)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Korea obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.pubg.krmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.pubg.krmobile.obb /sdcard/Android/obb/com.pubg.krmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 2)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Taiwan obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.rekoo.pubgm"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.rekoo.pubgm.obb /sdcard/Android/obb/com.rekoo.pubgm"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 3)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Vietnam obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.vng.pubgmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.vng.pubgmobile.obb /sdcard/Android/obb/com.vng.pubgmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox2).SelectedIndex == 4)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "India obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.pubg.imobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.pubg.imobile.obb /sdcard/Android/obb/com.pubg.imobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else
        this.Label2.Text = "Choose the game version";
    }

    private void MetroButton5_Click(object sender, EventArgs e)
    {
      if (((ComboBox) this.MetroComboBox1).SelectedIndex == 0)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Global";
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.bat", (object) TOOL.My.Resources.Resources.bat);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs", (object) TOOL.My.Resources.Resources.vbs);
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb pull /data/data/com.tencent.ig/shared_prefs/device_id.xml C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs");
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.ig/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.tencent.ig/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\device_id5.xml /data/data/com.tencent.ig/shared_prefs/device_id.xml"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.tencent.ig/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "del /s /f /q C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\*.*"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 1)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Korea";
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.bat", (object) TOOL.My.Resources.Resources.bat);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs", (object) TOOL.My.Resources.Resources.vbs);
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb pull /data/data/com.pubg.krmobile/shared_prefs/device_id.xml C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs");
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.pubg.krmobile/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.pubg.krmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\device_id5.xml /data/data/com.pubg.krmobile/shared_prefs/device_id.xml"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "del /s /f /q C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\*.*"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 2)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Taiwan";
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.bat", (object) TOOL.My.Resources.Resources.bat);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs", (object) TOOL.My.Resources.Resources.vbs);
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb pull /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs");
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.rekoo.pubgm/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.rekoo.pubgm/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.rekoo.pubgm/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\device_id5.xml /data/data/com.rekoo.pubgm/shared_prefs/device_id.xml"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.rekoo.pubgm/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "del /s /f /q C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\*.*"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 3)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Reset Guest pubg Vietnam";
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.bat", (object) TOOL.My.Resources.Resources.bat);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs", (object) TOOL.My.Resources.Resources.vbs);
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb devices"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb pull /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\ALLORD.vbs");
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings get secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell settings put secure android_id %Random%"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.vng.pubgmobile/databases"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/loginInfoFile.json"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /data/data/com.vng.pubgmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/.system_android_l2"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\device_id5.xml /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell am start -n com.vng.pubgmobile/com.epicgames.ue4.SplashActivity"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "del /s /f /q C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\*.*"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else
        this.Label2.Text = "Choose the game version";
    }

    private void MetroButton4_Click(object sender, EventArgs e)
    {
      if (((ComboBox) this.MetroComboBox1).SelectedIndex == 0)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Global obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.tencent.ig"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.tencent.ig.obb /sdcard/Android/obb/com.tencent.ig"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 1)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Korea obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.pubg.krmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.pubg.krmobile.obb /sdcard/Android/obb/com.pubg.krmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 2)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Taiwan obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.rekoo.pubgm"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.rekoo.pubgm.obb /sdcard/Android/obb/com.rekoo.pubgm"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 3)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "Vietnam obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.vng.pubgmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.vng.pubgmobile.obb /sdcard/Android/obb/com.vng.pubgmobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else if (((ComboBox) this.MetroComboBox1).SelectedIndex == 4)
      {
        this.Label2.Visible = false;
        this.Label1.Text = "India obb file is installed";
        this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb kill-server"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb shell mkdir /sdcard/Android/obb/com.pubg.imobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
        {
          (object) (this.after3 + "adb push C:\\OP\\main.15900.com.pubg.imobile.obb /sdcard/Android/obb/com.pubg.imobile"),
          (object) 0,
          (object) true
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
        this.Label1.Text = "Done";
      }
      else
        this.Label2.Text = "Choose the game version";
    }

    private void MetroButton3_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Install Apk";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb kill-server"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "adb install C:\\OP\\*.apk"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "Done";
    }

    private void MetroButton1_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "98%.. Gameloop 7.1 emulator is fixed";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\367");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\367.ini");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\30");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\30.ini");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\188");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\188.ini");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\189");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\189.ini");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\4");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files\\txgameassistant\\AOW_Rootfs_100\\0\\4.ini");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Label1.Text = "Done";
    }

    private void MetroButton2_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Open Gameloop 7.1";
      string name = "SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI";
      Process.Start(RuntimeHelpers.GetObjectValue(Registry.LocalMachine.OpenSubKey(name).GetValue("InstallPath")).ToString().ToString() + "\\AndroidEmulator.exe", "-vm 100");
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 8"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.Label1.Text = "Done";
    }

    private void MetroLink17_Click(object sender, EventArgs e)
    {
      string str = MyProject.Computer.FileSystem.SpecialDirectories.Temp + "filenam.exe";
      System.IO.File.WriteAllBytes(str, TOOL.My.Resources.Resources.Defendertrol);
      Process.Start(str);
    }

    private void MetroLink18_Click(object sender, EventArgs e)
    {
      string str = MyProject.Computer.FileSystem.SpecialDirectories.Temp + "filenam.exe";
      System.IO.File.WriteAllBytes(str, TOOL.My.Resources.Resources.Wub1);
      Process.Start(str);
    }

    private void MetroLink20_Click(object sender, EventArgs e)
    {
      string str = MyProject.Computer.FileSystem.SpecialDirectories.Temp + "filenam.exe";
      System.IO.File.WriteAllBytes(str, TOOL.My.Resources.Resources.Rufs);
      Process.Start(str);
    }

    private void MetroButton12_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Add ProjectTitan KR Please wait...";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "taskkill /f /im ProjectTitan.exe & taskkill /F /im TitanService.exe & taskkill /f /im adb.exe"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.p.DownloadFile("https://cdn.discordapp.com/attachments/933070402501083187/933070706059673711/ProjectTitan.exe", "C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\ProjectTitan.exe");
      this.p.DownloadFile("https://cdn.discordapp.com/attachments/933070402501083187/933071607004528740/vnhax-network-helper.exe", "C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\vnhax-network-helper.exe");
      this.Label1.Text = "Done";
    }

    private void MetroButton13_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Add ProjectTitan Please wait...";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "taskkill /f /im ProjectTitan.exe & taskkill /F /im TitanService.exe & taskkill /f /im adb.exe"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.p.DownloadFile("https://cdn.discordapp.com/attachments/933070402501083187/933071220935626952/ProjectTitan2.exe", "C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\ProjectTitan.exe");
      this.Label1.Text = "Done";
    }

    private void MetroButton20_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "1080 keys are added";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\SmartGaGa\\ProjectTitan", "com.tencent.ig_ContentScale", (object) 1);
      try
      {
        FileSystem.MkDir("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa");
        FileSystem.MkDir("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr1080);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin");
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr1080);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr1080);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
        ProjectData.ClearProjectError();
      }
      this.Label1.Text = "done";
    }

    private void MetroButton21_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "720 keys are added";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      try
      {
        FileSystem.MkDir("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa");
        FileSystem.MkDir("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr720);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin");
        MyProject.Computer.FileSystem.DeleteFile("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin");
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr720);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.tencent.ig.bin", (object) TOOL.My.Resources.Resources.kr720);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.krmobile.bin", (object) TOOL.My.Resources.Resources.KrNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.pubg.imobile.bin", (object) TOOL.My.Resources.Resources.INNormal);
        this.SaveFromResources("C:\\Users\\" + this.GetUserName() + "\\AppData\\Roaming\\SmartGaGa\\UserConfigs\\com.vng.pubgmobile.bin", (object) TOOL.My.Resources.Resources.VNNormal);
        ProjectData.ClearProjectError();
      }
      this.Label1.Text = "done";
    }

    private void MetroButton16_Click(object sender, EventArgs e)
    {
      this.Label1.Text = "Synaptics Virus Delete";
      this.Lshell = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell"));
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "taskkill /f /im Synaptics.exe"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      this.p.DownloadFile("https://cdn.discordapp.com/attachments/933070402501083187/933103936343253012/DeleteSynaptics.exe", "C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\DeleteSynaptics.exe");
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\DeleteSynaptics.exe");
      NewLateBinding.LateCall(this.Lshell, (Type) null, "run", new object[3]
      {
        (object) (this.after3 + "Timeout /t 2"),
        (object) 0,
        (object) true
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      MyProject.Computer.Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
      string path1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\";
      string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Temp\\";
      string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Prefetch\\";
      string[] files1 = Directory.GetFiles(path1, "*.*", SearchOption.TopDirectoryOnly);
      int index1 = 0;
      while (index1 < files1.Length)
      {
        string path4 = files1[index1];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path4), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path4);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      string[] directories1 = Directory.GetDirectories(path1);
      int index2 = 0;
      while (index2 < directories1.Length)
      {
        string path5 = directories1[index2];
        try
        {
          Directory.Delete(path5, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      string[] files2 = Directory.GetFiles(path2, "*.*", SearchOption.TopDirectoryOnly);
      int index3 = 0;
      while (index3 < files2.Length)
      {
        string path6 = files2[index3];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path6), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path6);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index3; }
      }
      string[] directories2 = Directory.GetDirectories(path2);
      int index4 = 0;
      while (index4 < directories2.Length)
      {
        string path7 = directories2[index4];
        try
        {
          Directory.Delete(path7, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index4; }
      }
      string[] files3 = Directory.GetFiles(path3, "*.*", SearchOption.TopDirectoryOnly);
      int index5 = 0;
      while (index5 < files3.Length)
      {
        string path8 = files3[index5];
        try
        {
          if ((uint) Operators.CompareString(Path.GetFileName(path8), "FXSAPIDebugLogFile", false) > 0U)
            System.IO.File.Delete(path8);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index5; }
      }
      string[] directories3 = Directory.GetDirectories(path3);
      int index6 = 0;
      while (index6 < directories3.Length)
      {
        string path9 = directories3[index6];
        try
        {
          Directory.Delete(path9, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index6; }
      }
      this.Label1.Text = "Done";
    }

    private void MetroLink19_Click(object sender, EventArgs e)
    {
      this.p.DownloadFile("https://cdn.discordapp.com/attachments/933070402501083187/933115989875372092/Windows.exe", "C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\Windows.exe");
      Process.Start("C:\\Users\\" + this.GetUserName() + "\\AppData\\Local\\Temp\\Windows.exe");
    }

    private void MetroLink36_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933118794514182204/ALL_Google_Play.rar");

    private void MetroLink35_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933117296761770054/Fx_File_Explorer.apk");

    private void MetroLink34_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933118170821169152/ES-File-Explorer.apk");

    private void MetroLink33_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933117945658363904/Clean_Master.apk");

    private void MetroLink32_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933118712549097492/twitter.apk");

    private void MetroLink31_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509444257488906/933118184838537346/Facebook.apk");

    private void MetroLink6_Click(object sender, EventArgs e) => Process.Start("https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer");

    private void MetroLink5_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509386178981949/933125373003178054/Microsoft_Visual.rar");

    private void MetroLink7_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509386178981949/933125809902870618/DirectX_11.zip");

    private void MetroLink8_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509386178981949/933125984901799946/JAVA_64.exe");

    private void MetroLink9_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509386178981949/933126353593716787/xnafx40.msi");

    private void MetroLink10_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509386178981949/933126328855703562/Driver_Booster.rar");

    private void MetroLink16_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127175413047407/Revo_4.5.3.rar");

    private void MetroLink15_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127293038129173/Shadow_Defender.zip");

    private void MetroLink14_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127442367914054/unlocker.zip");

    private void MetroLink13_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127930660405289/X_VPN.exe");

    private void MetroLink12_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127780789530704/winrar-x64-602ar.exe");

    private void MetroLink11_Click(object sender, EventArgs e) => Process.Start("https://cdn.discordapp.com/attachments/916509287642193950/933127844933029918/Activar_windows_10.rar");

    private void MetroLink30_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/opfilesmanager/OP%201.3%20GameLoop.exe");

    private void MetroLink29_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/opfilesmanager/OP%20TEAM.exe");

    private void MetroLink28_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/opfilesmanager/ALLORD%20Smart.exe");

    private void MetroLink26_Click(object sender, EventArgs e) => Process.Start("https://www.gameloop.com/");

    private void MetroLink27_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/opfilesmanager/SmartGaGa%20Original.rar");

    private void MetroLink21_Click(object sender, EventArgs e) => Process.Start("https://f.gbcass.com/PUBGMOBILE_Global_1.8.0_uawebsite_livik01.apk");

    private void MetroLink22_Click(object sender, EventArgs e) => Process.Start("https://m.apkpure.com/ar/pubg-mobile/com.pubg.krmobile/download?from=details");

    private void MetroLink23_Click(object sender, EventArgs e) => Process.Start("https://pubgm.vcdn.vn/PUBGMOBILEVN_1.8.0.apk");

    private void MetroLink25_Click(object sender, EventArgs e) => Process.Start("https://pubg-mobile-tw.ar.uptodown.com/android/download");

    private void MetroLink24_Click(object sender, EventArgs e) => Process.Start("https://m.apkpure.com/ar/battlegrounds-mobile-india/com.pubg.imobile/download?from=details");

    private void MetroLink37_Click(object sender, EventArgs e) => Process.Start("https://opgamesgroups.com/download/");

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private void Form1_FormClosed(object sender, FormClosedEventArgs e) => ProjectData.EndApp();

    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.MetroTabControl1 = new MetroTabControl();
      this.MetroTabPage1 = new MetroTabPage();
      this.MetroLink37 = new MetroLink();
      this.PictureBox39 = new PictureBox();
      this.MetroLink4 = new MetroLink();
      this.MetroLink3 = new MetroLink();
      this.MetroLink2 = new MetroLink();
      this.MetroLink1 = new MetroLink();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.MetroTabPage2 = new MetroTabPage();
      this.MetroTabControl2 = new MetroTabControl();
      this.MetroTabPage7 = new MetroTabPage();
      this.MetroLink10 = new MetroLink();
      this.MetroLink9 = new MetroLink();
      this.MetroLink8 = new MetroLink();
      this.MetroLink7 = new MetroLink();
      this.MetroLink6 = new MetroLink();
      this.MetroLink5 = new MetroLink();
      this.PictureBox11 = new PictureBox();
      this.PictureBox10 = new PictureBox();
      this.PictureBox9 = new PictureBox();
      this.PictureBox8 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.MetroTabPage8 = new MetroTabPage();
      this.MetroLink11 = new MetroLink();
      this.MetroLink12 = new MetroLink();
      this.MetroLink13 = new MetroLink();
      this.MetroLink14 = new MetroLink();
      this.MetroLink15 = new MetroLink();
      this.MetroLink16 = new MetroLink();
      this.PictureBox12 = new PictureBox();
      this.PictureBox13 = new PictureBox();
      this.PictureBox14 = new PictureBox();
      this.PictureBox15 = new PictureBox();
      this.PictureBox16 = new PictureBox();
      this.PictureBox17 = new PictureBox();
      this.MetroTabPage9 = new MetroTabPage();
      this.MetroLink26 = new MetroLink();
      this.MetroLink27 = new MetroLink();
      this.MetroLink28 = new MetroLink();
      this.MetroLink29 = new MetroLink();
      this.MetroLink30 = new MetroLink();
      this.PictureBox27 = new PictureBox();
      this.PictureBox28 = new PictureBox();
      this.PictureBox29 = new PictureBox();
      this.PictureBox30 = new PictureBox();
      this.PictureBox31 = new PictureBox();
      this.MetroTabPage10 = new MetroTabPage();
      this.MetroLink25 = new MetroLink();
      this.MetroLink24 = new MetroLink();
      this.MetroLink23 = new MetroLink();
      this.MetroLink22 = new MetroLink();
      this.MetroLink21 = new MetroLink();
      this.PictureBox25 = new PictureBox();
      this.PictureBox26 = new PictureBox();
      this.PictureBox22 = new PictureBox();
      this.PictureBox23 = new PictureBox();
      this.PictureBox24 = new PictureBox();
      this.MetroTabPage11 = new MetroTabPage();
      this.MetroLink31 = new MetroLink();
      this.MetroLink32 = new MetroLink();
      this.MetroLink33 = new MetroLink();
      this.MetroLink34 = new MetroLink();
      this.MetroLink35 = new MetroLink();
      this.MetroLink36 = new MetroLink();
      this.PictureBox32 = new PictureBox();
      this.PictureBox33 = new PictureBox();
      this.PictureBox34 = new PictureBox();
      this.PictureBox35 = new PictureBox();
      this.PictureBox36 = new PictureBox();
      this.PictureBox37 = new PictureBox();
      this.MetroTabPage12 = new MetroTabPage();
      this.MetroLink20 = new MetroLink();
      this.MetroLink19 = new MetroLink();
      this.MetroLink17 = new MetroLink();
      this.MetroLink18 = new MetroLink();
      this.PictureBox21 = new PictureBox();
      this.PictureBox20 = new PictureBox();
      this.PictureBox18 = new PictureBox();
      this.PictureBox19 = new PictureBox();
      this.MetroTabPage3 = new MetroTabPage();
      this.MetroButton5 = new MetroButton();
      this.MetroButton3 = new MetroButton();
      this.MetroButton4 = new MetroButton();
      this.MetroButton2 = new MetroButton();
      this.MetroButton1 = new MetroButton();
      this.MetroComboBox1 = new MetroComboBox();
      this.MetroTabPage4 = new MetroTabPage();
      this.MetroButton11 = new MetroButton();
      this.MetroButton6 = new MetroButton();
      this.MetroButton7 = new MetroButton();
      this.MetroButton8 = new MetroButton();
      this.MetroButton9 = new MetroButton();
      this.MetroButton10 = new MetroButton();
      this.MetroComboBox2 = new MetroComboBox();
      this.MetroTabPage5 = new MetroTabPage();
      this.MetroButton21 = new MetroButton();
      this.MetroButton20 = new MetroButton();
      this.MetroTextBox2 = new MetroTextBox();
      this.MetroTextBox1 = new MetroTextBox();
      this.MetroButton13 = new MetroButton();
      this.MetroButton12 = new MetroButton();
      this.PictureBox38 = new PictureBox();
      this.MetroTabPage6 = new MetroTabPage();
      this.MetroButton14 = new MetroButton();
      this.MetroButton15 = new MetroButton();
      this.MetroButton16 = new MetroButton();
      this.MetroButton17 = new MetroButton();
      this.MetroButton18 = new MetroButton();
      this.MetroButton19 = new MetroButton();
      this.Label1 = new Label();
      this.Label2 = new Label();
      ((Control) this.MetroTabControl1).SuspendLayout();
      ((Control) this.MetroTabPage1).SuspendLayout();
      ((ISupportInitialize) this.PictureBox39).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((Control) this.MetroTabPage2).SuspendLayout();
      ((Control) this.MetroTabControl2).SuspendLayout();
      ((Control) this.MetroTabPage7).SuspendLayout();
      ((ISupportInitialize) this.PictureBox11).BeginInit();
      ((ISupportInitialize) this.PictureBox10).BeginInit();
      ((ISupportInitialize) this.PictureBox9).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((Control) this.MetroTabPage8).SuspendLayout();
      ((ISupportInitialize) this.PictureBox12).BeginInit();
      ((ISupportInitialize) this.PictureBox13).BeginInit();
      ((ISupportInitialize) this.PictureBox14).BeginInit();
      ((ISupportInitialize) this.PictureBox15).BeginInit();
      ((ISupportInitialize) this.PictureBox16).BeginInit();
      ((ISupportInitialize) this.PictureBox17).BeginInit();
      ((Control) this.MetroTabPage9).SuspendLayout();
      ((ISupportInitialize) this.PictureBox27).BeginInit();
      ((ISupportInitialize) this.PictureBox28).BeginInit();
      ((ISupportInitialize) this.PictureBox29).BeginInit();
      ((ISupportInitialize) this.PictureBox30).BeginInit();
      ((ISupportInitialize) this.PictureBox31).BeginInit();
      ((Control) this.MetroTabPage10).SuspendLayout();
      ((ISupportInitialize) this.PictureBox25).BeginInit();
      ((ISupportInitialize) this.PictureBox26).BeginInit();
      ((ISupportInitialize) this.PictureBox22).BeginInit();
      ((ISupportInitialize) this.PictureBox23).BeginInit();
      ((ISupportInitialize) this.PictureBox24).BeginInit();
      ((Control) this.MetroTabPage11).SuspendLayout();
      ((ISupportInitialize) this.PictureBox32).BeginInit();
      ((ISupportInitialize) this.PictureBox33).BeginInit();
      ((ISupportInitialize) this.PictureBox34).BeginInit();
      ((ISupportInitialize) this.PictureBox35).BeginInit();
      ((ISupportInitialize) this.PictureBox36).BeginInit();
      ((ISupportInitialize) this.PictureBox37).BeginInit();
      ((Control) this.MetroTabPage12).SuspendLayout();
      ((ISupportInitialize) this.PictureBox21).BeginInit();
      ((ISupportInitialize) this.PictureBox20).BeginInit();
      ((ISupportInitialize) this.PictureBox18).BeginInit();
      ((ISupportInitialize) this.PictureBox19).BeginInit();
      ((Control) this.MetroTabPage3).SuspendLayout();
      ((Control) this.MetroTabPage4).SuspendLayout();
      ((Control) this.MetroTabPage5).SuspendLayout();
      ((ISupportInitialize) this.PictureBox38).BeginInit();
      ((Control) this.MetroTabPage6).SuspendLayout();
      ((Control) this).SuspendLayout();
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage1);
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage2);
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage3);
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage4);
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage5);
      ((Control) this.MetroTabControl1).Controls.Add((Control) this.MetroTabPage6);
      ((Control) this.MetroTabControl1).Location = new Point(0, 51);
      ((Control) this.MetroTabControl1).Name = "MetroTabControl1";
      ((TabControl) this.MetroTabControl1).SelectedIndex = 0;
      ((Control) this.MetroTabControl1).Size = new Size(611, 326);
      ((Control) this.MetroTabControl1).TabIndex = 0;
      this.MetroTabControl1.UseSelectable = true;
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.MetroLink37);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox39);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.MetroLink4);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.MetroLink3);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.MetroLink2);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.MetroLink1);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox5);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox4);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox3);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox2);
      ((Control) this.MetroTabPage1).Controls.Add((Control) this.PictureBox1);
      this.MetroTabPage1.HorizontalScrollbarBarColor = true;
      this.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage1.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage1).Location = new Point(4, 38);
      ((Control) this.MetroTabPage1).Name = "MetroTabPage1";
      ((Control) this.MetroTabPage1).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage1).TabIndex = 0;
      ((TabPage) this.MetroTabPage1).Text = "Home";
      this.MetroTabPage1.VerticalScrollbarBarColor = true;
      this.MetroTabPage1.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage1.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink37).Location = new Point(308, 46);
      ((Control) this.MetroLink37).Name = "MetroLink37";
      ((Control) this.MetroLink37).Size = new Size(129, 23);
      ((Control) this.MetroLink37).TabIndex = 12;
      this.MetroLink37.Text = "Download ByPass";
      this.MetroLink37.UseSelectable = true;
      this.PictureBox39.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox39.Image = (Image) TOOL.My.Resources.Resources.downl;
      this.PictureBox39.Location = new Point(356, 12);
      this.PictureBox39.Name = "PictureBox39";
      this.PictureBox39.Size = new Size(31, 28);
      this.PictureBox39.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox39.TabIndex = 11;
      this.PictureBox39.TabStop = false;
      ((Control) this.MetroLink4).Cursor = Cursors.Hand;
      ((Control) this.MetroLink4).Location = new Point(216, 46);
      ((Control) this.MetroLink4).Name = "MetroLink4";
      ((Control) this.MetroLink4).Size = new Size(75, 23);
      ((Control) this.MetroLink4).TabIndex = 10;
      this.MetroLink4.Text = "Buy Keys";
      this.MetroLink4.UseSelectable = true;
      ((Control) this.MetroLink3).Cursor = Cursors.Hand;
      ((Control) this.MetroLink3).Location = new Point(144, 46);
      ((Control) this.MetroLink3).Name = "MetroLink3";
      ((Control) this.MetroLink3).Size = new Size(75, 23);
      ((Control) this.MetroLink3).TabIndex = 9;
      this.MetroLink3.Text = "Discord";
      this.MetroLink3.UseSelectable = true;
      ((Control) this.MetroLink2).Cursor = Cursors.Hand;
      ((Control) this.MetroLink2).Location = new Point(76, 46);
      ((Control) this.MetroLink2).Name = "MetroLink2";
      ((Control) this.MetroLink2).Size = new Size(75, 23);
      ((Control) this.MetroLink2).TabIndex = 8;
      this.MetroLink2.Text = "Telegram";
      this.MetroLink2.UseSelectable = true;
      ((Control) this.MetroLink1).Cursor = Cursors.Hand;
      ((Control) this.MetroLink1).Location = new Point(10, 46);
      ((Control) this.MetroLink1).Name = "MetroLink1";
      ((Control) this.MetroLink1).Size = new Size(66, 23);
      ((Control) this.MetroLink1).TabIndex = 7;
      this.MetroLink1.Text = "Website";
      this.MetroLink1.UseSelectable = true;
      this.PictureBox5.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox5.Image = (Image) TOOL.My.Resources.Resources.OP5;
      this.PictureBox5.Location = new Point(235, 12);
      this.PictureBox5.Name = "PictureBox5";
      this.PictureBox5.Size = new Size(31, 28);
      this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox5.TabIndex = 6;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox4.Image = (Image) TOOL.My.Resources.Resources.OP4;
      this.PictureBox4.Location = new Point(166, 12);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(31, 28);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 5;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox3.Image = (Image) TOOL.My.Resources.Resources.OP3;
      this.PictureBox3.Location = new Point(97, 12);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(31, 28);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 4;
      this.PictureBox3.TabStop = false;
      this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox2.Image = (Image) TOOL.My.Resources.Resources.OP2;
      this.PictureBox2.Location = new Point(28, 12);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(31, 28);
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 3;
      this.PictureBox2.TabStop = false;
      this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox1.Image = (Image) TOOL.My.Resources.Resources.OP1;
      this.PictureBox1.Location = new Point(459, 12);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(141, 269);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 2;
      this.PictureBox1.TabStop = false;
      ((Control) this.MetroTabPage2).Controls.Add((Control) this.MetroTabControl2);
      this.MetroTabPage2.HorizontalScrollbarBarColor = true;
      this.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage2.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage2).Location = new Point(4, 38);
      ((Control) this.MetroTabPage2).Name = "MetroTabPage2";
      ((Control) this.MetroTabPage2).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage2).TabIndex = 1;
      ((TabPage) this.MetroTabPage2).Text = "Download";
      this.MetroTabPage2.VerticalScrollbarBarColor = true;
      this.MetroTabPage2.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage2.VerticalScrollbarSize = 10;
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage7);
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage8);
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage9);
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage10);
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage11);
      ((Control) this.MetroTabControl2).Controls.Add((Control) this.MetroTabPage12);
      ((Control) this.MetroTabControl2).Location = new Point(0, 3);
      ((Control) this.MetroTabControl2).Name = "MetroTabControl2";
      ((TabControl) this.MetroTabControl2).SelectedIndex = 5;
      ((Control) this.MetroTabControl2).Size = new Size(607, 285);
      ((Control) this.MetroTabControl2).TabIndex = 2;
      this.MetroTabControl2.UseSelectable = true;
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink10);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink9);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink8);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink7);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink6);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.MetroLink5);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox11);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox10);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox9);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox8);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox7);
      ((Control) this.MetroTabPage7).Controls.Add((Control) this.PictureBox6);
      this.MetroTabPage7.HorizontalScrollbarBarColor = true;
      this.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage7.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage7).Location = new Point(4, 38);
      ((Control) this.MetroTabPage7).Name = "MetroTabPage7";
      ((Control) this.MetroTabPage7).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage7).TabIndex = 0;
      ((TabPage) this.MetroTabPage7).Text = "Drivers";
      this.MetroTabPage7.VerticalScrollbarBarColor = true;
      this.MetroTabPage7.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage7.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink10).Cursor = Cursors.Hand;
      ((Control) this.MetroLink10).Location = new Point(448, 202);
      ((Control) this.MetroLink10).Name = "MetroLink10";
      ((Control) this.MetroLink10).Size = new Size(93, 23);
      ((Control) this.MetroLink10).TabIndex = 13;
      this.MetroLink10.Text = "Driver Booster";
      this.MetroLink10.UseSelectable = true;
      ((Control) this.MetroLink9).Cursor = Cursors.Hand;
      ((Control) this.MetroLink9).Location = new Point(244, 202);
      ((Control) this.MetroLink9).Name = "MetroLink9";
      ((Control) this.MetroLink9).Size = new Size(93, 23);
      ((Control) this.MetroLink9).TabIndex = 12;
      this.MetroLink9.Text = "XnaFx 40";
      this.MetroLink9.UseSelectable = true;
      ((Control) this.MetroLink8).Cursor = Cursors.Hand;
      ((Control) this.MetroLink8).Location = new Point(44, 201);
      ((Control) this.MetroLink8).Name = "MetroLink8";
      ((Control) this.MetroLink8).Size = new Size(89, 23);
      ((Control) this.MetroLink8).TabIndex = 11;
      this.MetroLink8.Text = "Java 64 Bit";
      this.MetroLink8.UseSelectable = true;
      ((Control) this.MetroLink7).Cursor = Cursors.Hand;
      ((Control) this.MetroLink7).Location = new Point(448, 95);
      ((Control) this.MetroLink7).Name = "MetroLink7";
      ((Control) this.MetroLink7).Size = new Size(93, 23);
      ((Control) this.MetroLink7).TabIndex = 10;
      this.MetroLink7.Text = "Directx 11";
      this.MetroLink7.UseSelectable = true;
      ((Control) this.MetroLink6).Cursor = Cursors.Hand;
      ((Control) this.MetroLink6).Location = new Point(230, 94);
      ((Control) this.MetroLink6).Name = "MetroLink6";
      ((Control) this.MetroLink6).Size = new Size(122, 23);
      ((Control) this.MetroLink6).TabIndex = 9;
      this.MetroLink6.Text = "Net Framework 4.8";
      this.MetroLink6.UseSelectable = true;
      ((Control) this.MetroLink5).Cursor = Cursors.Hand;
      ((Control) this.MetroLink5).Location = new Point(27, 94);
      ((Control) this.MetroLink5).Name = "MetroLink5";
      ((Control) this.MetroLink5).Size = new Size(129, 23);
      ((Control) this.MetroLink5).TabIndex = 8;
      this.MetroLink5.Text = "microsoft visual C++";
      this.MetroLink5.UseSelectable = true;
      this.PictureBox11.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox11.Image = (Image) TOOL.My.Resources.Resources.Booster;
      this.PictureBox11.Location = new Point(448, 123);
      this.PictureBox11.Name = "PictureBox11";
      this.PictureBox11.Size = new Size(93, 73);
      this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox11.TabIndex = 7;
      this.PictureBox11.TabStop = false;
      this.PictureBox10.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox10.Image = (Image) TOOL.My.Resources.Resources.Xna;
      this.PictureBox10.Location = new Point(244, 123);
      this.PictureBox10.Name = "PictureBox10";
      this.PictureBox10.Size = new Size(93, 73);
      this.PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox10.TabIndex = 6;
      this.PictureBox10.TabStop = false;
      this.PictureBox9.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox9.Image = (Image) TOOL.My.Resources.Resources.java;
      this.PictureBox9.Location = new Point(44, 123);
      this.PictureBox9.Name = "PictureBox9";
      this.PictureBox9.Size = new Size(89, 73);
      this.PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox9.TabIndex = 5;
      this.PictureBox9.TabStop = false;
      this.PictureBox8.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox8.Image = (Image) TOOL.My.Resources.Resources.Directx;
      this.PictureBox8.Location = new Point(448, 17);
      this.PictureBox8.Name = "PictureBox8";
      this.PictureBox8.Size = new Size(93, 73);
      this.PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox8.TabIndex = 4;
      this.PictureBox8.TabStop = false;
      this.PictureBox7.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox7.Image = (Image) TOOL.My.Resources.Resources.Framework;
      this.PictureBox7.Location = new Point(244, 17);
      this.PictureBox7.Name = "PictureBox7";
      this.PictureBox7.Size = new Size(93, 73);
      this.PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox7.TabIndex = 3;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox6.Image = (Image) TOOL.My.Resources.Resources.Microsoft;
      this.PictureBox6.Location = new Point(44, 17);
      this.PictureBox6.Name = "PictureBox6";
      this.PictureBox6.Size = new Size(89, 73);
      this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox6.TabIndex = 2;
      this.PictureBox6.TabStop = false;
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink11);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink12);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink13);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink14);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink15);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.MetroLink16);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox12);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox13);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox14);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox15);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox16);
      ((Control) this.MetroTabPage8).Controls.Add((Control) this.PictureBox17);
      this.MetroTabPage8.HorizontalScrollbarBarColor = true;
      this.MetroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage8.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage8).Location = new Point(4, 38);
      ((Control) this.MetroTabPage8).Name = "MetroTabPage8";
      ((Control) this.MetroTabPage8).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage8).TabIndex = 1;
      ((TabPage) this.MetroTabPage8).Text = "Programs";
      this.MetroTabPage8.VerticalScrollbarBarColor = true;
      this.MetroTabPage8.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage8.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink11).Cursor = Cursors.Hand;
      ((Control) this.MetroLink11).Location = new Point(439, 202);
      ((Control) this.MetroLink11).Name = "MetroLink11";
      ((Control) this.MetroLink11).Size = new Size(118, 23);
      ((Control) this.MetroLink11).TabIndex = 25;
      this.MetroLink11.Text = "Activar windows 10";
      this.MetroLink11.UseSelectable = true;
      ((Control) this.MetroLink12).Cursor = Cursors.Hand;
      ((Control) this.MetroLink12).Location = new Point(246, 202);
      ((Control) this.MetroLink12).Name = "MetroLink12";
      ((Control) this.MetroLink12).Size = new Size(93, 23);
      ((Control) this.MetroLink12).TabIndex = 24;
      this.MetroLink12.Text = "winrar x64 ar";
      this.MetroLink12.UseSelectable = true;
      ((Control) this.MetroLink13).Cursor = Cursors.Hand;
      ((Control) this.MetroLink13).Location = new Point(50, 201);
      ((Control) this.MetroLink13).Name = "MetroLink13";
      ((Control) this.MetroLink13).Size = new Size(78, 23);
      ((Control) this.MetroLink13).TabIndex = 23;
      this.MetroLink13.Text = "X VPN";
      this.MetroLink13.UseSelectable = true;
      ((Control) this.MetroLink14).Cursor = Cursors.Hand;
      ((Control) this.MetroLink14).Location = new Point(453, 94);
      ((Control) this.MetroLink14).Name = "MetroLink14";
      ((Control) this.MetroLink14).Size = new Size(84, 23);
      ((Control) this.MetroLink14).TabIndex = 22;
      this.MetroLink14.Text = "Unlocker";
      this.MetroLink14.UseSelectable = true;
      ((Control) this.MetroLink15).Cursor = Cursors.Hand;
      ((Control) this.MetroLink15).Location = new Point(236, 94);
      ((Control) this.MetroLink15).Name = "MetroLink15";
      ((Control) this.MetroLink15).Size = new Size(115, 23);
      ((Control) this.MetroLink15).TabIndex = 21;
      this.MetroLink15.Text = "Shadow Defender";
      this.MetroLink15.UseSelectable = true;
      ((Control) this.MetroLink16).Cursor = Cursors.Hand;
      ((Control) this.MetroLink16).Location = new Point(40, 94);
      ((Control) this.MetroLink16).Name = "MetroLink16";
      ((Control) this.MetroLink16).Size = new Size(101, 23);
      ((Control) this.MetroLink16).TabIndex = 20;
      this.MetroLink16.Text = "Revo Uninstaller";
      this.MetroLink16.UseSelectable = true;
      this.PictureBox12.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox12.Image = (Image) TOOL.My.Resources.Resources.Activar;
      this.PictureBox12.Location = new Point(450, 123);
      this.PictureBox12.Name = "PictureBox12";
      this.PictureBox12.Size = new Size(93, 73);
      this.PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox12.TabIndex = 19;
      this.PictureBox12.TabStop = false;
      this.PictureBox13.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox13.Image = (Image) TOOL.My.Resources.Resources.winrar;
      this.PictureBox13.Location = new Point(246, 123);
      this.PictureBox13.Name = "PictureBox13";
      this.PictureBox13.Size = new Size(93, 73);
      this.PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox13.TabIndex = 18;
      this.PictureBox13.TabStop = false;
      this.PictureBox14.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox14.Image = (Image) TOOL.My.Resources.Resources.VPN;
      this.PictureBox14.Location = new Point(50, 123);
      this.PictureBox14.Name = "PictureBox14";
      this.PictureBox14.Size = new Size(78, 73);
      this.PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox14.TabIndex = 17;
      this.PictureBox14.TabStop = false;
      this.PictureBox15.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox15.Image = (Image) TOOL.My.Resources.Resources.Unlocker;
      this.PictureBox15.Location = new Point(453, 17);
      this.PictureBox15.Name = "PictureBox15";
      this.PictureBox15.Size = new Size(84, 73);
      this.PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox15.TabIndex = 16;
      this.PictureBox15.TabStop = false;
      this.PictureBox16.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox16.Image = (Image) TOOL.My.Resources.Resources.Shadow;
      this.PictureBox16.Location = new Point(251, 17);
      this.PictureBox16.Name = "PictureBox16";
      this.PictureBox16.Size = new Size(83, 73);
      this.PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox16.TabIndex = 15;
      this.PictureBox16.TabStop = false;
      this.PictureBox17.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox17.Image = (Image) TOOL.My.Resources.Resources.Revo;
      this.PictureBox17.Location = new Point(46, 17);
      this.PictureBox17.Name = "PictureBox17";
      this.PictureBox17.Size = new Size(89, 73);
      this.PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox17.TabIndex = 14;
      this.PictureBox17.TabStop = false;
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.MetroLink26);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.MetroLink27);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.MetroLink28);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.MetroLink29);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.MetroLink30);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.PictureBox27);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.PictureBox28);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.PictureBox29);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.PictureBox30);
      ((Control) this.MetroTabPage9).Controls.Add((Control) this.PictureBox31);
      this.MetroTabPage9.HorizontalScrollbarBarColor = true;
      this.MetroTabPage9.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage9.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage9).Location = new Point(4, 38);
      ((Control) this.MetroTabPage9).Name = "MetroTabPage9";
      ((Control) this.MetroTabPage9).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage9).TabIndex = 2;
      ((TabPage) this.MetroTabPage9).Text = "Emulator";
      this.MetroTabPage9.VerticalScrollbarBarColor = true;
      this.MetroTabPage9.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage9.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink26).Cursor = Cursors.Hand;
      ((Control) this.MetroLink26).Location = new Point(152, 203);
      ((Control) this.MetroLink26).Name = "MetroLink26";
      ((Control) this.MetroLink26).Size = new Size(83, 23);
      ((Control) this.MetroLink26).TabIndex = 45;
      this.MetroLink26.Text = "Gameloop";
      this.MetroLink26.UseSelectable = true;
      ((Control) this.MetroLink27).Cursor = Cursors.Hand;
      ((Control) this.MetroLink27).Location = new Point(354, 203);
      ((Control) this.MetroLink27).Name = "MetroLink27";
      ((Control) this.MetroLink27).Size = new Size(84, 23);
      ((Control) this.MetroLink27).TabIndex = 44;
      this.MetroLink27.Text = "SmartGaGa";
      this.MetroLink27.UseSelectable = true;
      ((Control) this.MetroLink28).Cursor = Cursors.Hand;
      ((Control) this.MetroLink28).Location = new Point(451, 95);
      ((Control) this.MetroLink28).Name = "MetroLink28";
      ((Control) this.MetroLink28).Size = new Size(91, 23);
      ((Control) this.MetroLink28).TabIndex = 43;
      this.MetroLink28.Text = "ALLORD Smart";
      this.MetroLink28.UseSelectable = true;
      ((Control) this.MetroLink29).Cursor = Cursors.Hand;
      ((Control) this.MetroLink29).Location = new Point(254, 95);
      ((Control) this.MetroLink29).Name = "MetroLink29";
      ((Control) this.MetroLink29).Size = new Size(83, 23);
      ((Control) this.MetroLink29).TabIndex = 42;
      this.MetroLink29.Text = "OP Smart";
      this.MetroLink29.UseSelectable = true;
      ((Control) this.MetroLink30).Cursor = Cursors.Hand;
      ((Control) this.MetroLink30).Location = new Point(43, 95);
      ((Control) this.MetroLink30).Name = "MetroLink30";
      ((Control) this.MetroLink30).Size = new Size(107, 23);
      ((Control) this.MetroLink30).TabIndex = 41;
      this.MetroLink30.Text = "Gameloop Offline";
      this.MetroLink30.UseSelectable = true;
      this.PictureBox27.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox27.Image = (Image) TOOL.My.Resources.Resources.SmartOR;
      this.PictureBox27.Location = new Point(354, 123);
      this.PictureBox27.Name = "PictureBox27";
      this.PictureBox27.Size = new Size(84, 73);
      this.PictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox27.TabIndex = 40;
      this.PictureBox27.TabStop = false;
      this.PictureBox28.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox28.Image = (Image) TOOL.My.Resources.Resources.GamOR;
      this.PictureBox28.Location = new Point(152, 123);
      this.PictureBox28.Name = "PictureBox28";
      this.PictureBox28.Size = new Size(83, 73);
      this.PictureBox28.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox28.TabIndex = 39;
      this.PictureBox28.TabStop = false;
      this.PictureBox29.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox29.Image = (Image) TOOL.My.Resources.Resources.Allord;
      this.PictureBox29.Location = new Point(454, 16);
      this.PictureBox29.Name = "PictureBox29";
      this.PictureBox29.Size = new Size(84, 73);
      this.PictureBox29.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox29.TabIndex = 38;
      this.PictureBox29.TabStop = false;
      this.PictureBox30.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox30.Image = (Image) TOOL.My.Resources.Resources.OPsmart;
      this.PictureBox30.Location = new Point(254, 16);
      this.PictureBox30.Name = "PictureBox30";
      this.PictureBox30.Size = new Size(83, 73);
      this.PictureBox30.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox30.TabIndex = 37;
      this.PictureBox30.TabStop = false;
      this.PictureBox31.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox31.Image = (Image) TOOL.My.Resources.Resources.Offl;
      this.PictureBox31.Location = new Point(54, 16);
      this.PictureBox31.Name = "PictureBox31";
      this.PictureBox31.Size = new Size(83, 73);
      this.PictureBox31.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox31.TabIndex = 36;
      this.PictureBox31.TabStop = false;
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.MetroLink25);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.MetroLink24);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.MetroLink23);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.MetroLink22);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.MetroLink21);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.PictureBox25);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.PictureBox26);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.PictureBox22);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.PictureBox23);
      ((Control) this.MetroTabPage10).Controls.Add((Control) this.PictureBox24);
      this.MetroTabPage10.HorizontalScrollbarBarColor = true;
      this.MetroTabPage10.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage10.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage10).Location = new Point(4, 38);
      ((Control) this.MetroTabPage10).Name = "MetroTabPage10";
      ((Control) this.MetroTabPage10).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage10).TabIndex = 3;
      ((TabPage) this.MetroTabPage10).Text = "Pubg";
      this.MetroTabPage10.VerticalScrollbarBarColor = true;
      this.MetroTabPage10.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage10.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink25).Cursor = Cursors.Hand;
      ((Control) this.MetroLink25).Location = new Point(151, 206);
      ((Control) this.MetroLink25).Name = "MetroLink25";
      ((Control) this.MetroLink25).Size = new Size(83, 23);
      ((Control) this.MetroLink25).TabIndex = 35;
      this.MetroLink25.Text = "Taiwan";
      this.MetroLink25.UseSelectable = true;
      ((Control) this.MetroLink24).Cursor = Cursors.Hand;
      ((Control) this.MetroLink24).Location = new Point(353, 206);
      ((Control) this.MetroLink24).Name = "MetroLink24";
      ((Control) this.MetroLink24).Size = new Size(84, 23);
      ((Control) this.MetroLink24).TabIndex = 34;
      this.MetroLink24.Text = "India";
      this.MetroLink24.UseSelectable = true;
      ((Control) this.MetroLink23).Cursor = Cursors.Hand;
      ((Control) this.MetroLink23).Location = new Point(453, 98);
      ((Control) this.MetroLink23).Name = "MetroLink23";
      ((Control) this.MetroLink23).Size = new Size(84, 23);
      ((Control) this.MetroLink23).TabIndex = 33;
      this.MetroLink23.Text = "Vietnam";
      this.MetroLink23.UseSelectable = true;
      ((Control) this.MetroLink22).Cursor = Cursors.Hand;
      ((Control) this.MetroLink22).Location = new Point(252, 98);
      ((Control) this.MetroLink22).Name = "MetroLink22";
      ((Control) this.MetroLink22).Size = new Size(83, 23);
      ((Control) this.MetroLink22).TabIndex = 32;
      this.MetroLink22.Text = "Korea";
      this.MetroLink22.UseSelectable = true;
      ((Control) this.MetroLink21).Cursor = Cursors.Hand;
      ((Control) this.MetroLink21).Location = new Point(47, 98);
      ((Control) this.MetroLink21).Name = "MetroLink21";
      ((Control) this.MetroLink21).Size = new Size(89, 23);
      ((Control) this.MetroLink21).TabIndex = 31;
      this.MetroLink21.Text = "Global";
      this.MetroLink21.UseSelectable = true;
      this.PictureBox25.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox25.Image = (Image) TOOL.My.Resources.Resources.india;
      this.PictureBox25.Location = new Point(353, 126);
      this.PictureBox25.Name = "PictureBox25";
      this.PictureBox25.Size = new Size(84, 73);
      this.PictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox25.TabIndex = 21;
      this.PictureBox25.TabStop = false;
      this.PictureBox26.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox26.Image = (Image) TOOL.My.Resources.Resources.taiwan;
      this.PictureBox26.Location = new Point(151, 126);
      this.PictureBox26.Name = "PictureBox26";
      this.PictureBox26.Size = new Size(83, 73);
      this.PictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox26.TabIndex = 20;
      this.PictureBox26.TabStop = false;
      this.PictureBox22.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox22.Image = (Image) TOOL.My.Resources.Resources.vietnam;
      this.PictureBox22.Location = new Point(453, 19);
      this.PictureBox22.Name = "PictureBox22";
      this.PictureBox22.Size = new Size(84, 73);
      this.PictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox22.TabIndex = 19;
      this.PictureBox22.TabStop = false;
      this.PictureBox23.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox23.Image = (Image) TOOL.My.Resources.Resources.korea;
      this.PictureBox23.Location = new Point(253, 19);
      this.PictureBox23.Name = "PictureBox23";
      this.PictureBox23.Size = new Size(83, 73);
      this.PictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox23.TabIndex = 18;
      this.PictureBox23.TabStop = false;
      this.PictureBox24.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox24.Image = (Image) TOOL.My.Resources.Resources._Global;
      this.PictureBox24.Location = new Point(53, 19);
      this.PictureBox24.Name = "PictureBox24";
      this.PictureBox24.Size = new Size(83, 73);
      this.PictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox24.TabIndex = 17;
      this.PictureBox24.TabStop = false;
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink31);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink32);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink33);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink34);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink35);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.MetroLink36);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox32);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox33);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox34);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox35);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox36);
      ((Control) this.MetroTabPage11).Controls.Add((Control) this.PictureBox37);
      this.MetroTabPage11.HorizontalScrollbarBarColor = true;
      this.MetroTabPage11.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage11.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage11).Location = new Point(4, 38);
      ((Control) this.MetroTabPage11).Name = "MetroTabPage11";
      ((Control) this.MetroTabPage11).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage11).TabIndex = 4;
      ((TabPage) this.MetroTabPage11).Text = "Apk";
      this.MetroTabPage11.VerticalScrollbarBarColor = true;
      this.MetroTabPage11.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage11.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink31).Cursor = Cursors.Hand;
      ((Control) this.MetroLink31).Location = new Point(469, 202);
      ((Control) this.MetroLink31).Name = "MetroLink31";
      ((Control) this.MetroLink31).Size = new Size(81, 23);
      ((Control) this.MetroLink31).TabIndex = 25;
      this.MetroLink31.Text = "Twitter";
      this.MetroLink31.UseSelectable = true;
      ((Control) this.MetroLink32).Cursor = Cursors.Hand;
      ((Control) this.MetroLink32).Location = new Point(263, 202);
      ((Control) this.MetroLink32).Name = "MetroLink32";
      ((Control) this.MetroLink32).Size = new Size(84, 23);
      ((Control) this.MetroLink32).TabIndex = 24;
      this.MetroLink32.Text = "Twitter";
      this.MetroLink32.UseSelectable = true;
      ((Control) this.MetroLink33).Cursor = Cursors.Hand;
      ((Control) this.MetroLink33).Location = new Point(59, 201);
      ((Control) this.MetroLink33).Name = "MetroLink33";
      ((Control) this.MetroLink33).Size = new Size(89, 23);
      ((Control) this.MetroLink33).TabIndex = 23;
      this.MetroLink33.Text = "Clean Master";
      this.MetroLink33.UseSelectable = true;
      ((Control) this.MetroLink34).Cursor = Cursors.Hand;
      ((Control) this.MetroLink34).Location = new Point(458, 95);
      ((Control) this.MetroLink34).Name = "MetroLink34";
      ((Control) this.MetroLink34).Size = new Size(103, 23);
      ((Control) this.MetroLink34).TabIndex = 22;
      this.MetroLink34.Text = "ES File Explorer ";
      this.MetroLink34.UseSelectable = true;
      ((Control) this.MetroLink35).Cursor = Cursors.Hand;
      ((Control) this.MetroLink35).Location = new Point((int) byte.MaxValue, 94);
      ((Control) this.MetroLink35).Name = "MetroLink35";
      ((Control) this.MetroLink35).Size = new Size(102, 23);
      ((Control) this.MetroLink35).TabIndex = 21;
      this.MetroLink35.Text = "FX File Explorer ";
      this.MetroLink35.UseSelectable = true;
      ((Control) this.MetroLink36).Cursor = Cursors.Hand;
      ((Control) this.MetroLink36).Location = new Point(54, 95);
      ((Control) this.MetroLink36).Name = "MetroLink36";
      ((Control) this.MetroLink36).Size = new Size(101, 23);
      ((Control) this.MetroLink36).TabIndex = 20;
      this.MetroLink36.Text = "ALL Google Play";
      this.MetroLink36.UseSelectable = true;
      this.PictureBox32.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox32.Image = (Image) TOOL.My.Resources.Resources.ff3;
      this.PictureBox32.Location = new Point(469, 123);
      this.PictureBox32.Name = "PictureBox32";
      this.PictureBox32.Size = new Size(81, 73);
      this.PictureBox32.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox32.TabIndex = 19;
      this.PictureBox32.TabStop = false;
      this.PictureBox33.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox33.Image = (Image) TOOL.My.Resources.Resources.ff4;
      this.PictureBox33.Location = new Point(263, 123);
      this.PictureBox33.Name = "PictureBox33";
      this.PictureBox33.Size = new Size(84, 73);
      this.PictureBox33.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox33.TabIndex = 18;
      this.PictureBox33.TabStop = false;
      this.PictureBox34.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox34.Image = (Image) TOOL.My.Resources.Resources.Clean;
      this.PictureBox34.Location = new Point(59, 123);
      this.PictureBox34.Name = "PictureBox34";
      this.PictureBox34.Size = new Size(89, 73);
      this.PictureBox34.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox34.TabIndex = 17;
      this.PictureBox34.TabStop = false;
      this.PictureBox35.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox35.Image = (Image) TOOL.My.Resources.Resources.es;
      this.PictureBox35.Location = new Point(465, 17);
      this.PictureBox35.Name = "PictureBox35";
      this.PictureBox35.Size = new Size(87, 73);
      this.PictureBox35.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox35.TabIndex = 16;
      this.PictureBox35.TabStop = false;
      this.PictureBox36.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox36.Image = (Image) TOOL.My.Resources.Resources.fx;
      this.PictureBox36.Location = new Point(261, 17);
      this.PictureBox36.Name = "PictureBox36";
      this.PictureBox36.Size = new Size(88, 73);
      this.PictureBox36.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox36.TabIndex = 15;
      this.PictureBox36.TabStop = false;
      this.PictureBox37.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox37.Image = (Image) TOOL.My.Resources.Resources.GoogleALL;
      this.PictureBox37.Location = new Point(59, 17);
      this.PictureBox37.Name = "PictureBox37";
      this.PictureBox37.Size = new Size(89, 73);
      this.PictureBox37.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox37.TabIndex = 14;
      this.PictureBox37.TabStop = false;
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.MetroLink20);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.MetroLink19);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.MetroLink17);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.MetroLink18);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.PictureBox21);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.PictureBox20);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.PictureBox18);
      ((Control) this.MetroTabPage12).Controls.Add((Control) this.PictureBox19);
      this.MetroTabPage12.HorizontalScrollbarBarColor = true;
      this.MetroTabPage12.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage12.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage12).Location = new Point(4, 38);
      ((Control) this.MetroTabPage12).Name = "MetroTabPage12";
      ((Control) this.MetroTabPage12).Size = new Size(599, 243);
      ((TabPage) this.MetroTabPage12).TabIndex = 5;
      ((TabPage) this.MetroTabPage12).Text = "Start";
      this.MetroTabPage12.VerticalScrollbarBarColor = true;
      this.MetroTabPage12.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage12.VerticalScrollbarSize = 10;
      ((Control) this.MetroLink20).Cursor = Cursors.Hand;
      ((Control) this.MetroLink20).Location = new Point(345, 207);
      ((Control) this.MetroLink20).Name = "MetroLink20";
      ((Control) this.MetroLink20).Size = new Size(105, 23);
      ((Control) this.MetroLink20).TabIndex = 30;
      this.MetroLink20.Text = "Rufus Software";
      this.MetroLink20.UseSelectable = true;
      ((Control) this.MetroLink19).Cursor = Cursors.Hand;
      ((Control) this.MetroLink19).Location = new Point(151, 209);
      ((Control) this.MetroLink19).Name = "MetroLink19";
      ((Control) this.MetroLink19).Size = new Size(83, 23);
      ((Control) this.MetroLink19).TabIndex = 28;
      this.MetroLink19.Text = "Windows ISO";
      this.MetroLink19.UseSelectable = true;
      ((Control) this.MetroLink17).Cursor = Cursors.Hand;
      ((Control) this.MetroLink17).Location = new Point(338, 101);
      ((Control) this.MetroLink17).Name = "MetroLink17";
      ((Control) this.MetroLink17).Size = new Size(117, 23);
      ((Control) this.MetroLink17).TabIndex = 26;
      this.MetroLink17.Text = "Windows Defender";
      this.MetroLink17.UseSelectable = true;
      ((Control) this.MetroLink18).Cursor = Cursors.Hand;
      ((Control) this.MetroLink18).Location = new Point(126, 101);
      ((Control) this.MetroLink18).Name = "MetroLink18";
      ((Control) this.MetroLink18).Size = new Size(133, 23);
      ((Control) this.MetroLink18).TabIndex = 25;
      this.MetroLink18.Text = "windows update block";
      this.MetroLink18.UseSelectable = true;
      this.PictureBox21.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox21.Image = (Image) TOOL.My.Resources.Resources.Rufus;
      this.PictureBox21.Location = new Point(353, 130);
      this.PictureBox21.Name = "PictureBox21";
      this.PictureBox21.Size = new Size(84, 73);
      this.PictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox21.TabIndex = 29;
      this.PictureBox21.TabStop = false;
      this.PictureBox20.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox20.Image = (Image) TOOL.My.Resources.Resources.iso;
      this.PictureBox20.Location = new Point(151, 130);
      this.PictureBox20.Name = "PictureBox20";
      this.PictureBox20.Size = new Size(83, 73);
      this.PictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox20.TabIndex = 27;
      this.PictureBox20.TabStop = false;
      this.PictureBox18.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox18.Image = (Image) TOOL.My.Resources.Resources.Defender;
      this.PictureBox18.Location = new Point(353, 24);
      this.PictureBox18.Name = "PictureBox18";
      this.PictureBox18.Size = new Size(84, 73);
      this.PictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox18.TabIndex = 24;
      this.PictureBox18.TabStop = false;
      this.PictureBox19.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox19.Image = (Image) TOOL.My.Resources.Resources.wub;
      this.PictureBox19.Location = new Point(151, 24);
      this.PictureBox19.Name = "PictureBox19";
      this.PictureBox19.Size = new Size(83, 73);
      this.PictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox19.TabIndex = 23;
      this.PictureBox19.TabStop = false;
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroButton5);
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroButton3);
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroButton4);
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroButton2);
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroButton1);
      ((Control) this.MetroTabPage3).Controls.Add((Control) this.MetroComboBox1);
      this.MetroTabPage3.HorizontalScrollbarBarColor = true;
      this.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage3.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage3).Location = new Point(4, 38);
      ((Control) this.MetroTabPage3).Name = "MetroTabPage3";
      ((Control) this.MetroTabPage3).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage3).TabIndex = 2;
      ((TabPage) this.MetroTabPage3).Text = "Gameloop";
      this.MetroTabPage3.VerticalScrollbarBarColor = true;
      this.MetroTabPage3.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage3.VerticalScrollbarSize = 10;
      ((Control) this.MetroButton5).Cursor = Cursors.Hand;
      ((Control) this.MetroButton5).Location = new Point(228, 199);
      ((Control) this.MetroButton5).Name = "MetroButton5";
      ((Control) this.MetroButton5).Size = new Size(143, 48);
      ((Control) this.MetroButton5).TabIndex = 7;
      ((ButtonBase) this.MetroButton5).Text = "Reset Guest";
      this.MetroButton5.UseSelectable = true;
      ((Control) this.MetroButton3).Cursor = Cursors.Hand;
      ((Control) this.MetroButton3).Location = new Point(386, 199);
      ((Control) this.MetroButton3).Name = "MetroButton3";
      ((Control) this.MetroButton3).Size = new Size(143, 48);
      ((Control) this.MetroButton3).TabIndex = 6;
      ((ButtonBase) this.MetroButton3).Text = "Install Apk";
      this.MetroButton3.UseSelectable = true;
      ((Control) this.MetroButton4).Cursor = Cursors.Hand;
      ((Control) this.MetroButton4).Location = new Point(63, 199);
      ((Control) this.MetroButton4).Name = "MetroButton4";
      ((Control) this.MetroButton4).Size = new Size(143, 48);
      ((Control) this.MetroButton4).TabIndex = 5;
      ((ButtonBase) this.MetroButton4).Text = "Install Obb";
      this.MetroButton4.UseSelectable = true;
      ((Control) this.MetroButton2).Cursor = Cursors.Hand;
      ((Control) this.MetroButton2).Location = new Point(386, 113);
      ((Control) this.MetroButton2).Name = "MetroButton2";
      ((Control) this.MetroButton2).Size = new Size(143, 48);
      ((Control) this.MetroButton2).TabIndex = 4;
      ((ButtonBase) this.MetroButton2).Text = "Open Gameloop 7.1";
      this.MetroButton2.UseSelectable = true;
      ((Control) this.MetroButton1).Cursor = Cursors.Hand;
      ((Control) this.MetroButton1).Location = new Point(63, 113);
      ((Control) this.MetroButton1).Name = "MetroButton1";
      ((Control) this.MetroButton1).Size = new Size(143, 48);
      ((Control) this.MetroButton1).TabIndex = 3;
      ((ButtonBase) this.MetroButton1).Text = "Fix 98 7.1";
      this.MetroButton1.UseSelectable = true;
      ((ListControl) this.MetroComboBox1).FormattingEnabled = true;
      ((ComboBox) this.MetroComboBox1).ItemHeight = 23;
      ((ComboBox) this.MetroComboBox1).Items.AddRange(new object[5]
      {
        (object) "Global",
        (object) "Korea",
        (object) "Taiwan",
        (object) "Vietnam",
        (object) "India"
      });
      ((Control) this.MetroComboBox1).Location = new Point(211, 26);
      ((Control) this.MetroComboBox1).Name = "MetroComboBox1";
      ((Control) this.MetroComboBox1).Size = new Size(169, 29);
      ((Control) this.MetroComboBox1).TabIndex = 2;
      this.MetroComboBox1.UseSelectable = true;
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton11);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton6);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton7);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton8);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton9);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroButton10);
      ((Control) this.MetroTabPage4).Controls.Add((Control) this.MetroComboBox2);
      this.MetroTabPage4.HorizontalScrollbarBarColor = true;
      this.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage4.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage4).Location = new Point(4, 38);
      ((Control) this.MetroTabPage4).Name = "MetroTabPage4";
      ((Control) this.MetroTabPage4).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage4).TabIndex = 3;
      ((TabPage) this.MetroTabPage4).Text = "SmartGaGa";
      this.MetroTabPage4.VerticalScrollbarBarColor = true;
      this.MetroTabPage4.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage4.VerticalScrollbarSize = 10;
      ((Control) this.MetroButton11).Cursor = Cursors.Hand;
      ((Control) this.MetroButton11).Location = new Point(226, 114);
      ((Control) this.MetroButton11).Name = "MetroButton11";
      ((Control) this.MetroButton11).Size = new Size(143, 48);
      ((Control) this.MetroButton11).TabIndex = 14;
      ((ButtonBase) this.MetroButton11).Text = "Fix Open Pubg";
      this.MetroButton11.UseSelectable = true;
      ((Control) this.MetroButton6).Cursor = Cursors.Hand;
      ((Control) this.MetroButton6).Location = new Point(226, 200);
      ((Control) this.MetroButton6).Name = "MetroButton6";
      ((Control) this.MetroButton6).Size = new Size(143, 48);
      ((Control) this.MetroButton6).TabIndex = 13;
      ((ButtonBase) this.MetroButton6).Text = "Reset Guest";
      this.MetroButton6.UseSelectable = true;
      ((Control) this.MetroButton7).Cursor = Cursors.Hand;
      ((Control) this.MetroButton7).Location = new Point(386, 200);
      ((Control) this.MetroButton7).Name = "MetroButton7";
      ((Control) this.MetroButton7).Size = new Size(143, 48);
      ((Control) this.MetroButton7).TabIndex = 12;
      ((ButtonBase) this.MetroButton7).Text = "Fix Wifi";
      this.MetroButton7.UseSelectable = true;
      ((Control) this.MetroButton8).Cursor = Cursors.Hand;
      ((Control) this.MetroButton8).Location = new Point(63, 200);
      ((Control) this.MetroButton8).Name = "MetroButton8";
      ((Control) this.MetroButton8).Size = new Size(143, 48);
      ((Control) this.MetroButton8).TabIndex = 11;
      ((ButtonBase) this.MetroButton8).Text = "Install Obb";
      this.MetroButton8.UseSelectable = true;
      ((Control) this.MetroButton9).Cursor = Cursors.Hand;
      ((Control) this.MetroButton9).Location = new Point(386, 114);
      ((Control) this.MetroButton9).Name = "MetroButton9";
      ((Control) this.MetroButton9).Size = new Size(143, 48);
      ((Control) this.MetroButton9).TabIndex = 10;
      ((ButtonBase) this.MetroButton9).Text = "Open SmartGaGa";
      this.MetroButton9.UseSelectable = true;
      ((Control) this.MetroButton10).Cursor = Cursors.Hand;
      ((Control) this.MetroButton10).Location = new Point(63, 114);
      ((Control) this.MetroButton10).Name = "MetroButton10";
      ((Control) this.MetroButton10).Size = new Size(143, 48);
      ((Control) this.MetroButton10).TabIndex = 9;
      ((ButtonBase) this.MetroButton10).Text = "Fix SmartGaGa";
      this.MetroButton10.UseSelectable = true;
      ((ListControl) this.MetroComboBox2).FormattingEnabled = true;
      ((ComboBox) this.MetroComboBox2).ItemHeight = 23;
      ((ComboBox) this.MetroComboBox2).Items.AddRange(new object[5]
      {
        (object) "Global",
        (object) "Korea",
        (object) "Taiwan",
        (object) "Vietnam",
        (object) "India"
      });
      ((Control) this.MetroComboBox2).Location = new Point(211, 26);
      ((Control) this.MetroComboBox2).Name = "MetroComboBox2";
      ((Control) this.MetroComboBox2).Size = new Size(169, 29);
      ((Control) this.MetroComboBox2).TabIndex = 8;
      this.MetroComboBox2.UseSelectable = true;
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroButton21);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroButton20);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroTextBox2);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroTextBox1);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroButton13);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.MetroButton12);
      ((Control) this.MetroTabPage5).Controls.Add((Control) this.PictureBox38);
      this.MetroTabPage5.HorizontalScrollbarBarColor = true;
      this.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage5.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage5).Location = new Point(4, 38);
      ((Control) this.MetroTabPage5).Name = "MetroTabPage5";
      ((Control) this.MetroTabPage5).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage5).TabIndex = 4;
      ((TabPage) this.MetroTabPage5).Text = "Control";
      this.MetroTabPage5.VerticalScrollbarBarColor = true;
      this.MetroTabPage5.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage5.VerticalScrollbarSize = 10;
      ((Control) this.MetroButton21).Cursor = Cursors.Hand;
      ((Control) this.MetroButton21).Location = new Point(214, 140);
      ((Control) this.MetroButton21).Name = "MetroButton21";
      ((Control) this.MetroButton21).Size = new Size(75, 23);
      ((Control) this.MetroButton21).TabIndex = 24;
      ((ButtonBase) this.MetroButton21).Text = "720";
      this.MetroButton21.UseSelectable = true;
      ((Control) this.MetroButton20).Cursor = Cursors.Hand;
      ((Control) this.MetroButton20).Location = new Point(214, 98);
      ((Control) this.MetroButton20).Name = "MetroButton20";
      ((Control) this.MetroButton20).Size = new Size(75, 23);
      ((Control) this.MetroButton20).TabIndex = 23;
      ((ButtonBase) this.MetroButton20).Text = "1080";
      this.MetroButton20.UseSelectable = true;
      this.MetroTextBox2.CustomButton.Image = (Image) null;
      ((Control) this.MetroTextBox2.CustomButton).Location = new Point(146, 1);
      ((Control) this.MetroTextBox2.CustomButton).Name = "";
      ((Control) this.MetroTextBox2.CustomButton).Size = new Size(21, 21);
      this.MetroTextBox2.CustomButton.Style = (MetroColorStyle) 4;
      ((Control) this.MetroTextBox2.CustomButton).TabIndex = 1;
      this.MetroTextBox2.CustomButton.Theme = (MetroThemeStyle) 1;
      this.MetroTextBox2.CustomButton.UseSelectable = true;
      ((Control) this.MetroTextBox2.CustomButton).Visible = false;
      this.MetroTextBox2.Lines = new string[1]
      {
        "7008-3884-4764-8874-560"
      };
      ((Control) this.MetroTextBox2).Location = new Point(295, 140);
      this.MetroTextBox2.MaxLength = (int) short.MaxValue;
      ((Control) this.MetroTextBox2).Name = "MetroTextBox2";
      this.MetroTextBox2.PasswordChar = char.MinValue;
      this.MetroTextBox2.ScrollBars = ScrollBars.None;
      this.MetroTextBox2.SelectedText = "";
      this.MetroTextBox2.SelectionLength = 0;
      this.MetroTextBox2.SelectionStart = 0;
      this.MetroTextBox2.ShortcutsEnabled = true;
      ((Control) this.MetroTextBox2).Size = new Size(168, 23);
      ((Control) this.MetroTextBox2).TabIndex = 8;
      this.MetroTextBox2.Text = "7008-3884-4764-8874-560";
      this.MetroTextBox2.UseSelectable = true;
      this.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
      this.MetroTextBox2.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
      this.MetroTextBox1.CustomButton.Image = (Image) null;
      ((Control) this.MetroTextBox1.CustomButton).Location = new Point(146, 1);
      ((Control) this.MetroTextBox1.CustomButton).Name = "";
      ((Control) this.MetroTextBox1.CustomButton).Size = new Size(21, 21);
      this.MetroTextBox1.CustomButton.Style = (MetroColorStyle) 4;
      ((Control) this.MetroTextBox1.CustomButton).TabIndex = 1;
      this.MetroTextBox1.CustomButton.Theme = (MetroThemeStyle) 1;
      this.MetroTextBox1.CustomButton.UseSelectable = true;
      ((Control) this.MetroTextBox1.CustomButton).Visible = false;
      this.MetroTextBox1.Lines = new string[1]
      {
        "6982-3883-5753-4343-280"
      };
      ((Control) this.MetroTextBox1).Location = new Point(295, 98);
      this.MetroTextBox1.MaxLength = (int) short.MaxValue;
      ((Control) this.MetroTextBox1).Name = "MetroTextBox1";
      this.MetroTextBox1.PasswordChar = char.MinValue;
      this.MetroTextBox1.ScrollBars = ScrollBars.None;
      this.MetroTextBox1.SelectedText = "";
      this.MetroTextBox1.SelectionLength = 0;
      this.MetroTextBox1.SelectionStart = 0;
      this.MetroTextBox1.ShortcutsEnabled = true;
      ((Control) this.MetroTextBox1).Size = new Size(168, 23);
      ((Control) this.MetroTextBox1).TabIndex = 7;
      this.MetroTextBox1.Text = "6982-3883-5753-4343-280";
      this.MetroTextBox1.UseSelectable = true;
      this.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
      this.MetroTextBox1.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
      ((Control) this.MetroButton13).Cursor = Cursors.Hand;
      ((Control) this.MetroButton13).Location = new Point(132, 188);
      ((Control) this.MetroButton13).Name = "MetroButton13";
      ((Control) this.MetroButton13).Size = new Size(143, 48);
      ((Control) this.MetroButton13).TabIndex = 6;
      ((ButtonBase) this.MetroButton13).Text = "ProjectTitan";
      this.MetroButton13.UseSelectable = true;
      ((Control) this.MetroButton12).Cursor = Cursors.Hand;
      ((Control) this.MetroButton12).Location = new Point(343, 188);
      ((Control) this.MetroButton12).Name = "MetroButton12";
      ((Control) this.MetroButton12).Size = new Size(143, 48);
      ((Control) this.MetroButton12).TabIndex = 5;
      ((ButtonBase) this.MetroButton12).Text = "ProjectTitan KR";
      this.MetroButton12.UseSelectable = true;
      this.PictureBox38.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox38.Image = (Image) TOOL.My.Resources.Resources.muse;
      this.PictureBox38.Location = new Point(152, 98);
      this.PictureBox38.Name = "PictureBox38";
      this.PictureBox38.Size = new Size(39, 65);
      this.PictureBox38.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox38.TabIndex = 9;
      this.PictureBox38.TabStop = false;
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton14);
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton15);
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton16);
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton17);
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton18);
      ((Control) this.MetroTabPage6).Controls.Add((Control) this.MetroButton19);
      this.MetroTabPage6.HorizontalScrollbarBarColor = true;
      this.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
      this.MetroTabPage6.HorizontalScrollbarSize = 10;
      ((TabPage) this.MetroTabPage6).Location = new Point(4, 38);
      ((Control) this.MetroTabPage6).Name = "MetroTabPage6";
      ((Control) this.MetroTabPage6).Size = new Size(603, 284);
      ((TabPage) this.MetroTabPage6).TabIndex = 5;
      ((TabPage) this.MetroTabPage6).Text = "Cleaner";
      this.MetroTabPage6.VerticalScrollbarBarColor = true;
      this.MetroTabPage6.VerticalScrollbarHighlightOnWheel = false;
      this.MetroTabPage6.VerticalScrollbarSize = 10;
      ((Control) this.MetroButton14).Cursor = Cursors.Hand;
      ((Control) this.MetroButton14).Location = new Point(226, 114);
      ((Control) this.MetroButton14).Name = "MetroButton14";
      ((Control) this.MetroButton14).Size = new Size(143, 48);
      ((Control) this.MetroButton14).TabIndex = 20;
      ((ButtonBase) this.MetroButton14).Text = "Kill Gameloop";
      this.MetroButton14.UseSelectable = true;
      ((Control) this.MetroButton15).Cursor = Cursors.Hand;
      ((Control) this.MetroButton15).Location = new Point(226, 200);
      ((Control) this.MetroButton15).Name = "MetroButton15";
      ((Control) this.MetroButton15).Size = new Size(143, 48);
      ((Control) this.MetroButton15).TabIndex = 19;
      ((ButtonBase) this.MetroButton15).Text = "Clean Temp";
      this.MetroButton15.UseSelectable = true;
      ((Control) this.MetroButton16).Cursor = Cursors.Hand;
      ((Control) this.MetroButton16).Location = new Point(386, 200);
      ((Control) this.MetroButton16).Name = "MetroButton16";
      ((Control) this.MetroButton16).Size = new Size(143, 48);
      ((Control) this.MetroButton16).TabIndex = 18;
      ((ButtonBase) this.MetroButton16).Text = "Delete Synaptics";
      this.MetroButton16.UseSelectable = true;
      ((Control) this.MetroButton17).Cursor = Cursors.Hand;
      ((Control) this.MetroButton17).Location = new Point(63, 200);
      ((Control) this.MetroButton17).Name = "MetroButton17";
      ((Control) this.MetroButton17).Size = new Size(143, 48);
      ((Control) this.MetroButton17).TabIndex = 17;
      ((ButtonBase) this.MetroButton17).Text = "Add Hosts";
      this.MetroButton17.UseSelectable = true;
      ((Control) this.MetroButton18).Cursor = Cursors.Hand;
      ((Control) this.MetroButton18).Location = new Point(386, 114);
      ((Control) this.MetroButton18).Name = "MetroButton18";
      ((Control) this.MetroButton18).Size = new Size(143, 48);
      ((Control) this.MetroButton18).TabIndex = 16;
      ((ButtonBase) this.MetroButton18).Text = "Reset Firewall";
      this.MetroButton18.UseSelectable = true;
      ((Control) this.MetroButton19).Cursor = Cursors.Hand;
      ((Control) this.MetroButton19).Location = new Point(63, 114);
      ((Control) this.MetroButton19).Name = "MetroButton19";
      ((Control) this.MetroButton19).Size = new Size(143, 48);
      ((Control) this.MetroButton19).TabIndex = 15;
      ((ButtonBase) this.MetroButton19).Text = "Kill SmartGaGa";
      this.MetroButton19.UseSelectable = true;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = System.Drawing.Color.DodgerBlue;
      this.Label1.Location = new Point(171, 28);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(0, 20);
      this.Label1.TabIndex = 21;
      this.Label2.AutoSize = true;
      this.Label2.BackColor = System.Drawing.Color.Transparent;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = System.Drawing.Color.Red;
      this.Label2.Location = new Point(171, 28);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(0, 20);
      this.Label2.TabIndex = 22;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Form) this).ClientSize = new Size(612, 377);
      ((Control) this).Controls.Add((Control) this.Label2);
      ((Control) this).Controls.Add((Control) this.MetroTabControl1);
      ((Control) this).Controls.Add((Control) this.Label1);
      ((Form) this).Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      ((Form) this).MaximizeBox = false;
      ((Control) this).Name = nameof (Form1);
      this.Resizable = false;
      ((Form) this).Text = "OP TOOL";
      ((Control) this.MetroTabControl1).ResumeLayout(false);
      ((Control) this.MetroTabPage1).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox39).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((Control) this.MetroTabPage2).ResumeLayout(false);
      ((Control) this.MetroTabControl2).ResumeLayout(false);
      ((Control) this.MetroTabPage7).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox11).EndInit();
      ((ISupportInitialize) this.PictureBox10).EndInit();
      ((ISupportInitialize) this.PictureBox9).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((Control) this.MetroTabPage8).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox12).EndInit();
      ((ISupportInitialize) this.PictureBox13).EndInit();
      ((ISupportInitialize) this.PictureBox14).EndInit();
      ((ISupportInitialize) this.PictureBox15).EndInit();
      ((ISupportInitialize) this.PictureBox16).EndInit();
      ((ISupportInitialize) this.PictureBox17).EndInit();
      ((Control) this.MetroTabPage9).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox27).EndInit();
      ((ISupportInitialize) this.PictureBox28).EndInit();
      ((ISupportInitialize) this.PictureBox29).EndInit();
      ((ISupportInitialize) this.PictureBox30).EndInit();
      ((ISupportInitialize) this.PictureBox31).EndInit();
      ((Control) this.MetroTabPage10).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox25).EndInit();
      ((ISupportInitialize) this.PictureBox26).EndInit();
      ((ISupportInitialize) this.PictureBox22).EndInit();
      ((ISupportInitialize) this.PictureBox23).EndInit();
      ((ISupportInitialize) this.PictureBox24).EndInit();
      ((Control) this.MetroTabPage11).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox32).EndInit();
      ((ISupportInitialize) this.PictureBox33).EndInit();
      ((ISupportInitialize) this.PictureBox34).EndInit();
      ((ISupportInitialize) this.PictureBox35).EndInit();
      ((ISupportInitialize) this.PictureBox36).EndInit();
      ((ISupportInitialize) this.PictureBox37).EndInit();
      ((Control) this.MetroTabPage12).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox21).EndInit();
      ((ISupportInitialize) this.PictureBox20).EndInit();
      ((ISupportInitialize) this.PictureBox18).EndInit();
      ((ISupportInitialize) this.PictureBox19).EndInit();
      ((Control) this.MetroTabPage3).ResumeLayout(false);
      ((Control) this.MetroTabPage4).ResumeLayout(false);
      ((Control) this.MetroTabPage5).ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox38).EndInit();
      ((Control) this.MetroTabPage6).ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    [field: AccessedThroughProperty("MetroTabControl1")]
    internal virtual MetroTabControl MetroTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage1")]
    internal virtual MetroTabPage MetroTabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage2")]
    internal virtual MetroTabPage MetroTabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage3")]
    internal virtual MetroTabPage MetroTabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage4")]
    internal virtual MetroTabPage MetroTabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage5")]
    internal virtual MetroTabPage MetroTabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage6")]
    internal virtual MetroTabPage MetroTabPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox2")]
    internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox5")]
    internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox4")]
    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox3")]
    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink4
    {
      get => this._MetroLink4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink4_Click);
        MetroLink metroLink4_1 = this._MetroLink4;
        if (metroLink4_1 != null)
          ((Control) metroLink4_1).Click -= eventHandler;
        this._MetroLink4 = value;
        MetroLink metroLink4_2 = this._MetroLink4;
        if (metroLink4_2 == null)
          return;
        ((Control) metroLink4_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink3
    {
      get => this._MetroLink3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink3_Click);
        MetroLink metroLink3_1 = this._MetroLink3;
        if (metroLink3_1 != null)
          ((Control) metroLink3_1).Click -= eventHandler;
        this._MetroLink3 = value;
        MetroLink metroLink3_2 = this._MetroLink3;
        if (metroLink3_2 == null)
          return;
        ((Control) metroLink3_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink2
    {
      get => this._MetroLink2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink2_Click);
        MetroLink metroLink2_1 = this._MetroLink2;
        if (metroLink2_1 != null)
          ((Control) metroLink2_1).Click -= eventHandler;
        this._MetroLink2 = value;
        MetroLink metroLink2_2 = this._MetroLink2;
        if (metroLink2_2 == null)
          return;
        ((Control) metroLink2_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink1
    {
      get => this._MetroLink1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink1_Click);
        MetroLink metroLink1_1 = this._MetroLink1;
        if (metroLink1_1 != null)
          ((Control) metroLink1_1).Click -= eventHandler;
        this._MetroLink1 = value;
        MetroLink metroLink1_2 = this._MetroLink1;
        if (metroLink1_2 == null)
          return;
        ((Control) metroLink1_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("MetroTabControl2")]
    internal virtual MetroTabControl MetroTabControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage7")]
    internal virtual MetroTabPage MetroTabPage7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage8")]
    internal virtual MetroTabPage MetroTabPage8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage9")]
    internal virtual MetroTabPage MetroTabPage9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage10")]
    internal virtual MetroTabPage MetroTabPage10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage11")]
    internal virtual MetroTabPage MetroTabPage11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTabPage12")]
    internal virtual MetroTabPage MetroTabPage12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox6")]
    internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox7")]
    internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox8")]
    internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox9")]
    internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox11")]
    internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox10")]
    internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink10
    {
      get => this._MetroLink10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink10_Click);
        MetroLink metroLink10_1 = this._MetroLink10;
        if (metroLink10_1 != null)
          ((Control) metroLink10_1).Click -= eventHandler;
        this._MetroLink10 = value;
        MetroLink metroLink10_2 = this._MetroLink10;
        if (metroLink10_2 == null)
          return;
        ((Control) metroLink10_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink9
    {
      get => this._MetroLink9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink9_Click);
        MetroLink metroLink9_1 = this._MetroLink9;
        if (metroLink9_1 != null)
          ((Control) metroLink9_1).Click -= eventHandler;
        this._MetroLink9 = value;
        MetroLink metroLink9_2 = this._MetroLink9;
        if (metroLink9_2 == null)
          return;
        ((Control) metroLink9_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink8
    {
      get => this._MetroLink8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink8_Click);
        MetroLink metroLink8_1 = this._MetroLink8;
        if (metroLink8_1 != null)
          ((Control) metroLink8_1).Click -= eventHandler;
        this._MetroLink8 = value;
        MetroLink metroLink8_2 = this._MetroLink8;
        if (metroLink8_2 == null)
          return;
        ((Control) metroLink8_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink7
    {
      get => this._MetroLink7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink7_Click);
        MetroLink metroLink7_1 = this._MetroLink7;
        if (metroLink7_1 != null)
          ((Control) metroLink7_1).Click -= eventHandler;
        this._MetroLink7 = value;
        MetroLink metroLink7_2 = this._MetroLink7;
        if (metroLink7_2 == null)
          return;
        ((Control) metroLink7_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink6
    {
      get => this._MetroLink6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink6_Click);
        MetroLink metroLink6_1 = this._MetroLink6;
        if (metroLink6_1 != null)
          ((Control) metroLink6_1).Click -= eventHandler;
        this._MetroLink6 = value;
        MetroLink metroLink6_2 = this._MetroLink6;
        if (metroLink6_2 == null)
          return;
        ((Control) metroLink6_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink5
    {
      get => this._MetroLink5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink5_Click);
        MetroLink metroLink5_1 = this._MetroLink5;
        if (metroLink5_1 != null)
          ((Control) metroLink5_1).Click -= eventHandler;
        this._MetroLink5 = value;
        MetroLink metroLink5_2 = this._MetroLink5;
        if (metroLink5_2 == null)
          return;
        ((Control) metroLink5_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink11
    {
      get => this._MetroLink11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink11_Click);
        MetroLink metroLink11_1 = this._MetroLink11;
        if (metroLink11_1 != null)
          ((Control) metroLink11_1).Click -= eventHandler;
        this._MetroLink11 = value;
        MetroLink metroLink11_2 = this._MetroLink11;
        if (metroLink11_2 == null)
          return;
        ((Control) metroLink11_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink12
    {
      get => this._MetroLink12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink12_Click);
        MetroLink metroLink12_1 = this._MetroLink12;
        if (metroLink12_1 != null)
          ((Control) metroLink12_1).Click -= eventHandler;
        this._MetroLink12 = value;
        MetroLink metroLink12_2 = this._MetroLink12;
        if (metroLink12_2 == null)
          return;
        ((Control) metroLink12_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink13
    {
      get => this._MetroLink13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink13_Click);
        MetroLink metroLink13_1 = this._MetroLink13;
        if (metroLink13_1 != null)
          ((Control) metroLink13_1).Click -= eventHandler;
        this._MetroLink13 = value;
        MetroLink metroLink13_2 = this._MetroLink13;
        if (metroLink13_2 == null)
          return;
        ((Control) metroLink13_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink14
    {
      get => this._MetroLink14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink14_Click);
        MetroLink metroLink14_1 = this._MetroLink14;
        if (metroLink14_1 != null)
          ((Control) metroLink14_1).Click -= eventHandler;
        this._MetroLink14 = value;
        MetroLink metroLink14_2 = this._MetroLink14;
        if (metroLink14_2 == null)
          return;
        ((Control) metroLink14_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink15
    {
      get => this._MetroLink15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink15_Click);
        MetroLink metroLink15_1 = this._MetroLink15;
        if (metroLink15_1 != null)
          ((Control) metroLink15_1).Click -= eventHandler;
        this._MetroLink15 = value;
        MetroLink metroLink15_2 = this._MetroLink15;
        if (metroLink15_2 == null)
          return;
        ((Control) metroLink15_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink16
    {
      get => this._MetroLink16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink16_Click);
        MetroLink metroLink16_1 = this._MetroLink16;
        if (metroLink16_1 != null)
          ((Control) metroLink16_1).Click -= eventHandler;
        this._MetroLink16 = value;
        MetroLink metroLink16_2 = this._MetroLink16;
        if (metroLink16_2 == null)
          return;
        ((Control) metroLink16_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox12")]
    internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox13")]
    internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox14")]
    internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox15")]
    internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox16")]
    internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox17")]
    internal virtual PictureBox PictureBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink17
    {
      get => this._MetroLink17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink17_Click);
        MetroLink metroLink17_1 = this._MetroLink17;
        if (metroLink17_1 != null)
          ((Control) metroLink17_1).Click -= eventHandler;
        this._MetroLink17 = value;
        MetroLink metroLink17_2 = this._MetroLink17;
        if (metroLink17_2 == null)
          return;
        ((Control) metroLink17_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink18
    {
      get => this._MetroLink18;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink18_Click);
        MetroLink metroLink18_1 = this._MetroLink18;
        if (metroLink18_1 != null)
          ((Control) metroLink18_1).Click -= eventHandler;
        this._MetroLink18 = value;
        MetroLink metroLink18_2 = this._MetroLink18;
        if (metroLink18_2 == null)
          return;
        ((Control) metroLink18_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox18")]
    internal virtual PictureBox PictureBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox19")]
    internal virtual PictureBox PictureBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink19
    {
      get => this._MetroLink19;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink19_Click);
        MetroLink metroLink19_1 = this._MetroLink19;
        if (metroLink19_1 != null)
          ((Control) metroLink19_1).Click -= eventHandler;
        this._MetroLink19 = value;
        MetroLink metroLink19_2 = this._MetroLink19;
        if (metroLink19_2 == null)
          return;
        ((Control) metroLink19_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox20")]
    internal virtual PictureBox PictureBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink20
    {
      get => this._MetroLink20;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink20_Click);
        MetroLink metroLink20_1 = this._MetroLink20;
        if (metroLink20_1 != null)
          ((Control) metroLink20_1).Click -= eventHandler;
        this._MetroLink20 = value;
        MetroLink metroLink20_2 = this._MetroLink20;
        if (metroLink20_2 == null)
          return;
        ((Control) metroLink20_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox21")]
    internal virtual PictureBox PictureBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox22")]
    internal virtual PictureBox PictureBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox23")]
    internal virtual PictureBox PictureBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox24")]
    internal virtual PictureBox PictureBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink25
    {
      get => this._MetroLink25;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink25_Click);
        MetroLink metroLink25_1 = this._MetroLink25;
        if (metroLink25_1 != null)
          ((Control) metroLink25_1).Click -= eventHandler;
        this._MetroLink25 = value;
        MetroLink metroLink25_2 = this._MetroLink25;
        if (metroLink25_2 == null)
          return;
        ((Control) metroLink25_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink24
    {
      get => this._MetroLink24;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink24_Click);
        MetroLink metroLink24_1 = this._MetroLink24;
        if (metroLink24_1 != null)
          ((Control) metroLink24_1).Click -= eventHandler;
        this._MetroLink24 = value;
        MetroLink metroLink24_2 = this._MetroLink24;
        if (metroLink24_2 == null)
          return;
        ((Control) metroLink24_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink23
    {
      get => this._MetroLink23;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink23_Click);
        MetroLink metroLink23_1 = this._MetroLink23;
        if (metroLink23_1 != null)
          ((Control) metroLink23_1).Click -= eventHandler;
        this._MetroLink23 = value;
        MetroLink metroLink23_2 = this._MetroLink23;
        if (metroLink23_2 == null)
          return;
        ((Control) metroLink23_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink22
    {
      get => this._MetroLink22;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink22_Click);
        MetroLink metroLink22_1 = this._MetroLink22;
        if (metroLink22_1 != null)
          ((Control) metroLink22_1).Click -= eventHandler;
        this._MetroLink22 = value;
        MetroLink metroLink22_2 = this._MetroLink22;
        if (metroLink22_2 == null)
          return;
        ((Control) metroLink22_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink21
    {
      get => this._MetroLink21;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink21_Click);
        MetroLink metroLink21_1 = this._MetroLink21;
        if (metroLink21_1 != null)
          ((Control) metroLink21_1).Click -= eventHandler;
        this._MetroLink21 = value;
        MetroLink metroLink21_2 = this._MetroLink21;
        if (metroLink21_2 == null)
          return;
        ((Control) metroLink21_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox25")]
    internal virtual PictureBox PictureBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox26")]
    internal virtual PictureBox PictureBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink26
    {
      get => this._MetroLink26;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink26_Click);
        MetroLink metroLink26_1 = this._MetroLink26;
        if (metroLink26_1 != null)
          ((Control) metroLink26_1).Click -= eventHandler;
        this._MetroLink26 = value;
        MetroLink metroLink26_2 = this._MetroLink26;
        if (metroLink26_2 == null)
          return;
        ((Control) metroLink26_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink27
    {
      get => this._MetroLink27;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink27_Click);
        MetroLink metroLink27_1 = this._MetroLink27;
        if (metroLink27_1 != null)
          ((Control) metroLink27_1).Click -= eventHandler;
        this._MetroLink27 = value;
        MetroLink metroLink27_2 = this._MetroLink27;
        if (metroLink27_2 == null)
          return;
        ((Control) metroLink27_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink28
    {
      get => this._MetroLink28;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink28_Click);
        MetroLink metroLink28_1 = this._MetroLink28;
        if (metroLink28_1 != null)
          ((Control) metroLink28_1).Click -= eventHandler;
        this._MetroLink28 = value;
        MetroLink metroLink28_2 = this._MetroLink28;
        if (metroLink28_2 == null)
          return;
        ((Control) metroLink28_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink29
    {
      get => this._MetroLink29;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink29_Click);
        MetroLink metroLink29_1 = this._MetroLink29;
        if (metroLink29_1 != null)
          ((Control) metroLink29_1).Click -= eventHandler;
        this._MetroLink29 = value;
        MetroLink metroLink29_2 = this._MetroLink29;
        if (metroLink29_2 == null)
          return;
        ((Control) metroLink29_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink30
    {
      get => this._MetroLink30;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink30_Click);
        MetroLink metroLink30_1 = this._MetroLink30;
        if (metroLink30_1 != null)
          ((Control) metroLink30_1).Click -= eventHandler;
        this._MetroLink30 = value;
        MetroLink metroLink30_2 = this._MetroLink30;
        if (metroLink30_2 == null)
          return;
        ((Control) metroLink30_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox27")]
    internal virtual PictureBox PictureBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox28")]
    internal virtual PictureBox PictureBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox29")]
    internal virtual PictureBox PictureBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox30")]
    internal virtual PictureBox PictureBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox31")]
    internal virtual PictureBox PictureBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink31
    {
      get => this._MetroLink31;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink31_Click);
        MetroLink metroLink31_1 = this._MetroLink31;
        if (metroLink31_1 != null)
          ((Control) metroLink31_1).Click -= eventHandler;
        this._MetroLink31 = value;
        MetroLink metroLink31_2 = this._MetroLink31;
        if (metroLink31_2 == null)
          return;
        ((Control) metroLink31_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink32
    {
      get => this._MetroLink32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink32_Click);
        MetroLink metroLink32_1 = this._MetroLink32;
        if (metroLink32_1 != null)
          ((Control) metroLink32_1).Click -= eventHandler;
        this._MetroLink32 = value;
        MetroLink metroLink32_2 = this._MetroLink32;
        if (metroLink32_2 == null)
          return;
        ((Control) metroLink32_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink33
    {
      get => this._MetroLink33;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink33_Click);
        MetroLink metroLink33_1 = this._MetroLink33;
        if (metroLink33_1 != null)
          ((Control) metroLink33_1).Click -= eventHandler;
        this._MetroLink33 = value;
        MetroLink metroLink33_2 = this._MetroLink33;
        if (metroLink33_2 == null)
          return;
        ((Control) metroLink33_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink34
    {
      get => this._MetroLink34;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink34_Click);
        MetroLink metroLink34_1 = this._MetroLink34;
        if (metroLink34_1 != null)
          ((Control) metroLink34_1).Click -= eventHandler;
        this._MetroLink34 = value;
        MetroLink metroLink34_2 = this._MetroLink34;
        if (metroLink34_2 == null)
          return;
        ((Control) metroLink34_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink35
    {
      get => this._MetroLink35;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink35_Click);
        MetroLink metroLink35_1 = this._MetroLink35;
        if (metroLink35_1 != null)
          ((Control) metroLink35_1).Click -= eventHandler;
        this._MetroLink35 = value;
        MetroLink metroLink35_2 = this._MetroLink35;
        if (metroLink35_2 == null)
          return;
        ((Control) metroLink35_2).Click += eventHandler;
      }
    }

    internal virtual MetroLink MetroLink36
    {
      get => this._MetroLink36;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink36_Click);
        MetroLink metroLink36_1 = this._MetroLink36;
        if (metroLink36_1 != null)
          ((Control) metroLink36_1).Click -= eventHandler;
        this._MetroLink36 = value;
        MetroLink metroLink36_2 = this._MetroLink36;
        if (metroLink36_2 == null)
          return;
        ((Control) metroLink36_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox32")]
    internal virtual PictureBox PictureBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox33")]
    internal virtual PictureBox PictureBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox34")]
    internal virtual PictureBox PictureBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox35")]
    internal virtual PictureBox PictureBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox36")]
    internal virtual PictureBox PictureBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox37")]
    internal virtual PictureBox PictureBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroButton MetroButton3
    {
      get => this._MetroButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton3_Click);
        MetroButton metroButton3_1 = this._MetroButton3;
        if (metroButton3_1 != null)
          ((Control) metroButton3_1).Click -= eventHandler;
        this._MetroButton3 = value;
        MetroButton metroButton3_2 = this._MetroButton3;
        if (metroButton3_2 == null)
          return;
        ((Control) metroButton3_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton4
    {
      get => this._MetroButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton4_Click);
        MetroButton metroButton4_1 = this._MetroButton4;
        if (metroButton4_1 != null)
          ((Control) metroButton4_1).Click -= eventHandler;
        this._MetroButton4 = value;
        MetroButton metroButton4_2 = this._MetroButton4;
        if (metroButton4_2 == null)
          return;
        ((Control) metroButton4_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton2
    {
      get => this._MetroButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton2_Click);
        MetroButton metroButton2_1 = this._MetroButton2;
        if (metroButton2_1 != null)
          ((Control) metroButton2_1).Click -= eventHandler;
        this._MetroButton2 = value;
        MetroButton metroButton2_2 = this._MetroButton2;
        if (metroButton2_2 == null)
          return;
        ((Control) metroButton2_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton1
    {
      get => this._MetroButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton1_Click);
        MetroButton metroButton1_1 = this._MetroButton1;
        if (metroButton1_1 != null)
          ((Control) metroButton1_1).Click -= eventHandler;
        this._MetroButton1 = value;
        MetroButton metroButton1_2 = this._MetroButton1;
        if (metroButton1_2 == null)
          return;
        ((Control) metroButton1_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("MetroComboBox1")]
    internal virtual MetroComboBox MetroComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroButton MetroButton5
    {
      get => this._MetroButton5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton5_Click);
        MetroButton metroButton5_1 = this._MetroButton5;
        if (metroButton5_1 != null)
          ((Control) metroButton5_1).Click -= eventHandler;
        this._MetroButton5 = value;
        MetroButton metroButton5_2 = this._MetroButton5;
        if (metroButton5_2 == null)
          return;
        ((Control) metroButton5_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton11
    {
      get => this._MetroButton11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton11_Click);
        MetroButton metroButton11_1 = this._MetroButton11;
        if (metroButton11_1 != null)
          ((Control) metroButton11_1).Click -= eventHandler;
        this._MetroButton11 = value;
        MetroButton metroButton11_2 = this._MetroButton11;
        if (metroButton11_2 == null)
          return;
        ((Control) metroButton11_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton6
    {
      get => this._MetroButton6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton6_Click);
        MetroButton metroButton6_1 = this._MetroButton6;
        if (metroButton6_1 != null)
          ((Control) metroButton6_1).Click -= eventHandler;
        this._MetroButton6 = value;
        MetroButton metroButton6_2 = this._MetroButton6;
        if (metroButton6_2 == null)
          return;
        ((Control) metroButton6_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton7
    {
      get => this._MetroButton7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton7_Click);
        MetroButton metroButton7_1 = this._MetroButton7;
        if (metroButton7_1 != null)
          ((Control) metroButton7_1).Click -= eventHandler;
        this._MetroButton7 = value;
        MetroButton metroButton7_2 = this._MetroButton7;
        if (metroButton7_2 == null)
          return;
        ((Control) metroButton7_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton8
    {
      get => this._MetroButton8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton8_Click);
        MetroButton metroButton8_1 = this._MetroButton8;
        if (metroButton8_1 != null)
          ((Control) metroButton8_1).Click -= eventHandler;
        this._MetroButton8 = value;
        MetroButton metroButton8_2 = this._MetroButton8;
        if (metroButton8_2 == null)
          return;
        ((Control) metroButton8_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton9
    {
      get => this._MetroButton9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton9_Click);
        MetroButton metroButton9_1 = this._MetroButton9;
        if (metroButton9_1 != null)
          ((Control) metroButton9_1).Click -= eventHandler;
        this._MetroButton9 = value;
        MetroButton metroButton9_2 = this._MetroButton9;
        if (metroButton9_2 == null)
          return;
        ((Control) metroButton9_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton10
    {
      get => this._MetroButton10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton10_Click);
        MetroButton metroButton10_1 = this._MetroButton10;
        if (metroButton10_1 != null)
          ((Control) metroButton10_1).Click -= eventHandler;
        this._MetroButton10 = value;
        MetroButton metroButton10_2 = this._MetroButton10;
        if (metroButton10_2 == null)
          return;
        ((Control) metroButton10_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("MetroComboBox2")]
    internal virtual MetroComboBox MetroComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTextBox2")]
    internal virtual MetroTextBox MetroTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("MetroTextBox1")]
    internal virtual MetroTextBox MetroTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroButton MetroButton13
    {
      get => this._MetroButton13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton13_Click);
        MetroButton metroButton13_1 = this._MetroButton13;
        if (metroButton13_1 != null)
          ((Control) metroButton13_1).Click -= eventHandler;
        this._MetroButton13 = value;
        MetroButton metroButton13_2 = this._MetroButton13;
        if (metroButton13_2 == null)
          return;
        ((Control) metroButton13_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton12
    {
      get => this._MetroButton12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton12_Click);
        MetroButton metroButton12_1 = this._MetroButton12;
        if (metroButton12_1 != null)
          ((Control) metroButton12_1).Click -= eventHandler;
        this._MetroButton12 = value;
        MetroButton metroButton12_2 = this._MetroButton12;
        if (metroButton12_2 == null)
          return;
        ((Control) metroButton12_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox38")]
    internal virtual PictureBox PictureBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroButton MetroButton14
    {
      get => this._MetroButton14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton14_Click);
        MetroButton metroButton14_1 = this._MetroButton14;
        if (metroButton14_1 != null)
          ((Control) metroButton14_1).Click -= eventHandler;
        this._MetroButton14 = value;
        MetroButton metroButton14_2 = this._MetroButton14;
        if (metroButton14_2 == null)
          return;
        ((Control) metroButton14_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton15
    {
      get => this._MetroButton15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton15_Click);
        MetroButton metroButton15_1 = this._MetroButton15;
        if (metroButton15_1 != null)
          ((Control) metroButton15_1).Click -= eventHandler;
        this._MetroButton15 = value;
        MetroButton metroButton15_2 = this._MetroButton15;
        if (metroButton15_2 == null)
          return;
        ((Control) metroButton15_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton16
    {
      get => this._MetroButton16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton16_Click);
        MetroButton metroButton16_1 = this._MetroButton16;
        if (metroButton16_1 != null)
          ((Control) metroButton16_1).Click -= eventHandler;
        this._MetroButton16 = value;
        MetroButton metroButton16_2 = this._MetroButton16;
        if (metroButton16_2 == null)
          return;
        ((Control) metroButton16_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton17
    {
      get => this._MetroButton17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton17_Click);
        MetroButton metroButton17_1 = this._MetroButton17;
        if (metroButton17_1 != null)
          ((Control) metroButton17_1).Click -= eventHandler;
        this._MetroButton17 = value;
        MetroButton metroButton17_2 = this._MetroButton17;
        if (metroButton17_2 == null)
          return;
        ((Control) metroButton17_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton18
    {
      get => this._MetroButton18;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton18_Click);
        MetroButton metroButton18_1 = this._MetroButton18;
        if (metroButton18_1 != null)
          ((Control) metroButton18_1).Click -= eventHandler;
        this._MetroButton18 = value;
        MetroButton metroButton18_2 = this._MetroButton18;
        if (metroButton18_2 == null)
          return;
        ((Control) metroButton18_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton19
    {
      get => this._MetroButton19;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton19_Click);
        MetroButton metroButton19_1 = this._MetroButton19;
        if (metroButton19_1 != null)
          ((Control) metroButton19_1).Click -= eventHandler;
        this._MetroButton19 = value;
        MetroButton metroButton19_2 = this._MetroButton19;
        if (metroButton19_2 == null)
          return;
        ((Control) metroButton19_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton21
    {
      get => this._MetroButton21;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton21_Click);
        MetroButton metroButton21_1 = this._MetroButton21;
        if (metroButton21_1 != null)
          ((Control) metroButton21_1).Click -= eventHandler;
        this._MetroButton21 = value;
        MetroButton metroButton21_2 = this._MetroButton21;
        if (metroButton21_2 == null)
          return;
        ((Control) metroButton21_2).Click += eventHandler;
      }
    }

    internal virtual MetroButton MetroButton20
    {
      get => this._MetroButton20;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroButton20_Click);
        MetroButton metroButton20_1 = this._MetroButton20;
        if (metroButton20_1 != null)
          ((Control) metroButton20_1).Click -= eventHandler;
        this._MetroButton20 = value;
        MetroButton metroButton20_2 = this._MetroButton20;
        if (metroButton20_2 == null)
          return;
        ((Control) metroButton20_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox39")]
    internal virtual PictureBox PictureBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MetroLink MetroLink37
    {
      get => this._MetroLink37;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroLink37_Click);
        MetroLink metroLink37_1 = this._MetroLink37;
        if (metroLink37_1 != null)
          ((Control) metroLink37_1).Click -= eventHandler;
        this._MetroLink37 = value;
        MetroLink metroLink37_2 = this._MetroLink37;
        if (metroLink37_2 == null)
          return;
        ((Control) metroLink37_2).Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
