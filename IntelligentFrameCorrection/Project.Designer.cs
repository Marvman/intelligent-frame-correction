namespace IntelligentFrameCorrection
{
    partial class Project
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabelOnlineDocumentation = new System.Windows.Forms.LinkLabel();
            this.labelOnlineDocumentation = new MediaPortal.UserInterface.Controls.MPLabel();
            this.linkLabelHomepage = new System.Windows.Forms.LinkLabel();
            this.labelHomepage = new MediaPortal.UserInterface.Controls.MPLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(341, 39);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Intelligent Frame Correction is a frame correction plugin for MediaPortal,\r\nthat " +
    "provide automatically the best possible aspect ratio and letterbox \r\ncorrection." +
    "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Location = new System.Drawing.Point(338, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 100);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabelOnlineDocumentation);
            this.groupBox2.Controls.Add(this.labelOnlineDocumentation);
            this.groupBox2.Controls.Add(this.linkLabelHomepage);
            this.groupBox2.Controls.Add(this.labelHomepage);
            this.groupBox2.Location = new System.Drawing.Point(338, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 144);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            // 
            // linkLabelOnlineDocumentation
            // 
            this.linkLabelOnlineDocumentation.AutoSize = true;
            this.linkLabelOnlineDocumentation.Location = new System.Drawing.Point(14, 99);
            this.linkLabelOnlineDocumentation.Name = "linkLabelOnlineDocumentation";
            this.linkLabelOnlineDocumentation.Size = new System.Drawing.Size(260, 26);
            this.linkLabelOnlineDocumentation.TabIndex = 7;
            this.linkLabelOnlineDocumentation.TabStop = true;
            this.linkLabelOnlineDocumentation.Text = "http://wiki.team-mediaportal.com/Extensions-Plugins/\r\nIntelligentFrameCorrection";
            this.linkLabelOnlineDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOnlineDocumentation_LinkClicked);
            // 
            // labelOnlineDocumentation
            // 
            this.labelOnlineDocumentation.AutoSize = true;
            this.labelOnlineDocumentation.Location = new System.Drawing.Point(6, 84);
            this.labelOnlineDocumentation.Name = "labelOnlineDocumentation";
            this.labelOnlineDocumentation.Size = new System.Drawing.Size(115, 13);
            this.labelOnlineDocumentation.TabIndex = 6;
            this.labelOnlineDocumentation.Text = "Online Documentation:";
            // 
            // linkLabelHomepage
            // 
            this.linkLabelHomepage.AutoSize = true;
            this.linkLabelHomepage.Location = new System.Drawing.Point(14, 37);
            this.linkLabelHomepage.Name = "linkLabelHomepage";
            this.linkLabelHomepage.Size = new System.Drawing.Size(176, 26);
            this.linkLabelHomepage.TabIndex = 3;
            this.linkLabelHomepage.TabStop = true;
            this.linkLabelHomepage.Text = "http://forum.team-mediaportal.com/\r\ni-f-c-intelligent-frame-correction-512/";
            this.linkLabelHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHomepage_LinkClicked);
            // 
            // labelHomepage
            // 
            this.labelHomepage.AutoSize = true;
            this.labelHomepage.Location = new System.Drawing.Point(6, 21);
            this.labelHomepage.Name = "labelHomepage";
            this.labelHomepage.Size = new System.Drawing.Size(39, 13);
            this.labelHomepage.TabIndex = 2;
            this.labelHomepage.Text = "Forum:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(338, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 63);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version: 2.0.4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Special thanks to Dread Fury a.k.a. Bill";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IntelligentFrameCorrection.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Project";
            this.Size = new System.Drawing.Size(720, 370);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabelHomepage;
        private MediaPortal.UserInterface.Controls.MPLabel labelHomepage;
        private System.Windows.Forms.LinkLabel linkLabelOnlineDocumentation;
        private MediaPortal.UserInterface.Controls.MPLabel labelOnlineDocumentation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
