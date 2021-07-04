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
    public partial class misc : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public misc()
        {
            InitializeComponent();
        }

        private void misc_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("861250637899628584", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("861250637899628584", ref this.handlers, true, null);
            this.presence.details = "Using DaarDev Misc";
            this.presence.state = "https;//dsc.gg/daarg";
            this.presence.largeImageKey = "daardev";
            this.presence.smallImageKey = "daardev";
            this.presence.largeImageText = "Daar Dev";
            this.presence.smallImageText = "V0.1 By daar#3318";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private const string epicfnpath = "com.epicgames.launcher://apps/Fortnite?action=";
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start($"{epicfnpath}launch");
            var Proc = new ProcessStartInfo();
            Proc.CreateNoWindow = true;
            Proc.FileName = "cmd.exe";
            Proc.Arguments = "/C node .";
            Process.Start(Proc);
            System.Windows.Forms.MessageBox.Show("Press Ok When Your At Select GameMode");
            Process.Start("DaarDevInjector.exe");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
