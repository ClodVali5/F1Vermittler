namespace F1Vermittler
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.btStartMonitor = new System.Windows.Forms.Button();
            this.rtfLog = new System.Windows.Forms.RichTextBox();
            this.tfApplicationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tfClassname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTool = new System.Windows.Forms.Button();
            this.cbSimulation = new System.Windows.Forms.CheckBox();
            this.btSendWord = new System.Windows.Forms.Button();
            this.picDataReceived = new System.Windows.Forms.PictureBox();
            this.lb_DataReceived = new System.Windows.Forms.Label();
            this.lb_ComOpen = new System.Windows.Forms.Label();
            this.picComOpen = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDataReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // btStartMonitor
            // 
            this.btStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btStartMonitor.FlatAppearance.BorderSize = 0;
            this.btStartMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartMonitor.ForeColor = System.Drawing.Color.White;
            this.btStartMonitor.Location = new System.Drawing.Point(127, 235);
            this.btStartMonitor.Name = "btStartMonitor";
            this.btStartMonitor.Size = new System.Drawing.Size(454, 56);
            this.btStartMonitor.TabIndex = 0;
            this.btStartMonitor.Text = "Starten der Überwachung";
            this.btStartMonitor.UseVisualStyleBackColor = false;
            this.btStartMonitor.Click += new System.EventHandler(this.btStartMonitor_Click);
            // 
            // rtfLog
            // 
            this.rtfLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfLog.Location = new System.Drawing.Point(12, 67);
            this.rtfLog.Name = "rtfLog";
            this.rtfLog.Size = new System.Drawing.Size(569, 137);
            this.rtfLog.TabIndex = 1;
            this.rtfLog.Text = "";
            // 
            // tfApplicationName
            // 
            this.tfApplicationName.Location = new System.Drawing.Point(12, 41);
            this.tfApplicationName.Name = "tfApplicationName";
            this.tfApplicationName.Size = new System.Drawing.Size(300, 20);
            this.tfApplicationName.TabIndex = 2;
            this.tfApplicationName.Text = "Rechner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Applikationsname";
            // 
            // tfClassname
            // 
            this.tfClassname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tfClassname.Location = new System.Drawing.Point(318, 41);
            this.tfClassname.Name = "tfClassname";
            this.tfClassname.Size = new System.Drawing.Size(263, 20);
            this.tfClassname.TabIndex = 4;
            this.tfClassname.Text = "CalcFrame";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Klassenname";
            // 
            // btTool
            // 
            this.btTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTool.BackColor = System.Drawing.Color.Teal;
            this.btTool.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btTool.FlatAppearance.BorderSize = 0;
            this.btTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTool.ForeColor = System.Drawing.Color.White;
            this.btTool.Location = new System.Drawing.Point(12, 235);
            this.btTool.Name = "btTool";
            this.btTool.Size = new System.Drawing.Size(109, 56);
            this.btTool.TabIndex = 6;
            this.btTool.Text = "Spy++";
            this.btTool.UseVisualStyleBackColor = false;
            this.btTool.Click += new System.EventHandler(this.btTool_Click);
            // 
            // cbSimulation
            // 
            this.cbSimulation.AutoSize = true;
            this.cbSimulation.Location = new System.Drawing.Point(12, 210);
            this.cbSimulation.Name = "cbSimulation";
            this.cbSimulation.Size = new System.Drawing.Size(172, 17);
            this.cbSimulation.TabIndex = 7;
            this.cbSimulation.Text = "Nur Simulation der Schnittstelle";
            this.cbSimulation.UseVisualStyleBackColor = true;
            // 
            // btSendWord
            // 
            this.btSendWord.Location = new System.Drawing.Point(483, 206);
            this.btSendWord.Name = "btSendWord";
            this.btSendWord.Size = new System.Drawing.Size(75, 23);
            this.btSendWord.TabIndex = 8;
            this.btSendWord.Text = "send";
            this.btSendWord.UseVisualStyleBackColor = true;
            this.btSendWord.Visible = false;
            this.btSendWord.Click += new System.EventHandler(this.btSendWord_Click);
            // 
            // picDataReceived
            // 
            this.picDataReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDataReceived.Location = new System.Drawing.Point(456, 210);
            this.picDataReceived.Name = "picDataReceived";
            this.picDataReceived.Size = new System.Drawing.Size(21, 19);
            this.picDataReceived.TabIndex = 9;
            this.picDataReceived.TabStop = false;
            // 
            // lb_DataReceived
            // 
            this.lb_DataReceived.AutoSize = true;
            this.lb_DataReceived.Location = new System.Drawing.Point(376, 211);
            this.lb_DataReceived.Name = "lb_DataReceived";
            this.lb_DataReceived.Size = new System.Drawing.Size(74, 13);
            this.lb_DataReceived.TabIndex = 10;
            this.lb_DataReceived.Text = "dataReceived";
            // 
            // lb_ComOpen
            // 
            this.lb_ComOpen.AutoSize = true;
            this.lb_ComOpen.Location = new System.Drawing.Point(265, 211);
            this.lb_ComOpen.Name = "lb_ComOpen";
            this.lb_ComOpen.Size = new System.Drawing.Size(73, 13);
            this.lb_ComOpen.TabIndex = 12;
            this.lb_ComOpen.Text = "COM geöffnet";
            // 
            // picComOpen
            // 
            this.picComOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picComOpen.Location = new System.Drawing.Point(345, 210);
            this.picComOpen.Name = "picComOpen";
            this.picComOpen.Size = new System.Drawing.Size(21, 19);
            this.picComOpen.TabIndex = 11;
            this.picComOpen.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 299);
            this.Controls.Add(this.lb_ComOpen);
            this.Controls.Add(this.picComOpen);
            this.Controls.Add(this.lb_DataReceived);
            this.Controls.Add(this.picDataReceived);
            this.Controls.Add(this.btSendWord);
            this.Controls.Add(this.cbSimulation);
            this.Controls.Add(this.btTool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfClassname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfApplicationName);
            this.Controls.Add(this.rtfLog);
            this.Controls.Add(this.btStartMonitor);
            this.Name = "Start";
            this.Text = "F1 Vermittler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDataReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStartMonitor;
        private System.Windows.Forms.RichTextBox rtfLog;
        private System.Windows.Forms.TextBox tfApplicationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfClassname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTool;
        private System.Windows.Forms.CheckBox cbSimulation;
        private System.Windows.Forms.Button btSendWord;
        private System.Windows.Forms.PictureBox picDataReceived;
        private System.Windows.Forms.Label lb_DataReceived;
        private System.Windows.Forms.Label lb_ComOpen;
        private System.Windows.Forms.PictureBox picComOpen;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
    }
}

