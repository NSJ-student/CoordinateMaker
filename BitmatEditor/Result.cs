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

namespace BitmatEditor
{
	public partial class Result : Form
    {
        GraphicsPath drawPath;

        public Result()
		{
			InitializeComponent();

			drawPath = null;

        }

        public void ListAbsPoints(List<PointInfo> list, int row, int col)
        {
			rtbResult.Clear();
			dgvResult.Rows.Clear();

			for (int cnt = 0; cnt < list.Count; cnt++)
            {
                PointInfo info = list[cnt];
                rtbResult.AppendText(
                        string.Format("{0}: {1}, {2}\n",
                            GetName(info.Type), info.X, row - 1 - info.Y)
                    );
				dgvResult.Rows.Add(
					(cnt+1).ToString(),
					info.X.ToString("0.00#") + "F",
					(row - 1 - info.Y).ToString("0.00#") + "F",
					GetName(info.Type));
			}
        }

        public void ListRelativePoints(List<PointInfo> list, int row, int col)
        {
            rtbResult.Clear();
			dgvResult.Rows.Clear();

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
			int selectedCnt = dgvResult.SelectedRows.Count;
			if(selectedCnt < 2)
            {
				return;
            }

			rtbGenCode.Clear();

			rtbGenCode.AppendText(string.Format("GraphicsPath path{0} = new GraphicsPath();\n", txtVarSuffix.Text));
			
			for (int row = 0; row < selectedCnt-1; row++)
			{
				string X1 = (string)dgvResult.SelectedRows[row].Cells[1].Value;
				string Y1 = (string)dgvResult.SelectedRows[row].Cells[2].Value;
				string X2 = (string)dgvResult.SelectedRows[row+1].Cells[1].Value;
				string Y2 = (string)dgvResult.SelectedRows[row+1].Cells[2].Value;

				rtbGenCode.AppendText(string.Format("path{0}.AddLine(offsetX + ({1} * width), offsetY + ({2} * height),\n", txtVarSuffix.Text, X1, Y1));
				rtbGenCode.AppendText(string.Format("             offsetX + ({0} * width), offsetY + ({1} * height));\n", X2, Y2));
			}

			rtbGenCode.AppendText(string.Format("graphicPath.Add(path{0});\n", txtVarSuffix.Text));
			DrawLine();
        }

        private void btnArcCode_Click(object sender, EventArgs e)
		{
			int selectedCnt = dgvResult.SelectedRows.Count;
			if (selectedCnt < 2)
			{
				return;
			}

			rtbGenCode.Clear();
			rtbGenCode.AppendText(string.Format("var pointss{0} = new PointF[]\n{\n", txtVarSuffix.Text));

			for (int row = 0; row < selectedCnt; row++)
			{
				string X = (string)dgvResult.SelectedRows[row].Cells[1].Value;
				string Y = (string)dgvResult.SelectedRows[row].Cells[2].Value;

				rtbGenCode.AppendText(string.Format("\tnew PointF(offsetX + ({0} * width), offsetY + ({1} * height)),\n", X, Y));
			}

			rtbGenCode.AppendText("};\n");

        }

		private void DrawLine()
        {
            int selectedCnt = dgvResult.SelectedRows.Count;
            if (selectedCnt < 2)
            {
                return;
            }

			int offsetX = 0;
			int offsetY = 0;
			int width = 64;
			int height = 52;

            drawPath = new GraphicsPath();

            for (int row = 0; row < selectedCnt-1; row++)
            {
                double X1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[1].Value.ToString().Replace("F", ""));
                double Y1 = Convert.ToDouble(dgvResult.SelectedRows[row].Cells[2].Value.ToString().Replace("F", ""));
                double X2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[1].Value.ToString().Replace("F", ""));
                double Y2 = Convert.ToDouble(dgvResult.SelectedRows[row + 1].Cells[2].Value.ToString().Replace("F", ""));

				drawPath.AddLine((float)(offsetX + (X1 * width)), (float)(offsetY + (Y1 * height)),
                                 (float)(offsetX + (X2 * width)), (float)(offsetY + (Y2 * height)));
            }


            Matrix flipYMatrix = new Matrix(1, 0, 0, -1, 0, pDrawPath.Height / 2);
            Matrix transformMatrix = new Matrix();
            transformMatrix.Multiply(flipYMatrix);
            transformMatrix.Translate(pDrawPath.Width / 4, 0, MatrixOrder.Append);
            drawPath.Transform(transformMatrix);
            pDrawPath.Invalidate();
        }

        private void pDrawPath_Paint(object sender, PaintEventArgs e)
        {
            if (drawPath != null)
            {
                drawPath.StartFigure(); // Start the firstfigure.

                e.Graphics.DrawPath(new Pen(Color.Black, (float)2), drawPath);
                drawPath.CloseFigure();
            }
        }
    }
}
