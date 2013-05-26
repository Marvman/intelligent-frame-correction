namespace IntelligentFrameCorrection
{
    partial class General
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Advanced View Mode", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "4:3",
            "a",
            "b",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "4:3 Letterbox",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "16:9",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "16:9 Letterbox",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "16:9 With Sidebars",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "21:9",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Default",
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Scan Area", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Top",
            "a",
            "b",
            "c",
            "d"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bottom",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Left",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Right",
            "",
            "",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb21to9 = new System.Windows.Forms.RadioButton();
            this.rdb16to9 = new System.Windows.Forms.RadioButton();
            this.rdb4to3 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabAdvancedViewMode = new System.Windows.Forms.TabPage();
            this.grpBoxAdjustViewMode = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckbUseZoomFactorOnly = new System.Windows.Forms.CheckBox();
            this.sliderRightZoom = new System.Windows.Forms.TrackBar();
            this.sliderLeftZoom = new System.Windows.Forms.TrackBar();
            this.sliderBottomZoom = new System.Windows.Forms.TrackBar();
            this.sliderTopZoom = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numTopZoom = new System.Windows.Forms.NumericUpDown();
            this.numBottomZoom = new System.Windows.Forms.NumericUpDown();
            this.numRightZoom = new System.Windows.Forms.NumericUpDown();
            this.numLeftZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbboxViewModes = new System.Windows.Forms.ComboBox();
            this.listViewAdvancedViewMode = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabScanArea = new System.Windows.Forms.TabPage();
            this.TopScanArea = new Controls.ColoredPanel();
            this.grpBoxBlackArea = new System.Windows.Forms.GroupBox();
            this.sliderScanAreaY = new System.Windows.Forms.TrackBar();
            this.sliderScanAreaX = new System.Windows.Forms.TrackBar();
            this.sliderScanAreaWidth = new System.Windows.Forms.TrackBar();
            this.sliderScanAreaHeight = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.BlackAreaUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.BlackAreaUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.BlackAreaUpDownY = new System.Windows.Forms.NumericUpDown();
            this.BlackAreaUpDownX = new System.Windows.Forms.NumericUpDown();
            this.listViewScanArea = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanAreaPicture = new System.Windows.Forms.PictureBox();
            this.BottomScanArea = new Controls.ColoredPanel();
            this.RightScanArea = new Controls.ColoredPanel();
            this.LeftScanArea = new Controls.ColoredPanel();
            this.tabOverscan = new System.Windows.Forms.TabPage();
            this.lineOverscanCropBottom = new Controls.ColoredPanel();
            this.lineOverscanCropLeft = new Controls.ColoredPanel();
            this.lineOverscanCropRight = new Controls.ColoredPanel();
            this.grpBoxOverscanCrop = new System.Windows.Forms.GroupBox();
            this.sliderOverscanCropRight = new System.Windows.Forms.TrackBar();
            this.sliderOverscanCropLeft = new System.Windows.Forms.TrackBar();
            this.sliderOverscanCropBottom = new System.Windows.Forms.TrackBar();
            this.sliderOverscanCropTop = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numUpDownOverscanCropTop = new System.Windows.Forms.NumericUpDown();
            this.numUpDownOverscanCropBottom = new System.Windows.Forms.NumericUpDown();
            this.numUpDownOverscanCropRight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownOverscanCropLeft = new System.Windows.Forms.NumericUpDown();
            this.overscanCropPicture = new System.Windows.Forms.PictureBox();
            this.lineOverscanCropTop = new Controls.ColoredPanel();
            this.tabMiscellaneous = new System.Windows.Forms.TabPage();
            this.sliderFrameCaptureSize = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.numUpDownFrameCaptureSize = new System.Windows.Forms.NumericUpDown();
            this.sliderEdgeDetectionTolerance = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.numUpDownEdgeDetectionTolerance = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOperator = new System.Windows.Forms.Button();
            this.numUpDownHDHeight = new System.Windows.Forms.NumericUpDown();
            this.ckbHDSupport = new System.Windows.Forms.CheckBox();
            this.numUpDownHDWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownStabilizationFactor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderStabilizationTolerance = new System.Windows.Forms.TrackBar();
            this.numUpDownMaxBrightnessThreashold = new System.Windows.Forms.NumericUpDown();
            this.sliderStabilizationFactor = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.numUpDownMinBrightnessThreashold = new System.Windows.Forms.NumericUpDown();
            this.numUpDownStabilizationTolerance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.sliderMaxBrightnessThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sliderMinBrightnessThreshold = new System.Windows.Forms.TrackBar();
            this.ckbVideoSupport = new System.Windows.Forms.CheckBox();
            this.sliderDoubleBlackBarHeight = new System.Windows.Forms.TrackBar();
            this.sliderSingleBlackBarHeight = new System.Windows.Forms.TrackBar();
            this.sliderDetectionCounter = new System.Windows.Forms.TrackBar();
            this.sliderScanInterval = new System.Windows.Forms.TrackBar();
            this.ckbAutoStart = new System.Windows.Forms.CheckBox();
            this.ckbBlackBarScanner = new System.Windows.Forms.CheckBox();
            this.ckbCorrectAspectRatio = new System.Windows.Forms.CheckBox();
            this.ckbVerboseLogging = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownDoubleBlackBarHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSingleBlackBarHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDetectionCounter = new System.Windows.Forms.NumericUpDown();
            this.numUpDownScanInterval = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.ckbLeftSideBlackBar = new System.Windows.Forms.CheckBox();
            this.ckbRightSideBlackBar = new System.Windows.Forms.CheckBox();
            this.ckbBottomDoubleBlackBar = new System.Windows.Forms.CheckBox();
            this.ckbTopDoubleBlackBar = new System.Windows.Forms.CheckBox();
            this.ckbBottomSingleBlackBar = new System.Windows.Forms.CheckBox();
            this.ckbTopSingleBlackBar = new System.Windows.Forms.CheckBox();
            this.btnTestAndBenchmark = new System.Windows.Forms.Button();
            this.btnLoadSreenshot = new System.Windows.Forms.Button();
            this.pictureBoxTestImage = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabAdvancedViewMode.SuspendLayout();
            this.grpBoxAdjustViewMode.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRightZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLeftZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBottomZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTopZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBottomZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRightZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftZoom)).BeginInit();
            this.tabScanArea.SuspendLayout();
            this.grpBoxBlackArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanAreaPicture)).BeginInit();
            this.tabOverscan.SuspendLayout();
            this.grpBoxOverscanCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overscanCropPicture)).BeginInit();
            this.tabMiscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFrameCaptureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFrameCaptureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderEdgeDetectionTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdgeDetectionTolerance)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHDHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHDWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStabilizationFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStabilizationTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxBrightnessThreashold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStabilizationFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinBrightnessThreashold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStabilizationTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMaxBrightnessThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMinBrightnessThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDoubleBlackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSingleBlackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDetectionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDoubleBlackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSingleBlackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDetectionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownScanInterval)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdb21to9);
            this.groupBox1.Controls.Add(this.rdb16to9);
            this.groupBox1.Controls.Add(this.rdb4to3);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TV Ratio";
            this.toolTip.SetToolTip(this.groupBox1, "Aspect ratio of you television.");
            // 
            // rdb21to9
            // 
            this.rdb21to9.AutoSize = true;
            this.rdb21to9.Location = new System.Drawing.Point(12, 65);
            this.rdb21to9.Name = "rdb21to9";
            this.rdb21to9.Size = new System.Drawing.Size(46, 17);
            this.rdb21to9.TabIndex = 0;
            this.rdb21to9.TabStop = true;
            this.rdb21to9.Text = "21:9";
            this.rdb21to9.UseVisualStyleBackColor = true;
            // 
            // rdb16to9
            // 
            this.rdb16to9.AutoSize = true;
            this.rdb16to9.Location = new System.Drawing.Point(12, 42);
            this.rdb16to9.Name = "rdb16to9";
            this.rdb16to9.Size = new System.Drawing.Size(46, 17);
            this.rdb16to9.TabIndex = 0;
            this.rdb16to9.TabStop = true;
            this.rdb16to9.Text = "16:9";
            this.rdb16to9.UseVisualStyleBackColor = true;
            // 
            // rdb4to3
            // 
            this.rdb4to3.AutoSize = true;
            this.rdb4to3.Location = new System.Drawing.Point(12, 19);
            this.rdb4to3.Name = "rdb4to3";
            this.rdb4to3.Size = new System.Drawing.Size(40, 17);
            this.rdb4to3.TabIndex = 0;
            this.rdb4to3.TabStop = true;
            this.rdb4to3.Text = "4:3";
            this.rdb4to3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabAdvancedViewMode);
            this.tabControl1.Controls.Add(this.tabScanArea);
            this.tabControl1.Controls.Add(this.tabOverscan);
            this.tabControl1.Controls.Add(this.tabMiscellaneous);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 368);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(705, 342);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabAdvancedViewMode
            // 
            this.tabAdvancedViewMode.Controls.Add(this.grpBoxAdjustViewMode);
            this.tabAdvancedViewMode.Controls.Add(this.listViewAdvancedViewMode);
            this.tabAdvancedViewMode.Location = new System.Drawing.Point(4, 22);
            this.tabAdvancedViewMode.Name = "tabAdvancedViewMode";
            this.tabAdvancedViewMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancedViewMode.Size = new System.Drawing.Size(705, 342);
            this.tabAdvancedViewMode.TabIndex = 1;
            this.tabAdvancedViewMode.Text = "Advanced View Mode";
            this.tabAdvancedViewMode.UseVisualStyleBackColor = true;
            // 
            // grpBoxAdjustViewMode
            // 
            this.grpBoxAdjustViewMode.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxAdjustViewMode.Controls.Add(this.groupBox6);
            this.grpBoxAdjustViewMode.Controls.Add(this.sliderRightZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.sliderLeftZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.sliderBottomZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.sliderTopZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.label9);
            this.grpBoxAdjustViewMode.Controls.Add(this.label10);
            this.grpBoxAdjustViewMode.Controls.Add(this.label11);
            this.grpBoxAdjustViewMode.Controls.Add(this.label12);
            this.grpBoxAdjustViewMode.Controls.Add(this.numTopZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.numBottomZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.numRightZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.numLeftZoom);
            this.grpBoxAdjustViewMode.Controls.Add(this.label1);
            this.grpBoxAdjustViewMode.Controls.Add(this.cmbboxViewModes);
            this.grpBoxAdjustViewMode.Enabled = false;
            this.grpBoxAdjustViewMode.Location = new System.Drawing.Point(3, 182);
            this.grpBoxAdjustViewMode.Name = "grpBoxAdjustViewMode";
            this.grpBoxAdjustViewMode.Size = new System.Drawing.Size(696, 158);
            this.grpBoxAdjustViewMode.TabIndex = 1;
            this.grpBoxAdjustViewMode.TabStop = false;
            this.grpBoxAdjustViewMode.Text = "Adjust selected advanced view mode";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ckbUseZoomFactorOnly);
            this.groupBox6.Location = new System.Drawing.Point(231, 77);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 68);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            // 
            // ckbUseZoomFactorOnly
            // 
            this.ckbUseZoomFactorOnly.AutoSize = true;
            this.ckbUseZoomFactorOnly.Location = new System.Drawing.Point(6, 16);
            this.ckbUseZoomFactorOnly.Name = "ckbUseZoomFactorOnly";
            this.ckbUseZoomFactorOnly.Size = new System.Drawing.Size(95, 17);
            this.ckbUseZoomFactorOnly.TabIndex = 21;
            this.ckbUseZoomFactorOnly.Text = "Use zoom only";
            this.toolTip.SetToolTip(this.ckbUseZoomFactorOnly, "Use only the set zoom.\r\nDisabled the dynamic pixel accuracy cropping.");
            this.ckbUseZoomFactorOnly.UseVisualStyleBackColor = true;
            // 
            // sliderRightZoom
            // 
            this.sliderRightZoom.AutoSize = false;
            this.sliderRightZoom.Location = new System.Drawing.Point(447, 125);
            this.sliderRightZoom.Maximum = 100;
            this.sliderRightZoom.Name = "sliderRightZoom";
            this.sliderRightZoom.Size = new System.Drawing.Size(145, 20);
            this.sliderRightZoom.TabIndex = 18;
            this.sliderRightZoom.TickFrequency = 50;
            this.sliderRightZoom.Scroll += new System.EventHandler(this.sliderRightZoom_Scroll);
            // 
            // sliderLeftZoom
            // 
            this.sliderLeftZoom.AutoSize = false;
            this.sliderLeftZoom.Location = new System.Drawing.Point(447, 85);
            this.sliderLeftZoom.Maximum = 100;
            this.sliderLeftZoom.Name = "sliderLeftZoom";
            this.sliderLeftZoom.Size = new System.Drawing.Size(145, 20);
            this.sliderLeftZoom.TabIndex = 17;
            this.sliderLeftZoom.TickFrequency = 50;
            this.sliderLeftZoom.Scroll += new System.EventHandler(this.sliderLeftZoom_Scroll);
            // 
            // sliderBottomZoom
            // 
            this.sliderBottomZoom.AutoSize = false;
            this.sliderBottomZoom.Location = new System.Drawing.Point(8, 123);
            this.sliderBottomZoom.Maximum = 100;
            this.sliderBottomZoom.Name = "sliderBottomZoom";
            this.sliderBottomZoom.Size = new System.Drawing.Size(145, 20);
            this.sliderBottomZoom.TabIndex = 20;
            this.sliderBottomZoom.TickFrequency = 50;
            this.sliderBottomZoom.Scroll += new System.EventHandler(this.sliderBottomZoom_Scroll);
            // 
            // sliderTopZoom
            // 
            this.sliderTopZoom.AutoSize = false;
            this.sliderTopZoom.Location = new System.Drawing.Point(8, 83);
            this.sliderTopZoom.Maximum = 100;
            this.sliderTopZoom.Name = "sliderTopZoom";
            this.sliderTopZoom.Size = new System.Drawing.Size(145, 20);
            this.sliderTopZoom.TabIndex = 19;
            this.sliderTopZoom.TickFrequency = 50;
            this.sliderTopZoom.Scroll += new System.EventHandler(this.sliderTopZoom_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(450, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Left";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(450, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Right";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(11, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Bottom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(11, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Top";
            // 
            // numTopZoom
            // 
            this.numTopZoom.Location = new System.Drawing.Point(159, 83);
            this.numTopZoom.Name = "numTopZoom";
            this.numTopZoom.Size = new System.Drawing.Size(47, 20);
            this.numTopZoom.TabIndex = 12;
            this.numTopZoom.ValueChanged += new System.EventHandler(this.numTopZoom_ValueChanged);
            // 
            // numBottomZoom
            // 
            this.numBottomZoom.Location = new System.Drawing.Point(159, 123);
            this.numBottomZoom.Name = "numBottomZoom";
            this.numBottomZoom.Size = new System.Drawing.Size(47, 20);
            this.numBottomZoom.TabIndex = 11;
            this.numBottomZoom.ValueChanged += new System.EventHandler(this.numBottomZoom_ValueChanged);
            // 
            // numRightZoom
            // 
            this.numRightZoom.Location = new System.Drawing.Point(598, 125);
            this.numRightZoom.Name = "numRightZoom";
            this.numRightZoom.Size = new System.Drawing.Size(47, 20);
            this.numRightZoom.TabIndex = 10;
            this.numRightZoom.ValueChanged += new System.EventHandler(this.numRightZoom_ValueChanged);
            // 
            // numLeftZoom
            // 
            this.numLeftZoom.Location = new System.Drawing.Point(598, 85);
            this.numLeftZoom.Name = "numLeftZoom";
            this.numLeftZoom.Size = new System.Drawing.Size(47, 20);
            this.numLeftZoom.TabIndex = 9;
            this.numLeftZoom.ValueChanged += new System.EventHandler(this.numLeftZoom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Mode";
            // 
            // cmbboxViewModes
            // 
            this.cmbboxViewModes.FormattingEnabled = true;
            this.cmbboxViewModes.Location = new System.Drawing.Point(12, 35);
            this.cmbboxViewModes.Name = "cmbboxViewModes";
            this.cmbboxViewModes.Size = new System.Drawing.Size(134, 21);
            this.cmbboxViewModes.TabIndex = 0;
            this.cmbboxViewModes.SelectedIndexChanged += new System.EventHandler(this.cmbboxViewModes_SelectedIndexChanged);
            // 
            // listViewAdvancedViewMode
            // 
            this.listViewAdvancedViewMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewAdvancedViewMode.FullRowSelect = true;
            listViewGroup1.Header = "Advanced View Mode";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewAdvancedViewMode.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewAdvancedViewMode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAdvancedViewMode.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup1;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup1;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup1;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup1;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Group = listViewGroup1;
            listViewItem7.StateImageIndex = 0;
            this.listViewAdvancedViewMode.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewAdvancedViewMode.Location = new System.Drawing.Point(3, 3);
            this.listViewAdvancedViewMode.MultiSelect = false;
            this.listViewAdvancedViewMode.Name = "listViewAdvancedViewMode";
            this.listViewAdvancedViewMode.Scrollable = false;
            this.listViewAdvancedViewMode.Size = new System.Drawing.Size(696, 173);
            this.listViewAdvancedViewMode.TabIndex = 0;
            this.toolTip.SetToolTip(this.listViewAdvancedViewMode, "Select the view mode for each possible aspect ratio.\r\nA zoom for each side could " +
                    "additionally be chosen.\r\n");
            this.listViewAdvancedViewMode.UseCompatibleStateImageBehavior = false;
            this.listViewAdvancedViewMode.View = System.Windows.Forms.View.Details;
            this.listViewAdvancedViewMode.SelectedIndexChanged += new System.EventHandler(this.listViewAdvancedViewMode_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "View Mode";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Top Zoom in %";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bottom Zoom in %";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Left Zoom in %";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Right Zoom in %";
            this.columnHeader11.Width = 100;
            // 
            // tabScanArea
            // 
            this.tabScanArea.Controls.Add(this.TopScanArea);
            this.tabScanArea.Controls.Add(this.grpBoxBlackArea);
            this.tabScanArea.Controls.Add(this.listViewScanArea);
            this.tabScanArea.Controls.Add(this.scanAreaPicture);
            this.tabScanArea.Controls.Add(this.BottomScanArea);
            this.tabScanArea.Controls.Add(this.RightScanArea);
            this.tabScanArea.Controls.Add(this.LeftScanArea);
            this.tabScanArea.Location = new System.Drawing.Point(4, 22);
            this.tabScanArea.Name = "tabScanArea";
            this.tabScanArea.Size = new System.Drawing.Size(705, 342);
            this.tabScanArea.TabIndex = 2;
            this.tabScanArea.Text = "Scan Area";
            this.tabScanArea.UseVisualStyleBackColor = true;
            // 
            // TopScanArea
            // 
            this.TopScanArea.BackColor = System.Drawing.Color.Transparent;
            this.TopScanArea.BorderColor = System.Drawing.Color.Lime;
            this.TopScanArea.BorderColorWidth = 3F;
            this.TopScanArea.Location = new System.Drawing.Point(441, 3);
            this.TopScanArea.Name = "TopScanArea";
            this.TopScanArea.Size = new System.Drawing.Size(50, 33);
            this.TopScanArea.TabIndex = 4;
            // 
            // grpBoxBlackArea
            // 
            this.grpBoxBlackArea.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxBlackArea.Controls.Add(this.sliderScanAreaY);
            this.grpBoxBlackArea.Controls.Add(this.sliderScanAreaX);
            this.grpBoxBlackArea.Controls.Add(this.sliderScanAreaWidth);
            this.grpBoxBlackArea.Controls.Add(this.sliderScanAreaHeight);
            this.grpBoxBlackArea.Controls.Add(this.label22);
            this.grpBoxBlackArea.Controls.Add(this.label23);
            this.grpBoxBlackArea.Controls.Add(this.label24);
            this.grpBoxBlackArea.Controls.Add(this.label25);
            this.grpBoxBlackArea.Controls.Add(this.BlackAreaUpDownHeight);
            this.grpBoxBlackArea.Controls.Add(this.BlackAreaUpDownWidth);
            this.grpBoxBlackArea.Controls.Add(this.BlackAreaUpDownY);
            this.grpBoxBlackArea.Controls.Add(this.BlackAreaUpDownX);
            this.grpBoxBlackArea.Enabled = false;
            this.grpBoxBlackArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxBlackArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxBlackArea.Location = new System.Drawing.Point(3, 125);
            this.grpBoxBlackArea.Name = "grpBoxBlackArea";
            this.grpBoxBlackArea.Size = new System.Drawing.Size(251, 215);
            this.grpBoxBlackArea.TabIndex = 41;
            this.grpBoxBlackArea.TabStop = false;
            this.grpBoxBlackArea.Text = "Adjust selected scan area";
            // 
            // sliderScanAreaY
            // 
            this.sliderScanAreaY.AutoSize = false;
            this.sliderScanAreaY.Location = new System.Drawing.Point(8, 159);
            this.sliderScanAreaY.Maximum = 100;
            this.sliderScanAreaY.Name = "sliderScanAreaY";
            this.sliderScanAreaY.Size = new System.Drawing.Size(145, 20);
            this.sliderScanAreaY.TabIndex = 8;
            this.sliderScanAreaY.TickFrequency = 50;
            this.sliderScanAreaY.Scroll += new System.EventHandler(this.sliderScanAreaY_Scroll);
            // 
            // sliderScanAreaX
            // 
            this.sliderScanAreaX.AutoSize = false;
            this.sliderScanAreaX.Location = new System.Drawing.Point(8, 119);
            this.sliderScanAreaX.Maximum = 100;
            this.sliderScanAreaX.Name = "sliderScanAreaX";
            this.sliderScanAreaX.Size = new System.Drawing.Size(145, 20);
            this.sliderScanAreaX.TabIndex = 8;
            this.sliderScanAreaX.TickFrequency = 50;
            this.sliderScanAreaX.Scroll += new System.EventHandler(this.sliderScanAreaX_Scroll);
            // 
            // sliderScanAreaWidth
            // 
            this.sliderScanAreaWidth.AutoSize = false;
            this.sliderScanAreaWidth.Location = new System.Drawing.Point(8, 79);
            this.sliderScanAreaWidth.Maximum = 100;
            this.sliderScanAreaWidth.Name = "sliderScanAreaWidth";
            this.sliderScanAreaWidth.Size = new System.Drawing.Size(145, 20);
            this.sliderScanAreaWidth.TabIndex = 8;
            this.sliderScanAreaWidth.TickFrequency = 50;
            this.sliderScanAreaWidth.Scroll += new System.EventHandler(this.sliderScanAreaWidth_Scroll);
            // 
            // sliderScanAreaHeight
            // 
            this.sliderScanAreaHeight.AutoSize = false;
            this.sliderScanAreaHeight.Location = new System.Drawing.Point(8, 39);
            this.sliderScanAreaHeight.Maximum = 100;
            this.sliderScanAreaHeight.Name = "sliderScanAreaHeight";
            this.sliderScanAreaHeight.Size = new System.Drawing.Size(145, 20);
            this.sliderScanAreaHeight.TabIndex = 8;
            this.sliderScanAreaHeight.TickFrequency = 50;
            this.sliderScanAreaHeight.Scroll += new System.EventHandler(this.sliderScanAreaHeight_Scroll);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(11, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "X";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(11, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(11, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Width";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(11, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Height";
            // 
            // BlackAreaUpDownHeight
            // 
            this.BlackAreaUpDownHeight.Location = new System.Drawing.Point(159, 39);
            this.BlackAreaUpDownHeight.Name = "BlackAreaUpDownHeight";
            this.BlackAreaUpDownHeight.Size = new System.Drawing.Size(47, 20);
            this.BlackAreaUpDownHeight.TabIndex = 3;
            this.BlackAreaUpDownHeight.ValueChanged += new System.EventHandler(this.BlackAreaUpDownHeight_ValueChanged);
            // 
            // BlackAreaUpDownWidth
            // 
            this.BlackAreaUpDownWidth.Location = new System.Drawing.Point(159, 79);
            this.BlackAreaUpDownWidth.Name = "BlackAreaUpDownWidth";
            this.BlackAreaUpDownWidth.Size = new System.Drawing.Size(47, 20);
            this.BlackAreaUpDownWidth.TabIndex = 2;
            this.BlackAreaUpDownWidth.ValueChanged += new System.EventHandler(this.BlackAreaUpDownWidth_ValueChanged);
            // 
            // BlackAreaUpDownY
            // 
            this.BlackAreaUpDownY.Location = new System.Drawing.Point(159, 159);
            this.BlackAreaUpDownY.Name = "BlackAreaUpDownY";
            this.BlackAreaUpDownY.Size = new System.Drawing.Size(47, 20);
            this.BlackAreaUpDownY.TabIndex = 1;
            this.BlackAreaUpDownY.ValueChanged += new System.EventHandler(this.BlackAreaUpDownY_ValueChanged);
            // 
            // BlackAreaUpDownX
            // 
            this.BlackAreaUpDownX.Location = new System.Drawing.Point(159, 119);
            this.BlackAreaUpDownX.Name = "BlackAreaUpDownX";
            this.BlackAreaUpDownX.Size = new System.Drawing.Size(47, 20);
            this.BlackAreaUpDownX.TabIndex = 0;
            this.BlackAreaUpDownX.ValueChanged += new System.EventHandler(this.BlackAreaUpDownX_ValueChanged);
            // 
            // listViewScanArea
            // 
            this.listViewScanArea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewScanArea.FullRowSelect = true;
            listViewGroup2.Header = "Scan Area";
            listViewGroup2.Name = "listViewGroup1";
            this.listViewScanArea.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewScanArea.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewScanArea.HideSelection = false;
            listViewItem8.Group = listViewGroup2;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.Group = listViewGroup2;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup2;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.Group = listViewGroup2;
            listViewItem11.StateImageIndex = 0;
            this.listViewScanArea.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listViewScanArea.Location = new System.Drawing.Point(3, 4);
            this.listViewScanArea.MultiSelect = false;
            this.listViewScanArea.Name = "listViewScanArea";
            this.listViewScanArea.Scrollable = false;
            this.listViewScanArea.Size = new System.Drawing.Size(251, 119);
            this.listViewScanArea.TabIndex = 5;
            this.toolTip.SetToolTip(this.listViewScanArea, resources.GetString("listViewScanArea.ToolTip"));
            this.listViewScanArea.UseCompatibleStateImageBehavior = false;
            this.listViewScanArea.View = System.Windows.Forms.View.Details;
            this.listViewScanArea.SelectedIndexChanged += new System.EventHandler(this.listViewScanArea_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Height";
            this.columnHeader5.Width = 45;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Width";
            this.columnHeader6.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "X";
            this.columnHeader7.Width = 45;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Y";
            this.columnHeader8.Width = 45;
            // 
            // scanAreaPicture
            // 
            this.scanAreaPicture.BackgroundImage = global::IntelligentFrameCorrection.Properties.Resources.joker16zu9_2;
            this.scanAreaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scanAreaPicture.Location = new System.Drawing.Point(260, 6);
            this.scanAreaPicture.Name = "scanAreaPicture";
            this.scanAreaPicture.Size = new System.Drawing.Size(439, 330);
            this.scanAreaPicture.TabIndex = 0;
            this.scanAreaPicture.TabStop = false;
            // 
            // BottomScanArea
            // 
            this.BottomScanArea.BackColor = System.Drawing.Color.Transparent;
            this.BottomScanArea.BorderColor = System.Drawing.Color.Lime;
            this.BottomScanArea.BorderColorWidth = 3F;
            this.BottomScanArea.Location = new System.Drawing.Point(441, 300);
            this.BottomScanArea.Name = "BottomScanArea";
            this.BottomScanArea.Size = new System.Drawing.Size(50, 33);
            this.BottomScanArea.TabIndex = 4;
            // 
            // RightScanArea
            // 
            this.RightScanArea.BackColor = System.Drawing.Color.Transparent;
            this.RightScanArea.BorderColor = System.Drawing.Color.Lime;
            this.RightScanArea.BorderColorWidth = 3F;
            this.RightScanArea.Location = new System.Drawing.Point(649, 128);
            this.RightScanArea.Name = "RightScanArea";
            this.RightScanArea.Size = new System.Drawing.Size(50, 33);
            this.RightScanArea.TabIndex = 4;
            // 
            // LeftScanArea
            // 
            this.LeftScanArea.BackColor = System.Drawing.Color.Transparent;
            this.LeftScanArea.BorderColor = System.Drawing.Color.Lime;
            this.LeftScanArea.BorderColorWidth = 3F;
            this.LeftScanArea.Location = new System.Drawing.Point(260, 128);
            this.LeftScanArea.Name = "LeftScanArea";
            this.LeftScanArea.Size = new System.Drawing.Size(50, 33);
            this.LeftScanArea.TabIndex = 4;
            // 
            // tabOverscan
            // 
            this.tabOverscan.BackColor = System.Drawing.SystemColors.Control;
            this.tabOverscan.Controls.Add(this.lineOverscanCropBottom);
            this.tabOverscan.Controls.Add(this.lineOverscanCropLeft);
            this.tabOverscan.Controls.Add(this.lineOverscanCropRight);
            this.tabOverscan.Controls.Add(this.grpBoxOverscanCrop);
            this.tabOverscan.Controls.Add(this.overscanCropPicture);
            this.tabOverscan.Controls.Add(this.lineOverscanCropTop);
            this.tabOverscan.Location = new System.Drawing.Point(4, 22);
            this.tabOverscan.Name = "tabOverscan";
            this.tabOverscan.Size = new System.Drawing.Size(705, 342);
            this.tabOverscan.TabIndex = 4;
            this.tabOverscan.Text = "Overscan";
            // 
            // lineOverscanCropBottom
            // 
            this.lineOverscanCropBottom.BackColor = System.Drawing.Color.Lime;
            this.lineOverscanCropBottom.BorderColor = System.Drawing.Color.Lime;
            this.lineOverscanCropBottom.BorderColorWidth = 3F;
            this.lineOverscanCropBottom.Location = new System.Drawing.Point(259, 332);
            this.lineOverscanCropBottom.Name = "lineOverscanCropBottom";
            this.lineOverscanCropBottom.Size = new System.Drawing.Size(439, 1);
            this.lineOverscanCropBottom.TabIndex = 54;
            // 
            // lineOverscanCropLeft
            // 
            this.lineOverscanCropLeft.BackColor = System.Drawing.Color.Lime;
            this.lineOverscanCropLeft.BorderColor = System.Drawing.Color.Lime;
            this.lineOverscanCropLeft.BorderColorWidth = 3F;
            this.lineOverscanCropLeft.Location = new System.Drawing.Point(261, 4);
            this.lineOverscanCropLeft.Name = "lineOverscanCropLeft";
            this.lineOverscanCropLeft.Size = new System.Drawing.Size(1, 330);
            this.lineOverscanCropLeft.TabIndex = 55;
            // 
            // lineOverscanCropRight
            // 
            this.lineOverscanCropRight.BackColor = System.Drawing.Color.Lime;
            this.lineOverscanCropRight.BorderColor = System.Drawing.Color.Lime;
            this.lineOverscanCropRight.BorderColorWidth = 3F;
            this.lineOverscanCropRight.Location = new System.Drawing.Point(696, 3);
            this.lineOverscanCropRight.Name = "lineOverscanCropRight";
            this.lineOverscanCropRight.Size = new System.Drawing.Size(1, 330);
            this.lineOverscanCropRight.TabIndex = 53;
            // 
            // grpBoxOverscanCrop
            // 
            this.grpBoxOverscanCrop.Controls.Add(this.sliderOverscanCropRight);
            this.grpBoxOverscanCrop.Controls.Add(this.sliderOverscanCropLeft);
            this.grpBoxOverscanCrop.Controls.Add(this.sliderOverscanCropBottom);
            this.grpBoxOverscanCrop.Controls.Add(this.sliderOverscanCropTop);
            this.grpBoxOverscanCrop.Controls.Add(this.label13);
            this.grpBoxOverscanCrop.Controls.Add(this.label14);
            this.grpBoxOverscanCrop.Controls.Add(this.label15);
            this.grpBoxOverscanCrop.Controls.Add(this.label16);
            this.grpBoxOverscanCrop.Controls.Add(this.numUpDownOverscanCropTop);
            this.grpBoxOverscanCrop.Controls.Add(this.numUpDownOverscanCropBottom);
            this.grpBoxOverscanCrop.Controls.Add(this.numUpDownOverscanCropRight);
            this.grpBoxOverscanCrop.Controls.Add(this.numUpDownOverscanCropLeft);
            this.grpBoxOverscanCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOverscanCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxOverscanCrop.Location = new System.Drawing.Point(3, 125);
            this.grpBoxOverscanCrop.Name = "grpBoxOverscanCrop";
            this.grpBoxOverscanCrop.Size = new System.Drawing.Size(251, 215);
            this.grpBoxOverscanCrop.TabIndex = 51;
            this.grpBoxOverscanCrop.TabStop = false;
            this.grpBoxOverscanCrop.Text = "Adjust Overscan Crop Settings";
            this.toolTip.SetToolTip(this.grpBoxOverscanCrop, "When there are edges found, grubby edges could appear.\r\nTo prevent this behavior," +
                    " a overscan could be set globally.");
            // 
            // sliderOverscanCropRight
            // 
            this.sliderOverscanCropRight.AutoSize = false;
            this.sliderOverscanCropRight.Location = new System.Drawing.Point(8, 159);
            this.sliderOverscanCropRight.Maximum = 100;
            this.sliderOverscanCropRight.Name = "sliderOverscanCropRight";
            this.sliderOverscanCropRight.Size = new System.Drawing.Size(145, 20);
            this.sliderOverscanCropRight.TabIndex = 8;
            this.sliderOverscanCropRight.TickFrequency = 50;
            this.sliderOverscanCropRight.Scroll += new System.EventHandler(this.sliderOverscanCropRight_Scroll);
            // 
            // sliderOverscanCropLeft
            // 
            this.sliderOverscanCropLeft.AutoSize = false;
            this.sliderOverscanCropLeft.Location = new System.Drawing.Point(8, 119);
            this.sliderOverscanCropLeft.Maximum = 100;
            this.sliderOverscanCropLeft.Name = "sliderOverscanCropLeft";
            this.sliderOverscanCropLeft.Size = new System.Drawing.Size(145, 20);
            this.sliderOverscanCropLeft.TabIndex = 8;
            this.sliderOverscanCropLeft.TickFrequency = 50;
            this.sliderOverscanCropLeft.Scroll += new System.EventHandler(this.sliderOverscanCropLeft_Scroll);
            // 
            // sliderOverscanCropBottom
            // 
            this.sliderOverscanCropBottom.AutoSize = false;
            this.sliderOverscanCropBottom.Location = new System.Drawing.Point(8, 79);
            this.sliderOverscanCropBottom.Maximum = 100;
            this.sliderOverscanCropBottom.Name = "sliderOverscanCropBottom";
            this.sliderOverscanCropBottom.Size = new System.Drawing.Size(145, 20);
            this.sliderOverscanCropBottom.TabIndex = 8;
            this.sliderOverscanCropBottom.TickFrequency = 50;
            this.sliderOverscanCropBottom.Scroll += new System.EventHandler(this.sliderOverscanCropBottom_Scroll);
            // 
            // sliderOverscanCropTop
            // 
            this.sliderOverscanCropTop.AutoSize = false;
            this.sliderOverscanCropTop.Location = new System.Drawing.Point(8, 39);
            this.sliderOverscanCropTop.Maximum = 100;
            this.sliderOverscanCropTop.Name = "sliderOverscanCropTop";
            this.sliderOverscanCropTop.Size = new System.Drawing.Size(145, 20);
            this.sliderOverscanCropTop.TabIndex = 8;
            this.sliderOverscanCropTop.TickFrequency = 50;
            this.sliderOverscanCropTop.Scroll += new System.EventHandler(this.sliderOverscanCropTop_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(11, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Left";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(11, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Right";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(11, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Bottom";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(11, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Top";
            // 
            // numUpDownOverscanCropTop
            // 
            this.numUpDownOverscanCropTop.Location = new System.Drawing.Point(159, 39);
            this.numUpDownOverscanCropTop.Name = "numUpDownOverscanCropTop";
            this.numUpDownOverscanCropTop.Size = new System.Drawing.Size(47, 20);
            this.numUpDownOverscanCropTop.TabIndex = 3;
            this.numUpDownOverscanCropTop.ValueChanged += new System.EventHandler(this.numUpDownOverscanCropTop_ValueChanged);
            // 
            // numUpDownOverscanCropBottom
            // 
            this.numUpDownOverscanCropBottom.Location = new System.Drawing.Point(159, 79);
            this.numUpDownOverscanCropBottom.Name = "numUpDownOverscanCropBottom";
            this.numUpDownOverscanCropBottom.Size = new System.Drawing.Size(47, 20);
            this.numUpDownOverscanCropBottom.TabIndex = 2;
            this.numUpDownOverscanCropBottom.ValueChanged += new System.EventHandler(this.numUpDownOverscanCropBottom_ValueChanged);
            // 
            // numUpDownOverscanCropRight
            // 
            this.numUpDownOverscanCropRight.Location = new System.Drawing.Point(159, 159);
            this.numUpDownOverscanCropRight.Name = "numUpDownOverscanCropRight";
            this.numUpDownOverscanCropRight.Size = new System.Drawing.Size(47, 20);
            this.numUpDownOverscanCropRight.TabIndex = 1;
            this.numUpDownOverscanCropRight.ValueChanged += new System.EventHandler(this.numUpDownOverscanCropRight_ValueChanged);
            // 
            // numUpDownOverscanCropLeft
            // 
            this.numUpDownOverscanCropLeft.Location = new System.Drawing.Point(159, 119);
            this.numUpDownOverscanCropLeft.Name = "numUpDownOverscanCropLeft";
            this.numUpDownOverscanCropLeft.Size = new System.Drawing.Size(47, 20);
            this.numUpDownOverscanCropLeft.TabIndex = 0;
            this.numUpDownOverscanCropLeft.ValueChanged += new System.EventHandler(this.numUpDownOverscanCropLeft_ValueChanged);
            // 
            // overscanCropPicture
            // 
            this.overscanCropPicture.BackgroundImage = global::IntelligentFrameCorrection.Properties.Resources.joker16zu9_2;
            this.overscanCropPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.overscanCropPicture.Location = new System.Drawing.Point(260, 6);
            this.overscanCropPicture.Name = "overscanCropPicture";
            this.overscanCropPicture.Size = new System.Drawing.Size(439, 330);
            this.overscanCropPicture.TabIndex = 50;
            this.overscanCropPicture.TabStop = false;
            // 
            // lineOverscanCropTop
            // 
            this.lineOverscanCropTop.BackColor = System.Drawing.Color.Lime;
            this.lineOverscanCropTop.BorderColor = System.Drawing.Color.Lime;
            this.lineOverscanCropTop.BorderColorWidth = 3F;
            this.lineOverscanCropTop.Location = new System.Drawing.Point(259, 5);
            this.lineOverscanCropTop.Name = "lineOverscanCropTop";
            this.lineOverscanCropTop.Size = new System.Drawing.Size(439, 1);
            this.lineOverscanCropTop.TabIndex = 52;
            // 
            // tabMiscellaneous
            // 
            this.tabMiscellaneous.BackColor = System.Drawing.SystemColors.Control;
            this.tabMiscellaneous.Controls.Add(this.sliderFrameCaptureSize);
            this.tabMiscellaneous.Controls.Add(this.label21);
            this.tabMiscellaneous.Controls.Add(this.numUpDownFrameCaptureSize);
            this.tabMiscellaneous.Controls.Add(this.sliderEdgeDetectionTolerance);
            this.tabMiscellaneous.Controls.Add(this.label20);
            this.tabMiscellaneous.Controls.Add(this.numUpDownEdgeDetectionTolerance);
            this.tabMiscellaneous.Controls.Add(this.groupBox4);
            this.tabMiscellaneous.Controls.Add(this.groupBox5);
            this.tabMiscellaneous.Controls.Add(this.label6);
            this.tabMiscellaneous.Controls.Add(this.numUpDownStabilizationFactor);
            this.tabMiscellaneous.Controls.Add(this.label4);
            this.tabMiscellaneous.Controls.Add(this.sliderStabilizationTolerance);
            this.tabMiscellaneous.Controls.Add(this.numUpDownMaxBrightnessThreashold);
            this.tabMiscellaneous.Controls.Add(this.sliderStabilizationFactor);
            this.tabMiscellaneous.Controls.Add(this.label19);
            this.tabMiscellaneous.Controls.Add(this.numUpDownMinBrightnessThreashold);
            this.tabMiscellaneous.Controls.Add(this.numUpDownStabilizationTolerance);
            this.tabMiscellaneous.Controls.Add(this.label5);
            this.tabMiscellaneous.Controls.Add(this.sliderMaxBrightnessThreshold);
            this.tabMiscellaneous.Controls.Add(this.groupBox3);
            this.tabMiscellaneous.Controls.Add(this.sliderMinBrightnessThreshold);
            this.tabMiscellaneous.Controls.Add(this.ckbVideoSupport);
            this.tabMiscellaneous.Controls.Add(this.sliderDoubleBlackBarHeight);
            this.tabMiscellaneous.Controls.Add(this.sliderSingleBlackBarHeight);
            this.tabMiscellaneous.Controls.Add(this.sliderDetectionCounter);
            this.tabMiscellaneous.Controls.Add(this.sliderScanInterval);
            this.tabMiscellaneous.Controls.Add(this.ckbAutoStart);
            this.tabMiscellaneous.Controls.Add(this.ckbBlackBarScanner);
            this.tabMiscellaneous.Controls.Add(this.ckbCorrectAspectRatio);
            this.tabMiscellaneous.Controls.Add(this.ckbVerboseLogging);
            this.tabMiscellaneous.Controls.Add(this.label8);
            this.tabMiscellaneous.Controls.Add(this.label7);
            this.tabMiscellaneous.Controls.Add(this.label3);
            this.tabMiscellaneous.Controls.Add(this.label2);
            this.tabMiscellaneous.Controls.Add(this.numUpDownDoubleBlackBarHeight);
            this.tabMiscellaneous.Controls.Add(this.numUpDownSingleBlackBarHeight);
            this.tabMiscellaneous.Controls.Add(this.numUpDownDetectionCounter);
            this.tabMiscellaneous.Controls.Add(this.numUpDownScanInterval);
            this.tabMiscellaneous.Location = new System.Drawing.Point(4, 22);
            this.tabMiscellaneous.Name = "tabMiscellaneous";
            this.tabMiscellaneous.Size = new System.Drawing.Size(705, 342);
            this.tabMiscellaneous.TabIndex = 3;
            this.tabMiscellaneous.Text = "Miscellaneous";
            // 
            // sliderFrameCaptureSize
            // 
            this.sliderFrameCaptureSize.AutoSize = false;
            this.sliderFrameCaptureSize.LargeChange = 50;
            this.sliderFrameCaptureSize.Location = new System.Drawing.Point(11, 223);
            this.sliderFrameCaptureSize.Maximum = 100;
            this.sliderFrameCaptureSize.Name = "sliderFrameCaptureSize";
            this.sliderFrameCaptureSize.Size = new System.Drawing.Size(145, 20);
            this.sliderFrameCaptureSize.SmallChange = 10;
            this.sliderFrameCaptureSize.TabIndex = 24;
            this.sliderFrameCaptureSize.TickFrequency = 50;
            this.toolTip.SetToolTip(this.sliderFrameCaptureSize, "The frame capture size is the size of the current picture that will be analyzed b" +
                    "y I.F.C.\r\nThe lower the size the faster I.F.C. analyze the frame.");
            this.sliderFrameCaptureSize.Visible = false;
            this.sliderFrameCaptureSize.Scroll += new System.EventHandler(this.sliderFrameCaptureSize_Scroll);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 207);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Frame capture size";
            this.label21.Visible = false;
            // 
            // numUpDownFrameCaptureSize
            // 
            this.numUpDownFrameCaptureSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownFrameCaptureSize.Location = new System.Drawing.Point(162, 223);
            this.numUpDownFrameCaptureSize.Name = "numUpDownFrameCaptureSize";
            this.numUpDownFrameCaptureSize.Size = new System.Drawing.Size(56, 20);
            this.numUpDownFrameCaptureSize.TabIndex = 22;
            this.toolTip.SetToolTip(this.numUpDownFrameCaptureSize, "The frame capture size is the size of the current picture that will be analyzed b" +
                    "y I.F.C.\r\nThe lower the size the faster I.F.C. analyze the frame.");
            this.numUpDownFrameCaptureSize.Visible = false;
            this.numUpDownFrameCaptureSize.ValueChanged += new System.EventHandler(this.numUpDownFrameCaptureSize_ValueChanged);
            // 
            // sliderEdgeDetectionTolerance
            // 
            this.sliderEdgeDetectionTolerance.AutoSize = false;
            this.sliderEdgeDetectionTolerance.Location = new System.Drawing.Point(258, 224);
            this.sliderEdgeDetectionTolerance.Maximum = 40;
            this.sliderEdgeDetectionTolerance.Name = "sliderEdgeDetectionTolerance";
            this.sliderEdgeDetectionTolerance.Size = new System.Drawing.Size(145, 20);
            this.sliderEdgeDetectionTolerance.TabIndex = 21;
            this.sliderEdgeDetectionTolerance.TickFrequency = 20;
            this.toolTip.SetToolTip(this.sliderEdgeDetectionTolerance, "The higher the edge detection tolerance is set the faster I.F.C. detects the edge" +
                    "/transition from black bar to content.");
            this.sliderEdgeDetectionTolerance.Scroll += new System.EventHandler(this.sliderEdgeDetectionTolerance_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Edge detection  tolerance";
            // 
            // numUpDownEdgeDetectionTolerance
            // 
            this.numUpDownEdgeDetectionTolerance.Location = new System.Drawing.Point(409, 224);
            this.numUpDownEdgeDetectionTolerance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownEdgeDetectionTolerance.Name = "numUpDownEdgeDetectionTolerance";
            this.numUpDownEdgeDetectionTolerance.Size = new System.Drawing.Size(56, 20);
            this.numUpDownEdgeDetectionTolerance.TabIndex = 19;
            this.toolTip.SetToolTip(this.numUpDownEdgeDetectionTolerance, "The higher the edge detection tolerance is set the faster I.F.C. detects the edge" +
                    "/transition from black bar to content.");
            this.numUpDownEdgeDetectionTolerance.ValueChanged += new System.EventHandler(this.numericUpDownEdgeDetectionTolerance_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnOperator);
            this.groupBox4.Controls.Add(this.numUpDownHDHeight);
            this.groupBox4.Controls.Add(this.ckbHDSupport);
            this.groupBox4.Controls.Add(this.numUpDownHDWidth);
            this.groupBox4.Location = new System.Drawing.Point(498, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 111);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox4, "Enable/Disable HD analysis.\r\nIf disabled IFC won\'t analyze HD content.");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Height";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Width";
            // 
            // btnOperator
            // 
            this.btnOperator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperator.Location = new System.Drawing.Point(103, 58);
            this.btnOperator.Name = "btnOperator";
            this.btnOperator.Size = new System.Drawing.Size(56, 21);
            this.btnOperator.TabIndex = 13;
            this.btnOperator.Text = "or";
            this.btnOperator.UseVisualStyleBackColor = true;
            this.btnOperator.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // numUpDownHDHeight
            // 
            this.numUpDownHDHeight.Location = new System.Drawing.Point(103, 85);
            this.numUpDownHDHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownHDHeight.Name = "numUpDownHDHeight";
            this.numUpDownHDHeight.Size = new System.Drawing.Size(56, 20);
            this.numUpDownHDHeight.TabIndex = 11;
            this.numUpDownHDHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // ckbHDSupport
            // 
            this.ckbHDSupport.AutoSize = true;
            this.ckbHDSupport.Location = new System.Drawing.Point(11, 13);
            this.ckbHDSupport.Name = "ckbHDSupport";
            this.ckbHDSupport.Size = new System.Drawing.Size(80, 17);
            this.ckbHDSupport.TabIndex = 2;
            this.ckbHDSupport.Text = "HD support";
            this.toolTip.SetToolTip(this.ckbHDSupport, "Enable/Disable HD analysis.\r\nIf disabled IFC won\'t analyze HD content.");
            this.ckbHDSupport.UseVisualStyleBackColor = true;
            // 
            // numUpDownHDWidth
            // 
            this.numUpDownHDWidth.Location = new System.Drawing.Point(103, 32);
            this.numUpDownHDWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownHDWidth.Name = "numUpDownHDWidth";
            this.numUpDownHDWidth.Size = new System.Drawing.Size(56, 20);
            this.numUpDownHDWidth.TabIndex = 12;
            this.numUpDownHDWidth.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(488, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(2, 280);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stabilization factor";
            // 
            // numUpDownStabilizationFactor
            // 
            this.numUpDownStabilizationFactor.Location = new System.Drawing.Point(409, 133);
            this.numUpDownStabilizationFactor.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownStabilizationFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownStabilizationFactor.Name = "numUpDownStabilizationFactor";
            this.numUpDownStabilizationFactor.Size = new System.Drawing.Size(56, 20);
            this.numUpDownStabilizationFactor.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownStabilizationFactor, "The stabilizer provides a smoother cropping behavior.");
            this.numUpDownStabilizationFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownStabilizationFactor.ValueChanged += new System.EventHandler(this.numUpDownStabilizer_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max brightness threshold";
            // 
            // sliderStabilizationTolerance
            // 
            this.sliderStabilizationTolerance.AutoSize = false;
            this.sliderStabilizationTolerance.Location = new System.Drawing.Point(258, 174);
            this.sliderStabilizationTolerance.Maximum = 40;
            this.sliderStabilizationTolerance.Name = "sliderStabilizationTolerance";
            this.sliderStabilizationTolerance.Size = new System.Drawing.Size(145, 20);
            this.sliderStabilizationTolerance.TabIndex = 18;
            this.sliderStabilizationTolerance.TickFrequency = 20;
            this.toolTip.SetToolTip(this.sliderStabilizationTolerance, "The stabilizer tolerance provides a smoother cropping behavior.\r\nThe value must b" +
                    "e lower than the stabilization factor.");
            this.sliderStabilizationTolerance.Scroll += new System.EventHandler(this.sliderStabilizationTolerance_Scroll);
            // 
            // numUpDownMaxBrightnessThreashold
            // 
            this.numUpDownMaxBrightnessThreashold.Location = new System.Drawing.Point(409, 44);
            this.numUpDownMaxBrightnessThreashold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownMaxBrightnessThreashold.Name = "numUpDownMaxBrightnessThreashold";
            this.numUpDownMaxBrightnessThreashold.Size = new System.Drawing.Size(56, 20);
            this.numUpDownMaxBrightnessThreashold.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownMaxBrightnessThreashold, "The max brightness threshold is the value at which content is detected.\r\nIs the t" +
                    "hreshold value reached (at least one pixel) content was detected instantly, othe" +
                    "rwise not.\r\n0 = black\r\n255 = white");
            this.numUpDownMaxBrightnessThreashold.ValueChanged += new System.EventHandler(this.numUpDownMaxBrightnessThreashold_ValueChanged);
            // 
            // sliderStabilizationFactor
            // 
            this.sliderStabilizationFactor.AutoSize = false;
            this.sliderStabilizationFactor.Location = new System.Drawing.Point(258, 133);
            this.sliderStabilizationFactor.Maximum = 50;
            this.sliderStabilizationFactor.Minimum = 1;
            this.sliderStabilizationFactor.Name = "sliderStabilizationFactor";
            this.sliderStabilizationFactor.Size = new System.Drawing.Size(145, 20);
            this.sliderStabilizationFactor.TabIndex = 9;
            this.sliderStabilizationFactor.TickFrequency = 25;
            this.toolTip.SetToolTip(this.sliderStabilizationFactor, "The stabilizer provides a smoother cropping behavior.");
            this.sliderStabilizationFactor.Value = 1;
            this.sliderStabilizationFactor.Scroll += new System.EventHandler(this.sliderStabilizer_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Stabilization tolerance";
            // 
            // numUpDownMinBrightnessThreashold
            // 
            this.numUpDownMinBrightnessThreashold.Location = new System.Drawing.Point(409, 83);
            this.numUpDownMinBrightnessThreashold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownMinBrightnessThreashold.Name = "numUpDownMinBrightnessThreashold";
            this.numUpDownMinBrightnessThreashold.Size = new System.Drawing.Size(56, 20);
            this.numUpDownMinBrightnessThreashold.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownMinBrightnessThreashold, resources.GetString("numUpDownMinBrightnessThreashold.ToolTip"));
            this.numUpDownMinBrightnessThreashold.ValueChanged += new System.EventHandler(this.numUpDownMinBrightnessThreashold_ValueChanged);
            // 
            // numUpDownStabilizationTolerance
            // 
            this.numUpDownStabilizationTolerance.Location = new System.Drawing.Point(409, 174);
            this.numUpDownStabilizationTolerance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownStabilizationTolerance.Name = "numUpDownStabilizationTolerance";
            this.numUpDownStabilizationTolerance.Size = new System.Drawing.Size(56, 20);
            this.numUpDownStabilizationTolerance.TabIndex = 16;
            this.toolTip.SetToolTip(this.numUpDownStabilizationTolerance, "The stabilizer tolerance provides a smoother cropping behavior.\r\nThe value must b" +
                    "e lower than the stabilization factor.");
            this.numUpDownStabilizationTolerance.ValueChanged += new System.EventHandler(this.numUpDownStabilizationTolerance_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Min brightness threshold";
            // 
            // sliderMaxBrightnessThreshold
            // 
            this.sliderMaxBrightnessThreshold.AutoSize = false;
            this.sliderMaxBrightnessThreshold.Location = new System.Drawing.Point(258, 44);
            this.sliderMaxBrightnessThreshold.Maximum = 255;
            this.sliderMaxBrightnessThreshold.Name = "sliderMaxBrightnessThreshold";
            this.sliderMaxBrightnessThreshold.Size = new System.Drawing.Size(145, 20);
            this.sliderMaxBrightnessThreshold.TabIndex = 9;
            this.sliderMaxBrightnessThreshold.TickFrequency = 127;
            this.toolTip.SetToolTip(this.sliderMaxBrightnessThreshold, "The max brightness threshold is the value at which content is detected.\r\nIs the t" +
                    "hreshold value reached (at least one pixel) content was detected instantly, othe" +
                    "rwise not.\r\n0 = black\r\n255 = white");
            this.sliderMaxBrightnessThreshold.Scroll += new System.EventHandler(this.sliderMaxBrightnessThreshold_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(240, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2, 280);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // sliderMinBrightnessThreshold
            // 
            this.sliderMinBrightnessThreshold.AutoSize = false;
            this.sliderMinBrightnessThreshold.Location = new System.Drawing.Point(258, 83);
            this.sliderMinBrightnessThreshold.Maximum = 255;
            this.sliderMinBrightnessThreshold.Name = "sliderMinBrightnessThreshold";
            this.sliderMinBrightnessThreshold.Size = new System.Drawing.Size(145, 20);
            this.sliderMinBrightnessThreshold.TabIndex = 9;
            this.sliderMinBrightnessThreshold.TickFrequency = 127;
            this.toolTip.SetToolTip(this.sliderMinBrightnessThreshold, resources.GetString("sliderMinBrightnessThreshold.ToolTip"));
            this.sliderMinBrightnessThreshold.Scroll += new System.EventHandler(this.sliderMinBrightnessThreshold_Scroll);
            // 
            // ckbVideoSupport
            // 
            this.ckbVideoSupport.AutoSize = true;
            this.ckbVideoSupport.Location = new System.Drawing.Point(509, 135);
            this.ckbVideoSupport.Name = "ckbVideoSupport";
            this.ckbVideoSupport.Size = new System.Drawing.Size(91, 17);
            this.ckbVideoSupport.TabIndex = 10;
            this.ckbVideoSupport.Text = "Video support";
            this.toolTip.SetToolTip(this.ckbVideoSupport, "Enable/Disable video analysis.\r\nIf disabled IFC won\'t analyze video/DVD content.");
            this.ckbVideoSupport.UseVisualStyleBackColor = true;
            // 
            // sliderDoubleBlackBarHeight
            // 
            this.sliderDoubleBlackBarHeight.AutoSize = false;
            this.sliderDoubleBlackBarHeight.Location = new System.Drawing.Point(11, 174);
            this.sliderDoubleBlackBarHeight.Maximum = 30;
            this.sliderDoubleBlackBarHeight.Name = "sliderDoubleBlackBarHeight";
            this.sliderDoubleBlackBarHeight.Size = new System.Drawing.Size(145, 20);
            this.sliderDoubleBlackBarHeight.TabIndex = 9;
            this.sliderDoubleBlackBarHeight.TickFrequency = 15;
            this.toolTip.SetToolTip(this.sliderDoubleBlackBarHeight, "Above the double black bar height, double black bars were detected.");
            this.sliderDoubleBlackBarHeight.Scroll += new System.EventHandler(this.sliderDoubleBlackBarHeight_Scroll);
            // 
            // sliderSingleBlackBarHeight
            // 
            this.sliderSingleBlackBarHeight.AutoSize = false;
            this.sliderSingleBlackBarHeight.Location = new System.Drawing.Point(11, 134);
            this.sliderSingleBlackBarHeight.Maximum = 16;
            this.sliderSingleBlackBarHeight.Name = "sliderSingleBlackBarHeight";
            this.sliderSingleBlackBarHeight.Size = new System.Drawing.Size(145, 20);
            this.sliderSingleBlackBarHeight.TabIndex = 9;
            this.sliderSingleBlackBarHeight.TickFrequency = 8;
            this.toolTip.SetToolTip(this.sliderSingleBlackBarHeight, "Above the single black bar height, black bars were detected.");
            this.sliderSingleBlackBarHeight.Scroll += new System.EventHandler(this.sliderSingleBlackBarHeight_Scroll);
            // 
            // sliderDetectionCounter
            // 
            this.sliderDetectionCounter.AutoSize = false;
            this.sliderDetectionCounter.Location = new System.Drawing.Point(11, 82);
            this.sliderDetectionCounter.Maximum = 100;
            this.sliderDetectionCounter.Name = "sliderDetectionCounter";
            this.sliderDetectionCounter.Size = new System.Drawing.Size(145, 20);
            this.sliderDetectionCounter.TabIndex = 9;
            this.sliderDetectionCounter.TickFrequency = 50;
            this.toolTip.SetToolTip(this.sliderDetectionCounter, "After the counter was reached. I.F.C. evaluate all collected data\r\nand choose the" +
                    " best methods. If the collected data is inaccurate I.F.C. runs again\r\nuntil the " +
                    "detection counter reached again.");
            this.sliderDetectionCounter.Scroll += new System.EventHandler(this.sliderDetectionCounter_Scroll);
            // 
            // sliderScanInterval
            // 
            this.sliderScanInterval.AutoSize = false;
            this.sliderScanInterval.LargeChange = 500;
            this.sliderScanInterval.Location = new System.Drawing.Point(11, 43);
            this.sliderScanInterval.Maximum = 99999;
            this.sliderScanInterval.Name = "sliderScanInterval";
            this.sliderScanInterval.Size = new System.Drawing.Size(145, 20);
            this.sliderScanInterval.SmallChange = 100;
            this.sliderScanInterval.TabIndex = 9;
            this.sliderScanInterval.TickFrequency = 50000;
            this.toolTip.SetToolTip(this.sliderScanInterval, "Every umpteenth millisecond I.F.C analyze a frame of the playing content.");
            this.sliderScanInterval.Scroll += new System.EventHandler(this.sliderScanInterval_Scroll);
            // 
            // ckbAutoStart
            // 
            this.ckbAutoStart.AutoSize = true;
            this.ckbAutoStart.Location = new System.Drawing.Point(509, 113);
            this.ckbAutoStart.Name = "ckbAutoStart";
            this.ckbAutoStart.Size = new System.Drawing.Size(71, 17);
            this.ckbAutoStart.TabIndex = 3;
            this.ckbAutoStart.Text = "Auto start";
            this.toolTip.SetToolTip(this.ckbAutoStart, "Enable/Disable auto start.\r\nIf enabled I.F.C. starts when the player starts, othe" +
                    "rwise\r\nI.F.C. must be started manually (default shortcut is F4)");
            this.ckbAutoStart.UseVisualStyleBackColor = true;
            // 
            // ckbBlackBarScanner
            // 
            this.ckbBlackBarScanner.AutoSize = true;
            this.ckbBlackBarScanner.Location = new System.Drawing.Point(509, 89);
            this.ckbBlackBarScanner.Name = "ckbBlackBarScanner";
            this.ckbBlackBarScanner.Size = new System.Drawing.Size(112, 17);
            this.ckbBlackBarScanner.TabIndex = 3;
            this.ckbBlackBarScanner.Text = "Black bar scanner";
            this.toolTip.SetToolTip(this.ckbBlackBarScanner, "Enable/Disable the black bar scanner.\r\nIf disabled I.F.C. won\'t search for black " +
                    "bars.");
            this.ckbBlackBarScanner.UseVisualStyleBackColor = true;
            // 
            // ckbCorrectAspectRatio
            // 
            this.ckbCorrectAspectRatio.AutoSize = true;
            this.ckbCorrectAspectRatio.Location = new System.Drawing.Point(509, 66);
            this.ckbCorrectAspectRatio.Name = "ckbCorrectAspectRatio";
            this.ckbCorrectAspectRatio.Size = new System.Drawing.Size(118, 17);
            this.ckbCorrectAspectRatio.TabIndex = 3;
            this.ckbCorrectAspectRatio.Text = "Correct aspect ratio";
            this.toolTip.SetToolTip(this.ckbCorrectAspectRatio, "Crops all founded black bars, no matter of the aspect ratio.\r\n\"Egg-Heads\" could a" +
                    "ppear.");
            this.ckbCorrectAspectRatio.UseVisualStyleBackColor = true;
            // 
            // ckbVerboseLogging
            // 
            this.ckbVerboseLogging.AutoSize = true;
            this.ckbVerboseLogging.Location = new System.Drawing.Point(509, 43);
            this.ckbVerboseLogging.Name = "ckbVerboseLogging";
            this.ckbVerboseLogging.Size = new System.Drawing.Size(102, 17);
            this.ckbVerboseLogging.TabIndex = 2;
            this.ckbVerboseLogging.Text = "Verbose logging";
            this.toolTip.SetToolTip(this.ckbVerboseLogging, "Enable/Disable verbose logging. (For better debugging)");
            this.ckbVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Double black bar height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Single black bar height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detection counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scan interval";
            // 
            // numUpDownDoubleBlackBarHeight
            // 
            this.numUpDownDoubleBlackBarHeight.DecimalPlaces = 1;
            this.numUpDownDoubleBlackBarHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDownDoubleBlackBarHeight.Location = new System.Drawing.Point(162, 174);
            this.numUpDownDoubleBlackBarHeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownDoubleBlackBarHeight.Name = "numUpDownDoubleBlackBarHeight";
            this.numUpDownDoubleBlackBarHeight.Size = new System.Drawing.Size(56, 20);
            this.numUpDownDoubleBlackBarHeight.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownDoubleBlackBarHeight, "Above the double black bar height (%), double black bars were detected.");
            this.numUpDownDoubleBlackBarHeight.ValueChanged += new System.EventHandler(this.numUpDownDoubleBlackBarHeight_ValueChanged);
            // 
            // numUpDownSingleBlackBarHeight
            // 
            this.numUpDownSingleBlackBarHeight.DecimalPlaces = 1;
            this.numUpDownSingleBlackBarHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDownSingleBlackBarHeight.Location = new System.Drawing.Point(162, 134);
            this.numUpDownSingleBlackBarHeight.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numUpDownSingleBlackBarHeight.Name = "numUpDownSingleBlackBarHeight";
            this.numUpDownSingleBlackBarHeight.Size = new System.Drawing.Size(56, 20);
            this.numUpDownSingleBlackBarHeight.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownSingleBlackBarHeight, "Above the single black bar height (%), black bars were detected.");
            this.numUpDownSingleBlackBarHeight.ValueChanged += new System.EventHandler(this.numUpDownSingleBlackBarHeight_ValueChanged);
            // 
            // numUpDownDetectionCounter
            // 
            this.numUpDownDetectionCounter.Location = new System.Drawing.Point(162, 82);
            this.numUpDownDetectionCounter.Name = "numUpDownDetectionCounter";
            this.numUpDownDetectionCounter.Size = new System.Drawing.Size(56, 20);
            this.numUpDownDetectionCounter.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownDetectionCounter, "After the counter was reached. I.F.C. evaluate all collected data\r\nand choose the" +
                    " best methods. If the collected data is inaccurate I.F.C. runs again\r\nuntil the " +
                    "detection counter reached again.");
            this.numUpDownDetectionCounter.ValueChanged += new System.EventHandler(this.numUpDownDetectionCounter_ValueChanged);
            // 
            // numUpDownScanInterval
            // 
            this.numUpDownScanInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownScanInterval.Location = new System.Drawing.Point(162, 43);
            this.numUpDownScanInterval.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numUpDownScanInterval.Name = "numUpDownScanInterval";
            this.numUpDownScanInterval.Size = new System.Drawing.Size(56, 20);
            this.numUpDownScanInterval.TabIndex = 0;
            this.toolTip.SetToolTip(this.numUpDownScanInterval, "Every umpteenth millisecond I.F.C analyze a frame of the playing content.");
            this.numUpDownScanInterval.ValueChanged += new System.EventHandler(this.numUpDownScanInterval_ValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnTestAndBenchmark);
            this.tabPage1.Controls.Add(this.btnLoadSreenshot);
            this.tabPage1.Controls.Add(this.pictureBoxTestImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 342);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Test \'n Benchmark";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.ckbLeftSideBlackBar);
            this.groupBox2.Controls.Add(this.ckbRightSideBlackBar);
            this.groupBox2.Controls.Add(this.ckbBottomDoubleBlackBar);
            this.groupBox2.Controls.Add(this.ckbTopDoubleBlackBar);
            this.groupBox2.Controls.Add(this.ckbBottomSingleBlackBar);
            this.groupBox2.Controls.Add(this.ckbTopSingleBlackBar);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 215);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test results";
            this.toolTip.SetToolTip(this.groupBox2, "These test results based on your configuration settings you did.");
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(5, 196);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(71, 13);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "Speed in ms: ";
            // 
            // ckbLeftSideBlackBar
            // 
            this.ckbLeftSideBlackBar.AutoSize = true;
            this.ckbLeftSideBlackBar.Location = new System.Drawing.Point(6, 144);
            this.ckbLeftSideBlackBar.Name = "ckbLeftSideBlackBar";
            this.ckbLeftSideBlackBar.Size = new System.Drawing.Size(143, 17);
            this.ckbLeftSideBlackBar.TabIndex = 0;
            this.ckbLeftSideBlackBar.Text = "Left side black bar found";
            this.ckbLeftSideBlackBar.UseVisualStyleBackColor = true;
            // 
            // ckbRightSideBlackBar
            // 
            this.ckbRightSideBlackBar.AutoSize = true;
            this.ckbRightSideBlackBar.Location = new System.Drawing.Point(6, 121);
            this.ckbRightSideBlackBar.Name = "ckbRightSideBlackBar";
            this.ckbRightSideBlackBar.Size = new System.Drawing.Size(150, 17);
            this.ckbRightSideBlackBar.TabIndex = 0;
            this.ckbRightSideBlackBar.Text = "Right side black bar found";
            this.ckbRightSideBlackBar.UseVisualStyleBackColor = true;
            // 
            // ckbBottomDoubleBlackBar
            // 
            this.ckbBottomDoubleBlackBar.AutoSize = true;
            this.ckbBottomDoubleBlackBar.Location = new System.Drawing.Point(6, 98);
            this.ckbBottomDoubleBlackBar.Name = "ckbBottomDoubleBlackBar";
            this.ckbBottomDoubleBlackBar.Size = new System.Drawing.Size(171, 17);
            this.ckbBottomDoubleBlackBar.TabIndex = 0;
            this.ckbBottomDoubleBlackBar.Text = "Bottom double black bar found";
            this.ckbBottomDoubleBlackBar.UseVisualStyleBackColor = true;
            // 
            // ckbTopDoubleBlackBar
            // 
            this.ckbTopDoubleBlackBar.AutoSize = true;
            this.ckbTopDoubleBlackBar.Location = new System.Drawing.Point(6, 75);
            this.ckbTopDoubleBlackBar.Name = "ckbTopDoubleBlackBar";
            this.ckbTopDoubleBlackBar.Size = new System.Drawing.Size(187, 17);
            this.ckbTopDoubleBlackBar.TabIndex = 0;
            this.ckbTopDoubleBlackBar.Text = "Top double single black bar found";
            this.ckbTopDoubleBlackBar.UseVisualStyleBackColor = true;
            // 
            // ckbBottomSingleBlackBar
            // 
            this.ckbBottomSingleBlackBar.AutoSize = true;
            this.ckbBottomSingleBlackBar.Location = new System.Drawing.Point(6, 52);
            this.ckbBottomSingleBlackBar.Name = "ckbBottomSingleBlackBar";
            this.ckbBottomSingleBlackBar.Size = new System.Drawing.Size(166, 17);
            this.ckbBottomSingleBlackBar.TabIndex = 0;
            this.ckbBottomSingleBlackBar.Text = "Bottom single black bar found";
            this.ckbBottomSingleBlackBar.UseVisualStyleBackColor = true;
            // 
            // ckbTopSingleBlackBar
            // 
            this.ckbTopSingleBlackBar.AutoSize = true;
            this.ckbTopSingleBlackBar.Location = new System.Drawing.Point(6, 29);
            this.ckbTopSingleBlackBar.Name = "ckbTopSingleBlackBar";
            this.ckbTopSingleBlackBar.Size = new System.Drawing.Size(152, 17);
            this.ckbTopSingleBlackBar.TabIndex = 0;
            this.ckbTopSingleBlackBar.Text = "Top single black bar found";
            this.ckbTopSingleBlackBar.UseVisualStyleBackColor = true;
            // 
            // btnTestAndBenchmark
            // 
            this.btnTestAndBenchmark.Enabled = false;
            this.btnTestAndBenchmark.Location = new System.Drawing.Point(47, 63);
            this.btnTestAndBenchmark.Name = "btnTestAndBenchmark";
            this.btnTestAndBenchmark.Size = new System.Drawing.Size(148, 23);
            this.btnTestAndBenchmark.TabIndex = 2;
            this.btnTestAndBenchmark.Text = "2. Test your screenshot";
            this.btnTestAndBenchmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestAndBenchmark.UseVisualStyleBackColor = true;
            this.btnTestAndBenchmark.Click += new System.EventHandler(this.btnTestAndBenchmark_Click);
            // 
            // btnLoadSreenshot
            // 
            this.btnLoadSreenshot.Location = new System.Drawing.Point(47, 34);
            this.btnLoadSreenshot.Name = "btnLoadSreenshot";
            this.btnLoadSreenshot.Size = new System.Drawing.Size(148, 23);
            this.btnLoadSreenshot.TabIndex = 2;
            this.btnLoadSreenshot.Text = "1. Choose your screenshot";
            this.btnLoadSreenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSreenshot.UseVisualStyleBackColor = true;
            this.btnLoadSreenshot.Click += new System.EventHandler(this.btnLoadSreenshot_Click);
            // 
            // pictureBoxTestImage
            // 
            this.pictureBoxTestImage.BackgroundImage = global::IntelligentFrameCorrection.Properties.Resources.joker16zu9_2;
            this.pictureBoxTestImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTestImage.Location = new System.Drawing.Point(260, 6);
            this.pictureBoxTestImage.Name = "pictureBoxTestImage";
            this.pictureBoxTestImage.Size = new System.Drawing.Size(439, 330);
            this.pictureBoxTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTestImage.TabIndex = 1;
            this.pictureBoxTestImage.TabStop = false;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Information";
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "General";
            this.Size = new System.Drawing.Size(720, 375);
            this.Load += new System.EventHandler(this.General_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabAdvancedViewMode.ResumeLayout(false);
            this.grpBoxAdjustViewMode.ResumeLayout(false);
            this.grpBoxAdjustViewMode.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRightZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLeftZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBottomZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTopZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBottomZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRightZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftZoom)).EndInit();
            this.tabScanArea.ResumeLayout(false);
            this.grpBoxBlackArea.ResumeLayout(false);
            this.grpBoxBlackArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanAreaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAreaUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanAreaPicture)).EndInit();
            this.tabOverscan.ResumeLayout(false);
            this.grpBoxOverscanCrop.ResumeLayout(false);
            this.grpBoxOverscanCrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOverscanCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOverscanCropLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overscanCropPicture)).EndInit();
            this.tabMiscellaneous.ResumeLayout(false);
            this.tabMiscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFrameCaptureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFrameCaptureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderEdgeDetectionTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdgeDetectionTolerance)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHDHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHDWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStabilizationFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStabilizationTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxBrightnessThreashold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStabilizationFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinBrightnessThreashold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStabilizationTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMaxBrightnessThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMinBrightnessThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDoubleBlackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSingleBlackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDetectionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScanInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDoubleBlackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSingleBlackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDetectionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownScanInterval)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTestImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAdvancedViewMode;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabScanArea;
        private System.Windows.Forms.TabPage tabMiscellaneous;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox grpBoxBlackArea;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown BlackAreaUpDownHeight;
        private System.Windows.Forms.NumericUpDown BlackAreaUpDownWidth;
        private System.Windows.Forms.NumericUpDown BlackAreaUpDownY;
        private System.Windows.Forms.NumericUpDown BlackAreaUpDownX;
        private System.Windows.Forms.GroupBox grpBoxAdjustViewMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.RadioButton rdb4to3;
        internal System.Windows.Forms.RadioButton rdb21to9;
        internal System.Windows.Forms.RadioButton rdb16to9;
        internal System.Windows.Forms.NumericUpDown numUpDownMinBrightnessThreashold;
        internal System.Windows.Forms.NumericUpDown numUpDownMaxBrightnessThreashold;
        internal System.Windows.Forms.NumericUpDown numUpDownDetectionCounter;
        internal System.Windows.Forms.NumericUpDown numUpDownScanInterval;
        internal System.Windows.Forms.NumericUpDown numUpDownSingleBlackBarHeight;
        internal System.Windows.Forms.NumericUpDown numUpDownStabilizationFactor;
        internal System.Windows.Forms.NumericUpDown numUpDownDoubleBlackBarHeight;
        internal System.Windows.Forms.CheckBox ckbBlackBarScanner;
        internal System.Windows.Forms.CheckBox ckbCorrectAspectRatio;
        internal System.Windows.Forms.CheckBox ckbVerboseLogging;
        internal System.Windows.Forms.CheckBox ckbAutoStart;
        internal System.Windows.Forms.ListView listViewScanArea;
        internal Controls.ColoredPanel TopScanArea;
        internal Controls.ColoredPanel BottomScanArea;
        internal Controls.ColoredPanel RightScanArea;
        internal Controls.ColoredPanel LeftScanArea;
        internal System.Windows.Forms.PictureBox scanAreaPicture;
        internal System.Windows.Forms.ListView listViewAdvancedViewMode;
        internal System.Windows.Forms.ComboBox cmbboxViewModes;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TrackBar sliderScanAreaHeight;
        private System.Windows.Forms.TrackBar sliderScanAreaY;
        private System.Windows.Forms.TrackBar sliderScanAreaX;
        private System.Windows.Forms.TrackBar sliderScanAreaWidth;
        private System.Windows.Forms.TrackBar sliderRightZoom;
        private System.Windows.Forms.TrackBar sliderLeftZoom;
        private System.Windows.Forms.TrackBar sliderBottomZoom;
        private System.Windows.Forms.TrackBar sliderTopZoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTopZoom;
        private System.Windows.Forms.NumericUpDown numBottomZoom;
        private System.Windows.Forms.NumericUpDown numRightZoom;
        private System.Windows.Forms.NumericUpDown numLeftZoom;
        private System.Windows.Forms.TabPage tabOverscan;
        internal Controls.ColoredPanel lineOverscanCropBottom;
        internal Controls.ColoredPanel lineOverscanCropLeft;
        internal Controls.ColoredPanel lineOverscanCropRight;
        private System.Windows.Forms.GroupBox grpBoxOverscanCrop;
        private System.Windows.Forms.TrackBar sliderOverscanCropRight;
        private System.Windows.Forms.TrackBar sliderOverscanCropLeft;
        private System.Windows.Forms.TrackBar sliderOverscanCropBottom;
        private System.Windows.Forms.TrackBar sliderOverscanCropTop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.NumericUpDown numUpDownOverscanCropTop;
        internal System.Windows.Forms.NumericUpDown numUpDownOverscanCropBottom;
        internal System.Windows.Forms.NumericUpDown numUpDownOverscanCropRight;
        internal System.Windows.Forms.NumericUpDown numUpDownOverscanCropLeft;
        internal System.Windows.Forms.PictureBox overscanCropPicture;
        internal Controls.ColoredPanel lineOverscanCropTop;
        private System.Windows.Forms.TrackBar sliderDoubleBlackBarHeight;
        private System.Windows.Forms.TrackBar sliderSingleBlackBarHeight;
        private System.Windows.Forms.TrackBar sliderStabilizationFactor;
        private System.Windows.Forms.TrackBar sliderMinBrightnessThreshold;
        private System.Windows.Forms.TrackBar sliderMaxBrightnessThreshold;
        private System.Windows.Forms.TrackBar sliderDetectionCounter;
        private System.Windows.Forms.TrackBar sliderScanInterval;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.CheckBox ckbHDSupport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTestAndBenchmark;
        private System.Windows.Forms.Button btnLoadSreenshot;
        internal System.Windows.Forms.PictureBox pictureBoxTestImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbLeftSideBlackBar;
        private System.Windows.Forms.CheckBox ckbRightSideBlackBar;
        private System.Windows.Forms.CheckBox ckbBottomDoubleBlackBar;
        private System.Windows.Forms.CheckBox ckbTopDoubleBlackBar;
        private System.Windows.Forms.CheckBox ckbBottomSingleBlackBar;
        private System.Windows.Forms.CheckBox ckbTopSingleBlackBar;
        private System.Windows.Forms.Label lblSpeed;
        internal System.Windows.Forms.NumericUpDown numUpDownHDWidth;
        internal System.Windows.Forms.NumericUpDown numUpDownHDHeight;
        internal System.Windows.Forms.CheckBox ckbVideoSupport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnOperator;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar sliderStabilizationTolerance;
        private System.Windows.Forms.Label label19;
        internal System.Windows.Forms.NumericUpDown numUpDownStabilizationTolerance;
        private System.Windows.Forms.TrackBar sliderEdgeDetectionTolerance;
        private System.Windows.Forms.Label label20;
        internal System.Windows.Forms.NumericUpDown numUpDownEdgeDetectionTolerance;
        private System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.CheckBox ckbUseZoomFactorOnly;
        private System.Windows.Forms.TrackBar sliderFrameCaptureSize;
        private System.Windows.Forms.Label label21;
        internal System.Windows.Forms.NumericUpDown numUpDownFrameCaptureSize;


    }
}
