using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BitmatEditor
{
    public partial class Form1 : Form
    {
		DotMatrix matrix;
		Color? SelectedColor;
		int SelectedIndex;
		RectangleF MatrixArea;
		Bitmap backgroundBitmap;
		string backgroundText;
		Font backgroundTextFont;
        Dot SelectedDot;
		Dot MouseDownDot;
		bool bDrag = false;
		Result resultDialog;
		List<PointInfo> PointList;

        public Form1()
        {
            InitializeComponent();
			matrix = new DotMatrix(1, 1);

			pDiaplay.Width = 2 * gbControl.Location.X + gbControl.Width;
			this.MinimumSize = new Size(pDiaplay.Width + 200,
				pDiaplay.Location.Y + pDiaplay.Size.Height + tlpProperty.Size.Height);

			SelectedColor = null;
			SelectedIndex = -1;
            SelectedDot = null;
			MouseDownDot = null;
			backgroundBitmap = null;
			backgroundText = "";
			backgroundTextFont = btnBackgroundTextFont.Font;

			resultDialog = null;

			PointList = new List<PointInfo>();

            MatrixArea = new RectangleF(20, 20,
				this.ClientSize.Width - pDiaplay.Width - 50,
				this.ClientSize.Height - 50);

			tlpProperty.Visible = false;

            AddColorList("Line", Color.FromArgb((int)nDotAlpha.Value, Color.Red));
            AddColorList("Arc", Color.FromArgb((int)nDotAlpha.Value, Color.Blue));
            AddColorList("Point", Color.FromArgb((int)nDotAlpha.Value, Color.Black));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudRowCnt_KeyUp(object sender, KeyEventArgs e)
		{
			matrix = new DotMatrix((int)nudRowCnt.Value, (int)nudColCnt.Value);
			Invalidate(true);
        }

        private void nudColCnt_KeyUp(object sender, KeyEventArgs e)
		{
			matrix = new DotMatrix((int)nudRowCnt.Value, (int)nudColCnt.Value);
			Invalidate(true);
			SetDotRatio();
		}

        private void nudRowCnt_ValueChanged(object sender, EventArgs e)
		{
			matrix = new DotMatrix((int)nudRowCnt.Value, (int)nudColCnt.Value);
			Invalidate(true);
			SetDotRatio();
		}

        private void nudColCnt_ValueChanged(object sender, EventArgs e)
		{
			matrix = new DotMatrix((int)nudRowCnt.Value, (int)nudColCnt.Value);
			Invalidate(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PointList.Clear();
            matrix = new DotMatrix((int)nudRowCnt.Value, (int)nudColCnt.Value);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
		{
			int Row = (int)nudRowCnt.Value;
			int Col = (int)nudColCnt.Value;
			float Width = MatrixArea.Width / Col;
            float Height = MatrixArea.Height / Row;


            Font font = new Font(FontFamily.GenericSansSerif, 8);
            Brush tBrush = new SolidBrush(Color.Black);
			for(int row=0; row<Row; row++)
            {
                RectangleF areaR = new RectangleF(0, MatrixArea.Y + Height * row, MatrixArea.X, Height);
                e.Graphics.DrawString((Row-1-row).ToString(), font, tBrush, areaR);
            }
            for (int col = 0; col < Col; col++)
            {
                RectangleF areaC = new RectangleF(MatrixArea.X + Width * col, MatrixArea.Y + MatrixArea.Height, 
													Width, MatrixArea.Y);
                e.Graphics.DrawString(col.ToString(), font, tBrush, areaC);
            }

            if ((backgroundBitmap == null) && (backgroundText == ""))
            {
                Brush brush = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(brush, MatrixArea);
            }
			else if(backgroundText != "")
			{
				SizeF stringSize = new SizeF();
				stringSize = e.Graphics.MeasureString(backgroundText, backgroundTextFont);
				int leftMargin = (int)(MatrixArea.X + (MatrixArea.Width / 2) - (stringSize.Width / 2));
				int topMargin = (int)(MatrixArea.Y + (MatrixArea.Height / 2) - (int)nBackgroundTextOffsetY.Value);
				Brush bBrush = new SolidBrush(Color.FromArgb((int)nBackgroundTextAlpha.Value, 0, 0, 0));
				e.Graphics.DrawString(backgroundText, backgroundTextFont, bBrush, leftMargin, topMargin);
			}
			else
			{
				//create a color matrix object  
				ColorMatrix matrix = new ColorMatrix();
				//set the opacity  
				matrix.Matrix33 = (float)nBackgroundAlpha.Value / 255;
				//create image attributes  
				ImageAttributes attributes = new ImageAttributes();
				//set the color(opacity) of the image  
				attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				e.Graphics.DrawImage(backgroundBitmap, new Rectangle((int)MatrixArea.X, (int)MatrixArea.Y, (int)MatrixArea.Width, (int)MatrixArea.Height), 
								0, 0, backgroundBitmap.Width, backgroundBitmap.Height, GraphicsUnit.Pixel, attributes);
			}

			matrix.Draw(e, MatrixArea);
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			MatrixArea.Size = new Size(this.ClientSize.Width - pDiaplay.Width - 50, this.ClientSize.Height - 50);
			Invalidate(true);
			SetDotRatio();
		}

		private void nBackgroundAlpha_ValueChanged(object sender, EventArgs e)
		{
			Invalidate(true);
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			ColorDialog cDialog = new ColorDialog();
			DialogResult res = cDialog.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				btnColorValue.BackColor = cDialog.Color;
				btnColorValue.Text = (cDialog.Color.ToArgb() & 0xFFFFFF).ToString("X");
				if (SelectedDot != null)
					SelectedDot.SetColor(btnColorValue.BackColor);
			}
		}

        private void btnMakeAbsolute_Click(object sender, EventArgs e)
        {
            if ((resultDialog == null) ||
                (resultDialog.IsDisposed))
            {
                resultDialog = new Result();
            }

            resultDialog.ListAbsPoints(PointList, (int)nudRowCnt.Value, (int)nudColCnt.Value);
			if(resultDialog.Visible == false)
            {
                resultDialog.Show();
                resultDialog.StartPosition = FormStartPosition.Manual;
                resultDialog.Location = new Point(this.Left + this.Width, this.Top);
            }
        }

        private void btnMakeRelative_Click(object sender, EventArgs e)
        {
            if ((resultDialog == null) ||
                (resultDialog.IsDisposed))
            {
                resultDialog = new Result();
            }

            resultDialog.ListRelativePoints(PointList, (int)nudRowCnt.Value, (int)nudColCnt.Value);
            if (resultDialog.Visible == false)
            {
                resultDialog.Show();
                resultDialog.StartPosition = FormStartPosition.Manual;
                resultDialog.Location = new Point(this.Left + this.Width, this.Top);
            }
        }

        private bool IsListColorExist(Color color)
		{
			int cnt;

			for (cnt = 0; cnt < lvColorList.Items.Count; cnt++)
			{
				ListViewItem item = lvColorList.Items[cnt];
				if (item.SubItems[2].BackColor == color)
					return true;
			}

			return false;
		}
		private ListViewItem SearchListViewItem(Color color)
		{
			for (int cnt = 0; cnt < lvColorList.Items.Count; cnt++)
			{
				ListViewItem item = lvColorList.Items[cnt];
				if (item.SubItems[2].BackColor == color)
					return item;
			}

			return null;
		}
		private ListViewItem SearchListViewItem(int index)
		{
			for (int cnt = 0; cnt < lvColorList.Items.Count; cnt++)
			{
				ListViewItem item = lvColorList.Items[cnt];
				if (item.SubItems[0].Text.Equals(index.ToString()))
					return item;
			}

			return null;
		}

		private void lvColorList_DoubleClick(object sender, EventArgs e)
		{
			ColorDialog cDialog = new ColorDialog();
			DialogResult res = cDialog.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				SelectedColor = cDialog.Color;
				ListViewItemChangeColor(lvColorList.SelectedItems[0], cDialog.Color);
			}
		}

		private void cbFillAreaColor_CheckedChanged(object sender, EventArgs e)
		{
			if (cbFillAreaColor.Checked)
			{
				this.Cursor = Cursors.Hand;
				if (cbBrushColor.Checked)
					cbBrushColor.Checked = false;
			}
			else
			{
				if (!cbBrushColor.Checked)
					this.Cursor = Cursors.Default;
			}
		}
		private void cbFillColor_CheckedChanged(object sender, EventArgs e)
		{
			if(cbBrushColor.Checked)
			{
				this.Cursor = Cursors.Cross;
				if (cbFillAreaColor.Checked)
					cbFillAreaColor.Checked = false;
			}
			else
			{
				if (!cbFillAreaColor.Checked)
					this.Cursor = Cursors.Default;
			}
		}

		private bool AddColorList(Color? color)
		{
			if (color == null)
				return false;
			//if (IsListColorExist((Color)color) == true)
			//	return false;

			ListViewItem item = new ListViewItem();
			item.UseItemStyleForSubItems = false;
			item.SubItems[0] = new ListViewItem.ListViewSubItem(item,
				lvColorList.Items.Count.ToString());
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item,
				(((Color)color).ToArgb() & 0xFFFFFF).ToString("X6")));
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item, "", (Color)color, (Color)color, null));
			lvColorList.Items.Add(item);
			return true;
		}

        private bool AddColorList(string name, Color? color)
        {
            if (color == null)
                return false;
            //if (IsListColorExist((Color)color) == true)
            //	return false;

            ListViewItem item = new ListViewItem();
            item.UseItemStyleForSubItems = false;
            item.SubItems[0] = new ListViewItem.ListViewSubItem(item, name);
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item,
                (((Color)color).ToArgb() & 0xFFFFFF).ToString("X6")));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, "", (Color)color, (Color)color, null));
            lvColorList.Items.Add(item);
            return true;
        }

        private void ListViewItemChangeColor(ListViewItem item, Color color)
		{
			item.UseItemStyleForSubItems = false;
			item.SubItems[1].Text = (color.ToArgb() & 0xFFFFFF).ToString("X6");
			item.SubItems[2].BackColor = color;
		}

		private void lvColorList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvColorList.SelectedItems.Count > 0)
			{
				ListViewItem item = lvColorList.SelectedItems[0];
				SelectedColor = item.SubItems[2].BackColor;
				SelectedIndex = lvColorList.SelectedItems[0].Index;
                lbSelectedColor.Text = item.SubItems[0].Text;
			}
			else
			{
				SelectedColor = null;
				SelectedIndex = -1;

                lbSelectedColor.Text = "N";
			}
		}

		private UInt32 ColorToBit(Color? color)
		{
			if (color == null)
				return 0;

			ListViewItem item = SearchListViewItem((Color)color);
			return UInt32.Parse(item.SubItems[0].Text);
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Dot selectedItem = matrix.SelectDot(MatrixArea, e.X, e.Y);
			if (selectedItem != null)
			{
				MouseDownDot = selectedItem;
				if (cbBrushColor.Checked)
				{
					if (selectedItem.BackColor != SelectedColor)
					{
						selectedItem.SetColor(SelectedColor, SelectedIndex);
						PointList.Add(new PointInfo(selectedItem.Column, selectedItem.Row, SelectedIndex));
						Rectangle rect = new Rectangle(
							(int)Math.Ceiling(MatrixArea.X),
							(int)Math.Ceiling(MatrixArea.Y),
							(int)Math.Ceiling(MatrixArea.Width),
							(int)Math.Ceiling(MatrixArea.Height)
							);
						Invalidate(rect, true);
                        bDrag = true;
                    }
                }
            }
        }

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (cbBrushColor.Checked && bDrag)
			{
				Dot selectedItem = matrix.SelectDot(MatrixArea, e.X, e.Y);
				if (selectedItem != null)
				{
					if(selectedItem.BackColor != SelectedColor)
					{
						selectedItem.SetColor(SelectedColor, SelectedIndex);
                        PointList.Add(new PointInfo(selectedItem.Column, selectedItem.Row, SelectedIndex));
                        bDrag = true;
						Rectangle rect = new Rectangle(
							(int)Math.Ceiling(MatrixArea.X),
							(int)Math.Ceiling(MatrixArea.Y),
							(int)Math.Ceiling(MatrixArea.Width),
							(int)Math.Ceiling(MatrixArea.Height)
							);
						Invalidate(rect, true);
					}
				}
			}
		}
		
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if(bDrag)
			{
				bDrag = false;
				Dot item = matrix.SelectDot(MatrixArea, e.X, e.Y);
				if (item != null)
				{
					if (cbBrushColor.Checked)
					{
						if (item.BackColor != SelectedColor)
						{
							item.SetColor(SelectedColor, SelectedIndex);
                            PointList.Add(new PointInfo(item.Column, item.Row, SelectedIndex));
                            Rectangle rect = new Rectangle(
								(int)Math.Ceiling(MatrixArea.X),
								(int)Math.Ceiling(MatrixArea.Y),
								(int)Math.Ceiling(MatrixArea.Width),
								(int)Math.Ceiling(MatrixArea.Height)
								);
							Invalidate(rect, true);
						}
					}
				}
				return;
			}


			Dot selectedItem = matrix.SelectDot(MatrixArea, e.X, e.Y);
			if (selectedItem != null)
			{
				if(selectedItem != MouseDownDot)
				{
					return;
				}
				selectedItem.ToggleFocus();

				if (selectedItem.Selected)
				{
					if (SelectedDot != null)
						SelectedDot.Selected = false;
					SelectedDot = selectedItem;

					if (SelectedColor != null)
					{
						if (cbBrushColor.Checked)
						{
							SelectedDot.SetColor(SelectedColor, SelectedIndex);
                            PointList.Add(new PointInfo(selectedItem.Column, selectedItem.Row, SelectedIndex));
                        }
						else if (cbFillAreaColor.Checked)
						{
							matrix.FillAreaColor(SelectedDot, SelectedDot.BackColor, SelectedColor);
						}
					}

					tlpProperty.Visible = true;
					lbRowValue.Text = selectedItem.Row.ToString();
					lbColValue.Text = selectedItem.Column.ToString();
					if (selectedItem.BackColor != null)
					{
						btnColorValue.BackColor = (Color)selectedItem.BackColor;
						btnColorValue.Text = (((Color)selectedItem.BackColor).ToArgb() & 0xFFFFFF).ToString("X");
					}
					else
					{
						btnColorValue.BackColor = (Color)SystemColors.Control;
						btnColorValue.Text = "";
					}
				}
				else
				{
					if (SelectedDot != null)
					{
						if (cbBrushColor.Checked)
						{
							SelectedDot.SetColor(null, -1);
                            PointList.RemoveAll(
								x => (x.X == selectedItem.Column) && (x.Y == selectedItem.Row));
                        }
                        SelectedDot = null;
					}
					tlpProperty.Visible = false;
				}

				Rectangle rect = new Rectangle(
					(int)Math.Ceiling(MatrixArea.X),
					(int)Math.Ceiling(MatrixArea.Y),
					(int)Math.Ceiling(MatrixArea.Width),
					(int)Math.Ceiling(MatrixArea.Height)
					);
				Invalidate(rect, true);
			}
			else
			{
				if (SelectedDot != null)
				{
					SelectedDot.Selected = false;
					SelectedDot = null;
					tlpProperty.Visible = false;

					Rectangle rect = new Rectangle(
						(int)Math.Ceiling(MatrixArea.X),
						(int)Math.Ceiling(MatrixArea.Y),
						(int)Math.Ceiling(MatrixArea.Width),
						(int)Math.Ceiling(MatrixArea.Height)
						);
					Invalidate(rect, true);
				}
			}
		}

		private void Form1_MouseLeave(object sender, EventArgs e)
		{
			if (bDrag)
			{
				bDrag = false;
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
		}

        private void btnLoadBackground_Click(object sender, EventArgs e)
        {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image File(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            DialogResult result = dialog.ShowDialog();

			if(result == DialogResult.OK)
            {
                backgroundBitmap = new Bitmap(dialog.FileName);
				this.Invalidate();
            }
        }

        private void btnRemoveBackground_Click(object sender, EventArgs e)
        {
			if(backgroundBitmap!=null)
			{
				backgroundBitmap.Dispose();
				backgroundBitmap = null;
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if ((resultDialog != null) &&
                (!resultDialog.IsDisposed))
            {
                resultDialog.StartPosition = FormStartPosition.Manual;
                resultDialog.Location = new Point(this.Left + this.Width, this.Top);
            }
        }

        private void btnSetBackgroundText_Click(object sender, EventArgs e)
        {
			backgroundText = txtBackgroundText.Text;
			Invalidate();
		}

        private void btnClearBackgroundText_Click(object sender, EventArgs e)
        {
			backgroundText = "";
			Invalidate();
		}

        private void btnBackgroundTextFont_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();

			DialogResult result = dialog.ShowDialog();
			if(result == DialogResult.OK)
			{
				backgroundTextFont = dialog.Font;

				nBackgroundTextSize.Value = (decimal)backgroundTextFont.Size;

				btnBackgroundTextFont.Text = backgroundTextFont.Name;
				btnBackgroundTextFont.Font = new Font(backgroundTextFont.Name, 9.0F);
				Invalidate();
			}
		}

        private void nBackgroundTextSize_ValueChanged(object sender, EventArgs e)
		{
			backgroundTextFont = new Font(backgroundTextFont.FontFamily, (float)nBackgroundTextSize.Value);
			Invalidate();
		}

        private void nBackgroundTextOffsetY_ValueChanged(object sender, EventArgs e)
		{
			Invalidate();
		}

        private void nBackgroundTextAlpha_ValueChanged(object sender, EventArgs e)
		{
			Invalidate();
		}

		private void SetDotRatio()
		{
			int Row = (int)nudRowCnt.Value;
			int Col = (int)nudColCnt.Value;
			float Width = MatrixArea.Width / Col;
			float Height = MatrixArea.Height / Row;
			lblCurrentRatio.Text = string.Format("{0:0.00#}x{1:0.00#} \n({2})", Width, Height, Width / Height);
		}

        private void nDotAlpha_ValueChanged(object sender, EventArgs e)
		{
			for(int cnt=0; cnt<3; cnt++)
			{
				ListViewItem item = lvColorList.Items[cnt];
				Color color = item.SubItems[2].BackColor;
				ListViewItemChangeColor(item, Color.FromArgb((int)nDotAlpha.Value, color.R, color.G, color.B));
			}

			SelectedColor = null;
			SelectedIndex = -1;
			lbSelectedColor.Text = "N";
			Invalidate();
		}
    }

    public class PointInfo
	{
        public int X { get; }
        public int Y { get; }
        public int Type { get; }
        public PointInfo(int x, int y, int t)
		{
			X = x;
			Y = y;
			Type = t;
		}
	}
}
