namespace Result
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObtainedMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResultDetails = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDivision = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalMark = new System.Windows.Forms.Label();
            this.lblObtainedTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.txtObtainedMark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassMark);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotalMark);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marks Entry ";
            // 
            // txtObtainedMark
            // 
            this.txtObtainedMark.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObtainedMark.Location = new System.Drawing.Point(616, 73);
            this.txtObtainedMark.Name = "txtObtainedMark";
            this.txtObtainedMark.Size = new System.Drawing.Size(135, 36);
            this.txtObtainedMark.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Obtained Mark:";
            // 
            // txtPassMark
            // 
            this.txtPassMark.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassMark.Location = new System.Drawing.Point(142, 70);
            this.txtPassMark.Name = "txtPassMark";
            this.txtPassMark.Size = new System.Drawing.Size(153, 36);
            this.txtPassMark.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass Mark:";
            // 
            // txtTotalMark
            // 
            this.txtTotalMark.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMark.Location = new System.Drawing.Point(616, 19);
            this.txtTotalMark.Name = "txtTotalMark";
            this.txtTotalMark.Size = new System.Drawing.Size(135, 36);
            this.txtTotalMark.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Mark:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(176, 19);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(254, 36);
            this.txtSubjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvResultDetails);
            this.panel1.Location = new System.Drawing.Point(12, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 191);
            this.panel1.TabIndex = 1;
            // 
            // dgvResultDetails
            // 
            this.dgvResultDetails.AllowUserToAddRows = false;
            this.dgvResultDetails.AllowUserToDeleteRows = false;
            this.dgvResultDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultDetails.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvResultDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SubjectName,
            this.TotalMark,
            this.PassMark,
            this.ObtainedMark});
            this.dgvResultDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvResultDetails.MultiSelect = false;
            this.dgvResultDetails.Name = "dgvResultDetails";
            this.dgvResultDetails.ReadOnly = true;
            this.dgvResultDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultDetails.Size = new System.Drawing.Size(834, 191);
            this.dgvResultDetails.TabIndex = 0;
            // 
            // SNO
            // 
            this.SNO.HeaderText = "S.No";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // TotalMark
            // 
            this.TotalMark.HeaderText = "Total Mark";
            this.TotalMark.Name = "TotalMark";
            this.TotalMark.ReadOnly = true;
            // 
            // PassMark
            // 
            this.PassMark.HeaderText = "Pass Mark";
            this.PassMark.Name = "PassMark";
            this.PassMark.ReadOnly = true;
            // 
            // ObtainedMark
            // 
            this.ObtainedMark.HeaderText = "Obtained Mark";
            this.ObtainedMark.Name = "ObtainedMark";
            this.ObtainedMark.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add To Mark Sheet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(306, 148);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(260, 26);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Result";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDivision);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPercent);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 67);
            this.panel2.TabIndex = 4;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(460, 19);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(49, 28);
            this.lblDivision.TabIndex = 3;
            this.lblDivision.Text = "n/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Division:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(168, 19);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(49, 28);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "n/a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Percentage:";
            // 
            // lblTotalMark
            // 
            this.lblTotalMark.AutoSize = true;
            this.lblTotalMark.Location = new System.Drawing.Point(397, 378);
            this.lblTotalMark.Name = "lblTotalMark";
            this.lblTotalMark.Size = new System.Drawing.Size(18, 19);
            this.lblTotalMark.TabIndex = 5;
            this.lblTotalMark.Text = "0";
            // 
            // lblObtainedTotal
            // 
            this.lblObtainedTotal.AutoSize = true;
            this.lblObtainedTotal.Location = new System.Drawing.Point(732, 382);
            this.lblObtainedTotal.Name = "lblObtainedTotal";
            this.lblObtainedTotal.Size = new System.Drawing.Size(18, 19);
            this.lblObtainedTotal.TabIndex = 6;
            this.lblObtainedTotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 497);
            this.Controls.Add(this.lblObtainedTotal);
            this.Controls.Add(this.lblTotalMark);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvResultDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMark;
        private System.Windows.Forms.TextBox txtObtainedMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalMark;
        private System.Windows.Forms.Label lblObtainedTotal;
    }
}

