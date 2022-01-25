// Decompiled with JetBrains decompiler
// Type: SHREDDER_AIO_TOOL.UserControl4
// Assembly: OASIS AIO TOOL, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5CDD5355-9DF5-4ADD-83F8-00F1021EE824
// Assembly location: C:\Users\op\Downloads\B7BSH\OASIS AIO TOOL_4.3_dump-cleaned.exe

using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace SHREDDER_AIO_TOOL
{
  public class UserControl4 : UserControl
  {
    private string string_0;
    private IContainer icontainer_0;
    private Label label1;
    private SiticoneButton siticoneButton6;
    private SiticoneButton siticoneButton1;
    private SiticoneButton siticoneButton2;
    private static UserControl4 Vtp1cBCC17jk0e3f39G;

    public UserControl4()
    {
      Class2.V1XjF0uzuv5J3();
      this.string_0 = string.Empty;
      this.icontainer_0 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void UserControl4_Load(object sender, EventArgs e)
    {
    }

    private void siticoneButton6_Click(object sender, EventArgs e)
    {
      using (WebClient webClient = new WebClient())
        this.string_0 = webClient.DownloadString("https://textbin.net/raw/CjdGDRaNxe");
      Process.Start(this.string_0);
    }

    private void vbtaahWhss(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UCaIEI-CP11v6ywFqYK2J20A");

    private void siticoneButton1_MouseClick(object sender, MouseEventArgs e) => new SoundPlayer("C:\\Windows\\Web\\Wallpaper\\click.wav").Play();

    private void siticoneButton2_Click(object sender, EventArgs e) => Process.Start("https://t.me/RealOasis");

    protected override void Dispose(bool disposing)
    {
      if ((disposing ? (this.icontainer_0 != null ? 1 : 0) : 0) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControl4));
      this.label1 = new Label();
      this.siticoneButton6 = new SiticoneButton();
      this.siticoneButton1 = new SiticoneButton();
      this.siticoneButton2 = new SiticoneButton();
      this.SuspendLayout();
      this.label1.Font = new Font("Georgia", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(3, 198, 253);
      this.label1.Location = new Point(198, 27);
      this.label1.Name = "label1";
      this.label1.Size = new Size(422, 46);
      this.label1.TabIndex = 11;
      this.label1.Text = "JOIN OUR OFFICIAL SERVER";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.siticoneButton6.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.BorderRadius = 1;
      this.siticoneButton6.BorderThickness = 1;
      this.siticoneButton6.CheckedState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.CustomImages.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.FillColor = Color.Transparent;
      this.siticoneButton6.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.ForeColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.FillColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton6.HoveredState.Font = new Font("Georgia", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.siticoneButton6.HoveredState.ForeColor = Color.White;
      this.siticoneButton6.HoveredState.Parent = (CustomButtonBase) this.siticoneButton6;
      this.siticoneButton6.Image = (Image) componentResourceManager.GetObject("siticoneButton6.Image");
      this.siticoneButton6.ImageSize = new Size(50, 50);
      this.siticoneButton6.Location = new Point(110, 110);
      this.siticoneButton6.Name = "siticoneButton6";
      this.siticoneButton6.ShadowDecoration.Parent = (Control) this.siticoneButton6;
      this.siticoneButton6.Size = new Size(248, 64);
      this.siticoneButton6.TabIndex = 18;
      this.siticoneButton6.Text = "DISCORD";
      this.siticoneButton6.Click += new EventHandler(this.siticoneButton6_Click);
      this.siticoneButton6.MouseClick += new MouseEventHandler(this.siticoneButton1_MouseClick);
      this.siticoneButton1.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton1.BorderRadius = 1;
      this.siticoneButton1.BorderThickness = 1;
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
      this.siticoneButton1.ImageSize = new Size(60, 60);
      this.siticoneButton1.Location = new Point(434, 110);
      this.siticoneButton1.Name = "siticoneButton1";
      this.siticoneButton1.ShadowDecoration.Parent = (Control) this.siticoneButton1;
      this.siticoneButton1.Size = new Size(275, 64);
      this.siticoneButton1.TabIndex = 19;
      this.siticoneButton1.Text = "YOUTUBE";
      this.siticoneButton1.Click += new EventHandler(this.vbtaahWhss);
      this.siticoneButton1.MouseClick += new MouseEventHandler(this.siticoneButton1_MouseClick);
      this.siticoneButton2.BorderColor = Color.FromArgb(16, 167, 254);
      this.siticoneButton2.BorderRadius = 1;
      this.siticoneButton2.BorderThickness = 1;
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
      this.siticoneButton2.ImageSize = new Size(50, 50);
      this.siticoneButton2.Location = new Point(270, 207);
      this.siticoneButton2.Name = "siticoneButton2";
      this.siticoneButton2.ShadowDecoration.Parent = (Control) this.siticoneButton2;
      this.siticoneButton2.Size = new Size(248, 64);
      this.siticoneButton2.TabIndex = 20;
      this.siticoneButton2.Text = "TELEGRAM";
      this.siticoneButton2.Click += new EventHandler(this.siticoneButton2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.siticoneButton2);
      this.Controls.Add((Control) this.siticoneButton1);
      this.Controls.Add((Control) this.siticoneButton6);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (UserControl4);
      this.Size = new Size(836, 299);
      this.Load += new EventHandler(this.UserControl4_Load);
      this.ResumeLayout(false);
    }

    internal static void BDbP2kCsvdvJxiqqcFS()
    {
    }

    internal static bool DuGJJAC6iSuGuW8lJEZ() => UserControl4.Vtp1cBCC17jk0e3f39G == null;
  }
}
