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
		public Result()
		{
			InitializeComponent();
		}

        public void ListAbsPoints(List<PointInfo> list, int row, int col)
        {
			rtbResult.Clear();
            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                PointInfo info = list[cnt];
                rtbResult.AppendText(
                        string.Format("{0}: {1}, {2}\n",
                            GetName(info.Type), info.X, row - 1 - info.Y)
                    );
            }
        }

        public void ListRelativePoints(List<PointInfo> list, int row, int col)
        {
            rtbResult.Clear();
            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                PointInfo info = list[cnt];
				float rel_x = (float)(info.X) / (float)col;
                float rel_y = (float)(row-1-info.Y) / (float)row;

                rtbResult.AppendText(
                        string.Format("{0}: {1}*width, {2}*height\n",
                            GetName(info.Type), rel_x, rel_y)
                    );
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
	}
}
