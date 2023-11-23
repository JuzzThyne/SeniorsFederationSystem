namespace SENIOR_S_FEDERATION
{
    partial class DeceaseMaterlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeceaseMaterlist));
            this.tbClear = new System.Windows.Forms.Button();
            this.btnEditDecease = new System.Windows.Forms.Button();
            this.tbOscaId = new System.Windows.Forms.TextBox();
            this.tbAdmission = new System.Windows.Forms.TextBox();
            this.tbFederationId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMonitoring = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDateOfDeath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCauseOfDeath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRefresh = new System.Windows.Forms.Button();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnDeleteDecease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClear
            // 
            this.tbClear.Location = new System.Drawing.Point(16, 433);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(359, 34);
            this.tbClear.TabIndex = 25;
            this.tbClear.Text = "CLEAR DATA";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // btnEditDecease
            // 
            this.btnEditDecease.Location = new System.Drawing.Point(16, 473);
            this.btnEditDecease.Name = "btnEditDecease";
            this.btnEditDecease.Size = new System.Drawing.Size(359, 34);
            this.btnEditDecease.TabIndex = 21;
            this.btnEditDecease.Text = "UPDATE DATA";
            this.btnEditDecease.UseVisualStyleBackColor = true;
            this.btnEditDecease.Click += new System.EventHandler(this.btnEditDecease_Click);
            // 
            // tbOscaId
            // 
            this.tbOscaId.Enabled = false;
            this.tbOscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOscaId.Location = new System.Drawing.Point(177, 283);
            this.tbOscaId.Name = "tbOscaId";
            this.tbOscaId.Size = new System.Drawing.Size(198, 26);
            this.tbOscaId.TabIndex = 14;
            // 
            // tbAdmission
            // 
            this.tbAdmission.Enabled = false;
            this.tbAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdmission.Location = new System.Drawing.Point(177, 247);
            this.tbAdmission.Name = "tbAdmission";
            this.tbAdmission.Size = new System.Drawing.Size(198, 26);
            this.tbAdmission.TabIndex = 19;
            // 
            // tbFederationId
            // 
            this.tbFederationId.Enabled = false;
            this.tbFederationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFederationId.Location = new System.Drawing.Point(177, 216);
            this.tbFederationId.Name = "tbFederationId";
            this.tbFederationId.Size = new System.Drawing.Size(198, 26);
            this.tbFederationId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "OSCA ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ADMISSION DATE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "FEDERATION ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "BIRTHDAY:";
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(117, 126);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(258, 53);
            this.tbAddress.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADDRESS:";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Enabled = false;
            this.tbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirthday.Location = new System.Drawing.Point(117, 184);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(258, 26);
            this.tbBirthday.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(482, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 26);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "SEARCH:";
            // 
            // dgvMonitoring
            // 
            this.dgvMonitoring.AllowUserToAddRows = false;
            this.dgvMonitoring.AllowUserToDeleteRows = false;
            this.dgvMonitoring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMonitoring.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonitoring.BackgroundColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonitoring.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonitoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonitoring.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonitoring.Location = new System.Drawing.Point(399, 91);
            this.dgvMonitoring.Name = "dgvMonitoring";
            this.dgvMonitoring.ReadOnly = true;
            this.dgvMonitoring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitoring.Size = new System.Drawing.Size(541, 496);
            this.dgvMonitoring.TabIndex = 5;
            this.dgvMonitoring.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoring_CellClick);
            this.dgvMonitoring.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoring_CellContentClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 39);
            this.label8.TabIndex = 26;
            this.label8.Text = "DEATH LIST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "FULLNAME:";
            // 
            // tbDateOfDeath
            // 
            this.tbDateOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfDeath.Location = new System.Drawing.Point(177, 389);
            this.tbDateOfDeath.Name = "tbDateOfDeath";
            this.tbDateOfDeath.Size = new System.Drawing.Size(198, 26);
            this.tbDateOfDeath.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 318);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "CAUSE OF DEATH:";
            // 
            // tbCauseOfDeath
            // 
            this.tbCauseOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCauseOfDeath.Location = new System.Drawing.Point(177, 315);
            this.tbCauseOfDeath.Multiline = true;
            this.tbCauseOfDeath.Name = "tbCauseOfDeath";
            this.tbCauseOfDeath.Size = new System.Drawing.Size(198, 68);
            this.tbCauseOfDeath.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "DATE OF DEATH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "TOTAL DEATH:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "COUNT";
            this.label12.TextChanged += new System.EventHandler(this.label12_TextChanged);
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbRefresh
            // 
            this.tbRefresh.Location = new System.Drawing.Point(711, 18);
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(98, 34);
            this.tbRefresh.TabIndex = 29;
            this.tbRefresh.Text = "REFRESH";
            this.tbRefresh.UseVisualStyleBackColor = false;
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // tbFullname
            // 
            this.tbFullname.Enabled = false;
            this.tbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullname.Location = new System.Drawing.Point(117, 58);
            this.tbFullname.Multiline = true;
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(258, 62);
            this.tbFullname.TabIndex = 30;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(241, 553);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 34);
            this.btnNext.TabIndex = 51;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 553);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(134, 34);
            this.btnPrev.TabIndex = 50;
            this.btnPrev.Text = "PREVIOUS";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnDeleteDecease
            // 
            this.btnDeleteDecease.Location = new System.Drawing.Point(16, 513);
            this.btnDeleteDecease.Name = "btnDeleteDecease";
            this.btnDeleteDecease.Size = new System.Drawing.Size(359, 33);
            this.btnDeleteDecease.TabIndex = 52;
            this.btnDeleteDecease.Text = "DELETE DATA";
            this.btnDeleteDecease.UseVisualStyleBackColor = true;
            this.btnDeleteDecease.Click += new System.EventHandler(this.btnDeleteDecease_Click);
            // 
            // DeceaseMaterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 599);
            this.Controls.Add(this.btnDeleteDecease);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.tbRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.btnEditDecease);
            this.Controls.Add(this.tbOscaId);
            this.Controls.Add(this.tbAdmission);
            this.Controls.Add(this.tbFederationId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCauseOfDeath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbDateOfDeath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonitoring);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeceaseMaterlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeceaseMaterlist";
            this.Load += new System.EventHandler(this.DeceaseMaterlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button btnEditDecease;
        private System.Windows.Forms.TextBox tbOscaId;
        private System.Windows.Forms.TextBox tbAdmission;
        private System.Windows.Forms.TextBox tbFederationId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMonitoring;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDateOfDeath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCauseOfDeath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button tbRefresh;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnDeleteDecease;
    }
}