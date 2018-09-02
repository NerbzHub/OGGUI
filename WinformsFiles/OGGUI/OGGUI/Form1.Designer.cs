namespace OGGUI
{
    partial class OGGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fetch = new System.Windows.Forms.Button();
            this.Pull = new System.Windows.Forms.Button();
            this.Commit = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.runTerminal = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Fetch
            // 
            this.Fetch.Location = new System.Drawing.Point(97, 12);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 0;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = true;
            this.Fetch.Click += new System.EventHandler(this.Fetch_Click);
            // 
            // Pull
            // 
            this.Pull.Location = new System.Drawing.Point(178, 12);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(75, 23);
            this.Pull.TabIndex = 1;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = true;
            this.Pull.Click += new System.EventHandler(this.Pull_Click);
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(259, 12);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 23);
            this.Commit.TabIndex = 2;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(340, 12);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 3;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // runTerminal
            // 
            this.runTerminal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runTerminal_DoWork);
            // 
            // OGGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 414);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Pull);
            this.Controls.Add(this.Fetch);
            this.Name = "OGGUI";
            this.Text = "OG GUI";
            this.Load += new System.EventHandler(this.OGGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fetch;
        private System.Windows.Forms.Button Pull;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Push;
        private System.ComponentModel.BackgroundWorker runTerminal;
    }
}

