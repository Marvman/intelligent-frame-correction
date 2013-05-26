namespace IntelligentFrameCorrection
{
    partial class TvRec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TvRec));
            this.grpBoxTVCrop = new System.Windows.Forms.GroupBox();
            this.sliderTVCropRight = new System.Windows.Forms.TrackBar();
            this.sliderTVCropLeft = new System.Windows.Forms.TrackBar();
            this.sliderTVCropBottom = new System.Windows.Forms.TrackBar();
            this.sliderTVCropTop = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.numUpDownTVCropTop = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTVCropBottom = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTVCropRight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTVCropLeft = new System.Windows.Forms.NumericUpDown();
            this.lineTVCropRight = new Controls.ColoredPanel();
            this.lineTVCropBottom = new Controls.ColoredPanel();
            this.lineTVCropLeft = new Controls.ColoredPanel();
            this.lineTVCropTop = new Controls.ColoredPanel();
            this.tvCropPicture = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxTVCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCropPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxTVCrop
            // 
            this.grpBoxTVCrop.Controls.Add(this.sliderTVCropRight);
            this.grpBoxTVCrop.Controls.Add(this.sliderTVCropLeft);
            this.grpBoxTVCrop.Controls.Add(this.sliderTVCropBottom);
            this.grpBoxTVCrop.Controls.Add(this.sliderTVCropTop);
            this.grpBoxTVCrop.Controls.Add(this.label22);
            this.grpBoxTVCrop.Controls.Add(this.label23);
            this.grpBoxTVCrop.Controls.Add(this.label24);
            this.grpBoxTVCrop.Controls.Add(this.label25);
            this.grpBoxTVCrop.Controls.Add(this.numUpDownTVCropTop);
            this.grpBoxTVCrop.Controls.Add(this.numUpDownTVCropBottom);
            this.grpBoxTVCrop.Controls.Add(this.numUpDownTVCropRight);
            this.grpBoxTVCrop.Controls.Add(this.numUpDownTVCropLeft);
            this.grpBoxTVCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTVCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxTVCrop.Location = new System.Drawing.Point(21, 142);
            this.grpBoxTVCrop.Name = "grpBoxTVCrop";
            this.grpBoxTVCrop.Size = new System.Drawing.Size(251, 208);
            this.grpBoxTVCrop.TabIndex = 42;
            this.grpBoxTVCrop.TabStop = false;
            this.grpBoxTVCrop.Text = "Adjust TV/Recordings Crop Settings";
            this.toolTip.SetToolTip(this.grpBoxTVCrop, resources.GetString("grpBoxTVCrop.ToolTip"));
            // 
            // sliderTVCropRight
            // 
            this.sliderTVCropRight.AutoSize = false;
            this.sliderTVCropRight.Location = new System.Drawing.Point(6, 160);
            this.sliderTVCropRight.Maximum = 100;
            this.sliderTVCropRight.Name = "sliderTVCropRight";
            this.sliderTVCropRight.Size = new System.Drawing.Size(145, 20);
            this.sliderTVCropRight.TabIndex = 8;
            this.sliderTVCropRight.TickFrequency = 50;
            this.sliderTVCropRight.Scroll += new System.EventHandler(this.sliderTVCropRight_Scroll);
            // 
            // sliderTVCropLeft
            // 
            this.sliderTVCropLeft.AutoSize = false;
            this.sliderTVCropLeft.Location = new System.Drawing.Point(6, 120);
            this.sliderTVCropLeft.Maximum = 100;
            this.sliderTVCropLeft.Name = "sliderTVCropLeft";
            this.sliderTVCropLeft.Size = new System.Drawing.Size(145, 20);
            this.sliderTVCropLeft.TabIndex = 8;
            this.sliderTVCropLeft.TickFrequency = 50;
            this.sliderTVCropLeft.Scroll += new System.EventHandler(this.sliderTVCropLeft_Scroll);
            // 
            // sliderTVCropBottom
            // 
            this.sliderTVCropBottom.AutoSize = false;
            this.sliderTVCropBottom.Location = new System.Drawing.Point(6, 80);
            this.sliderTVCropBottom.Maximum = 100;
            this.sliderTVCropBottom.Name = "sliderTVCropBottom";
            this.sliderTVCropBottom.Size = new System.Drawing.Size(145, 20);
            this.sliderTVCropBottom.TabIndex = 8;
            this.sliderTVCropBottom.TickFrequency = 50;
            this.sliderTVCropBottom.Scroll += new System.EventHandler(this.sliderTVCropBottom_Scroll);
            // 
            // sliderTVCropTop
            // 
            this.sliderTVCropTop.AutoSize = false;
            this.sliderTVCropTop.Location = new System.Drawing.Point(6, 40);
            this.sliderTVCropTop.Maximum = 100;
            this.sliderTVCropTop.Name = "sliderTVCropTop";
            this.sliderTVCropTop.Size = new System.Drawing.Size(145, 20);
            this.sliderTVCropTop.TabIndex = 8;
            this.sliderTVCropTop.TickFrequency = 50;
            this.sliderTVCropTop.Scroll += new System.EventHandler(this.sliderTVCropTop_Scroll);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(9, 107);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Left";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(9, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Right";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(9, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Bottom";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(9, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Top";
            // 
            // numUpDownTVCropTop
            // 
            this.numUpDownTVCropTop.Location = new System.Drawing.Point(157, 40);
            this.numUpDownTVCropTop.Name = "numUpDownTVCropTop";
            this.numUpDownTVCropTop.Size = new System.Drawing.Size(47, 20);
            this.numUpDownTVCropTop.TabIndex = 3;
            this.numUpDownTVCropTop.ValueChanged += new System.EventHandler(this.numUpDownTVCropTop_ValueChanged);
            // 
            // numUpDownTVCropBottom
            // 
            this.numUpDownTVCropBottom.Location = new System.Drawing.Point(157, 80);
            this.numUpDownTVCropBottom.Name = "numUpDownTVCropBottom";
            this.numUpDownTVCropBottom.Size = new System.Drawing.Size(47, 20);
            this.numUpDownTVCropBottom.TabIndex = 2;
            this.numUpDownTVCropBottom.ValueChanged += new System.EventHandler(this.numUpDownTVCropBottom_ValueChanged);
            // 
            // numUpDownTVCropRight
            // 
            this.numUpDownTVCropRight.Location = new System.Drawing.Point(157, 160);
            this.numUpDownTVCropRight.Name = "numUpDownTVCropRight";
            this.numUpDownTVCropRight.Size = new System.Drawing.Size(47, 20);
            this.numUpDownTVCropRight.TabIndex = 1;
            this.numUpDownTVCropRight.ValueChanged += new System.EventHandler(this.numUpDownTVCropRight_ValueChanged);
            // 
            // numUpDownTVCropLeft
            // 
            this.numUpDownTVCropLeft.Location = new System.Drawing.Point(157, 120);
            this.numUpDownTVCropLeft.Name = "numUpDownTVCropLeft";
            this.numUpDownTVCropLeft.Size = new System.Drawing.Size(47, 20);
            this.numUpDownTVCropLeft.TabIndex = 0;
            this.numUpDownTVCropLeft.ValueChanged += new System.EventHandler(this.numUpDownTVCropLeft_ValueChanged);
            // 
            // lineTVCropRight
            // 
            this.lineTVCropRight.BackColor = System.Drawing.Color.Lime;
            this.lineTVCropRight.BorderColor = System.Drawing.Color.Lime;
            this.lineTVCropRight.BorderColorWidth = 3F;
            this.lineTVCropRight.Location = new System.Drawing.Point(714, 23);
            this.lineTVCropRight.Name = "lineTVCropRight";
            this.lineTVCropRight.Size = new System.Drawing.Size(1, 330);
            this.lineTVCropRight.TabIndex = 43;
            // 
            // lineTVCropBottom
            // 
            this.lineTVCropBottom.BackColor = System.Drawing.Color.Lime;
            this.lineTVCropBottom.BorderColor = System.Drawing.Color.Lime;
            this.lineTVCropBottom.BorderColorWidth = 3F;
            this.lineTVCropBottom.Location = new System.Drawing.Point(278, 346);
            this.lineTVCropBottom.Name = "lineTVCropBottom";
            this.lineTVCropBottom.Size = new System.Drawing.Size(439, 1);
            this.lineTVCropBottom.TabIndex = 43;
            // 
            // lineTVCropLeft
            // 
            this.lineTVCropLeft.BackColor = System.Drawing.Color.Lime;
            this.lineTVCropLeft.BorderColor = System.Drawing.Color.Lime;
            this.lineTVCropLeft.BorderColorWidth = 3F;
            this.lineTVCropLeft.Location = new System.Drawing.Point(278, 23);
            this.lineTVCropLeft.Name = "lineTVCropLeft";
            this.lineTVCropLeft.Size = new System.Drawing.Size(1, 330);
            this.lineTVCropLeft.TabIndex = 43;
            // 
            // lineTVCropTop
            // 
            this.lineTVCropTop.BackColor = System.Drawing.Color.Lime;
            this.lineTVCropTop.BorderColor = System.Drawing.Color.Lime;
            this.lineTVCropTop.BorderColorWidth = 3F;
            this.lineTVCropTop.Location = new System.Drawing.Point(278, 20);
            this.lineTVCropTop.Name = "lineTVCropTop";
            this.lineTVCropTop.Size = new System.Drawing.Size(439, 1);
            this.lineTVCropTop.TabIndex = 43;
            // 
            // tvCropPicture
            // 
            this.tvCropPicture.BackgroundImage = global::IntelligentFrameCorrection.Properties.Resources.joker16zu9_2;
            this.tvCropPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tvCropPicture.Location = new System.Drawing.Point(278, 20);
            this.tvCropPicture.Name = "tvCropPicture";
            this.tvCropPicture.Size = new System.Drawing.Size(439, 330);
            this.tvCropPicture.TabIndex = 1;
            this.tvCropPicture.TabStop = false;
            // 
            // TvRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lineTVCropRight);
            this.Controls.Add(this.lineTVCropBottom);
            this.Controls.Add(this.lineTVCropLeft);
            this.Controls.Add(this.lineTVCropTop);
            this.Controls.Add(this.grpBoxTVCrop);
            this.Controls.Add(this.tvCropPicture);
            this.Name = "TvRec";
            this.Size = new System.Drawing.Size(720, 370);
            this.grpBoxTVCrop.ResumeLayout(false);
            this.grpBoxTVCrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTVCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTVCropLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCropPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox tvCropPicture;
        private System.Windows.Forms.GroupBox grpBoxTVCrop;
        private System.Windows.Forms.TrackBar sliderTVCropRight;
        private System.Windows.Forms.TrackBar sliderTVCropLeft;
        private System.Windows.Forms.TrackBar sliderTVCropBottom;
        private System.Windows.Forms.TrackBar sliderTVCropTop;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        internal Controls.ColoredPanel lineTVCropTop;
        internal Controls.ColoredPanel lineTVCropRight;
        internal Controls.ColoredPanel lineTVCropLeft;
        internal Controls.ColoredPanel lineTVCropBottom;
        internal System.Windows.Forms.NumericUpDown numUpDownTVCropTop;
        internal System.Windows.Forms.NumericUpDown numUpDownTVCropBottom;
        internal System.Windows.Forms.NumericUpDown numUpDownTVCropRight;
        internal System.Windows.Forms.NumericUpDown numUpDownTVCropLeft;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
