
namespace EntityFramework
{
    partial class OrderForm_DBF
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrID = new System.Windows.Forms.TextBox();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.cbCusto = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtShipped_date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrequireddate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtxOrderdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderstatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(32, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 44);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.Green;
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(634, 11);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 27);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReload
            // 
            this.btReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReload.AutoSize = true;
            this.btReload.BackColor = System.Drawing.Color.Green;
            this.btReload.ForeColor = System.Drawing.SystemColors.Info;
            this.btReload.Location = new System.Drawing.Point(475, 11);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 27);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.AutoSize = true;
            this.btDelete.BackColor = System.Drawing.Color.Green;
            this.btDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btDelete.Location = new System.Drawing.Point(317, 11);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 27);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.AutoSize = true;
            this.btSave.BackColor = System.Drawing.Color.Green;
            this.btSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btSave.Location = new System.Drawing.Point(155, 11);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 27);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.AutoSize = true;
            this.btAdd.BackColor = System.Drawing.Color.Green;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btAdd.Location = new System.Drawing.Point(11, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 27);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(32, 273);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 113);
            this.dtGridView.TabIndex = 26;
            // 
            // grPanel
            // 
            this.grPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.txtOrID);
            this.grPanel.Controls.Add(this.cbStaff);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Controls.Add(this.cbStore);
            this.grPanel.Controls.Add(this.cbCusto);
            this.grPanel.Controls.Add(this.panel8);
            this.grPanel.Controls.Add(this.panel7);
            this.grPanel.Controls.Add(this.panel6);
            this.grPanel.Controls.Add(this.panel5);
            this.grPanel.Controls.Add(this.txtShipped_date);
            this.grPanel.Controls.Add(this.label10);
            this.grPanel.Controls.Add(this.txtrequireddate);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.txtxOrderdate);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.txtOrderstatus);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Location = new System.Drawing.Point(32, 59);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(736, 208);
            this.grPanel.TabIndex = 25;
            this.grPanel.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(111, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1);
            this.panel1.TabIndex = 37;
            // 
            // txtOrID
            // 
            this.txtOrID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtOrID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrID.Enabled = false;
            this.txtOrID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtOrID.Location = new System.Drawing.Point(111, 30);
            this.txtOrID.Name = "txtOrID";
            this.txtOrID.Size = new System.Drawing.Size(198, 15);
            this.txtOrID.TabIndex = 36;
            this.txtOrID.Leave += new System.EventHandler(this.txtOrID_Leave);
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(111, 153);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(121, 24);
            this.cbStaff.TabIndex = 37;
            this.cbStaff.Leave += new System.EventHandler(this.cbStaff_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Order_ID:";
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(111, 112);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(121, 24);
            this.cbStore.TabIndex = 36;
            this.cbStore.Leave += new System.EventHandler(this.cbStore_Leave);
            // 
            // cbCusto
            // 
            this.cbCusto.FormattingEnabled = true;
            this.cbCusto.Location = new System.Drawing.Point(111, 68);
            this.cbCusto.Name = "cbCusto";
            this.cbCusto.Size = new System.Drawing.Size(121, 24);
            this.cbCusto.TabIndex = 35;
            this.cbCusto.Leave += new System.EventHandler(this.cbCusto_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel8.ForeColor = System.Drawing.SystemColors.Info;
            this.panel8.Location = new System.Drawing.Point(445, 172);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(201, 1);
            this.panel8.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel7.ForeColor = System.Drawing.SystemColors.Info;
            this.panel7.Location = new System.Drawing.Point(445, 130);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 1);
            this.panel7.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.ForeColor = System.Drawing.SystemColors.Info;
            this.panel6.Location = new System.Drawing.Point(445, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 1);
            this.panel6.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.ForeColor = System.Drawing.SystemColors.Info;
            this.panel5.Location = new System.Drawing.Point(442, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 1);
            this.panel5.TabIndex = 34;
            // 
            // txtShipped_date
            // 
            this.txtShipped_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtShipped_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShipped_date.ForeColor = System.Drawing.SystemColors.Info;
            this.txtShipped_date.Location = new System.Drawing.Point(448, 156);
            this.txtShipped_date.Name = "txtShipped_date";
            this.txtShipped_date.Size = new System.Drawing.Size(198, 15);
            this.txtShipped_date.TabIndex = 7;
            this.txtShipped_date.Leave += new System.EventHandler(this.txtShipped_date_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(8, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Customers ID:";
            // 
            // txtrequireddate
            // 
            this.txtrequireddate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtrequireddate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrequireddate.ForeColor = System.Drawing.SystemColors.Info;
            this.txtrequireddate.Location = new System.Drawing.Point(445, 116);
            this.txtrequireddate.Name = "txtrequireddate";
            this.txtrequireddate.Size = new System.Drawing.Size(198, 15);
            this.txtrequireddate.TabIndex = 6;
            this.txtrequireddate.Leave += new System.EventHandler(this.txtrequireddate_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(15, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Staff ID:";
            // 
            // txtxOrderdate
            // 
            this.txtxOrderdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtxOrderdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxOrderdate.ForeColor = System.Drawing.SystemColors.Info;
            this.txtxOrderdate.Location = new System.Drawing.Point(445, 71);
            this.txtxOrderdate.Name = "txtxOrderdate";
            this.txtxOrderdate.Size = new System.Drawing.Size(198, 15);
            this.txtxOrderdate.TabIndex = 5;
            this.txtxOrderdate.Leave += new System.EventHandler(this.txtxOrderdate_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(15, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Store ID:";
            // 
            // txtOrderstatus
            // 
            this.txtOrderstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtOrderstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderstatus.ForeColor = System.Drawing.SystemColors.Info;
            this.txtOrderstatus.Location = new System.Drawing.Point(442, 30);
            this.txtOrderstatus.Name = "txtOrderstatus";
            this.txtOrderstatus.Size = new System.Drawing.Size(198, 15);
            this.txtOrderstatus.TabIndex = 4;
            this.txtOrderstatus.Leave += new System.EventHandler(this.txtOrderstatus_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(329, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Shipped_date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(328, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "required_date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(344, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order_date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(344, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order_status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 43);
            this.label1.TabIndex = 24;
            this.label1.Text = "UPDATE  ORDERS LIST";
            // 
            // OrderForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm_DBF";
            this.Text = "OrderForm_DBF";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrID;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.ComboBox cbCusto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtShipped_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtrequireddate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtxOrderdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}