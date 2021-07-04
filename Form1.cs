using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaarDevRPC;

namespace DaarDev
{
    public partial class DaarDev : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public DaarDev()
        {
            InitializeComponent();
        }
        private const string epicfnpath = "com.epicgames.launcher://apps/Fortnite?action=";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var Proc = new ProcessStartInfo();
            Proc.CreateNoWindow = true;
            Proc.FileName = "cmd.exe";
            Proc.Arguments = "/C start node .";
            Process.Start(Proc);
            Process.Start($"{epicfnpath}launch");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("861250637899628584", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("861250637899628584", ref this.handlers, true, null);
            this.presence.details = "Using DaarDev";
            this.presence.state = "https://dsc.gg/daarg";
            this.presence.largeImageKey = "daardev";
            this.presence.smallImageKey = "daardev";
            this.presence.largeImageText = "Daar Dev";
            this.presence.smallImageText = "V0.1 By daar#3312";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var Proc = new ProcessStartInfo();
            Proc.CreateNoWindow = true;
            Proc.FileName = "cmd.exe";
            Proc.Arguments = "/C start node .";
            Process.Start(Proc);
            Process.Start($"{epicfnpath}launch");
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://dsc.gg/daarg");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            misc misc = new misc();
            misc.Show();
            this.Hide();
        }
    }
}
