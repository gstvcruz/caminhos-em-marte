namespace apMartianPathways
{
  partial class FrmPaths
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaths));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCities = new System.Windows.Forms.TabPage();
            this.pbCitiesMap = new System.Windows.Forms.PictureBox();
            this.lsbCities = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.udY = new System.Windows.Forms.NumericUpDown();
            this.udX = new System.Windows.Forms.NumericUpDown();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenCitiesFile = new System.Windows.Forms.Button();
            this.rbDoubleHashing = new System.Windows.Forms.RadioButton();
            this.rbQuadraticProbing = new System.Windows.Forms.RadioButton();
            this.rbLinearProbing = new System.Windows.Forms.RadioButton();
            this.rbBucketHashing = new System.Windows.Forms.RadioButton();
            this.tpRoutes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBestRoute = new System.Windows.Forms.DataGridView();
            this.btnSearchRoute = new System.Windows.Forms.Button();
            this.btnOpenRoutesFile = new System.Windows.Forms.Button();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.btnUpdateConnection = new System.Windows.Forms.Button();
            this.btnRemoveConnection = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.udRouteDistance = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDestiny = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbRoutesMap = new System.Windows.Forms.PictureBox();
            this.dlgOpenCitiesFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenRoutesFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCitiesMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpRoutes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRouteDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoutesMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCities);
            this.tabControl1.Controls.Add(this.tpRoutes);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 679);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCities
            // 
            this.tpCities.Controls.Add(this.pbCitiesMap);
            this.tpCities.Controls.Add(this.lsbCities);
            this.tpCities.Controls.Add(this.btnList);
            this.tpCities.Controls.Add(this.btnSearch);
            this.tpCities.Controls.Add(this.btnRemove);
            this.tpCities.Controls.Add(this.btnInsert);
            this.tpCities.Controls.Add(this.udY);
            this.tpCities.Controls.Add(this.udX);
            this.tpCities.Controls.Add(this.txtCity);
            this.tpCities.Controls.Add(this.label3);
            this.tpCities.Controls.Add(this.label2);
            this.tpCities.Controls.Add(this.label1);
            this.tpCities.Controls.Add(this.groupBox1);
            this.tpCities.Location = new System.Drawing.Point(4, 22);
            this.tpCities.Name = "tpCities";
            this.tpCities.Padding = new System.Windows.Forms.Padding(3);
            this.tpCities.Size = new System.Drawing.Size(1173, 653);
            this.tpCities.TabIndex = 0;
            this.tpCities.Text = "Cities";
            this.tpCities.UseVisualStyleBackColor = true;
            // 
            // pbCitiesMap
            // 
            this.pbCitiesMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCitiesMap.Image = ((System.Drawing.Image)(resources.GetObject("pbCitiesMap.Image")));
            this.pbCitiesMap.Location = new System.Drawing.Point(275, 60);
            this.pbCitiesMap.Name = "pbCitiesMap";
            this.pbCitiesMap.Size = new System.Drawing.Size(895, 581);
            this.pbCitiesMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCitiesMap.TabIndex = 12;
            this.pbCitiesMap.TabStop = false;
            // 
            // lsbCities
            // 
            this.lsbCities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbCities.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCities.FormattingEnabled = true;
            this.lsbCities.ItemHeight = 14;
            this.lsbCities.Location = new System.Drawing.Point(10, 193);
            this.lsbCities.Name = "lsbCities";
            this.lsbCities.ScrollAlwaysVisible = true;
            this.lsbCities.Size = new System.Drawing.Size(259, 424);
            this.lsbCities.Sorted = true;
            this.lsbCities.TabIndex = 11;
            // 
            // btnList
            // 
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(148, 156);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(40, 30);
            this.btnList.TabIndex = 10;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(102, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 30);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(10, 156);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(40, 30);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "+";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // udY
            // 
            this.udY.DecimalPlaces = 5;
            this.udY.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            327680});
            this.udY.Location = new System.Drawing.Point(56, 126);
            this.udY.Name = "udY";
            this.udY.Size = new System.Drawing.Size(75, 20);
            this.udY.TabIndex = 6;
            // 
            // udX
            // 
            this.udX.DecimalPlaces = 5;
            this.udX.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            327680});
            this.udX.Location = new System.Drawing.Point(56, 100);
            this.udX.Name = "udX";
            this.udX.Size = new System.Drawing.Size(75, 20);
            this.udX.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(56, 71);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnOpenCitiesFile);
            this.groupBox1.Controls.Add(this.rbDoubleHashing);
            this.groupBox1.Controls.Add(this.rbQuadraticProbing);
            this.groupBox1.Controls.Add(this.rbLinearProbing);
            this.groupBox1.Controls.Add(this.rbBucketHashing);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected hashing technique";
            // 
            // btnOpenCitiesFile
            // 
            this.btnOpenCitiesFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCitiesFile.AutoSize = true;
            this.btnOpenCitiesFile.Location = new System.Drawing.Point(1054, 19);
            this.btnOpenCitiesFile.Name = "btnOpenCitiesFile";
            this.btnOpenCitiesFile.Size = new System.Drawing.Size(109, 23);
            this.btnOpenCitiesFile.TabIndex = 4;
            this.btnOpenCitiesFile.Text = "Open Cities File";
            this.btnOpenCitiesFile.UseVisualStyleBackColor = true;
            this.btnOpenCitiesFile.Click += new System.EventHandler(this.btnOpenCitiesFile_Click);
            // 
            // rbDoubleHashing
            // 
            this.rbDoubleHashing.AutoSize = true;
            this.rbDoubleHashing.Location = new System.Drawing.Point(374, 19);
            this.rbDoubleHashing.Name = "rbDoubleHashing";
            this.rbDoubleHashing.Size = new System.Drawing.Size(101, 17);
            this.rbDoubleHashing.TabIndex = 3;
            this.rbDoubleHashing.Text = "Double Hashing";
            this.rbDoubleHashing.UseVisualStyleBackColor = true;
            // 
            // rbQuadraticProbing
            // 
            this.rbQuadraticProbing.AutoSize = true;
            this.rbQuadraticProbing.Location = new System.Drawing.Point(246, 19);
            this.rbQuadraticProbing.Name = "rbQuadraticProbing";
            this.rbQuadraticProbing.Size = new System.Drawing.Size(110, 17);
            this.rbQuadraticProbing.TabIndex = 2;
            this.rbQuadraticProbing.Text = "Quadratic Probing";
            this.rbQuadraticProbing.UseVisualStyleBackColor = true;
            // 
            // rbLinearProbing
            // 
            this.rbLinearProbing.AutoSize = true;
            this.rbLinearProbing.Location = new System.Drawing.Point(135, 19);
            this.rbLinearProbing.Name = "rbLinearProbing";
            this.rbLinearProbing.Size = new System.Drawing.Size(93, 17);
            this.rbLinearProbing.TabIndex = 1;
            this.rbLinearProbing.Text = "Linear Probing";
            this.rbLinearProbing.UseVisualStyleBackColor = true;
            // 
            // rbBucketHashing
            // 
            this.rbBucketHashing.AutoSize = true;
            this.rbBucketHashing.Checked = true;
            this.rbBucketHashing.Location = new System.Drawing.Point(16, 19);
            this.rbBucketHashing.Name = "rbBucketHashing";
            this.rbBucketHashing.Size = new System.Drawing.Size(101, 17);
            this.rbBucketHashing.TabIndex = 0;
            this.rbBucketHashing.TabStop = true;
            this.rbBucketHashing.Text = "Bucket Hashing";
            this.rbBucketHashing.UseVisualStyleBackColor = true;
            // 
            // tpRoutes
            // 
            this.tpRoutes.Controls.Add(this.groupBox2);
            this.tpRoutes.Controls.Add(this.pbRoutesMap);
            this.tpRoutes.Location = new System.Drawing.Point(4, 22);
            this.tpRoutes.Name = "tpRoutes";
            this.tpRoutes.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoutes.Size = new System.Drawing.Size(1173, 653);
            this.tpRoutes.TabIndex = 1;
            this.tpRoutes.Text = "Routes";
            this.tpRoutes.UseVisualStyleBackColor = true;
            this.tpRoutes.Enter += new System.EventHandler(this.tpRoutes_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBestRoute);
            this.groupBox2.Controls.Add(this.btnSearchRoute);
            this.groupBox2.Controls.Add(this.btnOpenRoutesFile);
            this.groupBox2.Controls.Add(this.dgvRoutes);
            this.groupBox2.Controls.Add(this.btnUpdateConnection);
            this.groupBox2.Controls.Add(this.btnRemoveConnection);
            this.groupBox2.Controls.Add(this.btnAddConnection);
            this.groupBox2.Controls.Add(this.udRouteDistance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxDestiny);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxOrigin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 644);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routes";
            // 
            // dgvBestRoute
            // 
            this.dgvBestRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBestRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestRoute.Location = new System.Drawing.Point(4, 547);
            this.dgvBestRoute.Name = "dgvBestRoute";
            this.dgvBestRoute.Size = new System.Drawing.Size(276, 91);
            this.dgvBestRoute.TabIndex = 2;
            // 
            // btnSearchRoute
            // 
            this.btnSearchRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRoute.Image")));
            this.btnSearchRoute.Location = new System.Drawing.Point(242, 87);
            this.btnSearchRoute.Name = "btnSearchRoute";
            this.btnSearchRoute.Size = new System.Drawing.Size(32, 20);
            this.btnSearchRoute.TabIndex = 12;
            this.btnSearchRoute.UseVisualStyleBackColor = true;
            this.btnSearchRoute.Click += new System.EventHandler(this.btnSearchRoute_Click);
            // 
            // btnOpenRoutesFile
            // 
            this.btnOpenRoutesFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRoutesFile.AutoSize = true;
            this.btnOpenRoutesFile.Location = new System.Drawing.Point(171, 11);
            this.btnOpenRoutesFile.Name = "btnOpenRoutesFile";
            this.btnOpenRoutesFile.Size = new System.Drawing.Size(109, 23);
            this.btnOpenRoutesFile.TabIndex = 11;
            this.btnOpenRoutesFile.Text = "Open Routes File";
            this.btnOpenRoutesFile.UseVisualStyleBackColor = true;
            this.btnOpenRoutesFile.Click += new System.EventHandler(this.btnOpenRoutesFile_Click);
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Location = new System.Drawing.Point(4, 113);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.Size = new System.Drawing.Size(276, 428);
            this.dgvRoutes.TabIndex = 10;
            // 
            // btnUpdateConnection
            // 
            this.btnUpdateConnection.Location = new System.Drawing.Point(204, 87);
            this.btnUpdateConnection.Name = "btnUpdateConnection";
            this.btnUpdateConnection.Size = new System.Drawing.Size(32, 20);
            this.btnUpdateConnection.TabIndex = 9;
            this.btnUpdateConnection.Text = "#";
            this.btnUpdateConnection.UseVisualStyleBackColor = true;
            this.btnUpdateConnection.Click += new System.EventHandler(this.btnUpdateConnection_Click);
            // 
            // btnRemoveConnection
            // 
            this.btnRemoveConnection.Location = new System.Drawing.Point(166, 87);
            this.btnRemoveConnection.Name = "btnRemoveConnection";
            this.btnRemoveConnection.Size = new System.Drawing.Size(32, 20);
            this.btnRemoveConnection.TabIndex = 8;
            this.btnRemoveConnection.Text = "-";
            this.btnRemoveConnection.UseVisualStyleBackColor = true;
            this.btnRemoveConnection.Click += new System.EventHandler(this.btnRemoveConnection_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(127, 87);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(32, 20);
            this.btnAddConnection.TabIndex = 7;
            this.btnAddConnection.Text = "+";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // udRouteDistance
            // 
            this.udRouteDistance.Location = new System.Drawing.Point(61, 87);
            this.udRouteDistance.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udRouteDistance.Name = "udRouteDistance";
            this.udRouteDistance.Size = new System.Drawing.Size(57, 20);
            this.udRouteDistance.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Distance:";
            // 
            // cbxDestiny
            // 
            this.cbxDestiny.FormattingEnabled = true;
            this.cbxDestiny.Location = new System.Drawing.Point(127, 55);
            this.cbxDestiny.Name = "cbxDestiny";
            this.cbxDestiny.Size = new System.Drawing.Size(109, 21);
            this.cbxDestiny.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Destiny";
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(9, 55);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(109, 21);
            this.cbxOrigin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connections";
            // 
            // pbRoutesMap
            // 
            this.pbRoutesMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRoutesMap.Image = ((System.Drawing.Image)(resources.GetObject("pbRoutesMap.Image")));
            this.pbRoutesMap.Location = new System.Drawing.Point(295, 9);
            this.pbRoutesMap.Name = "pbRoutesMap";
            this.pbRoutesMap.Size = new System.Drawing.Size(869, 636);
            this.pbRoutesMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoutesMap.TabIndex = 1;
            this.pbRoutesMap.TabStop = false;
            // 
            // dlgOpenCitiesFile
            // 
            this.dlgOpenCitiesFile.DefaultExt = "*.txt";
            // 
            // dlgOpenRoutesFile
            // 
            this.dlgOpenRoutesFile.DefaultExt = "*.txt";
            // 
            // FrmPaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPaths";
            this.Text = "Martian Pathways - 23513 - 23521";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaths_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tpCities.ResumeLayout(false);
            this.tpCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCitiesMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpRoutes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRouteDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoutesMap)).EndInit();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCities;
    private System.Windows.Forms.TabPage tpRoutes;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbDoubleHashing;
    private System.Windows.Forms.RadioButton rbQuadraticProbing;
    private System.Windows.Forms.RadioButton rbLinearProbing;
    private System.Windows.Forms.RadioButton rbBucketHashing;
    private System.Windows.Forms.Button btnOpenCitiesFile;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown udX;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.NumericUpDown udY;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnList;
    private System.Windows.Forms.ListBox lsbCities;
    private System.Windows.Forms.PictureBox pbCitiesMap;
    private System.Windows.Forms.OpenFileDialog dlgOpenCitiesFile;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown udRouteDistance;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cbxDestiny;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cbxOrigin;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnUpdateConnection;
    private System.Windows.Forms.Button btnRemoveConnection;
    private System.Windows.Forms.Button btnAddConnection;
    private System.Windows.Forms.DataGridView dgvRoutes;
    private System.Windows.Forms.Button btnOpenRoutesFile;
    private System.Windows.Forms.OpenFileDialog dlgOpenRoutesFile;
    private System.Windows.Forms.Button btnSearchRoute;
    private System.Windows.Forms.DataGridView dgvBestRoute;
    private System.Windows.Forms.PictureBox pbRoutesMap;
    }
}
