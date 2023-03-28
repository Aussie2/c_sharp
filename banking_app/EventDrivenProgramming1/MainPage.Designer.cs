namespace EventDrivenProgramming1
{
    partial class MainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.Labeling = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnM0 = new System.Windows.Forms.Button();
            this.btnMStop = new System.Windows.Forms.Button();
            this.btnM9 = new System.Windows.Forms.Button();
            this.btnM8 = new System.Windows.Forms.Button();
            this.btnM7 = new System.Windows.Forms.Button();
            this.btnM6 = new System.Windows.Forms.Button();
            this.btnM5 = new System.Windows.Forms.Button();
            this.btnM4 = new System.Windows.Forms.Button();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM2 = new System.Windows.Forms.Button();
            this.btnM1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radioWithdrawal = new System.Windows.Forms.RadioButton();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.Labeling);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAccNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 93);
            this.panel1.TabIndex = 30;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(184, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "User Name";
            // 
            // Labeling
            // 
            this.Labeling.AutoSize = true;
            this.Labeling.Location = new System.Drawing.Point(34, 37);
            this.Labeling.Name = "Labeling";
            this.Labeling.Size = new System.Drawing.Size(35, 13);
            this.Labeling.TabIndex = 26;
            this.Labeling.Text = "Name";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(184, 61);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 29;
            this.lblBalance.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Balance";
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Location = new System.Drawing.Point(184, 9);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(33, 13);
            this.lblAccNumber.TabIndex = 25;
            this.lblAccNumber.Text = "Acc#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 334);
            this.panel2.TabIndex = 32;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(460, 278);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 44);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnMC, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnM0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMStop, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnM9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnM8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnM7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnM6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnM5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnM4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnM3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnM2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnM1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMC
            // 
            this.btnMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMC.Location = new System.Drawing.Point(298, 252);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(138, 76);
            this.btnMC.TabIndex = 15;
            this.btnMC.Text = "Clear";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnM0
            // 
            this.btnM0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM0.Location = new System.Drawing.Point(152, 252);
            this.btnM0.Name = "btnM0";
            this.btnM0.Size = new System.Drawing.Size(137, 76);
            this.btnM0.TabIndex = 14;
            this.btnM0.Text = "0";
            this.btnM0.UseVisualStyleBackColor = true;
            this.btnM0.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnMStop
            // 
            this.btnMStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMStop.Location = new System.Drawing.Point(6, 252);
            this.btnMStop.Name = "btnMStop";
            this.btnMStop.Size = new System.Drawing.Size(137, 76);
            this.btnMStop.TabIndex = 13;
            this.btnMStop.Text = ".";
            this.btnMStop.UseVisualStyleBackColor = true;
            this.btnMStop.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM9
            // 
            this.btnM9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM9.Location = new System.Drawing.Point(298, 170);
            this.btnM9.Name = "btnM9";
            this.btnM9.Size = new System.Drawing.Size(138, 73);
            this.btnM9.TabIndex = 12;
            this.btnM9.Text = "9";
            this.btnM9.UseVisualStyleBackColor = true;
            this.btnM9.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM8
            // 
            this.btnM8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM8.Location = new System.Drawing.Point(152, 170);
            this.btnM8.Name = "btnM8";
            this.btnM8.Size = new System.Drawing.Size(137, 73);
            this.btnM8.TabIndex = 11;
            this.btnM8.Text = "8";
            this.btnM8.UseVisualStyleBackColor = true;
            this.btnM8.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM7
            // 
            this.btnM7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM7.Location = new System.Drawing.Point(6, 170);
            this.btnM7.Name = "btnM7";
            this.btnM7.Size = new System.Drawing.Size(137, 73);
            this.btnM7.TabIndex = 10;
            this.btnM7.Text = "7";
            this.btnM7.UseVisualStyleBackColor = true;
            this.btnM7.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM6
            // 
            this.btnM6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM6.Location = new System.Drawing.Point(298, 88);
            this.btnM6.Name = "btnM6";
            this.btnM6.Size = new System.Drawing.Size(138, 73);
            this.btnM6.TabIndex = 9;
            this.btnM6.Text = "6";
            this.btnM6.UseVisualStyleBackColor = true;
            this.btnM6.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM5
            // 
            this.btnM5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM5.Location = new System.Drawing.Point(152, 88);
            this.btnM5.Name = "btnM5";
            this.btnM5.Size = new System.Drawing.Size(137, 73);
            this.btnM5.TabIndex = 8;
            this.btnM5.Text = "5";
            this.btnM5.UseVisualStyleBackColor = true;
            this.btnM5.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM4
            // 
            this.btnM4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM4.Location = new System.Drawing.Point(6, 88);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(137, 73);
            this.btnM4.TabIndex = 7;
            this.btnM4.Text = "4";
            this.btnM4.UseVisualStyleBackColor = true;
            this.btnM4.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM3
            // 
            this.btnM3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM3.Location = new System.Drawing.Point(298, 6);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(138, 73);
            this.btnM3.TabIndex = 5;
            this.btnM3.Text = "3";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM2
            // 
            this.btnM2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM2.Location = new System.Drawing.Point(152, 6);
            this.btnM2.Name = "btnM2";
            this.btnM2.Size = new System.Drawing.Size(137, 73);
            this.btnM2.TabIndex = 4;
            this.btnM2.Text = "2";
            this.btnM2.UseVisualStyleBackColor = true;
            this.btnM2.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // btnM1
            // 
            this.btnM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnM1.Location = new System.Drawing.Point(6, 6);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(137, 73);
            this.btnM1.TabIndex = 3;
            this.btnM1.Text = "1";
            this.btnM1.UseVisualStyleBackColor = true;
            this.btnM1.Click += new System.EventHandler(this.btnTouchpad_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.radioWithdrawal);
            this.panel3.Controls.Add(this.radioDeposit);
            this.panel3.Controls.Add(this.btnExecute);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 91);
            this.panel3.TabIndex = 31;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(257, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 13);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Transaction Status";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(149, 52);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(293, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextChanged += new System.EventHandler(this.TxtBoxes_TextChanged);
            // 
            // radioWithdrawal
            // 
            this.radioWithdrawal.AutoSize = true;
            this.radioWithdrawal.Location = new System.Drawing.Point(37, 55);
            this.radioWithdrawal.Name = "radioWithdrawal";
            this.radioWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.radioWithdrawal.TabIndex = 19;
            this.radioWithdrawal.Text = "Withdrawal";
            this.radioWithdrawal.UseVisualStyleBackColor = true;
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Checked = true;
            this.radioDeposit.Location = new System.Drawing.Point(37, 32);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(61, 17);
            this.radioDeposit.TabIndex = 18;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(460, 16);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(82, 56);
            this.btnExecute.TabIndex = 17;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Execute Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Transaction Type";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 518);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            //this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton radioWithdrawal;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnM0;
        private System.Windows.Forms.Button btnMStop;
        private System.Windows.Forms.Button btnM9;
        private System.Windows.Forms.Button btnM8;
        private System.Windows.Forms.Button btnM7;
        private System.Windows.Forms.Button btnM6;
        private System.Windows.Forms.Button btnM5;
        private System.Windows.Forms.Button btnM4;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM2;
        private System.Windows.Forms.Button btnM1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Labeling;
        private System.Windows.Forms.Label lblStatus;
    }
}