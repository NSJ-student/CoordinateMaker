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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbGenCode = new System.Windows.Forms.RichTextBox();
            this.btnLineCode = new System.Windows.Forms.Button();
            this.btnClearCode = new System.Windows.Forms.Button();
            this.btnArcCode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 551);
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
            this.tabPage2.Size = new System.Drawing.Size(372, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table Result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dgvResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbGenCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLineCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClearCode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnArcCode, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 519);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIndex,
            this.cPosX,
            this.cPosY,
            this.cType});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvResult, 3);
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(360, 238);
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
            this.tableLayoutPanel1.SetColumnSpan(this.rtbGenCode, 3);
            this.rtbGenCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGenCode.Location = new System.Drawing.Point(3, 247);
            this.rtbGenCode.Name = "rtbGenCode";
            this.rtbGenCode.Size = new System.Drawing.Size(360, 238);
            this.rtbGenCode.TabIndex = 1;
            this.rtbGenCode.Text = "";
            this.rtbGenCode.WordWrap = false;
            // 
            // btnLineCode
            // 
            this.btnLineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLineCode.Location = new System.Drawing.Point(3, 491);
            this.btnLineCode.Name = "btnLineCode";
            this.btnLineCode.Size = new System.Drawing.Size(115, 25);
            this.btnLineCode.TabIndex = 2;
            this.btnLineCode.Text = "Line Code";
            this.btnLineCode.UseVisualStyleBackColor = true;
            this.btnLineCode.Click += new System.EventHandler(this.btnLineCode_Click);
            // 
            // btnClearCode
            // 
            this.btnClearCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearCode.Location = new System.Drawing.Point(245, 491);
            this.btnClearCode.Name = "btnClearCode";
            this.btnClearCode.Size = new System.Drawing.Size(118, 25);
            this.btnClearCode.TabIndex = 3;
            this.btnClearCode.Text = "Clear Code";
            this.btnClearCode.UseVisualStyleBackColor = true;
            this.btnClearCode.Click += new System.EventHandler(this.btnClearCode_Click);
            // 
            // btnArcCode
            // 
            this.btnArcCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArcCode.Location = new System.Drawing.Point(124, 491);
            this.btnArcCode.Name = "btnArcCode";
            this.btnArcCode.Size = new System.Drawing.Size(115, 25);
            this.btnArcCode.TabIndex = 4;
            this.btnArcCode.Text = "Arc Code";
            this.btnArcCode.UseVisualStyleBackColor = true;
            this.btnArcCode.Click += new System.EventHandler(this.btnArcCode_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 571);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbGenCode;
        private System.Windows.Forms.Button btnLineCode;
        private System.Windows.Forms.Button btnClearCode;
        private System.Windows.Forms.Button btnArcCode;
    }
}