using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BitmatEditor
{
	public partial class Result : Form
    {
        GraphicsPath drawPath;
        GraphicsPath selectedDotPath;
        int Row;
		int Col;
        bool? IsRelative;

        public Result()
		{
			InitializeComponent();

            selectedDotPath = null;
            drawPath = null;
            selectedDotPath = null;
            Row = 1;
			Col = 1;
            IsRelative = null;
        }

        public void ListAbsPoints(List<PointInfo> list, int row, int col)
        {
            lblStatus.Text = "Absolute Points";
            IsRelative = false;

            drawPath = null;
            selectedDotPath = null;
            rtbResult.Clear();
			dgvResult.Rows.Clear();
            Row = row;
            Col = col;

            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                PointInfo info = list[cnt];
                rtbResult.AppendText(
                        string.Format("{0}: {1}, {2}\n",
                            GetName(info.Type), info.X, row - 1 - info.Y)
                    );
				dgvResult.Rows.Add(
					(cnt+1).ToString(),
					info.X.ToString("0.00#"),
					(row - 1 - info.Y).ToString("0.00#"),
					GetName(info.Type));
			}

            pDrawPath.Invalidate();
        }

        public void ListRelativePoints(List<PointInfo> list, int row, int col)
        {
            lblStatus.Text = "Relative Points";
            IsRelative = true;

            drawPath = null;
            selectedDotPath = null;
            rtbResult.Clear();
			dgvResult.Rows.Clear();
            Row = row;
            Col = col;

            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                PointInfo info = list[cnt];
				float rel_x = (float)(info.X) / (float)col;
                float rel_y = (float)(row-1-info.Y) / (float)row;

				rtbResult.AppendText(
						string.Format("offsetX + ({0:0.00#}F * width), offsetY + ({1:0.00#}F * height)\n", rel_x, rel_y)
					);

				dgvResult.Rows.Add(
					(cnt + 1).ToString(),
					rel_x.ToString("0.00#") + "F",
					rel_y.ToString("0.00#") + "F",
					GetName(info.Type));
			}

            pDrawPath.Invalidate();
        }

        private string GetName(int index)
		{
			switch(index)
			{
				case 0:  return "Line ";
				case 1:  return "Arc  ";
				case 2:  return "Point";
				default: return "None ";
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string path = Path.Combine(dialog.SelectedPath, "test.txt");
				//string path = "test.txt";
				FileStream stream;
				if(!File.Exists(path))
				{
					try
					{
						File.Create(path, 1024).Close();
					}
					catch(FileNotFoundException em)
					{
						MessageBox.Show(string.Format("Access Denied to [{0}]", dialog.SelectedPath), "Access Denied");
						return;
					}
				}
				stream = File.Open(path, FileMode.Open);

				rtbResult.SaveFile(stream, RichTextBoxStreamType.PlainText);
				stream.Close();
			}
		}

        private void btnClearCode_Click(object sender, EventArgs e)
		{
			rtbGenCode.Clear();
		}

        private void btnLineCode_Click(object sender, EventArgs e)
        {
            if (IsRelative == null)
            {
                return;
            }
            if (dgvResult.RowCount < 2)
            {
                return;
            }

            int selectedCnt = dgvResult.SelectedRows.Count;
            rtbGenCode.Clear();
            rtbGenCode.AppendText(string.Format("GraphicsPath path{0} = new GraphicsPath();\n", txtVarSuffix.Text));

            if (selectedCnt < 2)
            {
                for (int row = 0; row < dgvResult.RowCount - 1; row++)
                {
                    string X1 = (string)dgvResult.Rows[row].Cells[1].Value;
                    string Y1 = (string)dgvResult.Rows[row].Cells[2].Value;
                    string X2 = (string)dgvResult.Rows[row + 1].Cells[1].Value;
                    string Y2 = (string)dgvResult.Rows[row + 1].Cells[2].Value;

                    if (IsRelative == true)
                    {
                        rtbGenCode.AppendText(string.Format("path{0}.AddLine(offsetX + ({1} * width), offsetY + ({2} * height),\n", txtVarSuffix.Text, X1, Y1));
                        rtbGenCode.AppendText(string.Format("             offsetX + ({0} * width), offsetY + ({1} * height));\n", X2, Y2));
                    }
                    else if (IsRelative == false)
                    {
                        rtbGenCode.AppendText(string.Format("path{0}.AddLine({1}, {2}, {3}, {4});\n", txtVarSuffix.Text, X1, Y1, X2, Y2));
                    }
                }
            }
            else
            {
                for (int row = 0; row < selectedCnt - 1; row++)
                {
                    string X1 = (string)dgvResult.SelectedRows[row].Cells[1].Value;
                    string Y1 = (string)dgvResult.SelectedRows[row].Cells[2].Value;
                    string X2 = (string)dgvResult.SelectedRows[row + 1].Cells[1].Value;
                    string Y2 = (string)dgvResult.SelectedRows[row + 1].Cells[2].Value;

                    if (IsRelative == true)
                    {
                        rtbGenCode.AppendText(string.Format("path{0}.AddLine(offsetX + ({1} * width), offsetY + ({2} * height),\n", txtVarSuffix.Text, X1, Y1));
                        rtbGenCode.AppendText(string.Format("             offsetX + ({0} * width), offsetY + ({1} * height));\n", X2, Y2));
                    }
                    else if (IsRelative == false)
                    {
                        rtbGenCode.AppendText(string.Format("path{0}.AddLine({1}, {2}, {3}, {4});\n", txtVarSuffix.Text, X1, Y1, X2, Y2));
                    }
                }
            }

			rtbGenCode.AppendText(string.Format("graphicPath.Add(path{0});\n", txtVarSuffix.Text));
			DrawLine();
        }

        private void btnArcCode_Click(object sender, EventArgs e)
        {
            if (IsRelative == null)
            {
                return;
            }
            if (dgvResult.RowCount < 2)
            {
                return;
            }

            int selectedCnt = dgvResult.SelectedRows.Count;
            rtbGenCode.Clear();
            rtbGenCode.AppendText(string.Format("var pointss{0} = new PointF[]\n{{\n", txtVarSuffix.Text));

            if (selectedCnt < 2)
            {
                for (int row = 0; row < dgvResult.RowCount; row++)
                {
                    string X = (string)dgvResult.Rows[row].Cells[1].Value;
                    string Y = (string)dgvResult.Rows[row].Cells[2].Value;

                    if (IsRelative == true)
                    {
                        rtbGenCode.AppendText(string.Format("\tnew PointF(offsetX + ({0} * width), offsetY + ({1} * height)),\n", X, Y));
                    }
                    else if (IsRelative == false)
                    {
                        rtbGenCode.AppendText(string.Format("\tnew PointF({0}, {1}),\n", X, Y));
                    }
                }
            }
            else
            {
                for (int row = 0; row < selectedCnt; row++)
                {
                    string X = (string)dgvResult.SelectedRows[row].Cells[1].Value;
                    string Y = (string)dgvResult.SelectedRows[row].Cells[2].Value;

                    if (IsRelative == true)
                    {
                        rtbGenCode.AppendText(string.Format("\tnew PointF(offsetX + ({0} * width), offsetY + ({1} * height)),\n", X, Y));
                    }
                    else if (IsRelative == false)
                    {
                        rtbGenCode.AppendText(string.Format("\tnew PointF({0}, {1}),\n", X, Y));
                    }
                }
            }

            rtbGenCode.AppendText("}};\n");

        }

		private void DrawLine()
        {
            if (IsRelative == null)
            {
                return;
            }
            if (dgvResult.RowCount < 2)
            {
                return;
            }

            int selectedCnt = dgvResult.SelectedRows.Count;
            int offsetX = 0;
            int offsetY = 0;
            int width = Col;
            int height = Row;

            selectedDotPath = null;
            drawPath = new GraphicsPath();

            if (selectedCnt < 2)
            {
                for (int row = 0; row < dgvResult.RowCount - 1; row++)
                {
                    double X1 = Convert.ToDouble(dgvResult.Rows[row].Cells[1].Value.ToString().Replace("F", ""));
                    double Y1 = Convert.ToDouble(dgvResult.Rows[row].Cells[2].Value.ToString().Replace("F", ""));
                    double X2 = Convert.ToDouble(dgvResult.Rows[row + 1].Cells[1].Value.ToString().Replace("F", ""));
                    double Y2 = Convert.ToDouble(dgvResult.Rows[row + 1].Cells[2].Value.ToString().Replace("F", ""));

                    if (IsRelative == true)
                    {
                        drawPath.AddLine((float)(offsetX + (X1 * width)), (float)(offsetY + (Y1 * height)),
                                         (float)(offsetX + (X2 * width)), (float)(offsetY + (Y2 * height)));
                    }
                    else if (IsRelative == false)
                    {
                        drawPath.AddLine((float)X1, (float)Y1, (float)X2, (float)Y2);
                    }
                }
            }
            else
            {
                for (int row = 0; row < selectedCnt - 1; row++)
                {
                    double X1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[1].Value.ToString().Replace("F", ""));
                    double Y1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[2].Value.ToString().Replace("F", ""));
                    double X2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[1].Value.ToString().Replace("F", ""));
                    double Y2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[2].Value.ToString().Replace("F", ""));

                    if (IsRelative == true)
                    {
                        drawPath.AddLine((float)(offsetX + (X1 * width)), (float)(offsetY + (Y1 * height)),
                                         (float)(offsetX + (X2 * width)), (float)(offsetY + (Y2 * height)));
                    }
                    else if (IsRelative == false)
                    {
                        drawPath.AddLine((float)X1, (float)Y1, (float)X2, (float)Y2);
                    }
                }
            }

            Matrix flipYMatrix = new Matrix(1, 0, 0, -1, 0, pDrawPath.Height / 2);
            Matrix transformMatrix = new Matrix();
            transformMatrix.Multiply(flipYMatrix);
            transformMatrix.Translate(pDrawPath.Width / 2, 0, MatrixOrder.Append);
            drawPath.Transform(transformMatrix);
            pDrawPath.Invalidate();
        }

        private void pDrawPath_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray);
            // 가로줄
            e.Graphics.DrawLine(pen, pDrawPath.Width / 2, 0, pDrawPath.Width / 2, pDrawPath.Height);
            // 세로줄
            e.Graphics.DrawLine(pen, 0, pDrawPath.Height / 2, Width, pDrawPath.Height / 2);

            if (drawPath != null)
            {
                drawPath.StartFigure(); // Start the firstfigure.

                e.Graphics.DrawPath(new Pen(Color.Black, (float)2), drawPath);
                drawPath.CloseFigure();
            }

            if (selectedDotPath != null)
            {
                selectedDotPath.StartFigure(); // Start the firstfigure.

                e.Graphics.DrawPath(new Pen(Color.Red, (float)1), selectedDotPath);
                selectedDotPath.CloseFigure();
            }
        }

        private void btnGeneratePoints_Click(object sender, EventArgs e)
        {
            if (IsRelative == null)
            {
                return;
            }
            if (dgvResult.RowCount < 2)
            {
                return;
            }
            int selectedCnt = dgvResult.SelectedRows.Count;

            selectedDotPath = null;
            drawPath = new GraphicsPath();
            dgvPoints.Rows.Clear();

            int offsetX = 0;
            int offsetY = 0;
            int width = (int)nudColCnt.Value;
			int height = (int)nudRowCnt.Value;
			int rotate = (int)nudRotate.Value;

            if (selectedCnt < 2)
            {
                for (int row = 0; row < dgvResult.RowCount - 1; row++)
                {
                    double X1 = Convert.ToDouble(dgvResult.Rows[row].Cells[1].Value.ToString().Replace("F", ""));
                    double Y1 = Convert.ToDouble(dgvResult.Rows[row].Cells[2].Value.ToString().Replace("F", ""));
                    double X2 = Convert.ToDouble(dgvResult.Rows[row + 1].Cells[1].Value.ToString().Replace("F", ""));
                    double Y2 = Convert.ToDouble(dgvResult.Rows[row + 1].Cells[2].Value.ToString().Replace("F", ""));

                    if (IsRelative == true)
                    {
                        drawPath.AddLine((float)(offsetX + (X1 * width)), (float)(offsetY + (Y1 * height)),
                                         (float)(offsetX + (X2 * width)), (float)(offsetY + (Y2 * height)));
                    }
                    else if (IsRelative == false)
                    {
                        drawPath.AddLine((float)(X1), (float)(Y1), (float)(X2), (float)(Y2));
                    }
                }
            }
            else
            {
                for (int row = 0; row < selectedCnt - 1; row++)
                {
                    double X1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[1].Value.ToString().Replace("F", ""));
                    double Y1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[2].Value.ToString().Replace("F", ""));
                    double X2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[1].Value.ToString().Replace("F", ""));
                    double Y2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[2].Value.ToString().Replace("F", ""));

                    if (IsRelative == true)
                    {
                        drawPath.AddLine((float)(offsetX + (X1 * width)), (float)(offsetY + (Y1 * height)),
                                         (float)(offsetX + (X2 * width)), (float)(offsetY + (Y2 * height)));
                    }
                    else if (IsRelative == false)
                    {
                        drawPath.AddLine((float)(X1), (float)(Y1), (float)(X2), (float)(Y2));
                    }
                }
            }

			if(rotate != 0)
            {
                Matrix mx = new Matrix();
                mx.RotateAt(rotate, new PointF(0, 0));
                drawPath.Transform(mx);
            }

            /* store points in a list */
            var list_of_points = new List<PointF>(drawPath.PathPoints);
            /* show them */
            int i = 1;
            foreach (var point in list_of_points)
            {
                dgvPoints.Rows.Add(
                    i.ToString(),
                    point.X.ToString("0.00#"),
                    point.Y.ToString("0.00#"));

                i++;
            }

            Matrix flipYMatrix = new Matrix(1, 0, 0, -1, 0, pDrawPath.Height / 2);
            Matrix transformMatrix = new Matrix();
            transformMatrix.Multiply(flipYMatrix);
            transformMatrix.Translate(pDrawPath.Width / 2, 0, MatrixOrder.Append);
            drawPath.Transform(transformMatrix);
            pDrawPath.Invalidate();
        }

        private void dgvPoints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPoints.SelectedCells.Count == 0)
            {
                return;
            }

            int row = dgvPoints.SelectedCells[0].RowIndex;

            string str_x = (string)dgvPoints.Rows[row].Cells[1].Value;
            string str_y = (string)dgvPoints.Rows[row].Cells[2].Value;

            if ((str_x == null) || (str_y == null))
            {
                return;
            }

            double x = Convert.ToDouble(str_x);
            double y = Convert.ToDouble(str_y);

            selectedDotPath = new GraphicsPath();
            selectedDotPath.AddEllipse(new RectangleF((float)(x - 2.5), (float)(y - 2.5), 5, 5));

            Matrix flipYMatrix = new Matrix(1, 0, 0, -1, 0, pDrawPath.Height / 2);
            Matrix transformMatrix = new Matrix();
            transformMatrix.Multiply(flipYMatrix);
            transformMatrix.Translate(pDrawPath.Width / 2, 0, MatrixOrder.Append);
            selectedDotPath.Transform(transformMatrix);
            pDrawPath.Invalidate();
        }
    }
}
