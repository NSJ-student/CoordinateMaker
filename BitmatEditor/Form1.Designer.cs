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
            this.lbRow = new System.Windows.Forms.Label();
            this.lbRowValue = new System.Windows.Forms.Label();
            this.lbColumn = new System.Windows.Forms.Label();
            this.lbColValue = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnColorValue = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.nudColCnt = new System.Windows.Forms.NumericUpDown();
            this.nudRowCnt = new System.Windows.Forms.NumericUpDown();
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
            this.pDiaplay = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeAbsolute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMakeRelative = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).BeginInit();
            this.tlpProperty.SuspendLayout();
            this.pDiaplay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRow
            // 
            this.lbRow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRow.AutoSize = true;
            this.lbRow.Location = new System.Drawing.Point(9, 12);
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
            this.lbRowValue.Location = new System.Drawing.Point(93, 12);
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
            this.lbColumn.Location = new System.Drawing.Point(9, 36);
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
            this.lbColValue.Location = new System.Drawing.Point(93, 36);
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
            this.lbColor.Location = new System.Drawing.Point(9, 60);
            this.lbColor.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(43, 12);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color :";
            // 
            // btnColorValue
            // 
            this.btnColorValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnColorValue.Location = new System.Drawing.Point(93, 57);
            this.btnColorValue.Margin = new System.Windows.Forms.Padding(4, 2, 3, 2);
            this.btnColorValue.Name = "btnColorValue";
            this.btnColorValue.Size = new System.Drawing.Size(73, 18);
            this.btnColorValue.TabIndex = 3;
            this.btnColorValue.UseVisualStyleBackColor = true;
            this.btnColorValue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.nudColCnt);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.nudRowCnt);
            this.gbControl.Controls.Add(this.lbColCnt);
            this.gbControl.Controls.Add(this.lbRowCnt);
            this.gbControl.Location = new System.Drawing.Point(11, 11);
            this.gbControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Size = new System.Drawing.Size(199, 79);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Size";
            // 
            // nudColCnt
            // 
            this.nudColCnt.AutoSize = true;
            this.nudColCnt.Location = new System.Drawing.Point(66, 46);
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
            // lbColCnt
            // 
            this.lbColCnt.AutoSize = true;
            this.lbColCnt.Location = new System.Drawing.Point(12, 48);
            this.lbColCnt.Name = "lbColCnt";
            this.lbColCnt.Size = new System.Drawing.Size(43, 12);
            this.lbColCnt.TabIndex = 1;
            this.lbColCnt.Text = "Width :";
            // 
            // lbRowCnt
            // 
            this.lbRowCnt.AutoSize = true;
            this.lbRowCnt.Location = new System.Drawing.Point(12, 23);
            this.lbRowCnt.Name = "lbRowCnt";
            this.lbRowCnt.Size = new System.Drawing.Size(48, 12);
            this.lbRowCnt.TabIndex = 0;
            this.lbRowCnt.Text = "Height :";
            // 
            // btnRemoveBackground
            // 
            this.btnRemoveBackground.Location = new System.Drawing.Point(132, 29);
            this.btnRemoveBackground.Name = "btnRemoveBackground";
            this.btnRemoveBackground.Size = new System.Drawing.Size(51, 39);
            this.btnRemoveBackground.TabIndex = 13;
            this.btnRemoveBackground.Text = "Clear";
            this.btnRemoveBackground.UseVisualStyleBackColor = true;
            this.btnRemoveBackground.Click += new System.EventHandler(this.btnRemoveBackground_Click);
            // 
            // btnLoadBackground
            // 
            this.btnLoadBackground.Location = new System.Drawing.Point(14, 29);
            this.btnLoadBackground.Name = "btnLoadBackground";
            this.btnLoadBackground.Size = new System.Drawing.Size(112, 39);
            this.btnLoadBackground.TabIndex = 12;
            this.btnLoadBackground.Text = "Load Background";
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
            this.lvColorList.SelectedIndexChanged += new System.EventHandler(this.lvColorList_SelectedIndexChanged);
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
            this.tlpProperty.ColumnCount = 2;
            this.tlpProperty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpProperty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpProperty.Controls.Add(this.btnColorValue, 1, 3);
            this.tlpProperty.Controls.Add(this.lbRow, 0, 1);
            this.tlpProperty.Controls.Add(this.lbColumn, 0, 2);
            this.tlpProperty.Controls.Add(this.lbColor, 0, 3);
            this.tlpProperty.Controls.Add(this.lbColValue, 1, 2);
            this.tlpProperty.Controls.Add(this.lbRowValue, 1, 1);
            this.tlpProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperty.Location = new System.Drawing.Point(0, 513);
            this.tlpProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpProperty.Name = "tlpProperty";
            this.tlpProperty.RowCount = 5;
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpProperty.Size = new System.Drawing.Size(223, 86);
            this.tlpProperty.TabIndex = 0;
            // 
            // pDiaplay
            // 
            this.pDiaplay.Controls.Add(this.groupBox3);
            this.pDiaplay.Controls.Add(this.groupBox2);
            this.pDiaplay.Controls.Add(this.groupBox1);
            this.pDiaplay.Controls.Add(this.tlpProperty);
            this.pDiaplay.Controls.Add(this.gbControl);
            this.pDiaplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDiaplay.Location = new System.Drawing.Point(616, 0);
            this.pDiaplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDiaplay.Name = "pDiaplay";
            this.pDiaplay.Size = new System.Drawing.Size(223, 599);
            this.pDiaplay.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadBackground);
            this.groupBox2.Controls.Add(this.btnRemoveBackground);
            this.groupBox2.Location = new System.Drawing.Point(11, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 83);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background Image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBrushColor);
            this.groupBox1.Controls.Add(this.lvColorList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFillAreaColor);
            this.groupBox1.Controls.Add(this.lbSelectedColor);
            this.groupBox1.Location = new System.Drawing.Point(11, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
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
            // btnMakeAbsolute
            // 
            this.btnMakeAbsolute.Location = new System.Drawing.Point(8, 23);
            this.btnMakeAbsolute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeAbsolute.Name = "btnMakeAbsolute";
            this.btnMakeAbsolute.Size = new System.Drawing.Size(85, 42);
            this.btnMakeAbsolute.TabIndex = 4;
            this.btnMakeAbsolute.Text = "Absolute";
            this.btnMakeAbsolute.UseVisualStyleBackColor = true;
            this.btnMakeAbsolute.Click += new System.EventHandler(this.btnMakeAbsolute_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(152, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 49);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RST";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMakeRelative
            // 
            this.btnMakeRelative.Location = new System.Drawing.Point(99, 23);
            this.btnMakeRelative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeRelative.Name = "btnMakeRelative";
            this.btnMakeRelative.Size = new System.Drawing.Size(85, 42);
            this.btnMakeRelative.TabIndex = 4;
            this.btnMakeRelative.Text = "Relative";
            this.btnMakeRelative.UseVisualStyleBackColor = true;
            this.btnMakeRelative.Click += new System.EventHandler(this.btnMakeRelative_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMakeAbsolute);
            this.groupBox3.Controls.Add(this.btnMakeRelative);
            this.groupBox3.Location = new System.Drawing.Point(11, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 81);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Make Pooint List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 599);
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
            this.pDiaplay.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
		private System.Windows.Forms.Panel pDiaplay;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMakeRelative;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

