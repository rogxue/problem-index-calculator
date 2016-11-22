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
    public partial class EditForm : Form
    {
        private Product product;
        private bool confirm = false;
        private string productName = "";

        public EditForm(Product p)
        {
            product = p;
            InitializeComponent();
            //
            // DEFAULT SETTINGS
            // 
            txtBoxTarget.Text = "30";
            txtBoxRtyWeight.Text = "1";
            txtBoxObaWeight.Text = "3";
            txtBoxHotWeight.Text = "7";
            txtBoxAgrrWeight.Text = "5";
            txtBoxRtyCutoff1.Text = "95";
            txtBoxRtyCutoff2.Text = "85";
            txtBoxObaCutoff1.Text = "1200";
            txtBoxObaCutoff2.Text = "1500";
            txtBoxAgrrCutoff1.Text = "5";
            txtBoxAgrrCutoff2.Text = "15";
        }

        public EditForm(Product p, Boolean b)
        {
            product = p;
            InitializeComponent();
            FillInEditSettingsForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool tripped = false;
            product.name = txtBoxName.Text;
            try     // TARGET
            {
                product.target = int.Parse(txtBoxTarget.Text);
                if (product.target < 0)
                {
                    txtBoxTarget.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxTarget.ForeColor = Color.Red;
                tripped = true;
            }
            try // RTY Weight
            {
                product.rtyWeight = int.Parse(txtBoxRtyWeight.Text);
                if (product.rtyWeight < 0)
                {
                    txtBoxRtyWeight.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxRtyWeight.ForeColor = Color.Red;
                tripped = true;
            }
            try // OBA Weight
            {
                product.obaWeight = int.Parse(txtBoxObaWeight.Text);
                if (product.obaWeight < 0)
                {
                    txtBoxObaWeight.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxObaWeight.ForeColor = Color.Red;
                tripped = true;
            }
            try // HOT Weight
            {
                product.hotWeight = int.Parse(txtBoxHotWeight.Text);
                if (product.hotWeight < 0)
                {
                    txtBoxHotWeight.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxHotWeight.ForeColor = Color.Red;
                tripped = true;
            }
            try // AGRR Weight
            {
                product.agrrWeight = int.Parse(txtBoxAgrrWeight.Text);
                if (product.agrrWeight < 0)
                {
                    txtBoxAgrrWeight.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxAgrrWeight.ForeColor = Color.Red;
                tripped = true;
            }
            try // RTY math logic
            {
                product.rtyCutoff1 = int.Parse(txtBoxRtyCutoff1.Text);
                product.rtyCutoff2 = int.Parse(txtBoxRtyCutoff2.Text);
                if (product.rtyCutoff1 < 0 || product.rtyCutoff2 < 0 || product.rtyCutoff2 > product.rtyCutoff1)
                {
                    txtBoxRtyCutoff1.ForeColor = Color.Red;
                    txtBoxRtyCutoff2.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxRtyCutoff1.ForeColor = Color.Red;
                txtBoxRtyCutoff2.ForeColor = Color.Red;
                tripped = true;
            }
            try // OBA math logic
            {
                product.obaCutoff1 = int.Parse(txtBoxObaCutoff1.Text);
                product.obaCutoff2 = int.Parse(txtBoxObaCutoff2.Text);
                if (product.obaCutoff1 < 0 || product.obaCutoff2 < 0 || product.obaCutoff2 < product.obaCutoff1)
                {
                    txtBoxObaCutoff1.ForeColor = Color.Red;
                    txtBoxObaCutoff2.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxObaCutoff1.ForeColor = Color.Red;
                txtBoxObaCutoff2.ForeColor = Color.Red;
                tripped = true;
            }
            try // AGRR math logic
            {
                product.agrrCutoff1 = int.Parse(txtBoxAgrrCutoff1.Text);
                product.agrrCutoff2 = int.Parse(txtBoxAgrrCutoff2.Text);
                if (product.agrrCutoff1 < 0 || product.agrrCutoff2 < 0 || product.agrrCutoff2 < product.agrrCutoff1)
                {
                    txtBoxAgrrCutoff1.ForeColor = Color.Red;
                    txtBoxAgrrCutoff2.ForeColor = Color.Red;
                    tripped = true;
                }
            }
            catch
            {
                txtBoxAgrrCutoff1.ForeColor = Color.Red;
                txtBoxAgrrCutoff2.ForeColor = Color.Red;
                tripped = true;
            }
            if (tripped)
            {
                MessageBox.Show("Invalid input.", "Error");
            }
            else
            {
                confirm = true;
                productName = txtBoxName.Text;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxTarget_TextChanged(object sender, EventArgs e)
        {
            txtBoxTarget.ForeColor = Color.Black;
        }

        private void FillInEditSettingsForm()
        {
            txtBoxName.Text = product.name;
            txtBoxTarget.Text = product.target.ToString();
            txtBoxRtyWeight.Text = product.rtyWeight.ToString();
            txtBoxObaWeight.Text = product.obaWeight.ToString();
            txtBoxHotWeight.Text = product.hotWeight.ToString();
            txtBoxAgrrWeight.Text = product.agrrWeight.ToString();
            txtBoxRtyCutoff1.Text = product.rtyCutoff1.ToString();
            txtBoxRtyCutoff2.Text = product.rtyCutoff2.ToString();
            txtBoxObaCutoff1.Text = product.obaCutoff1.ToString();
            txtBoxObaCutoff2.Text = product.obaCutoff2.ToString();
            txtBoxAgrrCutoff1.Text = product.agrrCutoff1.ToString();
            txtBoxAgrrCutoff2.Text = product.agrrCutoff2.ToString();
        }

        public bool GetConfirm()
        {
            return confirm;
        }

        private void txtBoxRtyWeight_TextChanged(object sender, EventArgs e)
        {
            txtBoxRtyWeight.ForeColor = Color.Black;
        }

        private void txtBoxObaWeight_TextChanged(object sender, EventArgs e)
        {
            txtBoxObaWeight.ForeColor = Color.Black;
        }

        private void txtBoxHotWeight_TextChanged(object sender, EventArgs e)
        {
            txtBoxHotWeight.ForeColor = Color.Black;
        }

        private void txtBoxAgrrWeight_TextChanged(object sender, EventArgs e)
        {
            txtBoxAgrrWeight.ForeColor = Color.Black;
        }

        private void txtBoxRtyCutoff1_TextChanged(object sender, EventArgs e)
        {
            txtBoxRtyCutoff1.ForeColor = Color.Black;
            txtBoxRtyCutoff2.ForeColor = Color.Black;
        }

        private void txtBoxRtyCutoff2_TextChanged(object sender, EventArgs e)
        {
            txtBoxRtyCutoff1.ForeColor = Color.Black;
            txtBoxRtyCutoff2.ForeColor = Color.Black;
        }

        private void txtBoxObaCutoff1_TextChanged(object sender, EventArgs e)
        {
            txtBoxObaCutoff1.ForeColor = Color.Black;
            txtBoxObaCutoff2.ForeColor = Color.Black;
        }

        private void txtBoxObaCutoff2_TextChanged(object sender, EventArgs e)
        {
            txtBoxObaCutoff1.ForeColor = Color.Black;
            txtBoxObaCutoff2.ForeColor = Color.Black;
        }

        private void txtBoxAgrrCutoff1_TextChanged(object sender, EventArgs e)
        {
            txtBoxAgrrCutoff1.ForeColor = Color.Black;
            txtBoxAgrrCutoff2.ForeColor = Color.Black;
        }

        private void txtBoxAgrrCutoff2_TextChanged(object sender, EventArgs e)
        {
            txtBoxAgrrCutoff1.ForeColor = Color.Black;
            txtBoxAgrrCutoff2.ForeColor = Color.Black;
        }

        public void SetFormName(String name)
        {
            this.Text = name;
        }
        public String GetProductName()
        {
            return productName;
        }
    }
}
