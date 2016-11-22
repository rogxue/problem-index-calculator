using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ProblemIndexCalculator
{
    public partial class MainForm : Form
    {
        private double rty, oba, agrr;
        private int hot, probIndex;
        private string date, dateText;
        private string file;
        private Product product;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Sustained Product Quality Index Calculator v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DateTime d = DateTime.Now;
            dateText = d.ToString("MMMM yyyy");
            date = d.Month.ToString().PadLeft(2, '0') + d.Year;
            lblMonth.Text = dateText;
            DisableItems();
            //
            // Killing calculator button in favor of live updating
            //
            btnCalc.Visible = false;
            //
            // Kill save functions, no need for now
            //
            saveAsToolStripMenuItem.Visible = false;
            saveToolStripMenuItem.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                ParseNumbers();
            }
            catch
            {
                lblIndex.Text = "Invalid input.";
                btnSave.Enabled = false;
                return;
            }
            CalculateProblemIndex();
        }

        private void LiveUpdateProblemIndex()
        {
            try
            {
                ParseNumbers();
            }
            catch
            {
                lblIndex.Text = "Invalid input.";
                btnSave.Enabled = false;
                return;
            }
            CalculateProblemIndex();
        }

        private void ParseNumbers()
        {
            bool tripped = false;
            try
            {
                rty = Double.Parse(txtRty.Text);
                if (rty < 0 || rty > 100)
                {
                    txtRty.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtRty.ForeColor = Color.Red;
                tripped = true;
            }

            try
            {
                oba = Double.Parse(txtOba.Text);
                if (oba < 0)
                {
                    txtOba.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtOba.ForeColor = Color.Red;
                tripped = true;
            }
            try
            {
                hot = int.Parse(txtHot.Text);
                if (hot < 0)
                {
                    txtHot.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtHot.ForeColor = Color.Red;
                tripped = true;
            }

            try
            {
                agrr = Double.Parse(txtAgrr.Text);
                if (agrr < 0 || agrr > 100)
                {
                    txtAgrr.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtAgrr.ForeColor = Color.Red;
                tripped = true;
            }

            if (tripped)
            {
                throw new Exception();
            }
        }

        private void CalculateProblemIndex()
        {
            int rtyNorm = 0, obaNorm = 0, hotNorm = hot, agrrNorm = 0;

            if (rty < product.rtyCutoff1)
            {
                rtyNorm = 3;
                if (rty < product.rtyCutoff2)
                {
                    rtyNorm = 5;
                }
            }
            if (oba > product.obaCutoff1)
            {
                obaNorm = 3;
                if (oba > product.obaCutoff2)
                {
                    obaNorm = 5;
                }
            }
            if (agrr > product.agrrCutoff1)
            {
                agrrNorm = 3;
                if (agrr > product.agrrCutoff2)
                {
                    agrrNorm = 5;
                }
            }
            txtRtyNorm.Text = rtyNorm.ToString();
            txtObaNorm.Text = obaNorm.ToString();
            txtHotNorm.Text = hotNorm.ToString();
            txtAgrrNorm.Text = agrrNorm.ToString();
            txtRtyScore.Text = (product.rtyWeight * rtyNorm).ToString();
            txtObaScore.Text = (product.obaWeight * obaNorm).ToString();
            txtHotScore.Text = (product.hotWeight * hotNorm).ToString();
            txtAgrrScore.Text = (product.agrrWeight * agrrNorm).ToString();
            probIndex = product.rtyWeight * rtyNorm
                + product.obaWeight * obaNorm
                + product.agrrWeight * agrrNorm
                + product.hotWeight * hotNorm;
            lblIndex.Text = "SPQ Index: " + probIndex.ToString();
            btnSave.Enabled = true;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //btnSave.Enabled = false;
            DateTime d = monthCalendar.SelectionRange.Start;
            dateText = d.ToString("MMMM yyyy");
            date = d.Month.ToString().PadLeft(2, '0') + d.Year;
            lblMonth.Text = dateText;
            SetActiveProblemIndex();

        }

        private void SetActiveProblemIndex()
        {
            bool active = false;
            foreach (DateIndexPair dip in product.dipList)
            {
                if (dip.date == date)
                {
                    lblActiveIndex.Text = "Problem Index: " + dip.probIndex.ToString();
                    lblActiveIndex.Visible = true;
                    active = true;
                    break;
                }
            }
            if (!active)
            {
                lblActiveIndex.Visible = false;
            }
        }

        private void txtRty_TextChanged(object sender, EventArgs e)
        {
            txtRty.ForeColor = Color.Black;
            LiveUpdateProblemIndex();
        }

        private void txtOba_TextChanged(object sender, EventArgs e)
        {
            txtOba.ForeColor = Color.Black;
            LiveUpdateProblemIndex();
        }

        private void txtHot_TextChanged(object sender, EventArgs e)
        {
            txtHot.ForeColor = Color.Black;
            LiveUpdateProblemIndex();
        }

        private void txtAgrr_TextChanged(object sender, EventArgs e)
        {
            txtAgrr.ForeColor = Color.Black;
            LiveUpdateProblemIndex();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Properties.Settings.Default.directory;
            ofd.RestoreDirectory = true;
            ofd.Filter = "XML Files (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file = ofd.FileName;
                    Properties.Settings.Default.directory = file.Substring(0, file.LastIndexOf('\\'));
                    Properties.Settings.Default.Save();
                    ParseXml(file);
                    SetWeightValues();
                    EnableItems();
                }
                catch
                {
                    MessageBox.Show("Error: File invalid or corrupt.");
                }
            }
        }

        private void resetDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will erase all existing data.", "Reset data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                product.dipList = new List<DateIndexPair>();
                product.WriteToXml(file);
                SetActiveProblemIndex();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(product, true);
            edit.StartPosition = FormStartPosition.CenterParent;
            edit.ShowDialog();
            if (edit.GetConfirm())
            {
                product.WriteToXml(file);
                SetWeightValues();
            }
            edit.Dispose();
            lblProduct.Text = product.name;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            EditForm edit = new EditForm(newProduct);
            edit.SetFormName("New Product File");
            edit.StartPosition = FormStartPosition.CenterParent;
            edit.ShowDialog();
            if (edit.GetConfirm())
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML Files (*.xml)|*.xml";
                sfd.FileName = edit.GetProductName();
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    file = sfd.FileName;
                    Properties.Settings.Default.directory = file.Substring(0, file.LastIndexOf('\\'));
                    Properties.Settings.Default.Save();
                    newProduct.WriteToXml(file);
                    product = newProduct;
                    lblProduct.Text = product.name;
                    SetWeightValues();
                    EnableItems();
                    lblActiveIndex.Visible = false;
                }
            }
            edit.Dispose();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String data = "Product Name: " + product.name + "\n";
            data += "Product Target: " + product.target.ToString() + "\n\n";
            List<DateIndexPair> dipList = product.dipList;
            dipList.Sort((x, y) => DateTime.Compare(x.dt, y.dt));
            foreach (DateIndexPair dip in dipList)
            {
                data += dip.GetShortDateText() + ":\t\t" + dip.probIndex.ToString() + Environment.NewLine;
            }
            MessageBox.Show(data, "SPQi Data");
        }

        private void createChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (product.dipList.Count != 0)
            {
                Chart c = new Chart(product);
                c.Show();
            }
            else
            {
                MessageBox.Show("No data available.", "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (DateIndexPair dip in product.dipList)
            {
                if (dip.date == date)
                {
                    exists = true;
                    DialogResult dialogResult = MessageBox.Show("Data has already been recorded\n" + "for " + dateText + ". Overwrite?", "Overwrite existing data?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dip.probIndex = probIndex;
                        product.WriteToXml(file);
                        SetActiveProblemIndex();
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        break;
                    }
                }
            }
            if (!exists)
            {
                product.dipList.Add(new DateIndexPair(date, probIndex));
                product.WriteToXml(file);
                SetActiveProblemIndex();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problem Index Calculator v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n\n"
                + "Copyright © 2016 Roger Xue\n"
                + "Copyright © 2016 Avocados Only, Inc.\n\n"
                + "All rights reserved.",
                "About");
        }

        private void ParseXml(string filename)
        {
            product = new Product();
            String date = "";
            XmlTextReader reader = new XmlTextReader(filename);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if (reader.Name == "Name")
                        {
                            reader.Read();
                            product.name = reader.Value;
                        }
                        else if (reader.Name == "Target")
                        {
                            reader.Read();
                            product.target = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "RtyWeight")
                        {
                            reader.Read();
                            product.rtyWeight = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "ObaWeight")
                        {
                            reader.Read();
                            product.obaWeight = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "HotWeight")
                        {
                            reader.Read();
                            product.hotWeight = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "AgrrWeight")
                        {
                            reader.Read();
                            product.agrrWeight = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "RtyCutoff1")
                        {
                            reader.Read();
                            product.rtyCutoff1 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "RtyCutoff2")
                        {
                            reader.Read();
                            product.rtyCutoff2 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "ObaCutoff1")
                        {
                            reader.Read();
                            product.obaCutoff1 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "ObaCutoff2")
                        {
                            reader.Read();
                            product.obaCutoff2 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "AgrrCutoff1")
                        {
                            reader.Read();
                            product.agrrCutoff1 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "AgrrCutoff2")
                        {
                            reader.Read();
                            product.agrrCutoff2 = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "Date")
                        {
                            reader.Read();
                            date = reader.Value;
                        }
                        else if (reader.Name == "Index")
                        {
                            reader.Read();
                            product.dipList.Add(new DateIndexPair(date, int.Parse(reader.Value)));
                        }
                        break;
                }
            }
            reader.Close();
            lblProduct.Text = product.name;
            lblProductLabel.Visible = true;
            lblProduct.Visible = true;
            SetActiveProblemIndex();
        }

        private void DisableItems()
        {
            btnCalc.Enabled = false;
            txtAgrr.Enabled = false;
            txtHot.Enabled = false;
            txtOba.Enabled = false;
            txtRty.Enabled = false;
            monthCalendar.Enabled = false;
            dataToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            lblProductLabel.Visible = false;
            lblProduct.Visible = false;
        }

        private void EnableItems()
        {
            btnCalc.Enabled = true;
            txtAgrr.Enabled = true;
            txtHot.Enabled = true;
            txtOba.Enabled = true;
            txtRty.Enabled = true;
            monthCalendar.Enabled = true;
            dataToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            //
            // Default values
            //
            txtRty.Text = "100";
            txtOba.Text = "0";
            txtHot.Text = "0";
            txtAgrr.Text = "0";
        }

        private void SetWeightValues()
        {
            txtRtyWeight.Text = product.rtyWeight.ToString();
            txtObaWeight.Text = product.obaWeight.ToString();
            txtHotWeight.Text = product.hotWeight.ToString();
            txtAgrrWeight.Text = product.agrrWeight.ToString();
        }
    }
}
