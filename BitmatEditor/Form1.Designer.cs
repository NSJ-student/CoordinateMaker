namespace BitmatEditor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbRow = new System.Windows.Forms.Label();
            this.lbRowValue = new System.Windows.Forms.Label();
            this.lbColumn = new System.Windows.Forms.Label();
            this.lbColValue = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnColorValue = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lblCurrentRatio = new System.Windows.Forms.Label();
            this.nudColCnt = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudRowCnt = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lbColCnt = new System.Windows.Forms.Label();
            this.lbRowCnt = new System.Windows.Forms.Label();
            this.btnRemoveBackground = new System.Windows.Forms.Button();
            this.btnLoadBackground = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectedColor = new System.Windows.Forms.Label();
            this.cbFillAreaColor = new System.Windows.Forms.CheckBox();
            this.lvColorList = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColorHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBrushColor = new System.Windows.Forms.CheckBox();
            this.tlpProperty = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nBackgroundTextAlpha = new System.Windows.Forms.NumericUpDown();
            this.btnBackgroundTextFont = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nBackgroundTextOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nBackgroundTextSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBackgroundText = new System.Windows.Forms.TextBox();
            this.btnClearBackgroundText = new System.Windows.Forms.Button();
            this.btnSetBackgroundText = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nDotAlpha = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMakeAbsolute = new System.Windows.Forms.Button();
            this.btnMakeRelative = new System.Windows.Forms.Button();
            this.gbBackgroundImage = new System.Windows.Forms.GroupBox();
            this.nBackgroundAlpha = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listSelectedDot = new System.Windows.Forms.ListBox();
            this.pDiaplay = new System.Windows.Forms.Panel();
            this.pControl = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).BeginInit();
            this.tlpProperty.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDotAlpha)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundAlpha)).BeginInit();
            this.pDiaplay.SuspendLayout();
            this.pControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRow
            // 
            this.lbRow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRow.AutoSize = true;
            this.lbRow.Location = new System.Drawing.Point(9, 6);
            this.lbRow.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lbRow.Name = "lbRow";
            this.lbRow.Size = new System.Drawing.Size(38, 12);
            this.lbRow.TabIndex = 0;
            this.lbRow.Text = "Row :";
            // 
            // lbRowValue
            // 
            this.lbRowValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRowValue.AutoSize = true;
            this.lbRowValue.Location = new System.Drawing.Point(97, 6);
            this.lbRowValue.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.lbRowValue.Name = "lbRowValue";
            this.lbRowValue.Size = new System.Drawing.Size(11, 12);
            this.lbRowValue.TabIndex = 1;
            this.lbRowValue.Text = "0";
            // 
            // lbColumn
            // 
            this.lbColumn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbColumn.AutoSize = true;
            this.lbColumn.Location = new System.Drawing.Point(9, 30);
            this.lbColumn.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(32, 12);
            this.lbColumn.TabIndex = 2;
            this.lbColumn.Text = "Col :";
            // 
            // lbColValue
            // 
            this.lbColValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbColValue.AutoSize = true;
            this.lbColValue.Location = new System.Drawing.Point(97, 30);
            this.lbColValue.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.lbColValue.Name = "lbColValue";
            this.lbColValue.Size = new System.Drawing.Size(11, 12);
            this.lbColValue.TabIndex = 3;
            this.lbColValue.Text = "0";
            // 
            // lbColor
            // 
            this.lbColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(9, 54);
            this.lbColor.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(43, 12);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color :";
            // 
            // btnColorValue
            // 
            this.btnColorValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnColorValue.Location = new System.Drawing.Point(97, 51);
            this.btnColorValue.Margin = new System.Windows.Forms.Padding(4, 2, 3, 2);
            this.btnColorValue.Name = "btnColorValue";
            this.btnColorValue.Size = new System.Drawing.Size(73, 18);
            this.btnColorValue.TabIndex = 3;
            this.btnColorValue.UseVisualStyleBackColor = true;
            this.btnColorValue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lblCurrentRatio);
            this.gbControl.Controls.Add(this.nudColCnt);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.nudRowCnt);
            this.gbControl.Controls.Add(this.label8);
            this.gbControl.Controls.Add(this.lbColCnt);
            this.gbControl.Controls.Add(this.lbRowCnt);
            this.gbControl.Location = new System.Drawing.Point(11, 11);
            this.gbControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Size = new System.Drawing.Size(199, 108);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Size";
            // 
            // lblCurrentRatio
            // 
            this.lblCurrentRatio.AutoSize = true;
            this.lblCurrentRatio.Location = new System.Drawing.Point(66, 72);
            this.lblCurrentRatio.Name = "lblCurrentRatio";
            this.lblCurrentRatio.Size = new System.Drawing.Size(0, 12);
            this.lblCurrentRatio.TabIndex = 14;
            // 
            // nudColCnt
            // 
            this.nudColCnt.AutoSize = true;
            this.nudColCnt.Location = new System.Drawing.Point(66, 44);
            this.nudColCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudColCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColCnt.Name = "nudColCnt";
            this.nudColCnt.Size = new System.Drawing.Size(80, 21);
            this.nudColCnt.TabIndex = 3;
            this.nudColCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudColCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColCnt.ValueChanged += new System.EventHandler(this.nudColCnt_ValueChanged);
            this.nudColCnt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudColCnt_KeyUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(152, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 73);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RST";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudRowCnt
            // 
            this.nudRowCnt.AutoSize = true;
            this.nudRowCnt.Location = new System.Drawing.Point(66, 18);
            this.nudRowCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRowCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowCnt.Name = "nudRowCnt";
            this.nudRowCnt.Size = new System.Drawing.Size(80, 21);
            this.nudRowCnt.TabIndex = 2;
            this.nudRowCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRowCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowCnt.ValueChanged += new System.EventHandler(this.nudRowCnt_ValueChanged);
            this.nudRowCnt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudRowCnt_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ratio :";
            // 
            // lbColCnt
            // 
            this.lbColCnt.AutoSize = true;
            this.lbColCnt.Location = new System.Drawing.Point(12, 46);
            this.lbColCnt.Name = "lbColCnt";
            this.lbColCnt.Size = new System.Drawing.Size(43, 12);
            this.lbColCnt.TabIndex = 1;
            this.lbColCnt.Text = "Width :";
            // 
            // lbRowCnt
            // 
            this.lbRowCnt.AutoSize = true;
            this.lbRowCnt.Location = new System.Drawing.Point(12, 20);
            this.lbRowCnt.Name = "lbRowCnt";
            this.lbRowCnt.Size = new System.Drawing.Size(48, 12);
            this.lbRowCnt.TabIndex = 0;
            this.lbRowCnt.Text = "Height :";
            // 
            // btnRemoveBackground
            // 
            this.btnRemoveBackground.Location = new System.Drawing.Point(99, 20);
            this.btnRemoveBackground.Name = "btnRemoveBackground";
            this.btnRemoveBackground.Size = new System.Drawing.Size(84, 26);
            this.btnRemoveBackground.TabIndex = 13;
            this.btnRemoveBackground.Text = "Clear";
            this.btnRemoveBackground.UseVisualStyleBackColor = true;
            this.btnRemoveBackground.Click += new System.EventHandler(this.btnRemoveBackground_Click);
            // 
            // btnLoadBackground
            // 
            this.btnLoadBackground.Location = new System.Drawing.Point(14, 20);
            this.btnLoadBackground.Name = "btnLoadBackground";
            this.btnLoadBackground.Size = new System.Drawing.Size(84, 26);
            this.btnLoadBackground.TabIndex = 12;
            this.btnLoadBackground.Text = "Load";
            this.btnLoadBackground.UseVisualStyleBackColor = true;
            this.btnLoadBackground.Click += new System.EventHandler(this.btnLoadBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selected :";
            // 
            // lbSelectedColor
            // 
            this.lbSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelectedColor.Location = new System.Drawing.Point(80, 181);
            this.lbSelectedColor.Name = "lbSelectedColor";
            this.lbSelectedColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbSelectedColor.Size = new System.Drawing.Size(73, 20);
            this.lbSelectedColor.TabIndex = 10;
            this.lbSelectedColor.Text = "N";
            this.lbSelectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFillAreaColor
            // 
            this.cbFillAreaColor.AutoSize = true;
            this.cbFillAreaColor.Location = new System.Drawing.Point(132, 30);
            this.cbFillAreaColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFillAreaColor.Name = "cbFillAreaColor";
            this.cbFillAreaColor.Size = new System.Drawing.Size(40, 16);
            this.cbFillAreaColor.TabIndex = 7;
            this.cbFillAreaColor.Text = "Fill";
            this.cbFillAreaColor.UseVisualStyleBackColor = true;
            this.cbFillAreaColor.CheckedChanged += new System.EventHandler(this.cbFillAreaColor_CheckedChanged);
            // 
            // lvColorList
            // 
            this.lvColorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIndex,
            this.chColorHex,
            this.chColor});
            this.lvColorList.FullRowSelect = true;
            this.lvColorList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvColorList.HideSelection = false;
            this.lvColorList.Location = new System.Drawing.Point(14, 56);
            this.lvColorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvColorList.MultiSelect = false;
            this.lvColorList.Name = "lvColorList";
            this.lvColorList.Size = new System.Drawing.Size(169, 119);
            this.lvColorList.TabIndex = 6;
            this.lvColorList.UseCompatibleStateImageBehavior = false;
            this.lvColorList.View = System.Windows.Forms.View.Details;
            this.lvColorList.Click += new System.EventHandler(this.lvColorList_Click);
            this.lvColorList.DoubleClick += new System.EventHandler(this.lvColorList_DoubleClick);
            // 
            // chIndex
            // 
            this.chIndex.Text = "Name";
            // 
            // chColorHex
            // 
            this.chColorHex.Text = "Value";
            // 
            // chColor
            // 
            this.chColor.Text = "";
            this.chColor.Width = 20;
            // 
            // cbBrushColor
            // 
            this.cbBrushColor.AutoSize = true;
            this.cbBrushColor.Location = new System.Drawing.Point(69, 30);
            this.cbBrushColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrushColor.Name = "cbBrushColor";
            this.cbBrushColor.Size = new System.Drawing.Size(57, 16);
            this.cbBrushColor.TabIndex = 4;
            this.cbBrushColor.Text = "Brush";
            this.cbBrushColor.UseVisualStyleBackColor = true;
            this.cbBrushColor.CheckedChanged += new System.EventHandler(this.cbFillColor_CheckedChanged);
            // 
            // tlpProperty
            // 
            this.tlpProperty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpProperty.ColumnCount = 2;
            this.tlpProperty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpProperty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpProperty.Controls.Add(this.btnColorValue, 1, 2);
            this.tlpProperty.Controls.Add(this.lbRow, 0, 0);
            this.tlpProperty.Controls.Add(this.lbColumn, 0, 1);
            this.tlpProperty.Controls.Add(this.lbColor, 0, 2);
            this.tlpProperty.Controls.Add(this.lbColValue, 1, 1);
            this.tlpProperty.Controls.Add(this.lbRowValue, 1, 0);
            this.tlpProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperty.Location = new System.Drawing.Point(0, 545);
            this.tlpProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpProperty.Name = "tlpProperty";
            this.tlpProperty.RowCount = 4;
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProperty.Size = new System.Drawing.Size(234, 82);
            this.tlpProperty.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nBackgroundTextAlpha);
            this.groupBox4.Controls.Add(this.btnBackgroundTextFont);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nBackgroundTextOffsetY);
            this.groupBox4.Controls.Add(this.nBackgroundTextSize);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtBackgroundText);
            this.groupBox4.Controls.Add(this.btnClearBackgroundText);
            this.groupBox4.Controls.Add(this.btnSetBackgroundText);
            this.groupBox4.Location = new System.Drawing.Point(11, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 169);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Background Text";
            // 
            // nBackgroundTextAlpha
            // 
            this.nBackgroundTextAlpha.Location = new System.Drawing.Point(68, 77);
            this.nBackgroundTextAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nBackgroundTextAlpha.Name = "nBackgroundTextAlpha";
            this.nBackgroundTextAlpha.Size = new System.Drawing.Size(114, 21);
            this.nBackgroundTextAlpha.TabIndex = 15;
            this.nBackgroundTextAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nBackgroundTextAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nBackgroundTextAlpha.ValueChanged += new System.EventHandler(this.nBackgroundTextAlpha_ValueChanged);
            // 
            // btnBackgroundTextFont
            // 
            this.btnBackgroundTextFont.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBackgroundTextFont.Location = new System.Drawing.Point(69, 48);
            this.btnBackgroundTextFont.Name = "btnBackgroundTextFont";
            this.btnBackgroundTextFont.Size = new System.Drawing.Size(114, 23);
            this.btnBackgroundTextFont.TabIndex = 5;
            this.btnBackgroundTextFont.Text = "Courier New";
            this.btnBackgroundTextFont.UseVisualStyleBackColor = true;
            this.btnBackgroundTextFont.Click += new System.EventHandler(this.btnBackgroundTextFont_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alpha :";
            // 
            // nBackgroundTextOffsetY
            // 
            this.nBackgroundTextOffsetY.Location = new System.Drawing.Point(69, 104);
            this.nBackgroundTextOffsetY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nBackgroundTextOffsetY.Name = "nBackgroundTextOffsetY";
            this.nBackgroundTextOffsetY.Size = new System.Drawing.Size(114, 21);
            this.nBackgroundTextOffsetY.TabIndex = 4;
            this.nBackgroundTextOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nBackgroundTextOffsetY.ValueChanged += new System.EventHandler(this.nBackgroundTextOffsetY_ValueChanged);
            // 
            // nBackgroundTextSize
            // 
            this.nBackgroundTextSize.Location = new System.Drawing.Point(69, 21);
            this.nBackgroundTextSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nBackgroundTextSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nBackgroundTextSize.Name = "nBackgroundTextSize";
            this.nBackgroundTextSize.Size = new System.Drawing.Size(114, 21);
            this.nBackgroundTextSize.TabIndex = 4;
            this.nBackgroundTextSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nBackgroundTextSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nBackgroundTextSize.ValueChanged += new System.EventHandler(this.nBackgroundTextSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Offset Y :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Font :";
            // 
            // txtBackgroundText
            // 
            this.txtBackgroundText.Location = new System.Drawing.Point(14, 135);
            this.txtBackgroundText.Name = "txtBackgroundText";
            this.txtBackgroundText.Size = new System.Drawing.Size(67, 21);
            this.txtBackgroundText.TabIndex = 2;
            // 
            // btnClearBackgroundText
            // 
            this.btnClearBackgroundText.Location = new System.Drawing.Point(138, 131);
            this.btnClearBackgroundText.Name = "btnClearBackgroundText";
            this.btnClearBackgroundText.Size = new System.Drawing.Size(45, 26);
            this.btnClearBackgroundText.TabIndex = 1;
            this.btnClearBackgroundText.Text = "Clear";
            this.btnClearBackgroundText.UseVisualStyleBackColor = true;
            this.btnClearBackgroundText.Click += new System.EventHandler(this.btnClearBackgroundText_Click);
            // 
            // btnSetBackgroundText
            // 
            this.btnSetBackgroundText.Location = new System.Drawing.Point(87, 131);
            this.btnSetBackgroundText.Name = "btnSetBackgroundText";
            this.btnSetBackgroundText.Size = new System.Drawing.Size(45, 26);
            this.btnSetBackgroundText.TabIndex = 0;
            this.btnSetBackgroundText.Text = "Set";
            this.btnSetBackgroundText.UseVisualStyleBackColor = true;
            this.btnSetBackgroundText.Click += new System.EventHandler(this.btnSetBackgroundText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nDotAlpha);
            this.groupBox1.Controls.Add(this.cbBrushColor);
            this.groupBox1.Controls.Add(this.lvColorList);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFillAreaColor);
            this.groupBox1.Controls.Add(this.lbSelectedColor);
            this.groupBox1.Location = new System.Drawing.Point(11, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // nDotAlpha
            // 
            this.nDotAlpha.Location = new System.Drawing.Point(80, 209);
            this.nDotAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nDotAlpha.Name = "nDotAlpha";
            this.nDotAlpha.Size = new System.Drawing.Size(102, 21);
            this.nDotAlpha.TabIndex = 15;
            this.nDotAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nDotAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nDotAlpha.ValueChanged += new System.EventHandler(this.nDotAlpha_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Alpha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Action :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMakeAbsolute);
            this.groupBox3.Controls.Add(this.btnMakeRelative);
            this.groupBox3.Location = new System.Drawing.Point(11, 631);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 62);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Make Pooint List";
            // 
            // btnMakeAbsolute
            // 
            this.btnMakeAbsolute.Location = new System.Drawing.Point(8, 23);
            this.btnMakeAbsolute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeAbsolute.Name = "btnMakeAbsolute";
            this.btnMakeAbsolute.Size = new System.Drawing.Size(85, 26);
            this.btnMakeAbsolute.TabIndex = 4;
            this.btnMakeAbsolute.Text = "Absolute";
            this.btnMakeAbsolute.UseVisualStyleBackColor = true;
            this.btnMakeAbsolute.Click += new System.EventHandler(this.btnMakeAbsolute_Click);
            // 
            // btnMakeRelative
            // 
            this.btnMakeRelative.Location = new System.Drawing.Point(99, 23);
            this.btnMakeRelative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeRelative.Name = "btnMakeRelative";
            this.btnMakeRelative.Size = new System.Drawing.Size(85, 26);
            this.btnMakeRelative.TabIndex = 4;
            this.btnMakeRelative.Text = "Relative";
            this.btnMakeRelative.UseVisualStyleBackColor = true;
            this.btnMakeRelative.Click += new System.EventHandler(this.btnMakeRelative_Click);
            // 
            // gbBackgroundImage
            // 
            this.gbBackgroundImage.Controls.Add(this.nBackgroundAlpha);
            this.gbBackgroundImage.Controls.Add(this.label3);
            this.gbBackgroundImage.Controls.Add(this.btnLoadBackground);
            this.gbBackgroundImage.Controls.Add(this.btnRemoveBackground);
            this.gbBackgroundImage.Location = new System.Drawing.Point(11, 368);
            this.gbBackgroundImage.Name = "gbBackgroundImage";
            this.gbBackgroundImage.Size = new System.Drawing.Size(199, 83);
            this.gbBackgroundImage.TabIndex = 14;
            this.gbBackgroundImage.TabStop = false;
            this.gbBackgroundImage.Text = "Background Image";
            // 
            // nBackgroundAlpha
            // 
            this.nBackgroundAlpha.Location = new System.Drawing.Point(69, 52);
            this.nBackgroundAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nBackgroundAlpha.Name = "nBackgroundAlpha";
            this.nBackgroundAlpha.Size = new System.Drawing.Size(114, 21);
            this.nBackgroundAlpha.TabIndex = 15;
            this.nBackgroundAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nBackgroundAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nBackgroundAlpha.ValueChanged += new System.EventHandler(this.nBackgroundAlpha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alpha :";
            // 
            // listSelectedDot
            // 
            this.listSelectedDot.Dock = System.Windows.Forms.DockStyle.Top;
            this.listSelectedDot.FormattingEnabled = true;
            this.listSelectedDot.ItemHeight = 12;
            this.listSelectedDot.Location = new System.Drawing.Point(0, 0);
            this.listSelectedDot.Name = "listSelectedDot";
            this.listSelectedDot.Size = new System.Drawing.Size(234, 124);
            this.listSelectedDot.TabIndex = 18;
            this.listSelectedDot.Click += new System.EventHandler(this.listSelectedDot_Click);
            this.listSelectedDot.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listSelectedDot_KeyUp);
            // 
            // pDiaplay
            // 
            this.pDiaplay.AutoScroll = true;
            this.pDiaplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDiaplay.Controls.Add(this.tlpProperty);
            this.pDiaplay.Controls.Add(this.pControl);
            this.pDiaplay.Controls.Add(this.listSelectedDot);
            this.pDiaplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDiaplay.Location = new System.Drawing.Point(596, 0);
            this.pDiaplay.Name = "pDiaplay";
            this.pDiaplay.Size = new System.Drawing.Size(236, 629);
            this.pDiaplay.TabIndex = 19;
            // 
            // pControl
            // 
            this.pControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pControl.AutoScroll = true;
            this.pControl.Controls.Add(this.gbControl);
            this.pControl.Controls.Add(this.groupBox4);
            this.pControl.Controls.Add(this.groupBox1);
            this.pControl.Controls.Add(this.groupBox3);
            this.pControl.Controls.Add(this.gbBackgroundImage);
            this.pControl.Location = new System.Drawing.Point(0, 130);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(234, 410);
            this.pControl.TabIndex = 17;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 629);
            this.Controls.Add(this.pDiaplay);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Coordinate Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).EndInit();
            this.tlpProperty.ResumeLayout(false);
            this.tlpProperty.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundTextSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDotAlpha)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbBackgroundImage.ResumeLayout(false);
            this.gbBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBackgroundAlpha)).EndInit();
            this.pDiaplay.ResumeLayout(false);
            this.pControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbColValue;
        private System.Windows.Forms.Label lbColumn;
        private System.Windows.Forms.Label lbRowValue;
        private System.Windows.Forms.Label lbRow;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnColorValue;
		private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Label lbColCnt;
        private System.Windows.Forms.Label lbRowCnt;
        private System.Windows.Forms.NumericUpDown nudColCnt;
        private System.Windows.Forms.NumericUpDown nudRowCnt;
		private System.Windows.Forms.CheckBox cbBrushColor;
		private System.Windows.Forms.TableLayoutPanel tlpProperty;
		private System.Windows.Forms.Button btnMakeAbsolute;
		private System.Windows.Forms.ListView lvColorList;
		private System.Windows.Forms.ColumnHeader chIndex;
		private System.Windows.Forms.ColumnHeader chColorHex;
		private System.Windows.Forms.ColumnHeader chColor;
		private System.Windows.Forms.CheckBox cbFillAreaColor;
		private System.Windows.Forms.Label lbSelectedColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBackground;
        private System.Windows.Forms.Button btnRemoveBackground;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBackgroundImage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMakeRelative;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nBackgroundAlpha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearBackgroundText;
        private System.Windows.Forms.Button btnSetBackgroundText;
        private System.Windows.Forms.TextBox txtBackgroundText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nBackgroundTextSize;
        private System.Windows.Forms.Button btnBackgroundTextFont;
        private System.Windows.Forms.NumericUpDown nBackgroundTextOffsetY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nBackgroundTextAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentRatio;
        private System.Windows.Forms.NumericUpDown nDotAlpha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listSelectedDot;
        private System.Windows.Forms.Panel pDiaplay;
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

