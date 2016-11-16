namespace ProblemIndexCalculator
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxTarget = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtyLabel = new System.Windows.Forms.Label();
            this.obaLabel = new System.Windows.Forms.Label();
            this.agrrLabel = new System.Windows.Forms.Label();
            this.hotIssueLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.cutoff1Label = new System.Windows.Forms.Label();
            this.cutoffLabel2 = new System.Windows.Forms.Label();
            this.txtBoxRtyCutoff1 = new System.Windows.Forms.TextBox();
            this.txtBoxRtyCutoff2 = new System.Windows.Forms.TextBox();
            this.txtBoxObaWeight = new System.Windows.Forms.TextBox();
            this.txtBoxObaCutoff1 = new System.Windows.Forms.TextBox();
            this.txtBoxHotWeight = new System.Windows.Forms.TextBox();
            this.txtBoxAgrrWeight = new System.Windows.Forms.TextBox();
            this.txtBoxAgrrCutoff1 = new System.Windows.Forms.TextBox();
            this.txtBoxAgrrCutoff2 = new System.Windows.Forms.TextBox();
            this.txtBoxObaCutoff2 = new System.Windows.Forms.TextBox();
            this.txtBoxRtyWeight = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(82, 12);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(215, 30);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTarget
            // 
            this.txtBoxTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTarget.Location = new System.Drawing.Point(82, 66);
            this.txtBoxTarget.Name = "txtBoxTarget";
            this.txtBoxTarget.Size = new System.Drawing.Size(215, 30);
            this.txtBoxTarget.TabIndex = 1;
            this.txtBoxTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTarget.TextChanged += new System.EventHandler(this.txtBoxTarget_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(359, 310);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(92, 28);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(457, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(7, 71);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(69, 24);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Target:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.rtyLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.obaLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.agrrLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.hotIssueLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cutoff1Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cutoffLabel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRtyCutoff1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRtyCutoff2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxObaWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxObaCutoff1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxHotWeight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAgrrWeight, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAgrrCutoff1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAgrrCutoff2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxObaCutoff2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRtyWeight, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 178);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // rtyLabel
            // 
            this.rtyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtyLabel.AutoSize = true;
            this.rtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtyLabel.Location = new System.Drawing.Point(73, 40);
            this.rtyLabel.Name = "rtyLabel";
            this.rtyLabel.Size = new System.Drawing.Size(47, 24);
            this.rtyLabel.TabIndex = 8;
            this.rtyLabel.Text = "RTY";
            // 
            // obaLabel
            // 
            this.obaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.obaLabel.AutoSize = true;
            this.obaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obaLabel.Location = new System.Drawing.Point(39, 75);
            this.obaLabel.Name = "obaLabel";
            this.obaLabel.Size = new System.Drawing.Size(81, 24);
            this.obaLabel.TabIndex = 9;
            this.obaLabel.Text = "OBA / SI";
            // 
            // agrrLabel
            // 
            this.agrrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.agrrLabel.AutoSize = true;
            this.agrrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agrrLabel.Location = new System.Drawing.Point(57, 147);
            this.agrrLabel.Name = "agrrLabel";
            this.agrrLabel.Size = new System.Drawing.Size(63, 24);
            this.agrrLabel.TabIndex = 10;
            this.agrrLabel.Text = "AGRR";
            // 
            // hotIssueLabel
            // 
            this.hotIssueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hotIssueLabel.AutoSize = true;
            this.hotIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotIssueLabel.Location = new System.Drawing.Point(32, 110);
            this.hotIssueLabel.Name = "hotIssueLabel";
            this.hotIssueLabel.Size = new System.Drawing.Size(88, 24);
            this.hotIssueLabel.TabIndex = 11;
            this.hotIssueLabel.Text = "Hot Issue";
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(157, 5);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(69, 24);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // cutoff1Label
            // 
            this.cutoff1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cutoff1Label.AutoSize = true;
            this.cutoff1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutoff1Label.Location = new System.Drawing.Point(280, 5);
            this.cutoff1Label.Name = "cutoff1Label";
            this.cutoff1Label.Size = new System.Drawing.Size(97, 24);
            this.cutoff1Label.TabIndex = 12;
            this.cutoff1Label.Text = "Cutoff Low";
            // 
            // cutoffLabel2
            // 
            this.cutoffLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cutoffLabel2.AutoSize = true;
            this.cutoffLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutoffLabel2.Location = new System.Drawing.Point(415, 5);
            this.cutoffLabel2.Name = "cutoffLabel2";
            this.cutoffLabel2.Size = new System.Drawing.Size(102, 24);
            this.cutoffLabel2.TabIndex = 13;
            this.cutoffLabel2.Text = "Cutoff High";
            // 
            // txtBoxRtyCutoff1
            // 
            this.txtBoxRtyCutoff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRtyCutoff1.Location = new System.Drawing.Point(263, 38);
            this.txtBoxRtyCutoff1.Name = "txtBoxRtyCutoff1";
            this.txtBoxRtyCutoff1.Size = new System.Drawing.Size(131, 30);
            this.txtBoxRtyCutoff1.TabIndex = 3;
            this.txtBoxRtyCutoff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRtyCutoff1.TextChanged += new System.EventHandler(this.txtBoxRtyCutoff1_TextChanged);
            // 
            // txtBoxRtyCutoff2
            // 
            this.txtBoxRtyCutoff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRtyCutoff2.Location = new System.Drawing.Point(400, 38);
            this.txtBoxRtyCutoff2.Name = "txtBoxRtyCutoff2";
            this.txtBoxRtyCutoff2.Size = new System.Drawing.Size(133, 30);
            this.txtBoxRtyCutoff2.TabIndex = 4;
            this.txtBoxRtyCutoff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRtyCutoff2.TextChanged += new System.EventHandler(this.txtBoxRtyCutoff2_TextChanged);
            // 
            // txtBoxObaWeight
            // 
            this.txtBoxObaWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObaWeight.Location = new System.Drawing.Point(126, 73);
            this.txtBoxObaWeight.Name = "txtBoxObaWeight";
            this.txtBoxObaWeight.Size = new System.Drawing.Size(131, 30);
            this.txtBoxObaWeight.TabIndex = 5;
            this.txtBoxObaWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxObaWeight.TextChanged += new System.EventHandler(this.txtBoxObaWeight_TextChanged);
            // 
            // txtBoxObaCutoff1
            // 
            this.txtBoxObaCutoff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObaCutoff1.Location = new System.Drawing.Point(263, 73);
            this.txtBoxObaCutoff1.Name = "txtBoxObaCutoff1";
            this.txtBoxObaCutoff1.Size = new System.Drawing.Size(131, 30);
            this.txtBoxObaCutoff1.TabIndex = 6;
            this.txtBoxObaCutoff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxObaCutoff1.TextChanged += new System.EventHandler(this.txtBoxObaCutoff1_TextChanged);
            // 
            // txtBoxHotWeight
            // 
            this.txtBoxHotWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHotWeight.Location = new System.Drawing.Point(126, 108);
            this.txtBoxHotWeight.Name = "txtBoxHotWeight";
            this.txtBoxHotWeight.Size = new System.Drawing.Size(131, 30);
            this.txtBoxHotWeight.TabIndex = 8;
            this.txtBoxHotWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHotWeight.TextChanged += new System.EventHandler(this.txtBoxHotWeight_TextChanged);
            // 
            // txtBoxAgrrWeight
            // 
            this.txtBoxAgrrWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgrrWeight.Location = new System.Drawing.Point(126, 143);
            this.txtBoxAgrrWeight.Name = "txtBoxAgrrWeight";
            this.txtBoxAgrrWeight.Size = new System.Drawing.Size(131, 30);
            this.txtBoxAgrrWeight.TabIndex = 9;
            this.txtBoxAgrrWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAgrrWeight.TextChanged += new System.EventHandler(this.txtBoxAgrrWeight_TextChanged);
            // 
            // txtBoxAgrrCutoff1
            // 
            this.txtBoxAgrrCutoff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgrrCutoff1.Location = new System.Drawing.Point(263, 143);
            this.txtBoxAgrrCutoff1.Name = "txtBoxAgrrCutoff1";
            this.txtBoxAgrrCutoff1.Size = new System.Drawing.Size(131, 30);
            this.txtBoxAgrrCutoff1.TabIndex = 10;
            this.txtBoxAgrrCutoff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAgrrCutoff1.TextChanged += new System.EventHandler(this.txtBoxAgrrCutoff1_TextChanged);
            // 
            // txtBoxAgrrCutoff2
            // 
            this.txtBoxAgrrCutoff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgrrCutoff2.Location = new System.Drawing.Point(400, 143);
            this.txtBoxAgrrCutoff2.Name = "txtBoxAgrrCutoff2";
            this.txtBoxAgrrCutoff2.Size = new System.Drawing.Size(133, 30);
            this.txtBoxAgrrCutoff2.TabIndex = 11;
            this.txtBoxAgrrCutoff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAgrrCutoff2.TextChanged += new System.EventHandler(this.txtBoxAgrrCutoff2_TextChanged);
            // 
            // txtBoxObaCutoff2
            // 
            this.txtBoxObaCutoff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObaCutoff2.Location = new System.Drawing.Point(400, 73);
            this.txtBoxObaCutoff2.Name = "txtBoxObaCutoff2";
            this.txtBoxObaCutoff2.Size = new System.Drawing.Size(133, 30);
            this.txtBoxObaCutoff2.TabIndex = 7;
            this.txtBoxObaCutoff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxObaCutoff2.TextChanged += new System.EventHandler(this.txtBoxObaCutoff2_TextChanged);
            // 
            // txtBoxRtyWeight
            // 
            this.txtBoxRtyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRtyWeight.Location = new System.Drawing.Point(126, 38);
            this.txtBoxRtyWeight.Name = "txtBoxRtyWeight";
            this.txtBoxRtyWeight.Size = new System.Drawing.Size(131, 30);
            this.txtBoxRtyWeight.TabIndex = 2;
            this.txtBoxRtyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRtyWeight.TextChanged += new System.EventHandler(this.txtBoxRtyWeight_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBoxTarget);
            this.Controls.Add(this.txtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.Text = "Edit Settings";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxTarget;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label rtyLabel;
        private System.Windows.Forms.Label obaLabel;
        private System.Windows.Forms.Label agrrLabel;
        private System.Windows.Forms.Label hotIssueLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label cutoff1Label;
        private System.Windows.Forms.Label cutoffLabel2;
        private System.Windows.Forms.TextBox txtBoxRtyCutoff1;
        private System.Windows.Forms.TextBox txtBoxRtyCutoff2;
        private System.Windows.Forms.TextBox txtBoxObaWeight;
        private System.Windows.Forms.TextBox txtBoxObaCutoff1;
        private System.Windows.Forms.TextBox txtBoxHotWeight;
        private System.Windows.Forms.TextBox txtBoxAgrrWeight;
        private System.Windows.Forms.TextBox txtBoxAgrrCutoff1;
        private System.Windows.Forms.TextBox txtBoxAgrrCutoff2;
        private System.Windows.Forms.TextBox txtBoxObaCutoff2;
        private System.Windows.Forms.TextBox txtBoxRtyWeight;
    }
}