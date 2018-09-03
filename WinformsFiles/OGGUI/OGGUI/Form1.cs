using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace OGGUI
{
    public partial class OGGUI : Form
    {

        public OGGUI()
        {
            InitializeComponent();
            InitCMD();
        }

        private void runTerminal_DoWork(object sender, DoWorkEventArgs e)
        {
            //System.Console.Write("where cmd.exe");
            //System.Console.Write("start cmd.exe");
        }


        private void InitCMD()
        {
            System.Console.Write("where cmd.exe");
            System.Console.Write("start cmd.exe");
        }

        private void OGGUI_Load(object sender, EventArgs e)
        {

        }

        // Occurs when fetch is clisked.
        private void Fetch_Click(object sender, EventArgs e)
        {
            System.Console.Write("git fetch");
        }

        // Occurs when pull is clicked.
        private void Pull_Click(object sender, EventArgs e)
        {
            System.Console.Write("git pull");

        }

        // Occurs when commit is clicked.
        private void Commit_Click(object sender, EventArgs e)
        {
            // Not set up yet due to needing to use more functionality than just a one line
            // command.
            //System.Console.Write("git commit -m");
        }

        // Occurs when push is clicked.
        private void Push_Click(object sender, EventArgs e)
        {
            System.Console.Write("git push");
        }

        private void GoToRepo_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("cd /c/Users/s171735/Documents/OGGUI");
        }
    }
}

// This article may help me for what I am looking at doing but I am out of time.
// https://stackoverflow.com/questions/4107683/controlling-cmd-exe-from-winforms