namespace Dsys
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelCLRVersion;
        private System.Windows.Forms.Label labelSystemDirectory;
        private System.Windows.Forms.Label labelProcessorCount;
        private System.Windows.Forms.Label label64BitOS;
        private System.Windows.Forms.Label label64BitProcess;
        private System.Windows.Forms.TextBox textBoxOS;
        private System.Windows.Forms.TextBox textBoxMachineName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxCLRVersion;
        private System.Windows.Forms.TextBox textBoxSystemDirectory;
        private System.Windows.Forms.TextBox textBoxProcessorCount;
        private System.Windows.Forms.TextBox textBox64BitOS;
        private System.Windows.Forms.TextBox textBox64BitProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelOS = new System.Windows.Forms.Label();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelCLRVersion = new System.Windows.Forms.Label();
            this.labelSystemDirectory = new System.Windows.Forms.Label();
            this.labelProcessorCount = new System.Windows.Forms.Label();
            this.label64BitOS = new System.Windows.Forms.Label();
            this.label64BitProcess = new System.Windows.Forms.Label();
            this.textBoxOS = new System.Windows.Forms.TextBox();
            this.textBoxMachineName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxCLRVersion = new System.Windows.Forms.TextBox();
            this.textBoxSystemDirectory = new System.Windows.Forms.TextBox();
            this.textBoxProcessorCount = new System.Windows.Forms.TextBox();
            this.textBox64BitOS = new System.Windows.Forms.TextBox();
            this.textBox64BitProcess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(20, 20);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(93, 13);
            this.labelOS.TabIndex = 0;
            this.labelOS.Text = "Operating System:";
            // 
            // labelMachineName
            // 
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.Location = new System.Drawing.Point(20, 50);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(82, 13);
            this.labelMachineName.TabIndex = 1;
            this.labelMachineName.Text = "Machine Name:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(20, 80);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name:";
            // 
            // labelCLRVersion
            // 
            this.labelCLRVersion.AutoSize = true;
            this.labelCLRVersion.Location = new System.Drawing.Point(20, 110);
            this.labelCLRVersion.Name = "labelCLRVersion";
            this.labelCLRVersion.Size = new System.Drawing.Size(69, 13);
            this.labelCLRVersion.TabIndex = 3;
            this.labelCLRVersion.Text = "CLR Version:";
            // 
            // labelSystemDirectory
            // 
            this.labelSystemDirectory.AutoSize = true;
            this.labelSystemDirectory.Location = new System.Drawing.Point(20, 140);
            this.labelSystemDirectory.Name = "labelSystemDirectory";
            this.labelSystemDirectory.Size = new System.Drawing.Size(89, 13);
            this.labelSystemDirectory.TabIndex = 4;
            this.labelSystemDirectory.Text = "System Directory:";
            // 
            // labelProcessorCount
            // 
            this.labelProcessorCount.AutoSize = true;
            this.labelProcessorCount.Location = new System.Drawing.Point(20, 170);
            this.labelProcessorCount.Name = "labelProcessorCount";
            this.labelProcessorCount.Size = new System.Drawing.Size(88, 13);
            this.labelProcessorCount.TabIndex = 5;
            this.labelProcessorCount.Text = "Processor Count:";
            // 
            // label64BitOS
            // 
            this.label64BitOS.AutoSize = true;
            this.label64BitOS.Location = new System.Drawing.Point(20, 200);
            this.label64BitOS.Name = "label64BitOS";
            this.label64BitOS.Size = new System.Drawing.Size(54, 13);
            this.label64BitOS.TabIndex = 6;
            this.label64BitOS.Text = "64-bit OS:";
            // 
            // label64BitProcess
            // 
            this.label64BitProcess.AutoSize = true;
            this.label64BitProcess.Location = new System.Drawing.Point(20, 230);
            this.label64BitProcess.Name = "label64BitProcess";
            this.label64BitProcess.Size = new System.Drawing.Size(77, 13);
            this.label64BitProcess.TabIndex = 7;
            this.label64BitProcess.Text = "64-bit Process:";
            // 
            // textBoxOS
            // 
            this.textBoxOS.Location = new System.Drawing.Point(150, 20);
            this.textBoxOS.Name = "textBoxOS";
            this.textBoxOS.ReadOnly = true;
            this.textBoxOS.Size = new System.Drawing.Size(300, 20);
            this.textBoxOS.TabIndex = 8;
            // 
            // textBoxMachineName
            // 
            this.textBoxMachineName.Location = new System.Drawing.Point(150, 50);
            this.textBoxMachineName.Name = "textBoxMachineName";
            this.textBoxMachineName.ReadOnly = true;
            this.textBoxMachineName.Size = new System.Drawing.Size(300, 20);
            this.textBoxMachineName.TabIndex = 9;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(150, 80);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(300, 20);
            this.textBoxUserName.TabIndex = 10;
            // 
            // textBoxCLRVersion
            // 
            this.textBoxCLRVersion.Location = new System.Drawing.Point(150, 110);
            this.textBoxCLRVersion.Name = "textBoxCLRVersion";
            this.textBoxCLRVersion.ReadOnly = true;
            this.textBoxCLRVersion.Size = new System.Drawing.Size(300, 20);
            this.textBoxCLRVersion.TabIndex = 11;
            // 
            // textBoxSystemDirectory
            // 
            this.textBoxSystemDirectory.Location = new System.Drawing.Point(150, 140);
            this.textBoxSystemDirectory.Name = "textBoxSystemDirectory";
            this.textBoxSystemDirectory.ReadOnly = true;
            this.textBoxSystemDirectory.Size = new System.Drawing.Size(300, 20);
            this.textBoxSystemDirectory.TabIndex = 12;
            // 
            // textBoxProcessorCount
            // 
            this.textBoxProcessorCount.Location = new System.Drawing.Point(150, 170);
            this.textBoxProcessorCount.Name = "textBoxProcessorCount";
            this.textBoxProcessorCount.ReadOnly = true;
            this.textBoxProcessorCount.Size = new System.Drawing.Size(300, 20);
            this.textBoxProcessorCount.TabIndex = 13;
            // 
            // textBox64BitOS
            // 
            this.textBox64BitOS.Location = new System.Drawing.Point(150, 200);
            this.textBox64BitOS.Name = "textBox64BitOS";
            this.textBox64BitOS.ReadOnly = true;
            this.textBox64BitOS.Size = new System.Drawing.Size(300, 20);
            this.textBox64BitOS.TabIndex = 14;
            // 
            // textBox64BitProcess
            // 
            this.textBox64BitProcess.Location = new System.Drawing.Point(150, 230);
            this.textBox64BitProcess.Name = "textBox64BitProcess";
            this.textBox64BitProcess.ReadOnly = true;
            this.textBox64BitProcess.Size = new System.Drawing.Size(300, 20);
            this.textBox64BitProcess.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "© 2024 D.tech. All rights reserved.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox64BitProcess);
            this.Controls.Add(this.textBox64BitOS);
            this.Controls.Add(this.textBoxProcessorCount);
            this.Controls.Add(this.textBoxSystemDirectory);
            this.Controls.Add(this.textBoxCLRVersion);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxMachineName);
            this.Controls.Add(this.textBoxOS);
            this.Controls.Add(this.label64BitProcess);
            this.Controls.Add(this.label64BitOS);
            this.Controls.Add(this.labelProcessorCount);
            this.Controls.Add(this.labelSystemDirectory);
            this.Controls.Add(this.labelCLRVersion);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelMachineName);
            this.Controls.Add(this.labelOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "System Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
