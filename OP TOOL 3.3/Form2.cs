// Decompiled with JetBrains decompiler
// Type: TOOL.Form2
// Assembly: TOOL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB4B0A50-BB68-477B-ACEC-619EB8F5F2A1
// Assembly location: C:\Users\op\Desktop\OP TOOL 3.3_dump_dotkill-Cleaned-cleaned.exe

using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TOOL.My;

namespace TOOL
{
  [DesignerGenerated]
  public class Form2 : MetroForm
  {
    private IContainer components;
    private WebClient web;

    public Form2()
    {
      ((Form) this).Load += new EventHandler(this.Form2_Load);
      this.web = new WebClient();
      this.InitializeComponent();
    }

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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.MetroLabel1 = new MetroLabel();
      ((Control) this).SuspendLayout();
      ((Label) this.MetroLabel1).AutoSize = true;
      ((Control) this.MetroLabel1).Location = new Point(49, 86);
      ((Control) this.MetroLabel1).Name = "MetroLabel1";
      ((Control) this.MetroLabel1).Size = new Size(0, 0);
      ((Control) this.MetroLabel1).TabIndex = 0;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Form) this).ClientSize = new Size(213, 68);
      ((Control) this).Controls.Add((Control) this.MetroLabel1);
      ((Form) this).Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      ((Form) this).MaximizeBox = false;
      ((Form) this).MinimizeBox = false;
      ((Control) this).Name = nameof (Form2);
      this.Resizable = false;
      ((Form) this).Text = "Check Update ..";
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    internal virtual System.Windows.Forms.Timer Timer1
    {
      get => this._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        System.Windows.Forms.Timer timer1_1 = this._Timer1;
        if (timer1_1 != null)
          timer1_1.Tick -= eventHandler;
        this._Timer1 = value;
        System.Windows.Forms.Timer timer1_2 = this._Timer1;
        if (timer1_2 == null)
          return;
        timer1_2.Tick += eventHandler;
      }
    }

    [field: AccessedThroughProperty("MetroLabel1")]
    internal virtual MetroLabel MetroLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Form2_Load(object sender, EventArgs e) => this.Timer1.Start();

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private void Timer1_Tick(object sender, EventArgs e)
    {
      ((Label) this.MetroLabel1).Text = this.web.DownloadString("https://dl.dropbox.com/s/p3gehiko9sygzny/OP%20Tool.txt?dl=0");
      if (Operators.CompareString(((Label) this.MetroLabel1).Text, "3.3", false) == 0)
      {
        this.Timer1.Stop();
        ((Control) MyProject.Forms.Form1).Show();
        ((Control) this).Hide();
      }
      else
      {
        this.Timer1.Stop();
        int num = (int) Interaction.MsgBox((object) "There is a new update");
        Process.Start("https://mega.nz/folder/bFkFjKJI#OtSCKzFaO-II7qOXsILM4A");
        ProjectData.EndApp();
      }
    }
  }
}
