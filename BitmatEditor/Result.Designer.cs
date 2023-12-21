namespace BitmatEditor
{
	partial class Result
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
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbGenCode = new System.Windows.Forms.RichTextBox();
            this.btnLineCode = new System.Windows.Forms.Button();
            this.btnClearCode = new System.Windows.Forms.Button();
            this.btnArcCode = new System.Windows.Forms.Button();
            this.pDrawPath = new System.Windows.Forms.Panel();
            this.txtVarSuffix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudColCnt = new System.Windows.Forms.NumericUpDown();
            this.nudRowCnt = new System.Windows.Forms.NumericUpDown();
            this.lbColCnt = new System.Windows.Forms.Label();
            this.lbRowCnt = new System.Windows.Forms.Label();
            this.btnGeneratePoints = new System.Windows.Forms.Button();
            this.dgvPoints = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRotate = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(6, 5);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(363, 487);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            this.rtbResult.WordWrap = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(6, 496);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(360, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 538);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbResult);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text Result";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table Result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIndex,
            this.cPosX,
            this.cPosY,
            this.cType});
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(248, 247);
            this.dgvResult.TabIndex = 0;
            // 
            // cIndex
            // 
            this.cIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cIndex.Frozen = true;
            this.cIndex.HeaderText = "IDX";
            this.cIndex.Name = "cIndex";
            this.cIndex.ReadOnly = true;
            this.cIndex.Width = 49;
            // 
            // cPosX
            // 
            this.cPosX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPosX.Frozen = true;
            this.cPosX.HeaderText = "X";
            this.cPosX.Name = "cPosX";
            this.cPosX.ReadOnly = true;
            this.cPosX.Width = 38;
            // 
            // cPosY
            // 
            this.cPosY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPosY.Frozen = true;
            this.cPosY.HeaderText = "Y";
            this.cPosY.Name = "cPosY";
            this.cPosY.ReadOnly = true;
            this.cPosY.Width = 38;
            // 
            // cType
            // 
            this.cType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cType.Frozen = true;
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            this.cType.Width = 59;
            // 
            // rtbGenCode
            // 
            this.rtbGenCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGenCode.Location = new System.Drawing.Point(112, 79);
            this.rtbGenCode.Name = "rtbGenCode";
            this.rtbGenCode.Size = new System.Drawing.Size(388, 165);
            this.rtbGenCode.TabIndex = 1;
            this.rtbGenCode.Text = "";
            this.rtbGenCode.WordWrap = false;
            // 
            // btnLineCode
            // 
            this.btnLineCode.Location = new System.Drawing.Point(112, 42);
            this.btnLineCode.Name = "btnLineCode";
            this.btnLineCode.Size = new System.Drawing.Size(58, 25);
            this.btnLineCode.TabIndex = 2;
            this.btnLineCode.Text = "Line";
            this.btnLineCode.UseVisualStyleBackColor = true;
            this.btnLineCode.Click += new System.EventHandler(this.btnLineCode_Click);
            // 
            // btnClearCode
            // 
            this.btnClearCode.Location = new System.Drawing.Point(240, 42);
            this.btnClearCode.Name = "btnClearCode";
            this.btnClearCode.Size = new System.Drawing.Size(58, 25);
            this.btnClearCode.TabIndex = 3;
            this.btnClearCode.Text = "Clear";
            this.btnClearCode.UseVisualStyleBackColor = true;
            this.btnClearCode.Click += new System.EventHandler(this.btnClearCode_Click);
            // 
            // btnArcCode
            // 
            this.btnArcCode.Location = new System.Drawing.Point(176, 42);
            this.btnArcCode.Name = "btnArcCode";
            this.btnArcCode.Size = new System.Drawing.Size(58, 25);
            this.btnArcCode.TabIndex = 4;
            this.btnArcCode.Text = "Arc";
            this.btnArcCode.UseVisualStyleBackColor = true;
            this.btnArcCode.Click += new System.EventHandler(this.btnArcCode_Click);
            // 
            // pDrawPath
            // 
            this.pDrawPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pDrawPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDrawPath.Location = new System.Drawing.Point(3, 79);
            this.pDrawPath.Name = "pDrawPath";
            this.pDrawPath.Size = new System.Drawing.Size(103, 165);
            this.pDrawPath.TabIndex = 5;
            this.pDrawPath.Paint += new System.Windows.Forms.PaintEventHandler(this.pDrawPath_Paint);
            // 
            // txtVarSuffix
            // 
            this.txtVarSuffix.Location = new System.Drawing.Point(79, 45);
            this.txtVarSuffix.Name = "txtVarSuffix";
            this.txtVarSuffix.Size = new System.Drawing.Size(27, 21);
            this.txtVarSuffix.TabIndex = 6;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.pDrawPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLineCode);
            this.panel1.Controls.Add(this.txtVarSuffix);
            this.panel1.Controls.Add(this.btnArcCode);
            this.panel1.Controls.Add(this.btnClearCode);
            this.panel1.Controls.Add(this.rtbGenCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 247);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "path num :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGeneratePoints);
            this.panel2.Controls.Add(this.nudColCnt);
            this.panel2.Controls.Add(this.nudRotate);
            this.panel2.Controls.Add(this.nudRowCnt);
            this.panel2.Controls.Add(this.dgvPoints);
            this.panel2.Controls.Add(this.lbColCnt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbRowCnt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 247);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generate Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Generate Points";
            // 
            // nudColCnt
            // 
            this.nudColCnt.AutoSize = true;
            this.nudColCnt.Location = new System.Drawing.Point(66, 69);
            this.nudColCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudColCnt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudColCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColCnt.Name = "nudColCnt";
            this.nudColCnt.Size = new System.Drawing.Size(80, 21);
            this.nudColCnt.TabIndex = 12;
            this.nudColCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudColCnt.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // nudRowCnt
            // 
            this.nudRowCnt.AutoSize = true;
            this.nudRowCnt.Location = new System.Drawing.Point(66, 43);
            this.nudRowCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRowCnt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRowCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowCnt.Name = "nudRowCnt";
            this.nudRowCnt.Size = new System.Drawing.Size(80, 21);
            this.nudRowCnt.TabIndex = 11;
            this.nudRowCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRowCnt.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // lbColCnt
            // 
            this.lbColCnt.AutoSize = true;
            this.lbColCnt.Location = new System.Drawing.Point(12, 71);
            this.lbColCnt.Name = "lbColCnt";
            this.lbColCnt.Size = new System.Drawing.Size(43, 12);
            this.lbColCnt.TabIndex = 10;
            this.lbColCnt.Text = "Width :";
            // 
            // lbRowCnt
            // 
            this.lbRowCnt.AutoSize = true;
            this.lbRowCnt.Location = new System.Drawing.Point(12, 45);
            this.lbRowCnt.Name = "lbRowCnt";
            this.lbRowCnt.Size = new System.Drawing.Size(48, 12);
            this.lbRowCnt.TabIndex = 9;
            this.lbRowCnt.Text = "Height :";
            // 
            // btnGeneratePoints
            // 
            this.btnGeneratePoints.Location = new System.Drawing.Point(166, 10);
            this.btnGeneratePoints.Name = "btnGeneratePoints";
            this.btnGeneratePoints.Size = new System.Drawing.Size(62, 24);
            this.btnGeneratePoints.TabIndex = 13;
            this.btnGeneratePoints.Text = "GET";
            this.btnGeneratePoints.UseVisualStyleBackColor = true;
            this.btnGeneratePoints.Click += new System.EventHandler(this.btnGeneratePoints_Click);
            // 
            // dgvPoints
            // 
            this.dgvPoints.AllowUserToAddRows = false;
            this.dgvPoints.AllowUserToDeleteRows = false;
            this.dgvPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvPoints.Location = new System.Drawing.Point(3, 96);
            this.dgvPoints.Name = "dgvPoints";
            this.dgvPoints.ReadOnly = true;
            this.dgvPoints.RowHeadersVisible = false;
            this.dgvPoints.RowTemplate.Height = 23;
            this.dgvPoints.Size = new System.Drawing.Size(243, 148);
            this.dgvPoints.TabIndex = 0;
            this.dgvPoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoints_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvResult, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 506);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "IDX";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "X";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 38;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Y";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rotate :";
            // 
            // nudRotate
            // 
            this.nudRotate.AutoSize = true;
            this.nudRotate.Location = new System.Drawing.Point(158, 70);
            this.nudRotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRotate.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotate.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotate.Name = "nudRotate";
            this.nudRotate.Size = new System.Drawing.Size(80, 21);
            this.nudRotate.TabIndex = 11;
            this.nudRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(15, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "None";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 593);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbResult;
		private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.RichTextBox rtbGenCode;
        private System.Windows.Forms.Button btnLineCode;
        private System.Windows.Forms.Button btnClearCode;
        private System.Windows.Forms.Button btnArcCode;
        private System.Windows.Forms.Panel pDrawPath;
        private System.Windows.Forms.TextBox txtVarSuffix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeneratePoints;
        private System.Windows.Forms.NumericUpDown nudColCnt;
        private System.Windows.Forms.NumericUpDown nudRowCnt;
        private System.Windows.Forms.Label lbColCnt;
        private System.Windows.Forms.Label lbRowCnt;
        private System.Windows.Forms.DataGridView dgvPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown nudRotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
    }
}