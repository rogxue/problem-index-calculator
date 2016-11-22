using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProblemIndexCalculator
{
    public partial class Chart : Form
    {
        private List<DateIndexPair> dipList;
        private int target = 30;

        public Chart(Product p)
        {
            dipList = p.dipList;
            dipList.Sort((x, y) => DateTime.Compare(x.dt, y.dt));
            target = p.target;
            InitializeComponent();

            foreach (DateIndexPair dip in dipList)
            {
                chart1.Series[0].Points.AddXY(dip.dt, dip.probIndex);
                Console.WriteLine(dip.dt.ToString() + " " + dip.probIndex);
            }
            chart1.Series[1].Points.AddXY(dipList[0].dt, target);
            chart1.Series[1].Points.AddXY(dipList[dipList.Count - 1].dt, target);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(160, Color.Black);
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(160, Color.Black);
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.FromArgb(120, Color.Black);
            chart1.Titles[0].Text = p.name + " SPQi";
            chart1.Update();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files (*.png)|*.png";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String file = sfd.FileName;
                Properties.Settings.Default.directory = file.Substring(0, file.LastIndexOf('\\'));
                Properties.Settings.Default.Save();
                this.chart1.SaveImage(file, ChartImageFormat.Png);
                MessageBox.Show("Chart saved successfully.", "Message");
            }
        }
    }
}
