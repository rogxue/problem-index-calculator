using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemIndexCalculator
{
    public partial class MonthSelectionForm : Form
    {
        private List<DateIndexPair> dipList;
        public List<DateIndexPair> selectedDipList
        {
            get;
            set;
        }

        public MonthSelectionForm(Product p)
        {
            dipList = p.dipList;
            dipList.Sort((x, y) => DateTime.Compare(x.dt, y.dt));
            InitializeComponent();
            foreach (DateIndexPair dip in dipList)
            {
                monthBox.Items.Add(dip.GetDateText());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            selectedDipList = new List<DateIndexPair>();
            if (monthBox.SelectedItems == null)
            {
                Close();
            }
            else
            {
                foreach (String date in monthBox.SelectedItems)
                {
                    foreach (DateIndexPair dip in dipList)
                    {
                        if (date == dip.GetDateText())
                        {
                            selectedDipList.Add(dip);
                        }
                    }
                }
            }
            Hide();
        }
    }
}
