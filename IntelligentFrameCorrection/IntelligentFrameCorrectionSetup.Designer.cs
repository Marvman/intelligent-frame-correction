namespace IntelligentFrameCorrection
{
    partial class IntelligentFrameCorrectionSetup
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Project");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TV/Recodings");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Video");
            this.sectionView = new System.Windows.Forms.TreeView();
            this.holderPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new MediaPortal.UserInterface.Controls.MPGradientLabel();
            this.beveledLine1 = new MediaPortal.UserInterface.Controls.MPBeveledLine();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sectionView
            // 
            this.sectionView.Location = new System.Drawing.Point(12, 27);
            this.sectionView.Name = "sectionView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Project";
            treeNode2.Name = "Node2";
            treeNode2.Text = "General";
            treeNode3.Name = "Node3";
            treeNode3.Text = "TV/Recodings";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Video";
            this.sectionView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.sectionView.Size = new System.Drawing.Size(156, 399);
            this.sectionView.TabIndex = 0;
            this.sectionView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sectionView_AfterSelect);
            // 
            // holderPanel
            // 
            this.holderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.holderPanel.AutoScroll = true;
            this.holderPanel.BackColor = System.Drawing.SystemColors.Control;
            this.holderPanel.Location = new System.Drawing.Point(174, 55);
            this.holderPanel.MinimumSize = new System.Drawing.Size(720, 370);
            this.holderPanel.Name = "holderPanel";
            this.holderPanel.Size = new System.Drawing.Size(720, 382);
            this.holderPanel.TabIndex = 5;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.Caption = "";
            this.headerLabel.FirstColor = System.Drawing.SystemColors.InactiveCaption;
            this.headerLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.LastColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(174, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.PaddingLeft = 2;
            this.headerLabel.Size = new System.Drawing.Size(720, 24);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.TabStop = false;
            this.headerLabel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.TextFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // beveledLine1
            // 
            this.beveledLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.beveledLine1.Location = new System.Drawing.Point(12, 475);
            this.beveledLine1.Name = "beveledLine1";
            this.beveledLine1.Size = new System.Drawing.Size(883, 2);
            this.beveledLine1.TabIndex = 7;
            this.beveledLine1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(738, 483);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(819, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 483);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(93, 483);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // IntelligentFrameCorrectionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 518);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.beveledLine1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.holderPanel);
            this.Controls.Add(this.sectionView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IntelligentFrameCorrectionSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Frame Correction Setup";
            this.Load += new System.EventHandler(this.IntelligentFrameCorrectionSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView sectionView;
        private System.Windows.Forms.Panel holderPanel;
        private MediaPortal.UserInterface.Controls.MPGradientLabel headerLabel;
        private MediaPortal.UserInterface.Controls.MPBeveledLine beveledLine1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;



    }
}