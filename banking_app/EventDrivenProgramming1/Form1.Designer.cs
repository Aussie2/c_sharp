namespace EventDrivenProgramming1
{
    partial class Login
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLBackSpace = new System.Windows.Forms.Button();
            this.btnL0 = new System.Windows.Forms.Button();
            this.btnL9 = new System.Windows.Forms.Button();
            this.btnL8 = new System.Windows.Forms.Button();
            this.btnL7 = new System.Windows.Forms.Button();
            this.btnL6 = new System.Windows.Forms.Button();
            this.btnL5 = new System.Windows.Forms.Button();
            this.btnL4 = new System.Windows.Forms.Button();
            this.btnL3 = new System.Windows.Forms.Button();
            this.btnL2 = new System.Windows.Forms.Button();
            this.btnL1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPin);
            this.panel1.Controls.Add(this.txtAccNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 112);
            this.panel1.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(168, 73);
            this.txtPin.MaxLength = 5;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(113, 20);
            this.txtPin.TabIndex = 1;
            this.txtPin.Enter += new System.EventHandler(this.txtPin_Enter);
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(168, 34);
            this.txtAccNum.MaxLength = 10;
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(113, 20);
            this.txtAccNum.TabIndex = 0;
            this.txtAccNum.TextChanged += new System.EventHandler(this.TxtBoxes_TextChanged);
            this.txtAccNum.Enter += new System.EventHandler(this.txtAccNum_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 322);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnLBackSpace, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnL0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnL9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnL8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnL7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnL6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnL5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnL4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnL3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnL2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnL1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLBackSpace
            // 
            this.btnLBackSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLBackSpace.Location = new System.Drawing.Point(256, 243);
            this.btnLBackSpace.Name = "btnLBackSpace";
            this.btnLBackSpace.Size = new System.Drawing.Size(116, 73);
            this.btnLBackSpace.TabIndex = 13;
            this.btnLBackSpace.Text = "Clear";
            this.btnLBackSpace.UseVisualStyleBackColor = true;
            this.btnLBackSpace.Click += new System.EventHandler(this.btnLBackSpace_Click);
            // 
            // btnL0
            // 
            this.btnL0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL0.Location = new System.Drawing.Point(131, 243);
            this.btnL0.Name = "btnL0";
            this.btnL0.Size = new System.Drawing.Size(116, 73);
            this.btnL0.TabIndex = 12;
            this.btnL0.Text = "0";
            this.btnL0.UseVisualStyleBackColor = true;
            this.btnL0.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL9
            // 
            this.btnL9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL9.Location = new System.Drawing.Point(256, 164);
            this.btnL9.Name = "btnL9";
            this.btnL9.Size = new System.Drawing.Size(116, 70);
            this.btnL9.TabIndex = 10;
            this.btnL9.Text = "9";
            this.btnL9.UseVisualStyleBackColor = true;
            this.btnL9.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL8
            // 
            this.btnL8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL8.Location = new System.Drawing.Point(131, 164);
            this.btnL8.Name = "btnL8";
            this.btnL8.Size = new System.Drawing.Size(116, 70);
            this.btnL8.TabIndex = 9;
            this.btnL8.Text = "8";
            this.btnL8.UseVisualStyleBackColor = true;
            this.btnL8.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL7
            // 
            this.btnL7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL7.Location = new System.Drawing.Point(6, 164);
            this.btnL7.Name = "btnL7";
            this.btnL7.Size = new System.Drawing.Size(116, 70);
            this.btnL7.TabIndex = 8;
            this.btnL7.Text = "7";
            this.btnL7.UseVisualStyleBackColor = true;
            this.btnL7.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL6
            // 
            this.btnL6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL6.Location = new System.Drawing.Point(256, 85);
            this.btnL6.Name = "btnL6";
            this.btnL6.Size = new System.Drawing.Size(116, 70);
            this.btnL6.TabIndex = 7;
            this.btnL6.Text = "6";
            this.btnL6.UseVisualStyleBackColor = true;
            this.btnL6.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL5
            // 
            this.btnL5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL5.Location = new System.Drawing.Point(131, 85);
            this.btnL5.Name = "btnL5";
            this.btnL5.Size = new System.Drawing.Size(116, 70);
            this.btnL5.TabIndex = 6;
            this.btnL5.Text = "5";
            this.btnL5.UseVisualStyleBackColor = true;
            this.btnL5.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL4
            // 
            this.btnL4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL4.Location = new System.Drawing.Point(6, 85);
            this.btnL4.Name = "btnL4";
            this.btnL4.Size = new System.Drawing.Size(116, 70);
            this.btnL4.TabIndex = 5;
            this.btnL4.Text = "4";
            this.btnL4.UseVisualStyleBackColor = true;
            this.btnL4.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL3
            // 
            this.btnL3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL3.Location = new System.Drawing.Point(256, 6);
            this.btnL3.Name = "btnL3";
            this.btnL3.Size = new System.Drawing.Size(116, 70);
            this.btnL3.TabIndex = 4;
            this.btnL3.Text = "3";
            this.btnL3.UseVisualStyleBackColor = true;
            this.btnL3.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL2
            // 
            this.btnL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL2.Location = new System.Drawing.Point(131, 6);
            this.btnL2.Name = "btnL2";
            this.btnL2.Size = new System.Drawing.Size(116, 70);
            this.btnL2.TabIndex = 3;
            this.btnL2.Text = "2";
            this.btnL2.UseVisualStyleBackColor = true;
            this.btnL2.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnL1
            // 
            this.btnL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnL1.Location = new System.Drawing.Point(6, 6);
            this.btnL1.Name = "btnL1";
            this.btnL1.Size = new System.Drawing.Size(116, 70);
            this.btnL1.TabIndex = 2;
            this.btnL1.Text = "1";
            this.btnL1.UseVisualStyleBackColor = true;
            this.btnL1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 68);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 51);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLBackSpace;
        private System.Windows.Forms.Button btnL0;
        private System.Windows.Forms.Button btnL9;
        private System.Windows.Forms.Button btnL8;
        private System.Windows.Forms.Button btnL7;
        private System.Windows.Forms.Button btnL6;
        private System.Windows.Forms.Button btnL5;
        private System.Windows.Forms.Button btnL4;
        private System.Windows.Forms.Button btnL3;
        private System.Windows.Forms.Button btnL2;
        private System.Windows.Forms.Button btnL1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

