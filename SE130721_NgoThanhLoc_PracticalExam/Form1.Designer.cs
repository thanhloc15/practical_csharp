namespace SE130721_NgoThanhLoc_PracticalExam
{
    partial class Form1
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
            this.ListViewDepartment = new System.Windows.Forms.ListView();
            this.depNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mgrSSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mgrAssDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labal4 = new System.Windows.Forms.Label();
            this.txtDepNum = new System.Windows.Forms.TextBox();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.txtmgrSSN = new System.Windows.Forms.TextBox();
            this.txtmgrAssDate = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewDepartment
            // 
            this.ListViewDepartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depNum,
            this.depName,
            this.mgrSSN,
            this.mgrAssDate});
            this.ListViewDepartment.HideSelection = false;
            this.ListViewDepartment.Location = new System.Drawing.Point(12, 22);
            this.ListViewDepartment.Name = "ListViewDepartment";
            this.ListViewDepartment.Size = new System.Drawing.Size(603, 351);
            this.ListViewDepartment.TabIndex = 0;
            this.ListViewDepartment.UseCompatibleStateImageBehavior = false;
            this.ListViewDepartment.View = System.Windows.Forms.View.Details;
            this.ListViewDepartment.SelectedIndexChanged += new System.EventHandler(this.ListViewDepartment_SelectedIndexChanged);
            // 
            // depNum
            // 
            this.depNum.Text = "depNum";
            // 
            // depName
            // 
            this.depName.Text = "depName";
            this.depName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depName.Width = 250;
            // 
            // mgrSSN
            // 
            this.mgrSSN.Text = "mgrSSN";
            this.mgrSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mgrSSN.Width = 150;
            // 
            // mgrAssDate
            // 
            this.mgrAssDate.Text = "mgrAssDate";
            this.mgrAssDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mgrAssDate.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmgrAssDate);
            this.groupBox1.Controls.Add(this.txtmgrSSN);
            this.groupBox1.Controls.Add(this.txtDepName);
            this.groupBox1.Controls.Add(this.txtDepNum);
            this.groupBox1.Controls.Add(this.labal4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(627, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "depNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "depName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mgrSSN";
            // 
            // labal4
            // 
            this.labal4.AutoSize = true;
            this.labal4.Location = new System.Drawing.Point(6, 182);
            this.labal4.Name = "labal4";
            this.labal4.Size = new System.Drawing.Size(64, 13);
            this.labal4.TabIndex = 3;
            this.labal4.Text = "mgrAssDate";
            this.labal4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDepNum
            // 
            this.txtDepNum.Location = new System.Drawing.Point(76, 26);
            this.txtDepNum.Name = "txtDepNum";
            this.txtDepNum.Size = new System.Drawing.Size(137, 20);
            this.txtDepNum.TabIndex = 4;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(76, 73);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(137, 20);
            this.txtDepName.TabIndex = 5;
            // 
            // txtmgrSSN
            // 
            this.txtmgrSSN.Location = new System.Drawing.Point(76, 128);
            this.txtmgrSSN.Name = "txtmgrSSN";
            this.txtmgrSSN.Size = new System.Drawing.Size(137, 20);
            this.txtmgrSSN.TabIndex = 6;
            // 
            // txtmgrAssDate
            // 
            this.txtmgrAssDate.Location = new System.Drawing.Point(76, 179);
            this.txtmgrAssDate.Name = "txtmgrAssDate";
            this.txtmgrAssDate.Size = new System.Drawing.Size(137, 20);
            this.txtmgrAssDate.TabIndex = 7;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(639, 319);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(735, 319);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 3;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(836, 319);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(639, 359);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(735, 359);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListViewDepartment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewDepartment;
        private System.Windows.Forms.ColumnHeader depNum;
        private System.Windows.Forms.ColumnHeader depName;
        private System.Windows.Forms.ColumnHeader mgrSSN;
        private System.Windows.Forms.ColumnHeader mgrAssDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmgrAssDate;
        private System.Windows.Forms.TextBox txtmgrSSN;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.TextBox txtDepNum;
        private System.Windows.Forms.Label labal4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnExit;
    }
}

