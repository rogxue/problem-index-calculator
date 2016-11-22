namespace ProblemIndexCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblAgrr = new System.Windows.Forms.Label();
            this.txtAgrr = new System.Windows.Forms.TextBox();
            this.txtHot = new System.Windows.Forms.TextBox();
            this.lblHotIssue = new System.Windows.Forms.Label();
            this.txtOba = new System.Windows.Forms.TextBox();
            this.lblOba = new System.Windows.Forms.Label();
            this.txtRty = new System.Windows.Forms.TextBox();
            this.lblRty = new System.Windows.Forms.Label();
            this.txtRtyWeight = new System.Windows.Forms.TextBox();
            this.txtObaWeight = new System.Windows.Forms.TextBox();
            this.txtHotWeight = new System.Windows.Forms.TextBox();
            this.txtAgrrWeight = new System.Windows.Forms.TextBox();
            this.txtRtyNorm = new System.Windows.Forms.TextBox();
            this.txtObaNorm = new System.Windows.Forms.TextBox();
            this.txtHotNorm = new System.Windows.Forms.TextBox();
            this.txtAgrrNorm = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblNorm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblActiveIndex = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtRtyScore = new System.Windows.Forms.TextBox();
            this.txtObaScore = new System.Windows.Forms.TextBox();
            this.txtHotScore = new System.Windows.Forms.TextBox();
            this.txtAgrrScore = new System.Windows.Forms.TextBox();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.MinimumSize = new System.Drawing.Size(300, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SPQi Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 79);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TabStop = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lblAgrr
            // 
            this.lblAgrr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAgrr.AutoSize = true;
            this.lblAgrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrr.Location = new System.Drawing.Point(63, 203);
            this.lblAgrr.Name = "lblAgrr";
            this.lblAgrr.Size = new System.Drawing.Size(80, 29);
            this.lblAgrr.TabIndex = 2;
            this.lblAgrr.Text = "AGRR";
            // 
            // txtAgrr
            // 
            this.txtAgrr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAgrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrr.Location = new System.Drawing.Point(149, 201);
            this.txtAgrr.Name = "txtAgrr";
            this.txtAgrr.Size = new System.Drawing.Size(74, 34);
            this.txtAgrr.TabIndex = 4;
            this.txtAgrr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgrr.TextChanged += new System.EventHandler(this.txtAgrr_TextChanged);
            // 
            // txtHot
            // 
            this.txtHot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHot.Location = new System.Drawing.Point(149, 146);
            this.txtHot.Name = "txtHot";
            this.txtHot.Size = new System.Drawing.Size(74, 34);
            this.txtHot.TabIndex = 3;
            this.txtHot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHot.TextChanged += new System.EventHandler(this.txtHot_TextChanged);
            // 
            // lblHotIssue
            // 
            this.lblHotIssue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHotIssue.AutoSize = true;
            this.lblHotIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotIssue.Location = new System.Drawing.Point(30, 148);
            this.lblHotIssue.Name = "lblHotIssue";
            this.lblHotIssue.Size = new System.Drawing.Size(113, 29);
            this.lblHotIssue.TabIndex = 4;
            this.lblHotIssue.Text = "Hot Issue";
            // 
            // txtOba
            // 
            this.txtOba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOba.Location = new System.Drawing.Point(149, 92);
            this.txtOba.Name = "txtOba";
            this.txtOba.Size = new System.Drawing.Size(74, 34);
            this.txtOba.TabIndex = 2;
            this.txtOba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOba.TextChanged += new System.EventHandler(this.txtOba_TextChanged);
            // 
            // lblOba
            // 
            this.lblOba.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOba.AutoSize = true;
            this.lblOba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOba.Location = new System.Drawing.Point(39, 94);
            this.lblOba.Name = "lblOba";
            this.lblOba.Size = new System.Drawing.Size(104, 29);
            this.lblOba.TabIndex = 6;
            this.lblOba.Text = "OBA / SI";
            // 
            // txtRty
            // 
            this.txtRty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRty.Location = new System.Drawing.Point(149, 38);
            this.txtRty.Name = "txtRty";
            this.txtRty.Size = new System.Drawing.Size(74, 34);
            this.txtRty.TabIndex = 1;
            this.txtRty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRty.TextChanged += new System.EventHandler(this.txtRty_TextChanged);
            // 
            // lblRty
            // 
            this.lblRty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRty.AutoSize = true;
            this.lblRty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRty.Location = new System.Drawing.Point(81, 40);
            this.lblRty.Name = "lblRty";
            this.lblRty.Size = new System.Drawing.Size(62, 29);
            this.lblRty.TabIndex = 8;
            this.lblRty.Text = "RTY";
            // 
            // txtRtyWeight
            // 
            this.txtRtyWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRtyWeight.Enabled = false;
            this.txtRtyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtyWeight.Location = new System.Drawing.Point(229, 38);
            this.txtRtyWeight.Name = "txtRtyWeight";
            this.txtRtyWeight.ReadOnly = true;
            this.txtRtyWeight.Size = new System.Drawing.Size(74, 34);
            this.txtRtyWeight.TabIndex = 14;
            this.txtRtyWeight.TabStop = false;
            this.txtRtyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObaWeight
            // 
            this.txtObaWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObaWeight.Enabled = false;
            this.txtObaWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObaWeight.Location = new System.Drawing.Point(229, 92);
            this.txtObaWeight.Name = "txtObaWeight";
            this.txtObaWeight.ReadOnly = true;
            this.txtObaWeight.Size = new System.Drawing.Size(74, 34);
            this.txtObaWeight.TabIndex = 12;
            this.txtObaWeight.TabStop = false;
            this.txtObaWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHotWeight
            // 
            this.txtHotWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHotWeight.Enabled = false;
            this.txtHotWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotWeight.Location = new System.Drawing.Point(229, 146);
            this.txtHotWeight.Name = "txtHotWeight";
            this.txtHotWeight.ReadOnly = true;
            this.txtHotWeight.Size = new System.Drawing.Size(74, 34);
            this.txtHotWeight.TabIndex = 11;
            this.txtHotWeight.TabStop = false;
            this.txtHotWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgrrWeight
            // 
            this.txtAgrrWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAgrrWeight.Enabled = false;
            this.txtAgrrWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrrWeight.Location = new System.Drawing.Point(229, 201);
            this.txtAgrrWeight.Name = "txtAgrrWeight";
            this.txtAgrrWeight.ReadOnly = true;
            this.txtAgrrWeight.Size = new System.Drawing.Size(74, 34);
            this.txtAgrrWeight.TabIndex = 10;
            this.txtAgrrWeight.TabStop = false;
            this.txtAgrrWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRtyNorm
            // 
            this.txtRtyNorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRtyNorm.Enabled = false;
            this.txtRtyNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtyNorm.Location = new System.Drawing.Point(309, 38);
            this.txtRtyNorm.Name = "txtRtyNorm";
            this.txtRtyNorm.ReadOnly = true;
            this.txtRtyNorm.Size = new System.Drawing.Size(96, 34);
            this.txtRtyNorm.TabIndex = 18;
            this.txtRtyNorm.TabStop = false;
            this.txtRtyNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObaNorm
            // 
            this.txtObaNorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObaNorm.Enabled = false;
            this.txtObaNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObaNorm.Location = new System.Drawing.Point(309, 92);
            this.txtObaNorm.Name = "txtObaNorm";
            this.txtObaNorm.ReadOnly = true;
            this.txtObaNorm.Size = new System.Drawing.Size(96, 34);
            this.txtObaNorm.TabIndex = 17;
            this.txtObaNorm.TabStop = false;
            this.txtObaNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHotNorm
            // 
            this.txtHotNorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHotNorm.Enabled = false;
            this.txtHotNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotNorm.Location = new System.Drawing.Point(309, 146);
            this.txtHotNorm.Name = "txtHotNorm";
            this.txtHotNorm.ReadOnly = true;
            this.txtHotNorm.Size = new System.Drawing.Size(96, 34);
            this.txtHotNorm.TabIndex = 16;
            this.txtHotNorm.TabStop = false;
            this.txtHotNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgrrNorm
            // 
            this.txtAgrrNorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAgrrNorm.Enabled = false;
            this.txtAgrrNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrrNorm.Location = new System.Drawing.Point(309, 201);
            this.txtAgrrNorm.Name = "txtAgrrNorm";
            this.txtAgrrNorm.ReadOnly = true;
            this.txtAgrrNorm.Size = new System.Drawing.Size(96, 34);
            this.txtAgrrNorm.TabIndex = 15;
            this.txtAgrrNorm.TabStop = false;
            this.txtAgrrNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(415, 345);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(187, 53);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(164, 5);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 17);
            this.lblValue.TabIndex = 21;
            this.lblValue.Text = "Value";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(240, 5);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 17);
            this.lblWeight.TabIndex = 22;
            this.lblWeight.Text = "Weight";
            // 
            // lblNorm
            // 
            this.lblNorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNorm.AutoSize = true;
            this.lblNorm.Location = new System.Drawing.Point(310, 5);
            this.lblNorm.Name = "lblNorm";
            this.lblNorm.Size = new System.Drawing.Size(94, 17);
            this.lblNorm.TabIndex = 23;
            this.lblNorm.Text = "Normalization";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(608, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 53);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save Month";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Currently Selected Month:\r\n";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(31, 336);
            this.lblMonth.MinimumSize = new System.Drawing.Size(239, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(239, 25);
            this.lblMonth.TabIndex = 26;
            this.lblMonth.Text = "October 2016";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoEllipsis = true;
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(430, 302);
            this.lblIndex.MinimumSize = new System.Drawing.Size(360, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(360, 29);
            this.lblIndex.TabIndex = 27;
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 36);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.resetDataToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // resetDataToolStripMenuItem
            // 
            this.resetDataToolStripMenuItem.Name = "resetDataToolStripMenuItem";
            this.resetDataToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.resetDataToolStripMenuItem.Text = "Reset Data";
            this.resetDataToolStripMenuItem.Click += new System.EventHandler(this.resetDataToolStripMenuItem_Click_1);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataToolStripMenuItem,
            this.createChartToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // createChartToolStripMenuItem
            // 
            this.createChartToolStripMenuItem.Name = "createChartToolStripMenuItem";
            this.createChartToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.createChartToolStripMenuItem.Text = "Create Chart";
            this.createChartToolStripMenuItem.Click += new System.EventHandler(this.createChartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 32);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblActiveIndex
            // 
            this.lblActiveIndex.AutoSize = true;
            this.lblActiveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveIndex.Location = new System.Drawing.Point(31, 373);
            this.lblActiveIndex.MinimumSize = new System.Drawing.Size(239, 0);
            this.lblActiveIndex.Name = "lblActiveIndex";
            this.lblActiveIndex.Size = new System.Drawing.Size(239, 25);
            this.lblActiveIndex.TabIndex = 29;
            this.lblActiveIndex.Text = "Problem Index: ";
            this.lblActiveIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActiveIndex.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoEllipsis = true;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(276, 336);
            this.lblProduct.MaximumSize = new System.Drawing.Size(300, 25);
            this.lblProduct.MinimumSize = new System.Drawing.Size(300, 25);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(300, 25);
            this.lblProduct.TabIndex = 30;
            this.lblProduct.Text = "Product: ";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47417F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47418F));
            this.tableLayoutPanel1.Controls.Add(this.lblRty, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOba, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHotIssue, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAgrr, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNorm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAgrrNorm, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHotNorm, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtObaNorm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRtyNorm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOba, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAgrr, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRtyWeight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAgrrWeight, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHotWeight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtObaWeight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblScore, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRtyScore, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtObaScore, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHotScore, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAgrrScore, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 246);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(427, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 17);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "Score";
            // 
            // txtRtyScore
            // 
            this.txtRtyScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRtyScore.Enabled = false;
            this.txtRtyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtyScore.Location = new System.Drawing.Point(411, 38);
            this.txtRtyScore.Name = "txtRtyScore";
            this.txtRtyScore.ReadOnly = true;
            this.txtRtyScore.Size = new System.Drawing.Size(77, 34);
            this.txtRtyScore.TabIndex = 25;
            this.txtRtyScore.TabStop = false;
            this.txtRtyScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObaScore
            // 
            this.txtObaScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObaScore.Enabled = false;
            this.txtObaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObaScore.Location = new System.Drawing.Point(411, 92);
            this.txtObaScore.Name = "txtObaScore";
            this.txtObaScore.ReadOnly = true;
            this.txtObaScore.Size = new System.Drawing.Size(77, 34);
            this.txtObaScore.TabIndex = 26;
            this.txtObaScore.TabStop = false;
            this.txtObaScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHotScore
            // 
            this.txtHotScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHotScore.Enabled = false;
            this.txtHotScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotScore.Location = new System.Drawing.Point(411, 146);
            this.txtHotScore.Name = "txtHotScore";
            this.txtHotScore.ReadOnly = true;
            this.txtHotScore.Size = new System.Drawing.Size(77, 34);
            this.txtHotScore.TabIndex = 27;
            this.txtHotScore.TabStop = false;
            this.txtHotScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgrrScore
            // 
            this.txtAgrrScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAgrrScore.Enabled = false;
            this.txtAgrrScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrrScore.Location = new System.Drawing.Point(411, 201);
            this.txtAgrrScore.Name = "txtAgrrScore";
            this.txtAgrrScore.ReadOnly = true;
            this.txtAgrrScore.Size = new System.Drawing.Size(77, 34);
            this.txtAgrrScore.TabIndex = 28;
            this.txtAgrrScore.TabStop = false;
            this.txtAgrrScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductLabel.Location = new System.Drawing.Point(380, 300);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(90, 25);
            this.lblProductLabel.TabIndex = 32;
            this.lblProductLabel.Text = "Product: ";
            this.lblProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(802, 414);
            this.Controls.Add(this.lblProductLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblActiveIndex);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 460);
            this.MinimumSize = new System.Drawing.Size(820, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Sustained Product Quality Index Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblAgrr;
        private System.Windows.Forms.TextBox txtAgrr;
        private System.Windows.Forms.TextBox txtHot;
        private System.Windows.Forms.Label lblHotIssue;
        private System.Windows.Forms.TextBox txtOba;
        private System.Windows.Forms.Label lblOba;
        private System.Windows.Forms.TextBox txtRty;
        private System.Windows.Forms.Label lblRty;
        private System.Windows.Forms.TextBox txtRtyWeight;
        private System.Windows.Forms.TextBox txtObaWeight;
        private System.Windows.Forms.TextBox txtHotWeight;
        private System.Windows.Forms.TextBox txtAgrrWeight;
        private System.Windows.Forms.TextBox txtObaNorm;
        private System.Windows.Forms.TextBox txtHotNorm;
        private System.Windows.Forms.TextBox txtAgrrNorm;
        private System.Windows.Forms.TextBox txtRtyNorm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblNorm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDataToolStripMenuItem;
        private System.Windows.Forms.Label lblActiveIndex;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtRtyScore;
        private System.Windows.Forms.TextBox txtObaScore;
        private System.Windows.Forms.TextBox txtHotScore;
        private System.Windows.Forms.TextBox txtAgrrScore;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblProductLabel;
    }
}

