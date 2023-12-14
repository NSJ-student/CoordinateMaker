﻿namespace BitmatEditor
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
            this.lbColorSystem = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbRow = new System.Windows.Forms.Label();
            this.lbRowValue = new System.Windows.Forms.Label();
            this.lbColumn = new System.Windows.Forms.Label();
            this.lbColValue = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnColorValue = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lbSelectedColor = new System.Windows.Forms.Label();
            this.nudBitsPerColor = new System.Windows.Forms.NumericUpDown();
            this.lbBitsPerColor = new System.Windows.Forms.Label();
            this.cbFillAreaColor = new System.Windows.Forms.CheckBox();
            this.lvColorList = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColorHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBrushColor = new System.Windows.Forms.CheckBox();
            this.nudColCnt = new System.Windows.Forms.NumericUpDown();
            this.nudRowCnt = new System.Windows.Forms.NumericUpDown();
            this.lbColCnt = new System.Windows.Forms.Label();
            this.lbRowCnt = new System.Windows.Forms.Label();
            this.tlpProperty = new System.Windows.Forms.TableLayoutPanel();
            this.pDiaplay = new System.Windows.Forms.Panel();
            this.btnMake = new System.Windows.Forms.Button();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitsPerColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).BeginInit();
            this.tlpProperty.SuspendLayout();
            this.pDiaplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbColorSystem
            // 
            this.lbColorSystem.AutoSize = true;
            this.lbColorSystem.Location = new System.Drawing.Point(14, 14);
            this.lbColorSystem.Name = "lbColorSystem";
            this.lbColorSystem.Size = new System.Drawing.Size(82, 12);
            this.lbColorSystem.TabIndex = 0;
            this.lbColorSystem.Text = "Color System";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(17, 38);
            this.cbColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(82, 20);
            this.cbColor.TabIndex = 1;
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
            this.lbRowValue.Location = new System.Drawing.Point(74, 12);
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
            this.lbColValue.Location = new System.Drawing.Point(74, 36);
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
            this.btnColorValue.Location = new System.Drawing.Point(74, 57);
            this.btnColorValue.Margin = new System.Windows.Forms.Padding(4, 2, 3, 2);
            this.btnColorValue.Name = "btnColorValue";
            this.btnColorValue.Size = new System.Drawing.Size(73, 18);
            this.btnColorValue.TabIndex = 3;
            this.btnColorValue.UseVisualStyleBackColor = true;
            this.btnColorValue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lbSelectedColor);
            this.gbControl.Controls.Add(this.nudBitsPerColor);
            this.gbControl.Controls.Add(this.lbBitsPerColor);
            this.gbControl.Controls.Add(this.cbFillAreaColor);
            this.gbControl.Controls.Add(this.lvColorList);
            this.gbControl.Controls.Add(this.cbBrushColor);
            this.gbControl.Controls.Add(this.nudColCnt);
            this.gbControl.Controls.Add(this.nudRowCnt);
            this.gbControl.Controls.Add(this.lbColCnt);
            this.gbControl.Controls.Add(this.lbRowCnt);
            this.gbControl.Location = new System.Drawing.Point(8, 70);
            this.gbControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbControl.Size = new System.Drawing.Size(157, 203);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // lbSelectedColor
            // 
            this.lbSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelectedColor.Location = new System.Drawing.Point(122, 77);
            this.lbSelectedColor.Name = "lbSelectedColor";
            this.lbSelectedColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbSelectedColor.Size = new System.Drawing.Size(26, 20);
            this.lbSelectedColor.TabIndex = 10;
            this.lbSelectedColor.Text = "N";
            this.lbSelectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudBitsPerColor
            // 
            this.nudBitsPerColor.Location = new System.Drawing.Point(98, 177);
            this.nudBitsPerColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBitsPerColor.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBitsPerColor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBitsPerColor.Name = "nudBitsPerColor";
            this.nudBitsPerColor.ReadOnly = true;
            this.nudBitsPerColor.Size = new System.Drawing.Size(49, 21);
            this.nudBitsPerColor.TabIndex = 9;
            this.nudBitsPerColor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBitsPerColor.ValueChanged += new System.EventHandler(this.nudBitsPerColor_ValueChanged);
            // 
            // lbBitsPerColor
            // 
            this.lbBitsPerColor.AutoSize = true;
            this.lbBitsPerColor.Location = new System.Drawing.Point(6, 178);
            this.lbBitsPerColor.Name = "lbBitsPerColor";
            this.lbBitsPerColor.Size = new System.Drawing.Size(83, 12);
            this.lbBitsPerColor.TabIndex = 8;
            this.lbBitsPerColor.Text = "BitsPerColor: ";
            // 
            // cbFillAreaColor
            // 
            this.cbFillAreaColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFillAreaColor.AutoSize = true;
            this.cbFillAreaColor.Location = new System.Drawing.Point(66, 77);
            this.cbFillAreaColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFillAreaColor.Name = "cbFillAreaColor";
            this.cbFillAreaColor.Size = new System.Drawing.Size(31, 22);
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
            this.lvColorList.Location = new System.Drawing.Point(9, 102);
            this.lvColorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvColorList.MultiSelect = false;
            this.lvColorList.Name = "lvColorList";
            this.lvColorList.Size = new System.Drawing.Size(139, 71);
            this.lvColorList.TabIndex = 6;
            this.lvColorList.UseCompatibleStateImageBehavior = false;
            this.lvColorList.View = System.Windows.Forms.View.Details;
            this.lvColorList.SelectedIndexChanged += new System.EventHandler(this.lvColorList_SelectedIndexChanged);
            this.lvColorList.DoubleClick += new System.EventHandler(this.lvColorList_DoubleClick);
            // 
            // chIndex
            // 
            this.chIndex.Text = "No.";
            this.chIndex.Width = 30;
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
            this.cbBrushColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBrushColor.AutoSize = true;
            this.cbBrushColor.Location = new System.Drawing.Point(9, 77);
            this.cbBrushColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrushColor.Name = "cbBrushColor";
            this.cbBrushColor.Size = new System.Drawing.Size(48, 22);
            this.cbBrushColor.TabIndex = 4;
            this.cbBrushColor.Text = "Brush";
            this.cbBrushColor.UseVisualStyleBackColor = true;
            this.cbBrushColor.CheckedChanged += new System.EventHandler(this.cbFillColor_CheckedChanged);
            // 
            // nudColCnt
            // 
            this.nudColCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudColCnt.AutoSize = true;
            this.nudColCnt.Location = new System.Drawing.Point(60, 40);
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
            this.nudRowCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudRowCnt.AutoSize = true;
            this.nudRowCnt.Location = new System.Drawing.Point(60, 15);
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
            this.lbColCnt.Size = new System.Drawing.Size(32, 12);
            this.lbColCnt.TabIndex = 1;
            this.lbColCnt.Text = "Col :";
            // 
            // lbRowCnt
            // 
            this.lbRowCnt.AutoSize = true;
            this.lbRowCnt.Location = new System.Drawing.Point(12, 23);
            this.lbRowCnt.Name = "lbRowCnt";
            this.lbRowCnt.Size = new System.Drawing.Size(38, 12);
            this.lbRowCnt.TabIndex = 0;
            this.lbRowCnt.Text = "Row :";
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
            this.tlpProperty.Location = new System.Drawing.Point(0, 277);
            this.tlpProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpProperty.Name = "tlpProperty";
            this.tlpProperty.RowCount = 5;
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProperty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpProperty.Size = new System.Drawing.Size(176, 86);
            this.tlpProperty.TabIndex = 0;
            // 
            // pDiaplay
            // 
            this.pDiaplay.Controls.Add(this.btnMake);
            this.pDiaplay.Controls.Add(this.tlpProperty);
            this.pDiaplay.Controls.Add(this.gbControl);
            this.pDiaplay.Controls.Add(this.cbColor);
            this.pDiaplay.Controls.Add(this.lbColorSystem);
            this.pDiaplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDiaplay.Location = new System.Drawing.Point(451, 0);
            this.pDiaplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDiaplay.Name = "pDiaplay";
            this.pDiaplay.Size = new System.Drawing.Size(176, 363);
            this.pDiaplay.TabIndex = 5;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(110, 14);
            this.btnMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(54, 42);
            this.btnMake.TabIndex = 4;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 363);
            this.Controls.Add(this.pDiaplay);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Bitmap Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitsPerColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).EndInit();
            this.tlpProperty.ResumeLayout(false);
            this.tlpProperty.PerformLayout();
            this.pDiaplay.ResumeLayout(false);
            this.pDiaplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbColorSystem;
        private System.Windows.Forms.ComboBox cbColor;
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
		private System.Windows.Forms.Button btnMake;
		private System.Windows.Forms.ListView lvColorList;
		private System.Windows.Forms.ColumnHeader chIndex;
		private System.Windows.Forms.ColumnHeader chColorHex;
		private System.Windows.Forms.ColumnHeader chColor;
		private System.Windows.Forms.CheckBox cbFillAreaColor;
		private System.Windows.Forms.NumericUpDown nudBitsPerColor;
		private System.Windows.Forms.Label lbBitsPerColor;
		private System.Windows.Forms.Label lbSelectedColor;
    }
}

