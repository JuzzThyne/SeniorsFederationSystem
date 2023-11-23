namespace SENIOR_S_FEDERATION
{
    partial class MasterlistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterlistForm));
            this.dgvMonitoring = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFederationId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOscaId = new System.Windows.Forms.TextBox();
            this.btnAddSenior = new System.Windows.Forms.Button();
            this.btnEditSenior = new System.Windows.Forms.Button();
            this.btnDeleteSenior = new System.Windows.Forms.Button();
            this.btnDeceasedSenior = new System.Windows.Forms.Button();
            this.btnWithdrawedSenior = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdmission = new System.Windows.Forms.TextBox();
            this.tbClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRefresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDateOfWithdrawn = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).BeginInit();
            this.SuspendLayout();
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
            this.dgvMonitoring.Location = new System.Drawing.Point(399, 84);
            this.dgvMonitoring.Name = "dgvMonitoring";
            this.dgvMonitoring.ReadOnly = true;
            this.dgvMonitoring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitoring.Size = new System.Drawing.Size(541, 499);
            this.dgvMonitoring.TabIndex = 0;
            this.dgvMonitoring.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoring_CellClick);
            this.dgvMonitoring.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoring_CellContentClick);
            this.dgvMonitoring.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoring_CellDoubleClick);
            this.dgvMonitoring.SelectionChanged += new System.EventHandler(this.dgvMonitoring_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FULLNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADDRESS:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(117, 110);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(258, 52);
            this.tbAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "BIRTHDAY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "FEDERATION ID:";
            // 
            // tbFederationId
            // 
            this.tbFederationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFederationId.Location = new System.Drawing.Point(177, 199);
            this.tbFederationId.Name = "tbFederationId";
            this.tbFederationId.Size = new System.Drawing.Size(198, 26);
            this.tbFederationId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "OSCA ID:";
            // 
            // tbOscaId
            // 
            this.tbOscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOscaId.Location = new System.Drawing.Point(177, 266);
            this.tbOscaId.Name = "tbOscaId";
            this.tbOscaId.Size = new System.Drawing.Size(198, 26);
            this.tbOscaId.TabIndex = 2;
            // 
            // btnAddSenior
            // 
            this.btnAddSenior.Location = new System.Drawing.Point(16, 373);
            this.btnAddSenior.Name = "btnAddSenior";
            this.btnAddSenior.Size = new System.Drawing.Size(359, 34);
            this.btnAddSenior.TabIndex = 4;
            this.btnAddSenior.Text = "ADD DATA";
            this.btnAddSenior.UseVisualStyleBackColor = true;
            this.btnAddSenior.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditSenior
            // 
            this.btnEditSenior.Location = new System.Drawing.Point(16, 413);
            this.btnEditSenior.Name = "btnEditSenior";
            this.btnEditSenior.Size = new System.Drawing.Size(359, 34);
            this.btnEditSenior.TabIndex = 4;
            this.btnEditSenior.Text = "UPDATE DATA";
            this.btnEditSenior.UseVisualStyleBackColor = true;
            this.btnEditSenior.Click += new System.EventHandler(this.btnEditSenior_Click);
            // 
            // btnDeleteSenior
            // 
            this.btnDeleteSenior.Location = new System.Drawing.Point(16, 453);
            this.btnDeleteSenior.Name = "btnDeleteSenior";
            this.btnDeleteSenior.Size = new System.Drawing.Size(359, 34);
            this.btnDeleteSenior.TabIndex = 4;
            this.btnDeleteSenior.Text = "DELETE DATA";
            this.btnDeleteSenior.UseVisualStyleBackColor = true;
            this.btnDeleteSenior.Click += new System.EventHandler(this.btnDeleteSenior_Click);
            // 
            // btnDeceasedSenior
            // 
            this.btnDeceasedSenior.Location = new System.Drawing.Point(16, 493);
            this.btnDeceasedSenior.Name = "btnDeceasedSenior";
            this.btnDeceasedSenior.Size = new System.Drawing.Size(173, 34);
            this.btnDeceasedSenior.TabIndex = 4;
            this.btnDeceasedSenior.Text = "MOVE TO DECEASED";
            this.btnDeceasedSenior.UseVisualStyleBackColor = true;
            this.btnDeceasedSenior.Click += new System.EventHandler(this.btnDeceasedSenior_Click);
            // 
            // btnWithdrawedSenior
            // 
            this.btnWithdrawedSenior.Location = new System.Drawing.Point(202, 493);
            this.btnWithdrawedSenior.Name = "btnWithdrawedSenior";
            this.btnWithdrawedSenior.Size = new System.Drawing.Size(173, 34);
            this.btnWithdrawedSenior.TabIndex = 4;
            this.btnWithdrawedSenior.Text = "MOVE TO WITHDRAWN";
            this.btnWithdrawedSenior.UseVisualStyleBackColor = true;
            this.btnWithdrawedSenior.Click += new System.EventHandler(this.btnWithdrawedSenior_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "ADMISSION DATE:";
            // 
            // tbAdmission
            // 
            this.tbAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdmission.Location = new System.Drawing.Point(177, 230);
            this.tbAdmission.Name = "tbAdmission";
            this.tbAdmission.Size = new System.Drawing.Size(198, 26);
            this.tbAdmission.TabIndex = 2;
            // 
            // tbClear
            // 
            this.tbClear.Location = new System.Drawing.Point(16, 333);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(359, 34);
            this.tbClear.TabIndex = 4;
            this.tbClear.Text = "CLEAR DATA";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "SEARCH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 39);
            this.label8.TabIndex = 27;
            this.label8.Text = "MASTERLIST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(768, -299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "MASTERLIST";
            // 
            // tbRefresh
            // 
            this.tbRefresh.Location = new System.Drawing.Point(842, 14);
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(98, 34);
            this.tbRefresh.TabIndex = 28;
            this.tbRefresh.Text = "REFRESH";
            this.tbRefresh.UseVisualStyleBackColor = false;
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(541, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "COUNT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "TOTAL MEMBERS:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "DATE OF WITHDRAWN:";
            // 
            // tbDateOfWithdrawn
            // 
            this.tbDateOfWithdrawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfWithdrawn.Location = new System.Drawing.Point(206, 298);
            this.tbDateOfWithdrawn.Name = "tbDateOfWithdrawn";
            this.tbDateOfWithdrawn.Size = new System.Drawing.Size(169, 26);
            this.tbDateOfWithdrawn.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(202, 533);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(173, 34);
            this.btnNext.TabIndex = 53;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 533);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(173, 34);
            this.btnPrev.TabIndex = 52;
            this.btnPrev.Text = "PREVIOUS";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // tbFullname
            // 
            this.tbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullname.Location = new System.Drawing.Point(117, 54);
            this.tbFullname.Multiline = true;
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(258, 52);
            this.tbFullname.TabIndex = 2;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirthday.Location = new System.Drawing.Point(117, 167);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(258, 26);
            this.tbBirthday.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(482, 17);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 54;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MasterlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(952, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.btnWithdrawedSenior);
            this.Controls.Add(this.btnDeceasedSenior);
            this.Controls.Add(this.btnDeleteSenior);
            this.Controls.Add(this.btnEditSenior);
            this.Controls.Add(this.btnAddSenior);
            this.Controls.Add(this.tbDateOfWithdrawn);
            this.Controls.Add(this.tbOscaId);
            this.Controls.Add(this.tbAdmission);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbFederationId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonitoring);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterlistForm";
            this.Load += new System.EventHandler(this.MasterlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFederationId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOscaId;
        private System.Windows.Forms.Button btnAddSenior;
        private System.Windows.Forms.Button btnEditSenior;
        private System.Windows.Forms.Button btnDeleteSenior;
        private System.Windows.Forms.Button btnDeceasedSenior;
        private System.Windows.Forms.Button btnWithdrawedSenior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdmission;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tbRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDateOfWithdrawn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
    }
}