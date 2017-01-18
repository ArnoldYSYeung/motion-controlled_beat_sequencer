namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comPortDropDown = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.orientLabel = new System.Windows.Forms.Label();
            this.bufferBox = new System.Windows.Forms.TextBox();
            this.orientBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unreadButton = new System.Windows.Forms.RadioButton();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.zBox = new System.Windows.Forms.TextBox();
            this.xAvgBox = new System.Windows.Forms.TextBox();
            this.yAvgBox = new System.Windows.Forms.TextBox();
            this.zAvgBox = new System.Windows.Forms.TextBox();
            this.gestureLstBox = new System.Windows.Forms.ListBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.xDiffBox = new System.Windows.Forms.TextBox();
            this.yDiffBox = new System.Windows.Forms.TextBox();
            this.zDiffBox = new System.Windows.Forms.TextBox();
            this.orientPicBox = new System.Windows.Forms.PictureBox();
            this.hihatPanel0 = new System.Windows.Forms.TextBox();
            this.snarePanel0 = new System.Windows.Forms.TextBox();
            this.kickPanel0 = new System.Windows.Forms.TextBox();
            this.gunPanel0 = new System.Windows.Forms.TextBox();
            this.alertPanel0 = new System.Windows.Forms.TextBox();
            this.closedhatPanel0 = new System.Windows.Forms.TextBox();
            this.gunPanel1 = new System.Windows.Forms.TextBox();
            this.alertPanel1 = new System.Windows.Forms.TextBox();
            this.closedhatPanel1 = new System.Windows.Forms.TextBox();
            this.hihatPanel1 = new System.Windows.Forms.TextBox();
            this.snarePanel1 = new System.Windows.Forms.TextBox();
            this.kickPanel1 = new System.Windows.Forms.TextBox();
            this.gunPanel2 = new System.Windows.Forms.TextBox();
            this.alertPanel2 = new System.Windows.Forms.TextBox();
            this.closedhatPanel2 = new System.Windows.Forms.TextBox();
            this.hihatPanel2 = new System.Windows.Forms.TextBox();
            this.snarePanel2 = new System.Windows.Forms.TextBox();
            this.kickPanel2 = new System.Windows.Forms.TextBox();
            this.gunPanel3 = new System.Windows.Forms.TextBox();
            this.alertPanel3 = new System.Windows.Forms.TextBox();
            this.closedhatPanel3 = new System.Windows.Forms.TextBox();
            this.hihatPanel3 = new System.Windows.Forms.TextBox();
            this.snarePanel3 = new System.Windows.Forms.TextBox();
            this.kickPanel3 = new System.Windows.Forms.TextBox();
            this.gunPanel4 = new System.Windows.Forms.TextBox();
            this.alertPanel4 = new System.Windows.Forms.TextBox();
            this.closedhatPanel4 = new System.Windows.Forms.TextBox();
            this.hihatPanel4 = new System.Windows.Forms.TextBox();
            this.snarePanel4 = new System.Windows.Forms.TextBox();
            this.kickPanel4 = new System.Windows.Forms.TextBox();
            this.gunPanel5 = new System.Windows.Forms.TextBox();
            this.alertPanel5 = new System.Windows.Forms.TextBox();
            this.closedhatPanel5 = new System.Windows.Forms.TextBox();
            this.hihatPanel5 = new System.Windows.Forms.TextBox();
            this.snarePanel5 = new System.Windows.Forms.TextBox();
            this.kickPanel5 = new System.Windows.Forms.TextBox();
            this.gunPanel6 = new System.Windows.Forms.TextBox();
            this.alertPanel6 = new System.Windows.Forms.TextBox();
            this.closedhatPanel6 = new System.Windows.Forms.TextBox();
            this.hihatPanel6 = new System.Windows.Forms.TextBox();
            this.snarePanel6 = new System.Windows.Forms.TextBox();
            this.kickPanel6 = new System.Windows.Forms.TextBox();
            this.gunPanel7 = new System.Windows.Forms.TextBox();
            this.alertPanel7 = new System.Windows.Forms.TextBox();
            this.closedhatPanel7 = new System.Windows.Forms.TextBox();
            this.hihatPanel7 = new System.Windows.Forms.TextBox();
            this.snarePanel7 = new System.Windows.Forms.TextBox();
            this.kickPanel7 = new System.Windows.Forms.TextBox();
            this.beat0Button = new System.Windows.Forms.Button();
            this.beat1Button = new System.Windows.Forms.Button();
            this.beat2Button = new System.Windows.Forms.Button();
            this.beat3Button = new System.Windows.Forms.Button();
            this.beat4Button = new System.Windows.Forms.Button();
            this.beat5Button = new System.Windows.Forms.Button();
            this.beat6Button = new System.Windows.Forms.Button();
            this.beat8Button = new System.Windows.Forms.Button();
            this.kickLabel = new System.Windows.Forms.Label();
            this.snareLabel = new System.Windows.Forms.Label();
            this.hihatLabel = new System.Windows.Forms.Label();
            this.closedhatLabel = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.gunLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 128000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comPortDropDown
            // 
            this.comPortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortDropDown.FormattingEnabled = true;
            this.comPortDropDown.Location = new System.Drawing.Point(13, 13);
            this.comPortDropDown.Name = "comPortDropDown";
            this.comPortDropDown.Size = new System.Drawing.Size(154, 28);
            this.comPortDropDown.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(183, 7);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(115, 39);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(12, 55);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(51, 20);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X axis";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(165, 55);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(51, 20);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y axis";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(324, 55);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(50, 20);
            this.zLabel.TabIndex = 4;
            this.zLabel.Text = "Z axis";
            // 
            // bufferLabel
            // 
            this.bufferLabel.AutoSize = true;
            this.bufferLabel.Location = new System.Drawing.Point(12, 487);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(88, 20);
            this.bufferLabel.TabIndex = 8;
            this.bufferLabel.Text = "Buffer Size";
            // 
            // orientLabel
            // 
            this.orientLabel.AutoSize = true;
            this.orientLabel.Location = new System.Drawing.Point(14, 181);
            this.orientLabel.Name = "orientLabel";
            this.orientLabel.Size = new System.Drawing.Size(87, 20);
            this.orientLabel.TabIndex = 9;
            this.orientLabel.Text = "Orientation";
            // 
            // bufferBox
            // 
            this.bufferBox.Location = new System.Drawing.Point(103, 484);
            this.bufferBox.Name = "bufferBox";
            this.bufferBox.ReadOnly = true;
            this.bufferBox.Size = new System.Drawing.Size(113, 26);
            this.bufferBox.TabIndex = 10;
            // 
            // orientBox
            // 
            this.orientBox.Location = new System.Drawing.Point(107, 178);
            this.orientBox.Name = "orientBox";
            this.orientBox.ReadOnly = true;
            this.orientBox.Size = new System.Drawing.Size(247, 26);
            this.orientBox.TabIndex = 11;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(328, 12);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(537, 26);
            this.statusBox.TabIndex = 12;
            // 
            // readButton
            // 
            this.readButton.AutoSize = true;
            this.readButton.Location = new System.Drawing.Point(6, 25);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(112, 24);
            this.readButton.TabIndex = 13;
            this.readButton.Text = "Read Data";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unreadButton);
            this.groupBox1.Controls.Add(this.readButton);
            this.groupBox1.Location = new System.Drawing.Point(665, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Data?";
            // 
            // unreadButton
            // 
            this.unreadButton.AutoSize = true;
            this.unreadButton.Checked = true;
            this.unreadButton.Location = new System.Drawing.Point(6, 55);
            this.unreadButton.Name = "unreadButton";
            this.unreadButton.Size = new System.Drawing.Size(171, 24);
            this.unreadButton.TabIndex = 14;
            this.unreadButton.TabStop = true;
            this.unreadButton.Text = "Stop Reading Data";
            this.unreadButton.UseVisualStyleBackColor = true;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(16, 81);
            this.xBox.Name = "xBox";
            this.xBox.ReadOnly = true;
            this.xBox.Size = new System.Drawing.Size(116, 26);
            this.xBox.TabIndex = 15;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(169, 81);
            this.yBox.Name = "yBox";
            this.yBox.ReadOnly = true;
            this.yBox.Size = new System.Drawing.Size(116, 26);
            this.yBox.TabIndex = 16;
            // 
            // zBox
            // 
            this.zBox.Location = new System.Drawing.Point(328, 81);
            this.zBox.Name = "zBox";
            this.zBox.ReadOnly = true;
            this.zBox.Size = new System.Drawing.Size(116, 26);
            this.zBox.TabIndex = 17;
            // 
            // xAvgBox
            // 
            this.xAvgBox.Location = new System.Drawing.Point(16, 108);
            this.xAvgBox.Name = "xAvgBox";
            this.xAvgBox.ReadOnly = true;
            this.xAvgBox.Size = new System.Drawing.Size(116, 26);
            this.xAvgBox.TabIndex = 18;
            // 
            // yAvgBox
            // 
            this.yAvgBox.Location = new System.Drawing.Point(169, 108);
            this.yAvgBox.Name = "yAvgBox";
            this.yAvgBox.ReadOnly = true;
            this.yAvgBox.Size = new System.Drawing.Size(116, 26);
            this.yAvgBox.TabIndex = 19;
            // 
            // zAvgBox
            // 
            this.zAvgBox.Location = new System.Drawing.Point(328, 108);
            this.zAvgBox.Name = "zAvgBox";
            this.zAvgBox.ReadOnly = true;
            this.zAvgBox.Size = new System.Drawing.Size(116, 26);
            this.zAvgBox.TabIndex = 20;
            // 
            // gestureLstBox
            // 
            this.gestureLstBox.FormattingEnabled = true;
            this.gestureLstBox.ItemHeight = 20;
            this.gestureLstBox.Location = new System.Drawing.Point(370, 178);
            this.gestureLstBox.Name = "gestureLstBox";
            this.gestureLstBox.Size = new System.Drawing.Size(142, 284);
            this.gestureLstBox.TabIndex = 21;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(468, 80);
            this.stateBox.Name = "stateBox";
            this.stateBox.ReadOnly = true;
            this.stateBox.Size = new System.Drawing.Size(158, 26);
            this.stateBox.TabIndex = 22;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(464, 55);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(48, 20);
            this.stateLabel.TabIndex = 23;
            this.stateLabel.Text = "State";
            // 
            // xDiffBox
            // 
            this.xDiffBox.Location = new System.Drawing.Point(16, 135);
            this.xDiffBox.Name = "xDiffBox";
            this.xDiffBox.ReadOnly = true;
            this.xDiffBox.Size = new System.Drawing.Size(116, 26);
            this.xDiffBox.TabIndex = 24;
            // 
            // yDiffBox
            // 
            this.yDiffBox.Location = new System.Drawing.Point(169, 135);
            this.yDiffBox.Name = "yDiffBox";
            this.yDiffBox.ReadOnly = true;
            this.yDiffBox.Size = new System.Drawing.Size(116, 26);
            this.yDiffBox.TabIndex = 25;
            // 
            // zDiffBox
            // 
            this.zDiffBox.Location = new System.Drawing.Point(328, 135);
            this.zDiffBox.Name = "zDiffBox";
            this.zDiffBox.ReadOnly = true;
            this.zDiffBox.Size = new System.Drawing.Size(116, 26);
            this.zDiffBox.TabIndex = 26;
            // 
            // orientPicBox
            // 
            this.orientPicBox.Location = new System.Drawing.Point(18, 222);
            this.orientPicBox.Name = "orientPicBox";
            this.orientPicBox.Size = new System.Drawing.Size(336, 232);
            this.orientPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.orientPicBox.TabIndex = 27;
            this.orientPicBox.TabStop = false;
            // 
            // hihatPanel0
            // 
            this.hihatPanel0.Location = new System.Drawing.Point(535, 299);
            this.hihatPanel0.Name = "hihatPanel0";
            this.hihatPanel0.ReadOnly = true;
            this.hihatPanel0.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel0.TabIndex = 30;
            // 
            // snarePanel0
            // 
            this.snarePanel0.Location = new System.Drawing.Point(535, 272);
            this.snarePanel0.Name = "snarePanel0";
            this.snarePanel0.ReadOnly = true;
            this.snarePanel0.Size = new System.Drawing.Size(35, 26);
            this.snarePanel0.TabIndex = 29;
            // 
            // kickPanel0
            // 
            this.kickPanel0.BackColor = System.Drawing.SystemColors.Control;
            this.kickPanel0.Location = new System.Drawing.Point(535, 245);
            this.kickPanel0.Name = "kickPanel0";
            this.kickPanel0.ReadOnly = true;
            this.kickPanel0.Size = new System.Drawing.Size(35, 26);
            this.kickPanel0.TabIndex = 28;
            // 
            // gunPanel0
            // 
            this.gunPanel0.Location = new System.Drawing.Point(535, 380);
            this.gunPanel0.Name = "gunPanel0";
            this.gunPanel0.ReadOnly = true;
            this.gunPanel0.Size = new System.Drawing.Size(35, 26);
            this.gunPanel0.TabIndex = 33;
            // 
            // alertPanel0
            // 
            this.alertPanel0.Location = new System.Drawing.Point(535, 353);
            this.alertPanel0.Name = "alertPanel0";
            this.alertPanel0.ReadOnly = true;
            this.alertPanel0.Size = new System.Drawing.Size(35, 26);
            this.alertPanel0.TabIndex = 32;
            // 
            // closedhatPanel0
            // 
            this.closedhatPanel0.Location = new System.Drawing.Point(535, 326);
            this.closedhatPanel0.Name = "closedhatPanel0";
            this.closedhatPanel0.ReadOnly = true;
            this.closedhatPanel0.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel0.TabIndex = 31;
            // 
            // gunPanel1
            // 
            this.gunPanel1.Location = new System.Drawing.Point(576, 380);
            this.gunPanel1.Name = "gunPanel1";
            this.gunPanel1.ReadOnly = true;
            this.gunPanel1.Size = new System.Drawing.Size(35, 26);
            this.gunPanel1.TabIndex = 39;
            // 
            // alertPanel1
            // 
            this.alertPanel1.Location = new System.Drawing.Point(576, 353);
            this.alertPanel1.Name = "alertPanel1";
            this.alertPanel1.ReadOnly = true;
            this.alertPanel1.Size = new System.Drawing.Size(35, 26);
            this.alertPanel1.TabIndex = 38;
            // 
            // closedhatPanel1
            // 
            this.closedhatPanel1.Location = new System.Drawing.Point(576, 326);
            this.closedhatPanel1.Name = "closedhatPanel1";
            this.closedhatPanel1.ReadOnly = true;
            this.closedhatPanel1.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel1.TabIndex = 37;
            // 
            // hihatPanel1
            // 
            this.hihatPanel1.Location = new System.Drawing.Point(576, 299);
            this.hihatPanel1.Name = "hihatPanel1";
            this.hihatPanel1.ReadOnly = true;
            this.hihatPanel1.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel1.TabIndex = 36;
            // 
            // snarePanel1
            // 
            this.snarePanel1.Location = new System.Drawing.Point(576, 272);
            this.snarePanel1.Name = "snarePanel1";
            this.snarePanel1.ReadOnly = true;
            this.snarePanel1.Size = new System.Drawing.Size(35, 26);
            this.snarePanel1.TabIndex = 35;
            // 
            // kickPanel1
            // 
            this.kickPanel1.Location = new System.Drawing.Point(576, 245);
            this.kickPanel1.Name = "kickPanel1";
            this.kickPanel1.ReadOnly = true;
            this.kickPanel1.Size = new System.Drawing.Size(35, 26);
            this.kickPanel1.TabIndex = 34;
            // 
            // gunPanel2
            // 
            this.gunPanel2.Location = new System.Drawing.Point(617, 380);
            this.gunPanel2.Name = "gunPanel2";
            this.gunPanel2.ReadOnly = true;
            this.gunPanel2.Size = new System.Drawing.Size(35, 26);
            this.gunPanel2.TabIndex = 45;
            // 
            // alertPanel2
            // 
            this.alertPanel2.Location = new System.Drawing.Point(617, 353);
            this.alertPanel2.Name = "alertPanel2";
            this.alertPanel2.ReadOnly = true;
            this.alertPanel2.Size = new System.Drawing.Size(35, 26);
            this.alertPanel2.TabIndex = 44;
            // 
            // closedhatPanel2
            // 
            this.closedhatPanel2.Location = new System.Drawing.Point(617, 326);
            this.closedhatPanel2.Name = "closedhatPanel2";
            this.closedhatPanel2.ReadOnly = true;
            this.closedhatPanel2.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel2.TabIndex = 43;
            // 
            // hihatPanel2
            // 
            this.hihatPanel2.Location = new System.Drawing.Point(617, 299);
            this.hihatPanel2.Name = "hihatPanel2";
            this.hihatPanel2.ReadOnly = true;
            this.hihatPanel2.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel2.TabIndex = 42;
            // 
            // snarePanel2
            // 
            this.snarePanel2.Location = new System.Drawing.Point(617, 272);
            this.snarePanel2.Name = "snarePanel2";
            this.snarePanel2.ReadOnly = true;
            this.snarePanel2.Size = new System.Drawing.Size(35, 26);
            this.snarePanel2.TabIndex = 41;
            // 
            // kickPanel2
            // 
            this.kickPanel2.Location = new System.Drawing.Point(617, 245);
            this.kickPanel2.Name = "kickPanel2";
            this.kickPanel2.ReadOnly = true;
            this.kickPanel2.Size = new System.Drawing.Size(35, 26);
            this.kickPanel2.TabIndex = 40;
            // 
            // gunPanel3
            // 
            this.gunPanel3.Location = new System.Drawing.Point(658, 380);
            this.gunPanel3.Name = "gunPanel3";
            this.gunPanel3.ReadOnly = true;
            this.gunPanel3.Size = new System.Drawing.Size(35, 26);
            this.gunPanel3.TabIndex = 51;
            // 
            // alertPanel3
            // 
            this.alertPanel3.Location = new System.Drawing.Point(658, 353);
            this.alertPanel3.Name = "alertPanel3";
            this.alertPanel3.ReadOnly = true;
            this.alertPanel3.Size = new System.Drawing.Size(35, 26);
            this.alertPanel3.TabIndex = 50;
            // 
            // closedhatPanel3
            // 
            this.closedhatPanel3.Location = new System.Drawing.Point(658, 326);
            this.closedhatPanel3.Name = "closedhatPanel3";
            this.closedhatPanel3.ReadOnly = true;
            this.closedhatPanel3.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel3.TabIndex = 49;
            // 
            // hihatPanel3
            // 
            this.hihatPanel3.Location = new System.Drawing.Point(658, 299);
            this.hihatPanel3.Name = "hihatPanel3";
            this.hihatPanel3.ReadOnly = true;
            this.hihatPanel3.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel3.TabIndex = 48;
            // 
            // snarePanel3
            // 
            this.snarePanel3.Location = new System.Drawing.Point(658, 272);
            this.snarePanel3.Name = "snarePanel3";
            this.snarePanel3.ReadOnly = true;
            this.snarePanel3.Size = new System.Drawing.Size(35, 26);
            this.snarePanel3.TabIndex = 47;
            // 
            // kickPanel3
            // 
            this.kickPanel3.Location = new System.Drawing.Point(658, 245);
            this.kickPanel3.Name = "kickPanel3";
            this.kickPanel3.ReadOnly = true;
            this.kickPanel3.Size = new System.Drawing.Size(35, 26);
            this.kickPanel3.TabIndex = 46;
            // 
            // gunPanel4
            // 
            this.gunPanel4.Location = new System.Drawing.Point(724, 380);
            this.gunPanel4.Name = "gunPanel4";
            this.gunPanel4.ReadOnly = true;
            this.gunPanel4.Size = new System.Drawing.Size(35, 26);
            this.gunPanel4.TabIndex = 57;
            // 
            // alertPanel4
            // 
            this.alertPanel4.Location = new System.Drawing.Point(724, 353);
            this.alertPanel4.Name = "alertPanel4";
            this.alertPanel4.ReadOnly = true;
            this.alertPanel4.Size = new System.Drawing.Size(35, 26);
            this.alertPanel4.TabIndex = 56;
            // 
            // closedhatPanel4
            // 
            this.closedhatPanel4.Location = new System.Drawing.Point(724, 326);
            this.closedhatPanel4.Name = "closedhatPanel4";
            this.closedhatPanel4.ReadOnly = true;
            this.closedhatPanel4.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel4.TabIndex = 55;
            // 
            // hihatPanel4
            // 
            this.hihatPanel4.Location = new System.Drawing.Point(724, 299);
            this.hihatPanel4.Name = "hihatPanel4";
            this.hihatPanel4.ReadOnly = true;
            this.hihatPanel4.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel4.TabIndex = 54;
            // 
            // snarePanel4
            // 
            this.snarePanel4.Location = new System.Drawing.Point(724, 272);
            this.snarePanel4.Name = "snarePanel4";
            this.snarePanel4.ReadOnly = true;
            this.snarePanel4.Size = new System.Drawing.Size(35, 26);
            this.snarePanel4.TabIndex = 53;
            // 
            // kickPanel4
            // 
            this.kickPanel4.Location = new System.Drawing.Point(724, 245);
            this.kickPanel4.Name = "kickPanel4";
            this.kickPanel4.ReadOnly = true;
            this.kickPanel4.Size = new System.Drawing.Size(35, 26);
            this.kickPanel4.TabIndex = 52;
            // 
            // gunPanel5
            // 
            this.gunPanel5.Location = new System.Drawing.Point(765, 380);
            this.gunPanel5.Name = "gunPanel5";
            this.gunPanel5.ReadOnly = true;
            this.gunPanel5.Size = new System.Drawing.Size(35, 26);
            this.gunPanel5.TabIndex = 63;
            // 
            // alertPanel5
            // 
            this.alertPanel5.Location = new System.Drawing.Point(765, 353);
            this.alertPanel5.Name = "alertPanel5";
            this.alertPanel5.ReadOnly = true;
            this.alertPanel5.Size = new System.Drawing.Size(35, 26);
            this.alertPanel5.TabIndex = 62;
            // 
            // closedhatPanel5
            // 
            this.closedhatPanel5.Location = new System.Drawing.Point(765, 326);
            this.closedhatPanel5.Name = "closedhatPanel5";
            this.closedhatPanel5.ReadOnly = true;
            this.closedhatPanel5.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel5.TabIndex = 61;
            // 
            // hihatPanel5
            // 
            this.hihatPanel5.Location = new System.Drawing.Point(765, 299);
            this.hihatPanel5.Name = "hihatPanel5";
            this.hihatPanel5.ReadOnly = true;
            this.hihatPanel5.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel5.TabIndex = 60;
            // 
            // snarePanel5
            // 
            this.snarePanel5.Location = new System.Drawing.Point(765, 272);
            this.snarePanel5.Name = "snarePanel5";
            this.snarePanel5.ReadOnly = true;
            this.snarePanel5.Size = new System.Drawing.Size(35, 26);
            this.snarePanel5.TabIndex = 59;
            // 
            // kickPanel5
            // 
            this.kickPanel5.Location = new System.Drawing.Point(765, 245);
            this.kickPanel5.Name = "kickPanel5";
            this.kickPanel5.ReadOnly = true;
            this.kickPanel5.Size = new System.Drawing.Size(35, 26);
            this.kickPanel5.TabIndex = 58;
            // 
            // gunPanel6
            // 
            this.gunPanel6.Location = new System.Drawing.Point(806, 380);
            this.gunPanel6.Name = "gunPanel6";
            this.gunPanel6.ReadOnly = true;
            this.gunPanel6.Size = new System.Drawing.Size(35, 26);
            this.gunPanel6.TabIndex = 69;
            // 
            // alertPanel6
            // 
            this.alertPanel6.Location = new System.Drawing.Point(806, 353);
            this.alertPanel6.Name = "alertPanel6";
            this.alertPanel6.ReadOnly = true;
            this.alertPanel6.Size = new System.Drawing.Size(35, 26);
            this.alertPanel6.TabIndex = 68;
            // 
            // closedhatPanel6
            // 
            this.closedhatPanel6.Location = new System.Drawing.Point(806, 326);
            this.closedhatPanel6.Name = "closedhatPanel6";
            this.closedhatPanel6.ReadOnly = true;
            this.closedhatPanel6.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel6.TabIndex = 67;
            // 
            // hihatPanel6
            // 
            this.hihatPanel6.Location = new System.Drawing.Point(806, 299);
            this.hihatPanel6.Name = "hihatPanel6";
            this.hihatPanel6.ReadOnly = true;
            this.hihatPanel6.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel6.TabIndex = 66;
            // 
            // snarePanel6
            // 
            this.snarePanel6.Location = new System.Drawing.Point(806, 272);
            this.snarePanel6.Name = "snarePanel6";
            this.snarePanel6.ReadOnly = true;
            this.snarePanel6.Size = new System.Drawing.Size(35, 26);
            this.snarePanel6.TabIndex = 65;
            // 
            // kickPanel6
            // 
            this.kickPanel6.Location = new System.Drawing.Point(806, 245);
            this.kickPanel6.Name = "kickPanel6";
            this.kickPanel6.ReadOnly = true;
            this.kickPanel6.Size = new System.Drawing.Size(35, 26);
            this.kickPanel6.TabIndex = 64;
            // 
            // gunPanel7
            // 
            this.gunPanel7.Location = new System.Drawing.Point(847, 380);
            this.gunPanel7.Name = "gunPanel7";
            this.gunPanel7.ReadOnly = true;
            this.gunPanel7.Size = new System.Drawing.Size(35, 26);
            this.gunPanel7.TabIndex = 75;
            // 
            // alertPanel7
            // 
            this.alertPanel7.Location = new System.Drawing.Point(847, 353);
            this.alertPanel7.Name = "alertPanel7";
            this.alertPanel7.ReadOnly = true;
            this.alertPanel7.Size = new System.Drawing.Size(35, 26);
            this.alertPanel7.TabIndex = 74;
            // 
            // closedhatPanel7
            // 
            this.closedhatPanel7.Location = new System.Drawing.Point(847, 326);
            this.closedhatPanel7.Name = "closedhatPanel7";
            this.closedhatPanel7.ReadOnly = true;
            this.closedhatPanel7.Size = new System.Drawing.Size(35, 26);
            this.closedhatPanel7.TabIndex = 73;
            // 
            // hihatPanel7
            // 
            this.hihatPanel7.Location = new System.Drawing.Point(847, 299);
            this.hihatPanel7.Name = "hihatPanel7";
            this.hihatPanel7.ReadOnly = true;
            this.hihatPanel7.Size = new System.Drawing.Size(35, 26);
            this.hihatPanel7.TabIndex = 72;
            // 
            // snarePanel7
            // 
            this.snarePanel7.Location = new System.Drawing.Point(847, 272);
            this.snarePanel7.Name = "snarePanel7";
            this.snarePanel7.ReadOnly = true;
            this.snarePanel7.Size = new System.Drawing.Size(35, 26);
            this.snarePanel7.TabIndex = 71;
            // 
            // kickPanel7
            // 
            this.kickPanel7.Location = new System.Drawing.Point(847, 245);
            this.kickPanel7.Name = "kickPanel7";
            this.kickPanel7.ReadOnly = true;
            this.kickPanel7.Size = new System.Drawing.Size(35, 26);
            this.kickPanel7.TabIndex = 70;
            // 
            // beat0Button
            // 
            this.beat0Button.Location = new System.Drawing.Point(535, 413);
            this.beat0Button.Name = "beat0Button";
            this.beat0Button.Size = new System.Drawing.Size(35, 29);
            this.beat0Button.TabIndex = 76;
            this.beat0Button.UseVisualStyleBackColor = true;
            this.beat0Button.Click += new System.EventHandler(this.beat0Button_Click);
            // 
            // beat1Button
            // 
            this.beat1Button.Location = new System.Drawing.Point(576, 413);
            this.beat1Button.Name = "beat1Button";
            this.beat1Button.Size = new System.Drawing.Size(35, 29);
            this.beat1Button.TabIndex = 77;
            this.beat1Button.UseVisualStyleBackColor = true;
            this.beat1Button.Click += new System.EventHandler(this.beat1Button_Click);
            // 
            // beat2Button
            // 
            this.beat2Button.Location = new System.Drawing.Point(617, 413);
            this.beat2Button.Name = "beat2Button";
            this.beat2Button.Size = new System.Drawing.Size(35, 29);
            this.beat2Button.TabIndex = 78;
            this.beat2Button.UseVisualStyleBackColor = true;
            this.beat2Button.Click += new System.EventHandler(this.beat2Button_Click);
            // 
            // beat3Button
            // 
            this.beat3Button.Location = new System.Drawing.Point(658, 413);
            this.beat3Button.Name = "beat3Button";
            this.beat3Button.Size = new System.Drawing.Size(35, 29);
            this.beat3Button.TabIndex = 79;
            this.beat3Button.UseVisualStyleBackColor = true;
            this.beat3Button.Click += new System.EventHandler(this.beat3Button_Click);
            // 
            // beat4Button
            // 
            this.beat4Button.Location = new System.Drawing.Point(724, 412);
            this.beat4Button.Name = "beat4Button";
            this.beat4Button.Size = new System.Drawing.Size(35, 29);
            this.beat4Button.TabIndex = 80;
            this.beat4Button.UseVisualStyleBackColor = true;
            this.beat4Button.Click += new System.EventHandler(this.beat4Button_Click);
            // 
            // beat5Button
            // 
            this.beat5Button.Location = new System.Drawing.Point(765, 412);
            this.beat5Button.Name = "beat5Button";
            this.beat5Button.Size = new System.Drawing.Size(35, 29);
            this.beat5Button.TabIndex = 81;
            this.beat5Button.UseVisualStyleBackColor = true;
            this.beat5Button.Click += new System.EventHandler(this.beat5Button_Click);
            // 
            // beat6Button
            // 
            this.beat6Button.Location = new System.Drawing.Point(806, 412);
            this.beat6Button.Name = "beat6Button";
            this.beat6Button.Size = new System.Drawing.Size(35, 29);
            this.beat6Button.TabIndex = 82;
            this.beat6Button.UseVisualStyleBackColor = true;
            this.beat6Button.Click += new System.EventHandler(this.beat6Button_Click);
            // 
            // beat8Button
            // 
            this.beat8Button.Location = new System.Drawing.Point(847, 412);
            this.beat8Button.Name = "beat8Button";
            this.beat8Button.Size = new System.Drawing.Size(35, 29);
            this.beat8Button.TabIndex = 83;
            this.beat8Button.UseVisualStyleBackColor = true;
            this.beat8Button.Click += new System.EventHandler(this.beat8Button_Click);
            // 
            // kickLabel
            // 
            this.kickLabel.AutoSize = true;
            this.kickLabel.Location = new System.Drawing.Point(900, 245);
            this.kickLabel.Name = "kickLabel";
            this.kickLabel.Size = new System.Drawing.Size(38, 20);
            this.kickLabel.TabIndex = 84;
            this.kickLabel.Text = "Kick";
            // 
            // snareLabel
            // 
            this.snareLabel.AutoSize = true;
            this.snareLabel.Location = new System.Drawing.Point(900, 275);
            this.snareLabel.Name = "snareLabel";
            this.snareLabel.Size = new System.Drawing.Size(52, 20);
            this.snareLabel.TabIndex = 85;
            this.snareLabel.Text = "Snare";
            // 
            // hihatLabel
            // 
            this.hihatLabel.AutoSize = true;
            this.hihatLabel.Location = new System.Drawing.Point(902, 305);
            this.hihatLabel.Name = "hihatLabel";
            this.hihatLabel.Size = new System.Drawing.Size(50, 20);
            this.hihatLabel.TabIndex = 86;
            this.hihatLabel.Text = "HiHat";
            // 
            // closedhatLabel
            // 
            this.closedhatLabel.AutoSize = true;
            this.closedhatLabel.Location = new System.Drawing.Point(902, 332);
            this.closedhatLabel.Name = "closedhatLabel";
            this.closedhatLabel.Size = new System.Drawing.Size(84, 20);
            this.closedhatLabel.TabIndex = 87;
            this.closedhatLabel.Text = "ClosedHat";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(902, 359);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(42, 20);
            this.alertLabel.TabIndex = 88;
            this.alertLabel.Text = "Alert";
            // 
            // gunLabel
            // 
            this.gunLabel.AutoSize = true;
            this.gunLabel.Location = new System.Drawing.Point(902, 386);
            this.gunLabel.Name = "gunLabel";
            this.gunLabel.Size = new System.Drawing.Size(40, 20);
            this.gunLabel.TabIndex = 89;
            this.gunLabel.Text = "Gun";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(665, 148);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 66);
            this.playButton.TabIndex = 90;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1222, 547);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gunLabel);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.closedhatLabel);
            this.Controls.Add(this.hihatLabel);
            this.Controls.Add(this.snareLabel);
            this.Controls.Add(this.kickLabel);
            this.Controls.Add(this.beat8Button);
            this.Controls.Add(this.beat6Button);
            this.Controls.Add(this.beat5Button);
            this.Controls.Add(this.beat4Button);
            this.Controls.Add(this.beat3Button);
            this.Controls.Add(this.beat2Button);
            this.Controls.Add(this.beat1Button);
            this.Controls.Add(this.beat0Button);
            this.Controls.Add(this.gunPanel7);
            this.Controls.Add(this.alertPanel7);
            this.Controls.Add(this.closedhatPanel7);
            this.Controls.Add(this.hihatPanel7);
            this.Controls.Add(this.snarePanel7);
            this.Controls.Add(this.kickPanel7);
            this.Controls.Add(this.gunPanel6);
            this.Controls.Add(this.alertPanel6);
            this.Controls.Add(this.closedhatPanel6);
            this.Controls.Add(this.hihatPanel6);
            this.Controls.Add(this.snarePanel6);
            this.Controls.Add(this.kickPanel6);
            this.Controls.Add(this.gunPanel5);
            this.Controls.Add(this.alertPanel5);
            this.Controls.Add(this.closedhatPanel5);
            this.Controls.Add(this.hihatPanel5);
            this.Controls.Add(this.snarePanel5);
            this.Controls.Add(this.kickPanel5);
            this.Controls.Add(this.gunPanel4);
            this.Controls.Add(this.alertPanel4);
            this.Controls.Add(this.closedhatPanel4);
            this.Controls.Add(this.hihatPanel4);
            this.Controls.Add(this.snarePanel4);
            this.Controls.Add(this.kickPanel4);
            this.Controls.Add(this.gunPanel3);
            this.Controls.Add(this.alertPanel3);
            this.Controls.Add(this.closedhatPanel3);
            this.Controls.Add(this.hihatPanel3);
            this.Controls.Add(this.snarePanel3);
            this.Controls.Add(this.kickPanel3);
            this.Controls.Add(this.gunPanel2);
            this.Controls.Add(this.alertPanel2);
            this.Controls.Add(this.closedhatPanel2);
            this.Controls.Add(this.hihatPanel2);
            this.Controls.Add(this.snarePanel2);
            this.Controls.Add(this.kickPanel2);
            this.Controls.Add(this.gunPanel1);
            this.Controls.Add(this.alertPanel1);
            this.Controls.Add(this.closedhatPanel1);
            this.Controls.Add(this.hihatPanel1);
            this.Controls.Add(this.snarePanel1);
            this.Controls.Add(this.kickPanel1);
            this.Controls.Add(this.gunPanel0);
            this.Controls.Add(this.alertPanel0);
            this.Controls.Add(this.closedhatPanel0);
            this.Controls.Add(this.hihatPanel0);
            this.Controls.Add(this.snarePanel0);
            this.Controls.Add(this.kickPanel0);
            this.Controls.Add(this.orientPicBox);
            this.Controls.Add(this.zDiffBox);
            this.Controls.Add(this.yDiffBox);
            this.Controls.Add(this.xDiffBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.gestureLstBox);
            this.Controls.Add(this.zAvgBox);
            this.Controls.Add(this.yAvgBox);
            this.Controls.Add(this.xAvgBox);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.orientBox);
            this.Controls.Add(this.bufferBox);
            this.Controls.Add(this.orientLabel);
            this.Controls.Add(this.bufferLabel);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comPortDropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comPortDropDown;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label bufferLabel;
        private System.Windows.Forms.Label orientLabel;
        private System.Windows.Forms.TextBox bufferBox;
        private System.Windows.Forms.TextBox orientBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.RadioButton readButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton unreadButton;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.TextBox xAvgBox;
        private System.Windows.Forms.TextBox yAvgBox;
        private System.Windows.Forms.TextBox zAvgBox;
        private System.Windows.Forms.ListBox gestureLstBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox xDiffBox;
        private System.Windows.Forms.TextBox yDiffBox;
        private System.Windows.Forms.TextBox zDiffBox;
        private System.Windows.Forms.PictureBox orientPicBox;
        private System.Windows.Forms.TextBox hihatPanel0;
        private System.Windows.Forms.TextBox snarePanel0;
        private System.Windows.Forms.TextBox kickPanel0;
        private System.Windows.Forms.TextBox gunPanel0;
        private System.Windows.Forms.TextBox alertPanel0;
        private System.Windows.Forms.TextBox closedhatPanel0;
        private System.Windows.Forms.TextBox gunPanel1;
        private System.Windows.Forms.TextBox alertPanel1;
        private System.Windows.Forms.TextBox closedhatPanel1;
        private System.Windows.Forms.TextBox hihatPanel1;
        private System.Windows.Forms.TextBox snarePanel1;
        private System.Windows.Forms.TextBox kickPanel1;
        private System.Windows.Forms.TextBox gunPanel2;
        private System.Windows.Forms.TextBox alertPanel2;
        private System.Windows.Forms.TextBox closedhatPanel2;
        private System.Windows.Forms.TextBox hihatPanel2;
        private System.Windows.Forms.TextBox snarePanel2;
        private System.Windows.Forms.TextBox kickPanel2;
        private System.Windows.Forms.TextBox gunPanel3;
        private System.Windows.Forms.TextBox alertPanel3;
        private System.Windows.Forms.TextBox closedhatPanel3;
        private System.Windows.Forms.TextBox hihatPanel3;
        private System.Windows.Forms.TextBox snarePanel3;
        private System.Windows.Forms.TextBox kickPanel3;
        private System.Windows.Forms.TextBox gunPanel4;
        private System.Windows.Forms.TextBox alertPanel4;
        private System.Windows.Forms.TextBox closedhatPanel4;
        private System.Windows.Forms.TextBox hihatPanel4;
        private System.Windows.Forms.TextBox snarePanel4;
        private System.Windows.Forms.TextBox kickPanel4;
        private System.Windows.Forms.TextBox gunPanel5;
        private System.Windows.Forms.TextBox alertPanel5;
        private System.Windows.Forms.TextBox closedhatPanel5;
        private System.Windows.Forms.TextBox hihatPanel5;
        private System.Windows.Forms.TextBox snarePanel5;
        private System.Windows.Forms.TextBox kickPanel5;
        private System.Windows.Forms.TextBox gunPanel6;
        private System.Windows.Forms.TextBox alertPanel6;
        private System.Windows.Forms.TextBox closedhatPanel6;
        private System.Windows.Forms.TextBox hihatPanel6;
        private System.Windows.Forms.TextBox snarePanel6;
        private System.Windows.Forms.TextBox kickPanel6;
        private System.Windows.Forms.TextBox gunPanel7;
        private System.Windows.Forms.TextBox alertPanel7;
        private System.Windows.Forms.TextBox closedhatPanel7;
        private System.Windows.Forms.TextBox hihatPanel7;
        private System.Windows.Forms.TextBox snarePanel7;
        private System.Windows.Forms.TextBox kickPanel7;
        private System.Windows.Forms.Button beat0Button;
        private System.Windows.Forms.Button beat1Button;
        private System.Windows.Forms.Button beat2Button;
        private System.Windows.Forms.Button beat3Button;
        private System.Windows.Forms.Button beat4Button;
        private System.Windows.Forms.Button beat5Button;
        private System.Windows.Forms.Button beat6Button;
        private System.Windows.Forms.Button beat8Button;
        private System.Windows.Forms.Label kickLabel;
        private System.Windows.Forms.Label snareLabel;
        private System.Windows.Forms.Label hihatLabel;
        private System.Windows.Forms.Label closedhatLabel;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label gunLabel;
        private System.Windows.Forms.Button playButton;
    }
}

